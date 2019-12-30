using System.Linq;
using AngleSharp.Html.Parser;
using Documo.Services;
using Xunit;

namespace Tests
{
    public class ParsePlaceholdersTests{
    
        string html = @"<table>
                            <tbody>
                                <p class=""placeholder"">rs_Services</p>
                                    <tr>
                                        <td>
                                            <p class=""placeholder"">Name</p>
                                        </td>
                                
                                        <td>
                                            <p class=""placeholder"">Cost</p>
                                        </td>
                                    </tr>
                                <p class=""placeholder"">es_Services</p>
                            </tbody>
                        </table>";
    
        [Fact]
        public void ParsePlaceholders()
        {
            var expectedPlaceholders = "<p class=\"placeholder\">rs_Services</p><p class=\"placeholder\">Name</p><p class=\"placeholder\">Cost</p><p class=\"placeholder\">es_Services</p>";
            
            var parser = new HtmlParser();

            var document = parser.ParseDocument(html);
            
            var placeholders = HtmlNodeExtractor.GetAllPlaceholders(document);
            
            Assert.Equal(expectedPlaceholders, placeholders);
        }
    }
}