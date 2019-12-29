Imports System.IO

Public Class Ajouter_Un_Compte

#Region "Load"

    Private Sub Ajouter_Un_Compte_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Je vais ajouter les informations du serveur dans la liste.
        For i = 0 To Dico_Serveur.Count - 1

            'Je prend l'information directement depuis la "key" situé à "i"
            ComboBox_Choix_Serveur.Items.Add(Dico_Serveur.Keys(i))

        Next

        'Je vais ajouter les informations du serveur dans la liste.
        For Each Pair As KeyValuePair(Of Integer, String()) In Dico_Personnage

            'Je vérifie, si la combobox ne contient pas la classe, alors je l'ajoute.
            If Not ComboBox_Choix_Personnage.Items.Contains(Pair.Value(1)) Then

                ComboBox_Choix_Personnage.Items.Add(Pair.Value(1))

            End If

            'Je vérifie, si la combobox ne contient pas le sexe, alors je l'ajoute
            If Not ComboBox_Choix_Sexe.Items.Contains(Pair.Value(2)) Then

                ComboBox_Choix_Sexe.Items.Add(Pair.Value(2))

            End If

        Next

    End Sub

#End Region

#Region "ComboBox"

    Private Sub ComboBox_Choix_Personnage_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox_Choix_Personnage.SelectedIndexChanged, ComboBox_Choix_Sexe.SelectedIndexChanged

        'Je regarde avant si les 2 comboboxs comporte quelque chose, sinon je quitte pour éviter une erreur.
        If ComboBox_Choix_Personnage.Text = "" OrElse ComboBox_Choix_Sexe.Text = "" Then Return

        'Pour avoir la bonne "key" je prend l'index séléctionner sur le choix de personnage que je multiplie par "10".
        'puis j'additionne ça au combobox du sexe et j'y rajoute à la fin + "10", car le combobox du personnage commence à 0.
        PictureBox_Personnage.Load(Dico_Personnage(ComboBox_Choix_Personnage.SelectedIndex * 10 + ComboBox_Choix_Sexe.SelectedIndex + 10).GetValue(3)) '(Application.StartupPath & "\Image/" & ComboBox_Choix_Personnage.Text & " " & ComboBox_Choix_Sexe.Text & ".png")

    End Sub

#End Region

#Region "Text Box"

    Private Sub TextBox_Nom_De_Compte_TextChanged(sender As Object, e As EventArgs) Handles TextBox_Mot_De_Passe.Click, TextBox_Nom_Du_Personnage.Click, TextBox_Nom_De_Compte.Click

        'Si l'utilisateur clique sur la textbox, je supprimer les informations qu'elle contient.
        sender.Text = ""

        'Changement des informations du label.
        Changement_Information_Label("Inconnu", Color.White)

    End Sub

#End Region

#Region "Label"

    Private Sub Changement_Information_Label(ByVal Mot As String, ByVal La_Couleur As Color)

        'Je modifie le texte du label.
        Label_Création_Statut.Text = "Création du compte : " & Mot

        'Puis la couleur.
        Label_Création_Statut.ForeColor = La_Couleur

    End Sub

#End Region

#Region "Button"

    Private Sub Button_Charger_Les_Comptes_Click(sender As Object, e As EventArgs) Handles Button_Ajouter_Le_Compte.Click

        Try

            'Je lis le fichier.
            Dim Sw_Lecture As New StreamReader(Application.StartupPath + "\Comptes/Accounts.txt")
            Dim ligne As String = Sw_Lecture.ReadToEnd

            'Puis je ferme le fichier.
            Sw_Lecture.Close()

            'J'ouvre le fichier pour y écrire se que je souhaite
            Dim Sw_Ecriture As New StreamWriter(Application.StartupPath + "\Comptes/Accounts.txt")

            'Je met dans la ligne les informatiosn du nouveau compte avec les anciennes information lu avant.
            ligne &= TextBox_Nom_De_Compte.Text & "|" & TextBox_Mot_De_Passe.Text & "|" & TextBox_Nom_Du_Personnage.Text & "|" & ComboBox_Choix_Serveur.Text & "|" & ComboBox_Choix_Personnage.SelectedIndex * 10 + ComboBox_Choix_Sexe.SelectedIndex + 10

            'J'écris dedans avant de le fermer.
            Sw_Ecriture.WriteLine(ligne)

            'Puis je le ferme.
            Sw_Ecriture.Close()

            'Je mets les informations de base pour que se soit visible directement par l'utilisateur.
            TextBox_Nom_De_Compte.Text = "Nom de compte"
            TextBox_Mot_De_Passe.Text = "Mot de passe"
            TextBox_Nom_Du_Personnage.Text = "Nom du personnage"

            'SelectedIndex = 0 | Indique que je prend la première information qui se trouve dans la comboBox
            ComboBox_Choix_Personnage.SelectedIndex = 0
            ComboBox_Choix_Sexe.SelectedIndex = 0
            ComboBox_Choix_Serveur.SelectedIndex = 0

            Changement_Information_Label("Réussie", Color.Green)

        Catch ex As Exception

            Changement_Information_Label("Echec", Color.Red)

        End Try


    End Sub

#End Region


End Class