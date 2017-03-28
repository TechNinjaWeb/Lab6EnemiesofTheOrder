Option Strict On

Imports System.IO
Public Class frmNotes
    Private Sub frmNotes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim EnemyData As New DBL.Views.Enemies
        EnemyData = DBL.Views.Enemies.getOneRow(CInt(frmMain.dgvEnemiesofSecondOrder.CurrentCell.RowIndex))
        Me.rtbEnemy.Text = EnemyData.notes

    End Sub
#Region "---------- MenuStrip Event Handlers ----------"
    Private Sub SaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem.Click
        Call saveNotes(CInt(frmMain.dgvEnemiesofSecondOrder.CurrentCell.RowIndex))
        Me.Close()
    End Sub

    Private Sub LoadFromFileToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LoadFromFileToolStripMenuItem.Click
        Dim FileName As String = OpenFile()
        frmMain.tsMainFormStatus.Text = FileName
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

    Private Function OpenFile() As String
        Dim RetVal As String = String.Empty ' Serves as the return value
        Dim FS As FileStream = Nothing      ' Initialized to Nothing. Must be set first without NEW

        Dim OpenD As New OpenFileDialog
        OpenD.Filter = "Text Files|*.txt"
        OpenD.Multiselect = False
        OpenD.ShowDialog()

        RetVal = OpenD.FileName

        If Not RetVal = Nothing Then
            Try
                FS = New FileStream(RetVal, FileMode.Open, FileAccess.Read)       ' Instantiate the FS object as NEW
                Dim TxtIn As New StreamReader(FS)

                Do While TxtIn.Peek <> -1
                    Me.rtbEnemy.AppendText(TxtIn.ReadLine & vbCrLf)
                Loop
            Catch ex As Exception
                MsgBox("Error: " & Err.Description)
            Finally
                FS.Close()
            End Try
        End If


        Return RetVal
    End Function

#End Region
End Class