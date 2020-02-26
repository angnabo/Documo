using System.Collections.Generic;
using System.Linq;
using AngleSharp.Dom;
using Documo.Services;
using Documo.Visitor;
using Pather.CSharp;

namespace Documo.Strategies
{
    public class ProcessRepeatingSectionPlaceholders : IProcessPlaceholder
    {
        private readonly ProcessArrayAccessPlaceholder _processArrayAccessPlaceholder;
        public ProcessRepeatingSectionPlaceholders()
        {
            _processArrayAccessPlaceholder = new ProcessArrayAccessPlaceholder();
        }
        
        public bool AppliesTo(DocumentPlaceholder placeholder)
        {
            return placeholder.GetType() == typeof(RepeatingSection);
        }
        
        //TODO break down
        public void ProcessPlaceholders(IElement doc, DocumentPlaceholder placeholder, object jsonData)
        {
            var repeatingSectionPlaceholder = (RepeatingSection) placeholder;
            var startNode = HtmlNodeExtractor.GetSinglePlaceholderNode(doc, repeatingSectionPlaceholder.GetPlaceholder());
            var endNode = HtmlNodeExtractor.GetSinglePlaceholderNode(doc, repeatingSectionPlaceholder.GetEndPlaceholder());

            var nodes = HtmlNodeExtractor.GetNodesBetweenStartAndEnd(startNode, endNode).ToArray();
            var array = (object[])JsonResolver.Resolve(jsonData, placeholder.ObjectName);
            
            for (var i = 0; i < array.Length; i++)
            {
                foreach (var htmlNode in nodes)
                {
                    var newNode = htmlNode.Clone() as IElement;
                    ProcessNodes(newNode, jsonData, array, i);
                    endNode.InsertAfter(newNode.Clone());
                }
            }

            startNode.Remove();
            endNode.Remove();
            foreach (var n in nodes)
            {
                n.Remove();
            }
        }
            
        private void ProcessNodes(IElement node, object jsonData, object[] array, int index){
            var placeholders = HtmlNodeExtractor.GetPlaceholderNodes(node).Select(x => x.TextContent.Trim());
                    
            var input = string.Join("", placeholders);
                    
            var parsedPlaceholders = AntlrService.Parse(input); // inner table placeholders
                    
            foreach (var parsedPlaceholder in parsedPlaceholders)
            {  
                var placeholderNodes = HtmlNodeExtractor.GetPlaceholderNodes(node, parsedPlaceholder.GetPlaceholder()).ToArray();
                        
                if (!placeholderNodes.Any()) continue;
                        
                foreach (var placeholderNode in placeholderNodes)
                {
                    if (AppliesTo(parsedPlaceholder))
                    {
                        ProcessPlaceholders(node, parsedPlaceholder, jsonData);
                    }
                    else
                    {
                        _processArrayAccessPlaceholder.ProcessPlaceholders(placeholderNode, parsedPlaceholder, array, index);
                    }  
                }
            }
        }


    }
}

