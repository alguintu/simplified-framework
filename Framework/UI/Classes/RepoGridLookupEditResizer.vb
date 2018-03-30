Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Repository
Imports System.ComponentModel
Imports System.Drawing

Public Class RepoGridLookupEditResizer
    Public Sub New(edit As RepositoryItemGridLookUpEdit)
        edit.PopupFormSize = New Size(10, 10)
        edit.PopupFormMinSize = New Size(10, 10)
        AddHandler edit.QueryPopUp, AddressOf Edit_QueryPopUp
    End Sub

    Private Sub Edit_QueryPopUp(sender As Object, e As CancelEventArgs)
        Dim editor As GridLookUpEdit = DirectCast(sender, GridLookUpEdit)
        editor.Properties.View.OptionsView.ColumnAutoWidth = True
        editor.Properties.View.BestFitColumns()
        editor.Properties.PopupFormSize = New Size(editor.Width - 4, 100)
    End Sub

End Class
