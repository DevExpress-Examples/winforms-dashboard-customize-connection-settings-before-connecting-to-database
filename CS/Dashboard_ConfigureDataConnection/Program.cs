using System;
using System.Windows.Forms;

namespace Dashboard_ConfigureDataConnection {
    static class Program {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
            Application.SetCompatibleTextRenderingDefault(false);
            Application.EnableVisualStyles();
            Application.Run(new Form1());
        }
    }
}
