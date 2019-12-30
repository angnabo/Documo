using System;
using System.Collections.Generic;
using System.Linq;
using AngleSharp;
using AngleSharp.Dom;
using AngleSharp.Html.Dom;
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

        public void ProcessPlaceholders(IElement doc, DocumentPlaceholder placeholder, object jsonData)
        {
            var repeatingSectionPlaceholder = (RepeatingSection) placeholder;
            var startNode = HtmlNodeExtractor.SelectSinglePlaceholderElements(doc, repeatingSectionPlaceholder.GetPlaceholder());
            var endNode = HtmlNodeExtractor.SelectSinglePlaceholderElements(doc, repeatingSectionPlaceholder.GetEndPlaceholder());
            
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
                    var placeholders = HtmlNodeExtractor.SelectPlaceholderElements(htmlNode).Select(x => x.OuterHtml);
                    
                    var input = string.Join("", placeholders);
                    var antlrService = new AntlrService();
                    var parsedPlaceholders = antlrService.Parse(input); // inner table placeholders
                    
                    foreach (var p in parsedPlaceholders)
                    {  
                        var placeholderNodes = HtmlNodeExtractor.SelectPlaceholderElements(htmlNode, p.GetPlaceholder()).ToArray();
                        
                        if (!placeholderNodes.Any()) continue;
                        
                        foreach (var placeholderNode in placeholderNodes)
                        {
                            if (AppliesTo(p))
                            {
                                ProcessPlaceholders(htmlNode, p, jsonData);
                            }
                            else
                            {
                                var value = resolver.Resolve(array, $"[{i}].{p.ObjectName}").ToString();
                                placeholderNode.TextContent = value;
                            }
                        }
                    }

                    endNode.InsertAfter(htmlNode.Clone());
                }

            }

            startNode.Remove();
            endNode.Remove();
            foreach (var h in nodes)
            {
                h.Remove();
            }
        }
            
        private void removePlaceholderNodes(IElement doc){
    
        }
    }

}