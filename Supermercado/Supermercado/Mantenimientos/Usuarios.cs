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
    public partial class Usuarios : Form
    {
        Utilidades db = new Utilidades();
        public Usuarios()
        {
            InitializeComponent();
            
        }

        private void LLenarcampo() {
            String lestado = "";
            String query = "select codusu,nomusu,pass,nivel from usuarios where codusu='"+txtcodigo.Text+"' ";
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
               txtnombre.Text=db.VarReader["nomusu"].ToString();
               txtpassword.Text = db.VarReader["pass"].ToString();
               txtnivel.Text = lestado;
            }
        }

        private void btnnuevo_Click(object sender, EventArgs e)
        {
            txtcodigo.Text = db.MayorCodigo("codusu", "Usuarios");
            if (txtcodigo.Text.Trim() == "")
            {
                txtcodigo.Text = "1";
            }
            txtnombre.Focus();
            txtnombre.Text = "";
            txtpassword.Text = "";
            txtconfirmacion.Text = "";
            txtnivel.Text = "";
        }

        private void Usuarios_Load(object sender, EventArgs e)
        {
            btnnuevo.PerformClick();
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            String lnivel="";
            if (txtnivel.Text.Trim() == "Administrador") {
                lnivel = "3";
            }
            else if (txtnivel.Text.Trim() == "Supervisor")
            {
                lnivel = "2";
            }
            else if (txtnivel.Text.Trim() == "Vendedor")
            {
                lnivel = "1";
            }
            String query = @"if not exists (select codusu from Usuarios where codusu=" + txtcodigo.Text + @")
            insert into Usuarios(codusu,nomusu,pass,nivel) values(" + txtcodigo.Text + ",'" + txtnombre.Text + "','" + txtpassword.Text+ @"'
            ,"+lnivel+@")
            else
            Update Usuarios set nomusu='" + txtnombre.Text + "',pass='" + txtpassword.Text + "',nivel="+lnivel+"";
            //richTextBox1.Text = query;
            db.ManipularDB(query);
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

        private void txtconfirmacion_TextChanged(object sender, EventArgs e)
        {
            if (txtpassword.Text.Trim() != txtconfirmacion.Text.Trim())
            {

                errorProvider1.SetError(txtpassword, "La confirmacion no coincidecon lacontrasena.");
                errorProvider1.SetError(txtconfirmacion, "La confirmacion no coincidecon lacontrasena.");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void btnborrar_Click(object sender, EventArgs e)
        {
            try
            {
                String query = "delete Departamientos where coddep=" + txtcodigo.Text;
                db.ManipularDB(query);
                btnnuevo.PerformClick();
            }
            catch (Exception)
            {
                
            }
        }

        private void btncosulta_Click(object sender, EventArgs e)
        {
            Utilidades.Seleccionado2 = "";
            Consultas.Usuarios cu = new Consultas.Usuarios();
            cu.ShowDialog();
            txtcodigo.Text = Utilidades.Seleccionado2;
        }

        private void txtcodigo_TextChanged(object sender, EventArgs e)
        {
            LLenarcampo();
        }

    }
}
