<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Login
    Inherits DevExpress.XtraEditors.XtraForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        Me.locNav = New DevExpress.XtraLayout.LayoutControl()
        Me.btnLogin = New DevExpress.XtraEditors.SimpleButton()
        Me.btnCancel = New DevExpress.XtraEditors.SimpleButton()
        Me.lcgNav = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.lciCancel = New DevExpress.XtraLayout.LayoutControlItem()
        Me.lciLogin = New DevExpress.XtraLayout.LayoutControlItem()
        Me.separatorNav = New DevExpress.XtraLayout.SimpleSeparator()
        Me.esNavFiller = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.imageCollection = New DevExpress.Utils.ImageCollection(Me.components)
        Me.locContent = New DevExpress.XtraLayout.LayoutControl()
        Me.ceRememberMe = New DevExpress.XtraEditors.CheckEdit()
        Me.tePassword = New DevExpress.XtraEditors.TextEdit()
        Me.teUserName = New DevExpress.XtraEditors.TextEdit()
        Me.lcgContent = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.lciUserName = New DevExpress.XtraLayout.LayoutControlItem()
        Me.lciPassword = New DevExpress.XtraLayout.LayoutControlItem()
        Me.lciRememberMe = New DevExpress.XtraLayout.LayoutControlItem()
        Me.lblLogo = New DevExpress.XtraLayout.SimpleLabelItem()
        Me.errorProvider = New DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(Me.components)
        CType(Me.locNav, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.locNav.SuspendLayout()
        CType(Me.lcgNav, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lciCancel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lciLogin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.separatorNav, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.esNavFiller, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imageCollection, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.locContent, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.locContent.SuspendLayout()
        CType(Me.ceRememberMe.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tePassword.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teUserName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lcgContent, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lciUserName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lciPassword, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lciRememberMe, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.errorProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'locNav
        '
        Me.locNav.AllowCustomization = False
        Me.locNav.CausesValidation = False
        Me.locNav.Controls.Add(Me.btnLogin)
        Me.locNav.Controls.Add(Me.btnCancel)
        Me.locNav.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.locNav.Location = New System.Drawing.Point(0, 134)
        Me.locNav.Name = "locNav"
        Me.locNav.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(653, 144, 250, 350)
        Me.locNav.Root = Me.lcgNav
        Me.locNav.Size = New System.Drawing.Size(334, 40)
        Me.locNav.TabIndex = 1
        Me.locNav.Text = "LayoutControl1"
        '
        'btnLogin
        '
        Me.btnLogin.Location = New System.Drawing.Point(129, 8)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(95, 25)
        Me.btnLogin.StyleController = Me.locNav
        Me.btnLogin.TabIndex = 0
        Me.btnLogin.Text = "&Login"
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
        Me.lcgNav.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.lciCancel, Me.lciLogin, Me.separatorNav, Me.esNavFiller})
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
        'lciLogin
        '
        Me.lciLogin.Control = Me.btnLogin
        Me.lciLogin.CustomizationFormText = "lciLogin"
        Me.lciLogin.Location = New System.Drawing.Point(114, 2)
        Me.lciLogin.MaxSize = New System.Drawing.Size(100, 31)
        Me.lciLogin.MinSize = New System.Drawing.Size(100, 31)
        Me.lciLogin.Name = "lciLogin"
        Me.lciLogin.Padding = New DevExpress.XtraLayout.Utils.Padding(5, 0, 6, 0)
        Me.lciLogin.Size = New System.Drawing.Size(100, 38)
        Me.lciLogin.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.lciLogin.TextSize = New System.Drawing.Size(0, 0)
        Me.lciLogin.TextVisible = False
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
        Me.imageCollection.Images.SetKeyName(0, "group_key.png")
        '
        'locContent
        '
        Me.locContent.AllowCustomization = False
        Me.locContent.Controls.Add(Me.ceRememberMe)
        Me.locContent.Controls.Add(Me.tePassword)
        Me.locContent.Controls.Add(Me.teUserName)
        Me.locContent.Dock = System.Windows.Forms.DockStyle.Fill
        Me.locContent.Images = Me.imageCollection
        Me.locContent.Location = New System.Drawing.Point(0, 0)
        Me.locContent.Name = "locContent"
        Me.locContent.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(638, 147, 250, 350)
        Me.locContent.OptionsView.HighlightFocusedItem = True
        Me.locContent.Root = Me.lcgContent
        Me.locContent.Size = New System.Drawing.Size(334, 134)
        Me.locContent.TabIndex = 0
        '
        'ceRememberMe
        '
        Me.ceRememberMe.Location = New System.Drawing.Point(65, 97)
        Me.ceRememberMe.Name = "ceRememberMe"
        Me.ceRememberMe.Properties.Caption = "&Remember me"
        Me.ceRememberMe.Size = New System.Drawing.Size(254, 19)
        Me.ceRememberMe.StyleController = Me.locContent
        Me.ceRememberMe.TabIndex = 4
        '
        'tePassword
        '
        Me.tePassword.Location = New System.Drawing.Point(68, 71)
        Me.tePassword.Name = "tePassword"
        Me.tePassword.Properties.MaxLength = 20
        Me.tePassword.Properties.UseSystemPasswordChar = True
        Me.tePassword.Size = New System.Drawing.Size(251, 20)
        Me.tePassword.StyleController = Me.locContent
        Me.tePassword.TabIndex = 3
        '
        'teUserName
        '
        Me.teUserName.Location = New System.Drawing.Point(68, 29)
        Me.teUserName.Name = "teUserName"
        Me.teUserName.Properties.MaxLength = 20
        Me.teUserName.Size = New System.Drawing.Size(251, 20)
        Me.teUserName.StyleController = Me.locContent
        Me.teUserName.TabIndex = 2
        '
        'lcgContent
        '
        Me.lcgContent.CustomizationFormText = "Root"
        Me.lcgContent.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.lcgContent.GroupBordersVisible = False
        Me.lcgContent.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.lciUserName, Me.lciPassword, Me.lciRememberMe, Me.lblLogo})
        Me.lcgContent.Name = "Root"
        Me.lcgContent.Size = New System.Drawing.Size(334, 134)
        Me.lcgContent.TextVisible = False
        '
        'lciUserName
        '
        Me.lciUserName.Control = Me.teUserName
        Me.lciUserName.CustomizationFormText = "&User Name"
        Me.lciUserName.Location = New System.Drawing.Point(53, 0)
        Me.lciUserName.Name = "lciUserName"
        Me.lciUserName.Padding = New DevExpress.XtraLayout.Utils.Padding(5, 5, 3, 3)
        Me.lciUserName.Size = New System.Drawing.Size(261, 42)
        Me.lciUserName.Text = "&User Name"
        Me.lciUserName.TextLocation = DevExpress.Utils.Locations.Top
        Me.lciUserName.TextSize = New System.Drawing.Size(52, 13)
        '
        'lciPassword
        '
        Me.lciPassword.Control = Me.tePassword
        Me.lciPassword.CustomizationFormText = "&Password"
        Me.lciPassword.Location = New System.Drawing.Point(53, 42)
        Me.lciPassword.Name = "lciPassword"
        Me.lciPassword.Padding = New DevExpress.XtraLayout.Utils.Padding(5, 5, 3, 3)
        Me.lciPassword.Size = New System.Drawing.Size(261, 42)
        Me.lciPassword.Text = "&Password"
        Me.lciPassword.TextLocation = DevExpress.Utils.Locations.Top
        Me.lciPassword.TextSize = New System.Drawing.Size(52, 13)
        '
        'lciRememberMe
        '
        Me.lciRememberMe.Control = Me.ceRememberMe
        Me.lciRememberMe.CustomizationFormText = "lciRememberMe"
        Me.lciRememberMe.Location = New System.Drawing.Point(53, 84)
        Me.lciRememberMe.Name = "lciRememberMe"
        Me.lciRememberMe.Padding = New DevExpress.XtraLayout.Utils.Padding(2, 5, 3, 3)
        Me.lciRememberMe.Size = New System.Drawing.Size(261, 30)
        Me.lciRememberMe.TextSize = New System.Drawing.Size(0, 0)
        Me.lciRememberMe.TextVisible = False
        '
        'lblLogo
        '
        Me.lblLogo.AllowHotTrack = False
        Me.lblLogo.CustomizationFormText = " "
        Me.lblLogo.Location = New System.Drawing.Point(0, 0)
        Me.lblLogo.MaxSize = New System.Drawing.Size(53, 17)
        Me.lblLogo.MinSize = New System.Drawing.Size(53, 17)
        Me.lblLogo.Name = "lblLogo"
        Me.lblLogo.Size = New System.Drawing.Size(53, 114)
        Me.lblLogo.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.lblLogo.Text = " "
        Me.lblLogo.TextSize = New System.Drawing.Size(52, 13)
        '
        'errorProvider
        '
        Me.errorProvider.ContainerControl = Me
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(334, 174)
        Me.Controls.Add(Me.locContent)
        Me.Controls.Add(Me.locNav)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.HelpButton = True
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Login"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        CType(Me.locNav, System.ComponentModel.ISupportInitialize).EndInit()
        Me.locNav.ResumeLayout(False)
        CType(Me.lcgNav, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lciCancel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lciLogin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.separatorNav, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.esNavFiller, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imageCollection, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.locContent, System.ComponentModel.ISupportInitialize).EndInit()
        Me.locContent.ResumeLayout(False)
        CType(Me.ceRememberMe.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tePassword.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teUserName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lcgContent, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lciUserName, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lciPassword, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lciRememberMe, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblLogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.errorProvider, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents locNav As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents btnLogin As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnCancel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents lcgNav As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents lciCancel As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents lciLogin As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents separatorNav As DevExpress.XtraLayout.SimpleSeparator
    Friend WithEvents esNavFiller As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents imageCollection As DevExpress.Utils.ImageCollection
    Friend WithEvents locContent As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents lcgContent As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents lciUserName As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents lciPassword As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents lciRememberMe As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents lblLogo As DevExpress.XtraLayout.SimpleLabelItem
    Protected WithEvents errorProvider As DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider
    Protected WithEvents ceRememberMe As DevExpress.XtraEditors.CheckEdit
    Protected WithEvents tePassword As DevExpress.XtraEditors.TextEdit
    Protected WithEvents teUserName As DevExpress.XtraEditors.TextEdit
End Class
