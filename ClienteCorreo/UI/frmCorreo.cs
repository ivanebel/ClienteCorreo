using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Web;

using ClienteCorreo.DTO;

namespace ClienteCorreo.UI
{
    public partial class frmCorreo : Form
    {
        frmPrincipal main;
        CorreoDTO correo;

        
        public frmCorreo(frmPrincipal vmain)
        {
            InitializeComponent();
            main = vmain;
        }

        
        private void frmCorreo_Load(object sender, EventArgs e)
        {

        }

        public void ObtenerCorreo(CorreoDTO oCorreo) {
            try {
                correo = new CorreoDTO();
                correo = Controller.Correo.getInstance().obtenerCorreo(oCorreo);
                CargarCorreo();
                //Pasar a Leido
                //Cargo adjuntos
            }
            catch (Exception ex) { }
        }

        [STAThread]
        private void CargarCorreo() {
            String deStr = "";
            foreach (OrigenDestinoDTO origen in correo.OrigenDestino) {
                if (origen.Cc == false && origen.Cco == false)
                    deStr = origen.Direccion;
            }

            String ccStr = "";
            String ccoStr = "";
            foreach (OrigenDestinoDTO origen in correo.OrigenDestino) {
                if (origen.Cc == true)
                    ccStr = ccStr + origen.Direccion + "; ";
                else if (origen.Cco == true)
                    ccoStr = ccoStr + origen.Direccion + "; ";
            }

            txtDe.Text = deStr;
            txtCc.Text = ccStr;
            txtCco.Text = ccoStr;
            txtAsunto.Text = correo.Asunto;
            txtCorreo.Text = correo.Detalle;
            
            wbCorreo.DocumentText = correo.Detalle;

            wbCorreo.Focus();
            
        }

        private void wbCorreo_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            

        }

        private void wbCorreo_Navigating(object sender, WebBrowserNavigatingEventArgs e)
        {
            
        }

        private void wbCorreo_Navigated(object sender, WebBrowserNavigatedEventArgs e)
        {
            wbCorreo.Document.MouseOver += new HtmlElementEventHandler(Body_MouseOver);
        }

        private void Body_MouseOver(object sender, HtmlElementEventArgs e)
        {
            string element = wbCorreo.Document.GetElementFromPoint(e.ClientMousePosition).GetAttribute("href");
            tsLink.Text = element;
        }

        private void frmCorreo_MouseMove(object sender, MouseEventArgs e)
        {
            
        }
    }
}
