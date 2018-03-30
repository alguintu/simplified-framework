Imports Simplified.Framework.Core
Imports Simplified.Framework.Events

Namespace Interfaces
    Public Interface IModule
        Sub HandleDataUpdate(sender As Object, e As DataUpdateEventArgs)
        Sub HandlePermissionUpdate(sender As Object, e As EventArgs)
        Property Peek As Peek
    End Interface

End Namespace
