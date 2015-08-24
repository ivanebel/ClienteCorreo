using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

using ClienteCorreo.Persistence;
using ClienteCorreo.DTO;
using MySql.Data.MySqlClient;

namespace ClienteCorreo.Persistence.MySQL
{
    public class CuentaSQL : ICuentaDAO
    {
        public MySqlConnection connection;

        /// <summary>
        /// Constructor de la clase CuentaSQL
        /// </summary>
        /// <param name="connection">Conexión creada</param>
        public CuentaSQL(MySqlConnection connection)
        {
            this.connection = connection;
        }

        /// <summary>
        /// Crea una nueva Cuenta en la Base de Datos
        /// </summary>
        /// <param name="cuenta"></param>
        /// <returns></returns>
        public int create(CuentaDTO cuenta)
        {
            int generatedKey;

            try
            {
                connection.Open();

                MySqlCommand myCommand = new MySqlCommand();
                myCommand.Connection = connection;

                myCommand.CommandText = "INSERT INTO cuenta (usuario,password,server_idserver) VALUES " +
                    "(?user, ?pwd, ?server)";

                myCommand.Parameters.Add("?user", MySqlDbType.VarChar).Value = cuenta.User;
                myCommand.Parameters.Add("?pwd", MySqlDbType.VarChar).Value = cuenta.Password;
                myCommand.Parameters.Add("?server", MySqlDbType.VarChar).Value = cuenta.Server;

                generatedKey = myCommand.ExecuteNonQuery();

                connection.Close();
            }
            catch (Exception)
            {

                throw;
            }

            return generatedKey;
        }

        /// <summary>
        /// Obtiene una Cuenta almacenada en la Base de Datos
        /// </summary>
        /// <param name="cuenta"></param>
        /// <returns></returns>
        public CuentaDTO get(CuentaDTO cuenta)
        {
            CuentaDTO cuentaObtenida = new CuentaDTO();

            try
            {
                connection.Open();

                MySqlCommand myCommand = new MySqlCommand();
                MySqlDataAdapter myAdapter = new MySqlDataAdapter();
                DataTable myData = new DataTable();

                myCommand.Connection = connection;

                myCommand.CommandText = "SELECT idcuenta,usuario,password,server_idserver FROM Cuenta WHERE " +
                    "idcuenta = ?idcuenta";

                myCommand.Parameters.Add("?idcuenta", MySqlDbType.VarChar).Value = cuenta.IdCuenta;

                myAdapter.SelectCommand = myCommand;
                myAdapter.Fill(myData);

                connection.Close();

                if (myData.Rows.Count != 0) {
                    cuentaObtenida.IdCuenta = int.Parse(myData.Rows[0].ItemArray.GetValue(0).ToString());
                    cuentaObtenida.User = myData.Rows[0].ItemArray.GetValue(1).ToString();
                    cuentaObtenida.Password = myData.Rows[0].ItemArray.GetValue(2).ToString();
                    cuentaObtenida.Server = int.Parse(myData.Rows[0].ItemArray.GetValue(3).ToString());
                }

            }
            catch (Exception ex) { }

            return cuentaObtenida;
        }

        /// <summary>
        /// Actualiza una Cuenta almacenada en la Base de Datos
        /// </summary>
        /// <param name="cuenta"></param>
        /// <returns></returns>
        public int update(CuentaDTO cuenta)
        {
            int generatedKey;

            try
            {
                connection.Open();

                MySqlCommand myCommand = new MySqlCommand();
                myCommand.Connection = connection;

                myCommand.CommandText = "UPDATE cuenta SET usuario = ?user,password = ?pwd,server_idserver = ?server) WHERE " +
                    "idcuenta = ?idcuenta";

                myCommand.Parameters.Add("?user", MySqlDbType.VarChar).Value = cuenta.User;
                myCommand.Parameters.Add("?pwd", MySqlDbType.VarChar).Value = cuenta.Password;
                myCommand.Parameters.Add("?server", MySqlDbType.VarChar).Value = cuenta.Server;

                myCommand.Parameters.Add("?idcuenta", MySqlDbType.VarChar).Value = cuenta.IdCuenta;

                generatedKey = myCommand.ExecuteNonQuery();

                connection.Close();
            }
            catch (Exception)
            {

                throw;
            }

            return generatedKey;
        }

        /// <summary>
        /// Obtiene una lista de las Cuentas almacenadas en la Base de Datos
        /// </summary>
        /// <returns></returns>
        public List<CuentaDTO> list()
        {
            CuentaDTO cuentaObtenida;
            List<CuentaDTO> list = new List<CuentaDTO>();

            try
            {
                connection.Open();

                MySqlCommand myCommand = new MySqlCommand();
                MySqlDataAdapter myAdapter = new MySqlDataAdapter();
                DataTable myData = new DataTable();

                myCommand.Connection = connection;

                myCommand.CommandText = "SELECT idcuenta,usuario,password,server_idserver FROM cuenta";

                myAdapter.SelectCommand = myCommand;
                myAdapter.Fill(myData);

                connection.Close();

                if (myData.Rows.Count != 0) {
                    for (int i = 0; i <= myData.Rows.Count - 1; i++) {
                        cuentaObtenida = new CuentaDTO();

                        cuentaObtenida.IdCuenta = int.Parse(myData.Rows[i].ItemArray.GetValue(0).ToString());
                        cuentaObtenida.User = myData.Rows[i].ItemArray.GetValue(1).ToString();
                        cuentaObtenida.Password = myData.Rows[i].ItemArray.GetValue(2).ToString();
                        cuentaObtenida.Server = int.Parse(myData.Rows[i].ItemArray.GetValue(3).ToString());

                        list.Add(cuentaObtenida);
                    }
                }
                
            }
            catch (Exception ex) { }

            return list;
        }

        /// <summary>
        /// Elimina una cuenta de la Base de Datos
        /// </summary>
        /// <param name="cuenta"></param>
        /// <returns></returns>
        public int delete(CuentaDTO cuenta)
        {
            int generatedKey=0;

            try
            {
                connection.Open();

                MySqlCommand myCommand = new MySqlCommand();
                myCommand.Connection = connection;

                myCommand.CommandText = "DELETE FROM cuenta WHERE cuenta_idcuenta = ?idcuenta";

                myCommand.Parameters.Add("?idcuenta", MySqlDbType.VarChar).Value = cuenta.IdCuenta;

                generatedKey = myCommand.ExecuteNonQuery();

                connection.Close();
            }
            catch (MySqlException ex)
            {

            }

            return generatedKey;
        }

        public int count(CuentaDTO cuenta) {
            int cantidad = 0;

            try
            {
                connection.Open();

                MySqlCommand myCommand = new MySqlCommand();
                myCommand.Connection = connection;

                myCommand.CommandText = "SELECT COUNT(*) FROM correo WHERE cuenta_idcuenta = ?idcuenta";
                myCommand.Parameters.Add("?idcuenta", MySqlDbType.Int16).Value = cuenta.IdCuenta;

                cantidad = int.Parse(myCommand.ExecuteScalar().ToString());

                connection.Close();

                return cantidad;
            }
            catch (MySqlException ex) {
                return -1;
            }
        }
    }
}
