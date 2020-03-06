using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using AngleSharp.Dom;

namespace Documo.Services
{
    public static class HtmlNodeExtractor
    {
        public static string GetAllPlaceholders(IDocument doc)
        {
            var regex = new Regex("({{)[a-zA-Z0-9._]+(}})");
            var elements = doc.All.Where(x => !x.Children.Any() && regex.IsMatch(x.TextContent));
            
            var placeholders = elements.Select(x => x.TextContent.Trim());
            var matched = placeholders.Select(x => regex.Match(x));
            return string.Join("", matched);
        }
        
        public static IEnumerable<IElement> GetPlaceholderNodes(IElement doc, string placeholderName)
        {
            var regex = new Regex($"({{{{)({placeholderName})(}}}})");
            var elements = doc.QuerySelectorAll("*").Where(x => !x.Children.Any() && regex.IsMatch(x.TextContent));

            return elements;
        }
        
        public static IEnumerable<IElement> GetPlaceholderNodes(IElement doc)
        {
            var regex = new Regex("({{)[a-zA-Z0-9._]+(}})");
            return doc.QuerySelectorAll("*").Where(x => !x.Children.Any() && regex.IsMatch(x.TextContent));
        }
        
        public static IElement GetSinglePlaceholderNode(IElement doc, string placeholderName)
        {
            var regex = new Regex($"({{{{)({placeholderName})(}}}})");
            return doc.QuerySelectorAll("*").SingleOrDefault(x => !x.Children.Any() && regex.IsMatch(x.TextContent));
            return doc.QuerySelectorAll(".placeholder").SingleOrDefault(x => x.TextContent.Trim() == $"{{{{{placeholderName}}}}}");
        }
        
        public static IElement GetRepeatingSectionPlaceholder(IElement doc, string placeholderName)
        {
            var regex = new Regex("({{)[a-zA-Z0-9._]+(}})");
            var placeholderRegex = new Regex($"({{{{)({placeholderName})(}}}})");
            var placeholder =  doc.QuerySelectorAll("*").SingleOrDefault(x => !x.Children.Any() && placeholderRegex.IsMatch(x.TextContent));

            // get element 
            var otherPlaceholders = placeholder.QuerySelectorAll("*").Where(x => regex.IsMatch(x.TextContent)).ToList();

            while (!otherPlaceholders.Any())
            {
                
                otherPlaceholders = placeholder.ParentElement.QuerySelectorAll("*")
                    .Where(x => regex.IsMatch(x.TextContent) && !placeholderRegex.IsMatch(x.TextContent)).ToList();
                
                if (otherPlaceholders.Any())
                {
                    break;
                } 
                placeholder = placeholder.ParentElement;
            }

            return placeholder;
        }
        
        public static IEnumerable<IElement> GetNodesBetweenStartAndEnd(IElement startNode, IElement endNode)
        {
            var nodes = new List<IElement>();
            var nextNode = startNode.NextElementSibling;
            
            //get html between start and end node
            while (nextNode?.OuterHtml != endNode.OuterHtml)
            {
                if (nextNode == null)
                {
                    break;
                }
                nodes.Add(nextNode);
                nextNode = nextNode?.NextElementSibling;
            }
            return nodes;
        }
    }
}