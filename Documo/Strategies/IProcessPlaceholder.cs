
using System.Collections.Generic;
using Documo.Visitor;
using HtmlAgilityPack;

namespace Documo.Strategies
{
    public interface IProcessPlaceholder
    {
        bool AppliesTo(DocumentPlaceholder placeholder);
        void ProcessPlaceholders(HtmlDocument doc, DocumentPlaceholder placeholder, object jsonData);
    }
}