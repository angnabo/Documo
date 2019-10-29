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
    }
}