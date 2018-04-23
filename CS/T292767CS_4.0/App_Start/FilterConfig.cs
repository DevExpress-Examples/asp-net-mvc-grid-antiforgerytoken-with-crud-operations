using System.Web;
using System.Web.Mvc;

namespace T292767CS_4_0 {
    public class FilterConfig {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters) {
            filters.Add(new HandleErrorAttribute());
        }
    }
}