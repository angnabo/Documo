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
            renderer.Render();
        }
    }
}