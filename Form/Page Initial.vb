Public Class Page_Initial

    Public Index As Integer

    Private Sub Toggle_Connexion_CheckedChanged(sender As Object) Handles Toggle_Connexion.CheckedChanged

        Select Case Toggle_Connexion.Checked

            Case True

                Connexion_Déconnexion_Joueur(Index, "Connexion")

            Case False

                Connexion_Déconnexion_Joueur(Index, "Déconnexion")

        End Select

    End Sub


End Class
