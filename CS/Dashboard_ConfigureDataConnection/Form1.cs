using DevExpress.DataAccess.ConnectionParameters;
using DevExpress.DashboardCommon;
using DevExpress.XtraEditors;

namespace Dashboard_ConfigureDataConnection {
    public partial class Form1 : XtraForm {
        public Form1() {
            InitializeComponent();

            // Loads a dashboard from an XML file.
            dashboardViewer1.LoadDashboard(@"..\..\Data\nwindDashboard.xml");
        }

        // Handles the ConfigureDataConnection event.
        private void dashboardViewer1_ConfigureDataConnection(object sender, 
            DashboardConfigureDataConnectionEventArgs e) {

            // Checks the name of the connection for which the event has been raised.
            if (e.DataSourceName == "SQL Data Source 1") {

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
