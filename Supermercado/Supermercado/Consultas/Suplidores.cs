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
    public partial class Suplidores : Form
    {
        Utilidades db = new Utilidades();
        public Suplidores()
        {
            InitializeComponent();
        }

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
        private void Suplidores_Load(object sender, EventArgs e)
        {
            LLenarGrid();
        }

        private void txtbuscar_TextChanged(object sender, EventArgs e)
        {
            dtgrid.Rows.Clear();
            String lestado = "";
            String query = @"select codsup,nomsup,telsup,dirsup,status from suplidor where nomsup 
            like '%" + txtbuscar.Text.Trim() + "%' or telsup like '%" + txtbuscar.Text.Trim() + @"%'
            or dirsup like '%" + txtbuscar.Text.Trim() + "%' or status like '%" + txtbuscar.Text.Trim() + "%'";
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

        private void btnselect_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide();
                Utilidades.Seleccionado2 = dtgrid.CurrentRow.Cells[1].Value.ToString();
                
            }
            catch (Exception)
            {
                MessageBox.Show("Por favor seleccione una fila en la tabla", "Notificacion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
