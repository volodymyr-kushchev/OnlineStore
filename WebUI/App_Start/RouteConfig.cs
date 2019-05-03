using System.Web.Mvc;
using System.Web.Routing;
namespace WebUI
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                 null,
                 "",
                 new { controller = "Books", action = "List", genre = (string)null, page = 1 }
             );
            // example: .../Page234
            routes.MapRoute(
                name: null,
                url: "Page{page}",
                defaults: new { controller = "Books", action = "List", genre = (string)null },
                constraints: new { page = @"\d+" }// only numbers
            );
            // example: ...Books/List
            routes.MapRoute(
                null,
                "{controller}/{action}"
            );
            
        }
    }
}
