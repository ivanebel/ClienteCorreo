using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using ClienteCorreo.DTO;
using ClienteCorreo.Utils;
using ClienteCorreo.Correo;

namespace ClienteCorreo.Correo.Properties
{
    public class Gmail : IServerProperty
    {

        public Property getPropiedadEnviar(ServerDTO server)
        {
            try
            {
                Property propiedad = new Property();

                propiedad.set("mail.smtp.host", server.SmtpServer);
                propiedad.set("mail.smtp.port", server.SmtpPort);
                propiedad.set("mail.smtp.ssl.socketFactory.fallback", "false");
                propiedad.set("mail.smtp.starttls.enable", "false");
                propiedad.set("mail.smtp.ssl.enable", "true");
                propiedad.set("mail.smtp.ssl.checkserveridentity ", " true ");

                return propiedad;
            }
            catch (Exception ex) {
                return null;
            }
        }

        public Property getPropiedadRecibir(ServerDTO server)
        {
            try
            {
                Property propiedad = new Property();

                propiedad.set("mail.pop3.host", server.PopServer);
                propiedad.set("mail.pop3.port", server.PopPort);
                propiedad.set("mail.pop3.ssl.socketFactory.fallback", "false");
                propiedad.set("mail.pop3.starttls.enable", "false");
                propiedad.set("mail.pop3.ssl.enable", "true");
                propiedad.set("mail.pop3.ssl.checkserveridentity ", " true ");

                return propiedad;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
