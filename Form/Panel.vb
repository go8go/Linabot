Imports System.IO

Public Class Panel

#Region "Gestion comptes"

    Private Sub AjouterUnCompteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AjouterUnCompteToolStripMenuItem.Click

        Ajouter_Un_Compte.Show()

    End Sub

    Private Sub SupprimerUnCompteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SupprimerUnCompteToolStripMenuItem.Click

        Supprimer_un_compte.Show()

    End Sub

    Private Sub ChargerUnCompteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ChargerUnCompteToolStripMenuItem.Click

        Charger_Un_Compte.Show()

    End Sub

#End Region

#Region "Load"

    Private Sub Panel_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Je vérifie que le dossier "Comptes" existe.
        If Not Directory.Exists("Comptes") Then Directory.CreateDirectory("Comptes")

        'Je vérifie que le dossier "Options" existe.
        If Not Directory.Exists("Comptes\Options") Then Directory.CreateDirectory("Comptes\Options")

        'Je vérifie que le fichier "Account.txt" existe
        If Not File.Exists("Comptes/Accounts.txt") Then File.Create("Comptes/Accounts.txt").Close()

        'Je vérifie que le dossier "Image" existe.
        If Not Directory.Exists("Image") Then Directory.CreateDirectory("Image")

        'Je vérifie que le dossier "Personnage" existe.
        If Not Directory.Exists("Image\Personnage") Then Directory.CreateDirectory("Image\Personnage")

        'Je vérifie que le fichier "Serveur.txt" existe
        If Not File.Exists("Data/Serveur.txt") Then File.Create("Data/Serveur.txt").Close()

        Load_Information_Serveur()

        Load_Information_Personnage()

    End Sub

#End Region

End Class
