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
        Public Property Owner As ModuleBase

        Public Sub New(caption As String, owner As ModuleBase, Optional smallImages As ImageCollection = Nothing)
            DoubleBuffered = True
            Me.Owner = owner
            Me.Padding = New Windows.Forms.Padding(5)
            SuspendLayout()
            SetupNavBar(caption, smallImages)
            ResumeLayout()
        End Sub

        Private Sub SetupNavBar(caption As String, Optional smallImages As ImageCollection = Nothing)
            N = New NavBarControl
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
            SetHandler()
        End Sub

        Public Sub Add(caption As String, view As Object, Optional imageIndex As Integer = Nothing)
            Group.ItemLinks.Add(New NavBarItem(caption) With {.Tag = view, .SmallImageIndex = imageIndex})
            FitHeight()
        End Sub

        Public Sub SetHandler()
            RemoveHandler NavBar.LinkClicked, UiManager.Instance.SubModuleSwitcher
            AddHandler NavBar.LinkClicked, UiManager.Instance.SubModuleSwitcher
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

