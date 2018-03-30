Imports DevExpress.XtraBars
Imports DevExpress.Snap
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Repository

Public Class SnapZoomManager
    Private zoomControl As RepositoryItemZoomTrackBar
    Private zoomLevelCore As Integer = 0
    Private zoomBar As BarEditItem
    Private snapCore As SnapControl
    Private caption As BarStaticItem

    Public Sub New(siCaption As BarStaticItem, zoomBarEdit As BarEditItem, snap As SnapControl)
        zoomControl = zoomBarEdit.Edit
        caption = siCaption
        snapCore = snap
        zoomBar = zoomBarEdit
        AddHandler snapCore.ZoomChanged, AddressOf SnapZoomChanged
        AddHandler zoomControl.EditValueChanged, AddressOf ZoomValueChanged
    End Sub

    Private Sub SnapZoomChanged(sender As Object, e As EventArgs)
        Dim value As Single = CType(sender, SnapControl).ActiveView.ZoomFactor
        ZoomLevel = value * 100.0F
    End Sub

    Private Sub ZoomValueChanged(sender As Object, e As EventArgs)
        Dim value As Integer = CType(sender, ZoomTrackBarControl).EditValue
        value = value * 10
        SnapZoomLevel = value
        ZoomLevel = value
    End Sub

    Public Property ZoomLevel() As Integer
        Get
            Return zoomLevelCore
        End Get
        Set(ByVal value As Integer)
            If ZoomLevel = value Then
                Return
            End If
            zoomLevelCore = value
            OnZoomLevelChanged(value)
        End Set
    End Property

    Private Property SnapZoomLevel As Integer
        Get
            Return Math.Ceiling(snapCore.ActiveView.ZoomFactor * 100.0F)
        End Get
        Set(ByVal value As Integer)
            RemoveHandler snapCore.ZoomChanged, AddressOf SnapZoomChanged
            snapCore.ActiveView.ZoomFactor = (CSng(value)) / 100.0F
            AddHandler snapCore.ZoomChanged, AddressOf SnapZoomChanged
            OnZoomLevelChanged(value)
        End Set
    End Property

    Private Sub OnZoomLevelChanged(ByVal value As Integer)
        value = (value \ 10)
        RemoveHandler zoomControl.EditValueChanged, AddressOf ZoomValueChanged
        zoomBar.EditValue = value
        AddHandler zoomControl.EditValueChanged, AddressOf ZoomValueChanged
        caption.Caption = String.Format(" {0}%", ZoomLevel)
    End Sub
End Class
