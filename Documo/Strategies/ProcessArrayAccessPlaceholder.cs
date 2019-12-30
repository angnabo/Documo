using System;
using AngleSharp.Dom;
using Documo.Visitor;
using Pather.CSharp;

namespace Documo.Strategies
{
    public class ProcessArrayAccessPlaceholder : IProcessPlaceholder
    {
        public bool AppliesTo(DocumentPlaceholder placeholder)
        {
            return placeholder.GetType() == typeof(RepeatingSection);
        }

        public void ProcessPlaceholders(IElement node, DocumentPlaceholder placeholder, object array)
        {
            var resolver = new Resolver();
            var value = resolver.Resolve(array, $"[{1}].{placeholder.ObjectName}").ToString();
            node.TextContent = value;
        }
    }
}