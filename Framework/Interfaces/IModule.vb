Imports Simplified.Framework.Core
Imports Simplified.Framework.Events

Namespace Interfaces
    Public Interface IModule
        Sub HandleDataUpdate(sender As Object, e As DataUpdateEventArgs)
        Sub HandlePermissionUpdate(sender As Object, e As EventArgs)
    End Interface

End Namespace
