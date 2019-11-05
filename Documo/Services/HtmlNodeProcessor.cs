using System.Linq;
using HtmlAgilityPack;

namespace Documo.Services
{
    public static class HtmlNodeProcessor
    {
        public static HtmlNode ProcessPlaceholderNode(HtmlNode node, string placeholderValue)
        {
            node.Attributes["class"].Value = node.Attributes["class"].Value.Replace("placeholder", "");
                        
            if (node.ChildNodes.Count > 0)
            {
                node.ReplaceChild(HtmlNode.CreateNode(placeholderValue), node.ChildNodes.First());
            }
            else
            {
                node.AppendChild(HtmlNode.CreateNode(placeholderValue));
            }

            return node;
        }
    }
}