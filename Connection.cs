using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;

namespace Alimentation
{
   static class Connection
    {

           static string sConnection;
        static MySqlConnection connection;
        static Connection()
        {
            sConnection = "user=root;password=siojjr;server=127.0.0.1;database=rallyeLecture";
             connection = new MySqlConnection(sConnection);
        }
        public static MySqlConnection GetConnection()
        {
            return Connection.connection;
        }
    }
}
