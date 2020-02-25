using System;
using System.Collections.Generic;
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
            var dataType = data.GetType();
            try
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
                        ProcessNodes(doc, node, jsonData);
                    }
                    
                    startNode.Remove();
                    endNode.Remove();
                }
            }
            catch (InvalidCastException e)
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
                        if (node.ClassList.Contains("placeholder") || node.Children.Any(x => x.ClassList.Contains("placeholder")))
                        {
                            ProcessNodes(doc, node, jsonData);
                        }
                    }
                    
                    startNode.Remove();
                    endNode.Remove();
                }
            }
        }
        private void ProcessNodes(IElement doc, IElement node, object jsonData)
        {
            var placeholdersFromNode = HtmlNodeExtractor.GetPlaceholderNodes(node).Select(x => x.TextContent.Trim()).ToList();
            var placeholders = new List<string>();
            
            if (node.ClassList.Contains("placeholder"))
            {
                placeholders.Add(node.TextContent.Trim());
            }
            
            placeholders.AddRange(placeholdersFromNode);
                    
            var input = string.Join("", placeholders);
                    
            var parsedPlaceholders = AntlrService.Parse(input); // inner table placeholders
                    
            foreach (var parsedPlaceholder in parsedPlaceholders)
            {  
                    var placeholderStrategies = PlaceholderStrategies.Get();
                    var strategy = placeholderStrategies.SingleOrDefault(x => x.AppliesTo(parsedPlaceholder));
                    strategy?.ProcessPlaceholders(doc, parsedPlaceholder, jsonData); 
                
            }
        }
        
    }
}