using System;
using System.Collections.Generic;
using System.Linq;
using AngleSharp;
using AngleSharp.Dom;
using AngleSharp.Html.Parser;
using Documo.Services;
using Documo.Visitor;
using Pather.CSharp;

namespace Documo.Strategies
{
    public class ProcessRepeatingSectionPlaceholders : IProcessPlaceholder
    {
        private readonly List<IProcessPlaceholder> _placeholderStrategies = new List<IProcessPlaceholder>();
        public ProcessRepeatingSectionPlaceholders()
        {
            _placeholderStrategies.Add(new ProcessObjectPlaceholder());
        }
        
        public bool AppliesTo(DocumentPlaceholder placeholder)
        {
            return placeholder.GetType() == typeof(RepeatingSection);
        }

        public void ProcessPlaceholders(IDocument doc, DocumentPlaceholder placeholder, object jsonData)
        {
            //get repeating section start node
            //get repeating section end node
            var repeatingSectionPlaceholder = (RepeatingSection) placeholder;
            var startNode = doc.QuerySelectorAll("p.placeholder").Single(x => x.TextContent == repeatingSectionPlaceholder.GetPlaceholder());
            var endNode = doc.QuerySelectorAll("p.placeholder").Single(x => x.TextContent == repeatingSectionPlaceholder.GetEndPlaceholder());
            
            var nodes = new List<IElement>();

            var nextNode = startNode.NextElementSibling;
            
            //get html between start and end node
            while (nextNode?.OuterHtml != endNode.OuterHtml)
            {
                nodes.Add(nextNode);

                nextNode = nextNode?.NextElementSibling;
            }
            
            var resolver = new Resolver();
            var array = (object[])resolver.Resolve(jsonData, placeholder.ObjectName); //services array

            for (var i = 0; i < array.Length; i++)
            {
                foreach (var htmlNode in nodes)
                {
                    var config = Configuration.Default;
                    var context = BrowsingContext.New(config);
                    var parser = context.GetService<IHtmlParser>();
                    var nodeDoc = parser.ParseDocument(htmlNode.OuterHtml);
                    var placeholders = nodeDoc.QuerySelectorAll("p.placeholder").Select(x => x.OuterHtml);
                    
                    var input = string.Join("", placeholders);
                    var antlrService = new AntlrService();
                    var parsedPlaceholders = antlrService.Parse(input); // inner table placeholders
                    
                    foreach (var p in parsedPlaceholders)
                    {  
                        var placeholderNodes = nodeDoc.QuerySelectorAll("p.placeholder").Where(x => x.TextContent == p.GetPlaceholder());
                        
                        if (!placeholderNodes.Any()) continue;
                        
                        foreach (var placeholderNode in placeholderNodes)
                        {
                            if (AppliesTo(p))
                            {
                                ProcessPlaceholders(nodeDoc, p, jsonData);
                            }
                            else
                            {
                                var value = resolver.Resolve(array, $"[{i}].{p.ObjectName}").ToString();

                                placeholderNode.TextContent = value;
                            }
                        }
                    }

                    //var n = HtmlNode.CreateNode(nodeDoc.ToHtml());
                    //Console.WriteLine("Processing: " + n.OuterHtml + ", " + n.InnerHtml + ", " + n.InnerText);

                    endNode.AppendNodes(nodeDoc.DocumentElement);
                }

            }

//            startNode.Remove();
//            endNode.Remove();
//            foreach (var h in nodes)
//            {
//                h.Remove();
//            }
        }


    }
}