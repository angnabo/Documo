using System;
using System.Globalization;
using System.Linq;
using System.Net;
using AngleSharp;
using AngleSharp.Dom;
using Documo.Services;
using Documo.Visitor;

namespace Documo.Strategies
{
    public class ImagePlaceholderProcessor : IProcessPlaceholder
    {

        private const string ImageNotFoundError = "https://i.imgur.com/bZ3WcsA.png";
        public bool AppliesTo(DocumentPlaceholder placeholder)
        {
            return placeholder.GetType() == typeof(ImagePlaceholder);
        }

        public async void ProcessPlaceholders(IElement doc, DocumentPlaceholder placeholder, object jsonData)
        {
            var placeholderNodes = HtmlNodeExtractor.GetImagePlaceholderNode(doc, placeholder.GetPlaceholder()).ToArray();
            if (!placeholderNodes.Any()) return;
            
            try
            {
                var value = JsonResolver.Resolve(jsonData, placeholder.ObjectName).ToString();

                if (IsImageUrl(value))
                {
                    foreach (var node in placeholderNodes)
                    {
                        node.SetAttribute("src", value);
                        HtmlNodeModifier.SetImageDimentions(node);
                    }
                }
                else
                {
                    throw new Exception("The url returned invalid content type.");
                }
            }
            catch (Exception e)
            {
                foreach (var node in placeholderNodes)
                {
                    node.SetAttribute("src", ImageNotFoundError);
                    var context = BrowsingContext.New(Configuration.Default);
                    var document = await context.OpenAsync(r => r.Content($"<span>Image error: {e.Message}</span>"));
                    var errorNode = document.QuerySelector("span");
                    HtmlNodeModifier.SetErrorColour(errorNode);
                    node.After(errorNode);
                }
            }
        }
        
        private static bool IsImageUrl(string URL)
        {
            var req = (HttpWebRequest)HttpWebRequest.Create(URL);
            req.Method = "HEAD";
            using var resp = req.GetResponse();
            return resp.ContentType.ToLower(CultureInfo.InvariantCulture)
                .StartsWith("image/");
        }
    }
}