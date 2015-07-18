namespace King.Route.Demo.MVC.DataLayer
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using King.Azure.Data;
    using King.Route.Demo.MVC.Models;
    using Microsoft.Azure;
    using Microsoft.WindowsAzure.Storage.Table;

    [RouteAlias("CompanyStorage")]
    public class CompanyStorage
    {
        private static readonly string connection = CloudConfigurationManager.GetSetting("StorageAccount");
        private readonly ITableStorage storage = new TableStorage("company_route", connection);

        public async Task Save(Company company)
        {
            var c = new TableEntity()
            {
                RowKey = company.Identifer.ToString(),
                PartitionKey = company.Name,
            };

            await storage.InsertOrReplace(c);
        }

        public async Task<Company> Search(Guid id, string name)
        {
            if (Guid.Empty != id && !string.IsNullOrWhiteSpace(name))
            {
                var cs = await this.storage.QueryByPartitionAndRow(name, id.ToString());

                return new Company()
                {
                    Identifer = Guid.Parse(cs[TableStorage.RowKey] as string),
                    Name = cs[TableStorage.PartitionKey] as string
                };
            }
            //else if (Guid.Empty != id)
            //{
            //    return await this.storage.QueryByRow<Company>(id.ToString());
            //}
            //else if (!string.IsNullOrWhiteSpace(name))
            //{
            //    return await this.storage.QueryByPartition<Company>(name);
            //}
            else
            {
                return null;
            }
        }
    }
}