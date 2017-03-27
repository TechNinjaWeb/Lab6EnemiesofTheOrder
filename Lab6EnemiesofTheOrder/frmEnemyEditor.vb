Option Strict On
Public Class frmEnemyEditor
    Private Sub frmEnemyEditor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim Temp As Integer
        Dim IsNewRecord As Boolean = Integer.TryParse(Me.lblEnemyIDNumber.Text, Temp)

        If Not IsNewRecord Then
            Console.WriteLine("Can't Get ID")
            Call Me.populateEnemyData()
        Else
            Console.WriteLine("Got ID: " & CInt(Me.lblEnemyIDNumber.Text))
            Call Me.populateEnemyData(frmMain.dgvEnemiesofSecondOrder.CurrentCell.RowIndex)
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Call frmMain.saveOrCreateEnemy()
        Call frmMain.populateDataGrid()
        Try

        Catch ex As Exception

        End Try
    End Sub

    Public Sub populateEnemyData()
        Dim EnemyData As New DBL.Views.Enemies

        Me.lblEnemyIDNumber.Text = "New Enemy"
        Me.txtFirstName.Text = EnemyData.firstName
        Me.txtLastName.Text = EnemyData.lastName
        Me.cboAlliance.DataSource = Nothing
        Me.cboAlliance.DataSource = DBL.Tables.lstAlliances.getAllRows()
        Me.cboAlliance.ValueMember = "allianceID"
        Me.cboAlliance.DisplayMember = "allianceName"
        Me.cboThreatLevel.DataSource = Nothing
        Me.cboThreatLevel.DataSource = DBL.Tables.lstThreatLevel.getAllRows()
        Me.cboThreatLevel.ValueMember = "levelID"
        Me.cboThreatLevel.DisplayMember = "threatLevel"
    End Sub
    Public Sub populateEnemyData(ID As Integer)
        Dim EnemyData As New DBL.Views.Enemies
        EnemyData = DBL.Views.Enemies.getOneRow(ID)

        Me.lblEnemyIDNumber.Text = EnemyData.enemyID.ToString
        Me.txtFirstName.Text = EnemyData.firstName
        Me.txtLastName.Text = EnemyData.lastName
        Me.cboAlliance.DataSource = Nothing
        Me.cboAlliance.DataSource = DBL.Tables.lstAlliances.getAllRows()
        Me.cboAlliance.ValueMember = "allianceID"
        Me.cboAlliance.DisplayMember = "allianceName"
        Me.cboAlliance.SelectedValue = EnemyData.allianceID
        Me.cboThreatLevel.DataSource = Nothing
        Me.cboThreatLevel.DataSource = DBL.Tables.lstThreatLevel.getAllRows()
        Me.cboThreatLevel.DisplayMember = "threatLevel"
        Me.cboThreatLevel.ValueMember = "levelID"


    End Sub
End Class