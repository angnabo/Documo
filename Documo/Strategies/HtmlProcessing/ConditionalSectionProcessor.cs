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
            
            var startNode = HtmlNodeExtractor.GetRepeatingSectionPlaceholder(doc, repeatingSectionPlaceholder.GetPlaceholder());
            var endNode = HtmlNodeExtractor.GetRepeatingSectionPlaceholder(doc, repeatingSectionPlaceholder.GetEndPlaceholder());

            var nodes = new List<IElement>{startNode};
            if (startNode != endNode)
            {
                nodes = HtmlNodeExtractor.GetNodesBetweenStartAndEnd(startNode, endNode).ToList();
                startNode.Remove();
                endNode.Remove();
            }

            object data;
            try
            {
                data = JsonResolver.Resolve(jsonData, placeholder.ObjectName);
            }
            catch (ArgumentException e) when (e.Message.Equals($"The property {placeholder.ObjectName} could not be found."))
            {
                foreach (var n in nodes)
                {
                    n.Remove();
                }
                return;
            }
            
            try
            {
                var dataArray = (object[]) JsonResolver.Resolve(jsonData, placeholder.ObjectName);
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
        }

        private void ProcessNodes(IElement doc, IElement node, object jsonData)
        {
            var placeholdersFromNode = HtmlNodeExtractor.GetAllPlaceholders(node);
            var parsedPlaceholders = AntlrService.Parse(placeholdersFromNode); // inner table placeholders
                    
            foreach (var parsedPlaceholder in parsedPlaceholders)
            {  
                var placeholderStrategies = PlaceholderStrategies.Get();
                var strategy = placeholderStrategies.SingleOrDefault(x => x.AppliesTo(parsedPlaceholder));
                strategy?.ProcessPlaceholders(doc, parsedPlaceholder, jsonData);
            }
        }
        
    }
}