using System.Collections.Generic;
using Antlr4.Runtime;

namespace Documo.Visitor
{
    public class DocumoVisitor : DocumoBaseVisitor<object>
    {
        public readonly List<DocumentPlaceholder> Placeholders = new List<DocumentPlaceholder>();

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

        public override object VisitPlaceholder(DocumoParser.PlaceholderContext context)
        {
            
            DocumentPlaceholder placeholder;
            if (context.repeatingSection() != null)
            {
                placeholder = (RepeatingSection)VisitRepeatingSection(context.repeatingSection());
            }
            else
            {
                placeholder = (DocumentObject)VisitObject(context.@object());
            }
            
            Placeholders.Add(placeholder);
            return placeholder;
        }

        public object VisitObject(DocumoParser.ObjectContext context)
        {
            DocumentObject obj;
            if (context.objectFieldAccess() != null)
            {
                obj = new DocumentObject
                {
                    ObjectField = context.objectFieldAccess().objectField().GetText(),
                    ObjectName = context.objectFieldAccess().objectName().GetText()
                };
            }
            else
            {
                obj = new DocumentObject
                {
                    ObjectName = context.objectName().GetText()
                };
            }

            return obj;
        }

        public object VisitRepeatingSection(DocumoParser.RepeatingSectionContext context)
        {
            var repeatingSection = new RepeatingSection
            {
                ObjectName = VisitStartRepeatingSection(context.startRepeatingSection()).ToString()
            };

            foreach (var placeholder in context.placeholder())
            {
                repeatingSection.DocumentObject.Add((DocumentObject)VisitObject(placeholder.@object()));
            }
            
            return repeatingSection;
        }

        public override object VisitStartRepeatingSection(DocumoParser.StartRepeatingSectionContext context)
        {
            return context.@object().objectName().GetText();
        }
    }

}