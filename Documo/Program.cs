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
                            AddressLine1 = "123 Street",
                            AddressLine2 = "Leeds",
                            Postcode = "LS1 2AB"
                        },
                        FullName = "Angelica N",
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