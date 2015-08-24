using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using ClienteCorreo.DTO;

namespace ClienteCorreo.UI
{
    public partial class frmServidores : Form
    {
        frmPrincipal main;
        ServerDTO server = new ServerDTO();

        public frmServidores(frmPrincipal oMain)
        {
            InitializeComponent();
            main = oMain;
            //Cargo datos
            ArmarTabla();
            ActualizarLista();
        }

        private void frmServidores_Load(object sender, EventArgs e)
        {

        }

        private void ArmarTabla() {
            dgvServidores.Columns.Add("Id", "Id");
            dgvServidores.Columns.Add("Nombre", "Nombre");
            dgvServidores.Columns.Add("Pop", "Pop");
            dgvServidores.Columns.Add("Smtp", "Smtp");

            dgvServidores.Columns["Id"].Visible = false;
            dgvServidores.Columns["Pop"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvServidores.Columns["Smtp"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvServidores.Columns["Nombre"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void ActualizarLista() {
            try {
                ActualizarListaServidores(Controller.Server.getInstance().ListarServers());    
            }
            catch (Exception ex) { }
        }

        private void ActualizarListaServidores(List<ServerDTO> servidores) { 
            //Clear
            if (dgvServidores.Rows.Count != 0) {
                foreach (DataGridViewRow fila in dgvServidores.Rows)
                    dgvServidores.Rows.Remove(fila);
            }

            foreach (ServerDTO server in servidores) {
                dgvServidores.Rows.Add(server.Id.ToString(), server.Name, server.PopServer, server.SmtpServer);
            }
            //tabla.Rows.Add(correoObtenido.IdCorreo.ToString(), remitente, correoObtenido.Asunto.ToString(), correoObtenido.Fecha.ToString(), correoObtenido.Read);
        }

        private void CargarCampos() {
            if (server == null)
                return;

            txtNombre.Text = server.Name;
            txtPop.Text = server.PopServer;
            txtPuertoPop.Text = server.PopPort.ToString();
            txtSmtp.Text = server.SmtpServer;
            txtPuertoSmtp.Text = server.SmtpPort.ToString();
            chkSsl.Checked = server.Ssl;

            btnEditar.Enabled = true;
            btnEliminar.Enabled = true;

        }

        private void dgvServidores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvServidores.Rows.Count == 0)
                return;

            DataGridViewRow fila = dgvServidores.SelectedRows[0];
            int idservidor = int.Parse(fila.Cells[0].Value.ToString());

            ServerDTO serverSeleccionado = new ServerDTO();
            serverSeleccionado.Id = idservidor;
            server = Controller.Server.getInstance().ObtenerServer(serverSeleccionado);

            CargarCampos();

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            server.Name = txtNombre.Text;
            server.PopServer = txtPop.Text;
            server.PopPort = int.Parse(txtPuertoPop.Text);
            server.SmtpServer = txtSmtp.Text;
            server.SmtpPort = int.Parse(txtPuertoSmtp.Text);
            server.Ssl = chkSsl.Checked;

            Controller.Server.getInstance().AgregarServer(server);

            ActualizarLista();

        }
    
    
    }

}
