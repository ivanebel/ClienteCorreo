using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClienteCorreo.DTO
{
    /// <summary>
    /// Data Transfer Object para la Cuenta.
    /// </summary>
    public class CuentaDTO
    {
        private int idCuenta;
        private String user;
        private String password;
        private int server;

        /// <summary>
        /// Constructor de la clase CuentaDTO.
        /// </summary>
        public CuentaDTO() { }

        public int IdCuenta { get; set; }

        public String User { get; set; }

        public String Password { get; set; }

        public int Server { get; set; }

        public String toString() {
            return user;
        }


    }

    //clientedecorreotp@gmail.com | frcu2010
}
