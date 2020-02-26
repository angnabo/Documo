using System.Collections.Generic;

namespace Documo.Visitor
{
    public class DocumoVisitor : DocumoBaseVisitor<object>
    {
        public readonly List<DocumentPlaceholder> Placeholders = new List<DocumentPlaceholder>();

        public override object VisitPlaceholder(DocumoParser.PlaceholderContext context)
        {

            DocumentPlaceholder placeholder = VisitPlaceholderContext(context);
            Placeholders.Add(placeholder);
            return placeholder;
        }

        public DocumentPlaceholder VisitPlaceholderContext(DocumoParser.PlaceholderContext context)
        {
            DocumentPlaceholder placeholder;
            if (context.repeatingSection() != null)
            {
                placeholder = (RepeatingSection)VisitRepeatingSection(context.repeatingSection());
            }
            else if(context.imagePlaceholder() != null)
            {
                placeholder = (ImagePlaceholder)VisitImagePlaceholder(context.imagePlaceholder());
            }
            else if(context.conditionalSection() != null)
            {
                placeholder = (ConditionalPlaceholder)VisitConditionalPlaceholder(context.conditionalSection());
            } else
            {
                placeholder = (DocumentObject)VisitObject(context.@object());
            }
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

        public object VisitConditionalPlaceholder(DocumoParser.ConditionalSectionContext context)
        {
            var conditionalPlaceholder = new ConditionalPlaceholder
            {
                ObjectName = VisitStartConditionalSection(context.startConditionalSection()).ToString()
            };

            foreach (var placeholder in context.placeholder())
            {
                conditionalPlaceholder.DocumentPlaceholders.Add(VisitPlaceholderContext(placeholder));
            }
            
            return conditionalPlaceholder;
        }

        public override object VisitStartConditionalSection(DocumoParser.StartConditionalSectionContext context)
        {
            return context.@object().objectName().GetText();
        }

        public object VisitImagePlaceholder(DocumoParser.ImagePlaceholderContext context)
        {
            var obj = new ImagePlaceholder
            {
                ObjectName = context.@object().objectName().GetText()
            };
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
                repeatingSection.DocumentPlaceholders.Add(VisitPlaceholderContext(placeholder));
            }
            
            return repeatingSection;
        }

        public override object VisitStartRepeatingSection(DocumoParser.StartRepeatingSectionContext context)
        {
            return context.@object().objectName().GetText();
        }
    }

}