Imports DevExpress.XtraBars.Docking
Imports System.Reflection
Imports System.Windows.Forms

Public Class CustomDockManager
    Inherits DockManager
    Private mi As MethodInfo = GetType(DockManager).GetMethod("SetRedraw", BindingFlags.Instance Or BindingFlags.NonPublic)

    Public Sub New()
        MyBase.New()
    End Sub

    Protected Overrides Sub SuspendRedraw(control As Control)
        If Not IsInitialized Then
            Return
        End If
        mi.Invoke(Me, New Object() {control, False})
        MyBase.SuspendRedraw(control)
    End Sub

    Protected Overrides Sub ResumeRedraw(control As Control)
        If Not IsInitialized Then
            Return
        End If
        mi.Invoke(Me, New Object() {control, True})
        MyBase.ResumeRedraw(control)
    End Sub
End Class