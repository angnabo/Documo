using System;
using System.Linq;
using Antlr4.Runtime;
using Documo.Renderer;
using Documo.Visitor;
using HtmlAgilityPack;

namespace Documo
{
    class Program
    {
        static void Main(string[] args)
        {
            var renderer = new HtmlRenderer();

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
                Services = new []
                {
                    new {
                        Name = "Paint",
                        Cost = 87.89m
                    },
                    new {
                        Name = "Window Replacement",
                        Cost = 34.2m
                    },
                    new {
                        Name = "Lightbulbs",
                        Cost = 34.2m
                    },
                }
            };
            renderer.Render(json);
        }
    }
}