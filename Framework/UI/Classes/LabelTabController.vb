Imports DevExpress.XtraEditors
Imports System.Drawing

Public Class LabelTabController
    Public Event LabelClicked As EventHandler
    Private labels() As LabelControl

    Public Sub New(ByVal ParamArray list() As LabelControl)
        Me.labels = list
        For Each lb As LabelControl In list
            AddHandler lb.Click, AddressOf LabelClick
        Next lb
    End Sub

    Private Sub LabelClick(sender As Object, e As EventArgs)
        Dim l As LabelControl = CType(sender, LabelControl)
        l.Font = New Font(l.Font.FontFamily, 10, FontStyle.Bold)
        l.Tag = True
        For Each lc As LabelControl In labels
            If Not lc.Equals(l) Then
                lc.Appearance.Reset()
                lc.Font = New Font(lc.Font.FontFamily, 10, FontStyle.Regular)
                lc.Tag = False
            End If
        Next lc
        RaiseEvent LabelClicked(sender, EventArgs.Empty)
    End Sub
End Class

