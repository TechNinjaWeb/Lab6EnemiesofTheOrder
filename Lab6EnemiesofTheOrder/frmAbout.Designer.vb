<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAbout
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAbout))
        Me.picSecondOrder2 = New System.Windows.Forms.PictureBox()
        Me.lblEnemiesofTheSecondOrder2 = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblAuthors = New System.Windows.Forms.Label()
        Me.lblVersion = New System.Windows.Forms.Label()
        Me.lblAuthorsNames = New System.Windows.Forms.Label()
        Me.lblVersionNumber = New System.Windows.Forms.Label()
        Me.lblInformation = New System.Windows.Forms.Label()
        CType(Me.picSecondOrder2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picSecondOrder2
        '
        Me.picSecondOrder2.Image = CType(resources.GetObject("picSecondOrder2.Image"), System.Drawing.Image)
        Me.picSecondOrder2.Location = New System.Drawing.Point(12, 12)
        Me.picSecondOrder2.Name = "picSecondOrder2"
        Me.picSecondOrder2.Size = New System.Drawing.Size(196, 208)
        Me.picSecondOrder2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picSecondOrder2.TabIndex = 0
        Me.picSecondOrder2.TabStop = False
        '
        'lblEnemiesofTheSecondOrder2
        '
        Me.lblEnemiesofTheSecondOrder2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEnemiesofTheSecondOrder2.Location = New System.Drawing.Point(237, 12)
        Me.lblEnemiesofTheSecondOrder2.Name = "lblEnemiesofTheSecondOrder2"
        Me.lblEnemiesofTheSecondOrder2.Size = New System.Drawing.Size(233, 95)
        Me.lblEnemiesofTheSecondOrder2.TabIndex = 1
        Me.lblEnemiesofTheSecondOrder2.Text = "Enemies of The Second Order"
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(518, 211)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(77, 30)
        Me.btnExit.TabIndex = 2
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblAuthors
        '
        Me.lblAuthors.AutoSize = True
        Me.lblAuthors.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAuthors.Location = New System.Drawing.Point(229, 181)
        Me.lblAuthors.Name = "lblAuthors"
        Me.lblAuthors.Size = New System.Drawing.Size(56, 16)
        Me.lblAuthors.TabIndex = 3
        Me.lblAuthors.Text = "Authors:"
        '
        'lblVersion
        '
        Me.lblVersion.AutoSize = True
        Me.lblVersion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVersion.Location = New System.Drawing.Point(229, 207)
        Me.lblVersion.Name = "lblVersion"
        Me.lblVersion.Size = New System.Drawing.Size(57, 16)
        Me.lblVersion.TabIndex = 4
        Me.lblVersion.Text = "Version:"
        '
        'lblAuthorsNames
        '
        Me.lblAuthorsNames.AutoSize = True
        Me.lblAuthorsNames.Location = New System.Drawing.Point(300, 181)
        Me.lblAuthorsNames.Name = "lblAuthorsNames"
        Me.lblAuthorsNames.Size = New System.Drawing.Size(222, 13)
        Me.lblAuthorsNames.TabIndex = 5
        Me.lblAuthorsNames.Text = "Mohammad Al Jarrah && Raymonde Thompson"
        '
        'lblVersionNumber
        '
        Me.lblVersionNumber.AutoSize = True
        Me.lblVersionNumber.Location = New System.Drawing.Point(300, 207)
        Me.lblVersionNumber.Name = "lblVersionNumber"
        Me.lblVersionNumber.Size = New System.Drawing.Size(40, 13)
        Me.lblVersionNumber.TabIndex = 6
        Me.lblVersionNumber.Text = "1.0.0.0"
        '
        'lblInformation
        '
        Me.lblInformation.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInformation.Location = New System.Drawing.Point(229, 81)
        Me.lblInformation.Name = "lblInformation"
        Me.lblInformation.Size = New System.Drawing.Size(366, 88)
        Me.lblInformation.TabIndex = 7
        Me.lblInformation.Text = resources.GetString("lblInformation.Text")
        '
        'frmAbout
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(607, 253)
        Me.Controls.Add(Me.lblInformation)
        Me.Controls.Add(Me.lblVersionNumber)
        Me.Controls.Add(Me.lblAuthorsNames)
        Me.Controls.Add(Me.lblVersion)
        Me.Controls.Add(Me.lblAuthors)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.lblEnemiesofTheSecondOrder2)
        Me.Controls.Add(Me.picSecondOrder2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmAbout"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "About"
        CType(Me.picSecondOrder2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents picSecondOrder2 As PictureBox
    Friend WithEvents lblEnemiesofTheSecondOrder2 As Label
    Friend WithEvents btnExit As Button
    Friend WithEvents lblAuthors As Label
    Friend WithEvents lblVersion As Label
    Friend WithEvents lblAuthorsNames As Label
    Friend WithEvents lblVersionNumber As Label
    Friend WithEvents lblInformation As Label
End Class
