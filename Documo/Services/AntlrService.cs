using System.Collections.Generic;
using Antlr4.Runtime;
using Documo.Visitor;

namespace Documo.Services
{
    public class AntlrService
    {
        public IEnumerable<DocumentPlaceholder> Parse(string input)
        {
            var inputStream = new AntlrInputStream(input);
            var documoLexer = new DocumoLexer(inputStream);
            var commonTokenStream = new CommonTokenStream(documoLexer);
            var documoParser = new DocumoParser(commonTokenStream);
            var stmtContext = documoParser.stmt();

            var visitor = new DocumoVisitor();
            visitor.Visit(stmtContext);
            var s =  visitor.Placeholders;
            var v =  visitor.RepeatingSection;
            return visitor.Placeholders;
        }
    }
}