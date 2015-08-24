using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using ClienteCorreo.Persistence.MySQL;

namespace ClienteCorreo.Persistence
{
    /// <summary>
    /// Interfaz con métodos a implementar en aquellos casos que sea necesario modificar la Base de Datos.
    /// </summary>
    public abstract class Factory
    {
        private static Factory factory = null;

        public static Factory getDAOFactory() {
            if (factory == null) return new FactorySQL();
            else return factory;
        }

        public Factory()
        {
            
        }

        public abstract void startConnection();

        public abstract void closeConnection();

        public abstract ICorreoDAO getCorreo();

        public abstract ICuentaDAO getCuenta();

        public abstract IServerDAO getServer();

        public abstract IConfiguracionDAO getConfiguracion();


    }
}
