using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(King.Route.Demo.MVC.Startup))]
namespace King.Route.Demo.MVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            var config = new RoutingConfiguration();
            config.MapAttributeRoutes();
        }
    }
}