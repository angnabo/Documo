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
            var objectPlaceholder = (DocumentObject) placeholder;
            var placeholderNodes = HtmlNodeExtractor.GetPlaceholderNodes(doc, objectPlaceholder.GetPlaceholder()).ToArray();
            if (!placeholderNodes.Any()) return;

            try
            {
                var value = JsonResolver.Resolve(jsonData, objectPlaceholder.GetPlaceholder()).ToString();
                foreach (var node in placeholderNodes)
                {
                    node.InnerHtml = node.InnerHtml.Replace($"{{{{{objectPlaceholder.GetPlaceholder()}}}}}", value);
                }
            }
            catch (ArgumentException e) when (
                e.Message.Equals($"The property {objectPlaceholder.GetPlaceholder()} could not be found.") ||
                e.Message.Equals($"The property {objectPlaceholder.ObjectField} could not be found."))
            {
                var value = $"{{{{Not found: {objectPlaceholder.GetPlaceholder()}}}}}";
                foreach (var node in placeholderNodes)
                {
                    node.InnerHtml = node.InnerHtml.Replace($"{{{{{objectPlaceholder.GetPlaceholder()}}}}}", value);
                    HtmlNodeModifier.SetErrorColour(node);
                }
            }
        }
    }
}