using Microsoft.Reporting.WinForms;
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
    public partial class Departamentos : Form
    {
        public Departamentos()
        {
            InitializeComponent();
        }

        private void Departamentos_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ExportReportTo(Environment.CurrentDirectory + "\\" + "ReporteDepartamentos" + ".pdf", "PDF");
            Form2 rf = new Form2();
            rf.ShowDialog();
        }

        private string ExportReportTo(string path, string type)
        {
            Warning[] warnings;
            string[] streamids;
            string mimeType;
            string encoding;
            string filenameExtension;
            byte[] bytes = reportViewer1.LocalReport.Render("PDF", null, out mimeType, out encoding, out filenameExtension, out streamids, out warnings);
            string filename = path;
            using (var fs = new System.IO.FileStream(filename, System.IO.FileMode.Create))
            {
                fs.Write(bytes, 0, bytes.Length);
                fs.Close();
            }
            return filename;
        }


    }
}
