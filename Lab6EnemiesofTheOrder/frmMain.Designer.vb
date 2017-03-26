<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.btnAddNew = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnNotes = New System.Windows.Forms.Button()
        Me.lblCurrentEnemiesofTheSecondOrder = New System.Windows.Forms.Label()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.MenuStrip2 = New System.Windows.Forms.MenuStrip()
        Me.MenuFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuEnemies = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuRefreshEnemies = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuAddNew = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuDeleteCurrent = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuEditCurrent = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuNotes = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.dgvEnemiesofSecondOrder = New System.Windows.Forms.DataGridView()
        Me.DatEnemyBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsLab06BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsLab06 = New Lab6EnemiesofTheOrder.dsLab06()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.DatEnemyBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DatEnemyTableAdapter = New Lab6EnemiesofTheOrder.dsLab06TableAdapters.datEnemyTableAdapter()
        Me.DsLab06BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.StatusStrip1.SuspendLayout()
        Me.MenuStrip2.SuspendLayout()
        CType(Me.dgvEnemiesofSecondOrder, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DatEnemyBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsLab06BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsLab06, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DatEnemyBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsLab06BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnAddNew
        '
        Me.btnAddNew.ForeColor = System.Drawing.Color.Black
        Me.btnAddNew.Location = New System.Drawing.Point(15, 76)
        Me.btnAddNew.Name = "btnAddNew"
        Me.btnAddNew.Size = New System.Drawing.Size(100, 23)
        Me.btnAddNew.TabIndex = 0
        Me.btnAddNew.Text = "&Add New"
        Me.btnAddNew.UseVisualStyleBackColor = True
        '
        'btnEdit
        '
        Me.btnEdit.ForeColor = System.Drawing.Color.Black
        Me.btnEdit.Location = New System.Drawing.Point(121, 76)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(100, 23)
        Me.btnEdit.TabIndex = 1
        Me.btnEdit.Text = "&Edit"
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'btnNotes
        '
        Me.btnNotes.ForeColor = System.Drawing.Color.Black
        Me.btnNotes.Location = New System.Drawing.Point(227, 76)
        Me.btnNotes.Name = "btnNotes"
        Me.btnNotes.Size = New System.Drawing.Size(100, 23)
        Me.btnNotes.TabIndex = 2
        Me.btnNotes.Text = "&Notes"
        Me.btnNotes.UseVisualStyleBackColor = True
        '
        'lblCurrentEnemiesofTheSecondOrder
        '
        Me.lblCurrentEnemiesofTheSecondOrder.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblCurrentEnemiesofTheSecondOrder.BackColor = System.Drawing.Color.CornflowerBlue
        Me.lblCurrentEnemiesofTheSecondOrder.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCurrentEnemiesofTheSecondOrder.Location = New System.Drawing.Point(12, 24)
        Me.lblCurrentEnemiesofTheSecondOrder.Name = "lblCurrentEnemiesofTheSecondOrder"
        Me.lblCurrentEnemiesofTheSecondOrder.Size = New System.Drawing.Size(844, 49)
        Me.lblCurrentEnemiesofTheSecondOrder.TabIndex = 3
        Me.lblCurrentEnemiesofTheSecondOrder.Text = "Current Enemies of The Secon Order"
        Me.lblCurrentEnemiesofTheSecondOrder.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.StatusStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 531)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(138, 22)
        Me.StatusStrip1.TabIndex = 4
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(121, 17)
        Me.ToolStripStatusLabel1.Text = "ToolStripStatusLabel1"
        '
        'MenuStrip2
        '
        Me.MenuStrip2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MenuStrip2.BackColor = System.Drawing.Color.Transparent
        Me.MenuStrip2.Dock = System.Windows.Forms.DockStyle.None
        Me.MenuStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuFile, Me.MenuEnemies, Me.AboutToolStripMenuItem})
        Me.MenuStrip2.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip2.Name = "MenuStrip2"
        Me.MenuStrip2.Size = New System.Drawing.Size(160, 24)
        Me.MenuStrip2.TabIndex = 6
        Me.MenuStrip2.Text = "MenuStrip2"
        '
        'MenuFile
        '
        Me.MenuFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuExit})
        Me.MenuFile.ForeColor = System.Drawing.Color.Black
        Me.MenuFile.Name = "MenuFile"
        Me.MenuFile.Size = New System.Drawing.Size(37, 20)
        Me.MenuFile.Text = "File"
        '
        'MenuExit
        '
        Me.MenuExit.Name = "MenuExit"
        Me.MenuExit.Size = New System.Drawing.Size(92, 22)
        Me.MenuExit.Text = "Exit"
        '
        'MenuEnemies
        '
        Me.MenuEnemies.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuRefreshEnemies, Me.MenuAddNew, Me.MenuDeleteCurrent, Me.MenuEditCurrent, Me.MenuNotes})
        Me.MenuEnemies.ForeColor = System.Drawing.Color.Black
        Me.MenuEnemies.Name = "MenuEnemies"
        Me.MenuEnemies.Size = New System.Drawing.Size(63, 20)
        Me.MenuEnemies.Text = "Enemies"
        '
        'MenuRefreshEnemies
        '
        Me.MenuRefreshEnemies.Name = "MenuRefreshEnemies"
        Me.MenuRefreshEnemies.Size = New System.Drawing.Size(160, 22)
        Me.MenuRefreshEnemies.Text = "Refresh Enemies"
        '
        'MenuAddNew
        '
        Me.MenuAddNew.Name = "MenuAddNew"
        Me.MenuAddNew.Size = New System.Drawing.Size(160, 22)
        Me.MenuAddNew.Text = "Add New"
        '
        'MenuDeleteCurrent
        '
        Me.MenuDeleteCurrent.Name = "MenuDeleteCurrent"
        Me.MenuDeleteCurrent.Size = New System.Drawing.Size(160, 22)
        Me.MenuDeleteCurrent.Text = "Delete Current"
        '
        'MenuEditCurrent
        '
        Me.MenuEditCurrent.Name = "MenuEditCurrent"
        Me.MenuEditCurrent.Size = New System.Drawing.Size(160, 22)
        Me.MenuEditCurrent.Text = "Edit Current"
        '
        'MenuNotes
        '
        Me.MenuNotes.Name = "MenuNotes"
        Me.MenuNotes.Size = New System.Drawing.Size(160, 22)
        Me.MenuNotes.Text = "Notes"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.ForeColor = System.Drawing.Color.Black
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(52, 20)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'dgvEnemiesofSecondOrder
        '
        Me.dgvEnemiesofSecondOrder.AllowUserToAddRows = False
        Me.dgvEnemiesofSecondOrder.AllowUserToDeleteRows = False
        Me.dgvEnemiesofSecondOrder.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.dgvEnemiesofSecondOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvEnemiesofSecondOrder.Location = New System.Drawing.Point(13, 106)
        Me.dgvEnemiesofSecondOrder.Name = "dgvEnemiesofSecondOrder"
        Me.dgvEnemiesofSecondOrder.ReadOnly = True
        Me.dgvEnemiesofSecondOrder.Size = New System.Drawing.Size(843, 422)
        Me.dgvEnemiesofSecondOrder.TabIndex = 7
        '
        'DatEnemyBindingSource1
        '
        Me.DatEnemyBindingSource1.DataMember = "datEnemy"
        Me.DatEnemyBindingSource1.DataSource = Me.DsLab06BindingSource
        '
        'DsLab06BindingSource
        '
        Me.DsLab06BindingSource.DataSource = Me.DsLab06
        Me.DsLab06BindingSource.Position = 0
        '
        'DsLab06
        '
        Me.DsLab06.DataSetName = "dsLab06"
        Me.DsLab06.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'DatEnemyBindingSource
        '
        Me.DatEnemyBindingSource.DataMember = "datEnemy"
        Me.DatEnemyBindingSource.DataSource = Me.DsLab06BindingSource
        '
        'DatEnemyTableAdapter
        '
        Me.DatEnemyTableAdapter.ClearBeforeFill = True
        '
        'DsLab06BindingSource1
        '
        Me.DsLab06BindingSource1.DataSource = Me.DsLab06
        Me.DsLab06BindingSource1.Position = 0
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(868, 553)
        Me.Controls.Add(Me.dgvEnemiesofSecondOrder)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip2)
        Me.Controls.Add(Me.lblCurrentEnemiesofTheSecondOrder)
        Me.Controls.Add(Me.btnNotes)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.btnAddNew)
        Me.ForeColor = System.Drawing.Color.White
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Enemies of The Second Order"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.MenuStrip2.ResumeLayout(False)
        Me.MenuStrip2.PerformLayout()
        CType(Me.dgvEnemiesofSecondOrder, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DatEnemyBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsLab06BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsLab06, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DatEnemyBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsLab06BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnAddNew As Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnNotes As Button
    Friend WithEvents lblCurrentEnemiesofTheSecondOrder As Label
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents MenuStrip2 As MenuStrip
    Friend WithEvents MenuFile As ToolStripMenuItem
    Friend WithEvents MenuExit As ToolStripMenuItem
    Friend WithEvents MenuEnemies As ToolStripMenuItem
    Friend WithEvents MenuRefreshEnemies As ToolStripMenuItem
    Friend WithEvents MenuAddNew As ToolStripMenuItem
    Friend WithEvents MenuDeleteCurrent As ToolStripMenuItem
    Friend WithEvents MenuEditCurrent As ToolStripMenuItem
    Friend WithEvents MenuNotes As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents dgvEnemiesofSecondOrder As DataGridView
    Friend WithEvents DsLab06BindingSource As BindingSource
    Friend WithEvents DsLab06 As dsLab06
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents DatEnemyBindingSource As BindingSource
    Friend WithEvents DatEnemyTableAdapter As dsLab06TableAdapters.datEnemyTableAdapter
    Friend WithEvents DsLab06BindingSource1 As BindingSource
    Friend WithEvents DatEnemyBindingSource1 As BindingSource
End Class
