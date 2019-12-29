Public Class Picture_Box : Inherits PictureBox

    Private Ma_Picture_Box As PictureBox

    Sub New(ByVal Index As Integer, ByVal ID_Objet As Integer, ByVal ID_Unique As Integer, ByVal Caractéristique As String, ByVal Quantité As Integer)

        SetStyle(ControlStyles.SupportsTransparentBackColor, True)
        SetStyle(ControlStyles.UserPaint, True)
        SetStyle(ControlStyles.AllPaintingInWmPaint, True)
        SetStyle(ControlStyles.OptimizedDoubleBuffer, True)
        DoubleBuffered = True
        BackColor = Color.FromArgb(43, 44, 48)
        SizeMode = PictureBoxSizeMode.Zoom
        Size = New Size(80, 80)

        'Je donne l'ID unique de l'item comme nom
        Name = ID_Unique

        'Je charge l'image qui correspond à l'ID de l'objet
        Load(Application.StartupPath & "\" & ID_Objet & ".png")

        AddHandler MouseMove, Sub(Sender As Object, E As MouseEventArgs)
                                  BackColor = Color.Red
                              End Sub

        AddHandler MouseLeave, Sub(Sender As Object, E As EventArgs)
                                   BackColor = Color.FromArgb(43, 44, 48)
                               End Sub

        AddHandler Click, Sub() Item_Affiche_Inventaire_Click(Index, Caractéristique)

        AddHandler MouseMove, Sub() Item_Affiche_Inventaire_Quantité(Index, Quantité)

        'Uniquement si besoin de texte en info bulle
        'Comptes(Index)._User.ToolTip1.SetToolTip(Me, "Salut bande de nase")

        'Initialise mon label qui va afficher la quantité
        Dim Mon_Label As New Label
        Mon_Label.Text = Quantité
        Mon_Label.ForeColor = Color.White
        Mon_Label.Dock = DockStyle.Top
        Mon_Label.AutoSize = True
        Mon_Label.BackColor = Color.Transparent

        Controls.Add(Mon_Label)

    End Sub

End Class
