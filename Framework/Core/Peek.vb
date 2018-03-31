Imports DevExpress.Utils
Imports DevExpress.XtraEditors
Imports DevExpress.XtraNavBar
Imports Simplified.Framework.Interfaces

Namespace Core

    Public Class Peek
        Inherits XtraUserControl

        Private WithEvents N As NavBarControl

        Public ReadOnly Property NavBar As NavBarControl
            Get
                Return N
            End Get
        End Property
        Public Property Group As NavBarGroup
        Public Property Owner As ModuleGroup

        Public Sub New(caption As String, owner As ModuleGroup, modules As Dictionary(Of String, Object), Optional smallImages As ImageCollection = Nothing)
            DoubleBuffered = True
            Me.Owner = owner
            Padding = New Windows.Forms.Padding(5)
            SuspendLayout()
            SetupNavBar(caption, smallImages)
            For Each i In modules
                Add(i.Key, i.Value)
            Next
            NavBar.SelectedLink = NavBar.Items.First.Links.First
            SetHandler(owner.PeekHandler)
            ResumeLayout()
        End Sub

        Private Sub SetupNavBar(caption As String, Optional smallImages As ImageCollection = Nothing)
            N = New NavBarControl With {.LinkSelectionMode = LinkSelectionModeType.OneInControl, .SelectLinkOnPress = True}
            Group = New NavBarGroup
            N.Tag = Me
            With NavBar
                .BeginUpdate()
                .Groups.Add(Group)
                .Dock = Windows.Forms.DockStyle.Fill
                .PaintStyleKind = NavBarViewKind.NavigationPane
                .OptionsNavPane.ShowExpandButton = False
                .OptionsNavPane.ShowOverflowButton = False
                .OptionsNavPane.ShowOverflowPanel = False
                .OptionsNavPane.ShowSplitter = False
                .OptionsNavPane.AllowOptionsMenuItem = False
                .SmallImages = smallImages
                .Appearance.GroupHeader.FontSizeDelta = 2
                .NavigationPaneMaxVisibleGroups = 0
                .EndUpdate()
            End With
            With Group
                .Caption = caption
                .GroupStyle = NavBarGroupStyle.SmallIconsText
            End With
            Controls.Add(NavBar)
        End Sub

        Public Sub Add(caption As String, view As Object, Optional imageIndex As Integer = Nothing)
            Dim link As New NavBarItem(caption) With {.Tag = view, .SmallImageIndex = imageIndex}
            Group.ItemLinks.Add(link)
            FitHeight()
        End Sub

        Public Sub SetHandler(handler As NavBarLinkEventHandler)
            RemoveHandler NavBar.LinkClicked, handler
            AddHandler NavBar.LinkClicked, handler
        End Sub

        Public Sub FitHeight()
            SuspendLayout()
            Dim info = NavBar.GetViewInfo()
            info.Calc(NavBar.Bounds)
            Dim infoGroup = info.GetGroupInfo(Group)
            Height = (infoGroup.LastLinkBounds.Height * 1.5) + (infoGroup.Links.Count * infoGroup.LastLinkBounds.Height) + (Padding.All * 2)
            ResumeLayout()
        End Sub
    End Class
End Namespace

