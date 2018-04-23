Imports Microsoft.VisualBasic
Imports System
Imports System.Windows.Forms

Namespace Dashboard_ConfigureDataConnection
	Friend NotInheritable Class Program
		''' <summary>
		''' The main entry point for the application.
		''' </summary>
		Private Sub New()
		End Sub
		<STAThread> _
		Shared Sub Main()
			Application.SetCompatibleTextRenderingDefault(False)
			Application.EnableVisualStyles()
			Application.Run(New Form1())
		End Sub
	End Class
End Namespace
