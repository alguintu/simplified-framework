Imports System.Windows.Forms

Namespace Core.Actions
    Public MustInherit Class ActionBase

        Protected WithEvents C As Object
        Public Property Control
        Public Property Permission As Integer
        Public Property Name As String
        Public Property Restrictable As Boolean


        Sub New(name As String, control As Object, Optional permission As Integer = 0, Optional restrict As Boolean = False)
            C = control
            Me.Permission = permission
            Me.Name = name
            Restrictable = restrict
        End Sub

    End Class

End Namespace
