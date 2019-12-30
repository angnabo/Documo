using AngleSharp.Dom;
using Documo.Visitor;

namespace Documo.Strategies
{
    public interface IPlaceholderProcessor
    {
        void Process(IElement document, DocumentPlaceholder placeholder, object jsonData);
    }
}