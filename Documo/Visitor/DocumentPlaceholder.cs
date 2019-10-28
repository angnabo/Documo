namespace Documo.Visitor
{
    public class DocumentPlaceholder
    {
        public DocumentObject DocumentObject { set; get; }
    }
    
    public class DocumentObject
    {
        public string ObjectName { set; get; }
        public string ObjectField { set; get; }
    }
}