using Documo.Services;
using Documo.Visitor;
using HtmlAgilityPack;

namespace Documo.Strategies
{
    public class ProcessObjectPlaceholder : IProcessPlaceholder
    {
        public bool AppliesTo(DocumentPlaceholder placeholder)
        {
            return placeholder.GetType() == typeof(DocumentObject);
        }

        public void ProcessPlaceholders(HtmlDocument doc, DocumentPlaceholder placeholder, object jsonData)
        {
            var nodes = HtmlNodeExtractor.SelectPlaceholderNodes(doc, placeholder.GetPlaceholder());
 
            foreach (var node in nodes)
            {
                var value = GetValue((DocumentObject)placeholder, jsonData);
                HtmlNodeProcessor.ProcessPlaceholderNode(node, "");
            }
        }

        private string GetValue(DocumentObject placeholder, object jsonData){
            object propertyValue;

            var jsonType = jsonData.GetType();
            var property = jsonType.GetProperty(placeholder.GetPlaceholder());
            propertyValue = property.GetValue(jsonType, null);

            if (placeholder.ObjectField != null)
            {
                var propertyValueType = propertyValue.GetType();
                var memberProperty = propertyValueType.GetProperty(placeholder.ObjectField);
                propertyValue = memberProperty.GetValue(propertyValueType, null); 
            }

            return propertyValue.ToString();
        }
    }
}