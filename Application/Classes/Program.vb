Public Class Program
    <STAThread()>
    Public Shared Sub Main()
        Application.SetCompatibleTextRenderingDefault(False)
        Application.EnableVisualStyles()
        Try
            Dim main As New Main
            Application.Run(main)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class

