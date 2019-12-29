Imports System.IO

Module Divers

    Private Delegate Sub D_Divers()


    Public Function PassEnc(ByVal pwd As String, ByVal key As String) As String
        Dim l1, l2, l3, l4, l5 As Integer, l7 As String = "#1"
        Dim hash() As String = {"a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z", "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z", "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "-", "_"}
        Dim v1, v2 As String
        For l1 = 1 To Len(pwd)
            l2 = Asc(Mid(pwd, l1, 1))
            l3 = Asc(Mid(key, l1, 1))
            l5 = Fix(l2 / 16)
            l4 = l2 Mod 16
            v1 = hash(((l5 + l3) Mod (UBound(hash) + 1)) Mod (UBound(hash) + 1))
            v2 = hash(((l4 + l3) Mod (UBound(hash) + 1)) Mod (UBound(hash) + 1))
            l7 = l7 + v1 + v2
        Next
        Return l7
    End Function  ' Fonction du cryptage du mot de passe   'Provient de Maxoubot

    Public Sub EcritureMessage(ByVal Index As Integer, ByVal Indice As String, ByVal Message As String, ByVal Couleur As Color)
        With comptes(Index)._User
            Try
                If .InvokeRequired Then
                    .Invoke(New D_Divers(Sub() EcritureMessage(Index, Indice, Message, Couleur)))
                Else
                    .RichTextBox_Tchat.SelectionColor = Couleur
                    .RichTextBox_Tchat.AppendText("[" & TimeOfDay & "] " & Indice & " " & Message & vbCrLf)
                    .RichTextBox_Tchat.ScrollToCaret()
                End If
            Catch ex As Exception
                Erreur_Fichier(Index, "EcritureMessage", ex.Message)
            End Try
        End With
    End Sub

    Public Sub Erreur_Fichier(ByVal Index As Integer, ByVal Name_Erreur As String, ByVal Erreur As String)
        With comptes(Index)
            Try
                'Si le dossier Erreur n'existe pas, alors je le créer
                If Not Directory.Exists("Erreur") Then Directory.CreateDirectory("Erreur")

                EcritureMessage(Index, "[ERREUR]", "Une erreur c'est produite, veuillez envoyer le fichier créer dans 'Linabot\Fichier\Erreur\" & Name_Erreur & "' à Linaculer le roi des enculés", Color.Red)
                Dim sw As New StreamWriter(Application.StartupPath + "\Erreur/" & ._Nom_Du_Personnage & "_" & Name_Erreur & "_" & Mid(Panel.Text.Replace(".", ""), 13) & "_" & "_" & ".txt")
                sw.Write(Erreur)
                sw.Close()
            Catch ex As Exception
                MsgBox("Erreur fichier, impossible de créer le fichier erreur : " & Name_Erreur & vbCrLf & ex.ToString)
            End Try
        End With
    End Sub
    Public Sub Information_Inconnu(ByVal Index As Integer, ByVal Name_Erreur As String, ByVal Erreur As String)
        With Comptes(Index)
            Try
                'Si le dossier Erreur n'existe pas, alors je le créer
                If Not Directory.Exists("Erreur") Then Directory.CreateDirectory("Erreur")

                EcritureMessage(Index, "[ERREUR]", "Une erreur c'est produite, veuillez envoyer le fichier créer dans 'Linabot\Fichier\Erreur\" & Name_Erreur & "' à Linaculer le roi des enculés", Color.Red)
                ' Dim sw As New StreamWriter(Application.StartupPath + "\Erreur/" & .Nom_Personnage & "_" & Name_Erreur & "_" & Mid(Panel.Text.Replace(".", ""), 13) & "_" & .Tab_Personnage.Number_Erreur & "_" & ".txt")
                '  .Tab_Personnage.Number_Erreur += 1
                '  sw.Write(Erreur)
                '  sw.Close()
            Catch ex As Exception
                MsgBox("Erreur fichier, impossible de créer le fichier erreur : " & Name_Erreur & vbCrLf & ex.ToString)
            End Try
        End With
    End Sub

    Public Function AsciiDecoder(ByVal msg As String) As String
        Dim msgFinal As String = ""
        Dim iMax As Integer = msg.Length
        Dim i As Integer = 0
        While (i < iMax)
            Dim caractC As Char = msg(i)
            Dim caractI As Integer = Asc(caractC)
            Dim nbLettreCode As Integer = 1
            If (caractI And 128) = 0 Then
                msgFinal &= ChrW(caractI)
            Else
                Dim temp As Integer = 64
                Dim codecPremLettre As Integer = 63
                While (caractI And temp)
                    temp >>= 1
                    codecPremLettre = codecPremLettre Xor temp
                    nbLettreCode += 1
                End While
                codecPremLettre = codecPremLettre And 255
                Dim caractIFinal As Integer = caractI And codecPremLettre
                nbLettreCode -= 1
                i += 1
                While (nbLettreCode <> 0)
                    caractC = msg(i)
                    caractI = Asc(caractC)
                    caractIFinal <<= 6
                    caractIFinal = caractIFinal Or (caractI And 63)
                    nbLettreCode -= 1
                    i += 1
                End While
                msgFinal &= ChrW(caractIFinal)
            End If
            i += nbLettreCode
        End While
        Return msgFinal.Replace("%27", "'").Replace("%C3%A9", "é").Replace("%2C", ",").Replace("%3F", "?").Replace("%C3%A8", "é")
    End Function 'Provient de Maxoubot.

#Region "Serveur"

    Public Async Sub Packet_Serveur(ByVal Index As Integer, ByVal Information As String)

        'AH 601       ;1           ;75     ;1      |602;1;75;1
        'AH ID_Serveur;Etat_Serveur;Inconnu;Inconnu|_Serveur suivant

        With Comptes(Index)

            Information = Mid(Information, 3) 'Je prend les infos seulement après le "AH"

            Dim Separation_Serveur() As String = Split(Information, "|") 'Je sépare l'information pour chaque serveur.

            For i = 0 To Information.Count - 1

                Dim Separation() As String = Split(Information(i), ";")

                'Je vérifie que l'ID du serveur correspond à celui voulu et s'il est à 2 cela indique que le serveur est en sauvegarde.
                If Separation(0) = Dico_Serveur(._Serveur).GetValue(3) AndAlso Separation(1) = "2" Then

                    EcritureMessage(Index, "(Dofus)", "Serveur en sauvegarde !", Color.Red)
                    Await Task.Delay(30000)

                    ' Refresh la demande des serveurs  
                    .Socket_Authentification.Envoyer("Ax")

                    Return

                End If

            Next

        End With

    End Sub

#End Region
    Public Async Sub File_Attente_Refresh(ByVal Index As Integer)

        Await Task.Delay(5000)
        Comptes(Index).Socket.Envoyer("Af")

    End Sub

#Region "Encode_Decode"

    'A refaire "nom var" avec commentaire
    Public Const BASE36 As String = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ"
    Function Base36ToDec(ByVal sVal As String) As Long
        Dim lVal As Long
        Dim ChrPos As Integer

        lVal = 0
        sVal = UCase$(sVal)

        Do While Len(sVal) > 0
            lVal = lVal * 36

            ChrPos = InStr(BASE36, Left(sVal, 1))

            If ChrPos > 0 Then lVal = lVal + (ChrPos - 1)

            sVal = Mid(sVal, 2)
        Loop

        Return lVal
    End Function

#End Region

#Region "Cryptage/Décryptage"
    'Idem a refaire en comm
    'Maxoubot
    Public Function Décrypt_IP(ByVal IP_Crypt As String) As String

        ' Fonction de cryptage serveur      

        Dim i As Long = 0
        Dim fois As Long = 0
        Dim ipServeurJeu As String = ""

        While (i < 8)

            i = i + 1
            fois = fois + 1

            Dim dat1 As Integer = Asc(Mid(IP_Crypt, i, 1)) - 48

            i = i + 1

            Dim dat2 As Integer = Asc(Mid(IP_Crypt, i, 1)) - 48
            Dim Dat3 As String = Str((dat1 And 15) << 4 Or dat2 And 15)

            If fois > 1 Then
                ipServeurJeu = ipServeurJeu + Mid(Dat3, 2)
            Else
                ipServeurJeu = ipServeurJeu + Dat3
            End If

            If i < 8 Then
                ipServeurJeu = ipServeurJeu + "."
            End If

        End While

        Return ipServeurJeu.Replace(" ", "")

    End Function
    'Idem a refaire en comm
    'Salesprendes
    Dim caracteres_array As Char() = New Char() {"a"c, "b"c, "c"c, "d"c, "e"c, "f"c, "g"c, "h"c, "i"c, "j"c, "k"c, "l"c, "m"c, "n"c, "o"c, "p"c, "q"c, "r"c, "s"c, "t"c, "u"c, "v"c, "w"c, "x"c, "y"c, "z"c, "A"c, "B"c, "C"c, "D"c, "E"c, "F"c, "G"c, "H"c, "I"c, "J"c, "K"c, "L"c, "M"c, "N"c, "O"c, "P"c, "Q"c, "R"c, "S"c, "T"c, "U"c, "V"c, "W"c, "X"c, "Y"c, "Z"c, "0"c, "1"c, "2"c, "3"c, "4"c, "5"c, "6"c, "7"c, "8"c, "9"c, "-"c, "_"c}

    Public Function Décrypt_Port(ByVal chars As Char()) As Integer

        If chars.Length <> 3 Then Throw New ArgumentOutOfRangeException("El puerto debe estar encriptado en 3 caracteres.")

        Dim puerto As Integer = 0

        For i As Integer = 0 To 2 - 1
            puerto += CInt((Math.Pow(64, 2 - i) * get_Hash(chars(i))))
        Next

        puerto += get_Hash(chars(2))

        Return puerto
    End Function
    Public Function get_Hash(ByVal ch As Char) As Short

        For i As Short = 0 To caracteres_array.Length - 1

            If caracteres_array(i) = ch Then Return i

        Next

    End Function

#End Region
End Module
