Module Affiche_Item

    Public Sub Item_Affiche_Inventaire_Click(ByVal Index As Integer, ByVal Information As String)

        With Comptes(Index)

            ._User.ListView_Inventaire_Affiche_Caractéristique.Items.Clear()

            With ._User

                Dim Separation() As String = Split(Information, "|")

                For i = 0 To Separation.Count - 1

                    Dim Separation_Info() As String = Split(Separation(i), "=")

                    .ListView_Inventaire_Affiche_Caractéristique.Items.Add(Separation_Info(1) & " " & Separation_Info(0), .ImageList_Caractéristique.Images.Keys.IndexOf(Separation_Info(0) & ".png"))

                Next

            End With

        End With

    End Sub

    Public Sub Item_Affiche_Inventaire_Quantité(ByVal Index As Integer, ByVal Quantité As Integer)

        With Comptes(Index)._User

            .Button_Inventaire_Supprimer.Text = Quantité

        End With

    End Sub

End Module
