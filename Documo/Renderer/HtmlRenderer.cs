using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using AngleSharp;
using AngleSharp.Dom;
using AngleSharp.Html;
using Documo.Services;
using Documo.Strategies;

namespace Documo.Renderer
{
    public class HtmlRenderer
    {
        private readonly IPlaceholderProcessor _placeholderProcessor;
        public HtmlRenderer()
        {
            _placeholderProcessor = new PlaceholderProcessor();
        }

        public static async Task<IDocument> OpenDocument(string html)
        {
            var config = Configuration.Default;
            var context = BrowsingContext.New(config);
            var doc = await context.OpenAsync(req => req.Content(html));
            return StripScripts(doc);
        }

        public async Task<string> Render(string template, object jsonData)
        {
            try
            {
                var doc = await OpenDocument(template);
                var placeholders = HtmlNodeExtractor.GetAllPlaceholders(doc);
                var parsedPlaceholders = AntlrService.Parse(placeholders);
                
                foreach (var placeholder in parsedPlaceholders)
                {  
                    var placeholderNodes = HtmlNodeExtractor.GetPlaceholderNodes(doc.Body, placeholder.GetPlaceholder());
                    if (!placeholderNodes.Any()) continue;
                    
                    _placeholderProcessor.Process(doc.Body, placeholder, jsonData);
                }
                
                var sw = new StringWriter();
                doc.ToHtml(sw, new PrettyMarkupFormatter());
                
                File.WriteAllText ("/home/angelica/RiderProjects/Documo/Documo/TestData/Templates/OutputHtml.html", sw.ToString());
                
                return sw.ToString();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex}");
                throw;
            }
        }

        public static IDocument StripScripts(IDocument document)
        {
            var elements = document.QuerySelectorAll("script");
            foreach (var element in elements)
            {
                element.Remove();
            }
            return document;
        }
    }
}