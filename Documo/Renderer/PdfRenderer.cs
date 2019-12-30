using System.IO;
using System.Threading.Tasks;
using jsreport.Binary.Linux;
using jsreport.Local;
using jsreport.Types;

namespace Documo.Renderer
{
    public class PdfRenderer
    {
        public async Task Render(object data)
        {
            var renderer = new HtmlRenderer();
            var content = await renderer.Render(data);
            var rs = new LocalReporting().UseBinary(JsReportBinary.GetBinary()).AsUtility().Create();
            var pdf = await rs.RenderAsync(new RenderRequest
            {
                Template = new Template
                {
                    Content = content,
                    Engine = Engine.None,
                    Recipe = Recipe.ChromePdf
                },
                
            });

            var fileStream = new FileStream("/home/angelica/RiderProjects/Documo/Documo/OutputPdf.pdf", FileMode.Create, FileAccess.Write);
            pdf.Content.CopyTo(fileStream);
            fileStream.Dispose();
        }
    }
}