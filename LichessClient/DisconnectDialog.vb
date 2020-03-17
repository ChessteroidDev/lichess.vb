'Boite de dialogue personnalisée pour la confirmation de déconnexion
'On utilise pas une MsgBox car il est impossible de les centrer dans
'la fenêtre de notre application, alors que le dialogue personnalisé
'peut être centré grâce au paramètre StartPosition de la fenêtre
Public Class DisconnectDialog
    Private Sub DisconnectDialog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        YesButton.Enabled = True
    End Sub
End Class