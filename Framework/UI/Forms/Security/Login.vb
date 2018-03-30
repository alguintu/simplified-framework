Imports System.Drawing
Imports System.Windows.Forms
Imports DevExpress.XtraBars.Ribbon

Public Class Login
    Public Property LoggedInUser As Object

    Public Sub New()
        InitializeComponent()
        AddHandler btnLogin.Click, AddressOf ValidateLogin
        lblLogo.ImageOptions.ImageIndex = 0
        lblLogo.ImageOptions.Alignment = ContentAlignment.TopCenter
    End Sub

    Protected Overridable Sub ValidateLogin(sender As Object, e As EventArgs)
    End Sub

    Private Sub frmLogin_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If (e.KeyCode = Keys.Enter) Then
            btnLogin.PerformClick()
        End If
    End Sub

    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles Me.Load
        If Owner IsNot Nothing Then SetMenuManager(Controls, CType(Owner, RibbonForm).Ribbon)
    End Sub
End Class