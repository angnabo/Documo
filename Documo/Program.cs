using System;
using System.IO;
using System.Threading.Tasks;
using Documo.Renderer;
using Documo.TestData;
using Newtonsoft.Json.Serialization;

namespace Documo
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var testData = TestJsonObject.GetData();
            var pdfRenderer = new PdfRenderer();
            var template = File.ReadAllText("/home/angelica/RiderProjects/Documo/Documo/sample_template.html");
            await PdfRenderer.Render(template, testData);
        }
    }
}