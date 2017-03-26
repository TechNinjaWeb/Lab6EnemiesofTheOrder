<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEnemyEditor
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEnemyEditor))
        Me.lblEnemyID = New System.Windows.Forms.Label()
        Me.lblEnemyIDNumber = New System.Windows.Forms.Label()
        Me.lblFirstName = New System.Windows.Forms.Label()
        Me.lblLastName = New System.Windows.Forms.Label()
        Me.lblThreatLevel = New System.Windows.Forms.Label()
        Me.lblAlliance = New System.Windows.Forms.Label()
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.cboThreatLevel = New System.Windows.Forms.ComboBox()
        Me.cboAlliance = New System.Windows.Forms.ComboBox()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblEnemyID
        '
        Me.lblEnemyID.AutoSize = True
        Me.lblEnemyID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEnemyID.Location = New System.Drawing.Point(12, 42)
        Me.lblEnemyID.Name = "lblEnemyID"
        Me.lblEnemyID.Size = New System.Drawing.Size(66, 16)
        Me.lblEnemyID.TabIndex = 0
        Me.lblEnemyID.Text = "Enemy ID"
        '
        'lblEnemyIDNumber
        '
        Me.lblEnemyIDNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEnemyIDNumber.Location = New System.Drawing.Point(107, 35)
        Me.lblEnemyIDNumber.Name = "lblEnemyIDNumber"
        Me.lblEnemyIDNumber.Size = New System.Drawing.Size(62, 23)
        Me.lblEnemyIDNumber.TabIndex = 1
        '
        'lblFirstName
        '
        Me.lblFirstName.AutoSize = True
        Me.lblFirstName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFirstName.Location = New System.Drawing.Point(12, 84)
        Me.lblFirstName.Name = "lblFirstName"
        Me.lblFirstName.Size = New System.Drawing.Size(73, 16)
        Me.lblFirstName.TabIndex = 2
        Me.lblFirstName.Text = "First Name"
        '
        'lblLastName
        '
        Me.lblLastName.AutoSize = True
        Me.lblLastName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLastName.Location = New System.Drawing.Point(12, 123)
        Me.lblLastName.Name = "lblLastName"
        Me.lblLastName.Size = New System.Drawing.Size(73, 16)
        Me.lblLastName.TabIndex = 3
        Me.lblLastName.Text = "Last Name"
        '
        'lblThreatLevel
        '
        Me.lblThreatLevel.AutoSize = True
        Me.lblThreatLevel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblThreatLevel.Location = New System.Drawing.Point(12, 167)
        Me.lblThreatLevel.Name = "lblThreatLevel"
        Me.lblThreatLevel.Size = New System.Drawing.Size(83, 16)
        Me.lblThreatLevel.TabIndex = 4
        Me.lblThreatLevel.Text = "Threat Level"
        '
        'lblAlliance
        '
        Me.lblAlliance.AutoSize = True
        Me.lblAlliance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAlliance.Location = New System.Drawing.Point(12, 211)
        Me.lblAlliance.Name = "lblAlliance"
        Me.lblAlliance.Size = New System.Drawing.Size(56, 16)
        Me.lblAlliance.TabIndex = 5
        Me.lblAlliance.Text = "Alliance"
        '
        'txtFirstName
        '
        Me.txtFirstName.Location = New System.Drawing.Point(110, 80)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(157, 20)
        Me.txtFirstName.TabIndex = 6
        '
        'txtLastName
        '
        Me.txtLastName.Location = New System.Drawing.Point(110, 123)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(157, 20)
        Me.txtLastName.TabIndex = 7
        '
        'cboThreatLevel
        '
        Me.cboThreatLevel.FormattingEnabled = True
        Me.cboThreatLevel.Location = New System.Drawing.Point(110, 161)
        Me.cboThreatLevel.Name = "cboThreatLevel"
        Me.cboThreatLevel.Size = New System.Drawing.Size(157, 21)
        Me.cboThreatLevel.TabIndex = 8
        '
        'cboAlliance
        '
        Me.cboAlliance.FormattingEnabled = True
        Me.cboAlliance.Location = New System.Drawing.Point(110, 206)
        Me.cboAlliance.Name = "cboAlliance"
        Me.cboAlliance.Size = New System.Drawing.Size(157, 21)
        Me.cboAlliance.TabIndex = 9
        '
        'btnCancel
        '
        Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Location = New System.Drawing.Point(94, 257)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 10
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Location = New System.Drawing.Point(192, 257)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 11
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 290)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(287, 22)
        Me.StatusStrip1.TabIndex = 12
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(120, 17)
        Me.ToolStripStatusLabel1.Text = "ToolStripStatusLabel1"
        '
        'frmEnemyEditor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(287, 312)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.cboAlliance)
        Me.Controls.Add(Me.cboThreatLevel)
        Me.Controls.Add(Me.txtLastName)
        Me.Controls.Add(Me.txtFirstName)
        Me.Controls.Add(Me.lblAlliance)
        Me.Controls.Add(Me.lblThreatLevel)
        Me.Controls.Add(Me.lblLastName)
        Me.Controls.Add(Me.lblFirstName)
        Me.Controls.Add(Me.lblEnemyIDNumber)
        Me.Controls.Add(Me.lblEnemyID)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmEnemyEditor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmEnemyEditor"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblEnemyID As Label
    Friend WithEvents lblEnemyIDNumber As Label
    Friend WithEvents lblFirstName As Label
    Friend WithEvents lblLastName As Label
    Friend WithEvents lblThreatLevel As Label
    Friend WithEvents lblAlliance As Label
    Friend WithEvents txtFirstName As TextBox
    Friend WithEvents txtLastName As TextBox
    Friend WithEvents cboThreatLevel As ComboBox
    Friend WithEvents cboAlliance As ComboBox
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
End Class
