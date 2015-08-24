using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using ClienteCorreo.DTO;

namespace ClienteCorreo.Utils
{
    public class PasajeCorreos
    {
        private static PasajeCorreos instance = null;

        private PasajeCorreos() { 
        }

        public static PasajeCorreos getInstance() {
            if (instance == null) return new PasajeCorreos();
            else return instance;
        }

        public String obtenerCorreoBlank(String correoParaObtener) {
            int ini = correoParaObtener.IndexOf('<') + 1;
            int fin = correoParaObtener.IndexOf('>');

            int test = correoParaObtener.Length;
            string strTest = correoParaObtener.Substring(0, correoParaObtener.Length);

            if (ini == -1 || fin == -1)
                return correoParaObtener;
            else
                return correoParaObtener.Substring(ini, (fin-ini));
        }

        public List<OrigenDestinoDTO> getListaOrigenDestino(string correoParaObtener) {
            List<OrigenDestinoDTO> lista = new List<OrigenDestinoDTO>();
            String correos = correoParaObtener;

            while (correos.Length > 0) { 
                if(correos.IndexOf(';') != -1) {
                    OrigenDestinoDTO destinos = new OrigenDestinoDTO();
                    destinos.Direccion = correos.Substring(0, correos.IndexOf(';'));
                    lista.Add(destinos);

                    int ini = correos.IndexOf(';') + 1;
                    int fin = correos.Length - 1;

                    correos = correos.Substring(ini);
                }
                else if (correos.Equals("")) { } 
                else {
                    OrigenDestinoDTO destinos = new OrigenDestinoDTO();
                    destinos.Direccion = correos;
                    lista.Add(destinos);
                    correos = "";
                }
            }

            return lista;

        }
    }
}
