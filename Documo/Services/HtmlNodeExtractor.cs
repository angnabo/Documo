using System;
using System.Collections.Generic;
using System.Linq;
using AngleSharp.Dom;

namespace Documo.Services
{
    public static class HtmlNodeExtractor
    {
        public static string GetAllPlaceholders(IDocument doc)
        {
            var elements = doc.Body.QuerySelectorAll(".placeholder");
            
            var placeholders = elements.Select(x => (x.TextContent.Trim() == string.Empty ? x.GetAttribute("data-placeholder").Trim() : x.TextContent.Trim()));
            
            return string.Join("", placeholders);
        }
        
        public static IEnumerable<IElement> GetPlaceholderNodes(IElement doc, string placeholderName)
        {
            var placeholder = $"{{{{{placeholderName}}}}}";
            return doc.QuerySelectorAll(".placeholder").Where(
                x => x.TextContent.Trim() == string.Empty
                    ? x.GetAttribute("data-placeholder").Trim() == placeholder
                    : x.TextContent.Trim() == placeholder);
        }
        
        public static IEnumerable<IElement> GetPlaceholderNodes(IElement doc)
        {
            return doc.QuerySelectorAll(".placeholder");
        }
        
        public static IElement GetSinglePlaceholderNode(IElement doc, string placeholderName)
        {
            return doc.QuerySelectorAll(".placeholder").SingleOrDefault(x => x.TextContent.Trim() == $"{{{{{placeholderName}}}}}");
        }
    }
}