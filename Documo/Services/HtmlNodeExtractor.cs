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
            
            var placeholders = elements.Select(x => 
            { 
                x.InnerHtml = "";
                return x.OuterHtml;
            });
            
            return string.Join("", placeholders);
        }
        
        public static IEnumerable<IElement> GetPlaceholderNodes(IElement doc, string placeholderName)
        {
            return doc.QuerySelectorAll(".placeholder").Where(x => x.GetAttribute("data-placeholder") == placeholderName);
        }
        
        public static IEnumerable<IElement> GetPlaceholderNodes(IElement doc)
        {
            return doc.QuerySelectorAll(".placeholder");
        }
        
        public static IElement GetSinglePlaceholderNode(IElement doc, string placeholderName)
        {
            return doc.QuerySelectorAll(".placeholder").SingleOrDefault(x => x.GetAttribute("data-placeholder") == placeholderName);
        }
    }
}