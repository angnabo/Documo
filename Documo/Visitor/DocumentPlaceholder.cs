using System.Collections.Generic;

namespace Documo.Visitor
{
    public abstract class DocumentPlaceholder
    {
        public abstract string GetPlaceholder();
    }
    
    public class DocumentObject : DocumentPlaceholder
    {
        public string ObjectName { set; get; }
        public string ObjectField { set; get; }

        public override string GetPlaceholder()
        {
            return $"{ObjectName}{(ObjectField != null ? $".{ObjectField}" : string.Empty)}";
        }
    }

    public class RepeatingSection : DocumentPlaceholder
    {
        public string ObjectName { set; get; }
        
        public List<DocumentObject> DocumentObject = new List<DocumentObject>();
        
        public override string GetPlaceholder()
        {
            return $"{ObjectName}";
        }
    }
}