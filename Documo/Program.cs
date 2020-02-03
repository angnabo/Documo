using System;
using System.Threading.Tasks;
using Documo.Renderer;
using Newtonsoft.Json.Serialization;

namespace Documo
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var data = new
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
            var json = Newtonsoft.Json.JsonConvert.SerializeObject(data);
            var pdfRenderer = new PdfRenderer();
            await pdfRenderer.Render(data);
        }
    }
}