Imports System.ComponentModel.Composition
Imports System.ComponentModel.Composition.Hosting
Imports System.Reflection

Public Class Composer

    Private container As CompositionContainer
    Public Sub New()
        Dim catalog = New AggregateCatalog()
        catalog.Catalogs.Add(New AssemblyCatalog(Assembly.GetExecutingAssembly()))
        catalog.Catalogs.Add(New DirectoryCatalog(AppDomain.CurrentDomain.BaseDirectory))
        container = New CompositionContainer(catalog)
    End Sub

    Public Sub Compose(piece As Object)
        Try
            container.ComposeParts(piece)
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

End Class

