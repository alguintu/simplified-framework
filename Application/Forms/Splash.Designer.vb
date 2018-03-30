<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Splash
    Inherits DevExpress.XtraSplashScreen.SplashScreen

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Splash))
        Me.lblStarting = New DevExpress.XtraEditors.LabelControl()
        Me.lblCopyright = New DevExpress.XtraEditors.LabelControl()
        Me.progress = New DevExpress.XtraEditors.MarqueeProgressBarControl()
        Me.peLogo = New DevExpress.XtraEditors.PictureEdit()
        Me.lblTrialVersion = New DevExpress.XtraEditors.LabelControl()
        Me.lblVersionInfo = New DevExpress.XtraEditors.LabelControl()
        Me.lblProductName = New DevExpress.XtraEditors.LabelControl()
        Me.lblSimplified = New DevExpress.XtraEditors.LabelControl()
        Me.panelBackdrop = New DevExpress.XtraEditors.PanelControl()
        CType(Me.progress.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.peLogo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.panelBackdrop, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelBackdrop.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblStarting
        '
        Me.lblStarting.Location = New System.Drawing.Point(23, 206)
        Me.lblStarting.Name = "lblStarting"
        Me.lblStarting.Size = New System.Drawing.Size(50, 13)
        Me.lblStarting.TabIndex = 12
        Me.lblStarting.Text = "Starting..."
        '
        'lblCopyright
        '
        Me.lblCopyright.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.lblCopyright.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lblCopyright.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.lblCopyright.Location = New System.Drawing.Point(23, 273)
        Me.lblCopyright.Name = "lblCopyright"
        Me.lblCopyright.Size = New System.Drawing.Size(238, 31)
        Me.lblCopyright.TabIndex = 11
        Me.lblCopyright.Text = "Copyright © 2015 Simplified Technologies" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Solutions and Services.  All rights res" &
    "erved."
        '
        'progress
        '
        Me.progress.EditValue = 0
        Me.progress.Location = New System.Drawing.Point(23, 231)
        Me.progress.Name = "progress"
        Me.progress.Size = New System.Drawing.Size(404, 12)
        Me.progress.TabIndex = 10
        '
        'peLogo
        '
        Me.peLogo.Cursor = System.Windows.Forms.Cursors.Default
        Me.peLogo.EditValue = CType(resources.GetObject("peLogo.EditValue"), Object)
        Me.peLogo.Location = New System.Drawing.Point(278, 264)
        Me.peLogo.Name = "peLogo"
        Me.peLogo.Properties.AllowFocused = False
        Me.peLogo.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.peLogo.Properties.Appearance.Options.UseBackColor = True
        Me.peLogo.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.peLogo.Properties.ShowMenu = False
        Me.peLogo.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch
        Me.peLogo.Size = New System.Drawing.Size(160, 48)
        Me.peLogo.TabIndex = 13
        '
        'lblTrialVersion
        '
        Me.lblTrialVersion.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTrialVersion.Appearance.BackColor = System.Drawing.Color.White
        Me.lblTrialVersion.Appearance.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTrialVersion.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.lblTrialVersion.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.lblTrialVersion.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lblTrialVersion.Location = New System.Drawing.Point(229, 22)
        Me.lblTrialVersion.Name = "lblTrialVersion"
        Me.lblTrialVersion.Size = New System.Drawing.Size(197, 30)
        Me.lblTrialVersion.TabIndex = 3
        Me.lblTrialVersion.Text = "TRIAL VERSION"
        '
        'lblVersionInfo
        '
        Me.lblVersionInfo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblVersionInfo.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVersionInfo.Appearance.ForeColor = System.Drawing.Color.White
        Me.lblVersionInfo.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.lblVersionInfo.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lblVersionInfo.Location = New System.Drawing.Point(330, 132)
        Me.lblVersionInfo.Name = "lblVersionInfo"
        Me.lblVersionInfo.Size = New System.Drawing.Size(85, 17)
        Me.lblVersionInfo.TabIndex = 2
        Me.lblVersionInfo.Text = "Version"
        '
        'lblProductName
        '
        Me.lblProductName.Appearance.Font = New System.Drawing.Font("Segoe UI Light", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProductName.Appearance.ForeColor = System.Drawing.Color.White
        Me.lblProductName.Location = New System.Drawing.Point(22, 108)
        Me.lblProductName.Name = "lblProductName"
        Me.lblProductName.Size = New System.Drawing.Size(215, 47)
        Me.lblProductName.TabIndex = 1
        Me.lblProductName.Text = "Product Name"
        '
        'lblSimplified
        '
        Me.lblSimplified.Appearance.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSimplified.Appearance.ForeColor = System.Drawing.Color.White
        Me.lblSimplified.Location = New System.Drawing.Point(24, 96)
        Me.lblSimplified.Name = "lblSimplified"
        Me.lblSimplified.Size = New System.Drawing.Size(70, 21)
        Me.lblSimplified.TabIndex = 0
        Me.lblSimplified.Text = "Simplified"
        '
        'panelBackdrop
        '
        Me.panelBackdrop.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.panelBackdrop.Appearance.Options.UseBackColor = True
        Me.panelBackdrop.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.panelBackdrop.Controls.Add(Me.lblSimplified)
        Me.panelBackdrop.Controls.Add(Me.lblProductName)
        Me.panelBackdrop.Controls.Add(Me.lblTrialVersion)
        Me.panelBackdrop.Controls.Add(Me.lblVersionInfo)
        Me.panelBackdrop.Location = New System.Drawing.Point(12, 12)
        Me.panelBackdrop.Name = "panelBackdrop"
        Me.panelBackdrop.Size = New System.Drawing.Size(426, 180)
        Me.panelBackdrop.TabIndex = 15
        '
        'Splash
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(450, 320)
        Me.Controls.Add(Me.panelBackdrop)
        Me.Controls.Add(Me.peLogo)
        Me.Controls.Add(Me.lblStarting)
        Me.Controls.Add(Me.lblCopyright)
        Me.Controls.Add(Me.progress)
        Me.Name = "Splash"
        CType(Me.progress.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.peLogo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.panelBackdrop, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelBackdrop.ResumeLayout(False)
        Me.panelBackdrop.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents peLogo As DevExpress.XtraEditors.PictureEdit
    Private WithEvents lblStarting As DevExpress.XtraEditors.LabelControl
    Private WithEvents lblCopyright As DevExpress.XtraEditors.LabelControl
    Private WithEvents progress As DevExpress.XtraEditors.MarqueeProgressBarControl
    Friend WithEvents lblTrialVersion As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblVersionInfo As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblProductName As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblSimplified As DevExpress.XtraEditors.LabelControl
    Friend WithEvents panelBackdrop As DevExpress.XtraEditors.PanelControl
End Class
