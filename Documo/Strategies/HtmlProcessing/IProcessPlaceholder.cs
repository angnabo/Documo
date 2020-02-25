using AngleSharp.Dom;
using Documo.Visitor;

namespace Documo.Strategies
{
    public interface IProcessPlaceholder
    {
        bool AppliesTo(DocumentPlaceholder placeholder);
        void ProcessPlaceholders(IElement doc, DocumentPlaceholder placeholder, object jsonData);
    }
}