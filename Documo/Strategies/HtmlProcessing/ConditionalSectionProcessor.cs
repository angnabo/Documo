using System;
using System.Linq;
using AngleSharp.Dom;
using Documo.Services;
using Documo.Visitor;

namespace Documo.Strategies.HtmlProcessing
{
    public class ConditionalSectionProcessor : IProcessPlaceholder
    {
        public bool AppliesTo(DocumentPlaceholder placeholder)
        {
            return placeholder.GetType() == typeof(ConditionalPlaceholder);
        }

        public void ProcessPlaceholders(IElement doc, DocumentPlaceholder placeholder, object jsonData)
        {
            //get data from json
            var data = JsonResolver.Resolve(jsonData, placeholder.ObjectName);
            //if data is object - check if null - if not null do object access
            //if data is array - check if null - if not null do repeating section
            if (data.GetType() == typeof(object[]))
            {
                var dataArray = (object[]) data;
                if (dataArray.Any())
                {
                    var repeatingSectionPlaceholder = (ConditionalPlaceholder) placeholder;
                    var startNode = HtmlNodeExtractor.GetSinglePlaceholderNode(doc, repeatingSectionPlaceholder.GetPlaceholder());
                    var endNode = HtmlNodeExtractor.GetSinglePlaceholderNode(doc, repeatingSectionPlaceholder.GetEndPlaceholder());

                    var nodes = HtmlNodeExtractor.GetNodesBetweenStartAndEnd(startNode, endNode);
                    //foreach node
                    foreach (var node in nodes)
                    {
                        ProcessNodes(node, jsonData);
                    }
                    
                    startNode.Remove();
                    endNode.Remove();
                    foreach (var h in nodes)
                    {
                        h.Remove();
                    }
                }
            }
            else
            {
                if (data != null)
                {
                    var repeatingSectionPlaceholder = (ConditionalPlaceholder) placeholder;
                    var startNode = HtmlNodeExtractor.GetSinglePlaceholderNode(doc, repeatingSectionPlaceholder.GetPlaceholder());
                    var endNode = HtmlNodeExtractor.GetSinglePlaceholderNode(doc, repeatingSectionPlaceholder.GetEndPlaceholder());

                    var nodes = HtmlNodeExtractor.GetNodesBetweenStartAndEnd(startNode, endNode);
                    //foreach node
                    foreach (var node in nodes)
                    {
                        ProcessNodes(node, jsonData);
                    }
                    
                    startNode.Remove();
                    endNode.Remove();
                    foreach (var h in nodes)
                    {
                        h.Remove();
                    }
                }
            }
        }
        private void ProcessNodes(IElement node, object jsonData){
            var placeholders = HtmlNodeExtractor.GetPlaceholderNodes(node).Select(x => x.TextContent.Trim());
                    
            var input = string.Join("", placeholders);
                    
            var parsedPlaceholders = AntlrService.Parse(input); // inner table placeholders
                    
            foreach (var parsedPlaceholder in parsedPlaceholders)
            {  
                var placeholderNodes = HtmlNodeExtractor.GetPlaceholderNodes(node, parsedPlaceholder.GetPlaceholder()).ToArray();
                        
                if (!placeholderNodes.Any()) continue;
                        
                foreach (var placeholderNode in placeholderNodes)
                {
                    var placeholderStrategies = PlaceholderStrategies.Get();
                    var strategy = placeholderStrategies.SingleOrDefault(x => x.AppliesTo(parsedPlaceholder));
                    strategy?.ProcessPlaceholders(placeholderNode, parsedPlaceholder, jsonData); 
                }
            }
        }
        
    }
}