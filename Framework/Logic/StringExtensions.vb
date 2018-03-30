Imports System.Runtime.CompilerServices
Imports System.Text.RegularExpressions

Namespace Logic
    Module StringExtensions
        <Extension>
        Function SeparateCamelCase(ByVal s As String) As String
            Return (New Regex("(?<=[A-Z])(?=[A-Z][a-z]) | (?<=[^A-Z])(?=[A-Z]) | (?<=[A-Za-z])(?=[^A-Za-z])", RegexOptions.IgnorePatternWhitespace)).Replace(s, " ")
        End Function

        <Extension>
        Public Function ToTitleCase(ByVal source As String) As String
            Return Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(source.ToLower())
        End Function

        <Extension>
        Public Function SplitName(ByVal source As String) As List(Of String)
            Dim names As String() = source.Split(" ")
            Dim commonAffixes() = New String() {"de", "la", "dela", "san", "el", "del", "santa"}
            SplitName = New List(Of String)
            If names.Length >= 1 Then
                Dim firstName = ""
                Dim lastName = ""
                If names.Length = 2 Then
                    firstName = names(0)
                    lastName = names(1)
                Else
                    lastName = names(names.Length - 1)
                    For i = names.Length - 2 To 0 Step -1
                        If commonAffixes.Contains(names(i).ToLower) Then
                            lastName = names(i) + " " + lastName
                        Else
                            firstName = names(i) + " " + firstName
                        End If
                    Next
                End If
                SplitName.Add(firstName.Trim.ToTitleCase)
                SplitName.Add(lastName.Trim.ToTitleCase)
            End If

            Return SplitName
        End Function

        <Extension>
        Public Function Left(ByVal str As String, ByVal length As Integer) As String
            Return str.Substring(0, length)
        End Function

        <Extension>
        Public Function Right(ByVal str As String, ByVal length As Integer) As String
            Return str.Substring(str.Length - length, length)
        End Function

    End Module

End Namespace

