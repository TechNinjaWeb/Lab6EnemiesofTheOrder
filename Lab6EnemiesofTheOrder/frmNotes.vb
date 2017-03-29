Option Strict On

Imports System.IO
Public Class frmNotes
    Private Sub frmNotes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim EnemyData As New DBL.Views.Enemies
        EnemyData = DBL.Views.Enemies.getOneRow(CInt(frmMain.dgvEnemiesofSecondOrder.CurrentCell.RowIndex) + 1)

        Me.lblEnemyInfo.Text = "Enemy ID:" & EnemyData.enemyID.ToString & "   " & EnemyData.firstName _
            & " " & EnemyData.lastName
        Me.rtbEnemy.Text = EnemyData.notes

    End Sub
#Region "---------- MenuStrip Event Handlers ----------"
    Private Sub SaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem.Click
        Call saveNotes(CInt(frmMain.dgvEnemiesofSecondOrder.CurrentCell.RowIndex))
        Me.Close()
    End Sub

    Private Sub LoadFromFileToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LoadFromFileToolStripMenuItem.Click
        Me.rtbEnemy.Clear()
        Dim FileName As String = OpenFile()
        frmMain.tsMainFormStatus.Text = FileName
    End Sub

    Private Sub ExportToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExportToolStripMenuItem.Click
        Call SaveFile(Me.stsNotes.Text, Me.rtbEnemy.Text)
    End Sub

    Private Sub CopyCtrlCToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CopyCtrlCToolStripMenuItem.Click
        Call Clipboard.Clear()
        If Not Me.rtbEnemy.SelectedText = Nothing Then Call Clipboard.SetText(Me.rtbEnemy.SelectedText)
    End Sub

    Private Sub CutCtrlXToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CutCtrlXToolStripMenuItem.Click
        If Me.rtbEnemy.SelectedText <> "" Then
            Dim Copied As String = Me.rtbEnemy.SelectedText
            Call Clipboard.SetText(Copied)
            Me.rtbEnemy.Cut()
            Console.WriteLine("Copying Text: " & Clipboard.GetText())
        End If
    End Sub

    Private Sub PasteCtrlVToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PasteCtrlVToolStripMenuItem.Click
        Me.rtbEnemy.Paste()
    End Sub

    Private Sub ClearAllToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClearAllToolStripMenuItem.Click
        Me.rtbEnemy.Clear()
    End Sub

    Private Sub WordWrapFalseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles tsWordWrap.Click
        Me.rtbEnemy.WordWrap = Not Me.rtbEnemy.WordWrap
        Me.tsWordWrap.Text = "Word Wrap (" & Me.rtbEnemy.WordWrap.ToString & ")"
    End Sub



#End Region

#Region "---------- MenuStrip Subroutines ----------"
    Public Sub saveNotes(ID As Integer)
        Dim EnemyData As New DBL.Tables.datEnemy
        EnemyData = DBL.Tables.datEnemy.getOneRow(ID + 1)

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

    Private Sub SaveFile(FileName As String, Content As String)
        Dim saveFileDialog1 As New SaveFileDialog()
        saveFileDialog1.Filter = "Text File|*.txt"
        saveFileDialog1.Title = "Save Note As Text File"
        saveFileDialog1.ShowDialog()

        Console.WriteLine("FilePath: " & saveFileDialog1.FileName.ToString)
        Me.stsNotes.Text = saveFileDialog1.FileName.ToString
        My.Computer.FileSystem.WriteAllText(FileName, Content, False)

    End Sub



#End Region
End Class