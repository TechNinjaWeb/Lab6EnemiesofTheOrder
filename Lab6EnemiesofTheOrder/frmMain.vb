Imports System.ComponentModel

Public Class frmMain
    Private Sub frmEnemiesofTheSecondOrder_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call populateDataGrid()

    End Sub



    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        frmAbout.Show()

    End Sub

    Private Sub MenuExit_Click(sender As Object, e As EventArgs) Handles MenuExit.Click
        End
    End Sub

    Private Sub MenuAddNew_Click(sender As Object, e As EventArgs) Handles MenuAddNew.Click
        frmEnemyEditor.Show()
    End Sub

    Private Sub MenuEditCurrent_Click(sender As Object, e As EventArgs) Handles MenuEditCurrent.Click
        Call Me.populateEditor(Me.dgvEnemiesofSecondOrder.SelectedRows)
        frmEnemyEditor.Show()
    End Sub

    Private Sub btnAddNew_Click(sender As Object, e As EventArgs) Handles btnAddNew.Click
        frmEnemyEditor.Show()
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        frmEnemyEditor.Show()
    End Sub

    Private Sub frmMain_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        For Each f As Form In My.Application.OpenForms
            f.Close()
        Next
    End Sub

    Private Sub MenuNotes_Click(sender As Object, e As EventArgs) Handles MenuNotes.Click
        frmNotes.Show()
    End Sub

    Private Sub btnNotes_Click(sender As Object, e As EventArgs) Handles btnNotes.Click
        frmNotes.Show()
    End Sub

    Public Sub saveOrCreateEnemy()
        Dim e As New DBL.Tables.datEnemy

        'e.enemyID = CInt(frmEnemyEditor.lblEnemyIDNumber.Text)
        e.enemyID = 1
        e.firstName = frmEnemyEditor.txtFirstName.Text
        e.lastName = frmEnemyEditor.txtLastName.Text
        e.allianceID = CInt(frmEnemyEditor.cboAlliance.Text)          ' need to make sure the value member is set
        e.threatLevelID = CInt(frmEnemyEditor.cboThreatLevel.Text)     ' need to make sure the value member is set
        e.notes = ""


        'If CInt(frmEnemyEditor.lblEnemyID.Text) > 0 Then
        '    DBL.Tables.datEnemy.updateExistingRow(e)

        'Else
        'MsgBox("A Record could not be found to update. One has been created for you.")
        DBL.Tables.datEnemy.insertNewRow(e)
        'End If

        ''Populate data grid view

        'Me.dgvEnemiesofSecondOrder.DataSource = Nothing
        'Me.dgvEnemiesofSecondOrder.DataSource = DBL.Views.Enemies.getEnemyList()
        'Me.dgvEnemiesofSecondOrder.DataSource = DBL.Tables.datEnemy.getAllRows()

    End Sub

    Public Sub populateDataGrid()
        ' Declare table object
        Dim TableData As List(Of DBL.Views.Enemies) = DBL.Views.Enemies.getEnemyList()

        Me.dgvEnemiesofSecondOrder.DataSource = Nothing
        Me.dgvEnemiesofSecondOrder.DataSource = TableData


    End Sub

    Public Sub populateEditor(Row As DataGridViewSelectedRowCollection)

        If Row IsNot Nothing Then
            For Each R As DataGridViewRow In Row
                Console.Write("Row is: ")
                Console.WriteLine(R.ToString)
            Next

        End If
    End Sub

    Private Sub MenuRefreshEnemies_Click(sender As Object, e As EventArgs) Handles MenuRefreshEnemies.Click
        Call populateDataGrid()
    End Sub

    Private Sub MenuDeleteCurrent_Click(sender As Object, e As EventArgs) Handles MenuDeleteCurrent.Click

    End Sub
End Class
