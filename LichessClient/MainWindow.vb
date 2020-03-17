Imports System.ComponentModel
Imports LichessApi
' Fenêtre principale de l'application
Public Class MainWindow

    Private _loggedIn As Boolean = False
    Private ReadOnly _api As LichessHttpClient = New LichessHttpClient()
    Private ReadOnly _eventProgress = New Progress(Of LichessEvent)(AddressOf LichessEventHandler)
    Private _accountInformations As Account = Nothing

    ' Resize des boutons transparents
    Private Sub MainWindow_Resize(sender As Object, e As EventArgs) Handles Me.Resize

        ResizeButtons()

    End Sub

    Private Sub ResizeButtons()

        Dim w = (Index.Width() - 28) / 3
        Dim h = (Index.Height() - 28) / 3
        Dim newSize = New Size(w, h)

        RapidButton1.Size = newSize
        RapidButton2.Size = newSize
        RapidButton2.Left = 14 + w
        RapidButton3.Size = newSize
        RapidButton3.Left = 21 + 2 * w
        ClassicalButton1.Size = newSize
        ClassicalButton1.Top = 14 + h
        ClassicalButton2.Size = newSize
        ClassicalButton2.Left = 14 + w
        ClassicalButton2.Top = 14 + h
        ClassicalButton3.Size = newSize
        ClassicalButton3.Left = 21 + 2 * w
        ClassicalButton3.Top = 14 + h
        ClassicalButton4.Size = newSize
        ClassicalButton4.Top = 21 + 2 * h
        ClassicalButton5.Size = newSize
        ClassicalButton5.Left = 14 + w
        ClassicalButton5.Top = 21 + 2 * h
        CustomButton.Size = newSize
        CustomButton.Left = 21 + 2 * w
        CustomButton.Top = 21 + 2 * h
    End Sub

    ' Changement d'onglet dans le TabControl
    Private Sub TabControl_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TabControl.SelectedIndexChanged

        If TabControl.SelectedIndex = 0 Then
            ResizeButtons()
        End If

    End Sub

    ' Gestion des clics de boutons de l'index (rechercher un challenge aléatoire)
    Private Sub RapidButton1_Click(sender As Object, e As EventArgs) Handles RapidButton1.Click
        CreateSeek(1, 0)
    End Sub
    Private Sub RapidButton2_Click(sender As Object, e As EventArgs) Handles RapidButton2.Click
        CreateSeek(2, 1)
    End Sub
    Private Sub RapidButton3_Click(sender As Object, e As EventArgs) Handles RapidButton3.Click
        CreateSeek(3, 0)
    End Sub
    Private Sub ClassicalButton1_Click(sender As Object, e As EventArgs) Handles ClassicalButton1.Click
        CreateSeek(3, 2)
    End Sub
    Private Sub ClassicalButton2_Click(sender As Object, e As EventArgs) Handles ClassicalButton2.Click
        CreateSeek(5, 0)
    End Sub
    Private Sub ClassicalButton3_Click(sender As Object, e As EventArgs) Handles ClassicalButton3.Click
        CreateSeek(5, 3)
    End Sub
    Private Sub ClassicalButton4_Click(sender As Object, e As EventArgs) Handles ClassicalButton4.Click
        CreateSeek(10, 0)
    End Sub
    Private Sub ClassicalButton5_Click(sender As Object, e As EventArgs) Handles ClassicalButton5.Click
        CreateSeek(15, 15)
    End Sub
    Private Sub CustomButton_Click(sender As Object, e As EventArgs) Handles CustomButton.Click

        Using seekDialog = New SeekDialog(_api)
            seekDialog.ShowDialog()
        End Using

    End Sub
    Private Sub CreateSeek(time As Integer, increment As Integer)
        MsgBox("time " + time.ToString() + " inc " + increment.ToString())
    End Sub

    ' Clic sur le bouton compte
    Private Async Sub AccountLabel_Click(sender As Object, e As EventArgs) Handles AccountLabel.Click

        If _loggedIn = False Then 'tentative de connexion a l'api lichess
            Dim tokenString As String = ""
            Using tokenDialog = New TokenDialog()
                If tokenDialog.ShowDialog(tokenString) = DialogResult.OK Then
                    If tokenString <> "" Then
                        Await LichessConnection(tokenString)
                    End If
                End If
            End Using
        Else ' affichage parametres du compte (ou simplement déconnexion dans le programme d'exemple)
            Using disconnectDialog = New DisconnectDialog()
                If disconnectDialog.ShowDialog() = DialogResult.Yes Then
                    ' Reinitialisation du label du compte
                    AccountLabel.ForeColor = Color.RoyalBlue
                    AccountLabel.Text = "CONNEXION"
                    AccountLabel.Left = Width() - AccountLabel.Width() - 30
                    ' Désactivation du tabcontrol
                    TabControl.SelectTab(0)
                    TabControl.Enabled = False
                    _loggedIn = False
                    ' il faudra rajouter une fonctionnalité dans la classe de l'api pour fermer
                    ' toutes les connexions (event de stream etc)
                End If
            End Using
        End If

    End Sub

    ' Connexion a l'API lichess
    Private Async Function LichessConnection(token As String) As Task

        ' On indique le token a utiliser
        _api.SetToken(token)

        ' Tentative de connexion : envoie une requete account pour
        ' récuperer les informations du compte et afficher le pseudo
        If Await GetAccountInformations() = True Then
            ' La connexion a réussi
            _loggedIn = True
            ' On change le label du compte pour mettre le pseudo puis on commence a écouter le stream
            AccountLabel.Text = _accountInformations.Username
            AccountLabel.ForeColor = Color.FromArgb(255, 64, 64, 64)
            AccountLabel.Left = Width() - AccountLabel.Width() - 30
            ' Activation du TabControl
            TabControl.Enabled = True
            ' requete EventStreamAsync pour écouter les evenements (challenges..)
            Await _api.EventStreamAsync(_eventProgress)
        Else
            ' La connexion a échoué
            MsgBox("La connexion à lichess a échoué.")
        End If
    End Function
    Private Async Function GetAccountInformations() As Task(Of Boolean)
        _accountInformations = Await _api.AccountAsync()
        Return _accountInformations IsNot Nothing
    End Function

    ' Gestion des évènements (challenges, partie qui commence)
    Private Sub LichessEventHandler(evt As LichessEvent)
        If evt.Type = "challenge" Then
            AddChallenge(evt.Challenge)
        ElseIf evt.Type = "gamestart" Then
            'Code pour ajouter une partie'
        End If
    End Sub

    ' Effet visuel changement de couleur du label compte quand on passe dessus avec la souris
    Private Sub AccountLabel_MouseEnter(sender As Object, e As EventArgs) Handles AccountLabel.MouseEnter
        If _loggedIn Then
            AccountLabel.ForeColor = Color.Black
        End If
    End Sub
    Private Sub AccountLabel_MouseLeave(sender As Object, e As EventArgs) Handles AccountLabel.MouseLeave
        If _loggedIn Then
            AccountLabel.ForeColor = Color.FromArgb(255, 64, 64, 64)
        End If
    End Sub

    ' Gestion des actions de la page challenges

    ' Créer un nouveau challenge
    Private Sub NewChallengeButton_Click(sender As Object, e As EventArgs) Handles NewChallengeButton.Click

        Using challengeDialog = New ChallengeDialog(_api) ' on envoie l'api au formulaire pour la création du challenge
            challengeDialog.ShowDialog()
        End Using

    End Sub
    ' Ajouter un nouveau challenge dans la liste (appelé depuis la fenêtre 
    ' ChallengeDialog.vb ou depuis la fonction LichessEventHandler de cette fenêtre)
    Public Sub AddChallenge(challenge As Challenge)
        ' Si il n'y avait aucun challenge avant, on cache le label "no challenge"
        If ChallengeListBox.Items.Count = 0 Then
            NoChallengeLabel.Hide()
        End If

        'item.Tag = challenge ' on enregistre le challenge via le Tag de la listbox, a revoir par très propre
        ChallengeListBox.Items.Add(challenge)
    End Sub
    ' Retirer un challenge de la liste
    Public Sub RemoveChallenge(challengeId As Integer)
        ChallengeListBox.Items.RemoveAt(challengeId)
        'Si il n'y a plus de challenge on réaffiche le label "no challenge"
        If ChallengeListBox.Items.Count = 0 Then
            NoChallengeLabel.Show()
        End If
    End Sub

    ' Gestion de la fermeture de l'application
    Private Sub MainWindow_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        ' Si l'utilisateur ferme le programme et qu'il est connecté à lichess,
        ' envoyer un message de confirmation et déconnecter le compte
        If _loggedIn Then
            Using disconnectDialog = New DisconnectDialog()
                If disconnectDialog.ShowDialog() <> DialogResult.Yes Then e.Cancel = True
            End Using
        End If
    End Sub

End Class
