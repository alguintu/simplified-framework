Imports System.ComponentModel
Imports DevExpress.XtraBars.Ribbon
Imports DevExpress.XtraEditors
Imports Simplified.Framework.Core.Actions
Imports Simplified.Framework.Events
Imports Simplified.Framework.Interfaces
Imports Simplified.Framework.Presentation

Namespace Core
    Public Class ModuleBase
        Inherits XtraUserControl
        Implements IModule

        Public Shared Event DataUpdate(sender As Object, e As DataUpdateEventArgs)
        Public Shared Event PermissionsUpdate(sender As Object, e As EventArgs)

        Public Property Peek As Peek Implements IModule.Peek
        Public Property ModuleName As String
        Public Property Ribbon As RibbonControl
        Public ReadOnly Property HasRibbon As Boolean
            Get
                Return Ribbon IsNot Nothing
            End Get
        End Property
        Public Property Status As RibbonStatusBar
        Public ReadOnly Property HasStatusBar As Boolean
            Get
                Return Status IsNot Nothing
            End Get
        End Property
        Public ReadOnly Property MainForm As RibbonForm
            Get
                Return ParentForm
            End Get
        End Property
        Protected Actions As List(Of ActionBase)

        Public Sub New()
            DoubleBuffered = True
            Actions = New List(Of ActionBase)
        End Sub

        Private Sub BaseLoad() Handles Me.Load
            If MainForm IsNot Nothing Then Controls.SetMenuManager(MainForm.Ribbon)
            If HasRibbon Then Ribbon.Visible = False
            RaiseEvent PermissionsUpdate(Nothing, New EventArgs)
        End Sub

        Protected Sub AddSubmodule(name As String, view As IModule)
            If view IsNot Nothing Then
                If Peek Is Nothing Then Peek = New Peek(ModuleName, Me)
                Peek.Add(name, view)
            End If
        End Sub

        Protected Sub RaiseDataUpdate(businessObject As Type)
            Dim e = New DataUpdateEventArgs()
            e.BusinessObjects.Add(businessObject)
            RaiseEvent DataUpdate(Me, e)
        End Sub

        Public Sub HandleDataUpdate(sender As Object, e As DataUpdateEventArgs) Implements IModule.HandleDataUpdate
            Throw New NotImplementedException()
        End Sub

        Public Sub HandlePermissionUpdate(sender As Object, e As EventArgs) Implements IModule.HandlePermissionUpdate
            Throw New NotImplementedException()
        End Sub
    End Class
End Namespace