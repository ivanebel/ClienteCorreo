using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Mail;
using System.Net;

using ClienteCorreo.DTO;

namespace ClienteCorreo.Utils
{

    public class AdminSmtp
    {
        SmtpClient cliente;

        public AdminSmtp()
        {

        }

        public void ConectarSmtp(ServerDTO server, CuentaDTO cuenta) {
            cliente = new SmtpClient();

            cliente.Host = server.SmtpServer;
            cliente.Port = server.SmtpPort;
            cliente.DeliveryMethod = SmtpDeliveryMethod.Network;
            cliente.EnableSsl = server.Ssl;
            cliente.Credentials = new NetworkCredential(cuenta.User, cuenta.Password);
            
        }

        public int Enviar(MailMessage mensaje, bool async) {
            try
            {
                cliente.Send(mensaje);

                return 1;
            }
            catch (SmtpFailedRecipientException ex) { 
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
                Console.WriteLine(ex.InnerException.Message);
                return -1;
            }
            catch (SmtpException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
                Console.WriteLine(ex.InnerException.Message);
                return -1;
            }
        }

        //SmtpClient mailer = new SmtpClient();
        //        mailer.Host = "smtp.gmail.com";
        //        //System.Net.NetworkCredential nc = new System.Net.NetworkCredential("username", "pwd");
        //        System.Net.NetworkCredential nc = new System.Net.NetworkCredential(cuenta.User, cuenta.Password);
    }
}
