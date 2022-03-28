using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using US_EXCHANGER.Presentation;

namespace US_EXCHANGER
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Aplicacion.IniciarParametros();
            Aplicacion.ObtenerEmpresa();
            Aplicacion.ObtenerXmlConnection();
            Application.Run(new FrmLogin());
        }
    }
}
