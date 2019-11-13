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
    public partial class Menu3 : Form
    {
        public Menu3()
        {
            InitializeComponent();
        }

        private void Menu3_Load(object sender, EventArgs e)
        {
           label2.Text = Utilidades.Seleccionado1;
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

        private void ventaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Procesos.Factura pf = new Procesos.Factura();
            pf.ShowDialog();
        }
    }
}
