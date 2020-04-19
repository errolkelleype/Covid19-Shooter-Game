Public Class frmMain
    Dim SRight As Boolean
    Dim SLeft As Boolean
    Dim ShooterSpeed As Integer
    Dim shotSpeed As Integer
    Public score As Integer = 0
    Dim maxMissileNumber As Integer = 4
    Dim missileArray(maxMissileNumber) As PictureBox
    Dim missileNumber As Integer = 0
    Dim missileOnScreen(maxMissileNumber) As Boolean
    Dim maxEnemyNumber As Integer = 4
    Dim enemyArray(maxEnemyNumber) As PictureBox
    Dim enemyOnScreen(maxEnemyNumber) As Boolean
    Dim enemySpeed As Single = 5
    Dim life As Integer
    Dim Form2 As New frmGameOver
    Dim pause As Boolean

    Private Sub TmrMain_Tick(sender As Object, e As EventArgs) Handles TmrMain.Tick
        Dim i As Integer
        Dim j As Integer
        moveShooter()
        lblScore.Text = score

        For i = 0 To maxMissileNumber
            If missileOnScreen(i) = True Then
                missileArray(i).Top -= 4
            End If

            If missileArray(i).Top <= -50 Then
                missileOnScreen(i) = False

            End If


            For j = 0 To maxEnemyNumber
                If Collision(missileArray(i), enemyArray(j)) Then
                    My.Computer.Audio.Play(My.Resources.squirt, AudioPlayMode.Background)
                    enemyArray(j).Top = -50
                    enemyArray(j).Left = Int(Rnd() * Me.Width)
                    missileArray(i).Visible = False
                    score += 1
                End If
            Next
        Next
    End Sub

    Private Sub frmMain_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        Dim count As Integer = 1
        If e.KeyValue = Keys.Right Then
            SRight = True
            SLeft = False
        End If
        If e.KeyValue = Keys.Left Then
            SLeft = True
            SRight = False
        End If

        If e.KeyValue = Keys.Space Then

            For i As Integer = 0 To maxMissileNumber
                If missileOnScreen(i) = True Then
                    count = count + 1
                End If
            Next
            If count <= maxMissileNumber Then
                missileOnScreen(missileNumber) = True
                missileArray(missileNumber).Visible = True
                missileArray(missileNumber).Top = Shooter.Top + Shooter.Height / 2 - missileArray(missileNumber).Height / 2
                missileArray(missileNumber).Left = Shooter.Left + Shooter.Width / 2 - missileArray(missileNumber).Width / 2
                missileNumber += 1
                If missileNumber = maxMissileNumber Then missileNumber = 0
            End If
        End If
    End Sub

    Private Sub moveShooter()
        If SRight = True And Shooter.Left + Shooter.Width < Me.ClientRectangle.Width Then
            Shooter.Left += ShooterSpeed
        End If
        If SLeft = True And Shooter.Left > Me.ClientRectangle.Left Then
            Shooter.Left -= ShooterSpeed
        End If
    End Sub

    Private Sub frmMain_KeyUp(sender As Object, e As KeyEventArgs) Handles MyBase.KeyUp
        If e.KeyValue = Keys.Right Then
            SRight = False
        End If
        If e.KeyValue = Keys.Left Then
            SLeft = False
        End If
    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        pause = False
        loadSettings()
        CreateMissile(maxMissileNumber)
        CreateEnemies(maxEnemyNumber)
        Randomize()

    End Sub

    Private Sub loadSettings()
        shotSpeed = 11
        ShooterSpeed = 5
        Shot.Visible = False
    End Sub

    Private Sub CreateMissile(ByVal number As Integer)
        For i As Integer = 0 To number
            Dim missile As New PictureBox
            Me.Controls.Add(missile)
            missile.Image = My.Resources.alc
            missile.Width = 20
            missile.Height = 40
            missile.BackColor = Color.Transparent
            missile.SizeMode = PictureBoxSizeMode.StretchImage
            missile.Top = Shooter.Top + Shooter.Height / 2 - missile.Height / 2
            missile.Left = Shooter.Left + Shooter.Width / 2 - missile.Width / 2

            missileArray(i) = missile
            missileArray(i).Visible = False
            missileOnScreen(i) = False
        Next
    End Sub

    Private Sub CreateEnemies(ByVal number As Integer)
        For i As Integer = 0 To number
            Dim missile As New PictureBox
            Me.Controls.Add(missile)
            missile.Image = My.Resources.virus
            missile.Width = 50
            missile.Height = 40
            missile.BackColor = Color.Transparent
            missile.SizeMode = PictureBoxSizeMode.StretchImage
            missile.Top = -50
            missile.Left = i * 130

            enemyArray(i) = missile
            enemyArray(i).Visible = True
            enemyOnScreen(i) = True
        Next
    End Sub

    Private Function Collision(ByVal Object1 As Object, ByVal Object2 As Object) As Boolean
        Dim Collided As Boolean = False
        If Object1.Top + Object1.Height >= Object2.Top And
            Object2.Top + Object2.Height >= Object1.Top And
            Object1.Left + Object1.Width >= Object2.Left And
            Object2.Left + Object2.Width >= Object1.Left And Object1.visible = True And Object2.visible = True Then
            Collided = True
        End If
        Return Collided
    End Function

    Private Sub enemyTimer_Tick(sender As Object, e As EventArgs) Handles enemyTimer.Tick
        Dim i As Integer = 0
        Dim random As Double

        For i = 0 To maxEnemyNumber
            enemyArray(i).Top += enemySpeed

            If enemyArray(i).Top > Me.Height - 90 Then
                My.Computer.Audio.Play(My.Resources.gameOver, AudioPlayMode.Background)
                TmrMain.Stop()
                enemyTimer.Stop()
                Form2.Show()
                Me.Hide()
                Form2.TxtScore.Text = score
            End If
            random = Rnd()
            If random > 0.66 Then
                enemyArray(i).Left += 6
            ElseIf random < 0.33 Then
                enemyArray(i).Left -= 6
            End If
            If enemyArray(i).Left < 5 Then
                enemyArray(i).Left += 10
            End If
            If enemyArray(i).Left > (Me.Width - 80) Then
                enemyArray(i).Left -= 10
            End If
        Next
    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim butt As Button = DirectCast(sender, Button)
        My.Computer.Audio.Play(My.Resources.play, AudioPlayMode.Background)
        TmrMain.Start()
        enemyTimer.Start()
        Controls.Remove(butt)
        Controls.Remove(btnHowtoPlay)
        Controls.Remove(lblSign)
        Controls.Remove(pic1)
        Controls.Remove(pic2)
        Controls.Remove(pic3)
        Controls.Remove(pic4)
        Controls.Remove(pic5)
        Shooter.Visible = True

    End Sub

    Private Sub btnHowtoPlay_Click(sender As Object, e As EventArgs) Handles btnHowtoPlay.Click
        My.Computer.Audio.Play(My.Resources.play, AudioPlayMode.Background)
        FrmHowtoPlay.Show()
    End Sub

    Private Sub frmMain_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MyBase.KeyPress
        If e.KeyChar = "P" Or e.KeyChar = "p" Then
            If pause = True Then
                TmrMain.Enabled = True
                enemyTimer.Enabled = True
                pause = False
            Else
                TmrMain.Enabled = False
                enemyTimer.Enabled = False
                pause = True
            End If
        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        If pause = True Then
            TmrMain.Enabled = True
            enemyTimer.Enabled = True
            pause = False
        Else
            TmrMain.Enabled = False
            enemyTimer.Enabled = False
            pause = True
        End If
    End Sub
End Class
