<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TokenDialog
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
        Me.DescLabel = New System.Windows.Forms.Label()
        Me.TokenTextBox = New System.Windows.Forms.TextBox()
        Me.DisplayTokenCheckBox = New System.Windows.Forms.CheckBox()
        Me.RememberTokenCheckBox = New System.Windows.Forms.CheckBox()
        Me.ConnexionButton = New System.Windows.Forms.Button()
        Me.CancelConnexionButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'DescLabel
        '
        Me.DescLabel.AutoSize = True
        Me.DescLabel.Location = New System.Drawing.Point(13, 16)
        Me.DescLabel.Name = "DescLabel"
        Me.DescLabel.Size = New System.Drawing.Size(44, 13)
        Me.DescLabel.TabIndex = 0
        Me.DescLabel.Text = "Token :"
        '
        'TokenTextBox
        '
        Me.TokenTextBox.Location = New System.Drawing.Point(63, 13)
        Me.TokenTextBox.Name = "TokenTextBox"
        Me.TokenTextBox.Size = New System.Drawing.Size(209, 20)
        Me.TokenTextBox.TabIndex = 1
        Me.TokenTextBox.UseSystemPasswordChar = True
        '
        'DisplayTokenCheckBox
        '
        Me.DisplayTokenCheckBox.AutoSize = True
        Me.DisplayTokenCheckBox.Location = New System.Drawing.Point(63, 46)
        Me.DisplayTokenCheckBox.Name = "DisplayTokenCheckBox"
        Me.DisplayTokenCheckBox.Size = New System.Drawing.Size(103, 17)
        Me.DisplayTokenCheckBox.TabIndex = 2
        Me.DisplayTokenCheckBox.Text = "Afficher le token"
        Me.DisplayTokenCheckBox.UseVisualStyleBackColor = True
        '
        'RememberTokenCheckBox
        '
        Me.RememberTokenCheckBox.AutoSize = True
        Me.RememberTokenCheckBox.Location = New System.Drawing.Point(63, 70)
        Me.RememberTokenCheckBox.Name = "RememberTokenCheckBox"
        Me.RememberTokenCheckBox.Size = New System.Drawing.Size(115, 17)
        Me.RememberTokenCheckBox.TabIndex = 3
        Me.RememberTokenCheckBox.Text = "Mémoriser le token"
        Me.RememberTokenCheckBox.UseVisualStyleBackColor = True
        '
        'ConnexionButton
        '
        Me.ConnexionButton.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.ConnexionButton.Location = New System.Drawing.Point(58, 105)
        Me.ConnexionButton.Name = "ConnexionButton"
        Me.ConnexionButton.Size = New System.Drawing.Size(75, 23)
        Me.ConnexionButton.TabIndex = 4
        Me.ConnexionButton.Text = "Connexion"
        Me.ConnexionButton.UseVisualStyleBackColor = True
        '
        'CancelConnexionButton
        '
        Me.CancelConnexionButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.CancelConnexionButton.Location = New System.Drawing.Point(144, 105)
        Me.CancelConnexionButton.Name = "CancelConnexionButton"
        Me.CancelConnexionButton.Size = New System.Drawing.Size(75, 23)
        Me.CancelConnexionButton.TabIndex = 5
        Me.CancelConnexionButton.Text = "Annuler"
        Me.CancelConnexionButton.UseVisualStyleBackColor = True
        '
        'TokenDialog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 140)
        Me.Controls.Add(Me.CancelConnexionButton)
        Me.Controls.Add(Me.ConnexionButton)
        Me.Controls.Add(Me.RememberTokenCheckBox)
        Me.Controls.Add(Me.DisplayTokenCheckBox)
        Me.Controls.Add(Me.TokenTextBox)
        Me.Controls.Add(Me.DescLabel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "TokenDialog"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Connexion à lichess.org"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DescLabel As Label
    Friend WithEvents TokenTextBox As TextBox
    Friend WithEvents DisplayTokenCheckBox As CheckBox
    Friend WithEvents RememberTokenCheckBox As CheckBox
    Friend WithEvents ConnexionButton As Button
    Friend WithEvents CancelConnexionButton As Button
End Class
