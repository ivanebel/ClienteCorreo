using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

using ClienteCorreo.DTO;
using ClienteCorreo.Persistence;
using MySql.Data.MySqlClient;

namespace ClienteCorreo.Persistence.MySQL
{
    /// <summary>
    /// Clase para realizar la transferencia del modelo relacional al objeto para un Correo.
    /// </summary>
    public class CorreoSQL : ICorreoDAO
    {
        private MySqlConnection connection;

        /// <summary>
        /// Constructor de la clase CorreoSQL.
        /// </summary>
        /// <param name="connection">Conexión existente</param>
        public CorreoSQL(MySqlConnection connection)
        {
            this.connection = connection;
        }


        /// <summary>
        /// Crea un nuevo Correo en la BBDD.
        /// </summary>
        /// <param name="correo"></param>
        /// <returns></returns>
        public int create(CorreoDTO correo)
        {
            int generatedKey = 0;

            try
            {
                connection.Open();

                MySqlCommand myCommand = new MySqlCommand();
                myCommand.Connection = connection;

                myCommand.CommandText = "INSERT INTO correo (cuenta_idcuenta,asunto,detalle,leido,tipocorreo,fecha,server_idserver) VALUES " +
                    "(?cuenta,?asunto,?detalle,?leido,?tipo,?fecha,?numserver)";

                myCommand.Parameters.Add("?cuenta", MySqlDbType.VarChar).Value = correo.IdCuenta;
                myCommand.Parameters.Add("?asunto", MySqlDbType.VarChar).Value = correo.Asunto;
                myCommand.Parameters.Add("?detalle", MySqlDbType.VarChar).Value = correo.Detalle;
                myCommand.Parameters.Add("?leido", MySqlDbType.VarChar).Value = correo.Read;
                myCommand.Parameters.Add("?tipo", MySqlDbType.VarChar).Value = correo.TipoCorreo;
                myCommand.Parameters.Add("?fecha", MySqlDbType.VarChar).Value = correo.Fecha;
                myCommand.Parameters.Add("?numserver", MySqlDbType.VarChar).Value = correo.NumeroServidorCorreo;

                generatedKey = myCommand.ExecuteNonQuery();

                

                List<AttachmentDTO> adjuntos = correo.Adjuntos;

                if (adjuntos != null) {
                    foreach (AttachmentDTO adjunto in adjuntos)
                    {
                        
                        try
                        {
                            myCommand.CommandText = "SELECT LAST_INSERT_ID()";
                            string strId = myCommand.ExecuteScalar().ToString();
                            adjunto.IdCorreo = int.Parse(strId);
                        }
                        catch (MySqlException e) 
                        {
                            adjunto.IdCorreo = 0;
                        }

                        //Necesito obtener el idcorreo generado en la query anterior.

                        
                        try
                        {
                            myCommand.CommandText = "INSERT INTO adjunto (detalle,path,correo_idcorreo) VALUES " +
                                "(?detalleadj,?path,?correoid)";
                            myCommand.Parameters.Add("?detalleadj", MySqlDbType.VarChar).Value = adjunto.Name;
                            myCommand.Parameters.Add("?path", MySqlDbType.VarChar).Value = adjunto.Path;
                            myCommand.Parameters.Add("?correoid", MySqlDbType.Int16).Value = adjunto.IdCorreo;

                            
                            myCommand.ExecuteNonQuery();
                        }
                        catch (MySqlException e) {
                            connection.Close();
                        }
                    }
                }

                List<OrigenDestinoDTO> destinos = correo.OrigenDestino;

                if (destinos != null) {
                    foreach (OrigenDestinoDTO destino in destinos)
                    {
                        destino.IdCorreo = generatedKey;

                        try
                        {
                            int idmaillocal = 0;
                            myCommand.CommandText = "SELECT MAX(idcorreo) FROM correo";

                            String strtemp = myCommand.ExecuteScalar().ToString();

                            idmaillocal = int.Parse(strtemp);

                            myCommand.CommandText = "INSERT INTO origendestino (direccion,cc,cco,correo_idcorreo) VALUES " +
                                "(?direccion,?cc,?cco,?correoidd)";
                            myCommand.Parameters.Add("?direccion", MySqlDbType.VarChar).Value = destino.Direccion;
                            myCommand.Parameters.Add("?cc", MySqlDbType.VarChar).Value = destino.Cc;
                            myCommand.Parameters.Add("?cco", MySqlDbType.VarChar).Value = destino.Cco;
                            myCommand.Parameters.Add("?correoidd", MySqlDbType.Int16).Value = idmaillocal;                  //destino.IdCorreo;

                            myCommand.ExecuteNonQuery();
                        }
                        catch (MySqlException e) {
                            connection.Close();
                        }
                    }
                }

            }
            catch (MySqlException ex) {
                connection.Close();
            }

            connection.Close();

            return generatedKey;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="correo"></param>
        /// <returns></returns>
        public CorreoDTO get(CorreoDTO correo)
        {
            CorreoDTO correoObtenido = new CorreoDTO();

            try {
                connection.Open();

                MySqlCommand myCommand = new MySqlCommand();
                MySqlDataAdapter myAdapter = new MySqlDataAdapter();
                DataTable myData = new DataTable();

                myCommand.Connection = connection;

                myCommand.CommandText = "SELECT idcorreo,asunto,detalle,tipocorreo,fecha,leido,server_idserver FROM correo WHERE idcorreo=?idcorreo";
                myCommand.Parameters.Add("?idcorreo", MySqlDbType.Int16).Value = correo.IdCorreo;

                myAdapter.SelectCommand = myCommand;
                myAdapter.Fill(myData);

                connection.Close();

                if (myData.Rows.Count != 0) {
                    for (int i = 0; i <= myData.Rows.Count - 1; i++) {
                        correoObtenido.IdCorreo = int.Parse(myData.Rows[i].ItemArray.GetValue(0).ToString()) ;
                        correoObtenido.Asunto = myData.Rows[i].ItemArray.GetValue(1).ToString();
                        correoObtenido.Detalle= myData.Rows[i].ItemArray.GetValue(2).ToString();
                        //correoObtenido.TipoCorreo = myData.Rows[i].ItemArray.GetValue(3).ToString();
                        correoObtenido.TipoCorreo = Tipo.RECIBIDO;
                        string fechaStr = myData.Rows[i].ItemArray.GetValue(4).ToString();
                        fechaStr = fechaStr.Substring(0, 10);
                        correoObtenido.Fecha= DateTime.Parse(fechaStr);
                        correoObtenido.Read = bool.Parse(myData.Rows[i].ItemArray.GetValue(5).ToString());
                        correoObtenido.NumeroServidorCorreo= int.Parse(myData.Rows[i].ItemArray.GetValue(6).ToString());

                        List<AttachmentDTO> adjuntos = new List<AttachmentDTO>();
                        try
                        {
                            myCommand.CommandText = "SELECT idadjunto,detalle,path,correo_idcorreo FROM adjunto WHERE correo_idcorreo=?idcorreoo";
                            myCommand.Parameters.Add("?idcorreoo", MySqlDbType.Int16).Value = correo.IdCorreo;
                            DataTable myDataAdj = new DataTable();
                            myAdapter.SelectCommand = myCommand;
                            myAdapter.Fill(myDataAdj);

                            if (myDataAdj.Rows.Count != 0) {
                                for (int j = 0; j <= myDataAdj.Rows.Count - 1; j++) {
                                    AttachmentDTO adjunto = new AttachmentDTO();
                                    adjunto.IdAttachment = int.Parse(myDataAdj.Rows[j].ItemArray.GetValue(0).ToString());
                                    adjunto.Name = myDataAdj.Rows[j].ItemArray.GetValue(1).ToString();
                                    adjunto.Path = myDataAdj.Rows[j].ItemArray.GetValue(2).ToString();
                                    adjunto.IdCorreo = int.Parse(myDataAdj.Rows[j].ItemArray.GetValue(3).ToString());

                                    adjuntos.Add(adjunto);
                                }
                            }
                        }
                        catch (MySqlException e) { }

                        correoObtenido.Adjuntos = adjuntos;

                        List<OrigenDestinoDTO> origenes = new List<OrigenDestinoDTO>();
                        try
                        {
                            myCommand.CommandText = "SELECT idorigendestino,direccion,cc,cco,correo_idcorreo FROM origendestino WHERE correo_idcorreo=?idcorreooo";
                            myCommand.Parameters.Add("?idcorreooo", MySqlDbType.Int16).Value = correo.IdCorreo;
                            DataTable myDataOri = new DataTable();
                            myAdapter.SelectCommand = myCommand;
                            myAdapter.Fill(myDataOri);

                            if (myDataOri.Rows.Count != 0) {
                                for (int j = 0; j <= myDataOri.Rows.Count - 1; j++) {
                                    OrigenDestinoDTO origen = new OrigenDestinoDTO();
                                    origen.IdOrigenDestino = int.Parse(myDataOri.Rows[j].ItemArray.GetValue(0).ToString());
                                    origen.Direccion = myDataOri.Rows[j].ItemArray.GetValue(1).ToString();
                                    origen.Cc = bool.Parse(myDataOri.Rows[j].ItemArray.GetValue(2).ToString());
                                    origen.Cco = bool.Parse(myDataOri.Rows[j].ItemArray.GetValue(3).ToString());
                                    origen.IdCorreo = int.Parse(myDataOri.Rows[j].ItemArray.GetValue(4).ToString());

                                    origenes.Add(origen);
                                }
                            }
                        }
                        catch (MySqlException e) { }

                        correoObtenido.OrigenDestino = origenes;
                    }
                }

            }
            catch (MySqlException ex) { }

            return correoObtenido;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="correo"></param>
        /// <returns></returns>
        public int update(CorreoDTO correo)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="correo"></param>
        /// <returns></returns>
        public int markAsRead(CorreoDTO correo, bool leido)
        {
            int res = 0;

            try {
                connection.Open();

                MySqlCommand myCommand = new MySqlCommand();
                myCommand.Connection = connection;
                myCommand.CommandText = "UPDATE correo SET leido=?leido WHERE idcorreo=?idcorreo";

                if(leido)
                    myCommand.Parameters.Add("?leido", MySqlDbType.Int16).Value = 1;
                else
                    myCommand.Parameters.Add("?leido", MySqlDbType.Int16).Value = 0;

                myCommand.Parameters.Add("?idcorreo", MySqlDbType.Int16).Value = correo.IdCorreo;
                myCommand.ExecuteNonQuery();

                connection.Close();

                res = 1;
                return res;
            }
            catch (MySqlException ex) {
                return -1;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="read"></param>
        /// <param name="sent"></param>
        /// <param name="cant"></param>
        /// <returns></returns>
        public List<CorreoDTO> list(bool read, bool sent, int cant, CuentaDTO cuenta = null)
        {
            CorreoDTO correo;
            List<CorreoDTO> correos = new List<CorreoDTO>();

            try {
                connection.Open();

                MySqlCommand myCommand = new MySqlCommand();
                myCommand.Connection = connection;
                MySqlDataAdapter myAdapter = new MySqlDataAdapter();
                DataTable myData = new DataTable();

                string query = "SELECT idcorreo,asunto,detalle,tipocorreo,fecha,leido,cuenta_idcuenta FROM correo WHERE 1=1";

                //Agrego texto a la query si así lo indica cada filtro
                if (cuenta != null)
                    query += " AND cuenta_idcuenta=?idcuenta";
                if (read) query += " AND leido=?leido";
                if (sent)
                    query += " AND tipocorreo='ENVIADO'";
                else
                    query += " AND tipocorreo='RECIBIDO'";
                query += " ORDER BY idcorreo DESC";
                if (cant != 0) query += " LIMIT ?cant";

                myCommand.CommandText = query;

                if(cuenta != null)  {myCommand.Parameters.Add("?idcuenta",MySqlDbType.Int16).Value = cuenta.IdCuenta;}
                myCommand.Parameters.Add("?leido", MySqlDbType.Int16).Value = read;
                myCommand.Parameters.Add("?cant", MySqlDbType.Int16).Value = cant;

                myAdapter.SelectCommand = myCommand;
                myAdapter.Fill(myData);

                connection.Close();

                if (myData.Rows.Count != 0) {
                    for (int i = 0; i <= myData.Rows.Count - 1; i++) {
                        correo = new CorreoDTO();

                        correo.IdCorreo = int.Parse(myData.Rows[i].ItemArray.GetValue(0).ToString());
                        correo.Asunto = myData.Rows[i].ItemArray.GetValue(1).ToString();
                        correo.Detalle = myData.Rows[i].ItemArray.GetValue(2).ToString();
                        correo.TipoCorreo = Tipo.ENVIADO;                                           //!!!!!!!!

                        String fechaStr = myData.Rows[i].ItemArray.GetValue(4).ToString();
                        fechaStr = fechaStr.Substring(0, 10);

                        correo.Fecha = DateTime.Parse(fechaStr);
                        
                        correo.Read = bool.Parse(myData.Rows[i].ItemArray.GetValue(5).ToString());
                        correo.IdCuenta = int.Parse(myData.Rows[i].ItemArray.GetValue(6).ToString());

                        List<OrigenDestinoDTO> direcciones = new List<OrigenDestinoDTO>();

                        try {
                            DataTable myDataDir = new DataTable();

                            myCommand.CommandText = "SELECT idorigendestino,direccion,cc,cco,correo_idcorreo FROM origendestino " +
                                "WHERE correo_idcorreo=?idcorreo";
                            
                            myCommand.Parameters.Clear();
                            myCommand.Parameters.Add("?idcorreo", MySqlDbType.Int16).Value = correo.IdCorreo;
                            
                            myAdapter.SelectCommand = myCommand;
                            myAdapter.Fill(myDataDir);

                            if (myDataDir.Rows.Count != 0) {
                                for (int j = 0; j <= myDataDir.Rows.Count - 1; j++) {
                                    OrigenDestinoDTO direccion = new OrigenDestinoDTO();

                                    direccion.IdOrigenDestino = int.Parse(myDataDir.Rows[j].ItemArray.GetValue(0).ToString());
                                    direccion.Direccion = myDataDir.Rows[j].ItemArray.GetValue(1).ToString();
                                    direccion.Cc = bool.Parse(myDataDir.Rows[j].ItemArray.GetValue(2).ToString());
                                    direccion.Cco = bool.Parse(myDataDir.Rows[j].ItemArray.GetValue(3).ToString());
                                    direccion.IdCorreo = int.Parse(myDataDir.Rows[j].ItemArray.GetValue(4).ToString());

                                    direcciones.Add(direccion);
                                }
                            }

                        }
                        catch (MySqlException e) { }

                        correo.OrigenDestino = direcciones;

                        List<AttachmentDTO> adjuntos = new List<AttachmentDTO>();
                        try
                        {
                            myCommand.CommandText = "SELECT idadjunto,detalle,path,correo_idcorreo FROM adjunto WHERE correo_idcorreo=?idcorreoo";
                            myCommand.Parameters.Add("?idcorreoo", MySqlDbType.Int16).Value = correo.IdCorreo;
                            DataTable myDataAdj = new DataTable();
                            myAdapter.SelectCommand = myCommand;
                            myAdapter.Fill(myDataAdj);

                            if (myDataAdj.Rows.Count != 0)
                            {
                                for (int j = 0; j <= myDataAdj.Rows.Count - 1; j++)
                                {
                                    AttachmentDTO adjunto = new AttachmentDTO();
                                    adjunto.IdAttachment = int.Parse(myDataAdj.Rows[j].ItemArray.GetValue(0).ToString());
                                    adjunto.Name = myDataAdj.Rows[j].ItemArray.GetValue(1).ToString();
                                    adjunto.Path = myDataAdj.Rows[j].ItemArray.GetValue(2).ToString();
                                    adjunto.IdCorreo = int.Parse(myDataAdj.Rows[j].ItemArray.GetValue(3).ToString());

                                    adjuntos.Add(adjunto);
                                }
                            }
                        }
                        catch (MySqlException e) { }

                        correo.Adjuntos = adjuntos;

                        correos.Add(correo);

                    }
                }
            }
            catch (MySqlException ex) { }

            return correos;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="correo"></param>
        /// <returns></returns>
        public int delete(CorreoDTO correo)
        {
            int res = 0;

            try
            {
                connection.Open();

                MySqlCommand myCommand = new MySqlCommand();
                myCommand.Connection = connection;

                myCommand.CommandText = "DELETE FROM adjunto WHERE correo_idcorreo=?idcorreoo";
                myCommand.Parameters.Add("?idcorreoo", MySqlDbType.Int16).Value = correo.IdCorreo;

                myCommand.ExecuteNonQuery();

                myCommand.CommandText = "DELETE FROM origendestino WHERE correo_idcorreo=?idcorreooo";
                myCommand.Parameters.Add("?idcorreooo", MySqlDbType.Int16).Value = correo.IdCorreo;

                myCommand.ExecuteNonQuery();

                myCommand.CommandText = "DELETE FROM correo WHERE idcorreo=?idcorreo";
                myCommand.Parameters.Add("?idcorreo", MySqlDbType.Int16).Value = correo.IdCorreo;

                myCommand.ExecuteNonQuery();

                connection.Close();

                res = 1;
                return res;
            }
            catch (MySqlException ex) {
                res = -1;
                return res;
            }
        }

        public int clear(CuentaDTO cuenta) {
            int res = 0;

            try {
                connection.Open();

                MySqlCommand myCommand = new MySqlCommand();
                myCommand.Connection = connection;

                myCommand.CommandText = "DELETE FROM correo WHERE cuenta_idcuenta=?idcuenta";
                myCommand.Parameters.Add("?idcuenta", MySqlDbType.Int16).Value = cuenta.IdCuenta;
                myCommand.ExecuteNonQuery();

                myCommand.CommandText = "DELETE FROM origendestino WHERE 1=1";
                myCommand.ExecuteNonQuery();

                myCommand.CommandText = "DELETE FROM adjunto WHERE 1=1";
                myCommand.ExecuteNonQuery();

                connection.Close();

                res = 1;
                return res;
            }
            catch (MySqlException ex) {
                return -1;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="cuenta"></param>
        /// <returns></returns>
        public DateTime lastMail(CuentaDTO cuenta)
        {
            DateTime fecha = DateTime.Today;

            try
            {
                connection.Open();
                MySqlCommand myCommand = new MySqlCommand();
                myCommand.Connection = connection;
                myCommand.CommandText = "SELECT MAX(fecha) FROM correo WHERE cuenta_idcuenta=?cuentaid";
                myCommand.Parameters.Add("?cuentaid", MySqlDbType.Int16).Value = cuenta.IdCuenta;

                string fechastr = myCommand.ExecuteScalar().ToString();
                fecha = DateTime.Parse(fechastr);

                connection.Close();
                return fecha;
                
            }
            catch (MySqlException ex) {
                return fecha;
            }
        }

        public int LastId(CuentaDTO cuenta) {
            int res = 0;

            try
            {
                connection.Open();

                MySqlCommand myCommand = new MySqlCommand();
                myCommand.Connection = connection;
                myCommand.CommandText = "SELECT MAX(idcorreo) FROM correo WHERE cuenta_idcuenta=?cuentaidd";
                myCommand.Parameters.Add("?cuentaidd", MySqlDbType.Int16).Value = cuenta.IdCuenta;

                string idStr = myCommand.ExecuteScalar().ToString();


                try
                {
                    int i = int.Parse(idStr);
                    res = i;
                }
                catch (Exception e) {
                    res = 0;
                }


                connection.Close();

                return res;
            }
            catch (MySqlException ex) {
                return 0;
            }
        }


        public int mailCount(CuentaDTO cuenta)
        {
            int res = 0;
            try 
            {
                connection.Open();

                MySqlCommand myCommand = new MySqlCommand();
                myCommand.Connection = connection;

                myCommand.CommandText = "SELECT COUNT(*) FROM correo WHERE cuenta_idcuenta=?idcuenta";
                myCommand.Parameters.Add("?idcuenta", MySqlDbType.Int16).Value = cuenta.IdCuenta;

                string resStr = myCommand.ExecuteScalar().ToString();

                res = int.Parse(resStr);

                connection.Close();

                return res;
            }
            catch (MySqlException ex) {
                return res;
            }
        }
    }
}
