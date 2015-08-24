namespace ClienteCorreo.UI
{
    partial class frmNuevoCorreo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNuevoCorreo));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtAsunto = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCCO = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCC = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPara = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMensaje = new System.Windows.Forms.RichTextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.limpiarAdjuntosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarArchivoAdjuntoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tbEnviar = new System.Windows.Forms.ToolStripButton();
            this.comboCuentas = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.txtAsunto);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtCCO);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtCC);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtPara);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(8, 64);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(518, 136);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Correo";
            // 
            // txtAsunto
            // 
            this.txtAsunto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAsunto.Location = new System.Drawing.Point(52, 105);
            this.txtAsunto.Name = "txtAsunto";
            this.txtAsunto.Size = new System.Drawing.Size(445, 20);
            this.txtAsunto.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Asunto:";
            // 
            // txtCCO
            // 
            this.txtCCO.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCCO.Location = new System.Drawing.Point(52, 78);
            this.txtCCO.Name = "txtCCO";
            this.txtCCO.Size = new System.Drawing.Size(445, 20);
            this.txtCCO.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "CCO:";
            // 
            // txtCC
            // 
            this.txtCC.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCC.Location = new System.Drawing.Point(52, 50);
            this.txtCC.Name = "txtCC";
            this.txtCC.Size = new System.Drawing.Size(445, 20);
            this.txtCC.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "CC:";
            // 
            // txtPara
            // 
            this.txtPara.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPara.Location = new System.Drawing.Point(52, 22);
            this.txtPara.Name = "txtPara";
            this.txtPara.Size = new System.Drawing.Size(445, 20);
            this.txtPara.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Para:";
            // 
            // txtMensaje
            // 
            this.txtMensaje.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMensaje.Location = new System.Drawing.Point(8, 206);
            this.txtMensaje.Name = "txtMensaje";
            this.txtMensaje.Size = new System.Drawing.Size(518, 355);
            this.txtMensaje.TabIndex = 1;
            this.txtMensaje.Text = "";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1,
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 569);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(537, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.limpiarAdjuntosToolStripMenuItem,
            this.agregarArchivoAdjuntoToolStripMenuItem});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(84, 20);
            this.toolStripDropDownButton1.Text = "Adjuntos";
            // 
            // limpiarAdjuntosToolStripMenuItem
            // 
            this.limpiarAdjuntosToolStripMenuItem.Name = "limpiarAdjuntosToolStripMenuItem";
            this.limpiarAdjuntosToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.limpiarAdjuntosToolStripMenuItem.Text = "Limpiar Adjuntos";
            // 
            // agregarArchivoAdjuntoToolStripMenuItem
            // 
            this.agregarArchivoAdjuntoToolStripMenuItem.Name = "agregarArchivoAdjuntoToolStripMenuItem";
            this.agregarArchivoAdjuntoToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.agregarArchivoAdjuntoToolStripMenuItem.Text = "Agregar Archivo Adjunto";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(106, 17);
            this.toolStripStatusLabel1.Text = "Adjuntos: ninguno";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tbEnviar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(537, 25);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tbEnviar
            // 
            this.tbEnviar.Image = ((System.Drawing.Image)(resources.GetObject("tbEnviar.Image")));
            this.tbEnviar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbEnviar.Name = "tbEnviar";
            this.tbEnviar.Size = new System.Drawing.Size(59, 22);
            this.tbEnviar.Text = "Enviar";
            this.tbEnviar.Click += new System.EventHandler(this.tbEnviar_Click);
            // 
            // comboCuentas
            // 
            this.comboCuentas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboCuentas.FormattingEnabled = true;
            this.comboCuentas.Location = new System.Drawing.Point(123, 33);
            this.comboCuentas.Name = "comboCuentas";
            this.comboCuentas.Size = new System.Drawing.Size(181, 21);
            this.comboCuentas.TabIndex = 4;
            this.comboCuentas.SelectedIndexChanged += new System.EventHandler(this.comboCuentas_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Seleccionar Cuenta:";
            // 
            // frmNuevoCorreo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 591);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboCuentas);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.txtMensaje);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmNuevoCorreo";
            this.Text = "Nuevo Correo";
            this.Load += new System.EventHandler(this.frmNuevoCorreo_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtAsunto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCCO;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCC;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPara;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox txtMensaje;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem limpiarAdjuntosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarArchivoAdjuntoToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tbEnviar;
        private System.Windows.Forms.ComboBox comboCuentas;
        private System.Windows.Forms.Label label5;
    }
}