Imports DevExpress.XtraBars.Ribbon
Imports DevExpress.XtraBars.Ribbon.ViewInfo

<System.ComponentModel.DesignerCategory("")> _
    Public Class CustomRibbon
    Inherits RibbonControl

    Protected Overrides Function CreateViewInfo() As RibbonViewInfo
        Return New CustomRibbonViewInfo(Me)
    End Function
End Class
