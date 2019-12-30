using System.Linq;
using AngleSharp.Dom;
using Documo.Services;
using Documo.Visitor;
using Pather.CSharp;

namespace Documo.Strategies
{
    public class ProcessObjectPlaceholder : IProcessPlaceholder
    {
        public bool AppliesTo(DocumentPlaceholder placeholder)
        {
            return placeholder.GetType() == typeof(DocumentObject);
        }

        public void ProcessPlaceholders(IElement doc, DocumentPlaceholder placeholder, object jsonData)
        {
            var value = JsonResolver.Resolve(jsonData, placeholder.GetPlaceholder());

            var placeholderNodes = HtmlNodeExtractor.GetPlaceholderNodes(doc, placeholder.GetPlaceholder()).ToArray();
                
            if (!placeholderNodes.Any()) return;
            
            foreach (var node in placeholderNodes)
            {
                node.TextContent = value.ToString();
            }
        }
    }
}