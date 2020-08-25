using System.Web;
using System.Web.Mvc;

namespace SEDC.AspNet.Class01.FullFrameworkReview
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
