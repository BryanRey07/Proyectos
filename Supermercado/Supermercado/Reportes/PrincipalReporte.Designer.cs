namespace Supermercado.Reportes
{
    partial class PrincipalReporte
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnimprimir = new System.Windows.Forms.Button();
            this.txtformato = new System.Windows.Forms.ComboBox();
            this.txtdesde = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtordenar = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txthasta = new System.Windows.Forms.TextBox();
            this.btnsalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Formato";
            // 
            // btnimprimir
            // 
            this.btnimprimir.Location = new System.Drawing.Point(100, 195);
            this.btnimprimir.Name = "btnimprimir";
            this.btnimprimir.Size = new System.Drawing.Size(113, 56);
            this.btnimprimir.TabIndex = 1;
            this.btnimprimir.Text = "Imprimir";
            this.btnimprimir.UseVisualStyleBackColor = true;
            this.btnimprimir.Click += new System.EventHandler(this.btnimprimir_Click);
            // 
            // txtformato
            // 
            this.txtformato.FormattingEnabled = true;
            this.txtformato.Items.AddRange(new object[] {
            "Articulos",
            "Clientes",
            "Departamentos",
            "Suplidores"});
            this.txtformato.Location = new System.Drawing.Point(82, 21);
            this.txtformato.Name = "txtformato";
            this.txtformato.Size = new System.Drawing.Size(194, 21);
            this.txtformato.TabIndex = 2;
            this.txtformato.SelectedIndexChanged += new System.EventHandler(this.formato_SelectedIndexChanged);
            // 
            // txtdesde
            // 
            this.txtdesde.Location = new System.Drawing.Point(82, 69);
            this.txtdesde.Name = "txtdesde";
            this.txtdesde.Size = new System.Drawing.Size(100, 20);
            this.txtdesde.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ordenar";
            // 
            // txtordenar
            // 
            this.txtordenar.FormattingEnabled = true;
            this.txtordenar.Location = new System.Drawing.Point(82, 127);
            this.txtordenar.Name = "txtordenar";
            this.txtordenar.Size = new System.Drawing.Size(194, 21);
            this.txtordenar.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Desde";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(241, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Hasta";
            // 
            // txthasta
            // 
            this.txthasta.Location = new System.Drawing.Point(282, 70);
            this.txthasta.Name = "txthasta";
            this.txthasta.Size = new System.Drawing.Size(100, 20);
            this.txthasta.TabIndex = 3;
            // 
            // btnsalir
            // 
            this.btnsalir.Location = new System.Drawing.Point(244, 195);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(113, 56);
            this.btnsalir.TabIndex = 1;
            this.btnsalir.Text = "Salir";
            this.btnsalir.UseVisualStyleBackColor = true;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // PrincipalReporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 295);
            this.Controls.Add(this.txthasta);
            this.Controls.Add(this.txtdesde);
            this.Controls.Add(this.txtordenar);
            this.Controls.Add(this.txtformato);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.btnimprimir);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "PrincipalReporte";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reporte Principal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnimprimir;
        private System.Windows.Forms.ComboBox txtformato;
        private System.Windows.Forms.TextBox txtdesde;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox txtordenar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txthasta;
        private System.Windows.Forms.Button btnsalir;
    }
}