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
    public partial class Menu : Form
    {
        public Menu()
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

        private void Menu_Load(object sender, EventArgs e)
        {
            label2.Text = Utilidades.Seleccionado1;
        }

        private void departamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Mantenimientos.Departamentos mn = new Mantenimientos.Departamentos();
            mn.ShowDialog();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Mantenimientos.Clientes mn = new Mantenimientos.Clientes();
            mn.ShowDialog();
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Mantenimientos.Usuarios mn = new Mantenimientos.Usuarios();
            mn.ShowDialog();
        }

        private void suplidoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Mantenimientos.Suplidores mn = new Mantenimientos.Suplidores();
            mn.ShowDialog();
        }

        private void atriculosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Mantenimientos.Articulos mn = new Mantenimientos.Articulos();
            mn.ShowDialog();
        }

        private void suplidoresToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Consultas.Suplidores mn = new Consultas.Suplidores();
            mn.ShowDialog();
        }

        private void aRTICULOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
           Consultas.Articulos mn = new Consultas.Articulos();
            mn.ShowDialog();
        }

        private void cLIENTESToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Consultas.Clientes mn = new Consultas.Clientes();
            mn.ShowDialog();
        }

        private void dEPARTAMENTOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Consultas.Dpartamentos mn = new Consultas.Dpartamentos();
            mn.ShowDialog();
        }

        private void uSUARIOSToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Consultas.Usuarios mn = new Consultas.Usuarios();
            mn.ShowDialog();
        }

        private void fORMAGENERALToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reportes.PrincipalReporte rp = new Reportes.PrincipalReporte();
            rp.ShowDialog();
        }

        private void facturasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Procesos.Factura pf = new Procesos.Factura();
            pf.ShowDialog();
        }
    }
}
