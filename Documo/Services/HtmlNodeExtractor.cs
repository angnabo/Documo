using System.Collections.Generic;
using System.Linq;
using HtmlAgilityPack;

namespace Documo.Services
{
    public static class HtmlNodeExtractor
    {
        public static IEnumerable<string> ExtractNodeOuterHtml(HtmlDocument doc, string htmlNode)
        {
            var nodes = doc.DocumentNode.SelectNodes(htmlNode);
            return nodes.Select(x => x.OuterHtml);
        }
        
        public static IEnumerable<HtmlNode> SelectPlaceholderNodes(HtmlDocument doc, string placeholderName)
        {
            return doc.DocumentNode.SelectNodes($"//p[@class='placeholder' and . = '{placeholderName}']");
        }
        
        public static HtmlNode SelectSinglePlaceholderNode(HtmlDocument doc, string placeholderName)
        {
            return doc.DocumentNode.SelectSingleNode($"//p[@class='placeholder' and . = '{placeholderName}']");
        }
    }
}