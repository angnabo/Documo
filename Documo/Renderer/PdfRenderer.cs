using System.IO;
using System.Threading.Tasks;
using jsreport.Binary;
using jsreport.Local;
using jsreport.Types;

namespace Documo.Renderer
{
    public class PdfRenderer
    {
        public static async Task<byte[]> Render(string template, object data)
        {
            var renderer = new HtmlRenderer();
            var content = await renderer.Render(template, data);
            var rs = new LocalReporting()
                .UseBinary(JsReportBinary.GetBinary())
                .Configure(cfg =>cfg.AllowedLocalFilesAccess().BaseUrlAsWorkingDirectory())
                .TempDirectory("C:\\Users\\angel\\Documents\\JsReportTemp")
                .AsUtility()
                .Create();
            
            var pdf = await rs.RenderAsync(new RenderRequest
            {
                Template = new Template
                {
                    Content = content,
                    Engine = Engine.None,
                    Recipe = Recipe.ChromePdf
                }
            });
            
            return ReadFully(pdf.Content);
        }

        private static byte[] ReadFully(Stream input)
        {
            using var ms = new MemoryStream();
            input.CopyTo(ms);
            return ms.ToArray();
        }
    }
}