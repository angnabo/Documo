using System;
using System.Threading.Tasks;
using Documo.Renderer;

namespace Documo
{
    class Program
    {
        static async Task Main(string[] args)
        {
            

            var json = new
            {
                Address = new
                {
                    AddressLine1 = "456 Flat",
                    AddressLine2 = "123 Street",
                    AddressLine3 = "Leeds",
                    Postcode = "LS1 2AB"
                },
                FullName = "Angelica N",
                CreatedDate = new DateTime(2019, 01, 12),
                DueDate = new DateTime(2020, 01, 12),
                InvoiceNumber = 56998735,
                Payments = new []
                {
                    new
                    {
                        Name = "Payment 1",
                        Amount = 50.0m
                    },
                    new
                    {
                        Name = "Payment 2",
                        Amount = 20.0m
                    },
                    new
                    {
                        Name = "Payment 1",
                        Amount = 50.0m
                    },
                    new
                    {
                        Name = "Payment 2",
                        Amount = 20.0m
                    },
                    new
                    {
                        Name = "Payment 1",
                        Amount = 50.0m
                    },
                    new
                    {
                        Name = "Payment 2",
                        Amount = 20.0m
                    },
                    new
                    {
                        Name = "Payment 1",
                        Amount = 50.0m
                    },
                    new
                    {
                        Name = "Payment 2",
                        Amount = 20.0m
                    },
                    new
                    {
                        Name = "Payment 1",
                        Amount = 50.0m
                    },
                    new
                    {
                        Name = "Payment 2",
                        Amount = 20.0m
                    }
                },
                Services = new []
                {
                    new {
                        Name = "Paint",
                        Cost = new
                        {
                            Net = 85.3m,
                            Vat = 5.25m
                        }
                    },
                    new {
                        Name = "Window Replacement",
                        Cost = new
                        {
                            Net = 42.3m,
                            Vat = 3.25m
                        }
                    },
                    new {
                        Name = "Lightbulbs",
                        Cost = new
                        {
                            Net = 63.7m,
                            Vat = 6.34m
                        }
                    }, 
                    new {
                        Name = "Paint",
                        Cost = new
                        {
                            Net = 85.3m,
                            Vat = 5.25m
                        }
                    },
                    new {
                        Name = "Window Replacement",
                        Cost = new
                        {
                            Net = 42.3m,
                            Vat = 3.25m
                        }
                    },
                    new {
                        Name = "Lightbulbs",
                        Cost = new
                        {
                            Net = 63.7m,
                            Vat = 6.34m
                        }
                    },
                    new {
                        Name = "Paint",
                        Cost = new
                        {
                            Net = 85.3m,
                            Vat = 5.25m
                        }
                    },
                    new {
                        Name = "Window Replacement",
                        Cost = new
                        {
                            Net = 42.3m,
                            Vat = 3.25m
                        }
                    },
                    new {
                        Name = "Lightbulbs",
                        Cost = new
                        {
                            Net = 63.7m,
                            Vat = 6.34m
                        }
                    },
                    new {
                        Name = "Paint",
                        Cost = new
                        {
                            Net = 85.3m,
                            Vat = 5.25m
                        }
                    },
                    new {
                        Name = "Window Replacement",
                        Cost = new
                        {
                            Net = 42.3m,
                            Vat = 3.25m
                        }
                    },
                    new {
                        Name = "Lightbulbs",
                        Cost = new
                        {
                            Net = 63.7m,
                            Vat = 6.34m
                        }
                    },
                    new {
                        Name = "Paint",
                        Cost = new
                        {
                            Net = 85.3m,
                            Vat = 5.25m
                        }
                    },
                    new {
                        Name = "Window Replacement",
                        Cost = new
                        {
                            Net = 42.3m,
                            Vat = 3.25m
                        }
                    },
                    new {
                        Name = "Lightbulbs",
                        Cost = new
                        {
                            Net = 63.7m,
                            Vat = 6.34m
                        }
                    },
                    new {
                        Name = "Paint",
                        Cost = new
                        {
                            Net = 85.3m,
                            Vat = 5.25m
                        }
                    },
                    new {
                        Name = "Window Replacement",
                        Cost = new
                        {
                            Net = 42.3m,
                            Vat = 3.25m
                        }
                    },
                    new {
                        Name = "Lightbulbs",
                        Cost = new
                        {
                            Net = 63.7m,
                            Vat = 6.34m
                        }
                    },
                    new {
                        Name = "Paint",
                        Cost = new
                        {
                            Net = 85.3m,
                            Vat = 5.25m
                        }
                    },
                    new {
                        Name = "Window Replacement",
                        Cost = new
                        {
                            Net = 42.3m,
                            Vat = 3.25m
                        }
                    },
                    new {
                        Name = "Lightbulbs",
                        Cost = new
                        {
                            Net = 63.7m,
                            Vat = 6.34m
                        }
                    },
                    new {
                        Name = "Paint",
                        Cost = new
                        {
                            Net = 85.3m,
                            Vat = 5.25m
                        }
                    },
                    new {
                        Name = "Window Replacement",
                        Cost = new
                        {
                            Net = 42.3m,
                            Vat = 3.25m
                        }
                    },
                    new {
                        Name = "Lightbulbs",
                        Cost = new
                        {
                            Net = 63.7m,
                            Vat = 6.34m
                        }
                    },
                }
            };
            var pdfRenderer = new PdfRenderer();
            await pdfRenderer.Render(json);
        }
    }
}