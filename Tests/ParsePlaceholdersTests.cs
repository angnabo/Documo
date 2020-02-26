using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using AngleSharp.Html.Parser;
using Documo.Renderer;
using Documo.Services;
using Xunit;

namespace Tests
{
    public class ParsePlaceholdersTests{

        private string normalizeString(string S)
        {
            return Regex.Replace(S, @"\s", "");
        }

        [Fact]
        public void ParsePlaceholders()
        {
            var expectedPlaceholders = "{{rs_Payments}}{{Name}}{{Amount}}{{es_Payments}}{{TotalPayments}}";
            var template = File.ReadAllText("../../../HtmlTestData/RowRepeatingSection.html");
            
            var parser = new HtmlParser();
            var document = parser.ParseDocument(template);
            var placeholders = HtmlNodeExtractor.GetAllPlaceholders(document);
            
            Assert.Equal(expectedPlaceholders, placeholders);
        }
        
        [Fact]
        public async Task RowRepeatingSection()
        {
            var testData = new
            {
                Payments = new[]
                {
                    new
                    {
                        Name = "Bank transfer 02/07",
                        Amount = 50.0m
                    },
                    new
                    {
                        Name = "Bank transfer 24/06",
                        Amount = 20.0m
                    },
                    new
                    {
                        Name = "Bank transfer 16/04",
                        Amount = 200.0m
                    }
                },
                TotalPayments = 270.0m
            };
            
            var template = File.ReadAllText("../../../HtmlTestData/RowRepeatingSection.html");
            var expectedHtml = File.ReadAllText("../../../ExpectedHtml/ExpectedRowRepeatingSection.html");
            
            var renderer = new HtmlRenderer();
            var actualHtml = await renderer.Render(template, testData);
            
            Assert.Equal(normalizeString(expectedHtml), normalizeString(actualHtml), StringComparer.InvariantCultureIgnoreCase);
        }
        
        [Fact]
        public async Task TableRepeatingSection()
        {
            var testData = new
            {
                Payments = new[]
                {
                    new
                    {
                        Name = "Bank transfer 02/07",
                        Amount = 50.0m
                    },
                    new
                    {
                        Name = "Bank transfer 24/06",
                        Amount = 20.0m
                    },
                    new
                    {
                        Name = "Bank transfer 16/04",
                        Amount = 200.0m
                    }
                },
                TotalPayments = 270.0m
            };
            
            var template = File.ReadAllText("../../../HtmlTestData/TableRepeatingSection.html");
            var expectedHtml = File.ReadAllText("../../../ExpectedHtml/ExpectedTableRepeatingSection.html");
            
            var renderer = new HtmlRenderer();
            var actualHtml = await renderer.Render(template, testData);
            
            Assert.Equal(normalizeString(expectedHtml), normalizeString(actualHtml), StringComparer.InvariantCultureIgnoreCase);
        }
        
        [Fact]
        public async Task ConditionalSectionList_WhenListNotEmpty()
        {
            var testData = new
            {
                Services = new[]
                {
                    new
                    {
                        Name = "Paint",
                        Cost = new
                        {
                            Net = 185.3m,
                            Vat = 15.25m
                        }
                    },
                    new
                    {
                        Name = "Window Replacement",
                        Cost = new
                        {
                            Net = 564.3m,
                            Vat = 37.25m
                        }
                    },
                    new
                    {
                        Name = "Lightbulbs",
                        Cost = new
                        {
                            Net = 63.7m,
                            Vat = 6.34m
                        }
                    }
                },
                TotalServices = 813.4m,
            };
            var template = File.ReadAllText("../../../HtmlTestData/ConditionalSection.html");
            var expectedHtml = File.ReadAllText("../../../ExpectedHtml/ExpectedConditionalSection.html");
            
            var renderer = new HtmlRenderer();
            var actualHtml = await renderer.Render(template, testData);
            
            Assert.Equal(normalizeString(expectedHtml), normalizeString(actualHtml), StringComparer.InvariantCultureIgnoreCase);
        }
        
        [Fact]
        public async Task ConditionalSectionList_WhenListEmpty()
        {
            var testData = new
            {
                Services = new object[] {}
            };
            var template = File.ReadAllText("../../../HtmlTestData/ConditionalSection.html");
            var expectedHtml = File.ReadAllText("../../../ExpectedHtml/ExpectedEmptyConditionalSection.html");
            
            var renderer = new HtmlRenderer();
            var actualHtml = await renderer.Render(template, testData);
            
            Assert.Equal(normalizeString(expectedHtml), normalizeString(actualHtml), StringComparer.InvariantCultureIgnoreCase);
        }
        
        [Fact]
        public async Task ConditionalSectionList_WhenValueNull()
        {
            var testData = new
            {
                Services = new object[] {}
            };
            var template = File.ReadAllText("../../../HtmlTestData/ConditionalSection.html");
            var expectedHtml = File.ReadAllText("../../../ExpectedHtml/ExpectedEmptyConditionalSection.html");
            
            var renderer = new HtmlRenderer();
            var actualHtml = await renderer.Render(template, testData);
            
            Assert.Equal(normalizeString(expectedHtml), normalizeString(actualHtml), StringComparer.InvariantCultureIgnoreCase);
        }
        
        [Fact]
        public async Task ConditionalSectionList_WhenValueNotPresent()
        {
            var testData = new
            {
                Fullname = "Test Test"
            };
            var template = File.ReadAllText("../../../HtmlTestData/ConditionalSection.html");
            var expectedHtml = File.ReadAllText("../../../ExpectedHtml/ExpectedErrorConditionalSection.html");
            
            var renderer = new HtmlRenderer();
            var actualHtml = await renderer.Render(template, testData);
            
            Assert.Equal(normalizeString(expectedHtml), normalizeString(actualHtml), StringComparer.InvariantCultureIgnoreCase);
        }
        
        [Fact]
        public async Task NestedRepeatingSection()
        {
            var testData = new
            {
                Receipts = new []
                {
                    new
                    {
                        Items = new[]
                        {
                            new
                            {
                                Item = "Receipt1, Item1",
                                Cost = new
                                {
                                    Net = 10.0
                                }
                            },
                            new
                            {
                                Item = "Receipt1, Item2",
                                Cost = new
                                {
                                    Net = 20.0
                                }
                            }
                        }
                    },
                    new
                    {
                        Items = new[]
                        {
                            new
                            {
                                Item = "Receipt2, Item1",
                                Cost = new
                                {
                                    Net = 30.0
                                }
                            },
                            new
                            {
                                Item = "Receipt2, Item2",
                                Cost = new
                                {
                                    Net = 40.0
                                }
                            }
                        }
                    }
                }
            };
            var template = File.ReadAllText("../../../HtmlTestData/NestedRepeatingSection.html");
            var expectedHtml = File.ReadAllText("../../../ExpectedHtml/ExpectedNestedRepeatingSection.html");
            
            var renderer = new HtmlRenderer();
            var actualHtml = await renderer.Render(template, testData);
            
            Assert.Equal(normalizeString(expectedHtml), normalizeString(actualHtml), StringComparer.InvariantCultureIgnoreCase);
        }
    }
}