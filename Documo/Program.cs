using System;
using System.Linq;
using Antlr4.Runtime;
using Documo.Visitor;
using HtmlAgilityPack;

namespace Documo
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {

                var doc = new HtmlDocument();
                doc.Load("/home/angelica/RiderProjects/Documo/Documo/NewFile1.html");

                var nodes = doc.DocumentNode.SelectNodes("//p[@class='placeholder']");
                var s = nodes.Select(x => x.OuterHtml);
                var placeholders = string.Join("", s);
                
                string input = "";
                var text = "<<Address.AddressLine>><<Address.Postcode>>";

                var inputStream = new AntlrInputStream(text.ToString());
                var speakLexer = new DocumoLexer(inputStream);
                var commonTokenStream = new CommonTokenStream(speakLexer);
                var speakParser = new DocumoParser(commonTokenStream);
                DocumoParser.StmtContext stmtContext = speakParser.stmt();

                var visitor = new DocumoVisitor();
                visitor.Visit(stmtContext);
                var placeholder = visitor.Placeholders;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex);
            }
        }
    }
}