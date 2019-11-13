namespace Supermercado.Consultas
{
    partial class Dpartamentos
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
            this.btnselect = new System.Windows.Forms.Button();
            this.txtbuscar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtgrid = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrid)).BeginInit();
            this.SuspendLayout();
            // 
            // btnselect
            // 
            this.btnselect.Location = new System.Drawing.Point(338, 12);
            this.btnselect.Name = "btnselect";
            this.btnselect.Size = new System.Drawing.Size(138, 37);
            this.btnselect.TabIndex = 37;
            this.btnselect.Text = "Seleccionar";
            this.btnselect.UseVisualStyleBackColor = true;
            this.btnselect.Click += new System.EventHandler(this.btnselect_Click);
            // 
            // txtbuscar
            // 
            this.txtbuscar.Location = new System.Drawing.Point(76, 21);
            this.txtbuscar.Name = "txtbuscar";
            this.txtbuscar.Size = new System.Drawing.Size(235, 20);
            this.txtbuscar.TabIndex = 36;
            this.txtbuscar.TextChanged += new System.EventHandler(this.txtbuscar_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 35;
            this.label1.Text = "Busqueda";
            // 
            // dtgrid
            // 
            this.dtgrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dtgrid.Location = new System.Drawing.Point(12, 85);
            this.dtgrid.Name = "dtgrid";
            this.dtgrid.ReadOnly = true;
            this.dtgrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgrid.Size = new System.Drawing.Size(479, 241);
            this.dtgrid.TabIndex = 38;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Codigo";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Nombre";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 200;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Estado";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Dpartamentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 337);
            this.Controls.Add(this.dtgrid);
            this.Controls.Add(this.btnselect);
            this.Controls.Add(this.txtbuscar);
            this.Controls.Add(this.label1);
            this.Name = "Dpartamentos";
            this.Text = "Dpartamentos";
            this.Load += new System.EventHandler(this.Dpartamentos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnselect;
        private System.Windows.Forms.TextBox txtbuscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtgrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}