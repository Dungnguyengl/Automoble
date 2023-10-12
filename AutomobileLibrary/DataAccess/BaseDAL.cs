using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomobileLibrary.DataAccess
{
    public class BaseDAL
    {
        public StockDataProvider? DataProvider { get; set; } = null;
        public SqlConnection? Connection = null;

        public BaseDAL()
        {
            var connectionString = GetConnectionString();
            DataProvider = new StockDataProvider(connectionString);
        }

        // Will need appsettings.json to exist in AutomobileWinApp project's folder
        public string? GetConnectionString()
        {
            string? connectionString;
            IConfiguration config = new ConfigurationBuilder()
                    .SetBasePath(Directory.GetCurrentDirectory())
                    .AddJsonFile("appsettings.json",true,true) .Build();
            connectionString = config["ConnectionString:MyStockDB"];
            return connectionString;
        }

        public void CloseConnection()=>DataProvider.CloseConnection(Connection);
    }
}
