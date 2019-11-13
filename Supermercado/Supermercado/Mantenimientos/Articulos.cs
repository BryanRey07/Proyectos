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
    public partial class Articulos : Form
    {
        Utilidades db = new Utilidades();
        public Articulos()
        {
            InitializeComponent();
        }

        //---------------metod ki ranpli datagrid la-------------------------

        private void LLenarGrid()
        {
            dtgrid.Rows.Clear();
            String lestado = "";
            String query = @"select a.codart,a.nomart,a.canexi,d.nomdep,s.nomsup,a.preven,a.status from articulos a
             left join departamientos d on d.coddep=a.coddep left join suplidor s on s.codsup=a.codsup";
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
                dtgrid.Rows.Add(db.VarReader["codart"].ToString(), db.VarReader["nomart"].ToString(),
                    db.VarReader["canexi"].ToString(), db.VarReader["nomdep"].ToString(),
                    db.VarReader["nomsup"].ToString(), db.VarReader["preven"].ToString(), lestado);
            }
        }
        //------------------------fin-----------------------------------------
        private void LLenarCombo() {
            txtdep.Items.Clear();
            String query = "select nomdep from departamientos order by nomdep asc";
            db.BuscarDatos(query);
            while (db.VarReader.Read()) {
                txtdep.Items.Add(db.VarReader["nomdep"].ToString());
            }
        }
        private void Articulos_Load(object sender, EventArgs e)
        {
            btnnuevo.PerformClick(); 
            LLenarCombo();
            LLenarGrid();
        }

        private void txtdep_MouseClick(object sender, MouseEventArgs e)
        {
            LLenarCombo();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            Mantenimientos.Departamentos md = new Departamentos();
            md.ShowDialog();
        }

        private void btnadd1_Click(object sender, EventArgs e)
        {
            Utilidades.Seleccionado2 = "";
            Consultas.Suplidores cs = new Consultas.Suplidores();
            cs.ShowDialog();
            txtsuplidor.Text = Utilidades.Seleccionado2;
        }

        private void btnnuevo_Click(object sender, EventArgs e)
        {
            txtcodigo.Text = db.MayorCodigo("codart", "articulos");
            if (txtcodigo.Text.Trim() == "")
            {
                txtcodigo.Text = "1";
            }
            txtnombre.Focus();
            txtnombre.Text = "";
            txtcanexi.Text = "";
            txtsuplidor.Text = "";
            txtdep.Items.Clear();
            txtpreven.Text = "";
            estado.Checked = false;
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            int codep = db.BuscarCodigo("coddep","nomdep",txtdep.Text,"departamientos");
            int codsp = db.BuscarCodigo("codsup", "nomsup", txtsuplidor.Text, "suplidor");
            string lestado = "";
            if (estado.Checked == true)
            {
                lestado = "true";
            }
            else
            {
                lestado = "false";
            }
            String query = @"if not exists (select codart from articulos where codart=" + txtcodigo.Text + @")
            insert into articulos(codart,nomart,canexi,coddep,codsup,preven,status) values(" + txtcodigo.Text + ",'" + txtnombre.Text + @"',
             '" + txtcanexi.Text + "'," + codep + "," + codsp + ",'"+txtpreven.Text+"','" + lestado + @"')
            else
            Update articulos set nomart='" + txtnombre.Text + "',canexi='" + txtcanexi.Text + "',coddep=" + codep + ",codsup=" + codsp + ",preven='"+txtpreven.Text+"',status='" + lestado + @"'
             where codart=" + txtcodigo.Text.Trim() + "";
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
            LLenarCombo();
            string lestado = "";
            txtcodigo.Text = dtgrid.CurrentRow.Cells[0].Value.ToString();
            txtnombre.Text = dtgrid.CurrentRow.Cells[1].Value.ToString();
            txtcanexi.Text = dtgrid.CurrentRow.Cells[2].Value.ToString();
            txtdep.Text = dtgrid.CurrentRow.Cells[3].Value.ToString();
            txtsuplidor.Text = dtgrid.CurrentRow.Cells[4].Value.ToString();
            txtpreven.Text = dtgrid.CurrentRow.Cells[5].Value.ToString();
            lestado = dtgrid.CurrentRow.Cells[6].Value.ToString();
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
                String query = "delete articulos where codart=" + par;
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
