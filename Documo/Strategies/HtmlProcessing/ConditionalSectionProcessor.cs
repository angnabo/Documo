using System;
using System.Linq;
using AngleSharp.Dom;
using Documo.Services;
using Documo.Visitor;

namespace Documo.Strategies.HtmlProcessing
{
    public class ConditionalSectionProcessor : IProcessPlaceholder
    {
        public bool AppliesTo(DocumentPlaceholder placeholder)
        {
            return placeholder.GetType() == typeof(ImagePlaceholder);
        }

        public void ProcessPlaceholders(IElement doc, DocumentPlaceholder placeholder, object jsonData)
        {
            object data;
            
            
            
            
            
            var placeholderNodes = HtmlNodeExtractor.GetPlaceholderNodes(doc, placeholder.GetPlaceholder()).ToArray();
            if (!placeholderNodes.Any()) return;
            
            try
            {
                var value = (object[])JsonResolver.Resolve(jsonData, placeholder.ObjectName);
                
            }
            catch (ArgumentException e) when (e.Message.Equals($"The property {placeholder.GetPlaceholder()} could not be found."))
            {
                var value = $"{{{{Not found: {placeholder.GetPlaceholder()}}}}}";
                foreach (var node in placeholderNodes)
                {
                    node.TextContent = value;
                    node.Attributes["style"].Value += "color:red;";
                }
            }
        }
    }
}