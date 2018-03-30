Imports System.Windows.Forms

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WaitForm
    Inherits DevExpress.XtraWaitForm.WaitForm

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
        Me.progressPanel = New DevExpress.XtraWaitForm.ProgressPanel()
        Me.layoutPanel = New System.Windows.Forms.TableLayoutPanel()
        Me.layoutPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'progressPanel
        '
        Me.progressPanel.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.progressPanel.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.progressPanel.Appearance.Options.UseBackColor = True
        Me.progressPanel.Appearance.Options.UseFont = True
        Me.progressPanel.AppearanceCaption.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.progressPanel.AppearanceCaption.Options.UseFont = True
        Me.progressPanel.AppearanceDescription.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.progressPanel.AppearanceDescription.Options.UseFont = True
        Me.progressPanel.AutoHeight = True
        Me.progressPanel.AutoWidth = True
        Me.progressPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.progressPanel.ImageHorzOffset = 20
        Me.progressPanel.Location = New System.Drawing.Point(0, 17)
        Me.progressPanel.Margin = New System.Windows.Forms.Padding(0, 3, 0, 3)
        Me.progressPanel.Name = "progressPanel"
        Me.progressPanel.Padding = New System.Windows.Forms.Padding(0, 0, 15, 0)
        Me.progressPanel.Size = New System.Drawing.Size(246, 39)
        Me.progressPanel.TabIndex = 0
        '
        'layoutPanel
        '
        Me.layoutPanel.AutoSize = True
        Me.layoutPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.layoutPanel.BackColor = System.Drawing.Color.Transparent
        Me.layoutPanel.ColumnCount = 1
        Me.layoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.layoutPanel.Controls.Add(Me.progressPanel, 0, 0)
        Me.layoutPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.layoutPanel.Location = New System.Drawing.Point(0, 0)
        Me.layoutPanel.Name = "layoutPanel"
        Me.layoutPanel.Padding = New System.Windows.Forms.Padding(0, 14, 0, 14)
        Me.layoutPanel.RowCount = 1
        Me.layoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.layoutPanel.Size = New System.Drawing.Size(246, 73)
        Me.layoutPanel.TabIndex = 1
        '
        'WaitForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(246, 73)
        Me.Controls.Add(Me.layoutPanel)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "WaitForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.layoutPanel.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents progressPanel As DevExpress.XtraWaitForm.ProgressPanel
    Private WithEvents layoutPanel As System.Windows.Forms.TableLayoutPanel
End Class
