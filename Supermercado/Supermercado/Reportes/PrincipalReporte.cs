using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace Supermercado.Reportes
{
    public partial class PrincipalReporte : Form
    {
        public PrincipalReporte()
        {
            InitializeComponent();
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Esta seguro que salir esta ventana?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void formato_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txtformato.Text == "Clientes") {
                txtordenar.Items.Clear();
                txtordenar.Items.Add("Codigo");
                txtordenar.Items.Add("Nombre");
            }
            if (txtformato.Text == "Suplidores")
            {
                txtordenar.Items.Clear();
                txtordenar.Items.Add("Codigo");
                txtordenar.Items.Add("Nombre");
            }
  
            if (txtformato.Text == "Departamentos")
            {
                txtordenar.Items.Clear();
                txtordenar.Items.Add("Codigo");
                txtordenar.Items.Add("Nombre");
            }
            if (txtformato.Text == "Articulos")
            {
                txtordenar.Items.Clear();
                txtordenar.Items.Add("Codigo");
                txtordenar.Items.Add("Nombre");
            }
        }

        private void btnimprimir_Click(object sender, EventArgs e)
        {
            String orders = "";
            String query = "";
            if ((txtformato.Text == "Clientes") && (txtordenar.Text == "Codigo")) {
                orders = "codcli";
                if (txtdesde.Text == "" && txthasta.Text == "")
                {
                    query = "select * from clientes order by '" + orders + "' asc";
                    DataSet ds = Utilidades.ejecuta(query);
                    Clientes md = new Clientes();
                    ReportDataSource ej = new ReportDataSource("DataSet1", ds.Tables[0]);
                    md.reportViewer1.LocalReport.DataSources.Clear();
                    md.reportViewer1.LocalReport.DataSources.Add(ej);
                    md.reportViewer1.RefreshReport();
                    md.ShowDialog();
                    md.reportViewer1.Reset();
                }
                else if (txtdesde.Text != "" && txthasta.Text == "")
                {
                    query = "select * from clientes  where codcli= " + txtdesde.Text + " order by '" + orders + "' asc";
                    DataSet ds = Utilidades.ejecuta(query);
                    Clientes md = new Clientes();
                    ReportDataSource ej = new ReportDataSource("DataSet1", ds.Tables[0]);
                    md.reportViewer1.LocalReport.DataSources.Clear();
                    md.reportViewer1.LocalReport.DataSources.Add(ej);
                    md.reportViewer1.RefreshReport();
                    md.ShowDialog();
                    md.reportViewer1.Reset();
                }
                else if (txtdesde.Text == "" && txthasta.Text != "")
                {
                    query = "select * from clientes where codcli= " + txthasta.Text + " order by '" + orders + "' asc";
                    DataSet ds = Utilidades.ejecuta(query);
                    Clientes md = new Clientes();
                    ReportDataSource ej = new ReportDataSource("DataSet1", ds.Tables[0]);
                    md.reportViewer1.LocalReport.DataSources.Clear();
                    md.reportViewer1.LocalReport.DataSources.Add(ej);
                    md.reportViewer1.RefreshReport();
                    md.ShowDialog();
                    md.reportViewer1.Reset();
                }
                else if (txtdesde.Text != "" && txthasta.Text != "")
                {
                    query = "select * from clientes where codcli between " + txtdesde.Text + " and " + txthasta.Text + " order by '" + orders + "' asc";
                    DataSet ds = Utilidades.ejecuta(query);
                    Clientes md = new Clientes();
                    ReportDataSource ej = new ReportDataSource("DataSet1", ds.Tables[0]);
                    md.reportViewer1.LocalReport.DataSources.Clear();
                    md.reportViewer1.LocalReport.DataSources.Add(ej);
                    md.reportViewer1.RefreshReport();
                    md.ShowDialog();
                    md.reportViewer1.Reset();
                }
            }
            else if ((txtformato.Text == "Clientes") && (txtordenar.Text == "Nombre"))
            {
                orders = "nomcli";
                if (txtdesde.Text == "" && txthasta.Text == "")
                {
                    query = "select * from clientes order by '" + orders + "' asc";
                    DataSet ds = Utilidades.ejecuta(query);
                    Clientes md = new Clientes();
                    ReportDataSource ej = new ReportDataSource("DataSet1", ds.Tables[0]);
                    md.reportViewer1.LocalReport.DataSources.Clear();
                    md.reportViewer1.LocalReport.DataSources.Add(ej);
                    md.reportViewer1.RefreshReport();
                    md.ShowDialog();
                    md.reportViewer1.Reset();
                }
                else if (txtdesde.Text != "" && txthasta.Text == "")
                {
                    query = "select * from clientes  where codcli= " + txtdesde.Text + " order by '" + orders + "' asc";
                    DataSet ds = Utilidades.ejecuta(query);
                    Clientes md = new Clientes();
                    ReportDataSource ej = new ReportDataSource("DataSet1", ds.Tables[0]);
                    md.reportViewer1.LocalReport.DataSources.Clear();
                    md.reportViewer1.LocalReport.DataSources.Add(ej);
                    md.reportViewer1.RefreshReport();
                    md.ShowDialog();
                    md.reportViewer1.Reset();
                }
                else if (txtdesde.Text == "" && txthasta.Text != "")
                {
                    query = "select * from clientes where codcli= " + txthasta.Text + " order by '" + orders + "' asc";
                    DataSet ds = Utilidades.ejecuta(query);
                    Clientes md = new Clientes();
                    ReportDataSource ej = new ReportDataSource("DataSet1", ds.Tables[0]);
                    md.reportViewer1.LocalReport.DataSources.Clear();
                    md.reportViewer1.LocalReport.DataSources.Add(ej);
                    md.reportViewer1.RefreshReport();
                    md.ShowDialog();
                    md.reportViewer1.Reset();
                }
                else if (txtdesde.Text != "" && txthasta.Text != "")
                {
                    query = "select * from clientes where codcli between " + txtdesde.Text + " and " + txthasta.Text + " order by '" + orders + "' asc";
                    DataSet ds = Utilidades.ejecuta(query);
                    Clientes md = new Clientes();
                    ReportDataSource ej = new ReportDataSource("DataSet1", ds.Tables[0]);
                    md.reportViewer1.LocalReport.DataSources.Clear();
                    md.reportViewer1.LocalReport.DataSources.Add(ej);
                    md.reportViewer1.RefreshReport();
                    md.ShowDialog();
                    md.reportViewer1.Reset();
                }
            }

            else if ((txtformato.Text == "Suplidores") && (txtordenar.Text == "Codigo")) {
                orders = "codsup";
                if (txtdesde.Text == "" && txthasta.Text == "")
                {
                    query = "select * from suplidor order by '" + orders + "' asc";
                    
                    DataSet ds = Utilidades.ejecuta(query);
                    Suplidores md = new Suplidores();
                    ReportDataSource ej = new ReportDataSource("DataSet1", ds.Tables[0]);
                    md.reportViewer1.LocalReport.DataSources.Clear();
                    md.reportViewer1.LocalReport.DataSources.Add(ej);
                    md.reportViewer1.RefreshReport();
                    md.ShowDialog();
                    md.reportViewer1.Reset();
                }
                else if (txtdesde.Text != "" && txthasta.Text == "")
                {
                    query = "select * from suplidor where codsup= " + txtdesde.Text + " order by '" + orders + "' asc";
                    
                    DataSet ds = Utilidades.ejecuta(query);
                    Suplidores md = new Suplidores();
                    ReportDataSource ej = new ReportDataSource("DataSet1", ds.Tables[0]);
                    md.reportViewer1.LocalReport.DataSources.Clear();
                    md.reportViewer1.LocalReport.DataSources.Add(ej);
                    md.reportViewer1.RefreshReport();
                    md.ShowDialog();
                    md.reportViewer1.Reset();
                }
                else if (txtdesde.Text == "" && txthasta.Text != "")
                {
                    query = "select * from suplidor where codsup= " + txthasta.Text + " order by '" + orders + "' asc";
                    DataSet ds = Utilidades.ejecuta(query);
                    Suplidores md = new Suplidores();
                    ReportDataSource ej = new ReportDataSource("DataSet1", ds.Tables[0]);
                    md.reportViewer1.LocalReport.DataSources.Clear();
                    md.reportViewer1.LocalReport.DataSources.Add(ej);
                    md.reportViewer1.RefreshReport();
                    md.ShowDialog();
                    md.reportViewer1.Reset();
                }
                else if (txtdesde.Text != "" && txthasta.Text != "")
                {
                    query = "select * from suplidor where codsup between " + txtdesde.Text + " and " + txthasta.Text + " order by '" + orders + "' asc";
                   
                    DataSet ds = Utilidades.ejecuta(query);
                    Suplidores md = new Suplidores();
                    ReportDataSource ej = new ReportDataSource("DataSet1", ds.Tables[0]);
                    md.reportViewer1.LocalReport.DataSources.Clear();
                    md.reportViewer1.LocalReport.DataSources.Add(ej);
                    md.reportViewer1.RefreshReport();
                    md.ShowDialog();
                    md.reportViewer1.Reset();
                }
            }
            else if ((txtformato.Text == "Suplidores") && (txtordenar.Text == "Nombre"))
            {
                orders = "nomsup";
                if (txtdesde.Text == "" && txthasta.Text == "")
                {
                    query = "select * from suplidor order by '" + orders + "' asc";
                   
                    DataSet ds = Utilidades.ejecuta(query);
                    Suplidores md = new Suplidores();
                    ReportDataSource ej = new ReportDataSource("DataSet1", ds.Tables[0]);
                    md.reportViewer1.LocalReport.DataSources.Clear();
                    md.reportViewer1.LocalReport.DataSources.Add(ej);
                    md.reportViewer1.RefreshReport();
                    md.ShowDialog();
                    md.reportViewer1.Reset();
                }
                else if (txtdesde.Text != "" && txthasta.Text == "")
                {
                    query = "select * from suplidor where codsup= " + txtdesde.Text + " order by '" + orders + "' asc";
                  
                    DataSet ds = Utilidades.ejecuta(query);
                    Suplidores md = new Suplidores();
                    ReportDataSource ej = new ReportDataSource("DataSet1", ds.Tables[0]);
                    md.reportViewer1.LocalReport.DataSources.Clear();
                    md.reportViewer1.LocalReport.DataSources.Add(ej);
                    md.reportViewer1.RefreshReport();
                    md.ShowDialog();
                    md.reportViewer1.Reset();
                }
                else if (txtdesde.Text == "" && txthasta.Text != "")
                {
                    query = "select * from suplidor where codsup= " + txthasta.Text + " order by '" + orders + "' asc";
                   
                    DataSet ds = Utilidades.ejecuta(query);
                    Suplidores md = new Suplidores();
                    ReportDataSource ej = new ReportDataSource("DataSet1", ds.Tables[0]);
                    md.reportViewer1.LocalReport.DataSources.Clear();
                    md.reportViewer1.LocalReport.DataSources.Add(ej);
                    md.reportViewer1.RefreshReport();
                    md.ShowDialog();
                    md.reportViewer1.Reset();
                }
                else if (txtdesde.Text != "" && txthasta.Text != "")
                {
                    query = "select * from suplidor where codsup between " + txtdesde.Text + " and " + txthasta.Text + " order by '" + orders + "' asc";
                   
                    DataSet ds = Utilidades.ejecuta(query);
                    Suplidores md = new Suplidores();
                    ReportDataSource ej = new ReportDataSource("DataSet1", ds.Tables[0]);
                    md.reportViewer1.LocalReport.DataSources.Clear();
                    md.reportViewer1.LocalReport.DataSources.Add(ej);
                    md.reportViewer1.RefreshReport();
                    md.ShowDialog();
                    md.reportViewer1.Reset();
                }
            }
          
            else if ((txtformato.Text == "Departamentos") && (txtordenar.Text == "Codigo"))
            {
                orders = "coddep";
                if (txtdesde.Text == "" && txthasta.Text == "")
                {
                    query = "select * from departamientos order by '" + orders + "' asc";
                    DataSet ds = Utilidades.ejecuta(query);
                    Departamentos md = new Departamentos();
                    ReportDataSource ej = new ReportDataSource("DataSet1", ds.Tables[0]);
                    md.reportViewer1.LocalReport.DataSources.Clear();
                    md.reportViewer1.LocalReport.DataSources.Add(ej);
                    md.reportViewer1.RefreshReport();
                    md.ShowDialog();
                    md.reportViewer1.Reset();
                }
                else if (txtdesde.Text != "" && txthasta.Text == "")
                {
                    query = "select * from departamientos  where coddep= " + txtdesde.Text + " order by '" + orders + "' asc";
                    DataSet ds = Utilidades.ejecuta(query);
                    Departamentos md = new Departamentos();
                    ReportDataSource ej = new ReportDataSource("DataSet1", ds.Tables[0]);
                    md.reportViewer1.LocalReport.DataSources.Clear();
                    md.reportViewer1.LocalReport.DataSources.Add(ej);
                    md.reportViewer1.RefreshReport();
                    md.ShowDialog();
                    md.reportViewer1.Reset();
                }
                else if (txtdesde.Text == "" && txthasta.Text != "")
                {
                    query = "select * from departamientos where coddep= " + txthasta.Text + " order by '" + orders + "' asc";
                    DataSet ds = Utilidades.ejecuta(query);
                    Departamentos md = new Departamentos();
                    ReportDataSource ej = new ReportDataSource("DataSet1", ds.Tables[0]);
                    md.reportViewer1.LocalReport.DataSources.Clear();
                    md.reportViewer1.LocalReport.DataSources.Add(ej);
                    md.reportViewer1.RefreshReport();
                    md.ShowDialog();
                    md.reportViewer1.Reset();
                }
                else if (txtdesde.Text != "" && txthasta.Text != "")
                {
                    query = "select * from departamientos where coddep between " + txtdesde.Text + " and " + txthasta.Text + " order by '" + orders + "' asc";
                    DataSet ds = Utilidades.ejecuta(query);
                    Departamentos md = new Departamentos();
                    ReportDataSource ej = new ReportDataSource("DataSet1", ds.Tables[0]);
                    md.reportViewer1.LocalReport.DataSources.Clear();
                    md.reportViewer1.LocalReport.DataSources.Add(ej);
                    md.reportViewer1.RefreshReport();
                    md.ShowDialog();
                    md.reportViewer1.Reset();
                }
            }
            else if ((txtformato.Text == "Departamentos") && (txtordenar.Text == "Nombre"))
            {
                orders = "nomdep";
                if (txtdesde.Text == "" && txthasta.Text == "")
                {
                    query = "select * from departamientos order by '" + orders + "' asc";
                    DataSet ds = Utilidades.ejecuta(query);
                    Departamentos md = new Departamentos();
                    ReportDataSource ej = new ReportDataSource("DataSet1", ds.Tables[0]);
                    md.reportViewer1.LocalReport.DataSources.Clear();
                    md.reportViewer1.LocalReport.DataSources.Add(ej);
                    md.reportViewer1.RefreshReport();
                    md.ShowDialog();
                    md.reportViewer1.Reset();
                }
                else if (txtdesde.Text != "" && txthasta.Text == "")
                {
                    query = "select * from departamientos  where coddep= " + txtdesde.Text + " order by '" + orders + "' asc";
                    DataSet ds = Utilidades.ejecuta(query);
                    Departamentos md = new Departamentos();
                    ReportDataSource ej = new ReportDataSource("DataSet1", ds.Tables[0]);
                    md.reportViewer1.LocalReport.DataSources.Clear();
                    md.reportViewer1.LocalReport.DataSources.Add(ej);
                    md.reportViewer1.RefreshReport();
                    md.ShowDialog();
                    md.reportViewer1.Reset();
                }
                else if (txtdesde.Text == "" && txthasta.Text != "")
                {
                    query = "select * from departamientos where coddep= " + txthasta.Text + " order by '" + orders + "' asc";
                    DataSet ds = Utilidades.ejecuta(query);
                    Departamentos md = new Departamentos();
                    ReportDataSource ej = new ReportDataSource("DataSet1", ds.Tables[0]);
                    md.reportViewer1.LocalReport.DataSources.Clear();
                    md.reportViewer1.LocalReport.DataSources.Add(ej);
                    md.reportViewer1.RefreshReport();
                    md.ShowDialog();
                    md.reportViewer1.Reset();
                }
                else if (txtdesde.Text != "" && txthasta.Text != "")
                {
                    query = "select * from departamientos where coddep between " + txtdesde.Text + " and " + txthasta.Text + " order by '" + orders + "' asc";
                    DataSet ds = Utilidades.ejecuta(query);
                    Departamentos md = new Departamentos();
                    ReportDataSource ej = new ReportDataSource("DataSet1", ds.Tables[0]);
                    md.reportViewer1.LocalReport.DataSources.Clear();
                    md.reportViewer1.LocalReport.DataSources.Add(ej);
                    md.reportViewer1.RefreshReport();
                    md.ShowDialog();
                    md.reportViewer1.Reset();
                }
            }
            else if ((txtformato.Text == "Articulos") && (txtordenar.Text == "Codigo"))
            {
                orders = "codart";
                if (txtdesde.Text == "" && txthasta.Text == "")
                {
                    query = "select * from Vista_articulo order by '" + orders + "' asc";
                    DataSet ds = Utilidades.ejecuta(query);
                    Articulos md = new Articulos();
                    ReportDataSource ej = new ReportDataSource("DataSet1", ds.Tables[0]);
                    md.reportViewer1.LocalReport.DataSources.Clear();
                    md.reportViewer1.LocalReport.DataSources.Add(ej);
                    md.reportViewer1.RefreshReport();
                    md.ShowDialog();
                    md.reportViewer1.Reset();
                }
                else if (txtdesde.Text != "" && txthasta.Text == "") {
                    query = "select * from Vista_articulo where codart= "+txtdesde.Text+" order by '" + orders + "' asc";
                    DataSet ds = Utilidades.ejecuta(query);
                    Articulos md = new Articulos();
                    ReportDataSource ej = new ReportDataSource("DataSet1", ds.Tables[0]);
                    md.reportViewer1.LocalReport.DataSources.Clear();
                    md.reportViewer1.LocalReport.DataSources.Add(ej);
                    md.reportViewer1.RefreshReport();
                    md.ShowDialog();
                    md.reportViewer1.Reset();
                }
                else if (txtdesde.Text == "" && txthasta.Text != "")
                {
                    query = "select * from Vista_articulo where codart= " + txthasta.Text + " order by '" + orders + "' asc";
                    DataSet ds = Utilidades.ejecuta(query);
                    Articulos md = new Articulos();
                    ReportDataSource ej = new ReportDataSource("DataSet1", ds.Tables[0]);
                    md.reportViewer1.LocalReport.DataSources.Clear();
                    md.reportViewer1.LocalReport.DataSources.Add(ej);
                    md.reportViewer1.RefreshReport();
                    md.ShowDialog();
                    md.reportViewer1.Reset();
                }
                else if (txtdesde.Text != "" && txthasta.Text != "")
                {
                    query = "select * from Vista_articulo where codart between " + txtdesde.Text + " and " + txthasta.Text + " order by '" + orders + "' asc";
                    DataSet ds = Utilidades.ejecuta(query);
                    Articulos md = new Articulos();
                    ReportDataSource ej = new ReportDataSource("DataSet1", ds.Tables[0]);
                    md.reportViewer1.LocalReport.DataSources.Clear();
                    md.reportViewer1.LocalReport.DataSources.Add(ej);
                    md.reportViewer1.RefreshReport();
                    md.ShowDialog();
                    md.reportViewer1.Reset();
                }
            }
            else if ((txtformato.Text == "Articulos") && (txtordenar.Text == "Nombre"))
            {
                orders = "nomart";
                if (txtdesde.Text == "" && txthasta.Text == "")
                {
                    query = "select * from Vista_articulo order by '" + orders + "' asc";
                    DataSet ds = Utilidades.ejecuta(query);
                    Articulos md = new Articulos();
                    ReportDataSource ej = new ReportDataSource("DataSet1", ds.Tables[0]);
                    md.reportViewer1.LocalReport.DataSources.Clear();
                    md.reportViewer1.LocalReport.DataSources.Add(ej);
                    md.reportViewer1.RefreshReport();
                    md.ShowDialog();
                    md.reportViewer1.Reset();
                }
                else if (txtdesde.Text != "" && txthasta.Text == "")
                {
                    query = "select * from Vista_articulo where codart= " + txtdesde.Text + " order by '" + orders + "' asc";
                    DataSet ds = Utilidades.ejecuta(query);
                    Articulos md = new Articulos();
                    ReportDataSource ej = new ReportDataSource("DataSet1", ds.Tables[0]);
                    md.reportViewer1.LocalReport.DataSources.Clear();
                    md.reportViewer1.LocalReport.DataSources.Add(ej);
                    md.reportViewer1.RefreshReport();
                    md.ShowDialog();
                    md.reportViewer1.Reset();
                }
                else if (txtdesde.Text == "" && txthasta.Text != "")
                {
                    query = "select * from Vista_articulo where codart= " + txthasta.Text + " order by '" + orders + "' asc";
                    DataSet ds = Utilidades.ejecuta(query);
                    Articulos md = new Articulos();
                    ReportDataSource ej = new ReportDataSource("DataSet1", ds.Tables[0]);
                    md.reportViewer1.LocalReport.DataSources.Clear();
                    md.reportViewer1.LocalReport.DataSources.Add(ej);
                    md.reportViewer1.RefreshReport();
                    md.ShowDialog();
                    md.reportViewer1.Reset();
                }
                else if (txtdesde.Text != "" && txthasta.Text != "")
                {
                    query = "select * from Vista_articulo where codart between " + txtdesde.Text + " and " + txthasta.Text + " order by '" + orders + "' asc";
                    DataSet ds = Utilidades.ejecuta(query);
                    Articulos md = new Articulos();
                    ReportDataSource ej = new ReportDataSource("DataSet1", ds.Tables[0]);
                    md.reportViewer1.LocalReport.DataSources.Clear();
                    md.reportViewer1.LocalReport.DataSources.Add(ej);
                    md.reportViewer1.RefreshReport();
                    md.ShowDialog();
                    md.reportViewer1.Reset();
                }
            }
           
        }
    }
}
