using System;
using System.Windows.Forms;
using DevExpress.Skins;

namespace Dashboard_ConfigureDataConnection {
    static class Program {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
            SkinManager.EnableFormSkins();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.EnableVisualStyles();
            Application.Run(new Form1());
        }
    }
}
