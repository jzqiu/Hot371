using System.Web;
using System.Web.Mvc;

namespace Hot371.Site.Enterprise
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}