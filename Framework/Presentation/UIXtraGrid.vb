Imports DevExpress.Utils.Win
Imports DevExpress.Xpo
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraEditors.Mask
Imports DevExpress.XtraEditors.Popup
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Grid
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms


Namespace Presentation

    Public Module UIXtraGrid
        <Extension>
        Public Function SelectionIsValid(view As GridView) As Boolean
            Return Not (view.FocusedRowHandle = GridControl.AutoFilterRowHandle OrElse view.IsGroupRow(view.FocusedRowHandle))
        End Function

        Public Sub DrawTextOnEmptyGrid(sender As Object, e As CustomDrawEventArgs)
            Dim view As GridView = CType(sender, GridView)
            If Not view.RowCount = 0 Then Return
            Dim drawFormat As New StringFormat() With {.Alignment = StringAlignment.Center}
            e.Graphics.DrawString("<There are no items found in this view>", New Font("Segoe UI", 8), SystemBrushes.ControlDark, New RectangleF(e.Bounds.X, e.Bounds.Y + 30, e.Bounds.Width, e.Bounds.Height), drawFormat)
        End Sub

        Public Function SetRepositoryTextEdit(ByVal grid As GridControl, Optional mask As MaskType = MaskType.None, Optional maskString As String = "", Optional maxlength As Integer = 10) As RepositoryItemTextEdit
            Dim edit As New RepositoryItemTextEdit
            edit.Mask.MaskType = mask
            edit.Mask.EditMask = maskString
            edit.MaxLength = maxlength
            grid.RepositoryItems.Add(edit)
            Return edit
        End Function

        Public Sub PrepareLookup(lookup As Object, columnName As String, valueMember As String, collection As XPBaseCollection, Optional handler As ProcessNewValueEventHandler = Nothing)
            Dim edit As RepositoryItemLookUpEdit
            Dim tag As String = String.Empty

            If TypeOf lookup Is RepositoryItemLookUpEdit Then
                edit = CType(lookup, RepositoryItemLookUpEdit)
                tag = edit.Tag
            Else
                edit = CType(lookup.Properties, RepositoryItemLookUpEdit)
                tag = CType(lookup, LookUpEdit).Tag
            End If

            Dim column As LookUpColumnInfo = New LookUpColumnInfo(columnName, columnName)
            With edit
                .DataSource = collection
                .Columns.Clear()
                .Columns.Add(column)
                .DisplayMember = columnName
                .ValueMember = valueMember
                .ShowFooter = False
                .ShowHeader = False
                .ShowPopupShadow = False
                .DropDownRows = RecalculatePopupHeight(collection.Count)
                .PopupWidth = 10


                AddHandler edit.Popup, AddressOf lue_Popup
                AddHandler edit.QueryPopUp, AddressOf lue_QueryPopUp

                If tag IsNot Nothing AndAlso handler IsNot Nothing Then
                    .TextEditStyle = TextEditStyles.Standard
                    .AllowNullInput = DevExpress.Utils.DefaultBoolean.True
                    .SearchMode = SearchMode.OnlyInPopup
                    AddHandler edit.ProcessNewValue, handler
                End If

            End With
        End Sub

        Private Function RecalculatePopupHeight(count As Integer) As Integer
            If count >= 7 Then Return 7
            Return count
        End Function

        Public Sub lue_Popup(sender As Object, e As EventArgs)
            Dim lookup As LookUpEdit = CType(sender, LookUpEdit)
            Dim popup As PopupLookUpEditForm = CType(TryCast(lookup, IPopupControl).PopupWindow, PopupLookUpEditForm)
            popup.Width = lookup.Width
        End Sub

        Private Sub lue_QueryPopUp(sender As Object, e As System.ComponentModel.CancelEventArgs)
            Dim lookup As LookUpEdit = CType(sender, LookUpEdit)
            lookup.Properties.DropDownRows = RecalculatePopupHeight(CType(lookup.Properties.DataSource, IList).Count)
        End Sub

        Public Sub NoActionInvalidRowException(sender As Object, e As InvalidRowExceptionEventArgs)
            e.ExceptionMode = ExceptionMode.NoAction
        End Sub

        Public Sub GridViewRowDeleteKeyCombo(sender As Object, e As KeyEventArgs)
            If (e.KeyCode = Keys.Delete And e.Modifiers = Keys.Control) Then
                If (MessageBox.Show("Delete this entry?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) <> DialogResult.Yes) Then Return
                Dim view As GridView = CType(sender, GridView)
                view.GetRow(view.FocusedRowHandle).Delete()
            End If
        End Sub
    End Module
End Namespace