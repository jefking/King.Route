using System.Web.Mvc;

namespace King.Route.Demo.MVC
{
    public class RouteConfig
    {
        public static void RegisterRoutes(System.Web.Routing.RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}