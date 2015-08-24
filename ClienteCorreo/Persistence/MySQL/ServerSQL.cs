using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using ClienteCorreo.DTO;
using ClienteCorreo.Persistence;
using MySql.Data.MySqlClient;

namespace ClienteCorreo.Persistence.MySQL
{
    /// <summary>
    /// Clase para realizar la trancisión del modelo relacional a objeto para el Servidor.
    /// </summary>
    public class ServerSQL : IServerDAO
    {
        private MySqlConnection connection;

        /// <summary>
        /// Constructor de la clase ServerSQL.
        /// </summary>
        /// <param name="connection">Conexión creada</param>
        public ServerSQL(MySqlConnection connection) {
            this.connection = connection;
        }

        /// <summary>
        /// Agrega un nuevo servidor a la Base de Datos.
        /// </summary>
        /// <param name="server">Servidor a agregar</param>
        /// <returns>True si se agregó con éxito - False si ocurrió un error al ejecutar la consulta</returns>
        public int save(ServerDTO server)  {
            int generatedKey;

            try
            {
                connection.Open();

                MySqlCommand myCommand = new MySqlCommand();
                myCommand.Connection = connection;

                myCommand.CommandText = "INSERT INTO server (nombre,popurl,smtpurl,popport,smtpport,isssl ) VALUES " +
                    "(?name, ?popserver, ?smtpserver, ?popport, ?smtpport, ?ssl)  ";

                myCommand.Parameters.Add("?name", MySqlDbType.VarChar).Value = server.Name;
                myCommand.Parameters.Add("?popserver", MySqlDbType.VarChar).Value = server.PopServer;
                myCommand.Parameters.Add("?smtpserver", MySqlDbType.VarChar).Value = server.SmtpServer;
                myCommand.Parameters.Add("?popport", MySqlDbType.VarChar).Value = server.PopPort;
                myCommand.Parameters.Add("?smtpport", MySqlDbType.VarChar).Value = server.SmtpPort;
                myCommand.Parameters.Add("?ssl",MySqlDbType.Int16).Value = server.Ssl;

                generatedKey = myCommand.ExecuteNonQuery();

                connection.Close();

            }
            catch (Exception)
            {
                
                throw ;
            }

            return generatedKey;
        }

        /// <summary>
        /// Obtiene un servidor almacenado en la Base de Datos.
        /// </summary>
        /// <param name="server">Servidor a obtener</param>
        /// <returns>Servidor encontrado</returns>
        public ServerDTO get(ServerDTO server) {
            ServerDTO serverObtenido = new ServerDTO();

            try
            {
                connection.Open();

                MySqlCommand myCommand = new MySqlCommand();
                myCommand.Connection = connection;

                myCommand.CommandText = "SELECT idserver,nombre,popurl,popport,smtpurl,smtpport,isssl FROM server WHERE " +
                    "idserver = ?idserver";

                myCommand.Parameters.Add("?idserver", MySqlDbType.VarChar).Value = server.Id;

                MySqlDataReader myReader = myCommand.ExecuteReader();

                

                while (myReader.Read())
                {
                    serverObtenido.Id = myReader.GetInt32(0);
                    serverObtenido.Name = myReader.GetString(1);
                    serverObtenido.PopServer = myReader.GetString(2);
                    serverObtenido.PopPort = myReader.GetInt32(3);
                    serverObtenido.SmtpServer = myReader.GetString(4);
                    serverObtenido.SmtpPort = myReader.GetInt32(5);
                    serverObtenido.Ssl = myReader.GetBoolean(6);
                }

                myReader.Close();

                connection.Close();

            }
            catch (MySqlException ex) { }

            return serverObtenido;

        }

        /// <summary>
        /// Lista todos los servidores existentes en la Base de Datos.
        /// </summary>
        /// <returns>Lista de ServerDTO</returns>
        public List<ServerDTO> list() {
            ServerDTO serverObtenido;
            List<ServerDTO> list = new List<ServerDTO>();

            try {
                connection.Open();

                MySqlCommand myCommand = new MySqlCommand();
                myCommand.Connection = connection;

                myCommand.CommandText = "SELECT idserver,nombre,popurl,popport,smtpurl,smtpport,isssl FROM server";

                MySqlDataReader myReader = myCommand.ExecuteReader();          

                while (myReader.Read()) {
                    serverObtenido = new ServerDTO();

                    serverObtenido.Id = myReader.GetInt32(0);
                    serverObtenido.Name = myReader.GetString(1);
                    serverObtenido.PopServer = myReader.GetString(2);
                    serverObtenido.PopPort = myReader.GetInt32(3);
                    serverObtenido.SmtpServer = myReader.GetString(4);
                    serverObtenido.SmtpPort = myReader.GetInt32(5);
                    serverObtenido.Ssl = myReader.GetBoolean(6);

                    list.Add(serverObtenido);
                }

                myReader.Close();

                connection.Close();

            }
            catch (MySqlException ex) { }

            return list;
        }

        /// <summary>
        /// Actualiza un Servidor.
        /// </summary>
        /// <param name="server">Servidor a actualizar</param>
        /// <returns></returns>
        public int update(ServerDTO server) {
            int generatedKey = -1;

            try {
                MySqlCommand myCommand = new MySqlCommand();
                myCommand.Connection = connection;

                myCommand.CommandText = "UPDATE server SET nombre = ?name, popurl = ?popserver, smtpurl = ?smtpserver, popport = ?popport, smtpport = ?smtpport, isssl = ?ssl WHERE " +
                    "idserver = ?idserver";

                myCommand.Parameters.Add("?name", MySqlDbType.VarChar).Value = server.Name;
                myCommand.Parameters.Add("?popserver", MySqlDbType.VarChar).Value = server.PopServer;
                myCommand.Parameters.Add("?smtpserver", MySqlDbType.VarChar).Value = server.SmtpServer;
                myCommand.Parameters.Add("?popport", MySqlDbType.VarChar).Value = server.PopPort;
                myCommand.Parameters.Add("?smtpport", MySqlDbType.VarChar).Value = server.SmtpPort;
                myCommand.Parameters.Add("?ssl", MySqlDbType.VarChar).Value = server.Ssl;

                myCommand.Parameters.Add("?idserver", MySqlDbType.VarChar).Value = server.Id;

                //Puede ser que sea algo tipo generatedKey = myCommand.ExecuteNonQuery();
                generatedKey = myCommand.ExecuteNonQuery();
                
            }
            catch (Exception ex) { }

            return generatedKey;
        }

        /// <summary>
        /// Elimina un Servidor de la Base de Datos.
        /// </summary>
        /// <param name="server">Servidor a eliminar</param>
        /// <returns></returns>
        public int delete(ServerDTO server) {
            int generatedKey = -1;

            try
            {
                MySqlCommand myCommand = new MySqlCommand();
                myCommand.Connection = connection;

                myCommand.CommandText = "DELETE FROM server WHERE idserver = ?idserver";

                myCommand.Parameters.Add("?idserver", MySqlDbType.VarChar).Value = server.Id;

                //Puede ser que sea algo tipo generatedKey = myCommand.ExecuteNonQuery();
                generatedKey = myCommand.ExecuteNonQuery();

            }
            catch (Exception ex) { }

            return generatedKey;

        }

    }
}
