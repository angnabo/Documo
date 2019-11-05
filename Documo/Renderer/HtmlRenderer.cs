using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Antlr4.Runtime;
using Documo.Services;
using Documo.Strategies;
using Documo.Visitor;
using HtmlAgilityPack;

namespace Documo.Renderer
{
    public class HtmlRenderer
    {
        private List<IProcessPlaceholder> _placeholderStrategies = new List<IProcessPlaceholder>();
        public HtmlRenderer()
        {
            _placeholderStrategies.Add(new ProcessObjectPlaceholder());

        }

        public void Render(object jsonData)
        {
            try
            {
                var doc = new HtmlDocument();
                doc.Load("/home/angelica/RiderProjects/Documo/Documo/NewFile1.html");

                var placeholders = HtmlNodeExtractor.ExtractNodeOuterHtml(doc, "//p[@class='placeholder']");
                var input = string.Join("", placeholders);
                var antlrService = new AntlrService();
                var parsedPlaceholders = antlrService.Parse(input);
                

                foreach (var placeholder in parsedPlaceholders)
                {                    
                    var strategy = _placeholderStrategies.SingleOrDefault(x => x.AppliesTo(placeholder));
                    
                    var placeholderNodes = HtmlNodeExtractor.SelectPlaceholderNodes(doc, placeholder.GetPlaceholder());
                    
                    if (placeholderNodes == null) continue;
                    
                    foreach (var node in placeholderNodes)
                    {
                        var n = HtmlNodeExtractor.SelectSinglePlaceholderNode(doc, placeholder.GetPlaceholder());
                        var newNode = strategy?.ProcessPlaceholders(node.Clone(), placeholder, jsonData);
                        n.ParentNode.ReplaceChild(newNode, n);
                    }
                }
                doc.Save("/home/angelica/RiderProjects/Documo/Documo/OutputHtml.html");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex);
            }
        }
    }
}