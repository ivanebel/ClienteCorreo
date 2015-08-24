using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

using ClienteCorreo.Controller;
using ClienteCorreo.DTO;
using ClienteCorreo.Utils;

namespace ClienteCorreo.UI
{
    public partial class frmPrincipal : Form
    {
        private Dictionary<int,String> nombreCuentas;
        private int cantidadNoLeidos = 0;
        private string selectednode = "inbox";
        public int correoseleccionado = 0;

        public int maxcorreos = 0;

        [STAThread]
        public static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmPrincipal());

        }

        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            treeMenu.ExpandAll();

            ActualizarTreeView();
            ActualizarDatos(selectednode);
            //Recibo mails
            //Recibir();
            //ActualizarDatos(false);
        }

        public void Actualizar() {
            ActualizarDatos(selectednode);
        }

        /// <summary>
        /// Recibe los correos electrónicos a través de POP.
        /// Los añade a la base de datos
        /// </summary>
        private void Recibir()
        {
            try
            {
                List<CuentaDTO> listaCuentas = Cuenta.getInstance().ListarCuentas();
                nombreCuentas = new Dictionary<int, string>();

                //Solo a modo de prueba: limpio los correos de la DB y vuelvo a cargar todo.
                
                                
                foreach (CuentaDTO cuentaObtenida in listaCuentas)
                {
                    nombreCuentas.Add(cuentaObtenida.IdCuenta, cuentaObtenida.User);

                    //maxcorreos = Controller.Correo.getInstance().UltimoIdCorreo(cuentaObtenida);

                    //Cuento cuántos mails hay con esa cuenta en la DB
                    int cantidadMailsDb = Controller.Correo.getInstance().CantidadCorreos(cuentaObtenida);

                    //Cuento cuántos mails hay con esa cuenta en el server pop.
                    ServerDTO servidor = new ServerDTO();
                    servidor.Id = cuentaObtenida.Server;
                    servidor = Controller.Server.getInstance().ObtenerServer(servidor);
                    AdminPop adminpop = new AdminPop();
                    adminpop.ConectarPop(servidor, cuentaObtenida);
                    int cantidadMailsPop = adminpop.ObtenerCantidadMensajes();
                    
                    //Si DB < POP
                    if (cantidadMailsDb < cantidadMailsPop && cantidadMailsDb != 0) {
                        //Por cada correo obtenido:
                        List<CorreoDTO> listaCorreosDb = Controller.Correo.getInstance().listar(false, false, cuentaObtenida);
                            //Borrar su OrigenDestino
                            //Borrar su Adjunto
                            //Borrar el correo
                        foreach (CorreoDTO correo in listaCorreosDb) {
                            Controller.Correo.getInstance().eliminarCorreo(correo);
                        }
                        
                        //Obtengo lista de mails de POP
                        List<CorreoDTO> listaCorreos = Correo.MailServer.getInstance().leerCorreo(cuentaObtenida);
                        foreach (CorreoDTO correo in listaCorreos)
                        {
                            //Agrego mail
                            //Agrego OrigenDestino
                            //Agrego Adjunto
                            Controller.Correo.getInstance().agregarCorreo(correo);
                        }

                    }
                    //Si no hay correos en DB, cargar los de POP y agregarlos en DB.
                    else if (cantidadMailsDb == 0) {
                        List<CorreoDTO> listaCorreos = Correo.MailServer.getInstance().leerCorreo(cuentaObtenida);
                        foreach (CorreoDTO correo in listaCorreos)
                        {
                            //Agrego mail
                            //Agrego OrigenDestino
                            //Agrego Adjunto
                            Controller.Correo.getInstance().agregarCorreo(correo);
                        }
                    }
                    
                }

            }
            catch (Exception ex)
            {

            }
        }

        private void ActualizarDatos(string folder) {

            List<CorreoDTO> listaCorreos;

            switch (folder) { 
                case "inbox":
                    listaCorreos = Controller.Correo.getInstance().listar(false, false);
                    break;
                case "sent":
                    listaCorreos = Controller.Correo.getInstance().listar(false, true);
                    break;
                case "draft":
                    listaCorreos = Controller.Correo.getInstance().listar(false, false);
                    break;
                default:
                    listaCorreos = Controller.Correo.getInstance().listar(false, false);
                    break;
            }
            

            
            LimpiarLista();

            DataTable tabla = GetFormatoTabla();

            for (int i = 0; i <= listaCorreos.Count - 1; i++) {
                DataRow fila = tabla.NewRow();      //Nueva fila con el formato default
                CorreoDTO correoObtenido = listaCorreos[i];

                //Obtengo remitente
                String remitente = "";
                foreach (OrigenDestinoDTO de in correoObtenido.OrigenDestino) {
                    if (!(de.Cc) && !(de.Cco))
                        remitente = de.Direccion;
                }

                string fechaStr = correoObtenido.Fecha.ToShortDateString();
                List<AttachmentDTO> adjuntos = new List<AttachmentDTO>();

                adjuntos = correoObtenido.Adjuntos;

                CuentaDTO cuenta = new CuentaDTO();
                cuenta.IdCuenta = correoObtenido.IdCuenta;

                cuenta = Controller.Cuenta.getInstance().ObtenerCuenta(cuenta);

                if (adjuntos.Count > 0)
                    tabla.Rows.Add(correoObtenido.IdCorreo.ToString(), remitente, correoObtenido.Asunto.ToString(), fechaStr, correoObtenido.Read, cuenta.User, "A");
                else
                    tabla.Rows.Add(correoObtenido.IdCorreo.ToString(), remitente, correoObtenido.Asunto.ToString(), fechaStr, correoObtenido.Read, cuenta.User);
                
            }

            //La tabla resultante es el nuevo DataSource del DGV.
            dgvMensajes.DataSource = tabla;

            dgvMensajes.Columns[6].HeaderText = "";

            dgvMensajes.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvMensajes.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvMensajes.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvMensajes.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvMensajes.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvMensajes.Columns[0].Visible = false;
            dgvMensajes.Columns[4].Visible = false;
            dgvMensajes.Columns[6].Visible = false;

            DataGridViewImageColumn imgCol = new DataGridViewImageColumn();
            Image image = imageList1.Images[4];

            dgvMensajes.Columns.Add(imgCol);
            dgvMensajes.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            cantidadNoLeidos = 0;

            foreach (DataGridViewRow fila in dgvMensajes.Rows)
            {
                if (fila.Cells["Leido"].Value.ToString() == "False")
                {
                    dgvMensajes.Rows[fila.Index].DefaultCellStyle.BackColor = Color.FromArgb(204, 227, 245);
                    dgvMensajes.Rows[fila.Index].DefaultCellStyle.Font = new Font(dgvMensajes.DefaultCellStyle.Font, FontStyle.Bold);
                    cantidadNoLeidos++;
                }
            }

            foreach (DataGridViewRow fila in dgvMensajes.Rows)
            {
                if (fila.Cells["Adjunto"].Value.ToString() == "A")
                {
                    dgvMensajes.Rows[fila.Index].Cells[7].Value = image;
                }
                else 
                {

                    dgvMensajes.Rows[fila.Index].Cells[7].Style.NullValue = null;
                }
            }
            
            tsMensajes.Text = "Bandeja de Entrada: " + dgvMensajes.Rows.Count.ToString() + " mensajes";

            ActualizarTreeView();

        }

        private DataTable GetFormatoTabla()
        {
            DataTable modelo = new DataTable();

            modelo.Columns.Add("Id");
            modelo.Columns.Add("De");
            modelo.Columns.Add("Asunto");
            modelo.Columns.Add("Fecha");
            modelo.Columns.Add("Leido");
            modelo.Columns.Add("Cuenta");
            modelo.Columns.Add("Adjunto");

            return modelo;

        }

        private void LimpiarLista()
        {
            if (dgvMensajes.Rows.Count != 0) {
                foreach (DataGridViewRow fila in dgvMensajes.Rows)
                    dgvMensajes.Rows.Remove(fila);
            }
        }


        private void ArmarLista(List<CorreoDTO> listaCorreos){
            //Limpiar datos
            DataTable myData = new DataTable();
            myData.Columns.Add();
            
            int filas=0;

            for (int i=0; i <= listaCorreos.Count-1;i++){
                myData.Rows.Add(new Object[i]);
                CorreoDTO correo = listaCorreos[i];
                
            }
        }

        private void ActualizarTreeView() {
            if (selectednode == "inbox") {
                if (cantidadNoLeidos > 0)
                {
                    treeMenu.Nodes[0].Nodes[0].Text = "Recibidos (" + cantidadNoLeidos.ToString() + ")";
                    treeMenu.Nodes[0].Nodes[0].NodeFont = new Font(treeMenu.Font, FontStyle.Bold);
                    treeMenu.Nodes[0].Nodes[0].Toggle();
                    treeMenu.ExpandAll();
                }
                else
                {
                    treeMenu.Nodes[0].Nodes[0].Text = "Recibidos";
                    treeMenu.Nodes[0].Nodes[0].NodeFont = treeMenu.Font;
                    treeMenu.ExpandAll();
                }
            }
            
        }

        private void tbNuevoCorreo_Click(object sender, EventArgs e)
        {
            this.NuevoCorreo();
        }

        private void NuevoCorreo() {
            frmNuevoCorreo nuevocorreo = new frmNuevoCorreo(this,"new");
            nuevocorreo.Show();

        }



        private void dgvMensajes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvMensajes.Rows.Count == 0)
                return;

            tbResponder.Enabled = true;
            tbReenviar.Enabled = true;
            tbEliminar.Enabled = true;
            tbNoLeido.Enabled = true;

            DataGridViewRow filaseleccionada = dgvMensajes.SelectedRows[0];
            correoseleccionado = int.Parse(filaseleccionada.Cells["Id"].Value.ToString());

            //CorreoDTO correo = new CorreoDTO();
            //correo.IdCorreo = idmensaje;
            //correo = Controller.Correo.getInstance().obtenerCorreo(correo);



        }

        private void dgvMensajes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvMensajes.Rows.Count == 0)
                return;

            DataGridViewRow filaseleccionada = dgvMensajes.SelectedRows[0];
            int idmensaje = int.Parse(filaseleccionada.Cells["Id"].Value.ToString());

            //Creo la nueva ventana
            frmCorreo form = new frmCorreo(this);

            CorreoDTO correo = new CorreoDTO();
            correo.IdCorreo = idmensaje;

            form.ObtenerCorreo(correo);

            //Marcar como leído
            dgvMensajes.SelectedRows[0].DefaultCellStyle.Font = dgvMensajes.Font;
            dgvMensajes.SelectedRows[0].DefaultCellStyle.BackColor = dgvMensajes.DefaultCellStyle.BackColor;
            Controller.Correo.getInstance().marcarComoLeido(correo,true);

            //DataGridViewRow filaseleccionada = dgvMensajes.SelectedRows[0];
            filaseleccionada.Cells["Leido"].Value = "True";

            cantidadNoLeidos = 0;
            foreach (DataGridViewRow fila in dgvMensajes.Rows)
            {                
                if (fila.Cells["Leido"].Value.ToString() == "False" && selectednode=="inbox")
                {
                    cantidadNoLeidos++;
                }
            }

            ActualizarTreeView();

            form.Show();
        }

        private void tbServidores_Click(object sender, EventArgs e)
        {
            AbrirServidores();
        }

        private void AbrirServidores() {
            frmServidores abrirservidores = new frmServidores(this);
            abrirservidores.Show();
        }

        private void dgvMensajes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvMensajes_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tbCuentas_Click(object sender, EventArgs e)
        {
            AbrirCuentas();
        }

        private void AbrirCuentas() {
            frmCuentas abrircuentas = new frmCuentas(this);
            abrircuentas.Show();
        }

        private void treeMenu_AfterSelect(object sender, TreeViewEventArgs e)
        {
            
        }

        private void tbSincronizar_Click(object sender, EventArgs e)
        {
            toolStrip1.Enabled = false;
            
            tbStatus.Text = "Sincronizando..";
            UseWaitCursor = true;

            //BackgroundWorker worker = new BackgroundWorker();

            //worker.DoWork += delegate(object s, DoWorkEventArgs args)
            //{
            //    Recibir();
            //    args.Result = true;
            //};

            //worker.RunWorkerCompleted += delegate(object s, RunWorkerCompletedEventArgs args)
            //{
            //    bool result = (bool)args.Result;
            //    if (result) {
            //        ActualizarDatos(false);
            //        UseWaitCursor = false;
            //        tbStatus.Text = "Sincronización Completa";
            //    }
            //};

            Recibir();
            ActualizarDatos(selectednode);
            UseWaitCursor = false;
            tbStatus.Text = "Sincronización Completa";

            toolStrip1.Enabled = true;
            
        }

        private void treeMenu_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            selectednode = treeMenu.SelectedNode.Tag.ToString();
            ActualizarDatos(selectednode);
        }

        private void tbResponder_Click(object sender, EventArgs e)
        {
            if (correoseleccionado == 0)
                return;

            CorreoDTO correo = new CorreoDTO();
            correo.IdCorreo = correoseleccionado;
            correo = Controller.Correo.getInstance().obtenerCorreo(correo);

            List<OrigenDestinoDTO> origenes = correo.OrigenDestino;

            frmNuevoCorreo nuevocorreo = new frmNuevoCorreo(this, "reply");
            nuevocorreo.PrepararParaResponder(correo);
            
            nuevocorreo.Show();


        }

        private void tbReenviar_Click(object sender, EventArgs e)
        {
            if (correoseleccionado == 0)
                return;

            CorreoDTO correo = new CorreoDTO();
            correo.IdCorreo = correoseleccionado;
            correo = Controller.Correo.getInstance().obtenerCorreo(correo);

            frmNuevoCorreo nuevocorreo = new frmNuevoCorreo(this, "forward");
            nuevocorreo.PrepararParaReenviar(correo);

            nuevocorreo.Show();
        }

        private void tbNoLeido_Click(object sender, EventArgs e)
        {
            if (correoseleccionado == 0)
                return;

            CorreoDTO correo = new CorreoDTO();
            correo.IdCorreo = correoseleccionado;
            Controller.Correo.getInstance().marcarComoLeido(correo,false);

            foreach (DataGridViewRow fila in dgvMensajes.SelectedRows) 
            {
                dgvMensajes.Rows[fila.Index].Cells["Leido"].Value = "False";
            }

            cantidadNoLeidos = 0;
            foreach (DataGridViewRow fila in dgvMensajes.Rows)
            {
                if (fila.Cells["Leido"].Value.ToString() == "False" && selectednode == "inbox")
                {
                    dgvMensajes.Rows[fila.Index].DefaultCellStyle.BackColor = Color.FromArgb(204, 227, 245);
                    dgvMensajes.Rows[fila.Index].DefaultCellStyle.Font = new Font(dgvMensajes.DefaultCellStyle.Font, FontStyle.Bold);
                    cantidadNoLeidos++;
                }
            }

            ActualizarTreeView();
        }

        private void dgvMensajes_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvMensajes.SelectedRows.Count > 1)
            {
                tbResponder.Enabled = false;
                tbReenviar.Enabled = false;
            }
            else
            { 
            
            }
        }

        private void tbEliminar_Click(object sender, EventArgs e)
        {
            if (correoseleccionado == 0)
                return;
            if (dgvMensajes.SelectedRows.Count > 1) 
            {
                DialogResult res = MessageBox.Show("Está seguro de que desea eliminar los correos seleccionados?", "Cliente de Correo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (res == DialogResult.Yes)
                {
                    foreach (DataGridViewRow fila in dgvMensajes.SelectedRows) 
                    {
                        CorreoDTO correo = new CorreoDTO();
                        correo.IdCorreo = int.Parse(fila.Cells["Id"].Value.ToString());
                        Controller.Correo.getInstance().eliminarCorreo(correo);
                    }
                    
                    MessageBox.Show("Los correos han sido eliminados.", "Cliente de Correo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    return;
                }
            }
            else if (dgvMensajes.SelectedRows.Count == 1) 
            {
                DialogResult res = MessageBox.Show("Está seguro de que desea eliminar este correo?", "Cliente de Correo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (res == DialogResult.Yes)
                {
                    CorreoDTO correo = new CorreoDTO();
                    correo.IdCorreo = correoseleccionado;
                    Controller.Correo.getInstance().eliminarCorreo(correo);
                    MessageBox.Show("El correo ha sido eliminado.", "Cliente de Correo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    return;
                }
            }
            
        }

        

    }
}
