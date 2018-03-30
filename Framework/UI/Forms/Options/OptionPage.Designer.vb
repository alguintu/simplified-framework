<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OptionPage
    Inherits DevExpress.XtraEditors.XtraUserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(OptionPage))
        Me.imageCollection = New DevExpress.Utils.ImageCollection(Me.components)
        Me.locOptions = New DevExpress.XtraLayout.LayoutControl()
        Me.lcg = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.lblOptionPageTitle = New DevExpress.XtraLayout.SimpleLabelItem()
        Me.separatorOptionPageTitle = New DevExpress.XtraLayout.SimpleSeparator()
        Me.validator = New DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(Me.components)
        CType(Me.imageCollection, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.locOptions, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lcg, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblOptionPageTitle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.separatorOptionPageTitle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.validator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'imageCollection
        '
        Me.imageCollection.ImageSize = New System.Drawing.Size(32, 32)
        Me.imageCollection.ImageStream = CType(resources.GetObject("imageCollection.ImageStream"), DevExpress.Utils.ImageCollectionStreamer)
        '
        'locOptions
        '
        Me.locOptions.AllowCustomization = False
        Me.locOptions.Dock = System.Windows.Forms.DockStyle.Fill
        Me.locOptions.Images = Me.imageCollection
        Me.locOptions.Location = New System.Drawing.Point(0, 0)
        Me.locOptions.Name = "locOptions"
        Me.locOptions.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(692, 167, 250, 350)
        Me.locOptions.Root = Me.lcg
        Me.locOptions.Size = New System.Drawing.Size(412, 464)
        Me.locOptions.TabIndex = 5
        '
        'lcg
        '
        Me.lcg.CustomizationFormText = "Root"
        Me.lcg.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.lcg.GroupBordersVisible = False
        Me.lcg.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.lblOptionPageTitle, Me.separatorOptionPageTitle})
        Me.lcg.Location = New System.Drawing.Point(0, 0)
        Me.lcg.Name = "Root"
        Me.lcg.Padding = New DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5)
        Me.lcg.Size = New System.Drawing.Size(412, 464)
        Me.lcg.TextVisible = False
        '
        'lblOptionPageTitle
        '
        Me.lblOptionPageTitle.AllowHotTrack = False
        Me.lblOptionPageTitle.AppearanceItemCaption.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.lblOptionPageTitle.AppearanceItemCaption.Options.UseFont = True
        Me.lblOptionPageTitle.Location = New System.Drawing.Point(0, 0)
        Me.lblOptionPageTitle.Name = "lblOptionPageTitle"
        Me.lblOptionPageTitle.Size = New System.Drawing.Size(402, 23)
        Me.lblOptionPageTitle.Text = "Option Page Title"
        Me.lblOptionPageTitle.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize
        Me.lblOptionPageTitle.TextSize = New System.Drawing.Size(123, 19)
        '
        'separatorOptionPageTitle
        '
        Me.separatorOptionPageTitle.AllowHotTrack = False
        Me.separatorOptionPageTitle.Location = New System.Drawing.Point(0, 23)
        Me.separatorOptionPageTitle.Name = "separatorOptionPageTitle"
        Me.separatorOptionPageTitle.Size = New System.Drawing.Size(402, 431)
        Me.separatorOptionPageTitle.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 5)
        '
        'validator
        '
        Me.validator.ValidationMode = DevExpress.XtraEditors.DXErrorProvider.ValidationMode.[Auto]
        '
        'OptionPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.locOptions)
        Me.Name = "OptionPage"
        Me.Size = New System.Drawing.Size(412, 464)
        CType(Me.imageCollection, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.locOptions, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lcg, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblOptionPageTitle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.separatorOptionPageTitle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.validator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Protected Friend WithEvents locOptions As DevExpress.XtraLayout.LayoutControl
    Protected Friend WithEvents imageCollection As DevExpress.Utils.ImageCollection
    Protected Friend WithEvents validator As DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider
    Protected Friend WithEvents lcg As DevExpress.XtraLayout.LayoutControlGroup
    Protected Friend WithEvents separatorOptionPageTitle As DevExpress.XtraLayout.SimpleSeparator
    Protected Friend WithEvents lblOptionPageTitle As DevExpress.XtraLayout.SimpleLabelItem

End Class
