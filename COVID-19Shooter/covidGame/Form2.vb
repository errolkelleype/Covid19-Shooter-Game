Public Class frmGameOver


    Private Sub btnTryAgain_Click(sender As Object, e As EventArgs) Handles btnTryAgain.Click
        Dim frmM As New frmMain
        frmM.Show()
        Me.Hide()
        My.Computer.Audio.Play(My.Resources.play, AudioPlayMode.Background)
        frmM.TmrMain.Start()

        frmM.enemyTimer.Start()
        frmM.Controls.Remove(frmM.Button1)
        frmM.Controls.Remove(frmM.btnHowtoPlay)
        frmM.Controls.Remove(frmM.lblSign)
        frmM.Controls.Remove(frmM.pic1)
        frmM.Controls.Remove(frmM.pic2)
        frmM.Controls.Remove(frmM.pic3)
        frmM.Controls.Remove(frmM.pic4)
        frmM.Controls.Remove(frmM.pic5)
        frmM.Shooter.Visible = True


    End Sub

    Private Sub frmGameOver_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class