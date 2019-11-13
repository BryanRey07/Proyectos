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
    public partial class Menu2 : Form
    {
        public Menu2()
        {
            InitializeComponent();
        }

        private void saliToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Esta seguro que desea deconectar?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                this.Hide();
                Inicio.Login lg = new Login();
                lg.ShowDialog();
            }
        }

        private void Menu2_Load(object sender, EventArgs e)
        {
            label2.Text = Utilidades.Seleccionado1;
        }

        private void articulosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Consultas.Articulos ca = new Consultas.Articulos();
            ca.ShowDialog();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Consultas.Clientes ca = new Consultas.Clientes();
            ca.ShowDialog();
        }

        private void suplidoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Consultas.Suplidores ca = new Consultas.Suplidores();
            ca.ShowDialog();
        }

        private void departamentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Consultas.Dpartamentos ca = new Consultas.Dpartamentos();
            ca.ShowDialog();
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Consultas.Usuarios ca = new Consultas.Usuarios();
            ca.ShowDialog();
        }

        private void formaPrincipalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reportes.PrincipalReporte rp =new  Reportes.PrincipalReporte();
            rp.ShowDialog();
        }

        private void bloquearToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
