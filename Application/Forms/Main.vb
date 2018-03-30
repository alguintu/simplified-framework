Imports System.ComponentModel.Composition
Imports DevExpress.LookAndFeel
Imports DevExpress.XtraSplashScreen
Imports Simplified.App.Interfaces
Imports Simplified.Framework
Imports Simplified.Framework.Core
Imports Simplified.Framework.Interfaces
Imports Simplified.Framework.Presentation

Partial Public Class Main
    Implements IMainForm

    <Import(GetType(IScheduler), AllowDefault:=True)>
    Private Property Contacts As Lazy(Of IScheduler)

    <Import(GetType(IRoom), AllowDefault:=True)>
    Private Property Rooms As Lazy(Of IRoom)


    Public Property CurrentUser As IUser Implements IMainForm.CurrentUser
    Private Property UiManager As UiManager Implements IMainForm.UiManager

    Public Sub New()
        DoubleBuffered = True
        InitializeComponent()
        InitializeFramework()
        Application.DoEvents()
    End Sub

    Private Sub InitializeFramework()
        Application.DoEvents()
        SplashScreenManager.ShowForm(GetType(Splash))
        UiManager = UiManager.Instance
        SuspendLayout()
        navigationBar.ShowPeekFormOnItemHover = True
        navigationBar.PeekFormShowDelay = 1000
        UiManager.Setup(Me, Ribbon, navigationBar, navigationFrame)
        InitializeUI()
        InitializeModules()
        'InitializeBackStage()
        'UiManager.LockView(True)
        RestoreWindowLayout()
        ResumeLayout()
        SplashScreenManager.CloseForm(False)
        Application.DoEvents()
    End Sub

    Private Sub InitializeUI()
        If Ribbon IsNot Nothing Then
            Ribbon.ForceInitialize()
            Ribbon.TransparentEditorsMode = DevExpress.Utils.DefaultBoolean.True
        End If
        Controls.SetMenuManager(Ribbon)
        UserLookAndFeel.Default.SkinName = My.Settings.AppTheme
    End Sub

    Private Sub InitializeModules() Implements IMainForm.InitializeModules
        Dim mozart As New Composer
        mozart.Compose(Me)
        UiManager.AddModule("Scheduler", Contacts)
        UiManager.AddModule("Rooms", Rooms)
    End Sub

    Private Sub Main_Load(sender As Object, e As EventArgs) Handles Me.Load
        SuspendLayout()
        UiManager.ShowFirstView()
        ResumeLayout()
    End Sub


    Public Sub ConnectToDatabase() Implements IMainForm.ConnectToDatabase
        Throw New NotImplementedException()
    End Sub

    Public Sub PerformLogin() Implements IMainForm.PerformLogin
        Throw New NotImplementedException()
    End Sub

    Public Sub PerformLogout() Implements IMainForm.PerformLogout
        Throw New NotImplementedException()
    End Sub

    Public Sub InitializeFramwework() Implements IMainForm.InitializeFramwework
        Throw New NotImplementedException()
    End Sub

    Public Sub InitializeBackStage() Implements IMainForm.InitializeBackStage
        Throw New NotImplementedException()
    End Sub

#Region "Window Layout"
    Private Sub SaveWindowLayout()
        With My.Settings
            If WindowState = FormWindowState.Normal Then
                .FormState = WindowState
                .FormLocation = Location
                .FormSize = Size
            ElseIf Me.WindowState = FormWindowState.Maximized Then
                .FormState = WindowState
            End If

            .AppTheme = UserLookAndFeel.Default.ActiveLookAndFeel.SkinName.ToString
            .Save()
        End With
    End Sub

    Private Sub MainForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        SaveWindowLayout()
    End Sub

    Private Sub RestoreWindowLayout()
        MinimumSize = My.Settings.MinimumSize
        Location = My.Settings.FormLocation
        Size = My.Settings.FormSize

        If My.Settings.FormState = FormWindowState.Maximized Then
            WindowState = My.Settings.FormState
        End If
    End Sub
#End Region
End Class
