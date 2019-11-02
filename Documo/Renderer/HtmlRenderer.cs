using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Antlr4.Runtime;
using Documo.Services;
using Documo.Visitor;
using HtmlAgilityPack;

namespace Documo.Renderer
{
    public class HtmlRenderer
    {
        public void Render()
        {
            try
            {
                var doc = new HtmlDocument();
                doc.Load("/home/angelica/RiderProjects/Documo/Documo/NewFile1.html");

                var placeholderNodes = HtmlNodeExtractor.ExtractNodeOuterHtml(doc, "//p[@class='placeholder']");
                var input = string.Join("", placeholderNodes);
                var antlrService = new AntlrService();
                var placeholders = antlrService.Parse(input);
                

                foreach (var placeholder in placeholders)
                {
                    var nodes = HtmlNodeExtractor.SelectPlaceholderNodes(doc, placeholder.DocumentObject.GetPlaceholder());

                    foreach (var node in nodes)
                    {
                        HtmlNodeProcessor.ProcessPlaceholderNode(node, "");
                    }
                }

                
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex);
            }
        }
    }
}