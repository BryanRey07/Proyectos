using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace Supermercado
{
    class Utilidades
    {
        //////////////Declarion publica////////////////////

        public SqlConnection VarConnection = new SqlConnection();
        public SqlCommand VarCmd = new SqlCommand();
        public SqlDataReader VarReader;

        // public static string servidor = "MACCEAU-PC\\SQLEXPRESS";
        public static string servidor = "LAPTOP-0HLLP22S";
        public static string baseDatos = "Supermercado";
        public static int VariablePublica1 = 0;
        public static int VariablePublica2 = 0;
        public static string Seleccionado1 = "";
        public static string Seleccionado2 = "";
        public static string Seleccionado3 = "";
        public static string Seleccionado4 = "";
        public static string Seleccionado5 = "";
        public static string Seleccionado6= "";
        public static string Seleccionado14 = "";

        //--------------------------Metod ki fe koneksyon an ---------------------------------------
        public bool Conectar()
        {
            VarConnection.Close();

            string connectionString;
            connectionString = "Data Source=" + servidor + ";" + "Initial Catalog=" + baseDatos + ";" + "Integrated Security=True";
            try
            {
                VarConnection = new SqlConnection(connectionString);
                VarConnection.Open();
                return true;
            }
            catch
            {

                try
                {
                    connectionString = "Data Source=" + servidor + ";" + "Initial Catalog=" + baseDatos + ";" + "Integrated Security=True";
                    VarConnection.Close();
                    VarConnection = new SqlConnection(connectionString);
                    VarConnection.Open();
                    return true;
                }
                catch
                {

                    return false;
                }
            }

        }
        //------------------------------------- fin de la conexion--------------------------------------

        //////////////////////Fin de funcion para desconectar//////////////////
        public void Desconectar()
        {
            VarConnection.Close();
        }
        //////////////////////Fin de funcion para desconectar//////////////////

        /// //////////////////////////Para reiniciar conexion///////////////////////////
        public void reset()
        {
            this.Desconectar();
            this.Conectar();
        }
        /// //////////////////////Fin de reinicializacion//////////////////
        //--------------------------------------Metod pou insertar, update, delete-------------------
        public string ManipularDB(string query)
        {
            Conectar();

            VarCmd = new SqlCommand(query, VarConnection);
            try
            {
                VarCmd.ExecuteNonQuery();
                return ("1");
            }
            catch (SqlException b)
            {
                MessageBox.Show(query + "\n\n\n" + b.Message);
                return ("2");
            }

        }
        //////////////////////Fin de manipuacion de la base de datos//////////////////

        //////////////////////Funcion para retornar el codigo mayor //////////////////
        public string MayorCodigo(String nombreCampo, String nombreTabla)
        {
            Conectar();

            int Count = 0;
            String valor;
            string query = "select max(" + nombreCampo + ") from " + nombreTabla + "";
            SqlCommand cmd = new SqlCommand(query, this.VarConnection);

            try
            {
                valor = cmd.ExecuteScalar() + "";//ExecuteScalar will return one value
            }
            catch { valor = ""; }

            if (valor.Equals(""))
                return "";
            else
                Count = int.Parse(valor) + 1;

            Desconectar();//close Connection

            return Count.ToString();
        }

        //////////////////////Fin //////////////////

        //para seleccionar un código relacionado con una descripcion en una tabla
        public int BuscarCodigo(String codcampo, String descampo, String descripcion, String tabla)
        {
            Conectar();

            int resultado = 0;
            String valor;
            //Create Mysql Command
            string query = "select " + codcampo + "  from " + tabla + " where " + descampo + "='" + descripcion + "'";
            SqlCommand cmd = new SqlCommand(query, this.VarConnection);
            valor = cmd.ExecuteScalar() + "";//ExecuteScalar will return one values
            if (valor.Equals(""))
                resultado = 0;
            else
                resultado = int.Parse(valor);

            this.Desconectar();//close Connection

            return resultado;
        }
        //-------------------------------------------------fin---------------------------------------------


        public static DataSet Ejecutar1(string cmd)
        {
            SqlConnection Con = new SqlConnection(@"Data Source=.;Initial Catalog=Supermercado;Integrated Security=True");
            Con.Open();

            DataSet DS = new DataSet();
            SqlDataAdapter DP = new SqlDataAdapter(cmd, Con);

            DP.Fill(DS);
            Con.Close();

            return DS;
        }

        //////////////////////Funcion para llenar (datagridvew,combobox,TextBox...)//////////////////
        public void BuscarDatos(string query)
        {
            try
            {
                Conectar();
                VarCmd = new SqlCommand(query, VarConnection);
                VarReader = VarCmd.ExecuteReader();
            }

            catch (SqlException b)
            {
                MessageBox.Show(query + "\n\n\n" + b.Message);

            }


        }
        //////////////////////Fin//////////////////

        //----------------------------Metod ki konekte baz de done a avek datasources la pou reporte ---------------------------------------------
        public static DataSet ejecuta(string cmd)
        {
            string connectionString;
            connectionString = @"Data Source= LAPTOP-0HLLP22S;" + "Initial Catalog=" + baseDatos + ";" + "Integrated Security=True";
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand comando = new SqlCommand(cmd, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd, con);
            DataSet ds = new DataSet();
            try
            {
                con.Open();
                da.Fill(ds, "Conexion Ok");
            }
            catch
            {
                MessageBox.Show("Error de Conexion.");
            }
            finally
            {
                con.Close();
            }
            return ds;
        }
    }
}
