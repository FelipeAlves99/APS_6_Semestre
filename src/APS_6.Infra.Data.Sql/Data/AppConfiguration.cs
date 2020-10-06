using Microsoft.Extensions.Configuration;
using System.IO;

namespace APS_6.Infra.Data.Sql.Data
{
    public class AppConfiguration
    {
        public AppConfiguration()
        {
            //var configurationBuilder = new ConfigurationBuilder();
            //var path = Path.Combine(Directory.GetCurrentDirectory(), "appsettings.json");
            //configurationBuilder.AddJsonFile(path, false);

            //var root = configurationBuilder.Build();
            //ConnectionString = root.GetSection("ConnectionStrings").GetSection("DefaultConnection").Value;            
        }

        public string ConnectionString { get; } = "Server=localhost\\SQLEXPRESS;Initial Catalog=APS6;Integrated Security=False;User ID=sa;Password=1q2w3e%&!";
    }
}
