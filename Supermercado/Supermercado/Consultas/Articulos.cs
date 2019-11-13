using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Supermercado.Consultas
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
        private void Articulos_Load(object sender, EventArgs e)
        {
            LLenarGrid();
        }

        private void txtbuscar_TextChanged(object sender, EventArgs e)
        {
            dtgrid.Rows.Clear();
            String lestado = "";
            String query = @"select a.codart,a.nomart,a.canexi,d.nomdep,s.nomsup,a.preven,a.status from articulos a
             left join departamientos d on d.coddep=a.coddep left join suplidor s on s.codsup=a.codsup 
             where a.nomart like '%" + txtbuscar.Text.Trim() + "%' or s.nomsup like '%" + txtbuscar.Text.Trim() + @"%' or
             d.nomdep like '%"+txtbuscar.Text.Trim()+"%'";
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

        private void btnselect_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide();
                Utilidades.Seleccionado2 = dtgrid.CurrentRow.Cells[1].Value.ToString();
                Utilidades.Seleccionado3 = dtgrid.CurrentRow.Cells[5].Value.ToString();
                Utilidades.Seleccionado4 = dtgrid.CurrentRow.Cells[2].Value.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Por favor seleccione una fila en la tabla", "Notificacion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
