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
    public partial class Departamentos : Form
    {
        Utilidades db = new Utilidades();
        public Departamentos()
        {
            InitializeComponent();
        }
        //---------------metod ki ranpli datagrid la-------------------------

        private void LLenarGrid() {
            dtgrid.Rows.Clear();
            String lestado = "";
            String query = "select coddep,nomdep,status from Departamientos";
            db.BuscarDatos(query);
            while (db.VarReader.Read()) {
                String val = db.VarReader["status"].ToString();
                if (val == "True")
                {
                    lestado = "Activado";
                }else{
                    lestado = "Desactivado";
                }
                dtgrid.Rows.Add(db.VarReader["coddep"].ToString(), db.VarReader["nomdep"].ToString(),lestado);
            }
        }
        //------------------------fin-----------------------------------------
        private void btnnuevo_Click(object sender, EventArgs e)
        {
            txtcodigo.Text = db.MayorCodigo("coddep","Departamientos");
            if (txtcodigo.Text.Trim() == "")
            {
                txtcodigo.Text = "1";
            }
            txtnombre.Focus();
            txtnombre.Text = "";
            estado.Checked = false;
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Esta seguro que desea cerrar esta ventana?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                Close();
            }
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            string lestado = "";
            if (estado.Checked == true)
            {
                lestado = "true";
            }
            else {
                lestado = "false";            
            }
            String query = @"if not exists (select coddep from departamientos where coddep="+txtcodigo.Text+@")
            insert into Departamientos(coddep,nomdep,status) values("+txtcodigo.Text+",'"+txtnombre.Text+"','"+lestado+@"')
            else
            Update Departamientos set nomdep='"+txtnombre.Text+"',status='"+lestado+"' where coddep="+txtcodigo.Text.Trim()+"";
            db.ManipularDB(query);
            LLenarGrid();
            btnnuevo.PerformClick();
        }

        private void Departamentos_Load(object sender, EventArgs e)
        {
            btnnuevo.PerformClick();
            LLenarGrid();
        }

        private void dtgrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string lestado = "";
            txtcodigo.Text = dtgrid.CurrentRow.Cells[0].Value.ToString();
            txtnombre.Text = dtgrid.CurrentRow.Cells[1].Value.ToString();
            lestado =dtgrid.CurrentRow.Cells[2].Value.ToString();
            if (lestado == "Desactivado")
            {
                estado.Checked = false;
            }
            else {
                estado.Checked = true;
            }
        }

        private void btnborrar_Click(object sender, EventArgs e)
        {
            try
            {
                string par = dtgrid.CurrentRow.Cells[0].Value.ToString();
                String query = "delete Departamientos where coddep=" + par;
                db.ManipularDB(query);
                LLenarGrid();
                btnnuevo.PerformClick();
            }
            catch (Exception ) {
                MessageBox.Show("Por favor seleccione una fila en la tabla", "Notificacion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
