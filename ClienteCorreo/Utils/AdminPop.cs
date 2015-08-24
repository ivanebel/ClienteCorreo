using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Mail;

using OpenPop.Pop3;
using OpenPop.Mime;
using OpenPop.Mime.Header;

using ClienteCorreo.DTO;

namespace ClienteCorreo.Utils
{
    public class AdminPop
    {
        Pop3Client cliente;

        public AdminPop()
        {
            
        }

        public void ConectarPop(ServerDTO server, CuentaDTO cuenta) {
            cliente = new Pop3Client();
            try {
                cliente.Connect(server.PopServer, server.PopPort, server.Ssl);
                cliente.Authenticate(cuenta.User, cuenta.Password);
            }
            catch (OpenPop.Pop3.Exceptions.PopClientException ex) {
                Console.WriteLine(ex.Message);
            }
            
        }

        public List<MailMessage> ObtenerMensajes() {
            int cantidadmensajes = ObtenerCantidadMensajes();
            List<MailMessage> mensajes = new List<MailMessage>();

            for (int i = 1; i <= cantidadmensajes; i++) {
                try
                {
                    MailMessage mensaje = cliente.GetMessage(i).ToMailMessage();

                    String fechaStr = cliente.GetMessageHeaders(i).DateSent.ToShortDateString();

                    mensaje.Subject = mensaje.Subject + fechaStr;

                    mensajes.Add(mensaje);


                }
                catch (Exception ex) {
                    continue;
                }
            }
                

            return mensajes;
        }

        //public MailMessage ObtenerMensaje(int indice) {
        //    try
        //    {
        //        Message mensaje = cliente.GetMessage(indice);
        //        OpenPop.Mime.Header.MessageHeader header = cliente.GetMessageHeaders(indice);
                               
        //        MailMessage men = new MailMessage();
        //         men.Headers["Date"] = header.Date;
        //        return cliente.GetMessage(indice).ToMailMessage();
        //    }
        //    catch (Exception ex) {
        //        return null;
        //    }
        //}

        public int ObtenerCantidadMensajes()
        { 
            return cliente.GetMessageCount();
        }
    }
}
