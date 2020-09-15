using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.Routing;
using System.Collections.Generic;
using System.IO;

namespace PizzaApp.Web.Models.CustomHtmlHelpers
{
    public static class PizzaAppHtmlHelpers
    {
       public static IHtmlContent Button(this IHtmlHelper helper,string type,string value,IEnumerable<string> cssClasses,string href)
       {
            TagBuilder a = new TagBuilder("a");
            foreach (var cssClass in cssClasses)
            {
                a.AddCssClass(cssClass);
            }
            a.Attributes.Add("type", type);
            a.Attributes.Add("href", href);
            a.InnerHtml.Append(value);
            string result;
            using (var writer = new StringWriter())
            {
                a.WriteTo(writer, System.Text.Encodings.Web.HtmlEncoder.Default);
                result = writer.ToString();
            }

            return new HtmlString(result);
        }
    }
}
