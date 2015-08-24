namespace ClienteCorreo.UI
{
    partial class frmCorreo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCorreo));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tbResponder = new System.Windows.Forms.ToolStripButton();
            this.tbReenviar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tbMarcarLeido = new System.Windows.Forms.ToolStripButton();
            this.tbEliminar = new System.Windows.Forms.ToolStripButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtAsunto = new System.Windows.Forms.TextBox();
            this.txtCco = new System.Windows.Forms.TextBox();
            this.txtCc = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDe = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCorreo = new System.Windows.Forms.RichTextBox();
            this.wbCorreo = new System.Windows.Forms.WebBrowser();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tsLink = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tbResponder,
            this.tbReenviar,
            this.toolStripSeparator1,
            this.tbMarcarLeido,
            this.tbEliminar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(694, 35);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tbResponder
            // 
            this.tbResponder.Image = ((System.Drawing.Image)(resources.GetObject("tbResponder.Image")));
            this.tbResponder.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbResponder.Name = "tbResponder";
            this.tbResponder.Size = new System.Drawing.Size(83, 32);
            this.tbResponder.Text = "Responder";
            // 
            // tbReenviar
            // 
            this.tbReenviar.Image = ((System.Drawing.Image)(resources.GetObject("tbReenviar.Image")));
            this.tbReenviar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbReenviar.Name = "tbReenviar";
            this.tbReenviar.Size = new System.Drawing.Size(72, 32);
            this.tbReenviar.Text = "Reenviar";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 35);
            // 
            // tbMarcarLeido
            // 
            this.tbMarcarLeido.Image = ((System.Drawing.Image)(resources.GetObject("tbMarcarLeido.Image")));
            this.tbMarcarLeido.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbMarcarLeido.Name = "tbMarcarLeido";
            this.tbMarcarLeido.Size = new System.Drawing.Size(127, 32);
            this.tbMarcarLeido.Text = "Marcar como leído";
            // 
            // tbEliminar
            // 
            this.tbEliminar.Image = ((System.Drawing.Image)(resources.GetObject("tbEliminar.Image")));
            this.tbEliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbEliminar.Name = "tbEliminar";
            this.tbEliminar.Size = new System.Drawing.Size(70, 32);
            this.tbEliminar.Text = "Eliminar";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.txtAsunto);
            this.groupBox1.Controls.Add(this.txtCco);
            this.groupBox1.Controls.Add(this.txtCc);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtDe);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(669, 129);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Correo";
            // 
            // txtAsunto
            // 
            this.txtAsunto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAsunto.BackColor = System.Drawing.Color.White;
            this.txtAsunto.Location = new System.Drawing.Point(68, 95);
            this.txtAsunto.Name = "txtAsunto";
            this.txtAsunto.ReadOnly = true;
            this.txtAsunto.Size = new System.Drawing.Size(570, 20);
            this.txtAsunto.TabIndex = 7;
            // 
            // txtCco
            // 
            this.txtCco.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCco.BackColor = System.Drawing.Color.White;
            this.txtCco.Location = new System.Drawing.Point(68, 69);
            this.txtCco.Name = "txtCco";
            this.txtCco.ReadOnly = true;
            this.txtCco.Size = new System.Drawing.Size(570, 20);
            this.txtCco.TabIndex = 6;
            // 
            // txtCc
            // 
            this.txtCc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCc.BackColor = System.Drawing.Color.White;
            this.txtCc.Location = new System.Drawing.Point(68, 43);
            this.txtCc.Name = "txtCc";
            this.txtCc.ReadOnly = true;
            this.txtCc.Size = new System.Drawing.Size(570, 20);
            this.txtCc.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Asunto:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "CCO:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "CC:";
            // 
            // txtDe
            // 
            this.txtDe.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDe.BackColor = System.Drawing.Color.White;
            this.txtDe.Location = new System.Drawing.Point(68, 17);
            this.txtDe.Name = "txtDe";
            this.txtDe.ReadOnly = true;
            this.txtDe.Size = new System.Drawing.Size(570, 20);
            this.txtDe.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "De:";
            // 
            // txtCorreo
            // 
            this.txtCorreo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCorreo.BackColor = System.Drawing.Color.White;
            this.txtCorreo.Location = new System.Drawing.Point(12, 173);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.ReadOnly = true;
            this.txtCorreo.Size = new System.Drawing.Size(395, 460);
            this.txtCorreo.TabIndex = 2;
            this.txtCorreo.Text = "";
            this.txtCorreo.Visible = false;
            // 
            // wbCorreo
            // 
            this.wbCorreo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.wbCorreo.Location = new System.Drawing.Point(12, 173);
            this.wbCorreo.MinimumSize = new System.Drawing.Size(20, 20);
            this.wbCorreo.Name = "wbCorreo";
            this.wbCorreo.Size = new System.Drawing.Size(669, 501);
            this.wbCorreo.TabIndex = 3;
            this.wbCorreo.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.wbCorreo_DocumentCompleted);
            this.wbCorreo.Navigated += new System.Windows.Forms.WebBrowserNavigatedEventHandler(this.wbCorreo_Navigated);
            this.wbCorreo.Navigating += new System.Windows.Forms.WebBrowserNavigatingEventHandler(this.wbCorreo_Navigating);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsLink});
            this.statusStrip1.Location = new System.Drawing.Point(0, 677);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(694, 22);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tsLink
            // 
            this.tsLink.Name = "tsLink";
            this.tsLink.Size = new System.Drawing.Size(0, 17);
            // 
            // frmCorreo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 699);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.wbCorreo);
            this.Controls.Add(this.txtCorreo);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCorreo";
            this.Text = "Correo";
            this.Load += new System.EventHandler(this.frmCorreo_Load);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmCorreo_MouseMove);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox txtCorreo;
        private System.Windows.Forms.ToolStripButton tbResponder;
        private System.Windows.Forms.ToolStripButton tbReenviar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tbMarcarLeido;
        private System.Windows.Forms.ToolStripButton tbEliminar;
        private System.Windows.Forms.TextBox txtAsunto;
        private System.Windows.Forms.TextBox txtCco;
        private System.Windows.Forms.TextBox txtCc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.WebBrowser wbCorreo;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tsLink;
    }
}