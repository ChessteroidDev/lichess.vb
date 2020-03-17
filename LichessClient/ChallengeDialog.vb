Imports LichessApi

' Fenetre de dialogue pour créer un challenge
' personnalisé.
Public Class ChallengeDialog

    Private initialTime As Integer = 5
    Private increment As Integer = 5
    Private days As Integer = 2
    Private ReadOnly _api As LichessHttpClient

    'on transmet l'objet LichessHttpClient à la fenêtre dans le constructeur
    'vu que cette fenêtre fait un appele a la fonction SendChallengeAsync de l'API
    Public Sub New(ByRef api As LichessHttpClient)

        InitializeComponent()

        _api = api

    End Sub
    Private Sub ChallengeDialog_Load(sender As Object, e As EventArgs) Handles Me.Load

        TimeFormatComboBox.SelectedIndex = 0
        UsernameTextBox.Select()

    End Sub

    Private Sub MinutesTrackBar_Scroll(sender As Object, e As EventArgs) Handles MinutesTrackBar.Scroll

        Dim value = MinutesTrackBar.Value()

        'on convertit la valeur de la trackbar en minutes de la même
        'manière que sur lichess (voir bouton personnalisé sur l'accueil de lichess)
        If value < 4 Then
            IncrementTrackBar.Minimum = 6
            If increment < 5 Then
                increment = 5
                IncrementNumLabel.Text = 5
            End If
        Else
            IncrementTrackBar.Minimum = 1
        End If
        If value < 17 Then
            initialTime = 4 + value
        ElseIf value < 22 Then
            initialTime = 20 + (value - 16) * 5
        Else
            initialTime = 45 + (value - 21) * 15
        End If

        'les parties de moins de 1500 secondes estimées sont non classées (cf api board)
        If initialTime * 60 + increment * 40 < 1500 Then
            UnratedRadioButton.Checked = True
            RatedRadioButton.Enabled = False
        Else
            RatedRadioButton.Enabled = True
        End If
        MinutesNumLabel.Text = initialTime.ToString()

    End Sub

    Private Sub IncrementTrackBar_Scroll(sender As Object, e As EventArgs) Handles IncrementTrackBar.Scroll

        Dim value = IncrementTrackBar.Value

        'on convertit la valeur de la trackbar en secondes de la même
        'manière que sur lichess (voir bouton personnalisé sur l'accueil de lichess)
        If value < 22 Then
            increment = value - 1
        ElseIf value < 27 Then
            increment = 20 + (value - 21) * 5
        ElseIf value = 27 Then
            increment = 60
        Else
            increment = 60 + (value - 27) * 30
        End If

        'les parties de moins de 1500 secondes estimées sont non classées (cf api board)
        If initialTime * 60 + increment * 40 < 1500 Then
            UnratedRadioButton.Checked = True
            RatedRadioButton.Enabled = False
        Else
            RatedRadioButton.Enabled = True
        End If
        IncrementNumLabel.Text = increment.ToString()

    End Sub

    Private Sub DaysTrackBar_Scroll(sender As Object, e As EventArgs) Handles DaysTrackBar.Scroll

        ' ce controle est affiché seulement quand l'utilisateur selectionne "partie par correspondance"
        ' convertir en jours comme sur lichess
        Dim value = DaysTrackBar.Value

        If value < 4 Then
            days = value
        ElseIf value < 6 Then
            days = 3 + (value - 3) * 2
        ElseIf value = 6 Then
            days = 10
        Else
            days = 14
        End If
        DaysNumLabel.Text = days.ToString()

    End Sub

    'quand l'utilisateur sélectionne une cadence différente, on cache / affiche les controles utiles à cette cadence
    Private Sub TimeFormatComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TimeFormatComboBox.SelectedIndexChanged

        Dim selectedIndex = TimeFormatComboBox.SelectedIndex

        If selectedIndex = 0 Then
            DaysLabel.Hide()
            DaysNumLabel.Hide()
            DaysTrackBar.Hide()
            MinutesLabel.Show()
            MinutesNumLabel.Show()
            MinutesTrackBar.Show()
            IncrementLabel.Show()
            IncrementNumLabel.Show()
            IncrementTrackBar.Show()
            MinutesTrackBar.Enabled = True
            IncrementTrackBar.Enabled = True
            MinutesLabel.Enabled = True
            MinutesNumLabel.Enabled = True
            IncrementLabel.Enabled = True
            IncrementNumLabel.Enabled = True
            If initialTime * 60 + increment * 40 < 1500 Then
                UnratedRadioButton.Checked = True
                RatedRadioButton.Enabled = False
            End If
        ElseIf selectedIndex = 1 Then
            DaysLabel.Show()
            DaysNumLabel.Show()
            DaysTrackBar.Show()
            MinutesLabel.Hide()
            MinutesNumLabel.Hide()
            MinutesTrackBar.Hide()
            IncrementLabel.Hide()
            IncrementNumLabel.Hide()
            IncrementTrackBar.Hide()
            RatedRadioButton.Enabled = True
        Else
            DaysLabel.Hide()
            DaysNumLabel.Hide()
            DaysTrackBar.Hide()
            MinutesLabel.Show()
            MinutesNumLabel.Show()
            MinutesTrackBar.Show()
            IncrementLabel.Show()
            IncrementNumLabel.Show()
            IncrementTrackBar.Show()
            MinutesTrackBar.Enabled = False
            IncrementTrackBar.Enabled = False
            MinutesLabel.Enabled = False
            MinutesNumLabel.Enabled = False
            IncrementLabel.Enabled = False
            IncrementNumLabel.Enabled = False
            RatedRadioButton.Enabled = True
        End If
    End Sub

    'Gestion des clics sur les boutons envoyer
    Private Async Sub RandomButton_Click(sender As Object, e As EventArgs) Handles RandomButton.Click
        Await CreateChallenge("random")
        Close()
    End Sub

    Private Async Sub WhiteButton_Click(sender As Object, e As EventArgs) Handles WhiteButton.Click
        Await CreateChallenge("white")
        Close()
    End Sub

    Private Async Sub BlackButton_Click(sender As Object, e As EventArgs) Handles BlackButton.Click
        Await CreateChallenge("black")
        Close()
    End Sub

    'Envoi du challenge
    Private Async Function CreateChallenge(color As String) As Task
        Dim r As CreatedChallenge = Nothing
        Dim rated As Boolean

        If RatedRadioButton.Checked Then rated = True Else rated = False
        If Not String.IsNullOrEmpty(UsernameTextBox.Text) Then
            Select Case TimeFormatComboBox.SelectedIndex
                Case 0
                    r = Await _api.SendChallengeAsync(UsernameTextBox.Text, rated, initialTime * 60, increment, color)
                Case 1
                    r = Await _api.SendCorrespondenceChallengeAsync(UsernameTextBox.Text, rated, days, color)
                Case 2
                    r = Await _api.SendUnlimitedChallengeAsync(UsernameTextBox.Text, rated, color)
            End Select
            If r IsNot Nothing Then
                MainWindow.AddChallenge(r.Challenge)
            End If
        End If
    End Function
End Class
