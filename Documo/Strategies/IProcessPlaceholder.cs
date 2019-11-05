
using System.Collections.Generic;
using Documo.Visitor;
using HtmlAgilityPack;

namespace Documo.Strategies
{
    public interface IProcessPlaceholder
    {
        bool AppliesTo(DocumentPlaceholder placeholder);
        HtmlNode ProcessPlaceholders(HtmlNode node, DocumentPlaceholder placeholder, object jsonData);
    }
}