Module Statut_Information

    Public Sub Statut_Information_Peronnage_Autorisation(ByVal Index As Integer, ByVal Autorisation As Integer)

        With Comptes(Index)

            '   Dim Valeur() As Integer = {16384, 8192, 4096, 512, 256, 128, 64, 32, 16, 8, 4, 2}

            Select Case Autorisation

                Case 8192 'Normal

                    ._Autorisation_Défi = True
                    ._Autorisation_Echange = True
                    ._Autorisation_Interraction = True
                    ._Autorisation_Attaquer_Mobs = True
                    ._Autorisation_Agression = True

                    ._Fantôme = False

                Case 10983 'Fantôme

                    ._Autorisation_Défi = False
                    ._Autorisation_Echange = False
                    ._Autorisation_Interraction = False
                    ._Autorisation_Attaquer_Mobs = False
                    ._Autorisation_Agression = False

                    ._Fantôme = True

                Case Else

            End Select

        End With

    End Sub

End Module
