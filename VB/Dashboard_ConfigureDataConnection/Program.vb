Imports System
Imports System.Windows.Forms

Namespace Dashboard_ConfigureDataConnection

    Friend Module Program

        ''' <summary>
        ''' The main entry point for the application.
        ''' </summary>
        <STAThread>
        Sub Main()
            Application.SetCompatibleTextRenderingDefault(False)
            Call Application.EnableVisualStyles()
            Call Application.Run(New Form1())
        End Sub
    End Module
End Namespace
