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
            var htmlRenderer = new HtmlRenderer();
            var testData = InvoiceTestData.GetData();
            //var template = File.ReadAllText("/home/angelica/RiderProjects/Documo/Documo/TestData/Templates/InvoiceTemplateWithConditional.html");
            var template = File.ReadAllText("D:\\src\\Documo\\Documo\\TestData\\Templates\\InvoiceTemplateWithConditional.html");
            var watch = new System.Diagnostics.Stopwatch();
            
            watch.Start();
            
            for (var i = 0; i < 100; i++)
            {
                var pdf = await htmlRenderer.Render(template, testData);
            }
            
            watch.Stop();
            
            _testOutputHelper.WriteLine($"Execution Time: {watch.ElapsedMilliseconds/100.0m} ms");
        }
    }
}