using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AngleSharp.Common;
using Documo.Renderer;
using DocumoWeb.Constants;
using DocumoWeb.Models;
using Microsoft.AspNetCore.Mvc;
using Template = DocumoWeb.Models.Template;

namespace DocumoWeb.Controllers
{
    public class HomeController : Controller
    {
        
        public HomeController()
        {
            
        }
        public IActionResult Index()
        {
            var templateTypes = TemplateTypes.GetTemplateTypes()
                .ToDictionary(
                x => x.Id,
                x => x.Name);
            
            var model = new HomeModel
            {
                Html = "",
                TemplateTypes = templateTypes
            };
            
            return View(model);
        }
        
        [HttpPost]
        public async Task<IActionResult> Render(HomeModel model)
        {
            var file = await PdfRenderer.Render(GetData());
            return new FileContentResult(file, "application/pdf");
        }
        
        [HttpGet]
        public async Task<string> GetInvoiceTemplateHtmlCode(int id)
        {
            var templateType = TemplateTypes.Get(id);
            var templateFilePath = templateType.Path;
            var templateFile = await HtmlRenderer.OpenDocument(templateFilePath);
            //purge scripts
            return templateFile.DocumentElement.InnerHtml;
        }
        
        [HttpGet]
        public async Task<ViewResult> GetInvoiceTemplate(int id)
        {
            var templateType = TemplateTypes.Get(id);
            var templateFilePath = templateType.Path;
            var templateFile = await HtmlRenderer.OpenDocument(templateFilePath);
            //purge scripts
            ViewBag.Html = templateFile.DocumentElement.InnerHtml;
            return View("~/Views/_Template.cshtml");
        }


        private object GetData()
        {
            return new
            {
                Address = new
                {
                    AddressLine1 = "456 Flat",
                    AddressLine2 = "123 Street",
                    AddressLine3 = "Leeds",
                    Postcode = "LS1 2AB"
                },
                FullName = "Angelica N",
                CreatedDate = new DateTime(2019, 08, 12).ToString("dd/MM/yyy"),
                DueDate = new DateTime(2020, 01, 12).ToString("dd/MM/yyy"),
                InvoiceNumber = 56998735,
                Payments = new []
                {
                    new
                    {
                        Name = "Bank transfer 02/07",
                        Amount = 50.0m
                    },
                    new
                    {
                        Name = "Bank transfer 24/06",
                        Amount = 20.0m
                    },
                    new
                    {
                        Name = "Bank transfer 16/04",
                        Amount = 200.0m
                    }
                },
                TotalPayments = 270.0m,
                Services = new []
                {
                    new {
                        Name = "Paint",
                        Cost = new
                        {
                            Net = 185.3m,
                            Vat = 15.25m
                        }
                    },
                    new {
                        Name = "Window Replacement",
                        Cost = new
                        {
                            Net = 564.3m,
                            Vat = 37.25m
                        }
                    },
                    new {
                        Name = "Lightbulbs",
                        Cost = new
                        {
                            Net = 63.7m,
                            Vat = 6.34m
                        }
                    }
                },
                TotalServices = 813.4m,
            };
        }
    }
}