using System;
using System.IO;
using System.Threading.Tasks;
using Documo.Renderer;
using Documo.TestData;
using Xunit;
using Xunit.Abstractions;

namespace Tests
{
    public class PerformanceTest
    {
        private readonly ITestOutputHelper _testOutputHelper;

        public PerformanceTest(ITestOutputHelper testOutputHelper)
        {
            _testOutputHelper = testOutputHelper;
        }

        [Fact]
        public async Task TestPerformance()
        {
            var testData = TestJsonObject.GetData();
            var template = File.ReadAllText("/home/angelica/RiderProjects/Documo/Documo/TestData/Templates/InvoiceTemplateWithConditional.html");
            var watch = new System.Diagnostics.Stopwatch();
            
            watch.Start();
            
            for (var i = 0; i < 10; i++)
            {
                var pdf = await PdfRenderer.Render(template, testData);
            }
            
            watch.Stop();
            
            _testOutputHelper.WriteLine($"Execution Time: {watch.ElapsedMilliseconds/10.0m} ms");
        }
    }
}