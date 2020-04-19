Public Class FrmHowtoPlay
    Private Sub btnHowtoPlay_Click(sender As Object, e As EventArgs) Handles btnHowtoPlay.Click
        Dim butt As Button = DirectCast(sender, Button)
        Controls.Remove(h1)
        Controls.Remove(h2)
        Controls.Remove(h3)
        Controls.Remove(h4)
        Controls.Remove(h5)
        Controls.Remove(h6)
        Controls.Remove(h7)

        pic2.BringToFront()
        pic1.BringToFront()
        h8.Visible = True
        h1.BringToFront()
        pic3.BringToFront()
        h9.Visible = True
        h10.Visible = True
        btnHowtoPlay.BringToFront()
        pic4.BringToFront()
        h11.Visible = True
        btnHowtoPlay2.Visible = True
        h12.Visible = True
        Controls.Remove(butt)
        btnHowtoplay3.Visible = True
    End Sub

    Private Sub btnHowtoPlay2_Click(sender As Object, e As EventArgs) Handles btnHowtoPlay2.Click
        Controls.Add(h1)
        Controls.Add(h2)
        Controls.Add(h3)
        Controls.Add(h4)
        Controls.Add(h5)
        Controls.Add(h6)
        Controls.Add(h7)
        h8.Visible = False
        h9.Visible = False
        h10.Visible = False
        h11.Visible = False
        h12.Visible = False
        btnHowtoplay3.Visible = False
        Controls.Add(btnHowtoPlay)
        btnHowtoplay3.BringToFront()
    End Sub

    Private Sub btnHowtoplay3_Click(sender As Object, e As EventArgs) Handles btnHowtoplay3.Click
        h8.Visible = False
        h9.Visible = False
        h10.Visible = False
        h11.Visible = False
        h12.Visible = False

        h13.Visible = True
        h14.Visible = True
        h15.Visible = True
        h15.BringToFront()
        btnHowtoPlay4.Visible = True
        btnHowtoPlay4.BringToFront()
        btnHowtoPlay5.Visible = True
    End Sub

    Private Sub btnHowtoPlay4_Click(sender As Object, e As EventArgs) Handles btnHowtoPlay4.Click
        Me.Close()
    End Sub

    Private Sub btnHowtoPlay5_Click(sender As Object, e As EventArgs) Handles btnHowtoPlay5.Click
        h13.Visible = False
        h14.Visible = False
        h15.Visible = False

        Controls.Remove(h1)
        Controls.Remove(h2)
        Controls.Remove(h3)
        Controls.Remove(h4)
        Controls.Remove(h5)
        Controls.Remove(h6)
        Controls.Remove(h7)

        h8.Visible = True
        h9.Visible = True
        h10.Visible = True
        h11.Visible = True
        h12.Visible = True
        btnHowtoPlay6.Visible = True
        btnHowtoPlay6.BringToFront()
    End Sub

    Private Sub btnHowtoPlay6_Click(sender As Object, e As EventArgs) Handles btnHowtoPlay6.Click
        Dim butt As Button = DirectCast(sender, Button)
        Controls.Add(h1)
        Controls.Add(h2)
        Controls.Add(h3)
        Controls.Add(h4)
        Controls.Add(h5)
        Controls.Add(h6)
        Controls.Add(h7)

        h8.Visible = False
        h9.Visible = False
        h10.Visible = False
        h11.Visible = False
        h12.Visible = False

        btnHowtoPlay4.Visible = False
        btnHowtoplay3.Visible = False
        btnHowtoPlay5.Visible = False
        btnHowtoPlay2.Visible = False
        btnHowtoPlay5.Visible = False
        butt.Visible = False

        Controls.Add(btnHowtoPlay)
    End Sub
End Class