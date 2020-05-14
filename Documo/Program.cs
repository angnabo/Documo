using System.IO;
using System.Threading.Tasks;
using Documo.Renderer;
using Documo.TestData;

namespace Documo
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var testData = InvoiceTestData.GetData();
            var template = File.ReadAllText("../../../TestData//Templates/InvoiceTemplateTinymce.html");
            var pdf = await PdfRenderer.Render(template, testData);
            File.WriteAllBytes("../../../TestData/Templates/OutputPdf.pdf", pdf);
        }
    }
}