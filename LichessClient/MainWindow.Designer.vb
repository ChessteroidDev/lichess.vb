<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainWindow
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainWindow))
        Me.TabControl = New System.Windows.Forms.TabControl()
        Me.Index = New System.Windows.Forms.TabPage()
        Me.CustomButton = New LichessControls.LButton()
        Me.ClassicalButton5 = New LichessControls.LButton()
        Me.ClassicalButton4 = New LichessControls.LButton()
        Me.ClassicalButton3 = New LichessControls.LButton()
        Me.ClassicalButton1 = New LichessControls.LButton()
        Me.ClassicalButton2 = New LichessControls.LButton()
        Me.RapidButton3 = New LichessControls.LButton()
        Me.RapidButton2 = New LichessControls.LButton()
        Me.RapidButton1 = New LichessControls.LButton()
        Me.ChallengesPage = New System.Windows.Forms.TabPage()
        Me.NoChallengeLabel = New System.Windows.Forms.Label()
        Me.ChallengeListBox = New System.Windows.Forms.ListBox()
        Me.DeclineChallengeButton = New System.Windows.Forms.Button()
        Me.IconsList = New System.Windows.Forms.ImageList(Me.components)
        Me.AcceptChallengeButton = New System.Windows.Forms.Button()
        Me.NewChallengeButton = New System.Windows.Forms.Button()
        Me.AccountLabel = New System.Windows.Forms.Label()
        Me.AppTitle = New System.Windows.Forms.Label()
        Me.TabControl.SuspendLayout()
        Me.Index.SuspendLayout()
        Me.ChallengesPage.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl
        '
        Me.TabControl.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl.Controls.Add(Me.Index)
        Me.TabControl.Controls.Add(Me.ChallengesPage)
        Me.TabControl.Enabled = False
        Me.TabControl.ImageList = Me.IconsList
        Me.TabControl.Location = New System.Drawing.Point(-4, 92)
        Me.TabControl.Margin = New System.Windows.Forms.Padding(0)
        Me.TabControl.Name = "TabControl"
        Me.TabControl.Padding = New System.Drawing.Point(0, 0)
        Me.TabControl.SelectedIndex = 0
        Me.TabControl.Size = New System.Drawing.Size(692, 576)
        Me.TabControl.TabIndex = 1
        '
        'Index
        '
        Me.Index.BackColor = System.Drawing.Color.White
        Me.Index.BackgroundImage = CType(resources.GetObject("Index.BackgroundImage"), System.Drawing.Image)
        Me.Index.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Index.Controls.Add(Me.CustomButton)
        Me.Index.Controls.Add(Me.ClassicalButton5)
        Me.Index.Controls.Add(Me.ClassicalButton4)
        Me.Index.Controls.Add(Me.ClassicalButton3)
        Me.Index.Controls.Add(Me.ClassicalButton1)
        Me.Index.Controls.Add(Me.ClassicalButton2)
        Me.Index.Controls.Add(Me.RapidButton3)
        Me.Index.Controls.Add(Me.RapidButton2)
        Me.Index.Controls.Add(Me.RapidButton1)
        Me.Index.Location = New System.Drawing.Point(4, 23)
        Me.Index.Margin = New System.Windows.Forms.Padding(0)
        Me.Index.Name = "Index"
        Me.Index.Size = New System.Drawing.Size(684, 549)
        Me.Index.TabIndex = 0
        Me.Index.Text = "Acceuil"
        '
        'CustomButton
        '
        Me.CustomButton.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CustomButton.BackgroundColorHover = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.CustomButton.BorderRadius = CType(8US, UShort)
        Me.CustomButton.BorderWidth = CType(1US, UShort)
        Me.CustomButton.Font = New System.Drawing.Font("Clear Sans Light", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CustomButton.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.CustomButton.Location = New System.Drawing.Point(457, 367)
        Me.CustomButton.Name = "CustomButton"
        Me.CustomButton.Size = New System.Drawing.Size(218, 174)
        Me.CustomButton.TabIndex = 8
        Me.CustomButton.Text = "Personnalisé"
        Me.CustomButton.Text2 = ""
        '
        'ClassicalButton5
        '
        Me.ClassicalButton5.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClassicalButton5.BackgroundColorHover = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.ClassicalButton5.BorderRadius = CType(8US, UShort)
        Me.ClassicalButton5.BorderWidth = CType(1US, UShort)
        Me.ClassicalButton5.Font = New System.Drawing.Font("Clear Sans Light", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ClassicalButton5.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.ClassicalButton5.Location = New System.Drawing.Point(232, 367)
        Me.ClassicalButton5.Name = "ClassicalButton5"
        Me.ClassicalButton5.Size = New System.Drawing.Size(218, 174)
        Me.ClassicalButton5.TabIndex = 7
        Me.ClassicalButton5.Text = "90+0"
        Me.ClassicalButton5.Text2 = "Classique"
        '
        'ClassicalButton4
        '
        Me.ClassicalButton4.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClassicalButton4.BackgroundColorHover = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.ClassicalButton4.BorderRadius = CType(8US, UShort)
        Me.ClassicalButton4.BorderWidth = CType(1US, UShort)
        Me.ClassicalButton4.Font = New System.Drawing.Font("Clear Sans Light", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ClassicalButton4.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.ClassicalButton4.Location = New System.Drawing.Point(7, 367)
        Me.ClassicalButton4.Name = "ClassicalButton4"
        Me.ClassicalButton4.Size = New System.Drawing.Size(218, 174)
        Me.ClassicalButton4.TabIndex = 6
        Me.ClassicalButton4.Text = "60+0"
        Me.ClassicalButton4.Text2 = "Classique"
        '
        'ClassicalButton3
        '
        Me.ClassicalButton3.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClassicalButton3.BackgroundColorHover = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.ClassicalButton3.BorderRadius = CType(8US, UShort)
        Me.ClassicalButton3.BorderWidth = CType(1US, UShort)
        Me.ClassicalButton3.Font = New System.Drawing.Font("Clear Sans Light", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ClassicalButton3.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.ClassicalButton3.Location = New System.Drawing.Point(457, 187)
        Me.ClassicalButton3.Name = "ClassicalButton3"
        Me.ClassicalButton3.Size = New System.Drawing.Size(218, 174)
        Me.ClassicalButton3.TabIndex = 5
        Me.ClassicalButton3.Text = "45+45"
        Me.ClassicalButton3.Text2 = "Classique"
        '
        'ClassicalButton1
        '
        Me.ClassicalButton1.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClassicalButton1.BackgroundColorHover = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.ClassicalButton1.BorderRadius = CType(8US, UShort)
        Me.ClassicalButton1.BorderWidth = CType(1US, UShort)
        Me.ClassicalButton1.Font = New System.Drawing.Font("Clear Sans Light", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ClassicalButton1.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.ClassicalButton1.Location = New System.Drawing.Point(7, 187)
        Me.ClassicalButton1.Name = "ClassicalButton1"
        Me.ClassicalButton1.Size = New System.Drawing.Size(218, 174)
        Me.ClassicalButton1.TabIndex = 4
        Me.ClassicalButton1.Text = "15+15"
        Me.ClassicalButton1.Text2 = "Classique"
        '
        'ClassicalButton2
        '
        Me.ClassicalButton2.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClassicalButton2.BackgroundColorHover = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.ClassicalButton2.BorderRadius = CType(8US, UShort)
        Me.ClassicalButton2.BorderWidth = CType(1US, UShort)
        Me.ClassicalButton2.Font = New System.Drawing.Font("Clear Sans Light", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ClassicalButton2.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.ClassicalButton2.Location = New System.Drawing.Point(232, 187)
        Me.ClassicalButton2.Name = "ClassicalButton2"
        Me.ClassicalButton2.Size = New System.Drawing.Size(218, 174)
        Me.ClassicalButton2.TabIndex = 3
        Me.ClassicalButton2.Text = "30+30"
        Me.ClassicalButton2.Text2 = "Classique"
        '
        'RapidButton3
        '
        Me.RapidButton3.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.RapidButton3.BackgroundColorHover = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.RapidButton3.BorderRadius = CType(8US, UShort)
        Me.RapidButton3.BorderWidth = CType(1US, UShort)
        Me.RapidButton3.Font = New System.Drawing.Font("Clear Sans Light", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RapidButton3.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.RapidButton3.Location = New System.Drawing.Point(457, 7)
        Me.RapidButton3.Name = "RapidButton3"
        Me.RapidButton3.Size = New System.Drawing.Size(218, 174)
        Me.RapidButton3.TabIndex = 2
        Me.RapidButton3.Text = "10+15"
        Me.RapidButton3.Text2 = "Rapide"
        '
        'RapidButton2
        '
        Me.RapidButton2.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.RapidButton2.BackgroundColorHover = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.RapidButton2.BorderRadius = CType(8US, UShort)
        Me.RapidButton2.BorderWidth = CType(1US, UShort)
        Me.RapidButton2.Font = New System.Drawing.Font("Clear Sans Light", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RapidButton2.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.RapidButton2.Location = New System.Drawing.Point(232, 7)
        Me.RapidButton2.Name = "RapidButton2"
        Me.RapidButton2.Size = New System.Drawing.Size(218, 174)
        Me.RapidButton2.TabIndex = 1
        Me.RapidButton2.Text = "10+0"
        Me.RapidButton2.Text2 = "Rapide"
        '
        'RapidButton1
        '
        Me.RapidButton1.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.RapidButton1.BackgroundColorHover = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.RapidButton1.BorderRadius = CType(8US, UShort)
        Me.RapidButton1.BorderWidth = CType(1US, UShort)
        Me.RapidButton1.Font = New System.Drawing.Font("Clear Sans Light", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RapidButton1.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.RapidButton1.Location = New System.Drawing.Point(7, 7)
        Me.RapidButton1.Name = "RapidButton1"
        Me.RapidButton1.Size = New System.Drawing.Size(218, 174)
        Me.RapidButton1.TabIndex = 0
        Me.RapidButton1.Text = "5+5"
        Me.RapidButton1.Text2 = "Rapide"
        '
        'ChallengesPage
        '
        Me.ChallengesPage.Controls.Add(Me.NoChallengeLabel)
        Me.ChallengesPage.Controls.Add(Me.ChallengeListBox)
        Me.ChallengesPage.Controls.Add(Me.DeclineChallengeButton)
        Me.ChallengesPage.Controls.Add(Me.AcceptChallengeButton)
        Me.ChallengesPage.Controls.Add(Me.NewChallengeButton)
        Me.ChallengesPage.Location = New System.Drawing.Point(4, 23)
        Me.ChallengesPage.Name = "ChallengesPage"
        Me.ChallengesPage.Size = New System.Drawing.Size(684, 549)
        Me.ChallengesPage.TabIndex = 1
        Me.ChallengesPage.Text = "Challenges"
        Me.ChallengesPage.UseVisualStyleBackColor = True
        '
        'NoChallengeLabel
        '
        Me.NoChallengeLabel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.NoChallengeLabel.Image = CType(resources.GetObject("NoChallengeLabel.Image"), System.Drawing.Image)
        Me.NoChallengeLabel.Location = New System.Drawing.Point(0, 0)
        Me.NoChallengeLabel.Name = "NoChallengeLabel"
        Me.NoChallengeLabel.Size = New System.Drawing.Size(684, 487)
        Me.NoChallengeLabel.TabIndex = 4
        '
        'ChallengeListBox
        '
        Me.ChallengeListBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ChallengeListBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ChallengeListBox.IntegralHeight = False
        Me.ChallengeListBox.Location = New System.Drawing.Point(0, 0)
        Me.ChallengeListBox.Name = "ChallengeListBox"
        Me.ChallengeListBox.Size = New System.Drawing.Size(684, 487)
        Me.ChallengeListBox.TabIndex = 3
        '
        'DeclineChallengeButton
        '
        Me.DeclineChallengeButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DeclineChallengeButton.Enabled = False
        Me.DeclineChallengeButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.DeclineChallengeButton.ImageIndex = 3
        Me.DeclineChallengeButton.ImageList = Me.IconsList
        Me.DeclineChallengeButton.Location = New System.Drawing.Point(473, 503)
        Me.DeclineChallengeButton.Name = "DeclineChallengeButton"
        Me.DeclineChallengeButton.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.DeclineChallengeButton.Size = New System.Drawing.Size(199, 32)
        Me.DeclineChallengeButton.TabIndex = 2
        Me.DeclineChallengeButton.Text = "  Refuser / annuler le challenge"
        Me.DeclineChallengeButton.UseVisualStyleBackColor = True
        '
        'IconsList
        '
        Me.IconsList.ImageStream = CType(resources.GetObject("IconsList.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.IconsList.TransparentColor = System.Drawing.Color.Transparent
        Me.IconsList.Images.SetKeyName(0, "alerticon.png")
        Me.IconsList.Images.SetKeyName(1, "searchicon.png")
        Me.IconsList.Images.SetKeyName(2, "yesicon.png")
        Me.IconsList.Images.SetKeyName(3, "noicon.png")
        '
        'AcceptChallengeButton
        '
        Me.AcceptChallengeButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AcceptChallengeButton.Enabled = False
        Me.AcceptChallengeButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.AcceptChallengeButton.ImageIndex = 2
        Me.AcceptChallengeButton.ImageList = Me.IconsList
        Me.AcceptChallengeButton.Location = New System.Drawing.Point(308, 503)
        Me.AcceptChallengeButton.Name = "AcceptChallengeButton"
        Me.AcceptChallengeButton.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.AcceptChallengeButton.Size = New System.Drawing.Size(159, 32)
        Me.AcceptChallengeButton.TabIndex = 1
        Me.AcceptChallengeButton.Text = "  Accepter le challenge"
        Me.AcceptChallengeButton.UseVisualStyleBackColor = True
        '
        'NewChallengeButton
        '
        Me.NewChallengeButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.NewChallengeButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.NewChallengeButton.ImageIndex = 1
        Me.NewChallengeButton.ImageList = Me.IconsList
        Me.NewChallengeButton.Location = New System.Drawing.Point(167, 503)
        Me.NewChallengeButton.Name = "NewChallengeButton"
        Me.NewChallengeButton.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.NewChallengeButton.Size = New System.Drawing.Size(135, 32)
        Me.NewChallengeButton.TabIndex = 0
        Me.NewChallengeButton.Text = "  Défier un joueur"
        Me.NewChallengeButton.UseVisualStyleBackColor = True
        '
        'AccountLabel
        '
        Me.AccountLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AccountLabel.AutoSize = True
        Me.AccountLabel.BackColor = System.Drawing.SystemColors.Control
        Me.AccountLabel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.AccountLabel.Font = New System.Drawing.Font("Clear Sans", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AccountLabel.ForeColor = System.Drawing.Color.RoyalBlue
        Me.AccountLabel.Location = New System.Drawing.Point(576, 20)
        Me.AccountLabel.Name = "AccountLabel"
        Me.AccountLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.AccountLabel.Size = New System.Drawing.Size(93, 21)
        Me.AccountLabel.TabIndex = 2
        Me.AccountLabel.Text = "CONNEXION"
        '
        'AppTitle
        '
        Me.AppTitle.AutoSize = True
        Me.AppTitle.Font = New System.Drawing.Font("Clear Sans", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AppTitle.Location = New System.Drawing.Point(12, 10)
        Me.AppTitle.Name = "AppTitle"
        Me.AppTitle.Size = New System.Drawing.Size(122, 34)
        Me.AppTitle.TabIndex = 4
        Me.AppTitle.Text = "lichess.vb"
        '
        'MainWindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(684, 662)
        Me.Controls.Add(Me.AppTitle)
        Me.Controls.Add(Me.AccountLabel)
        Me.Controls.Add(Me.TabControl)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(600, 600)
        Me.Name = "MainWindow"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Lichess.vb - Exemple pour utilisation de l'API lichess"
        Me.TabControl.ResumeLayout(False)
        Me.Index.ResumeLayout(False)
        Me.ChallengesPage.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TabControl As TabControl
    Friend WithEvents Index As TabPage
    Friend WithEvents AccountLabel As Label
    Friend WithEvents ChallengesPage As TabPage
    Friend WithEvents DeclineChallengeButton As Button
    Friend WithEvents AcceptChallengeButton As Button
    Friend WithEvents NewChallengeButton As Button
    Friend WithEvents ChallengeListBox As ListBox
    Friend WithEvents NoChallengeLabel As Label
    Friend WithEvents IconsList As ImageList
    Friend WithEvents RapidButton1 As LichessControls.LButton
    Friend WithEvents RapidButton3 As LichessControls.LButton
    Friend WithEvents RapidButton2 As LichessControls.LButton
    Friend WithEvents ClassicalButton4 As LichessControls.LButton
    Friend WithEvents ClassicalButton3 As LichessControls.LButton
    Friend WithEvents ClassicalButton1 As LichessControls.LButton
    Friend WithEvents ClassicalButton2 As LichessControls.LButton
    Friend WithEvents CustomButton As LichessControls.LButton
    Friend WithEvents ClassicalButton5 As LichessControls.LButton
    Friend WithEvents AppTitle As Label
End Class
