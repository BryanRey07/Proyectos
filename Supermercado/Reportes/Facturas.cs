using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Supermercado.Reportes
{
    public partial class Facturas : Form
    {
        public Facturas()
        {
            InitializeComponent();
        }

        private void Facturrraass_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }
    }
}
