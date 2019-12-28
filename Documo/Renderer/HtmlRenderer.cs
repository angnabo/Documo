using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AngleSharp;
using AngleSharp.Dom;
using AngleSharp.Html;
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

        public async Task<IDocument> openDocument(string path)
        {
            var config = Configuration.Default;
            var context = BrowsingContext.New(config);
            var file = File.ReadAllText(path);
            return await context.OpenAsync(req => req.Content(file));
        }

        public async void Render(object jsonData)
        {
            try
            {
                
                var doc = await openDocument("/home/angelica/RiderProjects/Documo/Documo/NewFile1.html");

                var placeholders = HtmlNodeExtractor.SelectPlaceholders(doc);
                
                var antlrService = new AntlrService();
                var parsedPlaceholders = antlrService.Parse(placeholders);
                
                foreach (var placeholder in parsedPlaceholders)
                {  
                    var placeholderNodes = doc.QuerySelectorAll(".placeholder").Where(x => x.GetAttribute("data-placeholder") == placeholder.GetPlaceholder());
                    if (!placeholderNodes.Any()) continue;
                    
                    var strategy = _placeholderStrategies.SingleOrDefault(x => x.AppliesTo(placeholder));
                    strategy?.ProcessPlaceholders(doc.Body, placeholder, jsonData);
                    
                }
                
                var sw = new StringWriter();
                doc.ToHtml(sw, new PrettyMarkupFormatter());

                File.WriteAllText("/home/angelica/RiderProjects/Documo/Documo/OutputHtml.html", sw.ToString());
                
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex}");
            }
        }
    }
}