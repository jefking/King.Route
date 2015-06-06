namespace King.Route.Demo.MVC.Controllers.Api
{
    using System.Collections.Generic;
    using System.Web.Http;
    using King.Route.Demo.MVC.Models;

    public class CompanyController : ApiController
    {
        private readonly IRouteTo route = new DirectRoute();

        public IEnumerable<Company> Get([FromUri] Company model)
        {
            return null;
        }
        
        public void Post([FromBody] Company model)
        {
        }
    }
}