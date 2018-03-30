Imports Simplified.Framework.Core

Namespace Module1
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class Module1
        Inherits ModuleBase
        'UserControl overrides dispose to clean up the component list.
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
            Dim TimeRuler1 As DevExpress.XtraScheduler.TimeRuler = New DevExpress.XtraScheduler.TimeRuler()
            Dim TimeRuler2 As DevExpress.XtraScheduler.TimeRuler = New DevExpress.XtraScheduler.TimeRuler()
            Dim TimeRuler3 As DevExpress.XtraScheduler.TimeRuler = New DevExpress.XtraScheduler.TimeRuler()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Module1))
            Me.RibbonControl1 = New DevExpress.XtraBars.Ribbon.RibbonControl()
            Me.RibbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
            Me.RibbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
            Me.SchedulerControl1 = New DevExpress.XtraScheduler.SchedulerControl()
            Me.SchedulerStorage1 = New DevExpress.XtraScheduler.SchedulerStorage(Me.components)
            Me.smallImages = New DevExpress.Utils.ImageCollection(Me.components)
            CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.SchedulerControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.SchedulerStorage1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.smallImages, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'RibbonControl1
            '
            Me.RibbonControl1.ColorScheme = DevExpress.XtraBars.Ribbon.RibbonControlColorScheme.Teal
            Me.RibbonControl1.ExpandCollapseItem.Id = 0
            Me.RibbonControl1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.RibbonControl1.ExpandCollapseItem})
            Me.RibbonControl1.Location = New System.Drawing.Point(0, 0)
            Me.RibbonControl1.MaxItemId = 1
            Me.RibbonControl1.Name = "RibbonControl1"
            Me.RibbonControl1.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.RibbonPage1})
            Me.RibbonControl1.Size = New System.Drawing.Size(690, 141)
            '
            'RibbonPage1
            '
            Me.RibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageGroup1})
            Me.RibbonPage1.Name = "RibbonPage1"
            Me.RibbonPage1.Text = "RibbonPage1"
            '
            'RibbonPageGroup1
            '
            Me.RibbonPageGroup1.Name = "RibbonPageGroup1"
            Me.RibbonPageGroup1.Text = "RibbonPageGroup1"
            '
            'SchedulerControl1
            '
            Me.SchedulerControl1.DataStorage = Me.SchedulerStorage1
            Me.SchedulerControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.SchedulerControl1.Location = New System.Drawing.Point(0, 141)
            Me.SchedulerControl1.MenuManager = Me.RibbonControl1
            Me.SchedulerControl1.Name = "SchedulerControl1"
            Me.SchedulerControl1.Size = New System.Drawing.Size(690, 288)
            Me.SchedulerControl1.Start = New Date(2018, 1, 28, 0, 0, 0, 0)
            Me.SchedulerControl1.TabIndex = 1
            Me.SchedulerControl1.Text = "SchedulerControl1"
            Me.SchedulerControl1.Views.DayView.TimeRulers.Add(TimeRuler1)
            Me.SchedulerControl1.Views.FullWeekView.Enabled = True
            Me.SchedulerControl1.Views.FullWeekView.TimeRulers.Add(TimeRuler2)
            Me.SchedulerControl1.Views.WeekView.Enabled = False
            Me.SchedulerControl1.Views.WorkWeekView.TimeRulers.Add(TimeRuler3)
            '
            'smallImages
            '
            Me.smallImages.ImageStream = CType(resources.GetObject("smallImages.ImageStream"), DevExpress.Utils.ImageCollectionStreamer)
            Me.smallImages.InsertGalleryImage("switchtimescalesto_16x16.png", "images/scheduling/switchtimescalesto_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/scheduling/switchtimescalesto_16x16.png"), 0)
            Me.smallImages.Images.SetKeyName(0, "switchtimescalesto_16x16.png")
            Me.smallImages.InsertGalleryImage("adateoccurring_16x16.png", "images/conditional%20formatting/adateoccurring_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/conditional%20formatting/adateoccurring_16x16.png"), 1)
            Me.smallImages.Images.SetKeyName(1, "adateoccurring_16x16.png")
            Me.smallImages.InsertGalleryImage("iconsetstars3_16x16.png", "images/conditional%20formatting/iconsetstars3_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/conditional%20formatting/iconsetstars3_16x16.png"), 2)
            Me.smallImages.Images.SetKeyName(2, "iconsetstars3_16x16.png")
            '
            'Module1
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.SchedulerControl1)
            Me.Controls.Add(Me.RibbonControl1)
            Me.Name = "Module1"
            Me.Ribbon = Me.RibbonControl1
            Me.Size = New System.Drawing.Size(690, 429)
            CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.SchedulerControl1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.SchedulerStorage1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.smallImages, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

        Friend WithEvents RibbonControl1 As DevExpress.XtraBars.Ribbon.RibbonControl
        Friend WithEvents RibbonPage1 As DevExpress.XtraBars.Ribbon.RibbonPage
        Friend WithEvents RibbonPageGroup1 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
        Friend WithEvents SchedulerControl1 As DevExpress.XtraScheduler.SchedulerControl
        Friend WithEvents SchedulerStorage1 As DevExpress.XtraScheduler.SchedulerStorage
        Friend WithEvents smallImages As DevExpress.Utils.ImageCollection
    End Class

End Namespace

