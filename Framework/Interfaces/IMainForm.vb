Imports DevExpress.XtraBars.Navigation
Imports DevExpress.XtraBars.Ribbon
Imports Simplified.Framework.Core

Namespace Interfaces
    Public Interface IMainForm


        Property CurrentUser As IUser
        Property UiManager As UiManager

        Sub InitializeFramwework()
        Sub InitializeModules()
        Sub InitializeBackStage()
        Sub ConnectToDatabase()
        Sub PerformLogin()
        Sub PerformLogout()

    End Interface

End Namespace

