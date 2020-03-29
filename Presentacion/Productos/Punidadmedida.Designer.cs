namespace Presentacion
{
    partial class Punidadmedida
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Punidadmedida));
            this.btneps = new Bunifu.Framework.UI.BunifuThinButton2();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btneps
            // 
            this.btneps.ActiveBorderThickness = 1;
            this.btneps.ActiveCornerRadius = 20;
            this.btneps.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(168)))), ((int)(((byte)(93)))));
            this.btneps.ActiveForecolor = System.Drawing.Color.White;
            this.btneps.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(168)))), ((int)(((byte)(93)))));
            this.btneps.BackColor = System.Drawing.SystemColors.Control;
            this.btneps.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btneps.BackgroundImage")));
            this.btneps.ButtonText = "Registrar";
            this.btneps.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btneps.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btneps.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(112)))), ((int)(((byte)(62)))));
            this.btneps.IdleBorderThickness = 1;
            this.btneps.IdleCornerRadius = 20;
            this.btneps.IdleFillColor = System.Drawing.Color.White;
            this.btneps.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(168)))), ((int)(((byte)(93)))));
            this.btneps.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(168)))), ((int)(((byte)(93)))));
            this.btneps.Location = new System.Drawing.Point(262, 147);
            this.btneps.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btneps.Name = "btneps";
            this.btneps.Size = new System.Drawing.Size(207, 49);
            this.btneps.TabIndex = 89;
            this.btneps.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btneps.Click += new System.EventHandler(this.btneps_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(25, 104);
            this.textBox1.MaxLength = 50;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(447, 34);
            this.textBox1.TabIndex = 88;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(168)))), ((int)(((byte)(93)))));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(486, 78);
            this.label1.TabIndex = 87;
            this.label1.Text = "Nueva Unidad";
            // 
            // Punidadmedida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 202);
            this.Controls.Add(this.btneps);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "Punidadmedida";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Punidadmedida";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuThinButton2 btneps;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
    }
}