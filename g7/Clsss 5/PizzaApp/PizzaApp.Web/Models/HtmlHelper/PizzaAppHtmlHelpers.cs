using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.IO;

namespace PizzaApp.Web.Models.HtmlHelper
{
    public static class PizzaAppHtmlHelpers
    {
        public static IHtmlContent ButtonFor(this IHtmlHelper helper,string type,string value, string route,IEnumerable<string> cssClasses)
        {
            TagBuilder anchorTag = new TagBuilder("a");
            foreach (var cssClass in cssClasses)
            {
                anchorTag.AddCssClass(cssClass);
            }
            anchorTag.Attributes.Add("type", type);
            anchorTag.InnerHtml.Append(value);
            anchorTag.Attributes.Add("href", route);
            string result;
            using (var writer = new StringWriter())
            {
                anchorTag.WriteTo(writer, System.Text.Encodings.Web.HtmlEncoder.Default);
                result = writer.ToString();
            }
            return new HtmlString(result);
        }
    }
}
