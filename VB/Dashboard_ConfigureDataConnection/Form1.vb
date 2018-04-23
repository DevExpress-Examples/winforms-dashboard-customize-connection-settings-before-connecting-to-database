Imports DevExpress.DataAccess.ConnectionParameters
Imports DevExpress.DashboardCommon
Imports DevExpress.XtraEditors

Namespace Dashboard_ConfigureDataConnection
    Partial Public Class Form1
        Inherits XtraForm

        Public Sub New()
            InitializeComponent()

            ' Loads a dashboard from an XML file.
            dashboardViewer1.LoadDashboard("..\..\Data\nwindDashboard.xml")
        End Sub

        ' Handles the ConfigureDataConnection event.
        Private Sub dashboardViewer1_ConfigureDataConnection(ByVal sender As Object, _
                                     ByVal e As DashboardConfigureDataConnectionEventArgs) _
                                 Handles dashboardViewer1.ConfigureDataConnection

            ' Checks the name of the connection for which the event has been raised.
            If e.DataSourceName = "SQL Data Source 1" Then

                ' Gets the connection parameters used to establish a connection to the database.
                Dim parameters As Access97ConnectionParameters =
                    CType(e.ConnectionParameters, Access97ConnectionParameters)

                ' Specifies the user name used to access the database file. 
                parameters.UserName = "Admin"

                ' Specifies the password used to access the database file.
                parameters.Password = "password"
            End If
        End Sub
    End Class
End Namespace
