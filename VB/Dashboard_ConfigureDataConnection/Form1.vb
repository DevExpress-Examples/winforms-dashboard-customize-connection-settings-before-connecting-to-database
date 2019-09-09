Imports DevExpress.DataAccess.ConnectionParameters
Imports DevExpress.DashboardCommon
Imports DevExpress.XtraEditors

Namespace Dashboard_ConfigureDataConnection
	Partial Public Class Form1
		Inherits XtraForm

		Public Sub New()
			InitializeComponent()
			AddHandler dashboardViewer1.ConfigureDataConnection, AddressOf dashboardViewer1_ConfigureDataConnection
			dashboardViewer1.LoadDashboard("..\..\Data\nwindDashboard.xml")
		End Sub

		Private Sub dashboardViewer1_ConfigureDataConnection(ByVal sender As Object, ByVal e As DashboardConfigureDataConnectionEventArgs)
			If e.DataSourceName = "SQL Data Source 1" Then
				Dim parameters As Access97ConnectionParameters = CType(e.ConnectionParameters, Access97ConnectionParameters)
				parameters.UserName = "Admin"
				parameters.Password = "password"
			End If
		End Sub
	End Class
End Namespace
