using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
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

                var placeholderNodes = HtmlNodeExtractor.ExtractNodeOuterHtml(doc, "//p[@class='placeholder']");
                var input = string.Join("", placeholderNodes);
                var antlrService = new AntlrService();
                var placeholders = antlrService.Parse(input);
                

                foreach (var placeholder in placeholders)
                {                    
                    var strategy = _placeholderStrategies.Single(x => x.AppliesTo(placeholder));
                    strategy.ProcessPlaceholders(doc, placeholder, jsonData);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex);
            }
        }
    }
}