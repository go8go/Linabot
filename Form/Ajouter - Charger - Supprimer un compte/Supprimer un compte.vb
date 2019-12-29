Imports System.IO

Public Class Supprimer_un_compte

    Private Dico_Supprime_Personnage As New Dictionary(Of String, Integer)

    Private Sub Button_Supprimer_Le_Compte_Click(sender As Object, e As EventArgs) Handles Button_Supprimer_Le_Compte.Click

        Try
            'J'ouvre et je lis le fichier.
            Dim Sw_Lecture As New StreamReader(Application.StartupPath + "\Comptes/Accounts.txt")
            Dim ligne() As String = Split(Sw_Lecture.ReadToEnd, vbCrLf)

            'Puis je ferme le fichier.
            Sw_Lecture.Close()

            'Puis je réecrit le fichier sans le(s) compte(s) sélectionné(s)
            Dim Sw_Ecriture As New StreamWriter(Application.StartupPath + "\Comptes/Accounts.txt")

            For i = 0 To ligne.Count - 1

                If ligne(i) <> "" Then

                    Dim Separation() As String = Split(ligne(i), "|")

                    'Si le compte n'est pas sélectionné, ça indique qu'il ne doit pas être supprimé, donc je le re écrit dans le fichier.
                    If Not ListBox_Compte.SelectedItems.Contains(Separation(0) & " (" & Separation(2) & ")") Then

                        Sw_Ecriture.WriteLine(ligne(i))

                    Else

                        'Vue qu'il est sélectionné, donc il doit être supprimé, je ne le re écrit pas dans le fichier et je supprime aussi le fichier "option" du compte.
                        If File.Exists(Application.StartupPath + "\Comptes\Options\" & Separation(2) & ".txt") Then My.Computer.FileSystem.DeleteFile(Application.StartupPath + "\Comptes\Options\" & Separation(2) & ".txt")

                        Label_Suppression_Statut.Text = "Suppression du/des compte(s) : Réussie"
                        Label_Suppression_Statut.ForeColor = Color.Green

                    End If

                End If

            Next

            Sw_Ecriture.Close()

        Catch ex As Exception

            Label_Suppression_Statut.Text = "Suppression du/des compte(s) : Echoué"
            Label_Suppression_Statut.ForeColor = Color.Red

        End Try

        'Je recharge toutes les informations comme si le formulaire vener de s'ouvrir.
        Supprimer_un_compte_Load(Nothing, Nothing)

    End Sub

#Region "Load"

    Private Sub Supprimer_un_compte_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try

            'J'ouvre et je lis le fichier.
            Dim Sw_Lecture As New StreamReader(Application.StartupPath + "\Comptes/Accounts.txt")
            Dim ligne() As String = Split(Sw_Lecture.ReadToEnd, vbCrLf)

            'Puis je ferme le fichier.
            Sw_Lecture.Close()

            'Je supprime tout se qui se trouve dans la listbox
            ListBox_Compte.Items.Clear()
            Dico_Supprime_Personnage.Clear()

            'Puis je les mets dans la listbox
            For i As Integer = 0 To ligne.Count - 1

                If ligne(i) <> "" Then

                    'Nom de compte | Mot de passe | Nom du personnage | Serveur | Classe + Sexe
                    Dim Separation() As String = Split(ligne(i), "|")

                    'Si mon dico ne contient pas le compte, alors je l'ajoute au dico et à ma liste.
                    If Not Dico_Supprime_Personnage.ContainsKey(Separation(0) & " (" & Separation(2) & ")") Then

                        Dico_Supprime_Personnage.Add(Separation(0) & " (" & Separation(2) & ")", Separation(4)) 'Nom de compte + Nom du personnage | Classe + sexe

                        ListBox_Compte.Items.Add(Separation(0) & " (" & Separation(2) & ")") 'Nom de compte + Nom du personnage

                    End If

                End If

            Next

            Label_Suppression_Statut.Text = "Suppression du/des compte(s) : Inconnu"
            Label_Suppression_Statut.ForeColor = Color.White

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

End Class