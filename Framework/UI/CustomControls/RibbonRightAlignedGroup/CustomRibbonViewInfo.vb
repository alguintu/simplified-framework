Imports DevExpress.XtraBars.Ribbon
Imports DevExpress.XtraBars.Ribbon.ViewInfo

Public Class CustomRibbonViewInfo
    Inherits RibbonViewInfo
    Public Sub New(ribbon As RibbonControl)
        MyBase.New(ribbon)
    End Sub

    Protected Overrides Function CreatePanelInfo() As RibbonPanelViewInfo
        Return New CustomRibbonPanelViewInfo(Me)
    End Function
End Class
