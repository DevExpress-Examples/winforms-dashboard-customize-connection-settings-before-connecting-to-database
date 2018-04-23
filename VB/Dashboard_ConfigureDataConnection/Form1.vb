Imports Microsoft.VisualBasic
Imports System.Windows.Forms
Imports DevExpress.DataAccess.ConnectionParameters

Namespace Dashboard_ConfigureDataConnection
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()

			' Loads a dashboard from an XML file.
			dashboardViewer1.LoadDashboard("..\..\Data\nwindDashboard.xml")
		End Sub

		' Handles the ConfigureDataConnection event.
        Private Sub dashboardViewer1_ConfigureDataConnection(ByVal sender As Object, _
                                     ByVal e As DevExpress.DataAccess.ConfigureDataConnectionEventArgs) _
                                 Handles dashboardViewer1.ConfigureDataConnection

            ' Checks the name of the connection for which the event has been raised.
            If e.ConnectionName = "nwindConnection" Then

                ' Gets the connection parameters used to establish a connection to the database.
                Dim parameters As Access97ConnectionParameters = CType(e.ConnectionParameters,  _
                    Access97ConnectionParameters)

                ' Specifies the user name used to access the database file. 
                parameters.UserName = "Admin"

                ' Specifies the password used to access the database file.
                parameters.Password = "password"
            End If
        End Sub
	End Class
End Namespace
