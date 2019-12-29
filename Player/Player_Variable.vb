Partial Public Class Player

    'Information du compte
    Public _Nom_De_Compte, _Mot_De_Passe, _Nom_Du_Personnage, _Serveur, _Ticket, _ID_Unique As String

    'Index
    Public _Index As Integer

    'Le groupe
    Public _Groupe As New Groupe

    'La page initial + le tab_personnage pour le groupe
    Public _User As New Page_Initial
    Dim Tab_Perso As New TabPage

    'Connexion
    Public _En_Connexion, _Connecté As Boolean

    'Les Sockets
    Public Socket_Authentification, Socket As All_CallBack

    'Caractéristique
    Public _Up_Caractéristique As Boolean

    'Pods
    Public _Pods As Integer

    'Régénération
    Public _Régénération As Integer

    'Autorisation de base
    Public _Autorisation_Echange As Boolean
    Public _Autorisation_Défi As Boolean
    Public _Autorisation_Agression As Boolean
    Public _Autorisation_Interraction As Boolean
    Public _Autorisation_Attaquer_Mobs As Boolean

    'Equipement
    Public _Coiffe, _Cape, _Ceinture, _Bottes, _Amulette, _Familier, _CaC, _Anneaux(1), _Dofus(5) As String

    'Vivant ou mort
    Public _Fantôme As Boolean

    'Dialogue
    Public _En_Dialogue As Boolean
    Public _Dialogue_ID_Réponse As Integer
    Public _Dialogue_Réponses_Possible As New List(Of String)

    'Craft
    Public _En_Craft As Boolean
    Public _En_Atelier As Boolean
    Public _Craft_Combiner_Moi, _Craft_Combiner_Lui As Boolean

    'Echange
    Public _En_Echange As Boolean

    'Hôtel de vente
    Public _En_Hôtel_De_Vente As Boolean

    'Achat/Vente
    Public _En_Achat_Vente As Boolean

    'Banque ou Coffre
    Public _En_Banque_Coffre As Boolean

    'Enclos
    Public _En_Enclos As Boolean



#Region "Initialise"

    Public Sub Initialiser(ByVal Form_Groupe As Groupe, ByVal Compteur As Integer, ByVal Image As String)

        'Je nomme le Tab_Page par le nom du personnage.
        Tab_Perso.Text = _Nom_Du_Personnage

        'J'ajoute à la form "groupe", dans le tabcontrol, le tab_page.
        Form_Groupe.TabControl1.Controls.Add(Tab_Perso)

        'Dans le Tab_Page j'ajoute "Page_Initial"
        Tab_Perso.Controls.Add(_User)

        'Je donne l'index aussi dans le Panel_utilisateur
        _User.Index = Compteur

        'Puis je donne le groupe auquel il appartient.
        _Groupe = Form_Groupe

        'Je met l'image associé
        Tab_Perso.ImageKey = Image & ".png"

    End Sub


#End Region

End Class
