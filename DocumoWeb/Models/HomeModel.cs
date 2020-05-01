using System.Collections.Generic;

namespace DocumoWeb.Models
{
    public class HomeModel
    {
        public Dictionary<int, string> TemplateTypes;
        public int? TemplateTypeId { get; set; }
        public string Html { get; set; }
    }
}