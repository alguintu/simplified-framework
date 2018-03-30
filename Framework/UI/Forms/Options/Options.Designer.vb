<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Options
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Options))
        Me.locNav = New DevExpress.XtraLayout.LayoutControl()
        Me.btnOK = New DevExpress.XtraEditors.SimpleButton()
        Me.btnCancel = New DevExpress.XtraEditors.SimpleButton()
        Me.lcgNav = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.lciCancel = New DevExpress.XtraLayout.LayoutControlItem()
        Me.lciOK = New DevExpress.XtraLayout.LayoutControlItem()
        Me.esNavFiller = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.UnitOfWork = New DevExpress.Xpo.UnitOfWork()
        Me.accordion = New DevExpress.XtraBars.Navigation.AccordionControl()
        Me.panelCategories = New DevExpress.XtraEditors.PanelControl()
        Me.panelAccordion = New DevExpress.XtraEditors.PanelControl()
        Me.panelWorkspace = New DevExpress.XtraEditors.PanelControl()
        Me.panelPages = New DevExpress.XtraEditors.PanelControl()
        CType(Me.locNav, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.locNav.SuspendLayout()
        CType(Me.lcgNav, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lciCancel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lciOK, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.esNavFiller, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UnitOfWork, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.accordion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.panelCategories, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelCategories.SuspendLayout()
        CType(Me.panelAccordion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelAccordion.SuspendLayout()
        CType(Me.panelWorkspace, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelWorkspace.SuspendLayout()
        CType(Me.panelPages, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'locNav
        '
        Me.locNav.AllowCustomization = False
        Me.locNav.CausesValidation = False
        Me.locNav.Controls.Add(Me.btnOK)
        Me.locNav.Controls.Add(Me.btnCancel)
        Me.locNav.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.locNav.Location = New System.Drawing.Point(0, 521)
        Me.locNav.Name = "locNav"
        Me.locNav.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(756, 99, 250, 350)
        Me.locNav.Root = Me.lcgNav
        Me.locNav.Size = New System.Drawing.Size(684, 40)
        Me.locNav.TabIndex = 3
        Me.locNav.Text = "LayoutControl1"
        '
        'btnOK
        '
        Me.btnOK.Location = New System.Drawing.Point(479, 6)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(95, 25)
        Me.btnOK.StyleController = Me.locNav
        Me.btnOK.TabIndex = 1
        Me.btnOK.Text = "&OK"
        '
        'btnCancel
        '
        Me.btnCancel.CausesValidation = False
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Location = New System.Drawing.Point(579, 6)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(95, 25)
        Me.btnCancel.StyleController = Me.locNav
        Me.btnCancel.TabIndex = 2
        Me.btnCancel.Text = "&Cancel"
        '
        'lcgNav
        '
        Me.lcgNav.CustomizationFormText = "Root"
        Me.lcgNav.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.lcgNav.GroupBordersVisible = False
        Me.lcgNav.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.lciCancel, Me.lciOK, Me.esNavFiller})
        Me.lcgNav.Name = "Root"
        Me.lcgNav.Padding = New DevExpress.XtraLayout.Utils.Padding(10, 10, 0, 0)
        Me.lcgNav.Size = New System.Drawing.Size(684, 40)
        Me.lcgNav.TextVisible = False
        '
        'lciCancel
        '
        Me.lciCancel.Control = Me.btnCancel
        Me.lciCancel.CustomizationFormText = "LayoutControlItem1"
        Me.lciCancel.Location = New System.Drawing.Point(564, 0)
        Me.lciCancel.MaxSize = New System.Drawing.Size(100, 31)
        Me.lciCancel.MinSize = New System.Drawing.Size(100, 31)
        Me.lciCancel.Name = "lciCancel"
        Me.lciCancel.Padding = New DevExpress.XtraLayout.Utils.Padding(5, 0, 6, 0)
        Me.lciCancel.Size = New System.Drawing.Size(100, 40)
        Me.lciCancel.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.lciCancel.TextSize = New System.Drawing.Size(0, 0)
        Me.lciCancel.TextVisible = False
        '
        'lciOK
        '
        Me.lciOK.Control = Me.btnOK
        Me.lciOK.CustomizationFormText = "lciOK"
        Me.lciOK.Location = New System.Drawing.Point(464, 0)
        Me.lciOK.MaxSize = New System.Drawing.Size(100, 31)
        Me.lciOK.MinSize = New System.Drawing.Size(100, 31)
        Me.lciOK.Name = "lciOK"
        Me.lciOK.Padding = New DevExpress.XtraLayout.Utils.Padding(5, 0, 6, 0)
        Me.lciOK.Size = New System.Drawing.Size(100, 40)
        Me.lciOK.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.lciOK.TextSize = New System.Drawing.Size(0, 0)
        Me.lciOK.TextVisible = False
        '
        'esNavFiller
        '
        Me.esNavFiller.AllowHotTrack = False
        Me.esNavFiller.CustomizationFormText = "esNavFiller"
        Me.esNavFiller.Location = New System.Drawing.Point(0, 0)
        Me.esNavFiller.Name = "esNavFiller"
        Me.esNavFiller.Size = New System.Drawing.Size(464, 40)
        Me.esNavFiller.TextSize = New System.Drawing.Size(0, 0)
        '
        'UnitOfWork
        '
        Me.UnitOfWork.IsObjectModifiedOnNonPersistentPropertyChange = Nothing
        Me.UnitOfWork.TrackPropertiesModifications = False
        '
        'accordion
        '
        Me.accordion.AllowItemSelection = True
        Me.accordion.AnimationType = DevExpress.XtraBars.Navigation.AnimationType.None
        Me.accordion.Appearance.AccordionControl.BackColor = System.Drawing.Color.White
        Me.accordion.Appearance.AccordionControl.Options.UseBackColor = True
        Me.accordion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.accordion.ItemHeight = 35
        Me.accordion.Location = New System.Drawing.Point(2, 2)
        Me.accordion.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat
        Me.accordion.Name = "accordion"
        Me.accordion.ScrollBarMode = DevExpress.XtraBars.Navigation.ScrollBarMode.Hidden
        Me.accordion.ShowGroupExpandButtons = False
        Me.accordion.Size = New System.Drawing.Size(140, 502)
        Me.accordion.TabIndex = 4
        '
        'panelCategories
        '
        Me.panelCategories.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.panelCategories.Controls.Add(Me.panelAccordion)
        Me.panelCategories.Dock = System.Windows.Forms.DockStyle.Left
        Me.panelCategories.Location = New System.Drawing.Point(0, 0)
        Me.panelCategories.Name = "panelCategories"
        Me.panelCategories.Padding = New System.Windows.Forms.Padding(10, 10, 5, 5)
        Me.panelCategories.Size = New System.Drawing.Size(159, 521)
        Me.panelCategories.TabIndex = 5
        '
        'panelAccordion
        '
        Me.panelAccordion.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.panelAccordion.Controls.Add(Me.accordion)
        Me.panelAccordion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelAccordion.Location = New System.Drawing.Point(10, 10)
        Me.panelAccordion.Name = "panelAccordion"
        Me.panelAccordion.Size = New System.Drawing.Size(144, 506)
        Me.panelAccordion.TabIndex = 0
        '
        'panelWorkspace
        '
        Me.panelWorkspace.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.panelWorkspace.Controls.Add(Me.panelPages)
        Me.panelWorkspace.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelWorkspace.Location = New System.Drawing.Point(159, 0)
        Me.panelWorkspace.Name = "panelWorkspace"
        Me.panelWorkspace.Padding = New System.Windows.Forms.Padding(0, 10, 10, 5)
        Me.panelWorkspace.Size = New System.Drawing.Size(525, 521)
        Me.panelWorkspace.TabIndex = 6
        '
        'panelPages
        '
        Me.panelPages.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.panelPages.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelPages.Location = New System.Drawing.Point(0, 10)
        Me.panelPages.Name = "panelPages"
        Me.panelPages.Size = New System.Drawing.Size(515, 506)
        Me.panelPages.TabIndex = 0
        '
        'Options
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(684, 561)
        Me.Controls.Add(Me.panelWorkspace)
        Me.Controls.Add(Me.panelCategories)
        Me.Controls.Add(Me.locNav)
        Me.HelpButton = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(700, 600)
        Me.Name = "Options"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Options"
        CType(Me.locNav, System.ComponentModel.ISupportInitialize).EndInit()
        Me.locNav.ResumeLayout(False)
        CType(Me.lcgNav, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lciCancel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lciOK, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.esNavFiller, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UnitOfWork, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.accordion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.panelCategories, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelCategories.ResumeLayout(False)
        CType(Me.panelAccordion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelAccordion.ResumeLayout(False)
        CType(Me.panelWorkspace, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelWorkspace.ResumeLayout(False)
        CType(Me.panelPages, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents locNav As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents btnOK As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnCancel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents lcgNav As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents lciCancel As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents lciOK As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents esNavFiller As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents UnitOfWork As DevExpress.Xpo.UnitOfWork
    Friend WithEvents panelCategories As DevExpress.XtraEditors.PanelControl
    Friend WithEvents panelWorkspace As DevExpress.XtraEditors.PanelControl
    Friend WithEvents panelPages As DevExpress.XtraEditors.PanelControl
    Protected Friend WithEvents accordion As DevExpress.XtraBars.Navigation.AccordionControl
    Friend WithEvents panelAccordion As DevExpress.XtraEditors.PanelControl
End Class
