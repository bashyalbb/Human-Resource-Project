using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;

namespace HRMS
{
    class DBConnection
    {
        public MySqlConnection con;
        public DBConnection()
        {
            String conString = "Server=localhost;Database=hrms;Uid=root;";
            con = new MySqlConnection(conString);
            con.Open();
        }
    }
}
