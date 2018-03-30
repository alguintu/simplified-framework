<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReportFilterForm
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
        Me.locNav = New DevExpress.XtraLayout.LayoutControl()
        Me.btnOK = New DevExpress.XtraEditors.SimpleButton()
        Me.btnCancel = New DevExpress.XtraEditors.SimpleButton()
        Me.lcgNav = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.lciCancel = New DevExpress.XtraLayout.LayoutControlItem()
        Me.lciLogin = New DevExpress.XtraLayout.LayoutControlItem()
        Me.separatorNav = New DevExpress.XtraLayout.SimpleSeparator()
        Me.esNavFiller = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.filterControl = New DevExpress.XtraEditors.FilterControl()
        CType(Me.locNav, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.locNav.SuspendLayout()
        CType(Me.lcgNav, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lciCancel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lciLogin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.separatorNav, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.esNavFiller, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'locNav
        '
        Me.locNav.AllowCustomization = False
        Me.locNav.CausesValidation = False
        Me.locNav.Controls.Add(Me.btnOK)
        Me.locNav.Controls.Add(Me.btnCancel)
        Me.locNav.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.locNav.Location = New System.Drawing.Point(0, 225)
        Me.locNav.Name = "locNav"
        Me.locNav.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(653, 144, 250, 350)
        Me.locNav.Root = Me.lcgNav
        Me.locNav.Size = New System.Drawing.Size(374, 40)
        Me.locNav.TabIndex = 2
        Me.locNav.Text = "LayoutControl1"
        '
        'btnOK
        '
        Me.btnOK.Location = New System.Drawing.Point(169, 8)
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
        Me.btnCancel.Location = New System.Drawing.Point(269, 8)
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
        Me.lcgNav.Name = "Root"
        Me.lcgNav.Padding = New DevExpress.XtraLayout.Utils.Padding(10, 10, 0, 0)
        Me.lcgNav.Size = New System.Drawing.Size(374, 40)
        Me.lcgNav.TextVisible = False
        '
        'lciCancel
        '
        Me.lciCancel.Control = Me.btnCancel
        Me.lciCancel.CustomizationFormText = "LayoutControlItem1"
        Me.lciCancel.Location = New System.Drawing.Point(254, 2)
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
        Me.lciLogin.Control = Me.btnOK
        Me.lciLogin.CustomizationFormText = "lciLogin"
        Me.lciLogin.Location = New System.Drawing.Point(154, 2)
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
        Me.separatorNav.Size = New System.Drawing.Size(354, 2)
        Me.separatorNav.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        '
        'esNavFiller
        '
        Me.esNavFiller.AllowHotTrack = False
        Me.esNavFiller.CustomizationFormText = "esNavFiller"
        Me.esNavFiller.Location = New System.Drawing.Point(0, 2)
        Me.esNavFiller.Name = "esNavFiller"
        Me.esNavFiller.Size = New System.Drawing.Size(154, 38)
        Me.esNavFiller.TextSize = New System.Drawing.Size(0, 0)
        '
        'filterControl
        '
        Me.filterControl.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.filterControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.filterControl.Location = New System.Drawing.Point(0, 0)
        Me.filterControl.Name = "filterControl"
        Me.filterControl.Size = New System.Drawing.Size(374, 225)
        Me.filterControl.TabIndex = 5
        Me.filterControl.Text = "FilterControl1"
        '
        'ReportFilterForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(374, 265)
        Me.Controls.Add(Me.filterControl)
        Me.Controls.Add(Me.locNav)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ReportFilterForm"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Report Filter"
        CType(Me.locNav, System.ComponentModel.ISupportInitialize).EndInit()
        Me.locNav.ResumeLayout(False)
        CType(Me.lcgNav, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lciCancel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lciLogin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.separatorNav, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.esNavFiller, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents locNav As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents btnOK As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnCancel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents lcgNav As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents lciCancel As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents lciLogin As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents separatorNav As DevExpress.XtraLayout.SimpleSeparator
    Friend WithEvents esNavFiller As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents filterControl As DevExpress.XtraEditors.FilterControl
End Class
