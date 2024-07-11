using System.Web;
using System.Web.Mvc;

namespace TranDuyVu_2210900138
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
