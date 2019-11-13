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
    public partial class Usuarios : Form
    {
        Utilidades db = new Utilidades();
        public Usuarios()
        {
            InitializeComponent();
        }

        private void LLenarGrid()
        {
            dtgrid.Rows.Clear();
            String lestado = "";
            String query = "select codusu,nomusu,nivel from usuarios";
            db.BuscarDatos(query);
            while (db.VarReader.Read())
            {
                String val = db.VarReader["nivel"].ToString();
                if (val == "3")
                {
                    lestado = "Administrador";
                }
                if (val == "2")
                {
                    lestado = "Supervisor";
                }
                else if (val == "1")
                {
                    lestado = "Vendedor";
                }
                dtgrid.Rows.Add(db.VarReader["codusu"].ToString(), db.VarReader["nomusu"].ToString(), lestado);
            }
        }
        //------------------------fin-----------------------------------------
        private void Usuarios_Load(object sender, EventArgs e)
        {
            LLenarGrid();
        }

        private void btnselect_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide();
                Utilidades.Seleccionado2 = dtgrid.CurrentRow.Cells[0].Value.ToString();

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
            String lestados = "";
            if (txtbuscar.Text == " ")
            {
                LLenarGrid();
            }
            else if (txtbuscar.Text == "Administrador") {
                lestados = "3";
            }
            else if (txtbuscar.Text == "Supervisor")
            {
                lestados = "2";
            }
            else if (txtbuscar.Text == "Vendedor")
            {
                lestados = "1";
            }
            String query = "select codusu,nomusu,nivel from usuarios where nomusu like '" + txtbuscar.Text + "' or nivel like '" + lestados + "' ";
            db.BuscarDatos(query);
            while (db.VarReader.Read())
            {
                String val = db.VarReader["nivel"].ToString();
                if (val == "3")
                {
                    lestado = "Administrador";
                }
                if (val == "2")
                {
                    lestado = "Supervisor";
                }
                else if (val == "1")
                {
                    lestado = "Vendedor";
                }
                dtgrid.Rows.Add(db.VarReader["codusu"].ToString(), db.VarReader["nomusu"].ToString(), lestado);
            }
        }
    }
}
