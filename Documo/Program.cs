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
            //var template = File.ReadAllText("/home/angelica/RiderProjects/Documo/Documo/TestData/Templates/InvoiceTemplateTinymce.html");
            //var template = File.ReadAllText("/home/angelica/RiderProjects/Documo/Documo/TestData/Templates/ReceiptTemplate.html");
            var template = File.ReadAllText("D:\\src\\Documo\\Documo\\TestData\\Templates\\ReceiptTemplate.html");
            var htmlRenderer = new HtmlRenderer();
            var pdf = await PdfRenderer.Render(template, testData);
            
            //File.WriteAllBytes("/home/angelica/RiderProjects/Documo/Documo/TestData/Templates/OutputPdf.pdf", pdf);
            File.WriteAllBytes("D:\\src\\Documo\\Documo\\TestData\\Templates\\OutputPdf.pdf", pdf);
        }
    }
}