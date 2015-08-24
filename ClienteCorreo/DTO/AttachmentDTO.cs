using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClienteCorreo.DTO
{
    /// <summary>
    /// Data Transfer Object para archivos adjuntos.
    /// </summary>
    public class AttachmentDTO
    {
        private int idAttachment;
        private int idCorreo;
        private String name;
        private String path;

        /// <summary>
        /// Constructor de la clase AttachmentDTO.
        /// </summary>
        public AttachmentDTO() { }

        public int IdAttachment { get; set; }

        public int IdCorreo { get; set; }

        public String Name { get; set; }

        public String Path { get; set; }

        public String toString() {
            return name;
        }
    }
}
