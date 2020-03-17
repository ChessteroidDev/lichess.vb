Imports System.ComponentModel
Imports System.Drawing
Imports System.Drawing.Text
Imports System.Drawing.Drawing2D
Imports System.Windows.Forms

' Bouton transparent personnalisé style lichess
'
' Fonctionnalités: transparence, coins arrondis
' 2 paramètres de ligne de texte, redimensionnement
' automatique du texte

Public Class LButton
    Inherits Control
    Implements IButtonControl

    ' membres privés
    Private _dialogResult As DialogResult
    Private _borderColor As Color = Color.LightGray
    Private _borderRadius As UShort = 0
    Private _borderWidth As UShort = 0
    Private _backgroundColor As Color = Color.FromArgb(150, 255, 255, 255)
    Private _backgroundHoverColor As Color = Color.FromArgb(150, 255, 200, 170)
    Private _currentBackgroundColor = Color.FromArgb(150, 255, 255, 255)
    Private _text2 As String = "text"

    ' propriétés cachées (inutilisées sauf BackColor dont on a besoin pour le fonctionnement du bouton)

    <Browsable(False), EditorBrowsable(EditorBrowsableState.Never)>
    Public Overrides Property BackColor() As Color = Color.Transparent

    <Browsable(False), EditorBrowsable(EditorBrowsableState.Never)>
    Public Overrides Property BackgroundImage As Image
        Get
            Return MyBase.BackgroundImage
        End Get
        Set
            MyBase.BackgroundImage = Value
        End Set
    End Property

    <Browsable(False), EditorBrowsable(EditorBrowsableState.Never)>
    Public Overrides Property AllowDrop As Boolean
        Get
            Return MyBase.AllowDrop
        End Get
        Set(value As Boolean)
            MyBase.AllowDrop = value
        End Set
    End Property

    <Browsable(False), EditorBrowsable(EditorBrowsableState.Never)>
    Public Overrides Property BackgroundImageLayout As ImageLayout
        Get
            Return MyBase.BackgroundImageLayout
        End Get
        Set(value As ImageLayout)
            MyBase.BackgroundImageLayout = value
        End Set
    End Property

    ' propriétés publiques

    <DefaultValue(GetType(DialogResult), "None")>
    Public Property DialogResult As DialogResult Implements IButtonControl.DialogResult
        Get
            Return _dialogResult
        End Get
        Set(value As DialogResult)
            If [Enum].IsDefined(GetType(DialogResult), value) Then
                _dialogResult = value
            End If
        End Set
    End Property
    Public Overrides Property Text() As String
        Get
            Return MyBase.Text
        End Get
        Set(ByVal value As String)
            If value <> MyBase.Text Then
                MyBase.Text = value
                Invalidate()
            End If
        End Set
    End Property

    <DefaultValue(GetType(String), "text")>
    Public Property Text2 As String
        Get
            Return _text2
        End Get
        Set(value As String)
            If value <> _text2 Then
                _text2 = value
                Invalidate()
            End If
        End Set
    End Property

    <DefaultValue(GetType(Color), "LightGray")>
    Public Property BorderColor As Color
        Get
            Return _borderColor
        End Get
        Set(value As Color)
            _borderColor = value
            Invalidate()
        End Set
    End Property

    <DefaultValue(GetType(UShort), "0")>
    Public Property BorderRadius As UShort
        Get
            Return _borderRadius
        End Get
        Set(value As UShort)
            _borderRadius = value
            Invalidate()
        End Set
    End Property

    <DefaultValue(GetType(UShort), "0")>
    Public Property BorderWidth As UShort
        Get
            Return _borderWidth
        End Get
        Set(value As UShort)
            _borderWidth = value
            Invalidate()
        End Set
    End Property

    <DefaultValue(GetType(Color), "150;255;255;255")>
    Public Property BackgroundColor As Color
        Get
            Return _backgroundColor
        End Get
        Set(value As Color)
            _backgroundColor = value
            _currentBackgroundColor = value
            Invalidate()
        End Set
    End Property

    <DefaultValue(GetType(Color), "150;255;200;170")>
    Public Property BackgroundColorHover As Color
        Get
            Return _backgroundHoverColor
        End Get
        Set(value As Color)
            _backgroundHoverColor = value
            Invalidate()
        End Set
    End Property

    'Constructeur (initialisation du controle)
    Public Sub New()
        SetStyle(ControlStyles.AllPaintingInWmPaint Or
                 ControlStyles.OptimizedDoubleBuffer Or
                 ControlStyles.ResizeRedraw Or
                 ControlStyles.SupportsTransparentBackColor Or
                 ControlStyles.UserPaint, True)
    End Sub

    'Implementation de l'interface IButtonControl pour que notre bouton se comporte
    'comme un bouton classique.
    Public Sub NotifyDefault(value As Boolean) Implements IButtonControl.NotifyDefault
        OnNotifyDefault(value)
    End Sub
    Public Overridable Sub OnNotifyDefault(ByVal value As Boolean)
    End Sub

    Public Sub PerformClick() Implements IButtonControl.PerformClick
        OnClick(EventArgs.Empty)
    End Sub

    'Fonction principale qui dessine le bouton à chaque
    'changement
    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        Dim w = Width()
        Dim h = Height()
        Dim radius = _borderRadius - 1
        'active l'anti aliasing
        e.Graphics.SmoothingMode = SmoothingMode.HighQuality
        'remplissage du fond du bouton
        Using shape = New GraphicsPath()
            If _borderRadius > 0 Then
                'fond arrondi
                If radius > Height() Then radius = Height()
                If radius > Width() Then radius = Width()




                'dessine le fond
                shape.AddArc(0, 0, radius, radius, 180, 90)
                shape.AddArc(w - radius - 1, 0, radius, radius, 270, 90)
                shape.AddArc(w - radius - 1, h - radius - 1, radius, radius, 0, 90)
                shape.AddArc(0, h - radius - 1, radius, radius, 90, 90)
            Else
                'fond carré
                shape.AddRectangle(e.ClipRectangle)
            End If
            Using bgBrush = New SolidBrush(_currentBackgroundColor)
                e.Graphics.FillPath(bgBrush, shape)
            End Using
        End Using

        'si la bordure à une épaisseur, on dessine la bordure
        'code qui bug probablement quand la taille des bordures deviennent
        'plus grandes que la taille des boutons, a refactoriser mais
        'pas important si on met une taille minimum sur nos boutons pour
        'que ca n'arrive pas
        If _borderWidth > 0 Then
            Using borderBrush = New SolidBrush(_borderColor)
                Using borderPen = New Pen(borderBrush, _borderWidth * 2)
                    Using border = New GraphicsPath()
                        If _borderRadius > 0 Then
                            borderPen.Width = _borderWidth
                            'bordure arrondie, pas besoin de recalculer le radius qui a déja été calculé plus haut
                            'par contre ca bug pour les bordures d'une épaisseur differente a un, je me suis
                            'cassé la tête pour trouver la bonne formule sans succes, utiliser les bordures rondes
                            'seulement si leur épaisseur est de 1 pour l'instant
                            border.AddArc(0, 0, radius, radius, 180, 90)
                            border.AddArc(w - radius - 1, 0, radius, radius, 270, 90)
                            border.AddArc(w - radius - 1, h - radius - 1, radius, radius, 0, 90)
                            border.AddArc(0, h - radius - 1, radius, radius, 90, 90)
                            border.CloseFigure()
                        Else
                            'bordure carrée
                            border.AddRectangle(e.ClipRectangle)
                        End If
                        e.Graphics.DrawPath(borderPen, border)
                    End Using
                End Using
            End Using
        End If

        'Affichage et redimensionnement du texte (paramètre à rajouter pour
        'desactiver le redimensionnement automatique), formule de redimensionnement
        'a refactoriser pour s'adapter a la taille de la boite correctement
        '(ca bug si la taille de la boite devient trop petite)'
        e.Graphics.TextRenderingHint = TextRenderingHint.AntiAlias
        Using textBrush = New SolidBrush(ForeColor)

            If Not Enabled Then textBrush.Color = Color.LightGray
            Dim fontScale = (w + h) / 15
            If String.IsNullOrEmpty(_text2) Then fontScale = (w + h) / 20
            Dim textFont = New Font(Font.FontFamily(), fontScale)
            Dim textSize = e.Graphics.MeasureString(Text, textFont)
            If String.IsNullOrEmpty(_text2) Then
                e.Graphics.DrawString(Text, textFont, textBrush, (Width - textSize.Width) / 2, Height / 2 - textSize.Height / 2)
            Else
                e.Graphics.DrawString(Text, textFont, textBrush, (Width - textSize.Width) / 2, Height / 2 - textSize.Height)
                Dim text2Font = New Font(Font.FontFamily(), (w + h) / 20)
                Dim text2Size = e.Graphics.MeasureString(_text2, text2Font)
                e.Graphics.DrawString(_text2, text2Font, textBrush, (Width - text2Size.Width) / 2, Height / 2 + 5)
            End If
        End Using
        ' A tester si l'appel à la fonction OnPaint de base est nécessaire
        MyBase.OnPaint(e)
    End Sub

    ' Réimplementation des évènements qui changent l'apparence
    ' (resize et changement de couleur quand la souris est sur
    ' le bouton)
    Protected Overrides Sub OnMouseDown(e As MouseEventArgs)
        Focus()
    End Sub
    Protected Overrides Sub OnResize(e As EventArgs)
        Invalidate()
        MyBase.OnResize(e)
    End Sub
    Protected Overrides Sub OnMouseEnter(e As EventArgs)
        _currentBackgroundColor = _backgroundHoverColor
        Invalidate()
        MyBase.OnMouseEnter(e)
    End Sub
    Protected Overrides Sub OnMouseLeave(e As EventArgs)
        _currentBackgroundColor = _backgroundColor
        Invalidate()
        MyBase.OnMouseLeave(e)
    End Sub

End Class
