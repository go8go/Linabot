Imports System.IO

Module Load

    Public Comptes As New List(Of Player)

    Public Version As String

    Public Dico_Personnage As New Dictionary(Of Integer, String())
    Public Dico_Serveur As New Dictionary(Of String, String())
    Public Liste_Des_Objets As New Dictionary(Of Integer, String())
    Public Liste_Des_Mobs As New Dictionary(Of Integer, Dictionary(Of Integer, String()))


    Public Sub Load_Information_Serveur()

        'J'ouvre et je lis le fichier.
        Dim Sw_Lecture As New StreamReader(Application.StartupPath + "\Data/Serveur.txt")
        Dim ligne() As String = Split(Sw_Lecture.ReadToEnd, vbCrLf)

        'Puis je ferme le fichier.
        Sw_Lecture.Close()

        For i = 0 To ligne.Count - 1

            Dim Separation() As String = Split(ligne(i), "|")

            'Je vérifie d'abord que le dico ne contient pas déjà le serveur en question
            If Not Dico_Serveur.ContainsKey(Separation(0)) Then

                Dico_Serveur.Add(Separation(0), Separation) 'Nom Serveur | Nom Serveur , IP , Port , Code Connexion

            End If

        Next

    End Sub

    Public Sub Load_Information_Personnage()

        'J'ouvre et je lis le fichier.
        Dim Sw_Lecture As New StreamReader(Application.StartupPath + "\Data/Personnage.txt")
        Dim ligne() As String = Split(Sw_Lecture.ReadToEnd, vbCrLf)

        'Puis je ferme le fichier.
        Sw_Lecture.Close()

        For i = 0 To ligne.Count - 1

            Dim Separation() As String = Split(ligne(i), "|")

            'Je vérifie d'abord que le dico ne contient pas déjà le serveur en question
            If Not Dico_Personnage.ContainsKey(Separation(0)) Then

                Dico_Personnage.Add(Separation(0), 'ID personnage = Key
                                   {Separation(0), 'ID Personnage
                                    Separation(1), 'Nom de la classe
                                    Separation(2), 'Sexe
                                    Application.StartupPath & "\Image\Personnage/" & Separation(0) & ".png"}) 'Lien de l'image

            End If

        Next

    End Sub


    Public Sub LoadItems()

        Try

            Liste_Des_Objets.Clear()

            Dim monStreamReader As New StreamReader("Data/Objets.txt")

            Do Until monStreamReader.EndOfStream

                Dim Ligne As String = monStreamReader.ReadLine

                If Ligne <> "" Then

                    Dim Separation() As String = Split(Ligne, "|")

                    Liste_Des_Objets.Add(Separation(0), Separation) 'ID | ID - Nom - Catégorie - Pods

                End If
            Loop

            monStreamReader.Close()

        Catch ex As Exception

            Erreur_Fichier(0, "LoadItems", ex.Message)

        End Try

    End Sub

    Public Sub LoadMobs()
        Try
            Liste_Des_Mobs.Clear()
            Dim monStreamReader As New StreamReader("Data/Mobs.txt")
            Do Until monStreamReader.EndOfStream

                Dim Ligne As String = monStreamReader.ReadLine

                If Ligne <> "" Then
                    'Je split les informations du mob.
                    Dim Separation() As String = Split(Ligne, "|")
                    Dim ID_Mobs As Integer = Separation(0)
                    Dim Name_Mobs As String = Separation(1)

                    For i = 2 To Separation.Count - 1
                        'Je split les informations du mobs (résistance, etc...)
                        Dim Separation_Info() As String = Split(Separation(i), ":")

                        If Liste_Des_Mobs.ContainsKey(ID_Mobs) Then
                            'Je split les informations du mob.
                            'ID | Level | Name - Niveau - Rés Neutre - Rés Terre - Rés Feu - Rés Eau - Rés Air - Esquive PA - Esquive PM
                            Liste_Des_Mobs(ID_Mobs).Add(i - 2,
                            {Name_Mobs, Separation_Info(3), Separation_Info(4), Separation_Info(5), Separation_Info(6), Separation_Info(7), Separation_Info(8), Separation_Info(9)})
                        Else
                            'Si la dictionnary contient déjà l'ID du mob, alors j'ajoute seulement le lv et les informations du mob.
                            'ID | Level | Name - Niveau - Rés Neutre - Rés Terre - Rés Feu - Rés Eau - Rés Air - Esquive PA - Esquive PM
                            Liste_Des_Mobs.Add(ID_Mobs, New Dictionary(Of Integer, String()) From
                                               {
                                               {i - 2,
                           {Name_Mobs, Separation_Info(1), Separation_Info(3), Separation_Info(4), Separation_Info(5), Separation_Info(6), Separation_Info(7), Separation_Info(8), Separation_Info(9)}}})
                        End If
                    Next

                End If
            Loop

            monStreamReader.Close()
        Catch ex As Exception
            ' Erreur_Fichier(0, "LoadMobs", ex.Message)
        End Try
    End Sub

End Module
