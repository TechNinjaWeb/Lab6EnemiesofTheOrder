Option Strict On
Public Class frmNotes
    Private Sub frmNotes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim EnemyData As New DBL.Views.Enemies
        EnemyData = DBL.Views.Enemies.getOneRow(CInt(frmMain.dgvEnemiesofSecondOrder.CurrentCell.RowIndex))
        Me.rtbEnemy.Text = EnemyData.notes

    End Sub
#Region "---------- MenuStrip Event Handlers ----------"
    Private Sub SaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem.Click
        Call saveNotes(CInt(frmMain.dgvEnemiesofSecondOrder.CurrentCell.RowIndex))
    End Sub

    Private Sub LoadFromFileToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LoadFromFileToolStripMenuItem.Click

    End Sub

    Private Sub ExportToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExportToolStripMenuItem.Click

    End Sub

    Private Sub CopyCtrlCToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CopyCtrlCToolStripMenuItem.Click

    End Sub

    Private Sub CutCtrlXToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CutCtrlXToolStripMenuItem.Click

    End Sub

    Private Sub PasteCtrlVToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PasteCtrlVToolStripMenuItem.Click

    End Sub

    Private Sub ClearAllToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClearAllToolStripMenuItem.Click

    End Sub

    Private Sub WordWrapFalseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles WordWrapFalseToolStripMenuItem.Click

    End Sub



#End Region

#Region "---------- MenuStrip Subroutines ----------"
    Public Sub saveNotes(ID As Integer)
        Dim EnemyData As New DBL.Tables.datEnemy
        EnemyData = DBL.Tables.datEnemy.getOneRow(ID)

        EnemyData.notes = Me.rtbEnemy.Text

        DBL.Tables.datEnemy.updateExistingRow(EnemyData)

        Call frmMain.populateDataGrid()

    End Sub

#End Region
End Class