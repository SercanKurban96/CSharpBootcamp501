using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBootcamp501.ConnectionString
{
    public static class DatabaseConnectionString
    {
        public static void SQLDatabaseConnectionString()
        {
            SqlConnection connection = new SqlConnection("Server=SERCAN\\SQLEXPRESS;initial catalog=Bootcamp501Db;integrated security=true");
        }
    }
}
