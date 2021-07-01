using DevExpress.DataAccess.ConnectionParameters;
using DevExpress.DashboardCommon;
using DevExpress.XtraEditors;

namespace Dashboard_ConfigureDataConnection {
    public partial class Form1 : XtraForm {
        public Form1() {
            InitializeComponent();
            dashboardViewer1.ConfigureDataConnection += dashboardViewer1_ConfigureDataConnection;
            dashboardViewer1.LoadDashboard(@"..\..\Data\nwindDashboard.xml");
        }

        private void dashboardViewer1_ConfigureDataConnection(object sender,
            DashboardConfigureDataConnectionEventArgs e) {
            if (e.DataSourceName == "SQL Data Source 1") {
                Access97ConnectionParameters parameters =
                    (Access97ConnectionParameters)e.ConnectionParameters;
                parameters.UserName = "Admin";
                parameters.Password = "password";
            }
        }
    }
}
