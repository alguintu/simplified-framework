Namespace Events
    Public Class DataUpdateEventArgs
        Inherits EventArgs
        Public Property BusinessObjects As New List(Of Type)
        Public Property ObjectType As Type
        Public Property SingleObject As Object
    End Class
End Namespace
