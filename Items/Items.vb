Module Items

    Public Sub Items_Ajoute_FlowLayout(ByVal Index As Integer, ByVal Information() As String, ByVal Flow_Panel As FlowLayoutPanel)

        With Comptes(Index)

            If Information(0) <> "" Then

                For i = 0 To Information.Count - 2

                    'a30d2a~1fd6~1~0~7d#63#0#0#0d0+99
                    Dim Separation_Information() As String = Split(Information(i), "~")

                    Separation_Information(1) = Convert.ToInt64(Separation_Information(1), 16)

                    'En cours de changement.

                    With Flow_Panel



                        Dim Picture_Box As New Picture_Box(Index, Separation_Information(1), Convert.ToInt64(Separation_Information(0), 16), "Caractéristique")



                        With .Rows(.Rows.Count - 1)

                            'Nom
                            .Cells(1).Value = Liste_Des_Objets(Separation_Information(1)).GetValue(1)

                            'ID Objet
                            .Cells(2).Value = Separation_Information(1)

                            'ID Unique
                            .Cells(3).Value = Convert.ToInt64(Separation_Information(0), 16)

                            'Quantité
                            .Cells(4).Value = Convert.ToInt64(Separation_Information(2), 16)

                            'Information
                            .Cells(5).Value = Objet_Caractéristiques(.Cells(2).Value, Separation_Information(4))

                            'S'il s'agit d'un Item équipé sur moi.
                            If Separation_Information(3) <> Nothing Then

                                'Information
                                Equipement_Equipé(Index, Separation_Information(1), .Cells(3).Value, Convert.ToInt64(Separation_Information(3), 16))

                                .DefaultCellStyle.BackColor = Color.Red

                                'Si il s'agit d'un Objet de quête.
                            ElseIf Liste_Des_Objets(Separation_Information(1)).GetValue(3) = 0 Then

                                .DefaultCellStyle.BackColor = Color.Orange

                            End If

                        End With

                    End With

                Next

            End If

        End With

    End Sub

End Module
