<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UpdatePassword
    Inherits DevExpress.XtraEditors.XtraForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UpdatePassword))
        Me.locNav = New DevExpress.XtraLayout.LayoutControl()
        Me.btnOK = New DevExpress.XtraEditors.SimpleButton()
        Me.btnCancel = New DevExpress.XtraEditors.SimpleButton()
        Me.lcgNav = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.lciCancel = New DevExpress.XtraLayout.LayoutControlItem()
        Me.lciOK = New DevExpress.XtraLayout.LayoutControlItem()
        Me.separatorNav = New DevExpress.XtraLayout.SimpleSeparator()
        Me.esNavFiller = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.imageCollection = New DevExpress.Utils.ImageCollection()
        Me.locChangePassword = New DevExpress.XtraLayout.LayoutControl()
        Me.teVerifyPassword = New DevExpress.XtraEditors.TextEdit()
        Me.teNewPassword = New DevExpress.XtraEditors.TextEdit()
        Me.teCurrentPassword = New DevExpress.XtraEditors.TextEdit()
        Me.lcgChangePassword = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.lciCurrentPassword = New DevExpress.XtraLayout.LayoutControlItem()
        Me.lciNewPassword = New DevExpress.XtraLayout.LayoutControlItem()
        Me.lciVerifyPassword = New DevExpress.XtraLayout.LayoutControlItem()
        Me.emptySpace = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.lblLogo = New DevExpress.XtraLayout.SimpleLabelItem()
        Me.errorProvider = New DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider()
        Me.Session = New DevExpress.Xpo.Session()
        CType(Me.locNav, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.locNav.SuspendLayout()
        CType(Me.lcgNav, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lciCancel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lciOK, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.separatorNav, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.esNavFiller, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imageCollection, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.locChangePassword, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.locChangePassword.SuspendLayout()
        CType(Me.teVerifyPassword.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teNewPassword.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teCurrentPassword.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lcgChangePassword, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lciCurrentPassword, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lciNewPassword, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lciVerifyPassword, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.emptySpace, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.errorProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Session, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'locNav
        '
        Me.locNav.AllowCustomization = False
        Me.locNav.CausesValidation = False
        Me.locNav.Controls.Add(Me.btnOK)
        Me.locNav.Controls.Add(Me.btnCancel)
        Me.locNav.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.locNav.Location = New System.Drawing.Point(0, 172)
        Me.locNav.Name = "locNav"
        Me.locNav.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(653, 144, 250, 350)
        Me.locNav.Root = Me.lcgNav
        Me.locNav.Size = New System.Drawing.Size(334, 40)
        Me.locNav.TabIndex = 1
        Me.locNav.Text = "LayoutControl1"
        '
        'btnOK
        '
        Me.btnOK.Location = New System.Drawing.Point(129, 8)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(95, 25)
        Me.btnOK.StyleController = Me.locNav
        Me.btnOK.TabIndex = 0
        Me.btnOK.Text = "&OK"
        '
        'btnCancel
        '
        Me.btnCancel.CausesValidation = False
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Location = New System.Drawing.Point(229, 8)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(95, 25)
        Me.btnCancel.StyleController = Me.locNav
        Me.btnCancel.TabIndex = 1
        Me.btnCancel.Text = "&Cancel"
        '
        'lcgNav
        '
        Me.lcgNav.CustomizationFormText = "Root"
        Me.lcgNav.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.lcgNav.GroupBordersVisible = False
        Me.lcgNav.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.lciCancel, Me.lciOK, Me.separatorNav, Me.esNavFiller})
        Me.lcgNav.Location = New System.Drawing.Point(0, 0)
        Me.lcgNav.Name = "lcgNav"
        Me.lcgNav.Padding = New DevExpress.XtraLayout.Utils.Padding(10, 10, 0, 0)
        Me.lcgNav.Size = New System.Drawing.Size(334, 40)
        Me.lcgNav.TextVisible = False
        '
        'lciCancel
        '
        Me.lciCancel.Control = Me.btnCancel
        Me.lciCancel.CustomizationFormText = "LayoutControlItem1"
        Me.lciCancel.Location = New System.Drawing.Point(214, 2)
        Me.lciCancel.MaxSize = New System.Drawing.Size(100, 31)
        Me.lciCancel.MinSize = New System.Drawing.Size(100, 31)
        Me.lciCancel.Name = "lciCancel"
        Me.lciCancel.Padding = New DevExpress.XtraLayout.Utils.Padding(5, 0, 6, 0)
        Me.lciCancel.Size = New System.Drawing.Size(100, 38)
        Me.lciCancel.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.lciCancel.TextSize = New System.Drawing.Size(0, 0)
        Me.lciCancel.TextVisible = False
        '
        'lciOK
        '
        Me.lciOK.Control = Me.btnOK
        Me.lciOK.CustomizationFormText = "lciOK"
        Me.lciOK.Location = New System.Drawing.Point(114, 2)
        Me.lciOK.MaxSize = New System.Drawing.Size(100, 31)
        Me.lciOK.MinSize = New System.Drawing.Size(100, 31)
        Me.lciOK.Name = "lciOK"
        Me.lciOK.Padding = New DevExpress.XtraLayout.Utils.Padding(5, 0, 6, 0)
        Me.lciOK.Size = New System.Drawing.Size(100, 38)
        Me.lciOK.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.lciOK.TextSize = New System.Drawing.Size(0, 0)
        Me.lciOK.TextVisible = False
        '
        'separatorNav
        '
        Me.separatorNav.AllowHotTrack = False
        Me.separatorNav.CustomizationFormText = "separatorNav"
        Me.separatorNav.Location = New System.Drawing.Point(0, 0)
        Me.separatorNav.Name = "separatorNav"
        Me.separatorNav.Size = New System.Drawing.Size(314, 2)
        '
        'esNavFiller
        '
        Me.esNavFiller.AllowHotTrack = False
        Me.esNavFiller.CustomizationFormText = "esNavFiller"
        Me.esNavFiller.Location = New System.Drawing.Point(0, 2)
        Me.esNavFiller.Name = "esNavFiller"
        Me.esNavFiller.Size = New System.Drawing.Size(114, 38)
        Me.esNavFiller.TextSize = New System.Drawing.Size(0, 0)
        '
        'imageCollection
        '
        Me.imageCollection.ImageSize = New System.Drawing.Size(32, 32)
        Me.imageCollection.ImageStream = CType(resources.GetObject("imageCollection.ImageStream"), DevExpress.Utils.ImageCollectionStreamer)
        Me.imageCollection.Images.SetKeyName(0, "server_link.png")
        Me.imageCollection.Images.SetKeyName(1, "server_connect.png")
        Me.imageCollection.Images.SetKeyName(2, "set_password.png")
        '
        'locChangePassword
        '
        Me.locChangePassword.AllowCustomization = False
        Me.locChangePassword.Controls.Add(Me.teVerifyPassword)
        Me.locChangePassword.Controls.Add(Me.teNewPassword)
        Me.locChangePassword.Controls.Add(Me.teCurrentPassword)
        Me.locChangePassword.Dock = System.Windows.Forms.DockStyle.Fill
        Me.locChangePassword.Images = Me.imageCollection
        Me.locChangePassword.Location = New System.Drawing.Point(0, 0)
        Me.locChangePassword.Name = "locChangePassword"
        Me.locChangePassword.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(638, 147, 250, 350)
        Me.locChangePassword.OptionsView.HighlightFocusedItem = True
        Me.locChangePassword.Root = Me.lcgChangePassword
        Me.locChangePassword.Size = New System.Drawing.Size(334, 172)
        Me.locChangePassword.TabIndex = 0
        '
        'teVerifyPassword
        '
        Me.teVerifyPassword.Location = New System.Drawing.Point(68, 113)
        Me.teVerifyPassword.Name = "teVerifyPassword"
        Me.teVerifyPassword.Properties.MaxLength = 20
        Me.teVerifyPassword.Properties.UseSystemPasswordChar = True
        Me.teVerifyPassword.Size = New System.Drawing.Size(256, 20)
        Me.teVerifyPassword.StyleController = Me.locChangePassword
        Me.teVerifyPassword.TabIndex = 3
        '
        'teNewPassword
        '
        Me.teNewPassword.EditValue = ""
        Me.teNewPassword.Location = New System.Drawing.Point(68, 71)
        Me.teNewPassword.Name = "teNewPassword"
        Me.teNewPassword.Properties.MaxLength = 20
        Me.teNewPassword.Properties.UseSystemPasswordChar = True
        Me.teNewPassword.Size = New System.Drawing.Size(256, 20)
        Me.teNewPassword.StyleController = Me.locChangePassword
        Me.teNewPassword.TabIndex = 2
        '
        'teCurrentPassword
        '
        Me.teCurrentPassword.EditValue = ""
        Me.teCurrentPassword.Location = New System.Drawing.Point(68, 29)
        Me.teCurrentPassword.Name = "teCurrentPassword"
        Me.teCurrentPassword.Properties.UseSystemPasswordChar = True
        Me.teCurrentPassword.Size = New System.Drawing.Size(256, 20)
        Me.teCurrentPassword.StyleController = Me.locChangePassword
        Me.teCurrentPassword.TabIndex = 1
        '
        'lcgChangePassword
        '
        Me.lcgChangePassword.AllowCustomizeChildren = False
        Me.lcgChangePassword.CustomizationFormText = "Root"
        Me.lcgChangePassword.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.lcgChangePassword.GroupBordersVisible = False
        Me.lcgChangePassword.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.lciCurrentPassword, Me.lciNewPassword, Me.lciVerifyPassword, Me.emptySpace, Me.lblLogo})
        Me.lcgChangePassword.Location = New System.Drawing.Point(0, 0)
        Me.lcgChangePassword.Name = "Root"
        Me.lcgChangePassword.Padding = New DevExpress.XtraLayout.Utils.Padding(10, 5, 10, 10)
        Me.lcgChangePassword.Size = New System.Drawing.Size(334, 172)
        Me.lcgChangePassword.TextVisible = False
        '
        'lciCurrentPassword
        '
        Me.lciCurrentPassword.Control = Me.teCurrentPassword
        Me.lciCurrentPassword.CustomizationFormText = "&Server Name"
        Me.lciCurrentPassword.Location = New System.Drawing.Point(53, 0)
        Me.lciCurrentPassword.Name = "lciCurrentPassword"
        Me.lciCurrentPassword.Padding = New DevExpress.XtraLayout.Utils.Padding(5, 5, 3, 3)
        Me.lciCurrentPassword.Size = New System.Drawing.Size(266, 42)
        Me.lciCurrentPassword.Text = "&Current Password"
        Me.lciCurrentPassword.TextLocation = DevExpress.Utils.Locations.Top
        Me.lciCurrentPassword.TextSize = New System.Drawing.Size(86, 13)
        '
        'lciNewPassword
        '
        Me.lciNewPassword.Control = Me.teNewPassword
        Me.lciNewPassword.CustomizationFormText = "&User Name"
        Me.lciNewPassword.Location = New System.Drawing.Point(53, 42)
        Me.lciNewPassword.Name = "lciNewPassword"
        Me.lciNewPassword.Padding = New DevExpress.XtraLayout.Utils.Padding(5, 5, 3, 3)
        Me.lciNewPassword.Size = New System.Drawing.Size(266, 42)
        Me.lciNewPassword.Text = "&New Password"
        Me.lciNewPassword.TextLocation = DevExpress.Utils.Locations.Top
        Me.lciNewPassword.TextSize = New System.Drawing.Size(86, 13)
        '
        'lciVerifyPassword
        '
        Me.lciVerifyPassword.Control = Me.teVerifyPassword
        Me.lciVerifyPassword.CustomizationFormText = "&Password"
        Me.lciVerifyPassword.Location = New System.Drawing.Point(53, 84)
        Me.lciVerifyPassword.Name = "lciVerifyPassword"
        Me.lciVerifyPassword.Padding = New DevExpress.XtraLayout.Utils.Padding(5, 5, 3, 3)
        Me.lciVerifyPassword.Size = New System.Drawing.Size(266, 42)
        Me.lciVerifyPassword.Text = "&Verify Password"
        Me.lciVerifyPassword.TextLocation = DevExpress.Utils.Locations.Top
        Me.lciVerifyPassword.TextSize = New System.Drawing.Size(86, 13)
        '
        'emptySpace
        '
        Me.emptySpace.AllowHotTrack = False
        Me.emptySpace.CustomizationFormText = "emptySpace"
        Me.emptySpace.Location = New System.Drawing.Point(53, 126)
        Me.emptySpace.Name = "emptySpace"
        Me.emptySpace.Size = New System.Drawing.Size(266, 26)
        Me.emptySpace.TextSize = New System.Drawing.Size(0, 0)
        '
        'lblLogo
        '
        Me.lblLogo.AllowHotTrack = False
        Me.lblLogo.CustomizationFormText = " "
        Me.lblLogo.ImageAlignment = System.Drawing.ContentAlignment.TopCenter
        Me.lblLogo.ImageIndex = 2
        Me.lblLogo.Location = New System.Drawing.Point(0, 0)
        Me.lblLogo.MaxSize = New System.Drawing.Size(53, 17)
        Me.lblLogo.MinSize = New System.Drawing.Size(53, 17)
        Me.lblLogo.Name = "lblLogo"
        Me.lblLogo.Size = New System.Drawing.Size(53, 152)
        Me.lblLogo.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.lblLogo.Text = " "
        Me.lblLogo.TextSize = New System.Drawing.Size(86, 50)
        '
        'errorProvider
        '
        Me.errorProvider.ContainerControl = Me
        '
        'Session
        '
        Me.Session.IsObjectModifiedOnNonPersistentPropertyChange = Nothing
        Me.Session.TrackPropertiesModifications = False
        '
        'UpdatePassword
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(334, 212)
        Me.Controls.Add(Me.locChangePassword)
        Me.Controls.Add(Me.locNav)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "UpdatePassword"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Change Password"
        CType(Me.locNav, System.ComponentModel.ISupportInitialize).EndInit()
        Me.locNav.ResumeLayout(False)
        CType(Me.lcgNav, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lciCancel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lciOK, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.separatorNav, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.esNavFiller, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imageCollection, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.locChangePassword, System.ComponentModel.ISupportInitialize).EndInit()
        Me.locChangePassword.ResumeLayout(False)
        CType(Me.teVerifyPassword.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teNewPassword.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teCurrentPassword.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lcgChangePassword, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lciCurrentPassword, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lciNewPassword, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lciVerifyPassword, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.emptySpace, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblLogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.errorProvider, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Session, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents locNav As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents btnOK As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnCancel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents lcgNav As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents lciCancel As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents lciOK As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents separatorNav As DevExpress.XtraLayout.SimpleSeparator
    Friend WithEvents esNavFiller As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents imageCollection As DevExpress.Utils.ImageCollection
    Friend WithEvents locChangePassword As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents lcgChangePassword As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents lciCurrentPassword As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents lciNewPassword As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents lciVerifyPassword As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents emptySpace As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents lblLogo As DevExpress.XtraLayout.SimpleLabelItem
    Protected WithEvents teVerifyPassword As DevExpress.XtraEditors.TextEdit
    Protected WithEvents teNewPassword As DevExpress.XtraEditors.TextEdit
    Protected WithEvents teCurrentPassword As DevExpress.XtraEditors.TextEdit
    Protected WithEvents Session As DevExpress.Xpo.Session
    Protected WithEvents errorProvider As DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider
End Class
