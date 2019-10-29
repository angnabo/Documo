using System.Collections.Generic;

namespace Documo.Visitor
{
    public class DocumoVisitor : DocumoBaseVisitor<object>
    {
        public List<DocumentPlaceholder> Placeholders = new List<DocumentPlaceholder>();

//        public override object VisitPlaceholder(DocumoParser.PlaceholderContext context)
//        {
//            var expression = context.@object();
//            DocumentObject obj = new DocumentObject
//            {
//                ObjectField = expression.objectField().GetText(),
//                ObjectName = expression.objectName().GetText()
//            };
//            DocumentPlaceholder placeholder = new DocumentPlaceholder
//            {
//                DocumentObject = obj
//            };
//            
//            Placeholders.Add(placeholder);
//            
//            return placeholder;
//        }

        public override object VisitObjectFieldAccess(DocumoParser.ObjectFieldAccessContext context)
        {
            DocumentObject obj = new DocumentObject
            {
                ObjectField = context.objectField().GetText(),
                ObjectName = context.objectName().GetText()
            };
            
            Placeholders.Add(new DocumentPlaceholder {DocumentObject = obj});
            
            return obj;
        }

        public override object VisitObjectName(DocumoParser.ObjectNameContext context)
        {
            DocumentObject obj = new DocumentObject
            {
                ObjectName = context.GetText()
            };
            
            Placeholders.Add(new DocumentPlaceholder {DocumentObject = obj});
            
            return obj;
        }

    }

}