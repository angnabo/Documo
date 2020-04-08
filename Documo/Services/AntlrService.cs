using System.Collections.Generic;
using Antlr4.Runtime;
using Documo.Visitor;

namespace Documo.Services
{
    public class AntlrService
    {
        public static IEnumerable<DocumentPlaceholder> Parse(string input)
        {
            if (input == string.Empty)
            {
                return new List<DocumentPlaceholder>();
            }
            var inputStream = new AntlrInputStream(input);
            var documoLexer = new DocumoLexer(inputStream);
            var commonTokenStream = new CommonTokenStream(documoLexer);
            var documoParser = new DocumoParser(commonTokenStream);
            var stmtContext = documoParser.stmt();

            var visitor = new DocumoVisitor();
            visitor.Visit(stmtContext);
            return visitor.Placeholders;
        }
    }
}