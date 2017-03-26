Public Class frmSplash
    Private Sub frmSplash_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()

        Dim ofd As New OpenFileDialog()
        ofd.Filter = "bild offnen (*.png)|*.png |ALL Files |*.*"
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        pbrEnemiesofSecondOrder.Increment(1)
        If pbrEnemiesofSecondOrder.Value = pbrEnemiesofSecondOrder.Maximum Then
            frmMain.Show()
            Me.Hide()
            Timer1.Stop()
        End If
    End Sub
End Class