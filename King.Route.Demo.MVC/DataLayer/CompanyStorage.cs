namespace King.Route.Demo.MVC.DataLayer
{
    using System;
    using System.Collections.Generic;
    using King.Azure.Data;
    using King.Route.Demo.MVC.Models;

    [RouteAlias("CompanyStorage")]
    public class CompanyStorage
    {
        private readonly ITableStorage storage = new TableStorage("", "");

        public void Save(Company company)
        {
            //storage.InsertOrReplace()
        }

        public IEnumerable<Company> Search(Guid id, string name)
        {
            return null;
        }
    }
}
