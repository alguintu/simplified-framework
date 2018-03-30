Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Registrator
Imports DevExpress.XtraEditors.Controls

<System.ComponentModel.DesignTimeVisible(True)> _
<System.ComponentModel.ToolboxItem(True)> _
<UserRepositoryItem("RegisterActionToolbar")> _
Public Class ActionToolbar
    Inherits ButtonEdit

    Public Event AddClicked(sender As Object, e As EventArgs)
    Public Event EditClicked(sender As Object, e As EventArgs)
    Public Event DeleteClicked(sender As Object, e As EventArgs)
    Public Event SaveClicked(sender As Object, e As EventArgs)
    Public Event CancelClicked(sender As Object, e As EventArgs)

    Shared Sub New()
        RepositoryItemActionToolbar.RegisterActionToolbar()
    End Sub

    Public Sub New()
        MyBase.New()
        Me.MaximumSize = New System.Drawing.Size(120, 32)
        Me.MinimumSize = New System.Drawing.Size(120, 32)
    End Sub

    Public Overrides ReadOnly Property EditorTypeName() As String
        Get
            Return RepositoryItemActionToolbar.CustomEditName
        End Get
    End Property

    Private _allowEdit As Boolean = True
    Private _allowDelete As Boolean = True

    Public Sub AllowEdit(state As Boolean)
        Try
            Properties.Buttons(1).Enabled = state
            _allowEdit = state
        Catch ex As Exception
            'Do nohing
        End Try
    End Sub

    Public Sub AllowDelete(state As Boolean)
        Try
            Properties.Buttons(2).Enabled = state
            _allowDelete = state
        Catch ex As Exception
            'Do nohing
        End Try
    End Sub

    <System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Content)> _
        Public Shadows ReadOnly Property Properties() As RepositoryItemActionToolbar
        Get
            Return CType(MyBase.Properties, RepositoryItemActionToolbar)
        End Get
    End Property

    Private Sub Button_Click(ByVal sender As Object, ByVal e As ButtonPressedEventArgs) Handles Me.ButtonClick
        Select Case e.Button.Caption
            Case "Add"
                With Properties
                    .Buttons(0).Enabled = False
                    .Buttons(1).Visible = False
                    .Buttons(2).Visible = False
                    .Buttons(3).Visible = True
                    .Buttons(4).Visible = True
                End With
                RaiseEvent AddClicked(Me, EventArgs.Empty)
            Case "Edit"
                With Properties
                    .Buttons(0).Visible = False
                    .Buttons(1).Enabled = False
                    .Buttons(2).Visible = False
                    .Buttons(3).Visible = True
                    .Buttons(4).Visible = True
                End With
                RaiseEvent EditClicked(Me, EventArgs.Empty)
            Case "Delete"
                RaiseEvent DeleteClicked(Me, EventArgs.Empty)
            Case "Save"
                RaiseEvent SaveClicked(Me, EventArgs.Empty)
            Case "Cancel"
                RaiseEvent CancelClicked(Me, EventArgs.Empty)
        End Select
    End Sub

    Public Sub PostSaveCancel()
        With Properties
            .Buttons(0).Visible = True
            .Buttons(0).Enabled = True
            .Buttons(1).Visible = True
            .Buttons(1).Enabled = _allowEdit AndAlso True
            .Buttons(2).Visible = _allowDelete AndAlso True
            .Buttons(3).Visible = False
            .Buttons(4).Visible = False
        End With
    End Sub

End Class
