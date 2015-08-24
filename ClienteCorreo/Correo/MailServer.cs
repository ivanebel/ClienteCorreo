using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Net.Mail;
using System.Text.RegularExpressions;
using System.Web;

using ClienteCorreo.Controller;
using ClienteCorreo.DTO;
using ClienteCorreo.Utils;

namespace ClienteCorreo.Correo
{
    public class MailServer
    {
        private static MailServer instance = null;
        private String fix = "C:";                  // !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!

        private MailServer() { 
           
        }

        /// <summary>
        /// Método para obtener el Singleton
        /// </summary>
        /// <returns>Una instancia de MailServer</returns>
        public static MailServer getInstance() {
            if (instance == null) return new MailServer();
            else return instance;
        }

        /// <summary>
        /// Método para obtener lo que se encuentra dentro de <body></body>
        /// </summary>
        /// <param name="cuerpo">String HTML</param>
        /// <returns></returns>
        public String tratarCuerpoHtml(String cuerpo) {
            String body = cuerpo;
            
            Regex rx = new Regex(@"<body(.*?)>(.*?)</body>");
            MatchCollection matcher = rx.Matches(cuerpo);

            if (matcher.Count > 0) {
                Match match = matcher[0];
                GroupCollection groupCollection = match.Groups;
                body = groupCollection[2].ToString();
            }

            body = body.Replace("[\"'](\\d+)(\\.)(\\d+)['\"]", "\"$1\"");

            return body;
        }

        public void enviarCorreo(CorreoDTO correo) {
            try
            {
                CuentaDTO cuenta = Cuenta.getInstance().ObtenerCuentaDeCorreo(correo);
                ServerDTO server = new ServerDTO();

                server.Id = cuenta.Server;
                server = Server.getInstance().ObtenerServer(server);

                //Sesión

                MailMessage mensaje = new MailMessage();

                //Agrego destinatarios, guardados en la lista de OrigenDestino
                foreach (OrigenDestinoDTO od in correo.OrigenDestino) { 
                    //Si es CC
                    if (od.Cc == true) mensaje.CC.Add(new MailAddress(od.Direccion));
                    //Si es CCO
                    else if (od.Cco == true) mensaje.Bcc.Add(new MailAddress(od.Direccion));
                    //Sino, es Para
                    else mensaje.To.Add(new MailAddress(od.Direccion));
                }

                mensaje.Subject = correo.Asunto;
                mensaje.Body = correo.Detalle;

                //Adjuntos
                //foreach (AttachmentDTO adjunto in correo.Adjuntos) { 
                    
                //}

                mensaje.From = new MailAddress(cuenta.User);

                AdminSmtp smtp = new AdminSmtp();
                smtp.ConectarSmtp(server, cuenta);

                //If enviado < 0 -> error al enviar
                int enviado = smtp.Enviar(mensaje, false);

            }
            catch (Exception ex) { }
        }

        public List<CorreoDTO> leerCorreo(CuentaDTO cuenta) { 
            
            List<CorreoDTO> listaCorreos = new List<CorreoDTO>();

            try
            {
                ServerDTO server = new ServerDTO();
                server.Id = cuenta.Server;
                server = Server.getInstance().ObtenerServer(server);

                //Sesión
                AdminPop adminpop = new AdminPop();

                adminpop.ConectarPop(server, cuenta);


                List<MailMessage> listaMensajes = adminpop.ObtenerMensajes();

                //listaMensajes.Add(adminpop.ObtenerMensaje(30));
                //check fechas

                foreach (MailMessage mensajeObtenido in listaMensajes)
                {
                    CorreoDTO correo = new CorreoDTO();
                    correo.IdCuenta = cuenta.IdCuenta;

                    OrigenDestinoDTO od = new OrigenDestinoDTO();
                    List<OrigenDestinoDTO> listaOrigenes = new List<OrigenDestinoDTO>();

                    od.Direccion = PasajeCorreos.getInstance().obtenerCorreoBlank(mensajeObtenido.From.ToString());
                    od.Cco = false;
                    od.Cc = false;
                    correo.OrigenDestino = listaOrigenes;
                    correo.OrigenDestino.Add(od);

                    MailAddressCollection listaCC = mensajeObtenido.CC;

                    if (listaCC != null) {
                        foreach (MailAddress ma in listaCC) {
                            OrigenDestinoDTO ccdir = new OrigenDestinoDTO();
                            ccdir.Direccion = PasajeCorreos.getInstance().obtenerCorreoBlank(ma.ToString());
                            ccdir.Cc = true;
                            ccdir.Cco = false;
                            correo.OrigenDestino.Add(ccdir);
                        }

                    }

                    AttachmentCollection coleccionadjuntos = mensajeObtenido.Attachments;
                    List<AttachmentDTO> adjuntos = new List<AttachmentDTO>();

                    if (coleccionadjuntos.Count > 0)
                    {

                        //No puedo usar esto porque previamente limpié la tabla de correos, por lo tanto no hay id.
                        //int maxid = Controller.Correo.getInstance().UltimoIdCorreo(cuenta);

                        foreach (Attachment adj in coleccionadjuntos)
                        {
                            AttachmentDTO adjunto = new AttachmentDTO();

                            //adjunto.IdCorreo = maxid + 1;
                            adjunto.Name = adj.Name;
                            adjunto.Path = adj.ContentStream.ToString();        //OJO

                            adjuntos.Add(adjunto);
                        }
                    }

                    correo.Adjuntos = adjuntos;

                    //MIRAR ACA
                    string fechaStr = mensajeObtenido.Subject.Substring(mensajeObtenido.Subject.Length - 10, 10);

                    correo.Fecha = DateTime.Parse(fechaStr);


                    correo.Asunto = mensajeObtenido.Subject.Substring(0, (mensajeObtenido.Subject.Length - 10));
                    correo.NumeroServidorCorreo = mensajeObtenido.To.Count;
                    
                    correo.Detalle = mensajeObtenido.Body;

                    correo.TipoCorreo = Tipo.RECIBIDO;
                    listaCorreos.Add(correo);
                }

                
            }
            catch (ArgumentNullException ex) { 
            
            }

            return listaCorreos;

        }

        


    }
}
