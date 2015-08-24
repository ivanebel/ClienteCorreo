using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

using MySql.Data.MySqlClient;
using ClienteCorreo.DTO;
using ClienteCorreo.Persistence;

namespace ClienteCorreo.Persistence.MySQL
{
    /// <summary>
    /// Clase para realizar la transición del modelo relacional al modelo objeto de la Configuración.
    /// </summary>
    public class ConfiguracionSQL : IConfiguracionDAO
    {
        private MySqlConnection connection;

        /// <summary>
        /// Constructor de la clase ConfiguracionSQL.
        /// </summary>
        /// <param name="connection">Conexión creada</param>
        public ConfiguracionSQL(MySqlConnection connection) {
            this.connection = connection;
        }

        
        public void modificarConfiguracion(ConfiguracionDTO config) {
            try
            {
                MySqlCommand myCommand = new MySqlCommand();
                myCommand.Connection = connection;

                myCommand.CommandText = "UPDATE tConfiguracion (val1,val2) VALUES (?cantcorreos,?rutaarchivos)";

                //myCommand.CommandText = "INSERT INTO tCorreo (cuenta,asunto,detalle,leido,tipo,fecha,numserver) VALUES " +
                //    "(?cuenta,?asunto,?detalle,?leido,?tipo,?fecha,?numserver)";

                //myCommand.Parameters.Add("?cuenta", MySqlDbType.VarChar).Value = correo.IdCuenta;
                //myCommand.Parameters.Add("?asunto", MySqlDbType.VarChar).Value = correo.Asunto;
                //myCommand.Parameters.Add("?detalle", MySqlDbType.VarChar).Value = correo.Detalle;
                //myCommand.Parameters.Add("?leido", MySqlDbType.VarChar).Value = correo.Read;
                //myCommand.Parameters.Add("?tipo", MySqlDbType.VarChar).Value = correo.TipoCorreo;
                //myCommand.Parameters.Add("?fecha", MySqlDbType.VarChar).Value = correo.Fecha;
                //myCommand.Parameters.Add("?numserver", MySqlDbType.VarChar).Value = correo.NumeroServidorCorreo;

                myCommand.Parameters.Add("?cantcorreos", MySqlDbType.Int16).Value = config.CantidadCorreos;
                myCommand.Parameters.Add("?rutaarchivos", MySqlDbType.VarChar).Value = config.Patch;

                myCommand.ExecuteNonQuery();


            }
            catch (MySqlException ex) { }
        }


        public ConfiguracionDTO getConfiguracion()
        {
            ConfiguracionDTO config = new ConfiguracionDTO();
            try {
                connection.Open();

                MySqlCommand myCommand = new MySqlCommand();
                MySqlDataAdapter myAdapter = new MySqlDataAdapter();
                DataTable myData = new DataTable();

                myCommand.Connection = connection;

                myCommand.CommandText = "SELECT cantidadcorreos,ruta FROM configuracion";
                myAdapter.SelectCommand = myCommand;
                myAdapter.Fill(myData);

                connection.Close();

                if (myData.Rows.Count != 0) {
                    for (int i = 0; i <= myData.Rows.Count - 1; i++) {
                        config.CantidadCorreos = Int16.Parse(myData.Rows[i].ItemArray.GetValue(0).ToString());
                        config.Patch = myData.Rows[i].ItemArray.GetValue(1).ToString();
                        //config.Patch = config.Patch.Replace("\\\\", "\\");
                        //config.Patch = config.Patch.Remove(config.Patch.Length - 1);
                    }
                }


            }
            catch (MySqlException ex) { }

            return config;

        }
    }
}
