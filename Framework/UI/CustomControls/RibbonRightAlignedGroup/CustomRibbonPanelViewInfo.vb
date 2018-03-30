Imports DevExpress.XtraBars.Ribbon
Imports DevExpress.XtraBars.Ribbon.ViewInfo

Public Class CustomRibbonPanelViewInfo
    Inherits RibbonPanelViewInfo
    Public Sub New(viewInfo As RibbonViewInfo)
        MyBase.New(viewInfo)
    End Sub

    Protected Overrides Function CreateGroupViewInfo(group As RibbonPageGroup) As RibbonPageGroupViewInfo
        Return New CustomRibbonPageGroupViewInfo(ViewInfo, group)
    End Function

    Protected Overrides Function CreatePanelLayoutCalculator() As RibbonPanelLayoutCalculator
        Return New CustomRibbonPanelComplexLayoutCalculator(Me)
    End Function
End Class
