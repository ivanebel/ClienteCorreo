using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClienteCorreo.DTO
{
    /// <summary>
    /// Data Transfer Object de la Configuración.
    /// </summary>
    public class ConfiguracionDTO
    {
        private int cantidadCorreos;
        private String patch;

        /// <summary>
        /// Constructor de la clase ConfiguraciónDTO.
        /// </summary>
        public ConfiguracionDTO() { }

        public int CantidadCorreos { get; set; }

        public String Patch { get; set; }

    }
}
