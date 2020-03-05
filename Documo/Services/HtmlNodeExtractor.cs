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
            var f = doc.ChildNodes.Where(x => regex.IsMatch(x.TextContent));
            
            var placeholders = elements.Select(x => x.TextContent.Trim());
            var matched = placeholders.Select(x => regex.Match(x));
            return string.Join("", matched);
        }
        
        public static IEnumerable<IElement> GetPlaceholderNodes(IElement doc, string placeholderName)
        {
            var regex = new Regex($"({{{{)({placeholderName})(}}}})");
            var elements = doc.QuerySelectorAll("*").Where(x => !x.Children.Any() && regex.IsMatch(x.TextContent));
//            var placeholders =  doc.QuerySelectorAll(".placeholder").Where(
//                x => x.TextContent.Trim() == string.Empty
//                    ? x.GetAttribute("data-placeholder").Trim() == placeholder
//                    : x.TextContent.Trim() == placeholder);

            return (IEnumerable<IElement>)elements;
        }
        
        public static IEnumerable<IElement> GetPlaceholderNodes(IElement doc)
        {
//            return doc.QuerySelectorAll(".placeholder").ToList();
            
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
            var parentEl = placeholder.ParentElement;

            var otherPlaceholders = parentEl.QuerySelectorAll("*").Where(x => regex.IsMatch(x.TextContent) && !placeholderRegex.IsMatch(x.TextContent));
            while (!otherPlaceholders.Any())
            {
                var h = parentEl.QuerySelectorAll("*");
                var hhg = parentEl.QuerySelectorAll("*").Where(x => regex.IsMatch(x.TextContent));
                otherPlaceholders = parentEl.QuerySelectorAll("*").Where(x => regex.IsMatch(x.TextContent) && !placeholderRegex.IsMatch(x.TextContent));
                parentEl = parentEl.ParentElement;
            }
            
            return doc.QuerySelectorAll(".placeholder").SingleOrDefault(x => x.TextContent.Trim() == $"{{{{{placeholderName}}}}}");
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