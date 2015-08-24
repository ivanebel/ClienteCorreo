using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using ClienteCorreo.DTO;
using ClienteCorreo.Persistence;

namespace ClienteCorreo.Controller
{
    /// <summary>
    /// Controlador para las Cuentas.
    /// </summary>
    public class Cuenta
    {
        private static Cuenta instance = null;
        Factory factory;

        /// <summary>
        /// Constructor singleton de la clase Cuenta.
        /// </summary>
        private Cuenta() {
            factory = Factory.getDAOFactory();
        }

        /// <summary>
        /// Obtiene la instancia del singleton.
        /// </summary>
        /// <returns>Configuracion</returns>
        public static Cuenta getInstance()
        {
            if (instance == null) instance = new Cuenta();
            return instance;
        }

        /// <summary>
        /// Método para agregar una cuenta
        /// </summary>
        /// <param name="cuenta">Cuenta que se va a agregar</param>
        public void AgregarCuenta(CuentaDTO cuenta) {
            factory.startConnection();
            factory.getCuenta().create(cuenta);
            factory.closeConnection();
        }

        /// <summary>
        /// Método para modificar una cuenta
        /// </summary>
        /// <param name="cuenta">Cuenta que se va a modificar</param>
        public void ModificarCuenta(CuentaDTO cuenta) {
            factory.startConnection();
            factory.getCuenta().update(cuenta);
            factory.closeConnection();
        }

        /// <summary>
        /// Método para eliminar una cuenta
        /// </summary>
        /// <param name="cuenta">Cuenta que se va a eliminar</param>
        public void EliminarCuenta(CuentaDTO cuenta) {
            factory.startConnection();
            factory.getCuenta().delete(cuenta);
            factory.closeConnection();
        }

        /// <summary>
        /// Método para obtener todos los datos existentes de una cuenta
        /// </summary>
        /// <param name="cuenta"></param>
        /// <returns></returns>
        public CuentaDTO ObtenerCuenta(CuentaDTO cuenta) {
            factory.startConnection();
            CuentaDTO cuentaObtenida = factory.getCuenta().get(cuenta);
            factory.closeConnection();
            return cuentaObtenida;
        }

        /// <summary>
        /// Método para obtener la cuenta a partir de un correo.
        /// </summary>
        /// <param name="correo">Correo del que se quiere obtener la cuenta</param>
        /// <returns>CuentaDTO del correo</returns>
        public CuentaDTO ObtenerCuentaDeCorreo(CorreoDTO correo) {
            CuentaDTO cuentaObtenida = new CuentaDTO();
            cuentaObtenida.IdCuenta = correo.IdCuenta;
            factory.startConnection();
            cuentaObtenida = factory.getCuenta().get(cuentaObtenida);
            factory.closeConnection();
            return cuentaObtenida;
        }

        /// <summary>
        /// Método para obtener una lista de cuentas existentes.
        /// </summary>
        /// <returns>Lista de CuentaDTO</returns>
        public List<CuentaDTO> ListarCuentas() {
            factory.startConnection();
            List<CuentaDTO> lista = factory.getCuenta().list();
            factory.closeConnection();
            return lista;
        }

        public int CantidadCorreos(CuentaDTO cuenta)
        {
            factory.startConnection();
            int cantidad = factory.getCuenta().count(cuenta);
            factory.closeConnection();

            return cantidad;
        }
    }
}
