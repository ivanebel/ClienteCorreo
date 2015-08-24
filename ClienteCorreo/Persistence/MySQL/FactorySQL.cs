using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using ClienteCorreo.Persistence;
using ClienteCorreo.Utils;

using MySql.Data.MySqlClient;

namespace ClienteCorreo.Persistence.MySQL
{
    public class FactorySQL : Factory
    {
        private MySqlConnection conexion;
        int num = 0;

        private String login = Connection.getInstance().User;
        private String password = Connection.getInstance().Pwd;
        private String driver = Connection.getInstance().Driver;
        private String dbUrl = Connection.getInstance().Url;
        public String connString = Connection.getInstance().GetConnectionString();

        private MySqlConnection connection;

        public FactorySQL() { }

        override
            public void startConnection() {
                try
                {
                    Pool pool = new Pool();
                    conexion = pool.conexion;
                    num++;

                }
                catch (MySqlException ex) { }
        }

        override
            public void closeConnection() {

                try
                {
                    conexion.Close();
                    num--;
                }
                catch (MySqlException ex) { }
        }

        override
        public ICorreoDAO getCorreo()
        {
            return new CorreoSQL(conexion);
        }

        override
        public ICuentaDAO getCuenta()
        {
            return new CuentaSQL(conexion);
        }

        override
        public IServerDAO getServer()
        {
            return new ServerSQL(conexion);
        }

        override
        public IConfiguracionDAO getConfiguracion()
        {
            return new ConfiguracionSQL(conexion);
        }

    }
}
