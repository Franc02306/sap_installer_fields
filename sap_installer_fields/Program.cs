using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sap_installer_fields
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Manualmente se abre el formulario de conexión SAP
            ConnectionForm conn = new ConnectionForm();
            conn.Show();

            Application.Run();
        }
    }
}
