using System.Collections.Generic;
using System.Linq;
using AngleSharp.Dom;
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

        public void ProcessPlaceholders(IDocument doc, DocumentPlaceholder placeholder, object jsonData)
        {
                var value = GetValue((DocumentObject)placeholder, jsonData);
                
                var placeholderNodes = doc.All.Where(x => x.LocalName == "p" 
                                                    && x.ClassList.Contains("placeholder") 
                                                    && x.TextContent == placeholder.GetPlaceholder());
                    
                if (!placeholderNodes.Any()) return;
                
                foreach (var node in placeholderNodes)
                {
                    node.TextContent = value;
                }
        }

        private string GetValue(DocumentObject placeholder, object jsonData){
            var jsonType = jsonData.GetType();
            var property = jsonType.GetProperty(placeholder.ObjectName);
            var propertyValue = property.GetValue(jsonData, null);

            if (placeholder.ObjectField != null)
            {
                var propertyValueType = propertyValue?.GetType();
                var memberProperty = propertyValueType?.GetProperty(placeholder.ObjectField);
                propertyValue = memberProperty?.GetValue(propertyValue, null); 
            }

            return propertyValue?.ToString();
        }

    }
    
    
}