using System.Threading.Tasks;
using Documo.Renderer;
using Documo.Services;
using DocumoWeb.Constants;

namespace DocumoWeb.Helpers
{
    public class TemplateHelper
    {
        public static async Task<string> GetTemplateContents(int templateId)
        {
            var templateType = TemplateTypes.Get(templateId);
            var templateFilePath = templateType.Path;
            var template = FileService.ReadAllLines(templateFilePath);
            var templateHtml = await HtmlRenderer.OpenDocument(template);
            return templateHtml.DocumentElement.InnerHtml;
        }
    }
}