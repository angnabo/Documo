using System.Collections.Generic;

namespace Documo.Visitor
{
    public class DocumentPlaceholder
    {
        public DocumentObject DocumentObject { set; get; }
        public RepeatingSection RepeatingSection { set; get; }
    }
    
    public class DocumentObject
    {
        public string ObjectName { set; get; }
        public string ObjectField { set; get; }

        public string GetPlaceholder()
        {
            return $"{ObjectName}{(ObjectField != null ? $".{ObjectField}" : string.Empty)}";
        }
    }

    public class RepeatingSection
    {
        public string ObjectName { set; get; }
        
        public List<DocumentObject> DocumentObject = new List<DocumentObject>();
    }
}