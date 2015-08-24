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
    public partial class frmCuentas : Form
    {
        CuentaDTO cuenta;
        frmPrincipal main;
        Dictionary<String, int> dictionaryServidores = new Dictionary<string, int>();

        public frmCuentas(frmPrincipal oMain)
        {
            InitializeComponent();
            main = oMain;

            ArmarTabla();
            ActualizarDatos();
        }

        private void frmCuentas_Load(object sender, EventArgs e)
        {

        }

        private void ArmarTabla() {
            dgvCuentas.Columns.Add("Id", "Id");
            dgvCuentas.Columns.Add("Usuario", "Usuario");
            dgvCuentas.Columns.Add("Servidor", "Servidor");

            dgvCuentas.Columns["Id"].Visible = false;
            dgvCuentas.Columns["Servidor"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvCuentas.Columns["Usuario"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            CargarComboServidores();
        }

        private void CargarComboServidores() {
            List<ServerDTO> servidores = Controller.Server.getInstance().ListarServers();

            if (servidores != null) {
                foreach (ServerDTO servidor in servidores) {
                    comboServidor.Items.Add(servidor.Name);
                    dictionaryServidores.Add(servidor.Name, servidor.Id);
                }
            }

        }

        private void ActualizarDatos() {
            try {
                ActualizarDatosLista(Controller.Cuenta.getInstance().ListarCuentas());
            }
            catch (Exception ex) { }
        }

        private void ActualizarDatosLista(List<CuentaDTO> cuentas) {
            if (dgvCuentas.Rows.Count != 0)
            {
                foreach (DataGridViewRow fila in dgvCuentas.Rows)
                    dgvCuentas.Rows.Remove(fila);
            }

            foreach (CuentaDTO cuenta in cuentas)
            {
                ServerDTO servidortemp = new ServerDTO();
                servidortemp.Id = cuenta.Server;

                ServerDTO servidor = Controller.Server.getInstance().ObtenerServer(servidortemp);
                
                dgvCuentas.Rows.Add(cuenta.IdCuenta.ToString(),cuenta.User,servidor.Name);
            }
        }

        private void dgvCuentas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvCuentas.Rows.Count == 0)
                return;

            DataGridViewRow fila = dgvCuentas.SelectedRows[0];
            int idcuenta = int.Parse(fila.Cells[0].Value.ToString());

            CuentaDTO cuentaSeleccionada = new CuentaDTO();
            cuentaSeleccionada.IdCuenta = idcuenta;
            cuenta = Controller.Cuenta.getInstance().ObtenerCuenta(cuentaSeleccionada);

            btnEditar.Enabled = true;
            btnEliminar.Enabled = true;

            CargarCampos();
        }

        private void CargarCampos() {
            if (cuenta == null)
                return;

            txtUsuario.Text = cuenta.User;
            txtPassword.Text = cuenta.Password;

            ServerDTO servidortemp = new ServerDTO();
            servidortemp.Id = cuenta.Server;

            ServerDTO servidor = Controller.Server.getInstance().ObtenerServer(servidortemp);

            try
            {
                comboServidor.SelectedItem = servidor.Name;
            }
            catch (Exception ex) { }
            
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            CuentaDTO nuevacuenta = new CuentaDTO();
            nuevacuenta.User = txtUsuario.Text;
            nuevacuenta.Password = txtPassword.Text;

            int idserver = dictionaryServidores[comboServidor.SelectedItem.ToString()];
            nuevacuenta.Server = idserver;

            try {
                Controller.Cuenta.getInstance().AgregarCuenta(nuevacuenta);
                ActualizarDatos();
                LimpiarCampos();
            }
            catch (Exception ex) { }

        }

        private void LimpiarCampos() {
            txtPassword.Text = "";
            txtUsuario.Text = "";
            comboServidor.SelectedIndex = 0;
        }
    }
}
