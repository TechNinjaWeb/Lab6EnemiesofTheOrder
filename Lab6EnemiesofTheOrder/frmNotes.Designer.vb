<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNotes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmNotes))
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.NoteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CloseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImportExportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LoadFromFileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CopyCtrlCToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CutCtrlXToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PasteCtrlVToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClearAllToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OptionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WordWrapFalseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblEnemy = New System.Windows.Forms.Label()
        Me.lblEnemyInfo = New System.Windows.Forms.Label()
        Me.rtbEnemy = New System.Windows.Forms.RichTextBox()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.StatusStrip1.AutoSize = False
        Me.StatusStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.StatusStrip1.Location = New System.Drawing.Point(2, 566)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(928, 22)
        Me.StatusStrip1.TabIndex = 0
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MenuStrip1.AutoSize = False
        Me.MenuStrip1.BackColor = System.Drawing.Color.SteelBlue
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NoteToolStripMenuItem, Me.ImportExportToolStripMenuItem, Me.EditToolStripMenuItem, Me.OptionsToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(13, 13)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(904, 25)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'NoteToolStripMenuItem
        '
        Me.NoteToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SaveToolStripMenuItem, Me.CloseToolStripMenuItem})
        Me.NoteToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NoteToolStripMenuItem.Name = "NoteToolStripMenuItem"
        Me.NoteToolStripMenuItem.Size = New System.Drawing.Size(49, 21)
        Me.NoteToolStripMenuItem.Text = "Note"
        '
        'SaveToolStripMenuItem
        '
        Me.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
        Me.SaveToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.SaveToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.SaveToolStripMenuItem.Text = "Save "
        '
        'CloseToolStripMenuItem
        '
        Me.CloseToolStripMenuItem.Name = "CloseToolStripMenuItem"
        Me.CloseToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.CloseToolStripMenuItem.Text = "Close"
        '
        'ImportExportToolStripMenuItem
        '
        Me.ImportExportToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LoadFromFileToolStripMenuItem, Me.ExportToolStripMenuItem})
        Me.ImportExportToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ImportExportToolStripMenuItem.Name = "ImportExportToolStripMenuItem"
        Me.ImportExportToolStripMenuItem.Size = New System.Drawing.Size(102, 21)
        Me.ImportExportToolStripMenuItem.Text = "Import/Export"
        '
        'LoadFromFileToolStripMenuItem
        '
        Me.LoadFromFileToolStripMenuItem.Name = "LoadFromFileToolStripMenuItem"
        Me.LoadFromFileToolStripMenuItem.Size = New System.Drawing.Size(160, 22)
        Me.LoadFromFileToolStripMenuItem.Text = "Load from File"
        '
        'ExportToolStripMenuItem
        '
        Me.ExportToolStripMenuItem.Name = "ExportToolStripMenuItem"
        Me.ExportToolStripMenuItem.Size = New System.Drawing.Size(160, 22)
        Me.ExportToolStripMenuItem.Text = "Export"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CopyCtrlCToolStripMenuItem, Me.CutCtrlXToolStripMenuItem, Me.PasteCtrlVToolStripMenuItem, Me.ClearAllToolStripMenuItem})
        Me.EditToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(42, 21)
        Me.EditToolStripMenuItem.Text = "Edit"
        '
        'CopyCtrlCToolStripMenuItem
        '
        Me.CopyCtrlCToolStripMenuItem.Name = "CopyCtrlCToolStripMenuItem"
        Me.CopyCtrlCToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.CopyCtrlCToolStripMenuItem.Size = New System.Drawing.Size(160, 22)
        Me.CopyCtrlCToolStripMenuItem.Text = "Copy  "
        '
        'CutCtrlXToolStripMenuItem
        '
        Me.CutCtrlXToolStripMenuItem.Name = "CutCtrlXToolStripMenuItem"
        Me.CutCtrlXToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.X), System.Windows.Forms.Keys)
        Me.CutCtrlXToolStripMenuItem.Size = New System.Drawing.Size(160, 22)
        Me.CutCtrlXToolStripMenuItem.Text = "Cut  "
        '
        'PasteCtrlVToolStripMenuItem
        '
        Me.PasteCtrlVToolStripMenuItem.Name = "PasteCtrlVToolStripMenuItem"
        Me.PasteCtrlVToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.V), System.Windows.Forms.Keys)
        Me.PasteCtrlVToolStripMenuItem.Size = New System.Drawing.Size(160, 22)
        Me.PasteCtrlVToolStripMenuItem.Text = "Paste  "
        '
        'ClearAllToolStripMenuItem
        '
        Me.ClearAllToolStripMenuItem.Name = "ClearAllToolStripMenuItem"
        Me.ClearAllToolStripMenuItem.Size = New System.Drawing.Size(160, 22)
        Me.ClearAllToolStripMenuItem.Text = "Clear All"
        '
        'OptionsToolStripMenuItem
        '
        Me.OptionsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.WordWrapFalseToolStripMenuItem})
        Me.OptionsToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OptionsToolStripMenuItem.Name = "OptionsToolStripMenuItem"
        Me.OptionsToolStripMenuItem.Size = New System.Drawing.Size(66, 21)
        Me.OptionsToolStripMenuItem.Text = "Options"
        '
        'WordWrapFalseToolStripMenuItem
        '
        Me.WordWrapFalseToolStripMenuItem.Name = "WordWrapFalseToolStripMenuItem"
        Me.WordWrapFalseToolStripMenuItem.Size = New System.Drawing.Size(186, 22)
        Me.WordWrapFalseToolStripMenuItem.Text = "Word Wrap (False)"
        '
        'lblEnemy
        '
        Me.lblEnemy.AutoSize = True
        Me.lblEnemy.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEnemy.Location = New System.Drawing.Point(13, 51)
        Me.lblEnemy.Name = "lblEnemy"
        Me.lblEnemy.Size = New System.Drawing.Size(62, 20)
        Me.lblEnemy.TabIndex = 2
        Me.lblEnemy.Text = "Enemy:"
        '
        'lblEnemyInfo
        '
        Me.lblEnemyInfo.Location = New System.Drawing.Point(84, 51)
        Me.lblEnemyInfo.Name = "lblEnemyInfo"
        Me.lblEnemyInfo.Size = New System.Drawing.Size(151, 30)
        Me.lblEnemyInfo.TabIndex = 3
        '
        'rtbEnemy
        '
        Me.rtbEnemy.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rtbEnemy.Location = New System.Drawing.Point(13, 82)
        Me.rtbEnemy.Name = "rtbEnemy"
        Me.rtbEnemy.Size = New System.Drawing.Size(904, 481)
        Me.rtbEnemy.TabIndex = 4
        Me.rtbEnemy.Text = ""
        '
        'frmNotes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(929, 588)
        Me.Controls.Add(Me.rtbEnemy)
        Me.Controls.Add(Me.lblEnemyInfo)
        Me.Controls.Add(Me.lblEnemy)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmNotes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Enemy Notes"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents NoteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CloseToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ImportExportToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LoadFromFileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExportToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CopyCtrlCToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CutCtrlXToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PasteCtrlVToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClearAllToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OptionsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents WordWrapFalseToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents lblEnemy As Label
    Friend WithEvents lblEnemyInfo As Label
    Friend WithEvents rtbEnemy As RichTextBox
End Class
