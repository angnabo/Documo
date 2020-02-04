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
            
            string value;
            
            try
            {
                value = JsonResolver.Resolve(jsonData, placeholder.GetPlaceholder());
                foreach (var node in placeholderNodes)
                {
                    node.TextContent = value;
                }
            }
            catch (ArgumentException e) when (e.Message.Equals($"The property {placeholder.GetPlaceholder()} could not be found."))
            {
                value = $"{{{{Not found: {placeholder.GetPlaceholder()}}}}}";
                foreach (var node in placeholderNodes)
                {
                    node.TextContent = value;
                    node.Attributes["style"].Value += "color:red;";
                }
            }
        }
    }
}