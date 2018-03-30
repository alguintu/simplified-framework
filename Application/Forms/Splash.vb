Imports DevExpress.LookAndFeel
Imports Simplified.Framework.Presentation

Public Class Splash
    Sub New()
        InitializeComponent()
        panelBackdrop.BackColor = Color.FromName((GetUserColorScheme(My.Settings.ColorScheme).ToString))
        lblTrialVersion.BackColor = LookAndFeelHelper.GetSystemColor(UserLookAndFeel.Default.ActiveLookAndFeel, SystemColors.Control)
        lblProductName.Text = My.Settings.ProductName
        lblVersionInfo.Text = String.Format("Version {0}", My.Settings.CurrentVersion)
    End Sub

    Public Overrides Sub ProcessCommand(ByVal cmd As [Enum], ByVal arg As Object)
        MyBase.ProcessCommand(cmd, arg)
    End Sub
End Class
