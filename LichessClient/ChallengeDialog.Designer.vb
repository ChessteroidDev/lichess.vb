<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ChallengeDialog
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ChallengeDialog))
        Me.UsernameLabel = New System.Windows.Forms.Label()
        Me.TimeFormatLabel = New System.Windows.Forms.Label()
        Me.UnratedRadioButton = New System.Windows.Forms.RadioButton()
        Me.RatedRadioButton = New System.Windows.Forms.RadioButton()
        Me.UsernameTextBox = New System.Windows.Forms.TextBox()
        Me.TimeFormatComboBox = New System.Windows.Forms.ComboBox()
        Me.MinutesTrackBar = New System.Windows.Forms.TrackBar()
        Me.IncrementTrackBar = New System.Windows.Forms.TrackBar()
        Me.MinutesLabel = New System.Windows.Forms.Label()
        Me.MinutesNumLabel = New System.Windows.Forms.Label()
        Me.IncrementLabel = New System.Windows.Forms.Label()
        Me.IncrementNumLabel = New System.Windows.Forms.Label()
        Me.RandomButton = New System.Windows.Forms.Button()
        Me.BlackButton = New System.Windows.Forms.Button()
        Me.WhiteButton = New System.Windows.Forms.Button()
        Me.ToolTips = New System.Windows.Forms.ToolTip(Me.components)
        Me.DaysNumLabel = New System.Windows.Forms.Label()
        Me.DaysLabel = New System.Windows.Forms.Label()
        Me.DaysTrackBar = New System.Windows.Forms.TrackBar()
        CType(Me.MinutesTrackBar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IncrementTrackBar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DaysTrackBar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'UsernameLabel
        '
        Me.UsernameLabel.AutoSize = True
        Me.UsernameLabel.Location = New System.Drawing.Point(13, 26)
        Me.UsernameLabel.Name = "UsernameLabel"
        Me.UsernameLabel.Size = New System.Drawing.Size(90, 13)
        Me.UsernameLabel.TabIndex = 0
        Me.UsernameLabel.Text = "Nom d'utilisateur :"
        '
        'TimeFormatLabel
        '
        Me.TimeFormatLabel.AutoSize = True
        Me.TimeFormatLabel.Location = New System.Drawing.Point(47, 64)
        Me.TimeFormatLabel.Name = "TimeFormatLabel"
        Me.TimeFormatLabel.Size = New System.Drawing.Size(56, 13)
        Me.TimeFormatLabel.TabIndex = 1
        Me.TimeFormatLabel.Text = "Cadence :"
        '
        'UnratedRadioButton
        '
        Me.UnratedRadioButton.AutoSize = True
        Me.UnratedRadioButton.Checked = True
        Me.UnratedRadioButton.Location = New System.Drawing.Point(72, 233)
        Me.UnratedRadioButton.Name = "UnratedRadioButton"
        Me.UnratedRadioButton.Size = New System.Drawing.Size(91, 17)
        Me.UnratedRadioButton.TabIndex = 5
        Me.UnratedRadioButton.TabStop = True
        Me.UnratedRadioButton.Text = "Partie amicale"
        Me.UnratedRadioButton.UseVisualStyleBackColor = True
        '
        'RatedRadioButton
        '
        Me.RatedRadioButton.AutoSize = True
        Me.RatedRadioButton.Enabled = False
        Me.RatedRadioButton.Location = New System.Drawing.Point(173, 233)
        Me.RatedRadioButton.Name = "RatedRadioButton"
        Me.RatedRadioButton.Size = New System.Drawing.Size(91, 17)
        Me.RatedRadioButton.TabIndex = 6
        Me.RatedRadioButton.Text = "Partie classée"
        Me.RatedRadioButton.UseVisualStyleBackColor = True
        '
        'UsernameTextBox
        '
        Me.UsernameTextBox.Location = New System.Drawing.Point(114, 23)
        Me.UsernameTextBox.Name = "UsernameTextBox"
        Me.UsernameTextBox.Size = New System.Drawing.Size(200, 20)
        Me.UsernameTextBox.TabIndex = 1
        '
        'TimeFormatComboBox
        '
        Me.TimeFormatComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.TimeFormatComboBox.FormattingEnabled = True
        Me.TimeFormatComboBox.Items.AddRange(New Object() {"Temps réel", "Correspondance", "Illimité"})
        Me.TimeFormatComboBox.Location = New System.Drawing.Point(114, 61)
        Me.TimeFormatComboBox.Name = "TimeFormatComboBox"
        Me.TimeFormatComboBox.Size = New System.Drawing.Size(200, 21)
        Me.TimeFormatComboBox.TabIndex = 2
        '
        'MinutesTrackBar
        '
        Me.MinutesTrackBar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.MinutesTrackBar.Location = New System.Drawing.Point(12, 121)
        Me.MinutesTrackBar.Margin = New System.Windows.Forms.Padding(3, 3, 3, 0)
        Me.MinutesTrackBar.Maximum = 30
        Me.MinutesTrackBar.Minimum = 1
        Me.MinutesTrackBar.Name = "MinutesTrackBar"
        Me.MinutesTrackBar.Size = New System.Drawing.Size(310, 45)
        Me.MinutesTrackBar.TabIndex = 3
        Me.MinutesTrackBar.Value = 1
        '
        'IncrementTrackBar
        '
        Me.IncrementTrackBar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.IncrementTrackBar.Location = New System.Drawing.Point(12, 187)
        Me.IncrementTrackBar.Margin = New System.Windows.Forms.Padding(3, 3, 3, 0)
        Me.IncrementTrackBar.Maximum = 31
        Me.IncrementTrackBar.Minimum = 6
        Me.IncrementTrackBar.Name = "IncrementTrackBar"
        Me.IncrementTrackBar.Size = New System.Drawing.Size(310, 45)
        Me.IncrementTrackBar.TabIndex = 4
        Me.IncrementTrackBar.Value = 6
        '
        'MinutesLabel
        '
        Me.MinutesLabel.AutoSize = True
        Me.MinutesLabel.Location = New System.Drawing.Point(13, 102)
        Me.MinutesLabel.Name = "MinutesLabel"
        Me.MinutesLabel.Size = New System.Drawing.Size(100, 13)
        Me.MinutesLabel.TabIndex = 8
        Me.MinutesLabel.Text = "Minutes par joueur :"
        '
        'MinutesNumLabel
        '
        Me.MinutesNumLabel.AutoSize = True
        Me.MinutesNumLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MinutesNumLabel.Location = New System.Drawing.Point(114, 103)
        Me.MinutesNumLabel.Name = "MinutesNumLabel"
        Me.MinutesNumLabel.Size = New System.Drawing.Size(14, 13)
        Me.MinutesNumLabel.TabIndex = 9
        Me.MinutesNumLabel.Text = "5"
        '
        'IncrementLabel
        '
        Me.IncrementLabel.AutoSize = True
        Me.IncrementLabel.Location = New System.Drawing.Point(13, 168)
        Me.IncrementLabel.Name = "IncrementLabel"
        Me.IncrementLabel.Size = New System.Drawing.Size(124, 13)
        Me.IncrementLabel.TabIndex = 10
        Me.IncrementLabel.Text = "Incrément en secondes :"
        '
        'IncrementNumLabel
        '
        Me.IncrementNumLabel.AutoSize = True
        Me.IncrementNumLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IncrementNumLabel.Location = New System.Drawing.Point(137, 169)
        Me.IncrementNumLabel.Name = "IncrementNumLabel"
        Me.IncrementNumLabel.Size = New System.Drawing.Size(14, 13)
        Me.IncrementNumLabel.TabIndex = 11
        Me.IncrementNumLabel.Text = "5"
        '
        'RandomButton
        '
        Me.RandomButton.BackgroundImage = CType(resources.GetObject("RandomButton.BackgroundImage"), System.Drawing.Image)
        Me.RandomButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.RandomButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.RandomButton.Location = New System.Drawing.Point(125, 266)
        Me.RandomButton.Name = "RandomButton"
        Me.RandomButton.Size = New System.Drawing.Size(85, 85)
        Me.RandomButton.TabIndex = 7
        Me.RandomButton.Tag = ""
        Me.ToolTips.SetToolTip(Me.RandomButton, "Couleur aléatoire")
        Me.RandomButton.UseVisualStyleBackColor = True
        '
        'BlackButton
        '
        Me.BlackButton.BackgroundImage = CType(resources.GetObject("BlackButton.BackgroundImage"), System.Drawing.Image)
        Me.BlackButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BlackButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BlackButton.Location = New System.Drawing.Point(54, 286)
        Me.BlackButton.Name = "BlackButton"
        Me.BlackButton.Size = New System.Drawing.Size(65, 65)
        Me.BlackButton.TabIndex = 8
        Me.ToolTips.SetToolTip(Me.BlackButton, "Noirs")
        Me.BlackButton.UseVisualStyleBackColor = True
        '
        'WhiteButton
        '
        Me.WhiteButton.BackgroundImage = CType(resources.GetObject("WhiteButton.BackgroundImage"), System.Drawing.Image)
        Me.WhiteButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.WhiteButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.WhiteButton.Location = New System.Drawing.Point(216, 286)
        Me.WhiteButton.Name = "WhiteButton"
        Me.WhiteButton.Size = New System.Drawing.Size(65, 65)
        Me.WhiteButton.TabIndex = 9
        Me.ToolTips.SetToolTip(Me.WhiteButton, "Blancs")
        Me.WhiteButton.UseVisualStyleBackColor = True
        '
        'ToolTips
        '
        Me.ToolTips.AutoPopDelay = 32000
        Me.ToolTips.InitialDelay = 500
        Me.ToolTips.ReshowDelay = 500
        '
        'DaysNumLabel
        '
        Me.DaysNumLabel.AutoSize = True
        Me.DaysNumLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DaysNumLabel.Location = New System.Drawing.Point(99, 103)
        Me.DaysNumLabel.Name = "DaysNumLabel"
        Me.DaysNumLabel.Size = New System.Drawing.Size(14, 13)
        Me.DaysNumLabel.TabIndex = 14
        Me.DaysNumLabel.Text = "2"
        Me.DaysNumLabel.Visible = False
        '
        'DaysLabel
        '
        Me.DaysLabel.AutoSize = True
        Me.DaysLabel.Location = New System.Drawing.Point(13, 102)
        Me.DaysLabel.Name = "DaysLabel"
        Me.DaysLabel.Size = New System.Drawing.Size(83, 13)
        Me.DaysLabel.TabIndex = 13
        Me.DaysLabel.Text = "Jours par coup :"
        Me.DaysLabel.Visible = False
        '
        'DaysTrackBar
        '
        Me.DaysTrackBar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DaysTrackBar.Location = New System.Drawing.Point(12, 121)
        Me.DaysTrackBar.Margin = New System.Windows.Forms.Padding(3, 3, 3, 0)
        Me.DaysTrackBar.Maximum = 7
        Me.DaysTrackBar.Minimum = 1
        Me.DaysTrackBar.Name = "DaysTrackBar"
        Me.DaysTrackBar.Size = New System.Drawing.Size(310, 45)
        Me.DaysTrackBar.TabIndex = 12
        Me.DaysTrackBar.Value = 2
        Me.DaysTrackBar.Visible = False
        '
        'ChallengeDialog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(334, 362)
        Me.Controls.Add(Me.DaysNumLabel)
        Me.Controls.Add(Me.DaysLabel)
        Me.Controls.Add(Me.DaysTrackBar)
        Me.Controls.Add(Me.WhiteButton)
        Me.Controls.Add(Me.BlackButton)
        Me.Controls.Add(Me.RandomButton)
        Me.Controls.Add(Me.IncrementNumLabel)
        Me.Controls.Add(Me.IncrementLabel)
        Me.Controls.Add(Me.MinutesNumLabel)
        Me.Controls.Add(Me.MinutesLabel)
        Me.Controls.Add(Me.IncrementTrackBar)
        Me.Controls.Add(Me.MinutesTrackBar)
        Me.Controls.Add(Me.TimeFormatComboBox)
        Me.Controls.Add(Me.UsernameTextBox)
        Me.Controls.Add(Me.RatedRadioButton)
        Me.Controls.Add(Me.UnratedRadioButton)
        Me.Controls.Add(Me.TimeFormatLabel)
        Me.Controls.Add(Me.UsernameLabel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ChallengeDialog"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Défier un joueur"
        CType(Me.MinutesTrackBar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IncrementTrackBar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DaysTrackBar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents UsernameLabel As Label
    Friend WithEvents TimeFormatLabel As Label
    Friend WithEvents UnratedRadioButton As RadioButton
    Friend WithEvents RatedRadioButton As RadioButton
    Friend WithEvents UsernameTextBox As TextBox
    Friend WithEvents TimeFormatComboBox As ComboBox
    Friend WithEvents MinutesTrackBar As TrackBar
    Friend WithEvents IncrementTrackBar As TrackBar
    Friend WithEvents MinutesLabel As Label
    Friend WithEvents MinutesNumLabel As Label
    Friend WithEvents IncrementLabel As Label
    Friend WithEvents IncrementNumLabel As Label
    Friend WithEvents RandomButton As Button
    Friend WithEvents BlackButton As Button
    Friend WithEvents WhiteButton As Button
    Friend WithEvents ToolTips As ToolTip
    Friend WithEvents DaysNumLabel As Label
    Friend WithEvents DaysLabel As Label
    Friend WithEvents DaysTrackBar As TrackBar
End Class
