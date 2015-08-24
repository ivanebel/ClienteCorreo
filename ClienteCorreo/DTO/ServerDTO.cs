using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClienteCorreo.DTO
{
    /// <summary>
    /// Data Transfer Object para el Servidor.
    /// </summary>
    public class ServerDTO
    {
        int id;
        String name;
        String popServer;
        String smtpServer;
        int popPort;
        int smtpPort;
        bool ssl;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public String Name { get; set; }

        public String PopServer { get; set; }

        public String SmtpServer { get; set; }

        public int PopPort { get; set; }

        public int SmtpPort { get; set; }

        public bool Ssl { get; set; }

        public String toString() {
            return name;
        }

    }
}
