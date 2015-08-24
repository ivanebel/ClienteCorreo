using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClienteCorreo.DTO
{
    /// <summary>
    /// Data Transfer Object para el Correo.
    /// </summary>
    public class CorreoDTO
    {
        int idCorreo;
        int idCuenta;
        String detalle;
        bool read;
        String asunto;
        Tipo tipoCorreo;
        DateTime fecha;
        int numeroServidorCorreo;
        List<AttachmentDTO> adjuntos = new List<AttachmentDTO>();
        List<OrigenDestinoDTO> origenDestino = new List<OrigenDestinoDTO>();

        /// <summary>
        /// Constructor de la clase CorreoDTO.
        /// </summary>
        public CorreoDTO() { }

        public int IdCorreo{ get; set; }

        public int IdCuenta { get; set; }

        public String Detalle { get; set; }

        public bool Read { get; set; }

        public String Asunto { get; set; }

        public Tipo TipoCorreo { get; set; }

        public DateTime Fecha { get; set; }

        public int NumeroServidorCorreo { get; set; }

        public List<AttachmentDTO> Adjuntos { get; set; }

        public List<OrigenDestinoDTO> OrigenDestino { get; set; }

    
    }
}
