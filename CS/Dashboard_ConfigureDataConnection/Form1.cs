using System.Windows.Forms;
using DevExpress.DataAccess.ConnectionParameters;

namespace Dashboard_ConfigureDataConnection {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();

            // Loads a dashboard from an XML file.
            dashboardViewer1.LoadDashboard(@"..\..\Data\nwindDashboard.xml");
        }

        // Handles the ConfigureDataConnection event.
        private void dashboardViewer1_ConfigureDataConnection(object sender, 
            DevExpress.DataAccess.ConfigureDataConnectionEventArgs e) {

            // Checks the name of the connection for which the event has been raised.
            if (e.ConnectionName == "nwindConnection") {

                // Gets the connection parameters used to establish a connection to the database.
                Access97ConnectionParameters parameters = 
                    (Access97ConnectionParameters)e.ConnectionParameters;

                // Specifies the user name used to access the database file. 
                parameters.UserName = "Admin";

                // Specifies the password used to access the database file.
                parameters.Password = "password";
            }
        }
    }
}
