' Boite de dialogue personnalisée pour enregistrer le token
Public Class TokenDialog
    Public Sub New()

        InitializeComponent()

    End Sub
    Private Sub TokenDialog_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim tokenString = My.Settings.token
        If tokenString = "" Then
            TokenTextBox.Select()
        Else
            TokenTextBox.Text = tokenString
            RememberTokenCheckBox.Checked = CheckState.Checked
            ConnexionButton.Select()
        End If

    End Sub
    Public Overloads Function ShowDialog(ByRef tokenString As String) As DialogResult

        MyBase.ShowDialog()

        'renvoie la valeur du token
        tokenString = TokenTextBox.Text()

        'enregistre le token si la case "mémoriser le token" est cochée
        If RememberTokenCheckBox.CheckState = CheckState.Checked And tokenString <> "" Then
            My.Settings.token = tokenString
        Else
            My.Settings.token = ""
        End If
        Return DialogResult

    End Function
    Private Sub DisplayTokenCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles DisplayTokenCheckBox.CheckedChanged

        ' active / désactive l'affichage du token en fonction de la case à cocher
        If DisplayTokenCheckBox.CheckState = CheckState.Checked Then
            TokenTextBox.UseSystemPasswordChar = False
        Else
            TokenTextBox.UseSystemPasswordChar = True
        End If

    End Sub

End Class