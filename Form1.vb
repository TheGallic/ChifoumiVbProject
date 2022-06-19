Public Class Form1
    Dim userChoice As String = ""
    Dim botChoice As String = ""
    Dim pbValue As Integer = 10
    Dim stepsNumber As Integer = 1
    Dim userScore As Integer = 0
    Dim listChoice() As String = {"Pierre", "Papier", "Ciseaux"}
    Dim random As New Random()
    Dim rdm As Integer
    Dim matchResult As String




    Private Sub BtnStop_Click(sender As Object, e As EventArgs) Handles BtnStop.Click
        StopChifoumi()
    End Sub


    Private Sub BtnPlay_Click(sender As Object, e As EventArgs) Handles BtnPlay.Click
        BtnPierre.Enabled = True
        BtnPapier.Enabled = True
        BtnCiseaux.Enabled = True
        BtnStop.Enabled = True
        BtnPlay.Enabled = False
        Timer1.Start()

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        If pbValue >= 0 Then
            CpbCountDown.Value = pbValue
            ' On change la couleur de la barre de progression suivant son état d'avancement
            If pbValue > 7 Then
                CpbCountDown.ProgressColor = Color.Green
            ElseIf pbValue < 7 And pbValue > 5 Then
                CpbCountDown.ProgressColor = Color.Orange
            ElseIf pbValue < 5 And pbValue > 2 Then
                CpbCountDown.ProgressColor = Color.Yellow
            ElseIf pbValue < 2 Then
                CpbCountDown.ProgressColor = Color.Red
            End If

            pbValue -= 1
        Else
            'La partie est finie
            If stepsNumber = 10 Then
                StopChifoumi()
            Else
                stepsNumber += 1
                BtnPapier.Enabled = True
                BtnPierre.Enabled = True
                BtnCiseaux.Enabled = True
                LblScore.Text = "Score: " & userScore
                LblResultat.Text = "Jouer...."
                LblResultat.ForeColor = Color.Blue
            End If
            LblSteps.Text = "Etapes " & stepsNumber & " sur 10"
            ' Threading.Thread.Sleep(3000)
            pbValue = 10
        End If
    End Sub

    Private Sub StartGame()

        'on genere le choix aléatoire
        rdm = random.Next(0, 3)
        botChoice = listChoice.ElementAt(rdm).ToString
        getResult()
        If matchResult = "Perdu" Then
            LblResultat.Text = "Vous avez perdu, le bot a joué: " & botChoice
            LblResultat.ForeColor = Color.Red
        ElseIf matchResult = "Ex aequo" Then
            LblResultat.Text = "Vous etes Ex aequo, le bot a joué: " & botChoice
            LblResultat.ForeColor = Color.Violet
            userScore += 1
        ElseIf matchResult = "Gagné" Then
            LblResultat.Text = "Vous avez Gagné, le bot a joué: " & botChoice
            LblResultat.ForeColor = Color.Green
            userScore += 2
        End If
        LblScore.Text = "Score: " & userScore
    End Sub
    Private Sub StopChifoumi()
        BtnPierre.Enabled = False
        BtnPapier.Enabled = False
        BtnCiseaux.Enabled = False
        Timer1.Stop()
        Timer1.Dispose()
        MessageBox.Show("La partie est terminée, votre score est de: " & userScore)
        BtnPlay.Enabled = True
        BtnStop.Enabled = False
        userChoice = ""
        botChoice = ""
        matchResult = ""
        stepsNumber = 1
        userScore = 0
        pbValue = 10
        LblResultat.Text = "En attente d'une nouvelle partie"
        LblResultat.ForeColor = Color.Blue
        LblScore.Text = "Score: " & userScore
        LblSteps.Text = "Etapes " & stepsNumber & " sur 10"
    End Sub

    Private Sub getResult()
        Select Case userChoice
            Case "Pierre"
                If botChoice = "Pierre" Then matchResult = "Ex aequo"
                If botChoice = "Papier" Then matchResult = "Perdu"
                If botChoice = "Ciseaux" Then matchResult = "Gagné"
            Case "Papier"
                If botChoice = "Pierre" Then matchResult = "Gagné"
                If botChoice = "Papier" Then matchResult = "Ex aequo"
                If botChoice = "Ciseaux" Then matchResult = "Perdu"
            Case "Ciseaux"
                If botChoice = "Pierre" Then matchResult = "Perdu"
                If botChoice = "Papier" Then matchResult = "Gagné"
                If botChoice = "Ciseaux" Then matchResult = "Ex aequo"
        End Select
    End Sub

    Private Sub BtnPierre_Click(sender As Object, e As EventArgs) Handles BtnPierre.Click
        userChoice = "Pierre"
        BtnPapier.Enabled = False
        BtnPierre.Enabled = False
        BtnCiseaux.Enabled = False
        StartGame()
    End Sub

    Private Sub BtnPapier_Click(sender As Object, e As EventArgs) Handles BtnPapier.Click
        userChoice = "Papier"
        BtnPapier.Enabled = False
        BtnPierre.Enabled = False
        BtnCiseaux.Enabled = False
        StartGame()
    End Sub

    Private Sub BtnCiseaux_Click(sender As Object, e As EventArgs) Handles BtnCiseaux.Click
        userChoice = "Ciseaux"
        BtnPapier.Enabled = False
        BtnPierre.Enabled = False
        BtnCiseaux.Enabled = False
        StartGame()
    End Sub
End Class
