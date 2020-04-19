<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.TmrMain = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblScore = New System.Windows.Forms.Label()
        Me.enemyTimer = New System.Windows.Forms.Timer(Me.components)
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnHowtoPlay = New System.Windows.Forms.Button()
        Me.lblSign = New System.Windows.Forms.Label()
        Me.pic5 = New System.Windows.Forms.PictureBox()
        Me.pic1 = New System.Windows.Forms.PictureBox()
        Me.pic3 = New System.Windows.Forms.PictureBox()
        Me.pic4 = New System.Windows.Forms.PictureBox()
        Me.pic2 = New System.Windows.Forms.PictureBox()
        Me.Shot = New System.Windows.Forms.PictureBox()
        Me.Shooter = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.pic5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Shot, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Shooter, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TmrMain
        '
        Me.TmrMain.Interval = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label1.Font = New System.Drawing.Font("MS Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(463, 414)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 16)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "SCORE: "
        '
        'lblScore
        '
        Me.lblScore.AutoSize = True
        Me.lblScore.BackColor = System.Drawing.Color.Transparent
        Me.lblScore.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblScore.Font = New System.Drawing.Font("MS Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblScore.Location = New System.Drawing.Point(539, 414)
        Me.lblScore.Name = "lblScore"
        Me.lblScore.Size = New System.Drawing.Size(17, 16)
        Me.lblScore.TabIndex = 4
        Me.lblScore.Text = "0"
        '
        'enemyTimer
        '
        Me.enemyTimer.Interval = 200
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Orange
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Font = New System.Drawing.Font("MS Gothic", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Location = New System.Drawing.Point(170, 117)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(213, 88)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "PLAY"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'btnHowtoPlay
        '
        Me.btnHowtoPlay.BackColor = System.Drawing.Color.Orange
        Me.btnHowtoPlay.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnHowtoPlay.Font = New System.Drawing.Font("MS Gothic", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHowtoPlay.ForeColor = System.Drawing.Color.Black
        Me.btnHowtoPlay.Location = New System.Drawing.Point(170, 226)
        Me.btnHowtoPlay.Name = "btnHowtoPlay"
        Me.btnHowtoPlay.Size = New System.Drawing.Size(213, 55)
        Me.btnHowtoPlay.TabIndex = 6
        Me.btnHowtoPlay.Text = "HOW TO PLAY"
        Me.btnHowtoPlay.UseVisualStyleBackColor = False
        '
        'lblSign
        '
        Me.lblSign.AutoSize = True
        Me.lblSign.BackColor = System.Drawing.Color.Transparent
        Me.lblSign.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblSign.Font = New System.Drawing.Font("MS Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSign.Location = New System.Drawing.Point(175, 325)
        Me.lblSign.Name = "lblSign"
        Me.lblSign.Size = New System.Drawing.Size(208, 12)
        Me.lblSign.TabIndex = 7
        Me.lblSign.Text = "Developed by: Errol Kelley Pe"
        '
        'pic5
        '
        Me.pic5.BackColor = System.Drawing.Color.Transparent
        Me.pic5.Image = Global.covidGame.My.Resources.Resources.shooter
        Me.pic5.Location = New System.Drawing.Point(44, 391)
        Me.pic5.Name = "pic5"
        Me.pic5.Size = New System.Drawing.Size(70, 39)
        Me.pic5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pic5.TabIndex = 12
        Me.pic5.TabStop = False
        '
        'pic1
        '
        Me.pic1.BackColor = System.Drawing.Color.Transparent
        Me.pic1.Image = Global.covidGame.My.Resources.Resources.alc
        Me.pic1.Location = New System.Drawing.Point(70, 193)
        Me.pic1.Name = "pic1"
        Me.pic1.Size = New System.Drawing.Size(17, 40)
        Me.pic1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pic1.TabIndex = 11
        Me.pic1.TabStop = False
        '
        'pic3
        '
        Me.pic3.BackColor = System.Drawing.Color.Transparent
        Me.pic3.Image = Global.covidGame.My.Resources.Resources.virus
        Me.pic3.Location = New System.Drawing.Point(212, 24)
        Me.pic3.Name = "pic3"
        Me.pic3.Size = New System.Drawing.Size(48, 44)
        Me.pic3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pic3.TabIndex = 10
        Me.pic3.TabStop = False
        '
        'pic4
        '
        Me.pic4.BackColor = System.Drawing.Color.Transparent
        Me.pic4.Image = Global.covidGame.My.Resources.Resources.virus
        Me.pic4.Location = New System.Drawing.Point(466, 132)
        Me.pic4.Name = "pic4"
        Me.pic4.Size = New System.Drawing.Size(47, 46)
        Me.pic4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pic4.TabIndex = 9
        Me.pic4.TabStop = False
        '
        'pic2
        '
        Me.pic2.BackColor = System.Drawing.Color.Transparent
        Me.pic2.Image = Global.covidGame.My.Resources.Resources.virus
        Me.pic2.Location = New System.Drawing.Point(55, 133)
        Me.pic2.Name = "pic2"
        Me.pic2.Size = New System.Drawing.Size(48, 44)
        Me.pic2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pic2.TabIndex = 8
        Me.pic2.TabStop = False
        '
        'Shot
        '
        Me.Shot.BackColor = System.Drawing.Color.Transparent
        Me.Shot.Image = Global.covidGame.My.Resources.Resources.alc
        Me.Shot.Location = New System.Drawing.Point(12, 390)
        Me.Shot.Name = "Shot"
        Me.Shot.Size = New System.Drawing.Size(17, 40)
        Me.Shot.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Shot.TabIndex = 1
        Me.Shot.TabStop = False
        '
        'Shooter
        '
        Me.Shooter.BackColor = System.Drawing.Color.Transparent
        Me.Shooter.Image = Global.covidGame.My.Resources.Resources.shooter
        Me.Shooter.Location = New System.Drawing.Point(238, 391)
        Me.Shooter.Name = "Shooter"
        Me.Shooter.Size = New System.Drawing.Size(70, 39)
        Me.Shooter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Shooter.TabIndex = 0
        Me.Shooter.TabStop = False
        Me.Shooter.Visible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(4, 408)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(27, 24)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 13
        Me.PictureBox1.TabStop = False
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(567, 435)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.pic5)
        Me.Controls.Add(Me.pic1)
        Me.Controls.Add(Me.pic3)
        Me.Controls.Add(Me.pic4)
        Me.Controls.Add(Me.pic2)
        Me.Controls.Add(Me.lblSign)
        Me.Controls.Add(Me.btnHowtoPlay)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lblScore)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Shot)
        Me.Controls.Add(Me.Shooter)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "COVID-19 Shooter"
        CType(Me.pic5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Shot, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Shooter, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Shooter As PictureBox
    Friend WithEvents TmrMain As Timer
    Friend WithEvents Shot As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lblScore As Label
    Friend WithEvents enemyTimer As Timer
    Friend WithEvents Button1 As Button
    Friend WithEvents btnHowtoPlay As Button
    Friend WithEvents lblSign As Label
    Friend WithEvents pic2 As PictureBox
    Friend WithEvents pic4 As PictureBox
    Friend WithEvents pic3 As PictureBox
    Friend WithEvents pic1 As PictureBox
    Friend WithEvents pic5 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
End Class
