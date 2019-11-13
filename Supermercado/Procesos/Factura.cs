using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
//using Microsoft.Reporting.WinForms;


namespace Supermercado.Procesos
{
    public partial class Factura : Form
    {
        Utilidades db = new Utilidades();
        public Factura()
        {
            InitializeComponent();
        }

        private void Insertfactura() {
            string cod = db.BuscarCodigo("codcli","nomcli",txtcliente.Text,"clientes").ToString();
            String query = @"insert into facturas(numfac,fecfac,codcli,status,monto)
            values("+txtcodigo.Text+",'"+txtfecha.Text+"',"+cod+",'True','"+txttotal.Text+"')";
            db.ManipularDB(query);
        }
        private void InsertDetalle()
        {

            for (int i = 0; i < dtgrid.RowCount-1; i++)
            {
                int aa = db.BuscarCodigo("codart", "nomart", dtgrid.Rows[i].Cells[0].Value.ToString().Trim(), "articulos");
                String query = "insert into detalles values(" + txtcodigo.Text + "," + aa + @"
,'" + dtgrid.Rows[i].Cells[1].Value.ToString() + "','" + dtgrid.Rows[i].Cells[2].Value.ToString() + @"')";
                db.ManipularDB(query);
               
            }
        }
        
        private void Imprimir() {
            string query = "select * from Vista_factura where numfac="+txtcodigo.Text+"";
            DataSet ds = Utilidades.ejecuta(query);
            Reportes.Facturas md = new Reportes.Facturas();
            ReportDataSource ej = new ReportDataSource("DataSet1", ds.Tables[0]);
            md.reportViewer1.LocalReport.DataSources.Clear();
            md.reportViewer1.LocalReport.DataSources.Add(ej);
            md.reportViewer1.RefreshReport();
            md.ShowDialog();
            md.reportViewer1.Reset();
        
        }
        private void SumarImporte() {
            Double suma = 0;
            for (int i = 0; i < dtgrid.RowCount-1; i++) { 
            suma=suma + Convert.ToDouble(dtgrid.Rows[i].Cells[3].Value.ToString());
            }
            txttotal.Text = suma.ToString();
            txtbalance.Text ="-"+suma.ToString();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnaddcli_Click(object sender, EventArgs e)
        {
            Utilidades.Seleccionado2 = "";
            Consultas.Clientes cc = new Consultas.Clientes();
            cc.ShowDialog();
            txtcliente.Text = Utilidades.Seleccionado2;
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Esta seguro que desea salir de este formulario?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnnuevo_Click(object sender, EventArgs e)
        {
            txtcodigo.Text = db.MayorCodigo("numfac", "facturas");
            if (txtcodigo.Text.Trim() == "")
            {
                txtcodigo.Text = "1";
            }
            txtfecha.Text = DateTime.Now.ToString();
            txtcliente.Text = "";
            txtpago.Text = "";
            txttotal.Text = "0.0";
            dtgrid.Rows.Clear();
            txtbalance.Text = "0.0";
            txtdevuelta.Text = "0.0";
        }

        private void Factura_MouseMove(object sender, MouseEventArgs e)
        {
            txtfecha.Text = DateTime.Now.ToString();
        }

        private void dtgrid_MouseMove(object sender, MouseEventArgs e)
        {
            txtfecha.Text = DateTime.Now.ToString();
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            txtfecha.Text = DateTime.Now.ToString();
        }

        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            txtfecha.Text = DateTime.Now.ToString();
        }

        private void btnaddarticulo_Click(object sender, EventArgs e)
        {
            Utilidades.Seleccionado2 = "";
            Utilidades.Seleccionado3 = "";
            Utilidades.Seleccionado4 = "";
            Utilidades.Seleccionado14 = "";
            Consultas.Articulos ca = new Consultas.Articulos();
            ca.ShowDialog();
            txtarticulo.Text = Utilidades.Seleccionado2;
            txtprecio.Text = Utilidades.Seleccionado3;
            txtcanexi.Text = Utilidades.Seleccionado4;
            txtcodart.Text = Utilidades.Seleccionado14;
        }

        private void Factura_Load(object sender, EventArgs e)
        {
            btnnuevo.PerformClick();
            
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            if (txtarticulo.Text == "" || txtcanexi.Text == "" || txtcantidad.Text == "" || txtprecio.Text == "")
            {
                MessageBox.Show("No debe haber campo vacio.");
            }
            else {
                Double impor = 0;
                impor = Convert.ToDouble(txtcantidad.Text) * Convert.ToDouble(txtprecio.Text);
                String imp = Convert.ToString(impor);
                dtgrid.Rows.Add(txtcodart.Text,txtarticulo.Text, txtcantidad.Text, txtprecio.Text,imp);
                SumarImporte();
                txtarticulo.Text = "";
                txtcanexi.Text = "";
                txtcantidad.Text = "";
                txtprecio.Text = "";
            }
        }

        

        private void txtpago_TextChanged(object sender, EventArgs e)
        {
            Double bal = 0;
            int aa = 0;
            int bb = 0;
            if (txtpago.Text.Trim() == "")
            {
                SumarImporte();
            }
            if (txtpago.Text.Trim() != "")
            {
                aa = Convert.ToInt16(txtpago.Text);
                bb = Convert.ToInt16(txttotal.Text);
                if (aa >= bb)
                {
                    bal = Convert.ToDouble(txtpago.Text) - Convert.ToDouble(txttotal.Text);
                    txtbalance.Text = "0.0";
                    txtdevuelta.Text = bal.ToString();
                }
                else if (aa < bb)
                {
                    bal = Convert.ToDouble(txtpago.Text) - Convert.ToDouble(txttotal.Text);
                    txtdevuelta.Text = "0.0";
                    txtbalance.Text = bal.ToString();
                }

            }
        }
       

        private void btnquitar_Click(object sender, EventArgs e)
        {
            try
            {
                dtgrid.Rows.RemoveAt(dtgrid.CurrentRow.Index);
                SumarImporte();
            }
            catch (Exception) {
                MessageBox.Show("Deberia seleccionar una fila en la tabla.");
            }
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            btnnuevo.PerformClick();
        }

        private void btnprocesar_Click(object sender, EventArgs e)
        {
           for (int i = 0; i < dtgrid.Rows.Count; i++)
            {

                string cmd = string.Format("EXEC actdetalles '{0}','{1}','{2}','{3}'", txtcodigo.Text, dtgrid.Rows[i].Cells[0].Value.ToString(),
                    dtgrid.Rows[i].Cells[2].Value.ToString(), dtgrid.Rows[i].Cells[3].Value.ToString());
                //MessageBox.Show(cmd);
                Utilidades.Ejecutar1(cmd);

            }


            Insertfactura();
            InsertDetalle();
            Imprimir();
            btnnuevo.PerformClick();


        }

        private void txtcodigo_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtbalance_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtdevuelta_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
