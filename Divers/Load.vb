Imports System.IO

Module Load

    Public Comptes As New List(Of Player)

    Public Version As String

    Public Dico_Personnage As New Dictionary(Of Integer, String())
    Public Dico_Serveur As New Dictionary(Of String, String())



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






End Module
