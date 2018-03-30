Imports DevExpress.Xpo

<System.ComponentModel.DesignTimeVisible(False)>
<System.ComponentModel.ToolboxItem(False)>
Public Class OptionPage
    Private _uow As UnitOfWork

    Public Property UoW As UnitOfWork
        Get
            Return _uow
        End Get
        Set(value As UnitOfWork)
            _uow = value
            SetXPSessions()
        End Set
    End Property

    Protected Overridable Sub SetXPSessions()
    End Sub

    Public Sub New()
        InitializeComponent()
    End Sub

    Public ReadOnly Property IsPageValid As Boolean
        Get
            Return IsFormValid(validator)
        End Get
    End Property

    Private Sub pageProperty_Leave(sender As Object, e As EventArgs) Handles Me.Leave
        Me.ValidateChildren()
        If IsPageValid AndAlso UoW.InTransaction Then
            UoW.CommitChanges()
        End If
    End Sub
End Class
