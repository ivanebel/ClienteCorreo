using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using ClienteCorreo.DTO;
using ClienteCorreo.Correo.Properties;
using ClienteCorreo.Utils;

namespace ClienteCorreo.Correo
{
    public class ServerConfig
    {
        private static ServerConfig instance = null;

        /// <summary>
        /// Constructor de la clase ServerConfig
        /// </summary>
        private ServerConfig() { }

        /// <summary>
        /// Método para obtener la instancia Singleton.
        /// </summary>
        /// <returns></returns>
        public static ServerConfig getInstance() {
            if (instance == null) return new ServerConfig();
            else return instance;
        }

        /// <summary>
        /// Método encargado de obtener las propiedades necesarias para realizar
        /// la conexión con el tipo de Servidor necesario.
        /// </summary>
        /// <param name="envio">Se configura para enviar si es TRUE, para recibir si es FALSE</param>
        /// <param name="server">Servidor del cual se quiere obtener la configuración</param>
        /// <returns></returns>
        public Property obtenerPropiedades(bool envio, ServerDTO server) {
            Property propiedad = new Property();

            try
            {
                IServerProperty propiedadObtenida;

                switch (server.Name)
                {
                    case "GMAIL":
                        propiedadObtenida = new Gmail();
                        if (envio) propiedad = propiedadObtenida.getPropiedadEnviar(server);
                        else propiedad = propiedadObtenida.getPropiedadRecibir(server);
                        break;
                    case "OUTLOOK":
                        ///
                        break;
                    case "YAHOO":
                        ///
                        break;
                }
            }
            catch (Exception ex) { }

            return propiedad;
        }

    }
}
