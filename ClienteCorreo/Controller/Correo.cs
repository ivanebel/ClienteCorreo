using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using ClienteCorreo.DTO;
using ClienteCorreo.Persistence;

namespace ClienteCorreo.Controller
{
    public class Correo {

        private static Correo instance = null;
        Factory factory;

        /// <summary>
        /// Constructor del controlador Singleton de Correo.
        /// </summary>
        private Correo() {
            factory = Factory.getDAOFactory();
        }

        /// <summary>
        /// Obtiene la instancia del Singleton.
        /// </summary>
        /// <returns></returns>
        public static Correo getInstance() {
            if (instance == null) return new Correo();
            else return instance;
        }

        /// <summary>
        /// Método para agregar un Correo.
        /// </summary>
        /// <param name="correo"></param>
        public void agregarCorreo(CorreoDTO correo) {
            factory.startConnection();
            factory.getCorreo().create(correo);
            factory.closeConnection();
        }

        /// <summary>
        /// Método para modificar un Correo.
        /// </summary>
        /// <param name="correo"></param>
        public void modificarCorreo(CorreoDTO correo) {
            factory.startConnection();
            factory.getCorreo().update(correo);
            factory.closeConnection();
        }

        /// <summary>
        /// Método para eliminar un Correo.
        /// </summary>
        /// <param name="correo"></param>
        public void eliminarCorreo(CorreoDTO correo) {
            factory.startConnection();
            factory.getCorreo().delete(correo);
            factory.closeConnection();
        }

        /// <summary>
        /// Método para obtener un Correo.
        /// </summary>
        /// <param name="correo"></param>
        public CorreoDTO obtenerCorreo(CorreoDTO correo) {
            factory.startConnection();
            CorreoDTO correoObtenido = factory.getCorreo().get(correo);
            factory.closeConnection();

            return correoObtenido;
        }

        /// <summary>
        /// Método para marcar un Correo como leído o como no leído.
        /// </summary>
        /// <param name="correo"></param>
        public void marcarComoLeido(CorreoDTO correo, bool leido) {
            factory.startConnection();
            factory.getCorreo().markAsRead(correo, leido);
            factory.closeConnection();
        }


        /// <summary>
        /// Método para obtener todos los correos de las cuentas en el sistema.
        /// </summary>
        /// <param name="leidos">Muestra mensajes leídos</param>
        /// <param name="enviados">Muestra mensajes enviados</param>
        /// <returns>Lista de CorreoDTO</returns>
        public List<CorreoDTO> listar(bool leidos, bool enviados, CuentaDTO cuenta=null) {
            factory.startConnection();
            
            int cant = factory.getConfiguracion().getConfiguracion().CantidadCorreos;

            List<CorreoDTO> lista = new List<CorreoDTO>();

            if (cuenta != null)
            {
                lista = factory.getCorreo().list(leidos, enviados, cant, cuenta);
            }
            else
            {
                lista = factory.getCorreo().list(leidos, enviados, cant);
            }
                
            factory.closeConnection();

            return lista;
        }

        /// <summary>
        /// Método para obtener la fecha del último mensaje descargado.
        /// </summary>
        /// <param name="cuenta">Cuenta destino</param>
        /// <returns></returns>
        public DateTime fechaUltimoMensaje(CuentaDTO cuenta) {
            factory.startConnection();
            DateTime fecha = factory.getCorreo().lastMail(cuenta);
            factory.closeConnection();

            return fecha;
        }

        public void limpiar(CuentaDTO cuenta) {
            factory.startConnection();

            factory.getCorreo().clear(cuenta);

            factory.closeConnection();
        }

        public int UltimoIdCorreo(CuentaDTO cuenta) {
            factory.startConnection();
            int id = factory.getCorreo().LastId(cuenta);
            factory.closeConnection();

            return id;
        }

        public int CantidadCorreos(CuentaDTO cuenta) {
            factory.startConnection();
            int cantidad = factory.getCorreo().mailCount(cuenta);
            factory.closeConnection();

            return cantidad;
        }

    
    
    }




    ///// <summary>
    ///// Interfaz para el Correo.
    ///// </summary>
    //public interface Correo
    //{
    //    public bool create(CorreoDTO correo);

    //    public CorreoDTO get(CorreoDTO correo);

    //    public bool update(CorreoDTO correo);

    //    public bool markAsRead(CorreoDTO correo);

    //    public List<CorreoDTO> list(bool read, bool sent, int cant);

    //    public bool delete(CorreoDTO correo);

    //    public DateTime lastMail(CuentaDTO cuenta);

    //}
}
