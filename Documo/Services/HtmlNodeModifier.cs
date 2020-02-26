using AngleSharp.Dom;

namespace Documo.Services
{
    public class HtmlNodeModifier
    {
        public static void SetErrorColour(IElement node)
        {
            if (node.Attributes["style"] == null)
            {
                node.SetAttribute("style", "color:red;");
                return;
            }
            node.Attributes["style"].Value += "color:red;";
        }
    }
}