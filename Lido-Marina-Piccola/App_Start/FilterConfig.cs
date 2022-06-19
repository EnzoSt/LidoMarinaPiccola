using System.Web;
using System.Web.Mvc;

namespace Lido_Marina_Piccola
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
