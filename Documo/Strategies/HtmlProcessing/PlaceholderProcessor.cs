using System.Linq;
using AngleSharp.Dom;
using Documo.Services;
using Documo.Visitor;

namespace Documo.Strategies
{
    public class PlaceholderProcessor : IPlaceholderProcessor
    {
        public void Process(IElement document, DocumentPlaceholder placeholder, object jsonData)
        {
            var placeholderStrategies = PlaceholderStrategies.Get();
            var strategy = placeholderStrategies.SingleOrDefault(x => x.AppliesTo(placeholder));
            strategy?.ProcessPlaceholders(document, placeholder, jsonData);
        }
        
    }
}