Imports System
Imports System.Windows.Forms
Imports DevExpress.Skins

Namespace Dashboard_ConfigureDataConnection
	Friend NotInheritable Class Program

		Private Sub New()
		End Sub

		''' <summary>
		''' The main entry point for the application.
		''' </summary>
		<STAThread>
		Shared Sub Main()
			SkinManager.EnableFormSkins()
			Application.SetCompatibleTextRenderingDefault(False)
			Application.EnableVisualStyles()
			Application.Run(New Form1())
		End Sub
	End Class
End Namespace
