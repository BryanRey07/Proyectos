using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Supermercado.Procesos
{


    public partial class Compras : Form
       
    {
        Utilidades db = new Utilidades();
        public Compras()
        {
            InitializeComponent();
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            if (txtarticulo.Text == "" || txtcodart.Text == "" || txtcantidad.Text == "" || txtprecio.Text == "")
            {
                MessageBox.Show("No debe haber campo vacio.");
            }
            else
            {

                Double impor = 0;
                impor = Convert.ToDouble(txtcantidad.Text) * Convert.ToDouble(txtprecio.Text);
                String imp = Convert.ToString(impor);
                dtgrid.Rows.Add(txtcodart.Text, txtarticulo.Text, txtcantidad.Text, txtprecio.Text, imp);
               // SumarImporte();
                txtarticulo.Text = "";
                txtcodart.Text = "";
                txtcantidad.Text = "";
                txtprecio.Text = "";
            }

        }

        private void Btnaddarticulo_Click(object sender, EventArgs e)
        {
        }

        private void Btnagregar_Click(object sender, EventArgs e)
        {
            



        }

        private void btnquitar_Click(object sender, EventArgs e)
        {
            try
            {
                dtgrid.Rows.RemoveAt(dtgrid.CurrentRow.Index);
                SumarImporte();
            }
            catch (Exception)
            {
                MessageBox.Show("Deberia seleccionar una fila en la tabla.");
            }
        }


        private void SumarImporte()
        {
            Double suma = 0;
            /**/
            for (int i = 0; i < dtgrid.RowCount; i++)
            {
                suma = suma + Convert.ToDouble(dtgrid.Rows[i].Cells[3].Value.ToString());
            }
            txttotal.Text = suma.ToString();
            txtbalance.Text = "-" + suma.ToString();
            float n = int.Parse(txtbalance.Text);
            if (n < 0)
            {
                txtbalance.BackColor = Color.Red;
            }
            else
            {
                txtbalance.BackColor = Color.Green;
            }
        }

        private void Btnprocesar_Click(object sender, EventArgs e)
        {
            

        }

        private void Compra_Load(object sender, EventArgs e)
        {
            btnnuevo.PerformClick();
        }

        private void Btnnuevo_Click(object sender, EventArgs e)
        {
          
        }

        private void Txtfecha_TextChanged(object sender, EventArgs e)
        {

        }

        private void Btnaddcli_Click(object sender, EventArgs e)
        {
           
        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Btncancelar_Click(object sender, EventArgs e)
        {
            btnnuevo.PerformClick();
        }

        private void txtcliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnnuevo_Click_1(object sender, EventArgs e)
        {
            txtcodigo.Text = db.MayorCodigo("numfac", "facturas");
            if (txtcodigo.Text.Trim() == "")
            {
                txtcodigo.Text = "1";
            }
            txtfecha.Text = DateTime.Now.ToString();
            txtsuplidor.Text = "";
            txtpago.Text = "";
            txttotal.Text = "0.0";
            dtgrid.Rows.Clear();
            txtbalance.Text = "0.0";
            txtdevuelta.Text = "0.0";
        }

        private void Compras_Load(object sender, EventArgs e)
        {
            btnnuevo.PerformClick();
        }

        private void btnaddcli_Click_1(object sender, EventArgs e)
        {
            Utilidades.Seleccionado2 = "";
            Consultas.Suplidores cc = new Consultas.Suplidores();
            cc.ShowDialog();
            txtsuplidor.Text = Utilidades.Seleccionado2;
        }

        private void btnaddarticulo_Click_1(object sender, EventArgs e)
        {

            Utilidades.Seleccionado2 = "";
            Utilidades.Seleccionado3 = "";
            Utilidades.Seleccionado4 = "";
            Utilidades.Seleccionado14 = "";
            Consultas.Articulos ca = new Consultas.Articulos();
            ca.ShowDialog();
            txtarticulo.Text = Utilidades.Seleccionado2;
            txtprecio.Text = Utilidades.Seleccionado3;
            txtcodart.Text = Utilidades.Seleccionado4;
            txtcodart.Text = Utilidades.Seleccionado14;
        }

        private void btnprocesar_Click_1(object sender, EventArgs e)
        {
            for (int i = 0; i < dtgrid.Rows.Count; i++)
            {
                string cmd = string.Format("EXEC actinventario '{0}','{1}','{2}','{3}'", txtcodigo.Text, dtgrid.Rows[i].Cells[0].Value.ToString(),
                    dtgrid.Rows[i].Cells[2].Value.ToString(), dtgrid.Rows[i].Cells[3].Value.ToString());
                Utilidades.Ejecutar1(cmd);
                MessageBox.Show("COMPRA REALIZADA!");
            }

            btnnuevo.PerformClick();
        }

        private void btncancelar_Click_1(object sender, EventArgs e)
        {

        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtpago_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
