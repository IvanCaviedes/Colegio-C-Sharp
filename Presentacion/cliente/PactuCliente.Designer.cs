namespace Presentacion
{
    partial class PactuCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PactuCliente));
            this.txttel2 = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.txtemail = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.txtcelular = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.txtdireccion = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.txttelefono = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.txtidentificacion = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.txtnomcliente = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.registrar = new Bunifu.Framework.UI.BunifuThinButton2();
            this.cmbestado = new System.Windows.Forms.ComboBox();
            this.label18 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txttel2
            // 
            this.txttel2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystemDirectories;
            this.txttel2.BorderColor = System.Drawing.Color.Red;
            this.txttel2.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttel2.Location = new System.Drawing.Point(434, 279);
            this.txttel2.MaxLength = 7;
            this.txttel2.Name = "txttel2";
            this.txttel2.Size = new System.Drawing.Size(166, 34);
            this.txttel2.TabIndex = 114;
            this.txttel2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txttel2_KeyPress);
            // 
            // txtemail
            // 
            this.txtemail.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystemDirectories;
            this.txtemail.BorderColor = System.Drawing.Color.Red;
            this.txtemail.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtemail.Location = new System.Drawing.Point(65, 274);
            this.txtemail.MaxLength = 50;
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(275, 34);
            this.txtemail.TabIndex = 113;
            this.txtemail.Leave += new System.EventHandler(this.txtemail_Leave);
            // 
            // txtcelular
            // 
            this.txtcelular.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystemDirectories;
            this.txtcelular.BorderColor = System.Drawing.Color.Red;
            this.txtcelular.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcelular.Location = new System.Drawing.Point(434, 230);
            this.txtcelular.MaxLength = 10;
            this.txtcelular.Name = "txtcelular";
            this.txtcelular.Size = new System.Drawing.Size(166, 34);
            this.txtcelular.TabIndex = 112;
            this.txtcelular.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcelular_KeyPress);
            // 
            // txtdireccion
            // 
            this.txtdireccion.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystemDirectories;
            this.txtdireccion.BorderColor = System.Drawing.Color.Red;
            this.txtdireccion.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdireccion.Location = new System.Drawing.Point(115, 230);
            this.txtdireccion.MaxLength = 30;
            this.txtdireccion.Name = "txtdireccion";
            this.txtdireccion.Size = new System.Drawing.Size(237, 34);
            this.txtdireccion.TabIndex = 111;
            // 
            // txttelefono
            // 
            this.txttelefono.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystemDirectories;
            this.txttelefono.BorderColor = System.Drawing.Color.Red;
            this.txttelefono.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttelefono.Location = new System.Drawing.Point(434, 185);
            this.txttelefono.MaxLength = 7;
            this.txttelefono.Name = "txttelefono";
            this.txttelefono.Size = new System.Drawing.Size(166, 34);
            this.txttelefono.TabIndex = 110;
            this.txttelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txttelefono_KeyPress);
            // 
            // txtidentificacion
            // 
            this.txtidentificacion.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystemDirectories;
            this.txtidentificacion.BorderColor = System.Drawing.Color.Red;
            this.txtidentificacion.Enabled = false;
            this.txtidentificacion.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtidentificacion.Location = new System.Drawing.Point(180, 185);
            this.txtidentificacion.MaxLength = 10;
            this.txtidentificacion.Name = "txtidentificacion";
            this.txtidentificacion.Size = new System.Drawing.Size(166, 34);
            this.txtidentificacion.TabIndex = 109;
            this.txtidentificacion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtidentificacion_KeyPress);
            // 
            // txtnomcliente
            // 
            this.txtnomcliente.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystemDirectories;
            this.txtnomcliente.BorderColor = System.Drawing.Color.Red;
            this.txtnomcliente.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnomcliente.Location = new System.Drawing.Point(222, 140);
            this.txtnomcliente.MaxLength = 50;
            this.txtnomcliente.Name = "txtnomcliente";
            this.txtnomcliente.Size = new System.Drawing.Size(378, 34);
            this.txtnomcliente.TabIndex = 108;
            this.txtnomcliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtnomcliente_KeyPress);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(128)))), ((int)(((byte)(6)))));
            this.label14.Location = new System.Drawing.Point(350, 289);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(66, 17);
            this.label14.TabIndex = 107;
            this.label14.Text = "opcional";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(128)))), ((int)(((byte)(6)))));
            this.label13.Location = new System.Drawing.Point(339, 267);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(98, 22);
            this.label13.TabIndex = 106;
            this.label13.Text = "Telefono2";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(128)))), ((int)(((byte)(6)))));
            this.label11.Location = new System.Drawing.Point(12, 279);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(56, 22);
            this.label11.TabIndex = 105;
            this.label11.Text = "Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(128)))), ((int)(((byte)(6)))));
            this.label3.Location = new System.Drawing.Point(345, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 22);
            this.label3.TabIndex = 104;
            this.label3.Text = "Telefono";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(128)))), ((int)(((byte)(6)))));
            this.label6.Location = new System.Drawing.Point(358, 235);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 22);
            this.label6.TabIndex = 103;
            this.label6.Text = "Celular";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(128)))), ((int)(((byte)(6)))));
            this.label5.Location = new System.Drawing.Point(277, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 36);
            this.label5.TabIndex = 102;
            this.label5.Text = "Clientes";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(128)))), ((int)(((byte)(6)))));
            this.label10.Location = new System.Drawing.Point(21, 235);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(96, 22);
            this.label10.TabIndex = 100;
            this.label10.Text = "Direccion";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(128)))), ((int)(((byte)(6)))));
            this.label9.Location = new System.Drawing.Point(45, 190);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(135, 22);
            this.label9.TabIndex = 99;
            this.label9.Text = "Identificacion";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(128)))), ((int)(((byte)(6)))));
            this.label2.Location = new System.Drawing.Point(43, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 22);
            this.label2.TabIndex = 98;
            this.label2.Text = "Nombre completo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(128)))), ((int)(((byte)(6)))));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(341, 78);
            this.label1.TabIndex = 97;
            this.label1.Text = "Actualizar";
            // 
            // registrar
            // 
            this.registrar.ActiveBorderThickness = 1;
            this.registrar.ActiveCornerRadius = 20;
            this.registrar.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(170)))), ((int)(((byte)(89)))));
            this.registrar.ActiveForecolor = System.Drawing.Color.White;
            this.registrar.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(170)))), ((int)(((byte)(89)))));
            this.registrar.BackColor = System.Drawing.SystemColors.Control;
            this.registrar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("registrar.BackgroundImage")));
            this.registrar.ButtonText = "Registrar";
            this.registrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.registrar.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registrar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(128)))), ((int)(((byte)(6)))));
            this.registrar.IdleBorderThickness = 1;
            this.registrar.IdleCornerRadius = 20;
            this.registrar.IdleFillColor = System.Drawing.Color.White;
            this.registrar.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(170)))), ((int)(((byte)(89)))));
            this.registrar.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(170)))), ((int)(((byte)(89)))));
            this.registrar.Location = new System.Drawing.Point(187, 339);
            this.registrar.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.registrar.Name = "registrar";
            this.registrar.Size = new System.Drawing.Size(281, 63);
            this.registrar.TabIndex = 101;
            this.registrar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.registrar.Click += new System.EventHandler(this.registrar_Click);
            // 
            // cmbestado
            // 
            this.cmbestado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbestado.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbestado.FormattingEnabled = true;
            this.cmbestado.Items.AddRange(new object[] {
            "Activo",
            "Inactivo"});
            this.cmbestado.Location = new System.Drawing.Point(449, 25);
            this.cmbestado.Name = "cmbestado";
            this.cmbestado.Size = new System.Drawing.Size(184, 29);
            this.cmbestado.TabIndex = 154;
            this.cmbestado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbestado_KeyPress);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.Transparent;
            this.label18.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(128)))), ((int)(((byte)(6)))));
            this.label18.Location = new System.Drawing.Point(382, 32);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(72, 22);
            this.label18.TabIndex = 153;
            this.label18.Text = "Estado";
            // 
            // PactuCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 408);
            this.Controls.Add(this.cmbestado);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.txttel2);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.txtcelular);
            this.Controls.Add(this.txtdireccion);
            this.Controls.Add(this.txttelefono);
            this.Controls.Add(this.txtidentificacion);
            this.Controls.Add(this.txtnomcliente);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.registrar);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "PactuCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PactuUsuario";
            this.Load += new System.EventHandler(this.PactuCliente_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private WindowsFormsControlLibrary1.BunifuCustomTextbox txttel2;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox txtemail;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox txtcelular;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox txtdireccion;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox txttelefono;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox txtidentificacion;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox txtnomcliente;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private Bunifu.Framework.UI.BunifuThinButton2 registrar;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbestado;
        private System.Windows.Forms.Label label18;
    }
}