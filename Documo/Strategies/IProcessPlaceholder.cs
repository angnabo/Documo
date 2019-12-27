
using System.Collections.Generic;
using AngleSharp.Dom;
using Documo.Visitor;
using HtmlAgilityPack;

namespace Documo.Strategies
{
    public interface IProcessPlaceholder
    {
        bool AppliesTo(DocumentPlaceholder placeholder);
        void ProcessPlaceholders(IDocument doc, DocumentPlaceholder placeholder, object jsonData);
    }
}