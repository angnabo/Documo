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
            var repeatingSectionPlaceholder = (ConditionalPlaceholder) placeholder;
            
            var startNode = HtmlNodeExtractor.GetSinglePlaceholderNode(doc, repeatingSectionPlaceholder.GetPlaceholder());
            var endNode = HtmlNodeExtractor.GetSinglePlaceholderNode(doc, repeatingSectionPlaceholder.GetEndPlaceholder());
            var nodes = HtmlNodeExtractor.GetNodesBetweenStartAndEnd(startNode, endNode).ToList();
            
            object data;
            try
            {
                data = JsonResolver.Resolve(jsonData, placeholder.ObjectName);
            }
            catch (ArgumentException e) when (e.Message.Equals($"The property {placeholder.ObjectName} could not be found."))
            {
                var value = $"{{{{Not found: {placeholder.ObjectName}}}}}";
                startNode.TextContent = value;
                HtmlNodeModifier.SetErrorColour(startNode);
                return;
            }
            
            try
            {
                var dataArray = (object[]) data;
                if (dataArray.Any())
                {
                    foreach (var node in nodes)
                    {
                        ProcessNodes(doc, node, jsonData);
                    }
                }
                else
                {
                    foreach (var n in nodes)
                    {
                        n.Remove();
                    }
                }
            }
            catch (InvalidCastException)
            {
                if (data != null)
                {
                    foreach (var node in nodes)
                    {
                        ProcessNodes(doc, node, jsonData);
                    }
                }
                else
                {
                    foreach (var n in nodes)
                    {
                        n.Remove();
                    }
                }
            }
            
            startNode.Remove();
            endNode.Remove();

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