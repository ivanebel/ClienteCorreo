using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using MySql.Data.MySqlClient;

namespace ClienteCorreo.Utils
{
    public class Pool
    {
        public MySqlConnection conexion;
        
        public Pool() {
            initDataSource();
        }

        private void initDataSource() {
            Connection conn = Connection.getInstance();
            MySqlConnection myConn = new MySqlConnection();

            myConn.ConnectionString = conn.ConnString;

            conexion = myConn;
        }


    }
}
