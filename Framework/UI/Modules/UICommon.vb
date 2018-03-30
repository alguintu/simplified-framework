Imports DevExpress.LookAndFeel
Imports DevExpress.Skins
Imports DevExpress.Utils.Menu
Imports DevExpress.XtraBars
Imports DevExpress.XtraBars.Helpers
Imports DevExpress.XtraBars.Ribbon
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid
Imports DevExpress.XtraLayout
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports System.Windows.Forms.Control

Public Module UICommon
    Public Sub InitSkins(Optional apptheme As String = Nothing)
        WindowsFormsSettings.SetDPIAware()
        WindowsFormsSettings.AllowPixelScrolling = True
        WindowsFormsSettings.ScrollUIMode = ScrollUIMode.Touch

        If Not apptheme Is Nothing Then
            WindowsFormsSettings.DefaultLookAndFeel.SetSkinStyle(apptheme)
        End If
        DevExpress.Utils.AppearanceObject.DefaultFont = New Font("Segoe UI", 8)
    End Sub

    Public Sub InitSkinGallery(gallery As RibbonGalleryBarItem)
        SkinHelper.InitSkinGallery(gallery, True)
    End Sub

    Public Function GetSkinBorderColor(LookAndFeel As UserLookAndFeel) As Color
        Dim currentSkin As Skin = GridSkins.GetSkin(LookAndFeel.ActiveLookAndFeel)
        Dim elementName As String = GridSkins.SkinBorder
        Dim element As SkinElement = currentSkin(elementName)

        Return element.Border.All
    End Function

    Public Function GetUserColorScheme(userScheme As String) As RibbonControlColorScheme
        Dim schemes As Array
        schemes = [Enum].GetValues(GetType(RibbonControlColorScheme))

        For Each scheme As RibbonControlColorScheme In schemes
            If scheme.ToString = userScheme Then
                Return scheme
            End If
        Next
        Return Nothing
    End Function

    Public Function CenterLocation(form As Form) As Point
        Return New Point(Math.Floor(form.Owner.Location.X + (form.Owner.Width - form.Width) / 2), Math.Floor(form.Owner.Location.Y + (form.Owner.Height - form.Height) / 2))
    End Function

    Public Sub SetMenuManager(ByVal controlCollection As ControlCollection, ByVal manager As IDXMenuManager)
        For Each ctrl As Control In controlCollection
            Dim grid As GridControl = TryCast(ctrl, GridControl)
            If grid IsNot Nothing Then
                grid.MenuManager = manager
            End If
            Dim edit As BaseEdit = TryCast(ctrl, BaseEdit)
            If edit IsNot Nothing Then
                edit.MenuManager = manager
            End If
            SetMenuManager(ctrl.Controls, manager)
        Next ctrl
    End Sub

    Public Sub SplitControlHalfView(ByVal sender As Object, ByVal e As EventArgs)
        Dim split As SplitContainerControl = CType(sender, SplitContainerControl)
        split.SplitterPosition = split.RelevantDimension / 2
    End Sub


    Public Sub SplitControlTwoThirdView(ByVal sender As Object, ByVal e As EventArgs)
        Dim split As SplitContainerControl = CType(sender, SplitContainerControl)
        split.SplitterPosition = split.RelevantDimension / 3
    End Sub

    Public Sub SplitControlOneFourthView(ByVal sender As Object, ByVal e As EventArgs)
        Dim split As SplitContainerControl = CType(sender, SplitContainerControl)
        split.SplitterPosition = split.RelevantDimension / 4
    End Sub

    Public Sub SplitControlOneThirdView(ByVal sender As Object, ByVal e As EventArgs)
        Dim split As SplitContainerControl = CType(sender, SplitContainerControl)
        split.SplitterPosition = (split.RelevantDimension / 3) * 2
    End Sub

    <Extension>
    Public Function RelevantDimension(ByVal split As SplitContainerControl) As Integer
        Return If(split.Horizontal, split.Width, split.Height)
    End Function

    <Extension>
    Public Sub MakeTransparentBackground(ByVal layout As LayoutControl)
        layout.LookAndFeel.Style = LookAndFeelStyle.Flat
        layout.LookAndFeel.UseDefaultLookAndFeel = False
        layout.OptionsView.ShareLookAndFeelWithChildren = False
        layout.OptionsView.EnableTransparentBackColor = True
        layout.Root.AppearanceGroup.BackColor = Color.Transparent
        layout.Root.AppearanceGroup.Options.UseBackColor = True
        If TypeOf layout.Parent Is UserControl Then layout.Parent.BackColor = Color.Transparent
    End Sub

End Module
