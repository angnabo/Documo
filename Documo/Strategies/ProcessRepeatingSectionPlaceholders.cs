using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;
using Documo.Services;
using Documo.Visitor;
using HtmlAgilityPack;
using Pather.CSharp;

namespace Documo.Strategies
{
    public class ProcessRepeatingSectionPlaceholders : IProcessPlaceholder
    {
        private List<IProcessPlaceholder> _placeholderStrategies = new List<IProcessPlaceholder>();
        public ProcessRepeatingSectionPlaceholders()
        {
            _placeholderStrategies.Add(new ProcessObjectPlaceholder());
        }
        
        public bool AppliesTo(DocumentPlaceholder placeholder)
        {
            return placeholder.GetType() == typeof(RepeatingSection);
        }

        public void ProcessPlaceholders(HtmlDocument doc, DocumentPlaceholder placeholder, object jsonData)
        {
            //get repeating section start node
            //get repeating section end node
            var repeatingSectionPlaceholder = (RepeatingSection) placeholder;
            var startNode = HtmlNodeExtractor.SelectSinglePlaceholderNode(doc, repeatingSectionPlaceholder.GetPlaceholder());
            var endNode = HtmlNodeExtractor.SelectSinglePlaceholderNode(doc, repeatingSectionPlaceholder.GetEndPlaceholder());
            
            var htmlNodeCollection = new HtmlNodeCollection(startNode.ParentNode);

            HtmlNode nextNode = startNode.NextSibling;
            
            //get html between start and end node
            while (nextNode?.OuterHtml != endNode.OuterHtml)
            {
                htmlNodeCollection.Add(nextNode);
                nextNode = nextNode?.NextSibling;
            }
            
            var resolver = new Resolver();
            var array = (object[])resolver.Resolve(jsonData, placeholder.ObjectName); //services array

            for (var i = 0; i < array.Count(); i++)
            {
                foreach (var htmlNode in htmlNodeCollection)
                {
                    var nodeDoc = new HtmlDocument();
                    nodeDoc.LoadHtml(htmlNode.OuterHtml);
                
                    var placeholders = HtmlNodeExtractor.ExtractNodeOuterHtml(nodeDoc, "//p[@class='placeholder']");
                    var input = string.Join("", placeholders);
                    var antlrService = new AntlrService();
                    var parsedPlaceholders = antlrService.Parse(input); // inner table placeholders
                    
                    foreach (var p in parsedPlaceholders)
                    {  
                        var placeholderNodes = HtmlNodeExtractor.SelectPlaceholderNodes(nodeDoc, p.GetPlaceholder());
                        var d = nodeDoc.DocumentNode;
                        var g = d.SelectNodes($"//p[@class='placeholder' and . = '{p.GetPlaceholder()}']");
                        if (placeholderNodes == null) continue;

                        var objectAccessString = $"{placeholder.ObjectName}.{p.ObjectName}"; //[].name
                        var value = array[i].GetType()?.GetProperty(p.ObjectName)?.GetValue(array[i], null).ToString(); //[].name

                        foreach (var placeholderNode in placeholderNodes)
                        {
                            if (AppliesTo(p))
                            {
                                ProcessPlaceholders(nodeDoc, p, jsonData);
                            }
                            else
                            {
                                var newNode = HtmlNodeProcessor.ProcessPlaceholderNode(placeholderNode, value);
                                //placeholderNode.ParentNode.ReplaceChild(newNode, placeholderNode);
                            }
                        }
                    }

                    var n = HtmlNode.CreateNode(nodeDoc.DocumentNode.OuterHtml);
                    doc.DocumentNode.InsertAfter(n, startNode);
                }

            }
            doc.DocumentNode.RemoveChild(startNode);
            doc.DocumentNode.RemoveChild(endNode);
            foreach (var h in htmlNodeCollection)
            {
                doc.DocumentNode.RemoveChild(h);
            }
        }


    }
}