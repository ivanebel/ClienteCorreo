using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClienteCorreo.DTO
{
    /// <summary>
    /// Data Transfer Object del Origen o Destino del Correo.
    /// </summary>
    public class OrigenDestinoDTO
    {
        private int idOrigenDestino;
        private int idCorreo;
        private String direccion;
        private bool cc;
        private bool cco;

        /// <summary>
        /// Constructor de la clase OrigenDestinoDTO.
        /// </summary>
        public OrigenDestinoDTO() { }

        public int IdOrigenDestino { get; set; }

        public int IdCorreo { get; set; }

        public String Direccion { get; set; }

        public bool Cc { get; set; }

        public bool Cco { get; set; }



    }
}
