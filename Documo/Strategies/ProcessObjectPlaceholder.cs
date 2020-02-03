using System;
using System.Linq;
using AngleSharp.Dom;
using Documo.Services;
using Documo.Visitor;
using Microsoft.AspNetCore.Routing.Matching;
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
            catch (Exception e)
            {
                value = e.Message;
                foreach (var node in placeholderNodes)
                {
                    node.TextContent = value;
                    var styleAttribute = node.Attributes["style"].Value;
                    node.Attributes["style"].Value = styleAttribute + "color:red;";
                    node.GetAttribute("style");
                }
            }


            

        }
    }
}