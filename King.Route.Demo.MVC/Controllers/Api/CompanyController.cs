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
            return this.route.Get<IEnumerable<Company>>("CompanyStorage/Save", model);
        }
        
        public void Post([FromBody] Company model)
        {
            this.route.Send("CompanyStorage/Search", model);
        }
    }
}