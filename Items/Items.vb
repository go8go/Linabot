Module Items

    Dim Dico_Caractéristique As New Dictionary(Of String, String) From
        {
        {"76", "Force : "},
        {"9d", "Force : -"},
        {"7d", "Vitalité : "},
        {"99", "Vitalité : -"},
        {"7c", "Sagesse : "},
        {"9c", "Sagesse : -"},
        {"7e", "Intelligence : "},
        {"9b", "Intelligence : -"},
        {"7b", "Chance : "},
        {"98", "Chance : -"},
        {"77", "Agilité : "},
        {"9a", "Agilité : -"},
        {"6f", "PA : "},
        {"65", "PA : -"},
        {"80", "PM : "},
        {"7f", "PM : -"},
        {"75", "PO : "},
        {"74", "PO : -"},
        {"b6", "Invocation : "},
        {"ae", "Initiative : "},
        {"b0", "Prospection : "},
        {"9e", "Pods : "},
        {"73", "Coups Critiques : "},
        {"70", "Dommage : "},
        {"e1", "Dommage Piège : "},
        {"8a", "%Dommage : "},
        {"b2", "Soin : "},
        {"6e", "Régénération : "},
        {"f0", "Résistance Terre : "},
        {"f1", "Résistance Eau : "},
        {"f2", "Résistance Air : "},
        {"f3", "Résistance Feu : "},
        {"f4", "Résistance Neutre : "},
        {"d2", "%Résistance Terre : "},
        {"d7", "%Résistance Terre : -"},
        {"d3", "%Résistance Eau : "},
        {"d8", "%Résistance Eau : -"},
        {"d4", "%Résistance Air : "},
        {"d9", "%Résistance Air : -"},
        {"d5", "%Résistance Feu : "},
        {"da", "%Résistance Feu : -"},
        {"d6", "%Résistance Neutre : "},
        {"db", "%Résistance Neutre : -"},
        {"64", "Corps à Corps : "},
        {"320", "Point de vie : "},
        {"", ""}
        }

    Public Sub Items_Ajoute_FlowLayout(ByVal Index As Integer, ByVal Information() As String, ByVal Flow_Panel As FlowLayoutPanel, ByVal La_ListView As ListView)

        With Comptes(Index)

            If Information(0) <> "" Then

                For i = 0 To Information.Count - 2

                    'a30d2a~1fd6~1~0~7d#63#0#0#0d0+99
                    Dim Separation_Information() As String = Split(Information(i), "~")

                    Separation_Information(1) = Convert.ToInt64(Separation_Information(1), 16)

                    'En cours de changement.

                    With Flow_Panel



                        Dim Picture_Box As New Picture_Box(Index,
                                                           Liste_Des_Objets(Separation_Information(1)).GetValue(1), 'Nom Item
                                                           Separation_Information(1), 'ID Objet
                                                           Convert.ToInt64(Separation_Information(0), 16), 'ID Unique
                                                           Convert.ToInt64(Separation_Information(2), 16), 'Quantité
                                                           Separation_Information(4),'Caractéristique
                                                           If(Separation_Information(3) <> Nothing, Color.Red, 'S'il s'agit d'un équipement actuellement équipé.
                                                           If(Liste_Des_Objets(Separation_Information(1)).GetValue(3) = 0, Color.Orange,  'S'il s'agit d'un objet de quêtes
                                                           Color.FromArgb(43, 44, 48))), 'sinon je donne la couleur de base Couleur
                                                           La_ListView) 'Je donne la listview associé à la picturebox (exemple : banque, inventaire etc...)


                        'S'il s'agit d'un Item équipé sur moi.
                        If Separation_Information(3) <> Nothing Then

                            'Information
                            Equipement_Equipé(Index, Separation_Information(1), .Cells(3).Value, Convert.ToInt64(Separation_Information(3), 16))


                        End If

                    End With

                Next

            End If

        End With

    End Sub

    'EN COURS DE MODIFICATION !!!!

    Public Function Objet_Caractéristiques(ByVal ID_Objet As String, ByVal Caractéristique As String, ByVal La_Listview As ListView, ByVal La_ImageList As ImageList) As String

        Try
            '76 #a             #0     #0                                      ,Next
            '7b #1             #0     #0     #0d0+1
            'ID #Divers        #Divers#Divers#Divers (surtout cac pour dégâts)

            ' .ListView_Inventaire_Affiche_Caractéristique.Items.Add(Objet_Caractéristiques(ID_Objet, Caractéristique), .ImageList_Caractéristique.Images.Keys.IndexOf(Separation_Info(0) & ".png"))

            If Caractéristique <> "" Then

                Dim Separation() As String = Split(Caractéristique.Replace("0d0+", ""), ",")

                Caractéristique = ""

                For i = 0 To Separation.Count - 1

                    Dim Separation_Info() As String = Split(Separation(i), "#")

                    Select Case Separation_Info(0)


                        Case "76" 'Force +

                            La_Listview.Items.Add("+" & Convert.ToInt64(Separation_Info(1), 16) & " Force", La_ImageList.Images.Keys.IndexOf("Force.png"))

                        Case "9d" 'Force -

                            La_Listview.Items.Add("-" & Convert.ToInt64(Separation_Info(1), 16) & " Force", La_ImageList.Images.Keys.IndexOf("Force.png"))

                        Case "7d" 'Vitalité +

                            La_Listview.Items.Add("+" & Convert.ToInt64(Separation_Info(1), 16) & " Vitalité", La_ImageList.Images.Keys.IndexOf("Vitalité.png"))

                        Case "99" 'Vitalité -

                            La_Listview.Items.Add("-" & Convert.ToInt64(Separation_Info(1), 16) & " Vitalité", La_ImageList.Images.Keys.IndexOf("Vitalité.png"))

                        Case "7c" 'Sagesse +

                            La_Listview.Items.Add("+" & Convert.ToInt64(Separation_Info(1), 16) & " Sagesse", La_ImageList.Images.Keys.IndexOf("Sagesse.png"))

                        Case "9c" 'Sagesse -

                            La_Listview.Items.Add("-" & Convert.ToInt64(Separation_Info(1), 16) & " Sagesse", La_ImageList.Images.Keys.IndexOf("Sagesse.png"))

                        Case "7e" 'Intelligence +

                            La_Listview.Items.Add("+" & Convert.ToInt64(Separation_Info(1), 16) & " Intelligence", La_ImageList.Images.Keys.IndexOf("Intelligence.png"))

                        Case "9b" 'Intelligence -

                            La_Listview.Items.Add("-" & Convert.ToInt64(Separation_Info(1), 16) & " Intelligence", La_ImageList.Images.Keys.IndexOf("Intelligence.png"))

                        Case "7b" 'Chance +

                            La_Listview.Items.Add("+" & Convert.ToInt64(Separation_Info(1), 16) & " Chance", La_ImageList.Images.Keys.IndexOf("Chance.png"))

                        Case "98" 'Chance -

                            La_Listview.Items.Add("-" & Convert.ToInt64(Separation_Info(1), 16) & " Chance", La_ImageList.Images.Keys.IndexOf("Chance.png"))

                        Case "77" 'Agilité +

                            La_Listview.Items.Add("+" & Convert.ToInt64(Separation_Info(1), 16) & " Agilité", La_ImageList.Images.Keys.IndexOf("Agilité.png"))

                        Case "9a" 'Agilité -

                            La_Listview.Items.Add("-" & Convert.ToInt64(Separation_Info(1), 16) & " Agilité", La_ImageList.Images.Keys.IndexOf("Agilité.png"))

                        Case "6f" 'PA +

                            La_Listview.Items.Add("+" & Convert.ToInt64(Separation_Info(1), 16) & " PA", La_ImageList.Images.Keys.IndexOf("PA.png"))

                        Case "65" 'PA -

                            La_Listview.Items.Add("-" & Convert.ToInt64(Separation_Info(1), 16) & " PA", La_ImageList.Images.Keys.IndexOf("PA.png"))

                        Case "80" 'PM +

                            La_Listview.Items.Add("+" & Convert.ToInt64(Separation_Info(1), 16) & " PM", La_ImageList.Images.Keys.IndexOf("PM.png"))

                        Case "7f" 'PM -

                            La_Listview.Items.Add("-" & Convert.ToInt64(Separation_Info(1), 16) & " PM", La_ImageList.Images.Keys.IndexOf("PM.png"))

                        Case "75" 'PO +

                            La_Listview.Items.Add("+" & Convert.ToInt64(Separation_Info(1), 16) & " PO", La_ImageList.Images.Keys.IndexOf("PO.png"))

                        Case "74" 'PO -

                            La_Listview.Items.Add("-" & Convert.ToInt64(Separation_Info(1), 16) & " PO", La_ImageList.Images.Keys.IndexOf("PO.png"))



                            'MANQUANT A FINIR

                        Case "b6" 'Invocation +

                            La_Listview.Items.Add("+" & Convert.ToInt64(Separation_Info(1), 16) & " Invocation", La_ImageList.Images.Keys.IndexOf("Invocation.png"))

                        Case "ae" 'Initiative +

                            La_Listview.Items.Add("+" & Convert.ToInt64(Separation_Info(1), 16) & " Initiative", La_ImageList.Images.Keys.IndexOf("Initiative.png"))

                        Case "b0" 'Prospection +

                            La_Listview.Items.Add("+" & Convert.ToInt64(Separation_Info(1), 16) & " Prospection", La_ImageList.Images.Keys.IndexOf("Prospection.png"))

                        Case "9e" 'Pods +

                            La_Listview.Items.Add("+" & Convert.ToInt64(Separation_Info(1), 16) & " Pods", La_ImageList.Images.Keys.IndexOf("Pods.png"))

                        Case "73" 'Coups Critiques +

                            La_Listview.Items.Add("+" & Convert.ToInt64(Separation_Info(1), 16) & " Coups Critiques", La_ImageList.Images.Keys.IndexOf("Coups Critiques.png"))

                        Case "70" 'Dommage +

                            La_Listview.Items.Add("+" & Convert.ToInt64(Separation_Info(1), 16) & " Dommage", La_ImageList.Images.Keys.IndexOf("Dommage.png"))

                        Case "e1" 'Dommage Piège +

                            La_Listview.Items.Add("+" & Convert.ToInt64(Separation_Info(1), 16) & " Dommage Piège", La_ImageList.Images.Keys.IndexOf("Dommage Piège.png"))

                        Case "8a" '%Dommage +

                            La_Listview.Items.Add("+" & Convert.ToInt64(Separation_Info(1), 16) & " %Dommage", La_ImageList.Images.Keys.IndexOf("%Dommage.png"))

                        Case "b2" 'Soin +

                            La_Listview.Items.Add("+" & Convert.ToInt64(Separation_Info(1), 16) & " Soin", La_ImageList.Images.Keys.IndexOf("Soin.png"))

                        Case "6e" 'Régénération +

                            La_Listview.Items.Add("+" & Convert.ToInt64(Separation_Info(1), 16) & " Régénération", La_ImageList.Images.Keys.IndexOf("Régénération.png"))

                        Case "f0" 'Résistance Terre +

                            La_Listview.Items.Add("+" & Convert.ToInt64(Separation_Info(1), 16) & " Résistance Terre", La_ImageList.Images.Keys.IndexOf("Résistance Terre.png"))

                        Case "f1" 'Résistance Eau +

                            La_Listview.Items.Add("+" & Convert.ToInt64(Separation_Info(1), 16) & " Résistance Eau", La_ImageList.Images.Keys.IndexOf("Résistance Eau.png"))

                        Case "f2" 'Résistance Air +

                            La_Listview.Items.Add("+" & Convert.ToInt64(Separation_Info(1), 16) & " Résistance Air", La_ImageList.Images.Keys.IndexOf("Résistance Air.png"))

                        Case "f3" 'Résistance Feu +

                            La_Listview.Items.Add("+" & Convert.ToInt64(Separation_Info(1), 16) & " Résistance Feu", La_ImageList.Images.Keys.IndexOf("Résistance Feu.png"))

                        Case "f4" 'Résistance Neutre +

                            La_Listview.Items.Add("+" & Convert.ToInt64(Separation_Info(1), 16) & " Résistance Neutre", La_ImageList.Images.Keys.IndexOf("Résistance Neutre.png"))

                        Case "d2" '%Résistance Terre +

                            La_Listview.Items.Add("+" & Convert.ToInt64(Separation_Info(1), 16) & " %Résistance Terre", La_ImageList.Images.Keys.IndexOf("%Résistance Terre.png"))

                        Case "d7" '%Résistance Terre -

                            La_Listview.Items.Add("-" & Convert.ToInt64(Separation_Info(1), 16) & " %Résistance Terre", La_ImageList.Images.Keys.IndexOf("%Résistance Terre.png"))

                        Case "d3" '%Résistance Eau +

                            La_Listview.Items.Add("+" & Convert.ToInt64(Separation_Info(1), 16) & " %Résistance Eau", La_ImageList.Images.Keys.IndexOf("%Résistance Eau.png"))

                        Case "d8" '%Résistance Eau -

                            La_Listview.Items.Add("-" & Convert.ToInt64(Separation_Info(1), 16) & " %Résistance Eau", La_ImageList.Images.Keys.IndexOf("%Résistance Eau.png"))

                        Case "d4" '%Résistance Air  +

                            La_Listview.Items.Add("+" & Convert.ToInt64(Separation_Info(1), 16) & " %Résistance Air", La_ImageList.Images.Keys.IndexOf("%Résistance Air.png"))

                        Case "d9" '%Résistance Air  -

                            La_Listview.Items.Add("-" & Convert.ToInt64(Separation_Info(1), 16) & " %Résistance Air", La_ImageList.Images.Keys.IndexOf("%Résistance Air.png"))

                        Case "d5" '%Résistance Feu +

                            La_Listview.Items.Add("+" & Convert.ToInt64(Separation_Info(1), 16) & " %Résistance Feu", La_ImageList.Images.Keys.IndexOf("%Résistance Feu.png"))

                        Case "da" '%Résistance Feu -

                            La_Listview.Items.Add("-" & Convert.ToInt64(Separation_Info(1), 16) & " %Résistance Feu", La_ImageList.Images.Keys.IndexOf("%Résistance Feu.png"))

                        Case "d6" '%Résistance Neutre +

                            La_Listview.Items.Add("+" & Convert.ToInt64(Separation_Info(1), 16) & " %Résistance Neutre", La_ImageList.Images.Keys.IndexOf("%Résistance Neutre.png"))

                        Case "db" '%Résistance Neutre -

                            La_Listview.Items.Add("-" & Convert.ToInt64(Separation_Info(1), 16) & " %Résistance Neutre", La_ImageList.Images.Keys.IndexOf("%Résistance Neutre.png"))

                        Case "64" 'Corps à Corps +

                            La_Listview.Items.Add("+" & Separation_Info(4) & " Corps à Corps", La_ImageList.Images.Keys.IndexOf("Corps à Corps.png"))

                        Case "320" 'Point de vie +

                            La_Listview.Items.Add("+" & Convert.ToInt64(Separation_Info(1), 16) & " Point de vie", La_ImageList.Images.Keys.IndexOf("Point de vie.png"))


