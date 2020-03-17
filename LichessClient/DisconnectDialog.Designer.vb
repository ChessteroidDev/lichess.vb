<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DisconnectDialog
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
        Me.YesButton = New System.Windows.Forms.Button()
        Me.NoButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'DescLabel
        '
        Me.DescLabel.BackColor = System.Drawing.Color.White
        Me.DescLabel.Dock = System.Windows.Forms.DockStyle.Top
        Me.DescLabel.Location = New System.Drawing.Point(0, 0)
        Me.DescLabel.Name = "DescLabel"
        Me.DescLabel.Padding = New System.Windows.Forms.Padding(20, 0, 0, 0)
        Me.DescLabel.Size = New System.Drawing.Size(284, 70)
        Me.DescLabel.TabIndex = 0
        Me.DescLabel.Text = "Confirmer la déconnexion au serveur de lichess"
        Me.DescLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'YesButton
        '
        Me.YesButton.DialogResult = System.Windows.Forms.DialogResult.Yes
        Me.YesButton.Location = New System.Drawing.Point(120, 79)
        Me.YesButton.Name = "YesButton"
        Me.YesButton.Size = New System.Drawing.Size(75, 23)
        Me.YesButton.TabIndex = 1
        Me.YesButton.Text = "Oui"
        Me.YesButton.UseVisualStyleBackColor = True
        '
        'NoButton
        '
        Me.NoButton.DialogResult = System.Windows.Forms.DialogResult.No
        Me.NoButton.Location = New System.Drawing.Point(201, 79)
        Me.NoButton.Name = "NoButton"
        Me.NoButton.Size = New System.Drawing.Size(75, 23)
        Me.NoButton.TabIndex = 2
        Me.NoButton.Text = "Non"
        Me.NoButton.UseVisualStyleBackColor = True
        '
        'DisconnectDialog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 112)
        Me.Controls.Add(Me.NoButton)
        Me.Controls.Add(Me.YesButton)
        Me.Controls.Add(Me.DescLabel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "DisconnectDialog"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Se déconnecter"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DescLabel As Label
    Friend WithEvents YesButton As Button
    Friend WithEvents NoButton As Button
End Class
