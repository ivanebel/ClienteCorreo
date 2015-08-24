using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using ClienteCorreo.DTO;
using ClienteCorreo.Utils;
using ClienteCorreo.Correo;
using ClienteCorreo.Controller;

namespace ClienteCorreo.UI
{
    public partial class frmNuevoCorreo : Form
    {
        frmPrincipal ventanaprincipal;
        CorreoDTO correo = new CorreoDTO();
        Dictionary<String, int> dictionaryCuentas = new Dictionary<String, int>();

        public string tipo = "new";


        public frmNuevoCorreo()
        {
            InitializeComponent();
        }

        public frmNuevoCorreo(frmPrincipal padre, string origen) {
            InitializeComponent();
            tipo = origen;
            ventanaprincipal = padre;

        }

        private void tbEnviar_Click(object sender, EventArgs e)
        {
            //Verificar datos
            Enviar();
        }

        private void Enviar() {
            //CorreoDTO correo = new CorreoDTO();
            OrigenDestinoDTO destino = new OrigenDestinoDTO();
            List<OrigenDestinoDTO> destinos = new List<OrigenDestinoDTO>();

            destino.Direccion = txtPara.Text;
            destino.Cc = false;
            destino.Cco = false;

            correo.OrigenDestino = destinos;

            correo.Asunto = txtAsunto.Text;
            correo.Detalle = txtMensaje.Text;
            correo.OrigenDestino.Add(destino);

            string fechahoyStr = "";
            //fecha = DateTime.Today;
            fechahoyStr = DateTime.Today.ToShortDateString();

            correo.Fecha = DateTime.Parse(fechahoyStr);
            correo.TipoCorreo = Tipo.ENVIADO;

            if (txtCC.Text != "") {
                List<OrigenDestinoDTO> listaCC = PasajeCorreos.getInstance().getListaOrigenDestino(txtCC.Text);
                foreach (OrigenDestinoDTO item in listaCC) {
                    item.Cc = true;
                    item.Cco = false;
                    correo.OrigenDestino.Add(item);
                }
            }

            if (txtCCO.Text != "") {
                List<OrigenDestinoDTO> listaCCO = PasajeCorreos.getInstance().getListaOrigenDestino(txtCCO.Text);
                foreach (OrigenDestinoDTO item in listaCCO) {
                    item.Cc = false;
                    item.Cco = true;
                    correo.OrigenDestino.Add(item);
                }
            }


            try
            {
                MailServer.getInstance().enviarCorreo(correo);
                Controller.Correo.getInstance().agregarCorreo(correo);

                MessageBox.Show("Mensaje Enviado");

                ventanaprincipal.Actualizar();
            }
            catch(Exception ex) { 
                
            }

            this.Dispose();
            
        }

        private void frmNuevoCorreo_Load(object sender, EventArgs e)
        {
            CargarCuentasEnCombo();
        }

        private void CargarCuentasEnCombo() {
            List<CuentaDTO> cuentas = new List<CuentaDTO>();
            try
            {
                cuentas = Controller.Cuenta.getInstance().ListarCuentas();
            }
            catch (Exception ex) { }

            foreach (CuentaDTO cuenta in cuentas) {
                dictionaryCuentas.Add(cuenta.User, cuenta.IdCuenta);
                comboCuentas.Items.Add(cuenta.User);
            }

            if (comboCuentas.Items.Count != 0) comboCuentas.SelectedIndex = 0;
            
        }

        private void comboCuentas_SelectedIndexChanged(object sender, EventArgs e)
        {
            String cuentaStr = comboCuentas.SelectedItem.ToString();
            correo.IdCuenta = dictionaryCuentas[cuentaStr];
        }

        public void PrepararParaResponder(CorreoDTO oCorreo) {
            if (tipo == "reply") {

                CorreoDTO mail = new CorreoDTO();
                mail.IdCorreo = oCorreo.IdCorreo;
                mail = Controller.Correo.getInstance().obtenerCorreo(mail);

                List<OrigenDestinoDTO> origenes = new List<OrigenDestinoDTO>();
                origenes = mail.OrigenDestino;

                String deStr = "";
                foreach (OrigenDestinoDTO origen in origenes)
                {
                    if (origen.Cc == false && origen.Cco == false)
                        deStr = origen.Direccion;
                }

                String ccStr = "";
                String ccoStr = "";
                foreach (OrigenDestinoDTO origen in origenes)
                {
                    if (origen.Cc == true)
                        ccStr = ccStr + origen.Direccion + "; ";
                    else if (origen.Cco == true)
                        ccoStr = ccoStr + origen.Direccion + "; ";
                }

                txtPara.Text = deStr;
                txtCC.Text = ccStr;
                txtCCO.Text = ccoStr;

                txtAsunto.Text = "RE: " + mail.Asunto;

            }
        }

        public void PrepararParaReenviar(CorreoDTO oCorreo) {
            if (tipo == "forward")
            {
                txtAsunto.Text = "FWD: " + oCorreo.Asunto;
                txtMensaje.Text = oCorreo.Detalle;
            }
        }
    }
}
