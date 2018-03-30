Imports DevExpress.XtraReports.UI

Public Class ReportFilterForm
    Private currentReport As XtraReport = Nothing

    Public Sub New(ByRef report As XtraReport, ByRef filter As String)
        InitializeComponent()
        currentReport = report
        filterControl.SourceControl = report.DataSource
        filterControl.FilterString = filter
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Close()
    End Sub

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        currentReport.FilterString = filterControl.FilterString
        currentReport.CreateDocument(True)
        Close()
    End Sub
End Class