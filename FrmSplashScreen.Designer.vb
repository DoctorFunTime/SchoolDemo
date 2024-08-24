<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmSplashScreen
    Inherits System.Windows.Forms.Form

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
        Me.components = New System.ComponentModel.Container()
        Me.prgBar = New Guna.UI2.WinForms.Guna2ProgressBar()
        Me.OpeningTransition = New Guna.UI2.WinForms.Guna2BorderlessForm(Me.components)
        Me.SuspendLayout()
        '
        'prgBar
        '
        Me.prgBar.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.prgBar.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.prgBar.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal
        Me.prgBar.Location = New System.Drawing.Point(0, 420)
        Me.prgBar.Name = "prgBar"
        Me.prgBar.ProgressColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.prgBar.ProgressColor2 = System.Drawing.Color.PowderBlue
        Me.prgBar.ShowText = True
        Me.prgBar.Size = New System.Drawing.Size(800, 30)
        Me.prgBar.TabIndex = 0
        Me.prgBar.Text = "Guna2ProgressBar1"
        Me.prgBar.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        '
        'OpeningTransition
        '
        Me.OpeningTransition.AnimateWindow = True
        Me.OpeningTransition.AnimationInterval = 1500
        Me.OpeningTransition.BorderRadius = 15
        Me.OpeningTransition.ContainerControl = Me
        Me.OpeningTransition.DockIndicatorTransparencyValue = 0.6R
        Me.OpeningTransition.ResizeForm = False
        Me.OpeningTransition.TransparentWhileDrag = True
        '
        'FrmSplashScreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.prgBar)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmSplashScreen"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmSplashScreen"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents prgBar As Guna.UI2.WinForms.Guna2ProgressBar
    Friend WithEvents OpeningTransition As Guna.UI2.WinForms.Guna2BorderlessForm
End Class
