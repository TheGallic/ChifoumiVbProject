<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnPlay = New System.Windows.Forms.Button()
        Me.BtnStop = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.CpbCountDown = New CircularProgressBar.CircularProgressBar()
        Me.LblScore = New System.Windows.Forms.Label()
        Me.LblSteps = New System.Windows.Forms.Label()
        Me.LblResultat = New System.Windows.Forms.Label()
        Me.BtnPierre = New System.Windows.Forms.Button()
        Me.BtnPapier = New System.Windows.Forms.Button()
        Me.BtnCiseaux = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(53, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(466, 89)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Jeux du chifoumi en 10 étapes." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Pour commencer cliquez sur le bouton jouer." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Puis" &
    " cliquez sur l'image de votre choix." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Vous avez 10 secondes entre chaques étapes" &
    " pour faire un choix." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'BtnPlay
        '
        Me.BtnPlay.Location = New System.Drawing.Point(57, 272)
        Me.BtnPlay.Name = "BtnPlay"
        Me.BtnPlay.Size = New System.Drawing.Size(150, 37)
        Me.BtnPlay.TabIndex = 4
        Me.BtnPlay.Text = "Jouer"
        Me.BtnPlay.UseVisualStyleBackColor = True
        '
        'BtnStop
        '
        Me.BtnStop.Enabled = False
        Me.BtnStop.Location = New System.Drawing.Point(369, 272)
        Me.BtnStop.Name = "BtnStop"
        Me.BtnStop.Size = New System.Drawing.Size(108, 37)
        Me.BtnStop.TabIndex = 5
        Me.BtnStop.Text = "Stop"
        Me.BtnStop.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'CpbCountDown
        '
        Me.CpbCountDown.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner
        Me.CpbCountDown.AnimationSpeed = 500
        Me.CpbCountDown.BackColor = System.Drawing.Color.Transparent
        Me.CpbCountDown.Font = New System.Drawing.Font("Microsoft Sans Serif", 72.0!, System.Drawing.FontStyle.Bold)
        Me.CpbCountDown.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.CpbCountDown.InnerColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.CpbCountDown.InnerMargin = 2
        Me.CpbCountDown.InnerWidth = -1
        Me.CpbCountDown.Location = New System.Drawing.Point(244, 257)
        Me.CpbCountDown.MarqueeAnimationSpeed = 2000
        Me.CpbCountDown.Maximum = 10
        Me.CpbCountDown.Name = "CpbCountDown"
        Me.CpbCountDown.OuterColor = System.Drawing.Color.Gray
        Me.CpbCountDown.OuterMargin = -25
        Me.CpbCountDown.OuterWidth = 26
        Me.CpbCountDown.ProgressColor = System.Drawing.Color.Green
        Me.CpbCountDown.ProgressWidth = 25
        Me.CpbCountDown.SecondaryFont = New System.Drawing.Font("Microsoft Sans Serif", 36.0!)
        Me.CpbCountDown.Size = New System.Drawing.Size(80, 77)
        Me.CpbCountDown.StartAngle = 270
        Me.CpbCountDown.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.CpbCountDown.SubscriptColor = System.Drawing.Color.FromArgb(CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.CpbCountDown.SubscriptMargin = New System.Windows.Forms.Padding(10, -35, 0, 0)
        Me.CpbCountDown.SubscriptText = ""
        Me.CpbCountDown.SuperscriptColor = System.Drawing.Color.FromArgb(CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.CpbCountDown.SuperscriptMargin = New System.Windows.Forms.Padding(10, 35, 0, 0)
        Me.CpbCountDown.SuperscriptText = ""
        Me.CpbCountDown.TabIndex = 6
        Me.CpbCountDown.TextMargin = New System.Windows.Forms.Padding(8, 8, 0, 0)
        Me.CpbCountDown.Value = 10
        '
        'LblScore
        '
        Me.LblScore.Location = New System.Drawing.Point(52, 360)
        Me.LblScore.Name = "LblScore"
        Me.LblScore.Size = New System.Drawing.Size(123, 24)
        Me.LblScore.TabIndex = 7
        Me.LblScore.Text = "Score : 0"
        '
        'LblSteps
        '
        Me.LblSteps.AutoSize = True
        Me.LblSteps.Location = New System.Drawing.Point(365, 360)
        Me.LblSteps.Name = "LblSteps"
        Me.LblSteps.Size = New System.Drawing.Size(139, 24)
        Me.LblSteps.TabIndex = 8
        Me.LblSteps.Text = "Etapes 0 sur 10"
        '
        'LblResultat
        '
        Me.LblResultat.Location = New System.Drawing.Point(53, 406)
        Me.LblResultat.Name = "LblResultat"
        Me.LblResultat.Size = New System.Drawing.Size(451, 27)
        Me.LblResultat.TabIndex = 9
        Me.LblResultat.Text = "En attente d'une nouvelle partie"
        '
        'BtnPierre
        '
        Me.BtnPierre.Enabled = False
        Me.BtnPierre.Image = Global.ChifoumiVbProject.My.Resources.Resource1.Pierre
        Me.BtnPierre.Location = New System.Drawing.Point(57, 101)
        Me.BtnPierre.Name = "BtnPierre"
        Me.BtnPierre.Size = New System.Drawing.Size(150, 150)
        Me.BtnPierre.TabIndex = 10
        Me.BtnPierre.UseVisualStyleBackColor = True
        '
        'BtnPapier
        '
        Me.BtnPapier.BackgroundImage = Global.ChifoumiVbProject.My.Resources.Resource1.Papier
        Me.BtnPapier.Enabled = False
        Me.BtnPapier.Image = Global.ChifoumiVbProject.My.Resources.Resource1.Papier
        Me.BtnPapier.Location = New System.Drawing.Point(213, 101)
        Me.BtnPapier.Name = "BtnPapier"
        Me.BtnPapier.Size = New System.Drawing.Size(150, 150)
        Me.BtnPapier.TabIndex = 11
        Me.BtnPapier.UseVisualStyleBackColor = True
        '
        'BtnCiseaux
        '
        Me.BtnCiseaux.Enabled = False
        Me.BtnCiseaux.Image = Global.ChifoumiVbProject.My.Resources.Resource1.Ciseaux
        Me.BtnCiseaux.Location = New System.Drawing.Point(369, 101)
        Me.BtnCiseaux.Name = "BtnCiseaux"
        Me.BtnCiseaux.Size = New System.Drawing.Size(150, 150)
        Me.BtnCiseaux.TabIndex = 12
        Me.BtnCiseaux.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(587, 461)
        Me.Controls.Add(Me.BtnCiseaux)
        Me.Controls.Add(Me.BtnPapier)
        Me.Controls.Add(Me.BtnPierre)
        Me.Controls.Add(Me.LblResultat)
        Me.Controls.Add(Me.LblSteps)
        Me.Controls.Add(Me.LblScore)
        Me.Controls.Add(Me.CpbCountDown)
        Me.Controls.Add(Me.BtnStop)
        Me.Controls.Add(Me.BtnPlay)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(6)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Chifoumi"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnPlay As Button
    Friend WithEvents BtnStop As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents CpbCountDown As CircularProgressBar.CircularProgressBar
    Friend WithEvents LblScore As Label
    Friend WithEvents LblSteps As Label
    Friend WithEvents LblResultat As Label
    Friend WithEvents BtnPierre As Button
    Friend WithEvents BtnPapier As Button
    Friend WithEvents BtnCiseaux As Button
End Class
