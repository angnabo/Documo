using System.Collections.Generic;

namespace Documo.Visitor
{
    public class DocumoVisitor : DocumoBaseVisitor<object>
    {
        public List<DocumentPlaceholder> Placeholders = new List<DocumentPlaceholder>();

        public override object VisitPlaceholder(DocumoParser.PlaceholderContext context)
        {
            DocumoParser.ExprContext expression = context.expr();
            DocumentObject obj = new DocumentObject
            {
                ObjectField = expression.objectField().GetText(),
                ObjectName = expression.objectName().GetText()
            };
            DocumentPlaceholder placeholder = new DocumentPlaceholder
            {
                DocumentObject = obj
            };
            
            Placeholders.Add(placeholder);
            
            return placeholder;
        }
    }

}