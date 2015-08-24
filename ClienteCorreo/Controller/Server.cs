using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using ClienteCorreo.DTO;
using ClienteCorreo.Persistence;

namespace ClienteCorreo.Controller
{
    public class Server
    {
        private static Server instance = null;
        Factory factory;

        /// <summary>
        /// Constructor del controlador Singleton del Servidor.
        /// </summary>
        private Server() {
            factory = Factory.getDAOFactory();
        }

        /// <summary>
        /// Método para obtener la instancia del Singleton.
        /// </summary>
        /// <returns></returns>
        public static Server getInstance() {
            if (instance == null) return new Server();
            else return instance;
        }

        /// <summary>
        /// Método para agregar un servidor
        /// </summary>
        /// <param name="server">Servidor que se va a agregar</param>
        public void AgregarServer(ServerDTO server)
        {
            factory.startConnection();
            factory.getServer().save(server);
            factory.closeConnection();
        }

        /// <summary>
        /// Método para modificar un servidor
        /// </summary>
        /// <param name="server">Servidor que se va a modificar</param>
        public void ModificarCuenta(ServerDTO server)
        {
            factory.startConnection();
            factory.getServer().update(server);
            factory.closeConnection();
        }

        /// <summary>
        /// Método para eliminar un servidor
        /// </summary>
        /// <param name="server">Cuenta que se va a eliminar</param>
        public void EliminarCuenta(ServerDTO server)
        {
            factory.startConnection();
            factory.getServer().delete(server);
            factory.closeConnection();
        }

        /// <summary>
        /// Método para obtener todos los datos existentes de un servidor
        /// </summary>
        /// <param name="server"></param>
        /// <returns></returns>
        public ServerDTO ObtenerServer(ServerDTO server)
        {
            factory.startConnection();
            ServerDTO serverObtenido = factory.getServer().get(server);
            factory.closeConnection();
            return serverObtenido;
        }

        /// <summary>
        /// Método para obtener una lista de servidores existentes.
        /// </summary>
        /// <returns>Lista de ServerDTO</returns>
        public List<ServerDTO> ListarServers()
        {
            factory.startConnection();
            List<ServerDTO> lista = factory.getServer().list();
            factory.closeConnection();
            return lista;
        }

    }
}
