using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Configuration;

namespace EsDnevnik
{
    class Connection
    {
        static public SqlConnection Connect()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["home"].ConnectionString;
            SqlConnection connection = new SqlConnection(connectionString);
            return connection;
        }
    }
}
