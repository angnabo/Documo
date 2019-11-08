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
            _placeholderStrategies.Add(new ProcessRepeatingSectionPlaceholders());
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
                    var placeholderNodes = HtmlNodeExtractor.SelectPlaceholderNodes(doc, placeholder.GetPlaceholder());
                    
                    if (placeholderNodes == null) continue;
                    
                        var strategy = _placeholderStrategies.SingleOrDefault(x => x.AppliesTo(placeholder));
                        strategy?.ProcessPlaceholders(doc, placeholder, jsonData);
                    
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