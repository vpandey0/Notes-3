using System.Web;
using System.Web.Mvc;

namespace RelationshipOneToMany_FluentApi
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
