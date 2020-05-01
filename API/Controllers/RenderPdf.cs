using System.IO;
using System.Threading.Tasks;
using Documo.Renderer;
using jsreport.Binary;
using jsreport.Local;
using jsreport.Types;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    public class RenderPdf : Controller
    {
  
        public async Task<IActionResult> Render(string template, object data)
        {
            var renderer = new HtmlRenderer();
            var content = await renderer.Render(template, data);
            var rs = new LocalReporting().UseBinary(JsReportBinary.GetBinary()).AsUtility().Create();
            var pdf = await rs.RenderAsync(new RenderRequest
            {
                Template = new Template
                {
                    Content = content,
                    Engine = Engine.None,
                    Recipe = Recipe.ChromePdf
                }
            });

            using (var fileStream = new StreamWriter("/home/angelica/RiderProjects/Documo/Documo/OutputPdf.pdf"))
            {
                fileStream.Write(pdf);
            }
            
            return new JsonResult("success");
        }
    }
}