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
    public partial class Splash : Form
    {
        public Splash()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Value = progressBar1.Value + 1;
            label1.Text = (Convert.ToInt32(label1.Text) + 1).ToString();
            progressBar1.Style = ProgressBarStyle.Continuous;
            if (Convert.ToInt32(progressBar1.Value) == 100)
            {
                timer1.Stop();
                timer1.Enabled = false;
                this.Hide();
                Inicio.Login form2 = new Inicio.Login();
                form2.Show();
            }
        }

        private void Splash_Load(object sender, EventArgs e)
        {
            label1.Visible = false;
            timer1.Start();
        }
    }
}
