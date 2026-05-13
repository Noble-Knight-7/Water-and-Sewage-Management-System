using Microsoft.Data.SqlClient;
using System.Configuration;

namespace WaterSewageManagementSystem.DataAccess
{
    public class DbConnection
    {
        private readonly string connectionString;

        public DbConnection()
        {
            connectionString = System.Configuration.ConfigurationManager
                .ConnectionStrings["WaterSewageDB"]
                .ConnectionString;
        }

        public SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}