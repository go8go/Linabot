Module Affiche_Item

    Public Sub Item_Affiche_Inventaire_Click(ByVal Index As Integer, ByVal Nom_Item As String, ByVal ID_Objet As Integer, ByVal ID_Unique As Integer, ByVal Quantité As Integer, ByVal Caractéristique As String, ByVal La_ListView As ListView)

        With Comptes(Index)._User

            La_ListView.Items.Clear()

            'Mettre dans le text la quantité, ainsi que l'ID unique en "name" simplifie la suppression, car tout sera indiqué directement sur le bouton.
            .Button_Inventaire_Supprimer.Name = ID_Unique
            .Button_Inventaire_Supprimer.Text = Quantité

            'J'affiche le nom de l'item
            .Label_Inventaire_Affiche_Nom.Text = Nom_Item

            'J'affiche l'mage de l'item.
            .PictureBox_Inventaire_Affiche_Caractéristique.Load(Application.StartupPath & "\" & ID_Objet & ".png")

            'Je mets les informations dans la ListView choisi
            Objet_Caractéristiques(ID_Objet, Caractéristique, La_ListView, .ImageList_Caractéristique)

        End With

    End Sub


End Module
