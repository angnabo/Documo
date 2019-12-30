using System.Collections.Generic;
using System.Linq;
using AngleSharp.Dom;
using Documo.Services;
using Documo.Visitor;
using Pather.CSharp;

namespace Documo.Strategies
{
    public class ProcessRepeatingSectionPlaceholders : IProcessPlaceholder
    {
        private readonly IPlaceholderProcessor _placeholderProcessor;
        public ProcessRepeatingSectionPlaceholders()
        {
            _placeholderProcessor = new PlaceholderProcessor();
        }
        
        public bool AppliesTo(DocumentPlaceholder placeholder)
        {
            return placeholder.GetType() == typeof(RepeatingSection);
        }
        
        //TODO break down
        public void ProcessPlaceholders(IElement doc, DocumentPlaceholder placeholder, object jsonData)
        {
            var repeatingSectionPlaceholder = (RepeatingSection) placeholder;
            var startNode = HtmlNodeExtractor.GetSinglePlaceholderNode(doc, repeatingSectionPlaceholder.GetPlaceholder());
            var endNode = HtmlNodeExtractor.GetSinglePlaceholderNode(doc, repeatingSectionPlaceholder.GetEndPlaceholder());

            var nodes = GetNodesBetweenStartAndEnd(startNode, endNode).ToArray();
            
            var resolver = new Resolver();
            var array = (object[])resolver.Resolve(jsonData, placeholder.ObjectName);

            for (var i = 0; i < array.Length; i++)
            {
                foreach (var htmlNode in nodes)
                {
                    var placeholders = HtmlNodeExtractor.GetPlaceholderNodes(htmlNode).Select(x => x.OuterHtml);
                    
                    var input = string.Join("", placeholders);
                    
                    var parsedPlaceholders = AntlrService.Parse(input); // inner table placeholders
                    
                    foreach (var p in parsedPlaceholders)
                    {  
                        var placeholderNodes = HtmlNodeExtractor.GetPlaceholderNodes(htmlNode, p.GetPlaceholder()).ToArray();
                        
                        if (!placeholderNodes.Any()) continue;
                        
                        foreach (var placeholderNode in placeholderNodes)
                        {
                            if (AppliesTo(p))
                            {
                                ProcessPlaceholders(htmlNode, p, jsonData);
                            }
                            else
                            {
                                var value = JsonResolver.Resolve(array, $"[{i}].{p.GetPlaceholder()}");
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

        private IEnumerable<IElement> GetNodesBetweenStartAndEnd(IElement startNode, IElement endNode)
        {
            var nodes = new List<IElement>();

            var nextNode = startNode.NextElementSibling;
            
            //get html between start and end node
            while (nextNode?.OuterHtml != endNode.OuterHtml)
            {
                nodes.Add(nextNode);
                nextNode = nextNode?.NextElementSibling;
            }

            return nodes;
        }
    }

}