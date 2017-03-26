<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSplash
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSplash))
        Me.picSecondOrder = New System.Windows.Forms.PictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.lblEnemiesofSecondOrder = New System.Windows.Forms.Label()
        Me.lblBy = New System.Windows.Forms.Label()
        Me.pbrEnemiesofSecondOrder = New System.Windows.Forms.ProgressBar()
        CType(Me.picSecondOrder, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picSecondOrder
        '
        Me.picSecondOrder.Image = CType(resources.GetObject("picSecondOrder.Image"), System.Drawing.Image)
        Me.picSecondOrder.Location = New System.Drawing.Point(13, 13)
        Me.picSecondOrder.Name = "picSecondOrder"
        Me.picSecondOrder.Size = New System.Drawing.Size(196, 208)
        Me.picSecondOrder.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picSecondOrder.TabIndex = 0
        Me.picSecondOrder.TabStop = False
        '
        'Timer1
        '
        '
        'lblEnemiesofSecondOrder
        '
        Me.lblEnemiesofSecondOrder.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEnemiesofSecondOrder.Location = New System.Drawing.Point(229, 38)
        Me.lblEnemiesofSecondOrder.Name = "lblEnemiesofSecondOrder"
        Me.lblEnemiesofSecondOrder.Size = New System.Drawing.Size(269, 112)
        Me.lblEnemiesofSecondOrder.TabIndex = 1
        Me.lblEnemiesofSecondOrder.Text = "Enemies of The Second Order"
        Me.lblEnemiesofSecondOrder.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblBy
        '
        Me.lblBy.AutoSize = True
        Me.lblBy.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBy.Location = New System.Drawing.Point(410, 221)
        Me.lblBy.Name = "lblBy"
        Me.lblBy.Size = New System.Drawing.Size(152, 16)
        Me.lblBy.TabIndex = 2
        Me.lblBy.Text = "by Aljarrah && Thompson"
        '
        'pbrEnemiesofSecondOrder
        '
        Me.pbrEnemiesofSecondOrder.Location = New System.Drawing.Point(235, 197)
        Me.pbrEnemiesofSecondOrder.Name = "pbrEnemiesofSecondOrder"
        Me.pbrEnemiesofSecondOrder.Size = New System.Drawing.Size(100, 23)
        Me.pbrEnemiesofSecondOrder.TabIndex = 3
        Me.pbrEnemiesofSecondOrder.Visible = False
        '
        'frmSplash
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(574, 246)
        Me.ControlBox = False
        Me.Controls.Add(Me.pbrEnemiesofSecondOrder)
        Me.Controls.Add(Me.lblBy)
        Me.Controls.Add(Me.lblEnemiesofSecondOrder)
        Me.Controls.Add(Me.picSecondOrder)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSplash"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Splash"
        CType(Me.picSecondOrder, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents picSecondOrder As PictureBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents lblEnemiesofSecondOrder As Label
    Friend WithEvents lblBy As Label
    Friend WithEvents pbrEnemiesofSecondOrder As ProgressBar
End Class
