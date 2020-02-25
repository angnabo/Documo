using System.Collections.Generic;

namespace Documo.Visitor
{
    public abstract class DocumentPlaceholder
    {
        public abstract string ObjectName { set; get; }
        public abstract string GetPlaceholder();
    }
    
    public class DocumentObject : DocumentPlaceholder
    {
        public override string ObjectName { set; get; }
        public string ObjectField { set; get; }

        public override string GetPlaceholder()
        {
            return $"{ObjectName}{(ObjectField != null ? $".{ObjectField}" : string.Empty)}";
        }
    }

    public class RepeatingSection : DocumentPlaceholder
    {
        public override string ObjectName { set; get; }
        
        public List<DocumentObject> DocumentObject = new List<DocumentObject>();
        
        public override string GetPlaceholder()
        {
            return $"rs_{ObjectName}";
        }
        
        public string GetEndPlaceholder()
        {
            return $"es_{ObjectName}";
        }
    }
    
    public class ImagePlaceholder : DocumentPlaceholder
    {
        public override string ObjectName { set; get; }

        public override string GetPlaceholder()
        {
            return $"img_{ObjectName}";
        }
    }

    public class ConditionalPlaceholder : DocumentPlaceholder
    {
        public override string ObjectName { set; get; }

        public List<DocumentPlaceholder> DocumentPlaceholders = new List<DocumentPlaceholder>();

        public override string GetPlaceholder()
        {
            return $"if_{ObjectName}";
        }

        public string GetEndPlaceholder()
        {
            return $"endif_{ObjectName}";
        }
    }
}