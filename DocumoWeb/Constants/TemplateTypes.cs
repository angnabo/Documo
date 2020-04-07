using System.Collections.Generic;
using System.Linq;

namespace DocumoWeb.Constants
{

    public class TemplateType
    {
        public TemplateType(int id, string name, string path)
        {
            Id = id;
            Name = name;
            Path = path;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Path { get; set; }
    }

    public class TemplateTypes
    {
        private static readonly List<TemplateType> TemplateTypesList = new List<TemplateType>();
        private static readonly TemplateType InvoiceTemplate = new TemplateType(1, "Invoice", "../Documo/TestData/Templates/InvoiceTemplateTinymce.html");
        private static readonly TemplateType ReceiptTemplate = new TemplateType(2, "Order receipt", "../Documo/TestData/Templates/ReceiptTemplate.html");

        static TemplateTypes()
        {
            TemplateTypesList.Add(InvoiceTemplate);
            TemplateTypesList.Add(ReceiptTemplate);
        }
        public static TemplateType Get(int id)
        {
            return TemplateTypesList.Single(x => x.Id == id);
        }
        
        public static TemplateType Get(string name)
        {
            return TemplateTypesList.Single(x => x.Name == name);
        }
        
        public static List<TemplateType> GetTemplateTypes()
        {
            return TemplateTypesList;
        }
    }
}