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
    public partial class Clientes : Form
    {
        Utilidades db = new Utilidades();
        public Clientes()
        {
            InitializeComponent();
        }

        //---------------metod ki ranpli datagrid la-------------------------

        private void LLenarGrid()
        {
            dtgrid.Rows.Clear();
            String lestado = "";
            String query = "select codcli,nomcli,telcli,dircli,status from Clientes";
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
                dtgrid.Rows.Add(db.VarReader["codcli"].ToString(), db.VarReader["nomcli"].ToString(),
                    db.VarReader["Telcli"].ToString(), db.VarReader["Dircli"].ToString(), lestado);
            }
        }
        //------------------------fin-----------------------------------------
        private void Clientes_Load(object sender, EventArgs e)
        {
            LLenarGrid();
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

        private void txtbuscar_TextChanged(object sender, EventArgs e)
        {
            dtgrid.Rows.Clear();
            String lestado = "";
            String query = "select codcli,nomcli,telcli,dircli,status from Clientes where nomcli like '%"+txtbuscar.Text.Trim()+@"%'
            or telcli like '%" + txtbuscar.Text.Trim() + "%' or dircli like '%" + txtbuscar.Text.Trim() + "%' or status like '%" + txtbuscar.Text.Trim() + "%'";
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
                dtgrid.Rows.Add(db.VarReader["codcli"].ToString(), db.VarReader["nomcli"].ToString(),
                    db.VarReader["Telcli"].ToString(), db.VarReader["Dircli"].ToString(), lestado);
            }
        }
    }
}
