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
            this.groupCorreo = new System.Windows.Forms.GroupBox();
            this.txtAsunto = new System.Windows.Forms.TextBox();
            this.txtCco = new System.Windows.Forms.TextBox();
            this.txtCc = new System.Windows.Forms.TextBox();
            this.lblsAsunto = new System.Windows.Forms.Label();
            this.lblsCco = new System.Windows.Forms.Label();
            this.lblsCC = new System.Windows.Forms.Label();
            this.txtDe = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCorreo = new System.Windows.Forms.RichTextBox();
            this.wbCorreo = new System.Windows.Forms.WebBrowser();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tsLink = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblDe = new System.Windows.Forms.Label();
            this.lblCc = new System.Windows.Forms.Label();
            this.lblCco = new System.Windows.Forms.Label();
            this.lblAsunto = new System.Windows.Forms.Label();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStrip1.SuspendLayout();
            this.groupCorreo.SuspendLayout();
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
            this.tbResponder.Font = new System.Drawing.Font("Droid Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbResponder.Image = ((System.Drawing.Image)(resources.GetObject("tbResponder.Image")));
            this.tbResponder.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbResponder.Name = "tbResponder";
            this.tbResponder.Size = new System.Drawing.Size(92, 32);
            this.tbResponder.Text = "Responder";
            // 
            // tbReenviar
            // 
            this.tbReenviar.Font = new System.Drawing.Font("Droid Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbReenviar.Image = ((System.Drawing.Image)(resources.GetObject("tbReenviar.Image")));
            this.tbReenviar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbReenviar.Name = "tbReenviar";
            this.tbReenviar.Size = new System.Drawing.Size(78, 32);
            this.tbReenviar.Text = "Reenviar";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 35);
            // 
            // tbMarcarLeido
            // 
            this.tbMarcarLeido.Font = new System.Drawing.Font("Droid Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMarcarLeido.Image = ((System.Drawing.Image)(resources.GetObject("tbMarcarLeido.Image")));
            this.tbMarcarLeido.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbMarcarLeido.Name = "tbMarcarLeido";
            this.tbMarcarLeido.Size = new System.Drawing.Size(136, 32);
            this.tbMarcarLeido.Text = "Marcar como leído";
            // 
            // tbEliminar
            // 
            this.tbEliminar.Font = new System.Drawing.Font("Droid Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEliminar.Image = ((System.Drawing.Image)(resources.GetObject("tbEliminar.Image")));
            this.tbEliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbEliminar.Name = "tbEliminar";
            this.tbEliminar.Size = new System.Drawing.Size(74, 32);
            this.tbEliminar.Text = "Eliminar";
            // 
            // groupCorreo
            // 
            this.groupCorreo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupCorreo.Controls.Add(this.lblAsunto);
            this.groupCorreo.Controls.Add(this.lblCco);
            this.groupCorreo.Controls.Add(this.lblCc);
            this.groupCorreo.Controls.Add(this.lblDe);
            this.groupCorreo.Controls.Add(this.txtAsunto);
            this.groupCorreo.Controls.Add(this.txtCco);
            this.groupCorreo.Controls.Add(this.txtCc);
            this.groupCorreo.Controls.Add(this.lblsAsunto);
            this.groupCorreo.Controls.Add(this.lblsCco);
            this.groupCorreo.Controls.Add(this.lblsCC);
            this.groupCorreo.Controls.Add(this.txtDe);
            this.groupCorreo.Controls.Add(this.label1);
            this.groupCorreo.Location = new System.Drawing.Point(12, 38);
            this.groupCorreo.Name = "groupCorreo";
            this.groupCorreo.Size = new System.Drawing.Size(669, 129);
            this.groupCorreo.TabIndex = 1;
            this.groupCorreo.TabStop = false;
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
            this.txtAsunto.Visible = false;
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
            this.txtCco.Visible = false;
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
            this.txtCc.Visible = false;
            // 
            // lblsAsunto
            // 
            this.lblsAsunto.AutoSize = true;
            this.lblsAsunto.Location = new System.Drawing.Point(20, 98);
            this.lblsAsunto.Name = "lblsAsunto";
            this.lblsAsunto.Size = new System.Drawing.Size(44, 13);
            this.lblsAsunto.TabIndex = 4;
            this.lblsAsunto.Text = "Asunto:";
            // 
            // lblsCco
            // 
            this.lblsCco.AutoSize = true;
            this.lblsCco.Location = new System.Drawing.Point(20, 72);
            this.lblsCco.Name = "lblsCco";
            this.lblsCco.Size = new System.Drawing.Size(33, 13);
            this.lblsCco.TabIndex = 3;
            this.lblsCco.Text = "CCO:";
            // 
            // lblsCC
            // 
            this.lblsCC.AutoSize = true;
            this.lblsCC.Location = new System.Drawing.Point(20, 46);
            this.lblsCC.Name = "lblsCC";
            this.lblsCC.Size = new System.Drawing.Size(24, 13);
            this.lblsCC.TabIndex = 2;
            this.lblsCC.Text = "CC:";
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
            this.txtDe.Visible = false;
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
            this.tsLink,
            this.toolStripStatusLabel1});
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
            // lblDe
            // 
            this.lblDe.AutoSize = true;
            this.lblDe.Font = new System.Drawing.Font("Droid Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDe.Location = new System.Drawing.Point(65, 19);
            this.lblDe.Name = "lblDe";
            this.lblDe.Size = new System.Drawing.Size(66, 15);
            this.lblDe.TabIndex = 5;
            this.lblDe.Text = "Remitente";
            // 
            // lblCc
            // 
            this.lblCc.AutoSize = true;
            this.lblCc.Font = new System.Drawing.Font("Droid Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCc.Location = new System.Drawing.Point(65, 45);
            this.lblCc.Name = "lblCc";
            this.lblCc.Size = new System.Drawing.Size(23, 15);
            this.lblCc.TabIndex = 8;
            this.lblCc.Text = "CC";
            // 
            // lblCco
            // 
            this.lblCco.AutoSize = true;
            this.lblCco.Font = new System.Drawing.Font("Droid Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCco.Location = new System.Drawing.Point(65, 71);
            this.lblCco.Name = "lblCco";
            this.lblCco.Size = new System.Drawing.Size(33, 15);
            this.lblCco.TabIndex = 9;
            this.lblCco.Text = "CCO";
            // 
            // lblAsunto
            // 
            this.lblAsunto.AutoSize = true;
            this.lblAsunto.Font = new System.Drawing.Font("Droid Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAsunto.Location = new System.Drawing.Point(65, 97);
            this.lblAsunto.Name = "lblAsunto";
            this.lblAsunto.Size = new System.Drawing.Size(51, 15);
            this.lblAsunto.TabIndex = 10;
            this.lblAsunto.Text = "Asunto";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Font = new System.Drawing.Font("Droid Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(125, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // frmCorreo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 699);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.wbCorreo);
            this.Controls.Add(this.txtCorreo);
            this.Controls.Add(this.groupCorreo);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("Droid Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCorreo";
            this.Text = "Correo";
            this.Load += new System.EventHandler(this.frmCorreo_Load);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmCorreo_MouseMove);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupCorreo.ResumeLayout(false);
            this.groupCorreo.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.GroupBox groupCorreo;
        private System.Windows.Forms.RichTextBox txtCorreo;
        private System.Windows.Forms.ToolStripButton tbResponder;
        private System.Windows.Forms.ToolStripButton tbReenviar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tbMarcarLeido;
        private System.Windows.Forms.ToolStripButton tbEliminar;
        private System.Windows.Forms.TextBox txtAsunto;
        private System.Windows.Forms.TextBox txtCco;
        private System.Windows.Forms.TextBox txtCc;
        private System.Windows.Forms.Label lblsAsunto;
        private System.Windows.Forms.Label lblsCco;
        private System.Windows.Forms.Label lblsCC;
        private System.Windows.Forms.TextBox txtDe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.WebBrowser wbCorreo;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tsLink;
        private System.Windows.Forms.Label lblDe;
        private System.Windows.Forms.Label lblAsunto;
        private System.Windows.Forms.Label lblCco;
        private System.Windows.Forms.Label lblCc;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    }
}