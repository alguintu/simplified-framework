Imports DevExpress.XtraEditors.DXErrorProvider

Public Module UIDXValidation
    Public Sub ClearErrors(validator As DXValidationProvider)
        Do While validator.GetInvalidControls.Count > 0
            validator.RemoveControlError(validator.GetInvalidControls(0))
        Loop
    End Sub

    Public Function IsFormValid(validator As DXValidationProvider) As Boolean
        With validator
            .Validate()
            If .GetInvalidControls.Count > 0 Then
                Return False
            End If
        End With
        Return True
    End Function
End Module
