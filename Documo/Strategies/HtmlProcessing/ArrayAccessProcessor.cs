using System;
using AngleSharp.Dom;
using Documo.Services;
using Documo.Visitor;

namespace Documo.Strategies
{
    public class ProcessArrayAccessPlaceholder
    {
        public bool AppliesTo(DocumentPlaceholder placeholder)
        {
            return placeholder.GetType() == typeof(RepeatingSection);
        }

        public void ProcessPlaceholders(IElement node, DocumentPlaceholder placeholder, object array, int index)
        {
            string value;
            var docObj = (DocumentObject) placeholder;
            var fieldName = docObj.ObjectField;
            try
            {
                value = JsonResolver.Resolve(array, $"[{index}].{placeholder.GetPlaceholder()}").ToString();
                node.InnerHtml = node.InnerHtml.Replace($"{{{{{placeholder.GetPlaceholder()}}}}}", value);
            }
            catch (ArgumentException e) when (e.Message.Equals($"The property {fieldName} could not be found."))
            {
                                   
                value = $"{{{{Not found: {placeholder.GetPlaceholder()}}}}}";
                node.InnerHtml = node.InnerHtml.Replace($"{{{{{placeholder.GetPlaceholder()}}}}}", value);
                HtmlNodeModifier.SetErrorColour(node);
            }
            catch (Exception e)
            {
                Console.WriteLine($"Exception processing {placeholder.ObjectName}: {e.Message}. Stack trace: {e.StackTrace}");
            }
        }
    }
}