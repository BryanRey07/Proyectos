using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Supermercado
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1());
           // Application.Run(new Mantenimientos.Departamentos());
            // Application.Run(new Mantenimientos.Usuarios());
            //Application.Run(new Inicio.Menu());
            Application.Run(new Inicio.Splash());
            //Application.Run(new Reportes.PrincipalReporte());
            //Application.Run(new Procesos.Factura());
        }
    }
}
