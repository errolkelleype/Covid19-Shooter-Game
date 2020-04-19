<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmGameOver
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmGameOver))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.btnTryAgain = New System.Windows.Forms.Button()
        Me.TxtScore = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label1.Font = New System.Drawing.Font("MS Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(81, 78)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(143, 16)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "  TOTAL SCORE: "
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.BackColor = System.Drawing.Color.Transparent
        Me.lblStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblStatus.Font = New System.Drawing.Font("MS Gothic", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatus.ForeColor = System.Drawing.Color.Red
        Me.lblStatus.Location = New System.Drawing.Point(31, 20)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(270, 48)
        Me.lblStatus.TabIndex = 5
        Me.lblStatus.Text = "GAME OVER!"
        Me.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnTryAgain
        '
        Me.btnTryAgain.BackColor = System.Drawing.Color.Orange
        Me.btnTryAgain.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnTryAgain.Font = New System.Drawing.Font("MS Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTryAgain.Location = New System.Drawing.Point(98, 174)
        Me.btnTryAgain.Name = "btnTryAgain"
        Me.btnTryAgain.Size = New System.Drawing.Size(103, 46)
        Me.btnTryAgain.TabIndex = 9
        Me.btnTryAgain.Text = "Try Again"
        Me.btnTryAgain.UseVisualStyleBackColor = False
        '
        'TxtScore
        '
        Me.TxtScore.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TxtScore.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtScore.Font = New System.Drawing.Font("MS Gothic", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtScore.Location = New System.Drawing.Point(65, 97)
        Me.TxtScore.Name = "TxtScore"
        Me.TxtScore.ReadOnly = True
        Me.TxtScore.Size = New System.Drawing.Size(175, 64)
        Me.TxtScore.TabIndex = 10
        Me.TxtScore.Text = "00"
        Me.TxtScore.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'frmGameOver
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(317, 236)
        Me.Controls.Add(Me.TxtScore)
        Me.Controls.Add(Me.btnTryAgain)
        Me.Controls.Add(Me.lblStatus)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmGameOver"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "COVID-19 Shooter"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents lblStatus As Label
    Friend WithEvents btnTryAgain As Button
    Friend WithEvents TxtScore As TextBox
End Class
