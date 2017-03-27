Option Strict On

Imports System.ComponentModel

Public Class frmMain
    Private Sub frmEnemiesofTheSecondOrder_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call setDefaults()
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
        Call frmEnemyEditor.populateEnemyData(Me.dgvEnemiesofSecondOrder.CurrentCell.RowIndex)
        frmEnemyEditor.Show()
    End Sub

    Private Sub btnAddNew_Click(sender As Object, e As EventArgs) Handles btnAddNew.Click
        frmEnemyEditor.Show()
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        Call frmEnemyEditor.populateEnemyData(Me.dgvEnemiesofSecondOrder.CurrentCell.RowIndex)
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

    Private Sub setDefaults()
        Me.dgvEnemiesofSecondOrder.ForeColor = Color.Black
    End Sub

    Public Sub saveOrCreateEnemy()
        Dim e As New DBL.Tables.datEnemy

        e.firstName = frmEnemyEditor.txtFirstName.Text
        e.lastName = frmEnemyEditor.txtLastName.Text
        e.allianceID = CInt(frmEnemyEditor.cboAlliance.SelectedValue)          ' need to make sure the value member is set
        e.threatLevelID = CInt(frmEnemyEditor.cboThreatLevel.SelectedValue)     ' need to make sure the value member is set
        e.notes = ""

        If frmEnemyEditor.txtFirstName.Text.Trim = String.Empty Or frmEnemyEditor.txtLastName.Text.Trim = String.Empty Then
            MsgBox("You must enter valid data in the first name and last name fields", 0, "Input Error")

        Else
            Dim Temp As Integer = Nothing
            Dim IsNewRecord As Boolean = False
            IsNewRecord = IsNewRecord = Integer.TryParse(frmEnemyEditor.lblEnemyIDNumber.Text, Temp)

            Console.WriteLine("Is New?: " & IsNewRecord.ToString & " temp value = " & Temp.ToString)

            If Not IsNewRecord Then
                e.enemyID = Temp
                e.notes = DBL.Tables.datEnemy.getOneRow(e.enemyID).notes.ToString
                DBL.Tables.datEnemy.updateExistingRow(e)
                Console.WriteLine("Updating")

            Else
                DBL.Tables.datEnemy.insertNewRow(e)
                Console.WriteLine("Creating")

            End If
        End If


    End Sub

    Public Sub populateDataGrid()
        ' Declare table object
        Dim TableData As List(Of DBL.Views.Enemies) = DBL.Views.Enemies.getEnemyList()

        Me.dgvEnemiesofSecondOrder.DataSource = Nothing
        Me.dgvEnemiesofSecondOrder.DataSource = TableData


    End Sub



    Public Sub populateComboBoxes()

    End Sub

    Private Sub MenuRefreshEnemies_Click(sender As Object, e As EventArgs) Handles MenuRefreshEnemies.Click
        Call populateDataGrid()
    End Sub

    Private Sub MenuDeleteCurrent_Click(sender As Object, e As EventArgs) Handles MenuDeleteCurrent.Click

    End Sub
End Class
