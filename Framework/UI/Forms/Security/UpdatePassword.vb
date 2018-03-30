Imports System.Windows.Forms

Public Class UpdatePassword

    Private Sub Form_Load() Handles Me.Load
        SuspendLayout()
        LoadUserData()
        AddHandler btnOK.Click, AddressOf DoUpdate
        ResumeLayout()
    End Sub

    Protected Overridable Sub LoadUserData()
    End Sub

    Protected Overridable Sub DoUpdate(sender As Object, e As EventArgs)
    End Sub

    Private Sub frmChangePassword_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If (e.KeyCode = Keys.Enter) Then
            btnOK.PerformClick()
        End If
    End Sub
End Class