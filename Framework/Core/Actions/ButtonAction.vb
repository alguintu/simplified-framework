Imports System.Windows.Forms
Imports DevExpress.XtraBars

Namespace Core.Actions
    Public Class BarItemAction

        Inherits ActionBase

        Public Sub New(name As String, ByRef control As BarButtonItem, t As ItemClickEventHandler, Optional permission As Integer = 0, Optional restrict As Boolean = False)
            MyBase.New(name, control, permission, restrict)
            AddHandler CType(C, BarButtonItem).ItemClick, t
        End Sub

        Public Overloads ReadOnly Property Control As BarButtonItem
            Get
                Return CType(C, BarButtonItem)
            End Get
        End Property
    End Class

End Namespace
