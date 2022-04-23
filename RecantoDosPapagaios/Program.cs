using System;
using System.Windows.Forms;
using RecantoDosPapagaios.TelasDeUsuarios;

namespace RecantoDosPapagaios
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
            //Application.Run(new frmTelaPrincipal());
            Application.Run(new frmTelaDeLogin());
        }
    }
}
