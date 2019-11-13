namespace Supermercado.Procesos
{
    partial class Factura
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnsalir = new System.Windows.Forms.Button();
            this.btncancelar = new System.Windows.Forms.Button();
            this.btnnuevo = new System.Windows.Forms.Button();
            this.btnprocesar = new System.Windows.Forms.Button();
            this.dtgrid = new System.Windows.Forms.DataGridView();
            this.codart = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.txtcodigo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtprecio = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtarticulo = new System.Windows.Forms.TextBox();
            this.txtcliente = new System.Windows.Forms.TextBox();
            this.btnaddarticulo = new System.Windows.Forms.Button();
            this.txtcantidad = new System.Windows.Forms.TextBox();
            this.txtfecha = new System.Windows.Forms.TextBox();
            this.txtcanexi = new System.Windows.Forms.TextBox();
            this.btnaddcli = new System.Windows.Forms.Button();
            this.btnquitar = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtdevuelta = new System.Windows.Forms.TextBox();
            this.txtbalance = new System.Windows.Forms.TextBox();
            this.txttotal = new System.Windows.Forms.TextBox();
            this.txtpago = new System.Windows.Forms.TextBox();
            this.btnagregar = new System.Windows.Forms.Button();
            this.txtcodart = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrid)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnsalir);
            this.panel1.Controls.Add(this.btncancelar);
            this.panel1.Controls.Add(this.btnnuevo);
            this.panel1.Controls.Add(this.btnprocesar);
            this.panel1.Location = new System.Drawing.Point(723, 151);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(148, 292);
            this.panel1.TabIndex = 0;
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // btnsalir
            // 
            this.btnsalir.Location = new System.Drawing.Point(24, 206);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(102, 45);
            this.btnsalir.TabIndex = 3;
            this.btnsalir.Text = "Salir";
            this.btnsalir.UseVisualStyleBackColor = true;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // btncancelar
            // 
            this.btncancelar.Location = new System.Drawing.Point(24, 140);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(102, 45);
            this.btncancelar.TabIndex = 3;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // btnnuevo
            // 
            this.btnnuevo.Location = new System.Drawing.Point(24, 78);
            this.btnnuevo.Name = "btnnuevo";
            this.btnnuevo.Size = new System.Drawing.Size(102, 45);
            this.btnnuevo.TabIndex = 3;
            this.btnnuevo.Text = "Nuevo";
            this.btnnuevo.UseVisualStyleBackColor = true;
            this.btnnuevo.Click += new System.EventHandler(this.btnnuevo_Click);
            // 
            // btnprocesar
            // 
            this.btnprocesar.Location = new System.Drawing.Point(24, 14);
            this.btnprocesar.Name = "btnprocesar";
            this.btnprocesar.Size = new System.Drawing.Size(102, 45);
            this.btnprocesar.TabIndex = 3;
            this.btnprocesar.Text = "Procesar";
            this.btnprocesar.UseVisualStyleBackColor = true;
            this.btnprocesar.Click += new System.EventHandler(this.btnprocesar_Click);
            // 
            // dtgrid
            // 
            this.dtgrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codart,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dtgrid.Location = new System.Drawing.Point(6, 151);
            this.dtgrid.Name = "dtgrid";
            this.dtgrid.Size = new System.Drawing.Size(682, 292);
            this.dtgrid.TabIndex = 1;
            this.dtgrid.MouseMove += new System.Windows.Forms.MouseEventHandler(this.dtgrid_MouseMove);
            // 
            // codart
            // 
            this.codart.HeaderText = "Codigo";
            this.codart.Name = "codart";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Articulo";
            this.Column2.Name = "Column2";
            this.Column2.Width = 240;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Cantidad";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Precio/Unidad";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Importe";
            this.Column5.Name = "Column5";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "NO:. ";
            // 
            // txtcodigo
            // 
            this.txtcodigo.Location = new System.Drawing.Point(81, 6);
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.ReadOnly = true;
            this.txtcodigo.Size = new System.Drawing.Size(86, 20);
            this.txtcodigo.TabIndex = 4;
            this.txtcodigo.TextChanged += new System.EventHandler(this.txtcodigo_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(198, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Fecha";
            // 
            // txtprecio
            // 
            this.txtprecio.Location = new System.Drawing.Point(512, 127);
            this.txtprecio.Name = "txtprecio";
            this.txtprecio.ReadOnly = true;
            this.txtprecio.Size = new System.Drawing.Size(94, 20);
            this.txtprecio.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Cliente";
            // 
            // txtarticulo
            // 
            this.txtarticulo.Location = new System.Drawing.Point(173, 127);
            this.txtarticulo.Name = "txtarticulo";
            this.txtarticulo.ReadOnly = true;
            this.txtarticulo.Size = new System.Drawing.Size(235, 20);
            this.txtarticulo.TabIndex = 4;
            // 
            // txtcliente
            // 
            this.txtcliente.Location = new System.Drawing.Point(81, 50);
            this.txtcliente.Name = "txtcliente";
            this.txtcliente.ReadOnly = true;
            this.txtcliente.Size = new System.Drawing.Size(246, 20);
            this.txtcliente.TabIndex = 4;
            // 
            // btnaddarticulo
            // 
            this.btnaddarticulo.Location = new System.Drawing.Point(6, 125);
            this.btnaddarticulo.Name = "btnaddarticulo";
            this.btnaddarticulo.Size = new System.Drawing.Size(39, 23);
            this.btnaddarticulo.TabIndex = 3;
            this.btnaddarticulo.Text = "+";
            this.btnaddarticulo.UseVisualStyleBackColor = true;
            this.btnaddarticulo.Click += new System.EventHandler(this.btnaddarticulo_Click);
            // 
            // txtcantidad
            // 
            this.txtcantidad.Location = new System.Drawing.Point(414, 127);
            this.txtcantidad.Name = "txtcantidad";
            this.txtcantidad.Size = new System.Drawing.Size(92, 20);
            this.txtcantidad.TabIndex = 4;
            // 
            // txtfecha
            // 
            this.txtfecha.Location = new System.Drawing.Point(239, 9);
            this.txtfecha.Name = "txtfecha";
            this.txtfecha.ReadOnly = true;
            this.txtfecha.Size = new System.Drawing.Size(185, 20);
            this.txtfecha.TabIndex = 4;
            // 
            // txtcanexi
            // 
            this.txtcanexi.Location = new System.Drawing.Point(612, 127);
            this.txtcanexi.Name = "txtcanexi";
            this.txtcanexi.ReadOnly = true;
            this.txtcanexi.Size = new System.Drawing.Size(94, 20);
            this.txtcanexi.TabIndex = 4;
            // 
            // btnaddcli
            // 
            this.btnaddcli.Location = new System.Drawing.Point(333, 48);
            this.btnaddcli.Name = "btnaddcli";
            this.btnaddcli.Size = new System.Drawing.Size(25, 23);
            this.btnaddcli.TabIndex = 3;
            this.btnaddcli.Text = "+";
            this.btnaddcli.UseVisualStyleBackColor = true;
            this.btnaddcli.Click += new System.EventHandler(this.btnaddcli_Click);
            // 
            // btnquitar
            // 
            this.btnquitar.Location = new System.Drawing.Point(796, 124);
            this.btnquitar.Name = "btnquitar";
            this.btnquitar.Size = new System.Drawing.Size(75, 23);
            this.btnquitar.TabIndex = 3;
            this.btnquitar.Text = "Quitar";
            this.btnquitar.UseVisualStyleBackColor = true;
            this.btnquitar.Click += new System.EventHandler(this.btnquitar_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txtdevuelta);
            this.panel2.Controls.Add(this.txtbalance);
            this.panel2.Controls.Add(this.txttotal);
            this.panel2.Controls.Add(this.txtpago);
            this.panel2.Location = new System.Drawing.Point(532, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(339, 112);
            this.panel2.TabIndex = 5;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            this.panel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseMove);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(33, 89);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(56, 13);
            this.label11.TabIndex = 2;
            this.label11.Text = "Devuelta: ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(33, 63);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "Balance: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(48, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Total: ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(276, 89);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(29, 13);
            this.label10.TabIndex = 2;
            this.label10.Text = "RD$";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(276, 63);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "RD$";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(276, 31);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "RD$";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(276, 8);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "RD$";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Pago: ";
            // 
            // txtdevuelta
            // 
            this.txtdevuelta.Location = new System.Drawing.Point(94, 86);
            this.txtdevuelta.Name = "txtdevuelta";
            this.txtdevuelta.ReadOnly = true;
            this.txtdevuelta.Size = new System.Drawing.Size(176, 20);
            this.txtdevuelta.TabIndex = 4;
            this.txtdevuelta.Text = "0.0";
            this.txtdevuelta.TextChanged += new System.EventHandler(this.txtdevuelta_TextChanged);
            // 
            // txtbalance
            // 
            this.txtbalance.Location = new System.Drawing.Point(94, 60);
            this.txtbalance.Name = "txtbalance";
            this.txtbalance.ReadOnly = true;
            this.txtbalance.Size = new System.Drawing.Size(176, 20);
            this.txtbalance.TabIndex = 4;
            this.txtbalance.Text = "0.0";
            this.txtbalance.TextChanged += new System.EventHandler(this.txtbalance_TextChanged);
            // 
            // txttotal
            // 
            this.txttotal.Location = new System.Drawing.Point(94, 30);
            this.txttotal.Name = "txttotal";
            this.txttotal.ReadOnly = true;
            this.txttotal.Size = new System.Drawing.Size(176, 20);
            this.txttotal.TabIndex = 4;
            this.txttotal.Text = "0.0";
            // 
            // txtpago
            // 
            this.txtpago.Location = new System.Drawing.Point(94, 5);
            this.txtpago.Name = "txtpago";
            this.txtpago.Size = new System.Drawing.Size(176, 20);
            this.txtpago.TabIndex = 4;
            this.txtpago.TextChanged += new System.EventHandler(this.txtpago_TextChanged);
            // 
            // btnagregar
            // 
            this.btnagregar.Location = new System.Drawing.Point(715, 125);
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.Size = new System.Drawing.Size(75, 23);
            this.btnagregar.TabIndex = 3;
            this.btnagregar.Text = "Agregar";
            this.btnagregar.UseVisualStyleBackColor = true;
            this.btnagregar.Click += new System.EventHandler(this.btnagregar_Click);
            // 
            // txtcodart
            // 
            this.txtcodart.Location = new System.Drawing.Point(67, 126);
            this.txtcodart.Name = "txtcodart";
            this.txtcodart.Size = new System.Drawing.Size(100, 20);
            this.txtcodart.TabIndex = 6;
            // 
            // Factura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 469);
            this.Controls.Add(this.txtcodart);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.txtcliente);
            this.Controls.Add(this.txtarticulo);
            this.Controls.Add(this.txtcantidad);
            this.Controls.Add(this.txtfecha);
            this.Controls.Add(this.txtcanexi);
            this.Controls.Add(this.txtprecio);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtcodigo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnaddarticulo);
            this.Controls.Add(this.btnaddcli);
            this.Controls.Add(this.btnagregar);
            this.Controls.Add(this.btnquitar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtgrid);
            this.Controls.Add(this.panel1);
            this.Name = "Factura";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Factura";
            this.Load += new System.EventHandler(this.Factura_Load);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Factura_MouseMove);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgrid)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dtgrid;
        private System.Windows.Forms.Button btnsalir;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.Button btnnuevo;
        private System.Windows.Forms.Button btnprocesar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtcodigo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtprecio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtarticulo;
        private System.Windows.Forms.TextBox txtcliente;
        private System.Windows.Forms.Button btnaddarticulo;
        private System.Windows.Forms.TextBox txtcantidad;
        private System.Windows.Forms.TextBox txtfecha;
        private System.Windows.Forms.TextBox txtcanexi;
        private System.Windows.Forms.Button btnaddcli;
        private System.Windows.Forms.Button btnquitar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txttotal;
        private System.Windows.Forms.TextBox txtpago;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtbalance;
        private System.Windows.Forms.Button btnagregar;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtdevuelta;
        private System.Windows.Forms.DataGridViewTextBoxColumn codart;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.TextBox txtcodart;
    }
}