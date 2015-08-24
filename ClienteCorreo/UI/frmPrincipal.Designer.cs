namespace ClienteCorreo.UI
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Recibidos");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Enviados");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Borradores");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Cuenta", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3});
            this.dgvMensajes = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoCorreoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sincronizarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.opcionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tbCuentas = new System.Windows.Forms.ToolStripMenuItem();
            this.tbServidores = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.configuraciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tbNuevoCorreo = new System.Windows.Forms.ToolStripButton();
            this.tbResponder = new System.Windows.Forms.ToolStripButton();
            this.tbReenviar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tbSincronizar = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tsMensajes = new System.Windows.Forms.ToolStripStatusLabel();
            this.tbStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.treeMenu = new System.Windows.Forms.TreeView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.tbEliminar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMensajes)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvMensajes
            // 
            this.dgvMensajes.AllowUserToAddRows = false;
            this.dgvMensajes.AllowUserToDeleteRows = false;
            this.dgvMensajes.AllowUserToResizeRows = false;
            this.dgvMensajes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvMensajes.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Droid Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMensajes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvMensajes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Droid Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMensajes.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvMensajes.Location = new System.Drawing.Point(179, 52);
            this.dgvMensajes.MultiSelect = false;
            this.dgvMensajes.Name = "dgvMensajes";
            this.dgvMensajes.ReadOnly = true;
            this.dgvMensajes.RowHeadersVisible = false;
            this.dgvMensajes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMensajes.Size = new System.Drawing.Size(781, 611);
            this.dgvMensajes.TabIndex = 0;
            this.dgvMensajes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMensajes_CellClick);
            this.dgvMensajes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMensajes_CellContentClick);
            this.dgvMensajes.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMensajes_CellContentDoubleClick);
            this.dgvMensajes.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMensajes_CellDoubleClick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.opcionesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(960, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoCorreoToolStripMenuItem,
            this.sincronizarToolStripMenuItem,
            this.toolStripMenuItem2,
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "&Archivo";
            // 
            // nuevoCorreoToolStripMenuItem
            // 
            this.nuevoCorreoToolStripMenuItem.Name = "nuevoCorreoToolStripMenuItem";
            this.nuevoCorreoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.nuevoCorreoToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.nuevoCorreoToolStripMenuItem.Text = "Nuevo Correo";
            // 
            // sincronizarToolStripMenuItem
            // 
            this.sincronizarToolStripMenuItem.Name = "sincronizarToolStripMenuItem";
            this.sincronizarToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.sincronizarToolStripMenuItem.Text = "Sincronizar";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(188, 6);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            // 
            // opcionesToolStripMenuItem
            // 
            this.opcionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tbCuentas,
            this.tbServidores,
            this.toolStripMenuItem1,
            this.configuraciónToolStripMenuItem});
            this.opcionesToolStripMenuItem.Name = "opcionesToolStripMenuItem";
            this.opcionesToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.opcionesToolStripMenuItem.Text = "&Opciones";
            // 
            // tbCuentas
            // 
            this.tbCuentas.Name = "tbCuentas";
            this.tbCuentas.Size = new System.Drawing.Size(152, 22);
            this.tbCuentas.Text = "Cuentas";
            this.tbCuentas.Click += new System.EventHandler(this.tbCuentas_Click);
            // 
            // tbServidores
            // 
            this.tbServidores.Name = "tbServidores";
            this.tbServidores.Size = new System.Drawing.Size(152, 22);
            this.tbServidores.Text = "Servidores";
            this.tbServidores.Click += new System.EventHandler(this.tbServidores_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(149, 6);
            // 
            // configuraciónToolStripMenuItem
            // 
            this.configuraciónToolStripMenuItem.Name = "configuraciónToolStripMenuItem";
            this.configuraciónToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.configuraciónToolStripMenuItem.Text = "Configuración";
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.White;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tbNuevoCorreo,
            this.tbResponder,
            this.tbReenviar,
            this.toolStripSeparator1,
            this.tbSincronizar,
            this.toolStripSeparator2,
            this.tbEliminar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(960, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tbNuevoCorreo
            // 
            this.tbNuevoCorreo.Font = new System.Drawing.Font("Droid Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNuevoCorreo.Image = ((System.Drawing.Image)(resources.GetObject("tbNuevoCorreo.Image")));
            this.tbNuevoCorreo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbNuevoCorreo.Name = "tbNuevoCorreo";
            this.tbNuevoCorreo.Size = new System.Drawing.Size(109, 22);
            this.tbNuevoCorreo.Text = "Nuevo Correo";
            this.tbNuevoCorreo.Click += new System.EventHandler(this.tbNuevoCorreo_Click);
            // 
            // tbResponder
            // 
            this.tbResponder.Enabled = false;
            this.tbResponder.Font = new System.Drawing.Font("Droid Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbResponder.Image = ((System.Drawing.Image)(resources.GetObject("tbResponder.Image")));
            this.tbResponder.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbResponder.Name = "tbResponder";
            this.tbResponder.Size = new System.Drawing.Size(92, 22);
            this.tbResponder.Text = "Responder";
            this.tbResponder.Click += new System.EventHandler(this.tbResponder_Click);
            // 
            // tbReenviar
            // 
            this.tbReenviar.Enabled = false;
            this.tbReenviar.Font = new System.Drawing.Font("Droid Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbReenviar.Image = ((System.Drawing.Image)(resources.GetObject("tbReenviar.Image")));
            this.tbReenviar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbReenviar.Name = "tbReenviar";
            this.tbReenviar.Size = new System.Drawing.Size(78, 22);
            this.tbReenviar.Text = "Reenviar";
            this.tbReenviar.Click += new System.EventHandler(this.tbReenviar_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // tbSincronizar
            // 
            this.tbSincronizar.Font = new System.Drawing.Font("Segoe UI Emoji", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSincronizar.Image = ((System.Drawing.Image)(resources.GetObject("tbSincronizar.Image")));
            this.tbSincronizar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbSincronizar.Name = "tbSincronizar";
            this.tbSincronizar.Size = new System.Drawing.Size(92, 22);
            this.tbSincronizar.Text = "Sincronizar";
            this.tbSincronizar.Click += new System.EventHandler(this.tbSincronizar_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsMensajes,
            this.tbStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 666);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(960, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tsMensajes
            // 
            this.tsMensajes.Name = "tsMensajes";
            this.tsMensajes.Size = new System.Drawing.Size(175, 17);
            this.tsMensajes.Text = "Bandeja de Entrada: 0 mensajes ";
            // 
            // tbStatus
            // 
            this.tbStatus.Name = "tbStatus";
            this.tbStatus.Size = new System.Drawing.Size(770, 17);
            this.tbStatus.Spring = true;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.treeMenu);
            this.panel1.Location = new System.Drawing.Point(0, 52);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(173, 611);
            this.panel1.TabIndex = 4;
            // 
            // treeMenu
            // 
            this.treeMenu.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.treeMenu.Font = new System.Drawing.Font("Droid Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treeMenu.ImageIndex = 0;
            this.treeMenu.ImageList = this.imageList1;
            this.treeMenu.Location = new System.Drawing.Point(3, 0);
            this.treeMenu.Name = "treeMenu";
            treeNode1.ImageKey = "email_open.ico";
            treeNode1.Name = "nodoBandejaEntrada";
            treeNode1.SelectedImageKey = "email_open.ico";
            treeNode1.Tag = "inbox";
            treeNode1.Text = "Recibidos";
            treeNode2.ImageKey = "email_go1.ico";
            treeNode2.Name = "nodoEnviados";
            treeNode2.SelectedImageKey = "email_go1.ico";
            treeNode2.Tag = "sent";
            treeNode2.Text = "Enviados";
            treeNode3.ImageKey = "script_edit.ico";
            treeNode3.Name = "nodoBorradores";
            treeNode3.SelectedImageKey = "script_edit.ico";
            treeNode3.Tag = "draft";
            treeNode3.Text = "Borradores";
            treeNode4.Name = "Node2";
            treeNode4.Text = "Cuenta";
            this.treeMenu.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode4});
            this.treeMenu.SelectedImageIndex = 0;
            this.treeMenu.ShowNodeToolTips = true;
            this.treeMenu.ShowPlusMinus = false;
            this.treeMenu.ShowRootLines = false;
            this.treeMenu.Size = new System.Drawing.Size(167, 97);
            this.treeMenu.TabIndex = 0;
            this.treeMenu.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeMenu_AfterSelect);
            this.treeMenu.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeMenu_NodeMouseDoubleClick);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "email.ico");
            this.imageList1.Images.SetKeyName(1, "email_open.ico");
            this.imageList1.Images.SetKeyName(2, "email_go1.ico");
            this.imageList1.Images.SetKeyName(3, "script_edit.ico");
            this.imageList1.Images.SetKeyName(4, "stock_attach.png");
            // 
            // tbEliminar
            // 
            this.tbEliminar.Enabled = false;
            this.tbEliminar.Font = new System.Drawing.Font("Droid Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEliminar.Image = global::ClienteCorreo.Properties.Resources.delete;
            this.tbEliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbEliminar.Name = "tbEliminar";
            this.tbEliminar.Size = new System.Drawing.Size(74, 22);
            this.tbEliminar.Text = "Eliminar";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 688);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.dgvMensajes);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmPrincipal";
            this.Text = "Cliente de Correo";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMensajes)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMensajes;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tbNuevoCorreo;
        private System.Windows.Forms.ToolStripButton tbResponder;
        private System.Windows.Forms.ToolStripButton tbReenviar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tbSincronizar;
        private System.Windows.Forms.ToolStripMenuItem nuevoCorreoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sincronizarToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem opcionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tbCuentas;
        private System.Windows.Forms.ToolStripMenuItem tbServidores;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem configuraciónToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TreeView treeMenu;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ToolStripStatusLabel tsMensajes;
        private System.Windows.Forms.ToolStripStatusLabel tbStatus;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tbEliminar;
    }
}