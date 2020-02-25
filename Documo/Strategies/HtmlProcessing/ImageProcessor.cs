using System;
using System.Linq;
using AngleSharp.Dom;
using Documo.Services;
using Documo.Visitor;

namespace Documo.Strategies
{
    public class ImagePlaceholderProcessor : IProcessPlaceholder
    {
        public bool AppliesTo(DocumentPlaceholder placeholder)
        {
            return placeholder.GetType() == typeof(ImagePlaceholder);
        }

        public void ProcessPlaceholders(IElement doc, DocumentPlaceholder placeholder, object jsonData)
        {
            var placeholderNodes = HtmlNodeExtractor.GetPlaceholderNodes(doc, placeholder.GetPlaceholder()).ToArray();
            if (!placeholderNodes.Any()) return;
            
            try
            {
                var value = JsonResolver.Resolve(jsonData, placeholder.ObjectName).ToString();
                foreach (var node in placeholderNodes)
                {
                    node.SetAttribute("src", value);
                    node.TextContent = string.Empty;
                }
            }
            catch (ArgumentException e) when (e.Message.Equals($"The property {placeholder.ObjectName} could not be found."))
            {
                var value = $"{{{{Not found: {placeholder.ObjectName}}}}}";
                foreach (var node in placeholderNodes)
                {
                    node.TextContent = value;
                    node.Attributes["style"].Value += "color:red;";
                }
            }
        }
    }
}