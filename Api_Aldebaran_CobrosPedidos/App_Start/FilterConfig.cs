using System.Web;
using System.Web.Mvc;

namespace Api_Aldebaran_CobrosPedidos
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