'A REFAIRE

                        Case "32" 'Inconnu

                            'Familier

                        Case "320"
                            '320#5      #48     #7
                            'pdv#Inconnu#Inconnu#Point de vie
                            Caractéristique &= Dico_Caractéristique(Separation_Info(0)) & Convert.ToInt64(Separation_Info(3), 16) & vbCrLf

                        Case "326" 'Repas et Corpulence 
                            '326#1      #0            #64
                            '   #Inconnu#Repas en trop#Repas Manquant                   
                            Separation_Info(3) = Convert.ToInt64(Separation_Info(3), 16) 'Repas
                            Separation_Info(2) = Convert.ToInt64(Separation_Info(2), 16) 'Corpulence

                            If CInt(Separation_Info(3)) >= 7 Then

                                Caractéristique &= "Repas Manquant : " & Separation_Info(3) & vbCrLf
                                Caractéristique &= "Corpulence : Maigrichon" & vbCrLf

                            ElseIf CInt(Separation_Info(2)) >= 7 Then

                                Caractéristique &= "Repas en trop : " & Separation_Info(2) & vbCrLf
                                Caractéristique &= "Corpulence : Obése" & vbCrLf

                            Else

                                Caractéristique &= "Corpulence : Normal" & vbCrLf

                            End If


                        Case "327" ' Dernier Repas (objet use)

                            Select Case Separation_Info(3)

                                Case "842"
                                    Caractéristique &= "Dernier repas : Aliment Inconnu" & vbCrLf
                                Case "0"
                                    Caractéristique &= "Dernier repas : Aucun" & vbCrLf
                                Case Else
                                    Caractéristique &= "Dernier repas : " & Liste_Des_Objets(Convert.ToInt64(Separation_Info(3), 16)).GetValue(1) & vbCrLf
                            End Select

                        Case "328" 'Date / Heure  
                            '328#288          #396             #475 
                            '   #Année + 1370 #Mois +1 et Jour #Heure + Minute

                            Dim Année As Integer = Convert.ToInt64(Separation_Info(1), 16) + 1370
                            Dim Mois As String = Convert.ToInt64(Separation_Info(2), 16)
                            Dim Jour As Integer
                            Dim Heure As String = "00:00"

                            Select Case Mois.Length
                                Case 1
                                    Jour = "0" & Mois
                                    Mois = "01"
                                Case 2
                                    Mois = "01"
                                Case 3
                                    Jour = Mois.Substring(1, 2)
                                    Mois = CInt(Mois.Substring(0, 1)) + 1
                                Case 4
                                    Jour = Mois.Substring(2, 2)
                                    Mois = CInt(Mois.Substring(0, 2)) + 1
                            End Select

                            If Mois.Length = 1 Then Mois = "0" & Mois

                            Caractéristique &= "Date : " & Jour & "/" & Mois & "/" & Année & vbCrLf

                            Heure = Convert.ToInt64(Separation_Info(3), 16)

                            Select Case Heure.Length
                                Case 0, 1 : Caractéristique &= "Heure : 00:0" & Heure & vbCrLf
                                Case 2 : Caractéristique &= "Heure : 00" & Heure.Insert(0, ":") & vbCrLf
                                Case 3 : Caractéristique &= "Heure : 0" & Heure.Insert(1, ":") & vbCrLf
                                Case 4 : Caractéristique &= "Heure : " & Heure.Insert(2, ":") & vbCrLf
                            End Select

                        Case "3ac" 'Capacité accrue Familier

                            Caractéristique &= "Capacité accrue : Oui" & vbCrLf

                            'Dragodinde
                        Case "3e3" ' ID de la dragodinde pour avoir les caractéristiques (quand elle se trouve dans l'inventaire)

                            Caractéristique &= "ID Dragodinde : " & Convert.ToInt64(Separation_Info(1), 16) & "|" & Convert.ToInt64(Separation_Info(2), 16) & vbCrLf

                            If Separation.Length < 4 Then Caractéristique &= "Nom Dragodinde : Inconnu" & vbCrLf

                        Case "3e4" 'Nom du joueur qui posséde la dragodinde.

                            Caractéristique &= "¨Dragodinde (Possesseur) : " & Separation_Info(4) & vbCrLf

                        Case "3e5" 'Nom de la dragodinde

                            Caractéristique &= "Nom Dragodinde : " & Separation_Info(4) & vbCrLf

                        Case "3e6" ' Jour/ heure / minute restant.

                            Caractéristique &= "Dragodinde Validité : " & Convert.ToInt64(Separation_Info(1), 16) & "j" & Convert.ToInt64(Separation_Info(2), 16) & "h" & Convert.ToInt64(Separation_Info(3), 16) & "m" & vbCrLf

                        Case "325" 'Divers

                            Caractéristique &= "Certificat Dopeul" & vbCrLf

                        Case "26f" 'Pierre d'âme 

                            Caractéristique &= "Pierre d'âme : " & Liste_Des_Mobs(Convert.ToInt64(Separation_Info(3), 16))(0).GetValue(0) & vbCrLf

                    End Select

                Next

            End If

        Catch ex As Exception

            Erreur_Fichier(0, "Caractéristiques_Objet", Caractéristique & vbCrLf & ex.Message)

        End Try

        Return Caractéristique

    End Function

    Private Function Calcul_Jour_Restant_Familier(ByVal Caractéristique As Integer, ByVal ID_Objet As String) As String

        Dim Repas As Integer

        'Les calculs se base sur des familiers avec les stats qui coûte le plus chère à la revente du familier.

        If Caractéristique > 0 Then

            'Calcul du nombre de caractéristique manquante avant d'être full (sans la capacité accrue)
            Select Case ID_Objet

                Case 7414, 8000

                    Caractéristique = If(ID_Objet = 7414, 800, 1000) - Caractéristique
                    Caractéristique = Caractéristique / If(ID_Objet = 7414, 5, 10)

                Case 7520

                    Caractéristique = 20 - Caractéristique

                Case 9623, 7519, 7704, 9617, 7705, 8211, 7892, 8561, 7911, 7524, 7522, 7415

                    Caractéristique = 50 - Caractéristique

                Case 6978

                    Caractéristique = 400 - Caractéristique

                Case 7708, 7709, 7711, 7712, 7891, 1728, 2074, 2075, 2076, 2077, 1748, 6716

                    Caractéristique = 80 - Caractéristique

                Case 7518

                    Caractéristique = 150 - Caractéristique

                Case 7703

                    Caractéristique = 40 - Caractéristique

                Case 7710, 7713, 7706, 8677, 7714

                    Caractéristique = 10 - Caractéristique

            End Select

            'Calcul du repas
            Repas = Caractéristique * 3

            'Calcul de la caractéristique "Jour(s) restant" avant d'être full.
            Select Case ID_Objet
                Case 6978
                    Caractéristique = 3 * 3 * Caractéristique
                Case 7710, 7414, 8000, 7713, 7706, 8677, 7714, 7703, 7518, 7520, 7708, 7709, 7711, 7712, 7891, 1728, 9623, 7519, 7704, 9617, 7705, 8211,
                     7892, 8561, 7911, 7524, 7522
                    Caractéristique = 5 * 3 * Caractéristique
                Case 7415, 2074, 2075, 2076, 2077
                    Caractéristique = 11 * 3 * Caractéristique
                Case 1748, 6716
                    Caractéristique = 24 * 3 * Caractéristique
            End Select

        End If

        Return "Jour(s) : " & If(Caractéristique > 0, Caractéristique / 24 / 1.3, "0") & vbCrLf & "Repas Total Nécessaire : " & Repas

    End Function


End Module
