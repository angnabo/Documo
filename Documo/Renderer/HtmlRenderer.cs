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

        private async Task<IDocument> OpenDocument(string path)
        {
            var config = Configuration.Default;
            var context = BrowsingContext.New(config);
            var file = File.ReadAllText(path);
            return await context.OpenAsync(req => req.Content(file));
        }

        public async Task<string> Render(object jsonData)
        {
            var s = "";
            try
            {
                var doc = await OpenDocument("/home/angelica/RiderProjects/Documo/Documo/sample_template.html");

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

                File.WriteAllText("/home/angelica/RiderProjects/Documo/Documo/OutputHtml.html", sw.ToString());

                s = sw.ToString();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex}");
            }

            return s;
        }
    }
}