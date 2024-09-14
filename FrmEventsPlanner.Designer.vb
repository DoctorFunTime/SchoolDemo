<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmEventsPlanner
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.openingTranstionReceipts = New Guna.UI2.WinForms.Guna2BorderlessForm(Me.components)
        Me.pnlTopBar = New Guna.UI2.WinForms.Guna2GradientPanel()
        Me.btnAddEvent = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.dtePickerDate = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.lblHeading = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.btnClose = New Guna.UI2.WinForms.Guna2Button()
        Me.pnlFlowHeader = New System.Windows.Forms.FlowLayoutPanel()
        Me.pnlFlowDays = New System.Windows.Forms.FlowLayoutPanel()
        Me.pnlTopBar.SuspendLayout()
        Me.SuspendLayout()
        '
        'openingTranstionReceipts
        '
        Me.openingTranstionReceipts.AnimateWindow = True
        Me.openingTranstionReceipts.AnimationInterval = 1000
        Me.openingTranstionReceipts.BorderRadius = 15
        Me.openingTranstionReceipts.ContainerControl = Me
        Me.openingTranstionReceipts.DockIndicatorTransparencyValue = 0.6R
        Me.openingTranstionReceipts.ResizeForm = False
        Me.openingTranstionReceipts.TransparentWhileDrag = True
        '
        'pnlTopBar
        '
        Me.pnlTopBar.Controls.Add(Me.btnAddEvent)
        Me.pnlTopBar.Controls.Add(Me.dtePickerDate)
        Me.pnlTopBar.Controls.Add(Me.lblHeading)
        Me.pnlTopBar.Controls.Add(Me.btnClose)
        Me.pnlTopBar.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTopBar.FillColor = System.Drawing.Color.PowderBlue
        Me.pnlTopBar.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.pnlTopBar.Location = New System.Drawing.Point(0, 0)
        Me.pnlTopBar.Name = "pnlTopBar"
        Me.pnlTopBar.Size = New System.Drawing.Size(1150, 41)
        Me.pnlTopBar.TabIndex = 60
        '
        'btnAddEvent
        '
        Me.btnAddEvent.Animated = True
        Me.btnAddEvent.BackColor = System.Drawing.Color.Transparent
        Me.btnAddEvent.BorderRadius = 8
        Me.btnAddEvent.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAddEvent.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnAddEvent.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnAddEvent.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnAddEvent.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnAddEvent.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnAddEvent.FillColor = System.Drawing.Color.Empty
        Me.btnAddEvent.FillColor2 = System.Drawing.Color.Empty
        Me.btnAddEvent.Font = New System.Drawing.Font("Century Gothic", 10.0!)
        Me.btnAddEvent.ForeColor = System.Drawing.Color.Black
        Me.btnAddEvent.Image = Global.SchoolDemo.My.Resources.Resources._830
        Me.btnAddEvent.ImageSize = New System.Drawing.Size(30, 30)
        Me.btnAddEvent.Location = New System.Drawing.Point(664, 4)
        Me.btnAddEvent.Name = "btnAddEvent"
        Me.btnAddEvent.ShadowDecoration.Color = System.Drawing.Color.DimGray
        Me.btnAddEvent.ShadowDecoration.Depth = 3
        Me.btnAddEvent.ShadowDecoration.Enabled = True
        Me.btnAddEvent.Size = New System.Drawing.Size(123, 31)
        Me.btnAddEvent.TabIndex = 61
        Me.btnAddEvent.Text = "Add New"
        Me.btnAddEvent.UseTransparentBackground = True
        '
        'dtePickerDate
        '
        Me.dtePickerDate.BackColor = System.Drawing.Color.Transparent
        Me.dtePickerDate.BorderColor = System.Drawing.Color.PowderBlue
        Me.dtePickerDate.BorderThickness = 1
        Me.dtePickerDate.Checked = True
        Me.dtePickerDate.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dtePickerDate.FillColor = System.Drawing.Color.Empty
        Me.dtePickerDate.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtePickerDate.ForeColor = System.Drawing.Color.Black
        Me.dtePickerDate.Format = System.Windows.Forms.DateTimePickerFormat.[Long]
        Me.dtePickerDate.Location = New System.Drawing.Point(809, 7)
        Me.dtePickerDate.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.dtePickerDate.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.dtePickerDate.Name = "dtePickerDate"
        Me.dtePickerDate.Size = New System.Drawing.Size(266, 27)
        Me.dtePickerDate.TabIndex = 59
        Me.dtePickerDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.dtePickerDate.UseTransparentBackground = True
        Me.dtePickerDate.Value = New Date(2024, 7, 21, 0, 0, 0, 0)
        '
        'lblHeading
        '
        Me.lblHeading.BackColor = System.Drawing.Color.Transparent
        Me.lblHeading.Font = New System.Drawing.Font("Century Gothic", 14.0!, System.Drawing.FontStyle.Bold)
        Me.lblHeading.Location = New System.Drawing.Point(16, 8)
        Me.lblHeading.Name = "lblHeading"
        Me.lblHeading.Size = New System.Drawing.Size(154, 25)
        Me.lblHeading.TabIndex = 56
        Me.lblHeading.Text = "Events Calendar"
        '
        'btnClose
        '
        Me.btnClose.Animated = True
        Me.btnClose.BackColor = System.Drawing.Color.Transparent
        Me.btnClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClose.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnClose.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnClose.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnClose.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnClose.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnClose.FillColor = System.Drawing.Color.Empty
        Me.btnClose.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnClose.ForeColor = System.Drawing.Color.White
        Me.btnClose.Image = Global.SchoolDemo.My.Resources.Resources._938
        Me.btnClose.ImageSize = New System.Drawing.Size(15, 15)
        Me.btnClose.Location = New System.Drawing.Point(1109, 0)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(41, 41)
        Me.btnClose.TabIndex = 55
        '
        'pnlFlowHeader
        '
        Me.pnlFlowHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlFlowHeader.Location = New System.Drawing.Point(0, 41)
        Me.pnlFlowHeader.Name = "pnlFlowHeader"
        Me.pnlFlowHeader.Size = New System.Drawing.Size(1150, 50)
        Me.pnlFlowHeader.TabIndex = 61
        '
        'pnlFlowDays
        '
        Me.pnlFlowDays.AutoScroll = True
        Me.pnlFlowDays.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlFlowDays.Location = New System.Drawing.Point(0, 91)
        Me.pnlFlowDays.Name = "pnlFlowDays"
        Me.pnlFlowDays.Size = New System.Drawing.Size(1150, 509)
        Me.pnlFlowDays.TabIndex = 62
        '
        'FrmEventsPlanner
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1150, 600)
        Me.Controls.Add(Me.pnlFlowDays)
        Me.Controls.Add(Me.pnlFlowHeader)
        Me.Controls.Add(Me.pnlTopBar)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmEventsPlanner"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmEventsPlanner"
        Me.pnlTopBar.ResumeLayout(False)
        Me.pnlTopBar.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents openingTranstionReceipts As Guna.UI2.WinForms.Guna2BorderlessForm
    Friend WithEvents pnlTopBar As Guna.UI2.WinForms.Guna2GradientPanel
    Friend WithEvents lblHeading As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents btnClose As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents pnlFlowDays As FlowLayoutPanel
    Friend WithEvents pnlFlowHeader As FlowLayoutPanel
    Friend WithEvents dtePickerDate As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents btnAddEvent As Guna.UI2.WinForms.Guna2GradientButton
End Class
