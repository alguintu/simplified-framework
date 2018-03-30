<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Public Class Main
    Inherits DevExpress.XtraBars.Ribbon.RibbonForm
    ''' <summary>
    ''' Required designer variable.
    ''' </summary>
    Private components As System.ComponentModel.IContainer = Nothing

    ''' <summary>
    ''' Clean up any resources being used.
    ''' </summary>
    ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso (components IsNot Nothing) Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

#Region "Windows Form Designer generated code"

    ''' <summary>
    ''' Required method for Designer support - do not modify
    ''' the contents of this method with the code editor.
    ''' </summary>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Me.tabbedView = New DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView()
        Me.ribbonControl = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.backstageControl = New DevExpress.XtraBars.Ribbon.BackstageViewControl()
        Me.backstageAbout = New DevExpress.XtraBars.Ribbon.BackstageViewClientControl()
        Me.bstabAbout = New DevExpress.XtraBars.Ribbon.BackstageViewTabItem()
        Me.backstageSeparator1 = New DevExpress.XtraBars.Ribbon.BackstageViewItemSeparator()
        Me.bsbiExit = New DevExpress.XtraBars.Ribbon.BackstageViewButtonItem()
        Me.ribbonSmallImages = New DevExpress.Utils.ImageCollection()
        Me.employeesBarButtonItem = New DevExpress.XtraBars.BarButtonItem()
        Me.customersBarButtonItem = New DevExpress.XtraBars.BarButtonItem()
        Me.statusText = New DevExpress.XtraBars.BarStaticItem()
        Me.rgbiSkins = New DevExpress.XtraBars.SkinRibbonGalleryBarItem()
        Me.biUserName = New DevExpress.XtraBars.BarButtonItem()
        Me.siServerName = New DevExpress.XtraBars.BarStaticItem()
        Me.biBackupRestore = New DevExpress.XtraBars.BarButtonItem()
        Me.biConfigureServer = New DevExpress.XtraBars.BarButtonItem()
        Me.ribbonLargeImages = New DevExpress.Utils.ImageCollection()
        Me.rpHome = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.ribbonStatusBar = New DevExpress.XtraBars.Ribbon.RibbonStatusBar()
        Me.tooltipController = New DevExpress.Utils.ToolTipController()
        Me.navigationBar = New DevExpress.XtraBars.Navigation.OfficeNavigationBar()
        Me.navigationFrame = New DevExpress.XtraBars.Navigation.NavigationFrame()
        Me.navigationPage = New DevExpress.XtraBars.Navigation.NavigationPage()
        Me.skinRibbonGalleryBarItem = New DevExpress.XtraBars.SkinRibbonGalleryBarItem()
        Me.flyoutUser = New DevExpress.Utils.FlyoutPanel()
        Me.flyoutUserPanel = New DevExpress.Utils.FlyoutPanelControl()
        Me.layoutUserPanel = New DevExpress.XtraLayout.LayoutControl()
        Me.peUserProfile = New DevExpress.XtraEditors.PictureEdit()
        Me.lblName = New DevExpress.XtraEditors.LabelControl()
        Me.lblSwitchUser = New DevExpress.XtraEditors.LabelControl()
        Me.lblUpdateUserProfile = New DevExpress.XtraEditors.LabelControl()
        Me.lcgUserPanel = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.lciUpdateUserProfile = New DevExpress.XtraLayout.LayoutControlItem()
        Me.lciSwitchUser = New DevExpress.XtraLayout.LayoutControlItem()
        Me.flyoutseparator2 = New DevExpress.XtraLayout.SimpleSeparator()
        Me.flyoutseparator1 = New DevExpress.XtraLayout.SimpleSeparator()
        Me.lciName = New DevExpress.XtraLayout.LayoutControlItem()
        Me.lciPhoto = New DevExpress.XtraLayout.LayoutControlItem()
        Me.UnitOfWork = New DevExpress.Xpo.UnitOfWork()
        Me.popup = New DevExpress.XtraBars.PopupMenu()
        CType(Me.tabbedView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ribbonControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.backstageControl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.backstageControl.SuspendLayout()
        CType(Me.ribbonSmallImages, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ribbonLargeImages, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.navigationBar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.navigationFrame, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.navigationFrame.SuspendLayout()
        CType(Me.flyoutUser, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.flyoutUser.SuspendLayout()
        CType(Me.flyoutUserPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.flyoutUserPanel.SuspendLayout()
        CType(Me.layoutUserPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.layoutUserPanel.SuspendLayout()
        CType(Me.peUserProfile.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lcgUserPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lciUpdateUserProfile, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lciSwitchUser, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.flyoutseparator2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.flyoutseparator1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lciName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lciPhoto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UnitOfWork, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.popup, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tabbedView
        '
        Me.tabbedView.RootContainer.Element = Nothing
        '
        'ribbonControl
        '
        Me.ribbonControl.ApplicationButtonDropDownControl = Me.backstageControl
        Me.ribbonControl.ColorScheme = DevExpress.XtraBars.Ribbon.RibbonControlColorScheme.Teal
        Me.ribbonControl.ExpandCollapseItem.Id = 0
        Me.ribbonControl.Images = Me.ribbonSmallImages
        Me.ribbonControl.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.ribbonControl.ExpandCollapseItem, Me.employeesBarButtonItem, Me.customersBarButtonItem, Me.statusText, Me.rgbiSkins, Me.biUserName, Me.siServerName, Me.biBackupRestore, Me.biConfigureServer})
        Me.ribbonControl.LargeImages = Me.ribbonLargeImages
        Me.ribbonControl.Location = New System.Drawing.Point(0, 0)
        Me.ribbonControl.MaxItemId = 53
        Me.ribbonControl.MdiMergeStyle = DevExpress.XtraBars.Ribbon.RibbonMdiMergeStyle.Always
        Me.ribbonControl.Name = "ribbonControl"
        Me.ribbonControl.PageHeaderItemLinks.Add(Me.rgbiSkins)
        Me.ribbonControl.PageHeaderItemLinks.Add(Me.ribbonControl.ExpandCollapseItem)
        Me.ribbonControl.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.rpHome})
        Me.ribbonControl.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2010
        Me.ribbonControl.Size = New System.Drawing.Size(784, 143)
        Me.ribbonControl.StatusBar = Me.ribbonStatusBar
        Me.ribbonControl.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden
        Me.ribbonControl.ToolTipController = Me.tooltipController
        '
        'backstageControl
        '
        Me.backstageControl.Controls.Add(Me.backstageAbout)
        Me.backstageControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.backstageControl.Items.Add(Me.bstabAbout)
        Me.backstageControl.Items.Add(Me.backstageSeparator1)
        Me.backstageControl.Items.Add(Me.bsbiExit)
        Me.backstageControl.Location = New System.Drawing.Point(0, 0)
        Me.backstageControl.Name = "backstageControl"
        Me.backstageControl.OwnerControl = Me.ribbonControl
        Me.backstageControl.Size = New System.Drawing.Size(784, 380)
        Me.backstageControl.TabIndex = 0
        Me.backstageControl.Visible = False
        '
        'backstageAbout
        '
        Me.backstageAbout.Location = New System.Drawing.Point(132, 0)
        Me.backstageAbout.Name = "backstageAbout"
        Me.backstageAbout.Size = New System.Drawing.Size(638, 380)
        Me.backstageAbout.TabIndex = 1
        '
        'bstabAbout
        '
        Me.bstabAbout.Caption = "About"
        Me.bstabAbout.ContentControl = Me.backstageAbout
        Me.bstabAbout.Name = "bstabAbout"
        '
        'backstageSeparator1
        '
        Me.backstageSeparator1.Name = "backstageSeparator1"
        '
        'bsbiExit
        '
        Me.bsbiExit.Caption = "Exit"
        Me.bsbiExit.Glyph = CType(resources.GetObject("bsbiExit.Glyph"), System.Drawing.Image)
        Me.bsbiExit.Name = "bsbiExit"
        '
        'ribbonSmallImages
        '
        Me.ribbonSmallImages.ImageStream = CType(resources.GetObject("ribbonSmallImages.ImageStream"), DevExpress.Utils.ImageCollectionStreamer)
        Me.ribbonSmallImages.InsertGalleryImage("properties_16x16.png", "images/setup/properties_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/setup/properties_16x16.png"), 0)
        Me.ribbonSmallImages.Images.SetKeyName(0, "properties_16x16.png")
        Me.ribbonSmallImages.InsertGalleryImage("close_16x16.png", "images/actions/close_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/actions/close_16x16.png"), 1)
        Me.ribbonSmallImages.Images.SetKeyName(1, "close_16x16.png")
        Me.ribbonSmallImages.InsertGalleryImage("database_16x16.png", "images/data/database_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/data/database_16x16.png"), 2)
        Me.ribbonSmallImages.Images.SetKeyName(2, "database_16x16.png")
        Me.ribbonSmallImages.InsertGalleryImage("employee_16x16.png", "images/people/employee_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/people/employee_16x16.png"), 3)
        Me.ribbonSmallImages.Images.SetKeyName(3, "employee_16x16.png")
        Me.ribbonSmallImages.InsertGalleryImage("editcontact_16x16.png", "images/mail/editcontact_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/mail/editcontact_16x16.png"), 4)
        Me.ribbonSmallImages.Images.SetKeyName(4, "editcontact_16x16.png")
        Me.ribbonSmallImages.InsertGalleryImage("changedatasourcepivottable_16x16.png", "images/spreadsheet/changedatasourcepivottable_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/spreadsheet/changedatasourcepivottable_16x16.png"), 5)
        Me.ribbonSmallImages.Images.SetKeyName(5, "changedatasourcepivottable_16x16.png")
        Me.ribbonSmallImages.InsertGalleryImage("managedatasource_16x16.png", "images/data/managedatasource_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/data/managedatasource_16x16.png"), 6)
        Me.ribbonSmallImages.Images.SetKeyName(6, "managedatasource_16x16.png")
        '
        'employeesBarButtonItem
        '
        Me.employeesBarButtonItem.Caption = "Employees"
        Me.employeesBarButtonItem.Id = 44
        Me.employeesBarButtonItem.Name = "employeesBarButtonItem"
        '
        'customersBarButtonItem
        '
        Me.customersBarButtonItem.Caption = "Customers"
        Me.customersBarButtonItem.Id = 45
        Me.customersBarButtonItem.Name = "customersBarButtonItem"
        '
        'statusText
        '
        Me.statusText.Caption = "Ready"
        Me.statusText.Id = 46
        Me.statusText.Name = "statusText"
        '
        'rgbiSkins
        '
        Me.rgbiSkins.Id = 48
        Me.rgbiSkins.Name = "rgbiSkins"
        '
        'biUserName
        '
        Me.biUserName.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.biUserName.Id = 49
        Me.biUserName.ImageOptions.ImageIndex = 3
        Me.biUserName.MergeOrder = 98
        Me.biUserName.Name = "biUserName"
        '
        'siServerName
        '
        Me.siServerName.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.siServerName.Caption = "MySQL"
        Me.siServerName.Id = 50
        Me.siServerName.ImageOptions.ImageIndex = 2
        Me.siServerName.MergeOrder = 99
        Me.siServerName.Name = "siServerName"
        '
        'biBackupRestore
        '
        Me.biBackupRestore.Caption = "Backup/Restore Database"
        Me.biBackupRestore.Id = 51
        Me.biBackupRestore.ImageOptions.ImageIndex = 5
        Me.biBackupRestore.Name = "biBackupRestore"
        '
        'biConfigureServer
        '
        Me.biConfigureServer.Caption = "Configure Database Connection"
        Me.biConfigureServer.Id = 52
        Me.biConfigureServer.ImageOptions.ImageIndex = 6
        Me.biConfigureServer.Name = "biConfigureServer"
        '
        'ribbonLargeImages
        '
        Me.ribbonLargeImages.ImageSize = New System.Drawing.Size(32, 32)
        Me.ribbonLargeImages.ImageStream = CType(resources.GetObject("ribbonLargeImages.ImageStream"), DevExpress.Utils.ImageCollectionStreamer)
        '
        'rpHome
        '
        Me.rpHome.MergeOrder = 1
        Me.rpHome.Name = "rpHome"
        Me.rpHome.Text = "Home"
        '
        'ribbonStatusBar
        '
        Me.ribbonStatusBar.ItemLinks.Add(Me.statusText)
        Me.ribbonStatusBar.ItemLinks.Add(Me.biUserName, True)
        Me.ribbonStatusBar.ItemLinks.Add(Me.siServerName, True)
        Me.ribbonStatusBar.Location = New System.Drawing.Point(0, 568)
        Me.ribbonStatusBar.Name = "ribbonStatusBar"
        Me.ribbonStatusBar.Ribbon = Me.ribbonControl
        Me.ribbonStatusBar.Size = New System.Drawing.Size(784, 31)
        Me.ribbonStatusBar.ToolTipController = Me.tooltipController
        '
        'navigationBar
        '
        Me.navigationBar.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.navigationBar.Location = New System.Drawing.Point(0, 523)
        Me.navigationBar.Name = "navigationBar"
        Me.navigationBar.Size = New System.Drawing.Size(784, 45)
        Me.navigationBar.TabIndex = 1
        Me.navigationBar.Text = "officeNavigationBar"
        '
        'navigationFrame
        '
        Me.navigationFrame.AllowTransitionAnimation = DevExpress.Utils.DefaultBoolean.[False]
        Me.navigationFrame.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.navigationFrame.Appearance.Options.UseBackColor = True
        Me.navigationFrame.Controls.Add(Me.backstageControl)
        Me.navigationFrame.Dock = System.Windows.Forms.DockStyle.Fill
        Me.navigationFrame.Location = New System.Drawing.Point(0, 143)
        Me.navigationFrame.Name = "navigationFrame"
        Me.navigationFrame.RibbonAndBarsMergeStyle = DevExpress.XtraBars.Docking2010.Views.RibbonAndBarsMergeStyle.Always
        Me.navigationFrame.SelectedPage = Nothing
        Me.navigationFrame.Size = New System.Drawing.Size(784, 380)
        Me.navigationFrame.TabIndex = 0
        Me.navigationFrame.Text = "navigationFrame"
        Me.navigationFrame.TransitionAnimationProperties.FrameInterval = 2000
        Me.navigationFrame.TransitionType = DevExpress.Utils.Animation.Transitions.Push
        '
        'navigationPage
        '
        Me.navigationPage.Caption = "navigationPage"
        Me.navigationPage.Name = "navigationPage"
        Me.navigationPage.Size = New System.Drawing.Size(790, 380)
        '
        'skinRibbonGalleryBarItem
        '
        Me.skinRibbonGalleryBarItem.Id = 14
        Me.skinRibbonGalleryBarItem.Name = "skinRibbonGalleryBarItem"
        '
        'flyoutUser
        '
        Me.flyoutUser.Controls.Add(Me.flyoutUserPanel)
        Me.flyoutUser.Location = New System.Drawing.Point(270, 169)
        Me.flyoutUser.Name = "flyoutUser"
        Me.flyoutUser.Options.AnimationType = DevExpress.Utils.Win.PopupToolWindowAnimation.Fade
        Me.flyoutUser.Options.CloseOnOuterClick = True
        Me.flyoutUser.OptionsBeakPanel.BeakLocation = DevExpress.Utils.BeakPanelBeakLocation.Bottom
        Me.flyoutUser.OwnerControl = Me
        Me.flyoutUser.Size = New System.Drawing.Size(250, 260)
        Me.flyoutUser.TabIndex = 7
        '
        'flyoutUserPanel
        '
        Me.flyoutUserPanel.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.flyoutUserPanel.Controls.Add(Me.layoutUserPanel)
        Me.flyoutUserPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.flyoutUserPanel.FlyoutPanel = Me.flyoutUser
        Me.flyoutUserPanel.Location = New System.Drawing.Point(0, 0)
        Me.flyoutUserPanel.Name = "flyoutUserPanel"
        Me.flyoutUserPanel.Size = New System.Drawing.Size(250, 260)
        Me.flyoutUserPanel.TabIndex = 0
        '
        'layoutUserPanel
        '
        Me.layoutUserPanel.AllowCustomization = False
        Me.layoutUserPanel.Controls.Add(Me.peUserProfile)
        Me.layoutUserPanel.Controls.Add(Me.lblName)
        Me.layoutUserPanel.Controls.Add(Me.lblSwitchUser)
        Me.layoutUserPanel.Controls.Add(Me.lblUpdateUserProfile)
        Me.layoutUserPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.layoutUserPanel.Location = New System.Drawing.Point(0, 0)
        Me.layoutUserPanel.Name = "layoutUserPanel"
        Me.layoutUserPanel.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(566, 266, 250, 350)
        Me.layoutUserPanel.OptionsView.AllowHotTrack = True
        Me.layoutUserPanel.Root = Me.lcgUserPanel
        Me.layoutUserPanel.Size = New System.Drawing.Size(250, 260)
        Me.layoutUserPanel.TabIndex = 0
        '
        'peUserProfile
        '
        Me.peUserProfile.Cursor = System.Windows.Forms.Cursors.Default
        Me.peUserProfile.Location = New System.Drawing.Point(62, 12)
        Me.peUserProfile.MenuManager = Me.ribbonControl
        Me.peUserProfile.Name = "peUserProfile"
        Me.peUserProfile.Properties.AllowFocused = False
        Me.peUserProfile.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.peUserProfile.Properties.Appearance.Options.UseBackColor = True
        Me.peUserProfile.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.peUserProfile.Properties.NullText = " "
        Me.peUserProfile.Properties.OptionsMask.MaskType = DevExpress.XtraEditors.Controls.PictureEditMaskType.Circle
        Me.peUserProfile.Properties.ShowMenu = False
        Me.peUserProfile.Properties.ShowZoomSubMenu = DevExpress.Utils.DefaultBoolean.[False]
        Me.peUserProfile.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom
        Me.peUserProfile.Size = New System.Drawing.Size(126, 142)
        Me.peUserProfile.StyleController = Me.layoutUserPanel
        Me.peUserProfile.TabIndex = 9
        '
        'lblName
        '
        Me.lblName.Appearance.Font = New System.Drawing.Font("Tahoma", 11.0!)
        Me.lblName.Appearance.Options.UseFont = True
        Me.lblName.Appearance.Options.UseTextOptions = True
        Me.lblName.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.lblName.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lblName.Location = New System.Drawing.Point(12, 158)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(226, 18)
        Me.lblName.StyleController = Me.layoutUserPanel
        Me.lblName.TabIndex = 8
        Me.lblName.Text = "Current User"
        '
        'lblSwitchUser
        '
        Me.lblSwitchUser.Appearance.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblSwitchUser.Appearance.ImageIndex = 3
        Me.lblSwitchUser.Appearance.ImageList = Me.ribbonSmallImages
        Me.lblSwitchUser.Appearance.Options.UseImageAlign = True
        Me.lblSwitchUser.Appearance.Options.UseImageIndex = True
        Me.lblSwitchUser.Appearance.Options.UseImageList = True
        Me.lblSwitchUser.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lblSwitchUser.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.lblSwitchUser.Location = New System.Drawing.Point(12, 180)
        Me.lblSwitchUser.Name = "lblSwitchUser"
        Me.lblSwitchUser.Padding = New System.Windows.Forms.Padding(5)
        Me.lblSwitchUser.Size = New System.Drawing.Size(226, 30)
        Me.lblSwitchUser.StyleController = Me.layoutUserPanel
        Me.lblSwitchUser.TabIndex = 6
        Me.lblSwitchUser.Text = "Switch user"
        '
        'lblUpdateUserProfile
        '
        Me.lblUpdateUserProfile.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.lblUpdateUserProfile.Appearance.ImageIndex = 4
        Me.lblUpdateUserProfile.Appearance.ImageList = Me.ribbonSmallImages
        Me.lblUpdateUserProfile.Appearance.Options.UseBackColor = True
        Me.lblUpdateUserProfile.Appearance.Options.UseImageIndex = True
        Me.lblUpdateUserProfile.Appearance.Options.UseImageList = True
        Me.lblUpdateUserProfile.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lblUpdateUserProfile.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.lblUpdateUserProfile.Location = New System.Drawing.Point(12, 216)
        Me.lblUpdateUserProfile.Name = "lblUpdateUserProfile"
        Me.lblUpdateUserProfile.Padding = New System.Windows.Forms.Padding(5)
        Me.lblUpdateUserProfile.Size = New System.Drawing.Size(226, 30)
        Me.lblUpdateUserProfile.StyleController = Me.layoutUserPanel
        Me.lblUpdateUserProfile.TabIndex = 5
        Me.lblUpdateUserProfile.Text = "Update user profile"
        '
        'lcgUserPanel
        '
        Me.lcgUserPanel.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.lcgUserPanel.GroupBordersVisible = False
        Me.lcgUserPanel.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.lciUpdateUserProfile, Me.lciSwitchUser, Me.flyoutseparator2, Me.flyoutseparator1, Me.lciName, Me.lciPhoto})
        Me.lcgUserPanel.Name = "Root"
        Me.lcgUserPanel.Size = New System.Drawing.Size(250, 260)
        Me.lcgUserPanel.TextVisible = False
        '
        'lciUpdateUserProfile
        '
        Me.lciUpdateUserProfile.Control = Me.lblUpdateUserProfile
        Me.lciUpdateUserProfile.Location = New System.Drawing.Point(0, 204)
        Me.lciUpdateUserProfile.Name = "lciUpdateUserProfile"
        Me.lciUpdateUserProfile.Size = New System.Drawing.Size(230, 34)
        Me.lciUpdateUserProfile.TextSize = New System.Drawing.Size(0, 0)
        Me.lciUpdateUserProfile.TextVisible = False
        '
        'lciSwitchUser
        '
        Me.lciSwitchUser.Control = Me.lblSwitchUser
        Me.lciSwitchUser.Location = New System.Drawing.Point(0, 168)
        Me.lciSwitchUser.Name = "lciSwitchUser"
        Me.lciSwitchUser.Size = New System.Drawing.Size(230, 34)
        Me.lciSwitchUser.TextSize = New System.Drawing.Size(0, 0)
        Me.lciSwitchUser.TextVisible = False
        '
        'flyoutseparator2
        '
        Me.flyoutseparator2.AllowHotTrack = False
        Me.flyoutseparator2.CustomizationFormText = " "
        Me.flyoutseparator2.Location = New System.Drawing.Point(0, 238)
        Me.flyoutseparator2.Name = "flyoutseparator2"
        Me.flyoutseparator2.Size = New System.Drawing.Size(230, 2)
        Me.flyoutseparator2.Text = " "
        '
        'flyoutseparator1
        '
        Me.flyoutseparator1.AllowHotTrack = False
        Me.flyoutseparator1.CustomizationFormText = " "
        Me.flyoutseparator1.Location = New System.Drawing.Point(0, 202)
        Me.flyoutseparator1.Name = "flyoutseparator1"
        Me.flyoutseparator1.Size = New System.Drawing.Size(230, 2)
        Me.flyoutseparator1.Text = " "
        '
        'lciName
        '
        Me.lciName.AllowHotTrack = False
        Me.lciName.Control = Me.lblName
        Me.lciName.Location = New System.Drawing.Point(0, 146)
        Me.lciName.Name = "lciName"
        Me.lciName.Size = New System.Drawing.Size(230, 22)
        Me.lciName.TextSize = New System.Drawing.Size(0, 0)
        Me.lciName.TextVisible = False
        '
        'lciPhoto
        '
        Me.lciPhoto.AllowHotTrack = False
        Me.lciPhoto.Control = Me.peUserProfile
        Me.lciPhoto.Location = New System.Drawing.Point(0, 0)
        Me.lciPhoto.Name = "lciPhoto"
        Me.lciPhoto.Size = New System.Drawing.Size(230, 146)
        Me.lciPhoto.Spacing = New DevExpress.XtraLayout.Utils.Padding(50, 50, 0, 0)
        Me.lciPhoto.Text = "Photo"
        Me.lciPhoto.TextSize = New System.Drawing.Size(0, 0)
        Me.lciPhoto.TextVisible = False
        '
        'UnitOfWork
        '
        Me.UnitOfWork.IsObjectModifiedOnNonPersistentPropertyChange = Nothing
        Me.UnitOfWork.TrackPropertiesModifications = False
        '
        'popup
        '
        Me.popup.ItemLinks.Add(Me.biBackupRestore)
        Me.popup.ItemLinks.Add(Me.biConfigureServer, True)
        Me.popup.Name = "popup"
        Me.popup.Ribbon = Me.ribbonControl
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 599)
        Me.Controls.Add(Me.flyoutUser)
        Me.Controls.Add(Me.navigationFrame)
        Me.Controls.Add(Me.navigationBar)
        Me.Controls.Add(Me.ribbonStatusBar)
        Me.Controls.Add(Me.ribbonControl)
        Me.Name = "Main"
        Me.Ribbon = Me.ribbonControl
        Me.ShowIcon = False
        Me.StatusBar = Me.ribbonStatusBar
        Me.Text = "App"
        CType(Me.tabbedView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ribbonControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.backstageControl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.backstageControl.ResumeLayout(False)
        CType(Me.ribbonSmallImages, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ribbonLargeImages, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.navigationBar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.navigationFrame, System.ComponentModel.ISupportInitialize).EndInit()
        Me.navigationFrame.ResumeLayout(False)
        CType(Me.flyoutUser, System.ComponentModel.ISupportInitialize).EndInit()
        Me.flyoutUser.ResumeLayout(False)
        CType(Me.flyoutUserPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.flyoutUserPanel.ResumeLayout(False)
        CType(Me.layoutUserPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.layoutUserPanel.ResumeLayout(False)
        CType(Me.peUserProfile.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lcgUserPanel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lciUpdateUserProfile, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lciSwitchUser, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.flyoutseparator2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.flyoutseparator1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lciName, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lciPhoto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UnitOfWork, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.popup, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region
    Private WithEvents tabbedView As DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView
    Private WithEvents ribbonControl As DevExpress.XtraBars.Ribbon.RibbonControl
    Private WithEvents ribbonStatusBar As DevExpress.XtraBars.Ribbon.RibbonStatusBar
    Private WithEvents navigationBar As DevExpress.XtraBars.Navigation.OfficeNavigationBar
    Private WithEvents employeesBarButtonItem As DevExpress.XtraBars.BarButtonItem
    Private WithEvents customersBarButtonItem As DevExpress.XtraBars.BarButtonItem
    Private WithEvents navigationFrame As DevExpress.XtraBars.Navigation.NavigationFrame
    Friend WithEvents navigationPage As DevExpress.XtraBars.Navigation.NavigationPage
    Friend WithEvents rpHome As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents statusText As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents backstageControl As DevExpress.XtraBars.Ribbon.BackstageViewControl
    Friend WithEvents backstageAbout As DevExpress.XtraBars.Ribbon.BackstageViewClientControl
    Friend WithEvents bstabAbout As DevExpress.XtraBars.Ribbon.BackstageViewTabItem
    Friend WithEvents backstageSeparator1 As DevExpress.XtraBars.Ribbon.BackstageViewItemSeparator
    Friend WithEvents bsbiExit As DevExpress.XtraBars.Ribbon.BackstageViewButtonItem
    Friend WithEvents ribbonSmallImages As DevExpress.Utils.ImageCollection
    Friend WithEvents ribbonLargeImages As DevExpress.Utils.ImageCollection
    Friend WithEvents tooltipController As DevExpress.Utils.ToolTipController
    Private WithEvents skinRibbonGalleryBarItem As DevExpress.XtraBars.SkinRibbonGalleryBarItem
    Friend WithEvents rgbiSkins As DevExpress.XtraBars.SkinRibbonGalleryBarItem
    Friend WithEvents biUserName As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents siServerName As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents flyoutUser As DevExpress.Utils.FlyoutPanel
    Friend WithEvents flyoutUserPanel As DevExpress.Utils.FlyoutPanelControl
    Friend WithEvents layoutUserPanel As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents peUserProfile As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents lblName As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblSwitchUser As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblUpdateUserProfile As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lcgUserPanel As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents lciUpdateUserProfile As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents lciSwitchUser As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents flyoutseparator2 As DevExpress.XtraLayout.SimpleSeparator
    Friend WithEvents flyoutseparator1 As DevExpress.XtraLayout.SimpleSeparator
    Friend WithEvents lciName As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents lciPhoto As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents UnitOfWork As DevExpress.Xpo.UnitOfWork
    Friend WithEvents biBackupRestore As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents biConfigureServer As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents popup As DevExpress.XtraBars.PopupMenu
End Class
