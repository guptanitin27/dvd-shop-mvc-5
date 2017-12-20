using System.Web;
using System.Web.Mvc;

namespace DVD_Shop
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
            filters.Add(new AuthorizeAttribute());// for authorization globaly 
            filters.Add(new RequireHttpsAttribute());// access only by https
        }
    }
}
