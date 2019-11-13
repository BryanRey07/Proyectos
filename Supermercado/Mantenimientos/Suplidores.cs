using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Supermercado.Mantenimientos
{
    public partial class Suplidores : Form
    {
        Utilidades db = new Utilidades();
        public Suplidores()
        {
            InitializeComponent();
        }

        //---------------metod ki ranpli datagrid la-------------------------

        private void LLenarGrid()
        {
            dtgrid.Rows.Clear();
            String lestado = "";
            String query = "select codsup,nomsup,telsup,dirsup,status from suplidor";
            db.BuscarDatos(query);
            while (db.VarReader.Read())
            {
                String val = db.VarReader["status"].ToString();
                if (val == "True")
                {
                    lestado = "Activado";
                }
                else
                {
                    lestado = "Desactivado";
                }
                dtgrid.Rows.Add(db.VarReader["codsup"].ToString(), db.VarReader["nomsup"].ToString(),
                    db.VarReader["Telsup"].ToString(), db.VarReader["Dirsup"].ToString(), lestado);
            }
        }
        //------------------------fin-----------------------------------------
        private void Suplidores_Load(object sender, EventArgs e)
        {
            btnnuevo.PerformClick();
            LLenarGrid();
        }

        private void btnnuevo_Click(object sender, EventArgs e)
        {
            txtcodigo.Text = db.MayorCodigo("codsup", "suplidor");
            if (txtcodigo.Text.Trim() == "")
            {
                txtcodigo.Text = "1";
            }
            txtnombre.Focus();
            txtnombre.Text = "";
            txtdireccion.Text = "";
            txttelefono.Text = "";
            estado.Checked = false;
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            string lestado = "";
            if (estado.Checked == true)
            {
                lestado = "true";
            }
            else
            {
                lestado = "false";
            }
            String query = @"if not exists (select codsup from suplidor where codsup=" + txtcodigo.Text + @")
            insert into suplidor(codsup,nomsup,telsup,dirsup,status) values(" + txtcodigo.Text + ",'" + txtnombre.Text + @"',
             '" + txttelefono.Text + "','" + txtdireccion.Text + "','" + lestado + @"')
            else
            Update suplidor set nomsup='" + txtnombre.Text + "',telsup='" + txttelefono.Text + "',dirsup='" + txtdireccion.Text + "',status='" + lestado + @"'
             where codsup=" + txtcodigo.Text.Trim() + "";
            db.ManipularDB(query);
            LLenarGrid();
            btnnuevo.PerformClick();
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Esta seguro que desea cerrar esta ventana?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                Close();
            }
        }

        private void dtgrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string lestado = "";
            txtcodigo.Text = dtgrid.CurrentRow.Cells[0].Value.ToString();
            txtnombre.Text = dtgrid.CurrentRow.Cells[1].Value.ToString();
            txttelefono.Text = dtgrid.CurrentRow.Cells[2].Value.ToString();
            txtdireccion.Text = dtgrid.CurrentRow.Cells[3].Value.ToString();
            lestado = dtgrid.CurrentRow.Cells[4].Value.ToString();
            if (lestado == "Desactivado")
            {
                estado.Checked = false;
            }
            else
            {
                estado.Checked = true;
            }
        }

        private void btnborrar_Click(object sender, EventArgs e)
        {
            try
            {
                string par = dtgrid.CurrentRow.Cells[0].Value.ToString();
                String query = "delete suplidor where codsup=" + par;
                db.ManipularDB(query);
                LLenarGrid();
                btnnuevo.PerformClick();
            }
            catch (Exception)
            {
                MessageBox.Show("Por favor seleccione una fila en la tabla", "Notificacion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
