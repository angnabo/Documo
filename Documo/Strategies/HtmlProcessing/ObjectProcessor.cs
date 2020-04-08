using System;
using System.Linq;
using AngleSharp.Dom;
using Documo.Services;
using Documo.Visitor;

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
            var placeholderNodes = HtmlNodeExtractor.GetPlaceholderNodes(doc, placeholder.GetPlaceholder()).ToArray();
            if (!placeholderNodes.Any()) return;

            try
            {
                var value = JsonResolver.Resolve(jsonData, placeholder.GetPlaceholder()).ToString();
                foreach (var node in placeholderNodes)
                {
                    node.InnerHtml = node.InnerHtml.Replace($"{{{{{placeholder.GetPlaceholder()}}}}}", value);
                }
            }
            catch (ArgumentException e) when (e.Message.Equals($"The property {placeholder.GetPlaceholder()} could not be found."))
            {
                var value = $"{{{{Not found: {placeholder.GetPlaceholder()}}}}}";
                foreach (var node in placeholderNodes)
                {
                    node.InnerHtml = node.InnerHtml.Replace($"{{{{{placeholder.GetPlaceholder()}}}}}", value);
                    HtmlNodeModifier.SetErrorColour(node);
                }
            }
        }
    }
}