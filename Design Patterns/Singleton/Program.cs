
using Microsoft.Extensions.Configuration;

namespace Singleton
{
    public class Program
    {
        private static IConfiguration configuration;

        public static void Main(string[] args)
        {
            SetConfiguration();

            DatabaseConnection db = DatabaseConnection.OpenConnection(configuration.GetConnectionString("default"));

            db.ExecuteQuery("Some query");
        }

        private static void SetConfiguration()
        {
            configuration = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json")
                .Build();
        }
    }
}

