using System.Web;
using System.Web.Mvc;

namespace PRACTICA_AEAE_3
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
