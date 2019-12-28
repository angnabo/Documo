using System.Collections.Generic;
using System.Linq;
using AngleSharp.Dom;
using HtmlAgilityPack;

namespace Documo.Services
{
    public static class HtmlNodeExtractor
    {
        public static IEnumerable<string> ExtractNodeOuterHtml(HtmlDocument doc, string htmlNode)
        {
            var nodes = doc.DocumentNode.SelectNodes(htmlNode);

            return nodes != null ? nodes.Select(x => x.OuterHtml) : new string[]{};
        }
        public static string SelectPlaceholders(IDocument doc)
        {
            var p = doc.QuerySelectorAll("p.placeholder");
            var placeholders = p.Select(x => x.OuterHtml);
            return string.Join("", placeholders);
        }
        public static IEnumerable<HtmlNode> SelectPlaceholderElements(HtmlDocument doc, string placeholderName)
        {
            return doc.DocumentNode.SelectNodes($"//p[@class='placeholder' and . = '{placeholderName}']");
        }
        
        public static HtmlNode SelectSinglePlaceholderNode(HtmlDocument doc, string placeholderName)
        {
            return doc.DocumentNode.SelectSingleNode($"//p[@class='placeholder' and . = '{placeholderName}']");
        }
    }
}