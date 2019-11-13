namespace Supermercado.Mantenimientos
{
    partial class Usuarios
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
            this.btnsalir = new System.Windows.Forms.Button();
            this.btnborrar = new System.Windows.Forms.Button();
            this.btnnuevo = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnimprimir = new System.Windows.Forms.Button();
            this.btnguardar = new System.Windows.Forms.Button();
            this.txtnivel = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtcodigo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtconfirmacion = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btncosulta = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnsalir
            // 
            this.btnsalir.Location = new System.Drawing.Point(366, 18);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(75, 40);
            this.btnsalir.TabIndex = 1;
            this.btnsalir.Text = "Salir";
            this.btnsalir.UseVisualStyleBackColor = true;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // btnborrar
            // 
            this.btnborrar.Location = new System.Drawing.Point(192, 18);
            this.btnborrar.Name = "btnborrar";
            this.btnborrar.Size = new System.Drawing.Size(75, 40);
            this.btnborrar.TabIndex = 1;
            this.btnborrar.Text = "Borrar";
            this.btnborrar.UseVisualStyleBackColor = true;
            this.btnborrar.Click += new System.EventHandler(this.btnborrar_Click);
            // 
            // btnnuevo
            // 
            this.btnnuevo.Location = new System.Drawing.Point(102, 18);
            this.btnnuevo.Name = "btnnuevo";
            this.btnnuevo.Size = new System.Drawing.Size(75, 40);
            this.btnnuevo.TabIndex = 1;
            this.btnnuevo.Text = "Nuevo";
            this.btnnuevo.UseVisualStyleBackColor = true;
            this.btnnuevo.Click += new System.EventHandler(this.btnnuevo_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnsalir);
            this.panel1.Controls.Add(this.btnimprimir);
            this.panel1.Controls.Add(this.btnborrar);
            this.panel1.Controls.Add(this.btnnuevo);
            this.panel1.Controls.Add(this.btnguardar);
            this.panel1.Location = new System.Drawing.Point(37, 324);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(453, 79);
            this.panel1.TabIndex = 6;
            // 
            // btnimprimir
            // 
            this.btnimprimir.Location = new System.Drawing.Point(281, 18);
            this.btnimprimir.Name = "btnimprimir";
            this.btnimprimir.Size = new System.Drawing.Size(75, 40);
            this.btnimprimir.TabIndex = 1;
            this.btnimprimir.Text = "Imprimir";
            this.btnimprimir.UseVisualStyleBackColor = true;
            // 
            // btnguardar
            // 
            this.btnguardar.Location = new System.Drawing.Point(12, 18);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(75, 40);
            this.btnguardar.TabIndex = 1;
            this.btnguardar.Text = "Guardar";
            this.btnguardar.UseVisualStyleBackColor = true;
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
            // 
            // txtnivel
            // 
            this.txtnivel.FormattingEnabled = true;
            this.txtnivel.Items.AddRange(new object[] {
            "Administrador",
            "Supervisor",
            "Vendedor"});
            this.txtnivel.Location = new System.Drawing.Point(140, 211);
            this.txtnivel.Name = "txtnivel";
            this.txtnivel.Size = new System.Drawing.Size(217, 21);
            this.txtnivel.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(98, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Codigo";
            // 
            // txtcodigo
            // 
            this.txtcodigo.Location = new System.Drawing.Point(140, 30);
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.ReadOnly = true;
            this.txtcodigo.Size = new System.Drawing.Size(111, 20);
            this.txtcodigo.TabIndex = 9;
            this.txtcodigo.TextChanged += new System.EventHandler(this.txtcodigo_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(90, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Nombre";
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(140, 77);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(217, 20);
            this.txtnombre.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(71, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Contrasena";
            // 
            // txtpassword
            // 
            this.txtpassword.Location = new System.Drawing.Point(140, 121);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.PasswordChar = '*';
            this.txtpassword.Size = new System.Drawing.Size(217, 20);
            this.txtpassword.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(64, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Confirmacion";
            // 
            // txtconfirmacion
            // 
            this.txtconfirmacion.Location = new System.Drawing.Point(140, 165);
            this.txtconfirmacion.Name = "txtconfirmacion";
            this.txtconfirmacion.PasswordChar = '*';
            this.txtconfirmacion.Size = new System.Drawing.Size(217, 20);
            this.txtconfirmacion.TabIndex = 9;
            this.txtconfirmacion.TextChanged += new System.EventHandler(this.txtconfirmacion_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(102, 214);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Nivel";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btncosulta
            // 
            this.btncosulta.Location = new System.Drawing.Point(256, 29);
            this.btncosulta.Name = "btncosulta";
            this.btncosulta.Size = new System.Drawing.Size(24, 23);
            this.btncosulta.TabIndex = 10;
            this.btncosulta.Text = "+";
            this.btncosulta.UseVisualStyleBackColor = true;
            this.btncosulta.Click += new System.EventHandler(this.btncosulta_Click);
            // 
            // Usuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 426);
            this.Controls.Add(this.btncosulta);
            this.Controls.Add(this.txtconfirmacion);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtpassword);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtcodigo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtnivel);
            this.Controls.Add(this.panel1);
            this.Name = "Usuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Usuarios";
            this.Load += new System.EventHandler(this.Usuarios_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnsalir;
        private System.Windows.Forms.Button btnborrar;
        private System.Windows.Forms.Button btnnuevo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnimprimir;
        private System.Windows.Forms.Button btnguardar;
        private System.Windows.Forms.ComboBox txtnivel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtcodigo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtpassword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtconfirmacion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button btncosulta;
    }
}