using Documo.Visitor;
using HtmlAgilityPack;

namespace Documo.Strategies
{
    public class ProcessRepeatingSectonPlaceholders : IProcessPlaceholder
    {
        
        public bool AppliesTo(DocumentPlaceholder placeholder)
        {
            return placeholder.GetType() == typeof(RepeatingSection);
        }

        public void ProcessPlaceholders(HtmlDocument doc, DocumentPlaceholder placeholder, object jsonData)
        {
            //get repeating section start node
            //get repeating section end node
            //get html between start and end node
            //foreach through json data and duplicate nodes
            //fill in nodes with json data
        }
    }
}