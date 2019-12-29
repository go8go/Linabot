Imports System.IO

Public Class Charger_Un_Compte

    Private Dico_Supprime_Personnage As New Dictionary(Of String, Integer)

#Region "Load"

    Private Sub Charger_Un_Compte_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try

            'J'ouvre et je lis le fichier.
            Dim Sw_Lecture As New StreamReader(Application.StartupPath + "\Comptes/Accounts.txt")
            Dim ligne() As String = Split(Sw_Lecture.ReadToEnd, vbCrLf)

            'Puis je ferme le fichier.
            Sw_Lecture.Close()

            'Je supprime tout se qui se trouve dans la listbox
            ListBox_Compte.Items.Clear()

            'Puis je les mets dans la listbox
            For i As Integer = 0 To ligne.Count - 1

                If ligne(i) <> "" Then

                    Dim Separation() As String = Split(ligne(i), "|")

                    If Not Dico_Supprime_Personnage.ContainsKey(Separation(0) & " (" & Separation(2) & ")") Then

                        Dico_Supprime_Personnage.Add(Separation(0) & " (" & Separation(2) & ")", Separation(4)) 'Nom de compte + Nom du personnage | Classe + sexe

                        ListBox_Compte.Items.Add(Separation(0) & " (" & Separation(2) & ")") 'Nom de compte + Nom du personnage

                    End If

                End If

            Next

            Label_Charger_Statut.Text = "Charger le(s) compte(s) : Inconnu"
            Label_Charger_Statut.ForeColor = Color.White

        Catch ex As Exception

        End Try

    End Sub

#End Region

#Region "List Box"

    Private Sub ListBox_Compte_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox_Compte.SelectedIndexChanged

        Try

            If ListBox_Compte.SelectedItem <> Nothing Then

                Dim Dernier_Index_Séléctionné As Integer = GetType(ListBox).GetProperty("FocusedIndex", Reflection.BindingFlags.NonPublic Or Reflection.BindingFlags.Instance).GetValue(ListBox_Compte, Nothing)

                PictureBox_Personnage.Load(Dico_Personnage(Dico_Supprime_Personnage(ListBox_Compte.Items(Dernier_Index_Séléctionné))).GetValue(3))

            End If

        Catch ex As Exception

        End Try

    End Sub

#End Region

#Region "Button"

    Private Sub Button_Charger_Click(sender As Object, e As EventArgs) Handles Button_Charger.Click

        'Création et ajout du form "Groupe" au panel.
        Dim Form_Groupe As New Groupe
        Form_Groupe.Text = "_Groupe"

        'J'indique a Form_Groupe que son Parent est le panel
        Form_Groupe.MdiParent = Panel

        'Puis j'appelle la form pour quel soit mis à l'intérieur du panel.
        Form_Groupe.Show()

        'Je lis le fichier pour obtenir les comptes.
        Dim Sw_Lecture As New StreamReader(Application.StartupPath + "\Comptes/Accounts.txt")
        Dim ligne() As String = Split(Sw_Lecture.ReadToEnd, vbCrLf)
        Sw_Lecture.Close()

        'Création d'un compteur pour les indexs du bot.
        Dim Compteur As Integer = 0

        For i = 0 To ligne.Count - 1

            'Je vérifie que la ligne contient au moins un caractére
            If ligne(i) <> "" Then

                Dim Separation() As String = Split(ligne(i), "|")

                'Je regarde si l'une des sélections correspond à la ligne actuel.
                If ListBox_Compte.SelectedItems.Contains(Separation(0) & " (" & Separation(2) & ")") Then 'Nom de compte + Nom du personnage

                    'J'ajoute alors aux comptes la class Player.
                    comptes.Add(New Player)

                    'Puis pour le comptes actuel je met les informations nécessaire.
                    With comptes(comptes.Count - 1)

                        ._Nom_De_Compte = Separation(0)
                        ._Mot_De_Passe = Separation(1)
                        ._Nom_Du_Personnage = Separation(2)
                        ._Serveur = Separation(3)
                        ._Index = Compteur
                        ._Groupe = Form_Groupe

                        .Initialiser(Form_Groupe, Compteur, Separation(4))

                        Compteur += 1

                    End With

                End If

            End If

        Next

        Close()

    End Sub

#End Region


End Class