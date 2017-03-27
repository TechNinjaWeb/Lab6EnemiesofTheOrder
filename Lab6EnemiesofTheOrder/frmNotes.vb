Option Strict On
Public Class frmNotes
    Dim FakeData As New DBL.Views.Enemies

    Private Sub frmNotes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FakeData = DBL.Views.Enemies.getOneRow(0)
        Me.rtbEnemy.Text = FakeData.notes
        'Console.WriteLine("Fake Data: " & FakeData.allianceName)
    End Sub
#Region "---------- MenuStrip Event Handlers ----------"
    Private Sub SaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem.Click
        Call saveNotes(Me.rtbEnemy.Text)
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
    Public Sub saveNotes(Content As String)
        FakeData = DBL.Views.Enemies.getOneRow(0)

        Dim e As New DBL.Tables.datEnemy
        e = DBL.Tables.datEnemy.getOneRow(0)
        e.notes = Me.rtbEnemy.Text

        DBL.Tables.datEnemy.updateExistingRow(e)

        Call frmMain.populateDataGrid()

    End Sub

#End Region
End Class