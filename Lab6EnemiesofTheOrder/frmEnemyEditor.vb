﻿Public Class frmEnemyEditor
    Private Sub frmEnemyEditor_Load(sender As Object, e As EventArgs) Handles MyBase.Load

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
End Class