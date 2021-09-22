Module Les_Fonctions_que_je_peux_utliser
    Public Sub DisposerLesBoites(ByRef listeDeBoutton As List(Of Guna.UI.WinForms.GunaButton))

        '#Disposition des boites
        'Augmenter les boites a chaque fois que le mauvais choix sera fait.
        'Faire plusieurs choix de dessin.

        Dim choix As Random = New Random()
        Dim choisirDessin As Integer
        Dim voiturePixel As New List(Of Boite) From {New Boite(1, 351, 133), New Boite(2, 236, 227), New Boite(3, 290, 179), New Boite(4, 236, 133), New Boite(5, 290, 73), New Boite(6, 351, 227)}
        Dim laCroix As New List(Of Boite) From {New Boite(1, 382, 87), New Boite(2, 290, 179), New Boite(3, 290, 87), New Boite(4, 203, 87), New Boite(5, 290, 22), New Boite(6, 290, 267)}
        Dim lePanzerTank As New List(Of Boite) From {New Boite(1, 382, 87), New Boite(2, 203, 178), New Boite(3, 290, 87), New Boite(4, 203, 87), New Boite(5, 290, 22), New Boite(6, 382, 167)}

        Dim leDessinAFaire As New List(Of Boite)
        choisirDessin = choix.Next(1, 3)

        Select Case choisirDessin
            Case 1
                leDessinAFaire = voiturePixel
            Case 2
                leDessinAFaire = laCroix
            Case 3
                leDessinAFaire = lePanzerTank
        End Select

        boite6.X = 351
        boite6.Y = 227

        boite5.X = 290
        boite5.Y = 73

        boite4.X = 236
        boite4.Y = 133

        boite3.X = 290
        boite3.Y = 179

        boite2.X = 236
        boite2.Y = 227

        boite1.X = 351
        boite1.Y = 133
        'Ici on associe les positions des boites créer, aux différents bouttons qui sont dans la fenetre
        For index = 0 To listeDeBoutton.Count() - 1
            For index2 = compteur2 To compteur2 'On fait ceci une seul fois
                listeDeBoutton(index).Location = leDessinAFaire(index2).Position1
            Next
            compteur2 += 1
        Next
        compteur2 = 0


    End Sub
    Public Sub mettreAJourleScore(ByVal numeroDuBoutton As Integer, ByVal labelDuScore As Label)
        'Ici on decide d'augmenter la valeur du score si on clique sur le bon numero de boutton
        'Sinon on augmente le nombre de fausse reponse
        'Lorsqu'on arrive à deux alors on enlève 3 au Score
        If choisirLaBoite = numeroDuBoutton Then
            mesPoints += 10
            labelDuScore.Text = mesPoints
            afficherLePanneauDeScore(Form1.GroupBox0)
            nbDeFausseReponse = -1
            'Form1.GroupBox0.Show()
        Else
            nbDeFausseReponse += 1
            If (nbDeFausseReponse = 2) Then
                mesPoints -= 10
                afficherLePanneauDeScore(Form1.GroupBox0)
                'Form1.GroupBox0.Show()
            End If

        End If
        labelDuScore.Text = mesPoints
    End Sub
    Public Sub afficherLePanneauDeScore(ByRef panneauDesScores As GroupBox)
        pointQuelquonque.X = 2
        pointQuelquonque.Y = 510
        panneauDesScores.Location = pointQuelquonque
        Form1.GN_Btn1.Enabled = False
        Form1.Gn_Btn2.Enabled = False
        Form1.GN_Btn3.Enabled = False
        Form1.GN_Btn4.Enabled = False
        Form1.GN_Btn5.Enabled = False
        Form1.GN_Btn6.Enabled = False
        Form1.Timer2.Start()
    End Sub
    Public Sub choisirLacouleurDesBoites()

        choisirLaCouleur = valeurAleatoire.Next(1, 3)

        Select Case choisirLaCouleur
            Case 1
                Form1.GN_Btn1.BaseColor = Color.Red
                Form1.Gn_Btn2.BaseColor = Color.Red
                Form1.GN_Btn3.BaseColor = Color.Red
                Form1.GN_Btn4.BaseColor = Color.Red
                Form1.GN_Btn5.BaseColor = Color.Red
                Form1.GN_Btn6.BaseColor = Color.Red
                Form1.GN_Btn1.OnHoverBaseColor = Color.IndianRed
                Form1.Gn_Btn2.OnHoverBaseColor = Color.IndianRed
                Form1.GN_Btn3.OnHoverBaseColor = Color.IndianRed
                Form1.GN_Btn4.OnHoverBaseColor = Color.IndianRed
                Form1.GN_Btn5.OnHoverBaseColor = Color.IndianRed
                Form1.GN_Btn6.OnHoverBaseColor = Color.IndianRed
            Case 2
                Form1.GN_Btn1.BaseColor = Color.Green
                Form1.Gn_Btn2.BaseColor = Color.Green
                Form1.GN_Btn3.BaseColor = Color.Green
                Form1.GN_Btn4.BaseColor = Color.Green
                Form1.GN_Btn5.BaseColor = Color.Green
                Form1.GN_Btn6.BaseColor = Color.Green
                Form1.GN_Btn1.OnHoverBaseColor = Color.LightGreen
                Form1.Gn_Btn2.OnHoverBaseColor = Color.LightGreen
                Form1.GN_Btn3.OnHoverBaseColor = Color.LightGreen
                Form1.GN_Btn4.OnHoverBaseColor = Color.LightGreen
                Form1.GN_Btn5.OnHoverBaseColor = Color.LightGreen
                Form1.GN_Btn6.OnHoverBaseColor = Color.LightGreen
            Case 3
                Form1.GN_Btn1.BaseColor = Color.Orange
                Form1.Gn_Btn2.BaseColor = Color.Orange
                Form1.GN_Btn3.BaseColor = Color.Orange
                Form1.GN_Btn4.BaseColor = Color.Orange
                Form1.GN_Btn5.BaseColor = Color.Orange
                Form1.GN_Btn6.BaseColor = Color.Orange
                Form1.GN_Btn1.OnHoverBaseColor = Color.OrangeRed
                Form1.Gn_Btn2.OnHoverBaseColor = Color.OrangeRed
                Form1.GN_Btn3.OnHoverBaseColor = Color.OrangeRed
                Form1.GN_Btn4.OnHoverBaseColor = Color.OrangeRed
                Form1.GN_Btn5.OnHoverBaseColor = Color.OrangeRed
                Form1.GN_Btn6.OnHoverBaseColor = Color.OrangeRed
        End Select
    End Sub
End Module
