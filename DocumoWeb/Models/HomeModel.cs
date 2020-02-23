using System.Collections.Generic;
using DocumoWeb.Constants;

namespace DocumoWeb.Models
{
    public class HomeModel
    {
        public Dictionary<int, string> TemplateTypes;
        public string Html { get; set; }
    }
}