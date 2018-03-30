Imports System.Drawing
Imports DevExpress.XtraBars.Ribbon
Imports DevExpress.XtraBars.Ribbon.ViewInfo

Public Class CustomRibbonPageGroupViewInfo
    Inherits RibbonPageGroupViewInfo

    Public Sub New(viewInfo As RibbonViewInfo, group As RibbonPageGroup)
        MyBase.New(viewInfo, group)
    End Sub

    Public Overrides Sub CalcViewInfo(bounds As Rectangle)
        If Object.Equals(PageGroup.Tag, "AlignRight") Then
            Dim offset As Integer = ViewInfo.Bounds.Right - bounds.Right
            If offset > 5 Then
                bounds.Offset(offset, 0)
            End If
        End If
        MyBase.CalcViewInfo(bounds)
    End Sub
End Class
