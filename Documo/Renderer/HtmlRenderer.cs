using System;
using System.Linq;
using Antlr4.Runtime;
using Documo.Services;
using Documo.Visitor;
using HtmlAgilityPack;

namespace Documo.Renderer
{
    public class HtmlRenderer
    {
        public void Render()
        {
            try
            {
                var doc = new HtmlDocument();
                doc.Load("/home/angelica/RiderProjects/Documo/Documo/NewFile1.html");

                var nodes = HtmlNodeExtractor.ExtractNodeOuterHtml(doc, "//p[@class='placeholder']");
                
                var placeholders = string.Join("", nodes);

                var inputStream = new AntlrInputStream(placeholders);
                var speakLexer = new DocumoLexer(inputStream);
                var commonTokenStream = new CommonTokenStream(speakLexer);
                var speakParser = new DocumoParser(commonTokenStream);
                DocumoParser.StmtContext stmtContext = speakParser.stmt();

                var visitor = new DocumoVisitor();
                var s = visitor.Visit(stmtContext);
                var placeholder = visitor.Placeholders;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex);
            }
        }
    }
}