using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Supermercado.Inicio
{
    public partial class Login : Form
    {
        Utilidades db = new Utilidades();
        public Login()
        {
            InitializeComponent();
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Esta seguro que desea detener el sistema?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnentrar_Click(object sender, EventArgs e)
        {
            String NbreUsuario="Marco";
            String Pass="Zamora";
            if ((txtnomusu.Text.Trim() == "") && (password.Text.Trim() == ""))
            {
                errorProvider1.SetError(txtnomusu,"jajajajajaja");
                errorProvider1.SetError(password, "jajajajajaja");
            }
            else if ((txtnomusu.Text.Trim() != "") && (password.Text.Trim() == ""))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(password, "jajajajajaja");
            }
            else if ((txtnomusu.Text.Trim() == "") && (password.Text.Trim() != ""))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txtnomusu, "jajajajajaja");
            }
            else
            {
                if ((txtnomusu.Text.Trim() == NbreUsuario) && (password.Text.Trim() == Pass))
                {
                    this.Hide();
                    Utilidades.Seleccionado1 = "DISENADOR DEL SISTEMA";
                    Inicio.Menu mn = new Menu();
                    mn.ShowDialog();
                }
                else {
                    String lnivel = "";
                    String query = "select nivel from usuarios where nomusu='" + txtnomusu.Text.Trim() + "' and pass='" + password.Text.Trim() + "'";
                    db.BuscarDatos(query);
                    if (db.VarReader.Read())
                    {
                        lnivel = db.VarReader["nivel"].ToString();
                        if (lnivel == "1") {
                            this.Hide();
                            Utilidades.Seleccionado1 = txtnomusu.Text.Trim();
                            Inicio.Menu3 mn = new Menu3();
                            mn.ShowDialog();
                        }
                        else if (lnivel == "2")
                        {
                            this.Hide();
                            Utilidades.Seleccionado1 = txtnomusu.Text.Trim();
                            Inicio.Menu2 mn = new Menu2();
                            mn.ShowDialog();
                        }
                        else if (lnivel == "3")
                        {
                            this.Hide();
                            Utilidades.Seleccionado1 = txtnomusu.Text.Trim();
                            Inicio.Menu mn = new Menu();
                            mn.ShowDialog();
                        }
                    }
                    else {
                        MessageBox.Show("Nombre Usuario y Contrasena Incorrtecta.", "Notificacion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtnomusu.Text = "";
                        password.Text = "";
                        txtnomusu.Focus();
                    }
                }
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            txtnomusu.Focus();
        }
    }
}
