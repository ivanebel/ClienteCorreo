using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using ClienteCorreo.DTO;
using ClienteCorreo.Persistence;

namespace ClienteCorreo.Controller
{
    /// <summary>
    /// Controlador para la administración de la Configuración.
    /// </summary>
    public class Configuracion
    {
        private static Configuracion instance = null;
        private Factory factory;

        /// <summary>
        /// Constructor singleton de la clase Configuracion.
        /// </summary>
        private Configuracion() {
            factory = Factory.getDAOFactory();
        }

        /// <summary>
        /// Obtiene la instancia del singleton.
        /// </summary>
        /// <returns>Configuracion</returns>
        public static Configuracion getInstance() {
            if (instance == null) instance = new Configuracion();
            return instance;
        }

        /// <summary>
        /// Modifica la configuración actual.
        /// </summary>
        /// <param name="config">Nueva Configuración</param>
        public void cambiarConfiguracion(ConfiguracionDTO config) {
            factory.startConnection();
            factory.getConfiguracion().modificarConfiguracion(config);
            factory.closeConnection();
        }

        /// <summary>
        /// Obtiene la configuración actual.
        /// </summary>
        /// <returns></returns>
        public ConfiguracionDTO getConfiguracion() {
            factory.startConnection();
            ConfiguracionDTO config = factory.getConfiguracion().getConfiguracion();
            factory.closeConnection();
            return config;
        }

    }
}
