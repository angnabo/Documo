using System;
using System.Collections.Generic;
using Documo.Services;
using Documo.Visitor;
using HtmlAgilityPack;
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

        public void ProcessPlaceholders(HtmlDocument doc, DocumentPlaceholder placeholder, object jsonData)
        {
            //get repeating section start node
            //get repeating section end node
            var repeatingSectionPlaceholder = (RepeatingSection) placeholder;
            var startNode = HtmlNodeExtractor.SelectSinglePlaceholderNode(doc, repeatingSectionPlaceholder.GetPlaceholder());
            var endNode = HtmlNodeExtractor.SelectSinglePlaceholderNode(doc, repeatingSectionPlaceholder.GetEndPlaceholder());
            
            var htmlNodeCollection = new HtmlNodeCollection(startNode.ParentNode);

            var nextNode = startNode.NextSibling;
            
            //get html between start and end node
            while (nextNode?.OuterHtml != endNode.OuterHtml)
            {
                htmlNodeCollection.Add(nextNode);

                nextNode = nextNode?.NextSibling;
            }
            
            var resolver = new Resolver();
            var array = (object[])resolver.Resolve(jsonData, placeholder.ObjectName); //services array

            for (var i = 0; i < array.Length; i++)
            {
                foreach (var htmlNode in htmlNodeCollection)
                {
                    var nodeDoc = new HtmlDocument();
                    nodeDoc.LoadHtml(htmlNode.OuterHtml);
                
                    var placeholders = HtmlNodeExtractor.ExtractNodeOuterHtml(nodeDoc, "//p[@class='placeholder']");
                    var input = string.Join("", placeholders);
                    var antlrService = new AntlrService();
                    var parsedPlaceholders = antlrService.Parse(input); // inner table placeholders
                    
                    foreach (var p in parsedPlaceholders)
                    {  
                        var placeholderNodes = HtmlNodeExtractor.SelectPlaceholderNodes(nodeDoc, p.GetPlaceholder());
                        
                        if (placeholderNodes == null) continue;
                        
                        foreach (var placeholderNode in placeholderNodes)
                        {
                            if (AppliesTo(p))
                            {
                                ProcessPlaceholders(nodeDoc, p, jsonData);
                            }
                            else
                            {
                                var value = resolver.Resolve(array, $"[{i}].{p.ObjectName}").ToString();
                                HtmlNodeProcessor.ProcessPlaceholderNode(placeholderNode, value);
                            }
                        }
                    }

                    var n = HtmlNode.CreateNode(nodeDoc.DocumentNode.OuterHtml);
                    var d = endNode.ParentNode.ChildNodes[endNode];
                    Console.WriteLine("Processing: " + n.OuterHtml + ", " + n.InnerHtml + ", " + n.InnerText);
                    
                    endNode.ParentNode.InsertAfter(n, endNode);
                }

            }
            startNode.ParentNode.RemoveChild(startNode);
            endNode.ParentNode.RemoveChild(endNode);
            foreach (var h in htmlNodeCollection)
            {
                h.ParentNode.RemoveChild(h);
            }
        }


    }
}