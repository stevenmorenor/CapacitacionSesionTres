using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Common;
using System.Configuration;

namespace ADO.NET
{
    internal class DBProviderFactories
    {
        static void Main()
        {
            string connectionString =
                ConfigurationManager.ConnectionStrings["Default"].ConnectionString;
            string provider =
                ConfigurationManager.ConnectionStrings["Default"].ProviderName;

            DbProviderFactory factory = DbProviderFactories.GetFactory(provider);

            DbConnection connection = factory.CreateConnection();
            connection.ConnectionString = connectionString;
            connection.Open();

            DbCommand command = connection.CreateCommand();

            command.CommandText = "Select * from futbolistas";

            var reader = command.ExecuteReader(CommandBehavior.CloseConnection);

            while (reader.Read())
            {
                Console.WriteLine(reader["futbolistas"]);
            }
            reader.Close();



        }
    }
}
