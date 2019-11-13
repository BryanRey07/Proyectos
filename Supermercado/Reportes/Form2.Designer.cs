namespace Supermercado.Reportes
{
    partial class Form2
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
            this.Button1 = new System.Windows.Forms.Button();
            this.txtRutaArchivo = new System.Windows.Forms.TextBox();
            this.Label5 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.Label4 = new System.Windows.Forms.Label();
            this.BtnEnviar = new System.Windows.Forms.Button();
            this.rtbMensaje = new System.Windows.Forms.RichTextBox();
            this.txtAsunto = new System.Windows.Forms.TextBox();
            this.txtReceptor = new System.Windows.Forms.TextBox();
            this.txtEmisor = new System.Windows.Forms.TextBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // Button1
            // 
            this.Button1.Location = new System.Drawing.Point(481, 98);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(43, 23);
            this.Button1.TabIndex = 38;
            this.Button1.Text = ".....";
            this.Button1.UseVisualStyleBackColor = true;
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // txtRutaArchivo
            // 
            this.txtRutaArchivo.Location = new System.Drawing.Point(61, 100);
            this.txtRutaArchivo.Name = "txtRutaArchivo";
            this.txtRutaArchivo.Size = new System.Drawing.Size(414, 20);
            this.txtRutaArchivo.TabIndex = 37;
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Label5.Location = new System.Drawing.Point(8, 104);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(49, 13);
            this.Label5.TabIndex = 36;
            this.Label5.Text = "Adjuntar:";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(343, 21);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(182, 20);
            this.txtPassword.TabIndex = 35;
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Label4.Location = new System.Drawing.Point(273, 24);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(64, 13);
            this.Label4.TabIndex = 34;
            this.Label4.Text = "Contraseña:";
            // 
            // BtnEnviar
            // 
            this.BtnEnviar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnEnviar.Location = new System.Drawing.Point(234, 252);
            this.BtnEnviar.Name = "BtnEnviar";
            this.BtnEnviar.Size = new System.Drawing.Size(75, 23);
            this.BtnEnviar.TabIndex = 33;
            this.BtnEnviar.Text = "Enviar";
            this.BtnEnviar.UseVisualStyleBackColor = false;
            this.BtnEnviar.Click += new System.EventHandler(this.BtnEnviar_Click);
            // 
            // rtbMensaje
            // 
            this.rtbMensaje.Location = new System.Drawing.Point(61, 128);
            this.rtbMensaje.Name = "rtbMensaje";
            this.rtbMensaje.Size = new System.Drawing.Size(464, 118);
            this.rtbMensaje.TabIndex = 32;
            this.rtbMensaje.Text = "";
            // 
            // txtAsunto
            // 
            this.txtAsunto.Location = new System.Drawing.Point(61, 73);
            this.txtAsunto.Name = "txtAsunto";
            this.txtAsunto.Size = new System.Drawing.Size(206, 20);
            this.txtAsunto.TabIndex = 31;
            // 
            // txtReceptor
            // 
            this.txtReceptor.Location = new System.Drawing.Point(61, 47);
            this.txtReceptor.Name = "txtReceptor";
            this.txtReceptor.Size = new System.Drawing.Size(206, 20);
            this.txtReceptor.TabIndex = 30;
            // 
            // txtEmisor
            // 
            this.txtEmisor.Location = new System.Drawing.Point(61, 21);
            this.txtEmisor.Name = "txtEmisor";
            this.txtEmisor.Size = new System.Drawing.Size(206, 20);
            this.txtEmisor.TabIndex = 29;
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Label3.Location = new System.Drawing.Point(14, 76);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(43, 13);
            this.Label3.TabIndex = 28;
            this.Label3.Text = "Asunto:";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Label2.Location = new System.Drawing.Point(15, 50);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(32, 13);
            this.Label2.TabIndex = 27;
            this.Label2.Text = "Para:";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Label1.Location = new System.Drawing.Point(15, 24);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(24, 13);
            this.Label1.TabIndex = 26;
            this.Label1.Text = "De:";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(592, 301);
            this.Controls.Add(this.Button1);
            this.Controls.Add(this.txtRutaArchivo);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.BtnEnviar);
            this.Controls.Add(this.rtbMensaje);
            this.Controls.Add(this.txtAsunto);
            this.Controls.Add(this.txtReceptor);
            this.Controls.Add(this.txtEmisor);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Enviar Email";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button Button1;
        internal System.Windows.Forms.TextBox txtRutaArchivo;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.TextBox txtPassword;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Button BtnEnviar;
        internal System.Windows.Forms.RichTextBox rtbMensaje;
        internal System.Windows.Forms.TextBox txtAsunto;
        internal System.Windows.Forms.TextBox txtReceptor;
        internal System.Windows.Forms.TextBox txtEmisor;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}