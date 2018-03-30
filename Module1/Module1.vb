Imports System.ComponentModel.Composition
Imports Simplified.Framework.Core
Imports Simplified.Framework.Events
Imports Simplified.App.Interfaces
Imports DevExpress.XtraScheduler
Imports Simplified.Framework.Interfaces

Namespace Module1

    <ComponentModel.DesignTimeVisible(False)>
    <ComponentModel.ToolboxItem(False)>
    <Export(GetType(IScheduler))>
    Public Class Module1
        Inherits ModuleBase
        Implements IScheduler, IModule
        Public Overloads Property Peek As Peek Implements IModule.Peek

        Public Sub New()
            InitializeComponent()
            ModuleName = "Scheduler"
            Peek = New Peek(ModuleName, Me, smallImages)
            Peek.Add("Arrivals", Me, 0)
            Peek.Add("Departures", GetType(SubModule1), 1)
            Peek.Add("More", Nothing, 2)
        End Sub

        Public Overloads Sub HandleDataUpdate(sender As Object, e As DataUpdateEventArgs) Implements IModule.HandleDataUpdate
        End Sub

        Public Overloads Sub HandlePermissionUpdate(sender As Object, e As EventArgs) Implements IModule.HandlePermissionUpdate
        End Sub
    End Class

End Namespace
