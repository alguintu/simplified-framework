Imports System.Runtime.CompilerServices
Imports DevExpress.XtraEditors
Imports DevExpress.Xpo
Imports System.Windows.Forms
Imports DevExpress.Compression
Imports System.IO
Imports System.Globalization
Imports System.Collections.ObjectModel

Namespace Logic


    Module DataCommon
        <Extension>
        Public Sub FillWithYears(ByRef cbo As ComboBoxEdit, years As Integer)
            For i As Integer = Date.Now.Year To Date.Now.Year - years Step -1
                cbo.Properties.Items.Add(i.ToString)
            Next
        End Sub

        <Extension>
        Public Sub FillWithDays(ByRef combo As Object, Optional saturday As Boolean = False, Optional sunday As Boolean = False)
            For Each Day In [Enum].GetValues(GetType(DayOfWeek))
                combo.Properties.Items.Add(Day)
            Next
        End Sub

        <Extension>
        Public Sub ReloadPurgeChangedObjects(ByRef uow As UnitOfWork)
            For Each obj In uow.GetObjectsToSave
                If uow.IsNewObject(obj) Then
                    CType(obj, XPBaseObject).Delete()
                End If
            Next
            uow.ReloadChangedObjects()
        End Sub

        Public Sub CompressFile(fileName As String)
            Dim encryptionType As EncryptionType = encryptionType.PkZip
            Dim zipFilename As String = String.Format("{0}.zip", Path.GetFileNameWithoutExtension(fileName))
            Using archive As New ZipArchive()
                archive.EncryptionType = encryptionType
                archive.AddFile(fileName, "/")
                archive.Save(String.Format("{0}\{1}", Path.GetDirectoryName(fileName), zipFilename))
            End Using
        End Sub

        Public Function ListCountries() As Collection(Of String)
            Dim countryCollection As New Collection(Of String)
            Dim countryList As New SortedDictionary(Of String, String)
            For Each ci As CultureInfo In CultureInfo.GetCultures(CultureTypes.AllCultures)
                Dim ri As RegionInfo
                Try
                    ri = New RegionInfo(ci.Name)
                Catch
                    Continue For
                End Try

                Dim newKeyValuePair As New KeyValuePair(Of String, String)(ri.EnglishName, ri.ThreeLetterISORegionName)
                If Not countryList.ContainsKey(ri.EnglishName) Then
                    countryList.Add(newKeyValuePair.Key, newKeyValuePair.Value)
                    countryCollection.Add(ri.EnglishName)
                End If
            Next

            Return countryCollection
        End Function
    End Module
End Namespace