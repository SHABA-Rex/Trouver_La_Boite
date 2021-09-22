Public Class Form1
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        compteur += 1
        enlevonsUneValeur = valeurAleatoire.Next(5, 8) '(2,6) si tu veux diniminuer la vitesse des boites tu diminue cette intervalle

        'On va afficher l'etoile à un moment donnée sur la boite choisie et on va aussi enlever une valeur pour augmenter la vitesse des boites ou les diminuer
        If (compteur = onAffichLacroixApartirDe) Then
            Select Case choisirLaBoite
                Case 1
                    GN_Btn1.Text = leCaractereaAfficher
                Case 2
                    Gn_Btn2.Text = leCaractereaAfficher
                Case 3
                    GN_Btn3.Text = leCaractereaAfficher
                Case 4
                    GN_Btn4.Text = leCaractereaAfficher
                Case 5
                    GN_Btn5.Text = leCaractereaAfficher
                Case 6
                    GN_Btn6.Text = leCaractereaAfficher
            End Select
        End If

        If (compteur = onArreteDafficherLacroixA) Then
            Select Case choisirLaBoite
                Case 1
                    GN_Btn1.Text = ""
                Case 2
                    Gn_Btn2.Text = ""
                Case 3
                    GN_Btn3.Text = ""
                Case 4
                    GN_Btn4.Text = ""
                Case 5
                    GN_Btn5.Text = ""
                Case 6
                    GN_Btn6.Text = ""
            End Select
        End If

        '=======================================================================
        'Mouvement du Premier Boutton
        '=======================================================================
        Select Case etape
            Case "a"
                positionDeLaBoite.X = positionDeLaBoite.X - enlevonsUneValeur '1
                positionDeLaBoite.Y = positionDeLaBoite.Y - enlevonsUneValeur '2
            Case "b"
                positionDeLaBoite.X = positionDeLaBoite.X - enlevonsUneValeur '1
                positionDeLaBoite.Y = positionDeLaBoite.Y + enlevonsUneValeur '2
            Case "c"
                positionDeLaBoite.X = positionDeLaBoite.X + enlevonsUneValeur '1
                positionDeLaBoite.Y = positionDeLaBoite.Y + enlevonsUneValeur '1
            Case "d"
                positionDeLaBoite.X = positionDeLaBoite.X + enlevonsUneValeur '1
                positionDeLaBoite.Y = positionDeLaBoite.Y - enlevonsUneValeur '1
            Case "e"
                positionDeLaBoite.X = positionDeLaBoite.X - enlevonsUneValeur '1
                positionDeLaBoite.Y = positionDeLaBoite.Y + enlevonsUneValeur '1
            Case "f"
                positionDeLaBoite.X = positionDeLaBoite.X - enlevonsUneValeur '1
                positionDeLaBoite.Y = positionDeLaBoite.Y - enlevonsUneValeur '1
            Case "g"
                positionDeLaBoite.X = positionDeLaBoite.X + enlevonsUneValeur '1
                positionDeLaBoite.Y = positionDeLaBoite.Y - enlevonsUneValeur '2
            Case "h"
                positionDeLaBoite.X = positionDeLaBoite.X + enlevonsUneValeur '1
                positionDeLaBoite.Y = positionDeLaBoite.Y + enlevonsUneValeur '2
        End Select

        If (positionDeLaBoite.Y <= lesLimitesaPasDepasser(0)) Then
            If (etape = "a" Or etape = "f") Then
                etape = "b"
            Else
                etape = "h"
            End If
        ElseIf (positionDeLaBoite.X <= lesLimitesaPasDepasser(1))
            If (etape = "b" Or etape = "e") Then
                etape = "c"
            Else
                etape = "g"
            End If
        ElseIf (positionDeLaBoite.Y >= lesLimitesaPasDepasser(3))
            If (etape = "c" Or etape = "h") Then
                etape = "d"
            Else
                etape = "f"
            End If
        ElseIf (positionDeLaBoite.X >= lesLimitesaPasDepasser(2)) Then
            If (etape = "d" Or etape = "g") Then
                etape = "a"
            Else
                etape = "e"
            End If
        End If

        GN_Btn1.Location = positionDeLaBoite
        'Label1.Text = "Etape de la boite : " & etape

        '=======================================================================
        'Mouvement du Deuxieme Boutton
        '=======================================================================
        Select Case etapeBtn2
            Case "a"
                positionDeLaBoite2.X = positionDeLaBoite2.X - enlevonsUneValeur '1
                positionDeLaBoite2.Y = positionDeLaBoite2.Y - enlevonsUneValeur '2
            Case "b"
                positionDeLaBoite2.X = positionDeLaBoite2.X - enlevonsUneValeur '1
                positionDeLaBoite2.Y = positionDeLaBoite2.Y + enlevonsUneValeur '2
            Case "c"
                positionDeLaBoite2.X = positionDeLaBoite2.X + enlevonsUneValeur '1
                positionDeLaBoite2.Y = positionDeLaBoite2.Y + enlevonsUneValeur '1
            Case "d"
                positionDeLaBoite2.X = positionDeLaBoite2.X + enlevonsUneValeur '1
                positionDeLaBoite2.Y = positionDeLaBoite2.Y - enlevonsUneValeur '1
            Case "e"
                positionDeLaBoite2.X = positionDeLaBoite2.X - enlevonsUneValeur '1
                positionDeLaBoite2.Y = positionDeLaBoite2.Y + enlevonsUneValeur '1
            Case "f"
                positionDeLaBoite2.X = positionDeLaBoite2.X - enlevonsUneValeur '1
                positionDeLaBoite2.Y = positionDeLaBoite2.Y - enlevonsUneValeur '1
            Case "g"
                positionDeLaBoite2.X = positionDeLaBoite2.X + enlevonsUneValeur '1
                positionDeLaBoite2.Y = positionDeLaBoite2.Y - enlevonsUneValeur '2
            Case "h"
                positionDeLaBoite2.X = positionDeLaBoite2.X + enlevonsUneValeur '1
                positionDeLaBoite2.Y = positionDeLaBoite2.Y + enlevonsUneValeur '2
        End Select

        If (positionDeLaBoite2.Y <= lesLimitesaPasDepasser(0)) Then
            If (etapeBtn2 = "a" Or etapeBtn2 = "f") Then
                etapeBtn2 = "b"
            Else
                etapeBtn2 = "h"
            End If
        ElseIf (positionDeLaBoite2.X <= lesLimitesaPasDepasser(1))
            If (etapeBtn2 = "b" Or etapeBtn2 = "e") Then
                etapeBtn2 = "c"
            Else
                etapeBtn2 = "g"
            End If
        ElseIf (positionDeLaBoite2.Y >= lesLimitesaPasDepasser(3))
            If (etapeBtn2 = "c" Or etapeBtn2 = "h") Then
                etapeBtn2 = "d"
            Else
                etapeBtn2 = "f"
            End If
        ElseIf (positionDeLaBoite2.X >= lesLimitesaPasDepasser(2)) Then
            If (etapeBtn2 = "d" Or etapeBtn2 = "g") Then
                etapeBtn2 = "a"
            Else
                etapeBtn2 = "e"
            End If
        End If


        Gn_Btn2.Location = positionDeLaBoite2
        'Label2.Text = "Etape de la boite : " & etapeBtn2 Si tu veux faire des test cree d'abord ca
        'porte un label et met le dans le formulaire parceque ça n'existe pas encore

        '========================================================================
        'Mouvement du Troisième Boutton
        '========================================================================
        Select Case etapeBtn3
            Case "a"
                positionDeLaBoite3.X = positionDeLaBoite3.X - enlevonsUneValeur '1
                positionDeLaBoite3.Y = positionDeLaBoite3.Y - enlevonsUneValeur '2
            Case "b"
                positionDeLaBoite3.X = positionDeLaBoite3.X - enlevonsUneValeur '1
                positionDeLaBoite3.Y = positionDeLaBoite3.Y + enlevonsUneValeur '2
            Case "c"
                positionDeLaBoite3.X = positionDeLaBoite3.X + enlevonsUneValeur '1
                positionDeLaBoite3.Y = positionDeLaBoite3.Y + enlevonsUneValeur '1
            Case "d"
                positionDeLaBoite3.X = positionDeLaBoite3.X + enlevonsUneValeur '1
                positionDeLaBoite3.Y = positionDeLaBoite3.Y - enlevonsUneValeur '1
            Case "e"
                positionDeLaBoite3.X = positionDeLaBoite3.X - enlevonsUneValeur '1
                positionDeLaBoite3.Y = positionDeLaBoite3.Y + enlevonsUneValeur '1
            Case "f"
                positionDeLaBoite3.X = positionDeLaBoite3.X - enlevonsUneValeur '1
                positionDeLaBoite3.Y = positionDeLaBoite3.Y - enlevonsUneValeur '1
            Case "g"
                positionDeLaBoite3.X = positionDeLaBoite3.X + enlevonsUneValeur '1
                positionDeLaBoite3.Y = positionDeLaBoite3.Y - enlevonsUneValeur '2
            Case "h"
                positionDeLaBoite3.X = positionDeLaBoite3.X + enlevonsUneValeur '1
                positionDeLaBoite3.Y = positionDeLaBoite3.Y + enlevonsUneValeur '2
        End Select


        If (positionDeLaBoite3.Y <= lesLimitesaPasDepasser(0)) Then
            If (etapeBtn3 = "a" Or etapeBtn3 = "f") Then
                etapeBtn3 = "b"
            Else
                etapeBtn3 = "h"
            End If
        ElseIf (positionDeLaBoite3.X <= lesLimitesaPasDepasser(1))
            If (etapeBtn3 = "b" Or etapeBtn3 = "e") Then
                etapeBtn3 = "c"
            Else
                etapeBtn3 = "g"
            End If
        ElseIf (positionDeLaBoite3.Y >= lesLimitesaPasDepasser(3))
            If (etapeBtn3 = "c" Or etapeBtn3 = "h") Then
                etapeBtn3 = "d"
            Else
                etapeBtn3 = "f"
            End If
        ElseIf (positionDeLaBoite3.X >= lesLimitesaPasDepasser(2)) Then
            If (etapeBtn3 = "d" Or etapeBtn3 = "g") Then
                etapeBtn3 = "a"
            Else
                etapeBtn3 = "e"
            End If
        End If
        GN_Btn3.Location = positionDeLaBoite3

        '===============================================================
        'Mouvement du quatrième Boutton
        '===============================================================


        Select Case etapeBtn4
            Case "a"
                positionDeLaBoite4.X = positionDeLaBoite4.X - enlevonsUneValeur '1
                positionDeLaBoite4.Y = positionDeLaBoite4.Y - enlevonsUneValeur '2
            Case "b"
                positionDeLaBoite4.X = positionDeLaBoite4.X - enlevonsUneValeur '1
                positionDeLaBoite4.Y = positionDeLaBoite4.Y + enlevonsUneValeur '2
            Case "c"
                positionDeLaBoite4.X = positionDeLaBoite4.X + enlevonsUneValeur '1
                positionDeLaBoite4.Y = positionDeLaBoite4.Y + enlevonsUneValeur '1
            Case "d"
                positionDeLaBoite4.X = positionDeLaBoite4.X + enlevonsUneValeur '1
                positionDeLaBoite4.Y = positionDeLaBoite4.Y - enlevonsUneValeur '1
            Case "e"
                positionDeLaBoite4.X = positionDeLaBoite4.X - enlevonsUneValeur '1
                positionDeLaBoite4.Y = positionDeLaBoite4.Y + enlevonsUneValeur '1
            Case "f"
                positionDeLaBoite4.X = positionDeLaBoite4.X - enlevonsUneValeur '1
                positionDeLaBoite4.Y = positionDeLaBoite4.Y - enlevonsUneValeur '1
            Case "g"
                positionDeLaBoite4.X = positionDeLaBoite4.X + enlevonsUneValeur '1
                positionDeLaBoite4.Y = positionDeLaBoite4.Y - enlevonsUneValeur '2
            Case "h"
                positionDeLaBoite4.X = positionDeLaBoite4.X + enlevonsUneValeur '1
                positionDeLaBoite4.Y = positionDeLaBoite4.Y + enlevonsUneValeur '2
        End Select



        If (positionDeLaBoite4.Y <= lesLimitesaPasDepasser(0)) Then
            If (etapeBtn4 = "a" Or etapeBtn4 = "f") Then
                etapeBtn4 = "b"
            Else
                etapeBtn4 = "h"
            End If
        ElseIf (positionDeLaBoite4.X <= lesLimitesaPasDepasser(1))
            If (etapeBtn4 = "b" Or etapeBtn4 = "e") Then
                etapeBtn4 = "c"
            Else
                etapeBtn4 = "g"
            End If
        ElseIf (positionDeLaBoite4.Y >= lesLimitesaPasDepasser(3))
            If (etapeBtn4 = "c" Or etapeBtn4 = "h") Then
                etapeBtn4 = "d"
            Else
                etapeBtn4 = "f"
            End If
        ElseIf (positionDeLaBoite4.X >= lesLimitesaPasDepasser(2)) Then
            If (etapeBtn4 = "d" Or etapeBtn4 = "g") Then
                etapeBtn4 = "a"
            Else
                etapeBtn4 = "e"
            End If
        End If

        GN_Btn4.Location = positionDeLaBoite4

        '===============================================================
        'Mouvement du cinquième Boutton
        '===============================================================
        Select Case etapeBtn5
            Case "a"
                positionDeLaBoite5.X = positionDeLaBoite5.X - enlevonsUneValeur '1
                positionDeLaBoite5.Y = positionDeLaBoite5.Y - enlevonsUneValeur '2
            Case "b"
                positionDeLaBoite5.X = positionDeLaBoite5.X - enlevonsUneValeur '1
                positionDeLaBoite5.Y = positionDeLaBoite5.Y + enlevonsUneValeur '2
            Case "c"
                positionDeLaBoite5.X = positionDeLaBoite5.X + enlevonsUneValeur '1
                positionDeLaBoite5.Y = positionDeLaBoite5.Y + enlevonsUneValeur '1
            Case "d"
                positionDeLaBoite5.X = positionDeLaBoite5.X + enlevonsUneValeur '1
                positionDeLaBoite5.Y = positionDeLaBoite5.Y - enlevonsUneValeur '1
            Case "e"
                positionDeLaBoite5.X = positionDeLaBoite5.X - enlevonsUneValeur '1
                positionDeLaBoite5.Y = positionDeLaBoite5.Y + enlevonsUneValeur '1
            Case "f"
                positionDeLaBoite5.X = positionDeLaBoite5.X - enlevonsUneValeur '1
                positionDeLaBoite5.Y = positionDeLaBoite5.Y - enlevonsUneValeur '1
            Case "g"
                positionDeLaBoite5.X = positionDeLaBoite5.X + enlevonsUneValeur '1
                positionDeLaBoite5.Y = positionDeLaBoite5.Y - enlevonsUneValeur '2
            Case "h"
                positionDeLaBoite5.X = positionDeLaBoite5.X + enlevonsUneValeur '1
                positionDeLaBoite5.Y = positionDeLaBoite5.Y + enlevonsUneValeur '2
        End Select


        If (positionDeLaBoite5.Y <= lesLimitesaPasDepasser(0)) Then
            If (etapeBtn5 = "a" Or etapeBtn5 = "f") Then
                etapeBtn5 = "b"
            Else
                etapeBtn5 = "h"
            End If
        ElseIf (positionDeLaBoite5.X <= lesLimitesaPasDepasser(1))
            If (etapeBtn5 = "b" Or etapeBtn5 = "e") Then
                etapeBtn5 = "c"
            Else
                etapeBtn5 = "g"
            End If
        ElseIf (positionDeLaBoite5.Y >= lesLimitesaPasDepasser(3))
            If (etapeBtn5 = "c" Or etapeBtn5 = "h") Then
                etapeBtn5 = "d"
            Else
                etapeBtn5 = "f"
            End If
        ElseIf (positionDeLaBoite5.X >= lesLimitesaPasDepasser(2)) Then
            If (etapeBtn5 = "d" Or etapeBtn5 = "g") Then
                etapeBtn5 = "a"
            Else
                etapeBtn5 = "e"
            End If
        End If

        GN_Btn5.Location = positionDeLaBoite5

        '===============================================================
        'Mouvement du Sixième Boutton
        '===============================================================
        Select Case etapeBtn6
            Case "a"
                positionDeLaBoite6.X = positionDeLaBoite6.X - enlevonsUneValeur '1
                positionDeLaBoite6.Y = positionDeLaBoite6.Y - enlevonsUneValeur '2
            Case "b"
                positionDeLaBoite6.X = positionDeLaBoite6.X - enlevonsUneValeur '1
                positionDeLaBoite6.Y = positionDeLaBoite6.Y + enlevonsUneValeur '2
            Case "c"
                positionDeLaBoite6.X = positionDeLaBoite6.X + enlevonsUneValeur '1
                positionDeLaBoite6.Y = positionDeLaBoite6.Y + enlevonsUneValeur '1
            Case "d"
                positionDeLaBoite6.X = positionDeLaBoite6.X + enlevonsUneValeur '1
                positionDeLaBoite6.Y = positionDeLaBoite6.Y - enlevonsUneValeur '1
            Case "e"
                positionDeLaBoite6.X = positionDeLaBoite6.X - enlevonsUneValeur '1
                positionDeLaBoite6.Y = positionDeLaBoite6.Y + enlevonsUneValeur '1
            Case "f"
                positionDeLaBoite6.X = positionDeLaBoite6.X - enlevonsUneValeur '1
                positionDeLaBoite6.Y = positionDeLaBoite6.Y - enlevonsUneValeur '1
            Case "g"
                positionDeLaBoite6.X = positionDeLaBoite6.X + enlevonsUneValeur '1
                positionDeLaBoite6.Y = positionDeLaBoite6.Y - enlevonsUneValeur '2
            Case "h"
                positionDeLaBoite6.X = positionDeLaBoite6.X + enlevonsUneValeur '1
                positionDeLaBoite6.Y = positionDeLaBoite6.Y + enlevonsUneValeur '2
        End Select

        If (positionDeLaBoite6.Y <= lesLimitesaPasDepasser(0)) Then
            If (etapeBtn6 = "a" Or etapeBtn6 = "f") Then
                etapeBtn6 = "b"
            Else
                etapeBtn6 = "h"
            End If
        ElseIf (positionDeLaBoite6.X <= lesLimitesaPasDepasser(1))
            If (etapeBtn6 = "b" Or etapeBtn6 = "e") Then
                etapeBtn6 = "c"
            Else
                etapeBtn6 = "g"
            End If
        ElseIf (positionDeLaBoite6.Y >= lesLimitesaPasDepasser(3))
            If (etapeBtn6 = "c" Or etapeBtn6 = "h") Then
                etapeBtn6 = "d"
            Else
                etapeBtn6 = "f"
            End If
        ElseIf (positionDeLaBoite6.X >= lesLimitesaPasDepasser(2)) Then
            If (etapeBtn6 = "d" Or etapeBtn6 = "g") Then
                etapeBtn6 = "a"
            Else
                etapeBtn6 = "e"
            End If
        End If

        GN_Btn6.Location = positionDeLaBoite6
        '===============================================================
        'Mouvement du Septième Boutton
        '===============================================================
        'Select Case etapeBtn7
        '    Case "a"
        '        positionDeLaBoite7.X = positionDeLaBoite7.X - 1
        '        positionDeLaBoite7.X = positionDeLaBoite7.Y - 2
        '    Case "b"
        '        positionDeLaBoite7.X = positionDeLaBoite7.X - 1
        '        positionDeLaBoite7.Y = positionDeLaBoite7.Y + 2
        '    Case "c"
        '        positionDeLaBoite7.X = positionDeLaBoite7.X + 1
        '        positionDeLaBoite7.Y = positionDeLaBoite7.Y + 1
        '    Case "d"
        '        positionDeLaBoite7.X = positionDeLaBoite7.X + 1
        '        positionDeLaBoite7.Y = positionDeLaBoite7.Y - 1
        '    Case "e"
        '        positionDeLaBoite7.X = positionDeLaBoite7.X - 1
        '        positionDeLaBoite7.Y = positionDeLaBoite7.Y + 1
        '    Case "f"
        '        positionDeLaBoite7.X = positionDeLaBoite7.X - 1
        '        positionDeLaBoite7.Y = positionDeLaBoite7.Y - 1
        '    Case "g"
        '        positionDeLaBoite7.X = positionDeLaBoite7.X + 1
        '        positionDeLaBoite7.Y = positionDeLaBoite7.Y - 2
        '    Case "h"
        '        positionDeLaBoite7.X = positionDeLaBoite7.X + 1
        '        positionDeLaBoite7.Y = positionDeLaBoite7.Y + 2
        'End Select

        'If (positionDeLaBoite6.Y <= lesLimitesaPasDepasser(0)) Then
        '    If (etapeBtn6 = "a" Or etapeBtn6 = "f") Then
        '        etapeBtn6 = "b"
        '    Else
        '        etapeBtn6 = "h"
        '    End If
        'ElseIf (positionDeLaBoite6.X <= lesLimitesaPasDepasser(1))
        '    If (etapeBtn6 = "b" Or etapeBtn6 = "e") Then
        '        etapeBtn6 = "c"
        '    Else
        '        etapeBtn6 = "g"
        '    End If
        'ElseIf (positionDeLaBoite6.Y >= lesLimitesaPasDepasser(3))
        '    If (etapeBtn6 = "c" Or etapeBtn6 = "h") Then
        '        etapeBtn6 = "d"
        '    Else
        '        etapeBtn6 = "f"
        '    End If
        'ElseIf (positionDeLaBoite6.X >= lesLimitesaPasDepasser(2)) Then
        '    If (etapeBtn6 = "d" Or etapeBtn6 = "g") Then
        '        etapeBtn6 = "a"
        '    Else
        '        etapeBtn6 = "e"
        '    End If
        'End If

        'GN_Btn6.Location = positionDeLaBoite6

        If (compteur = lesBoitesArreteDeBougerA) Then
            compteur = 0
            GN_Btn1.Enabled = True
            Gn_Btn2.Enabled = True
            GN_Btn3.Enabled = True
            GN_Btn4.Enabled = True
            GN_Btn5.Enabled = True
            GN_Btn6.Enabled = True
            Timer1.Stop()
        End If

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '488,510
        'Label1.Hide()
        'Label2.Hide()
        afficherLePanneauDeScore(GroupBox0)
        Dim lesBoites As New List(Of Guna.UI.WinForms.GunaButton) From {GN_Btn1, Gn_Btn2, GN_Btn3, GN_Btn4, GN_Btn5, GN_Btn6}
        DisposerLesBoites(lesBoites)
        choisirLacouleurDesBoites()
        GroupBox0.Hide()
        choisirLaBoite = valeurAleatoire.Next(1, 6)
        GN_Btn1.Text = ""
        Gn_Btn2.Text = ""
        GN_Btn3.Text = ""
        GN_Btn4.Text = ""
        GN_Btn5.Text = ""
        GN_Btn6.Text = ""

        etape = "a"
        etapeBtn2 = "a"
        etapeBtn3 = "a"
        etapeBtn4 = "a"
        etapeBtn5 = "a"
        etapeBtn6 = "a"
        nbDeFausseReponse = 0
        positionDeLaBoite.X = GN_Btn1.Location.X
        positionDeLaBoite.Y = GN_Btn1.Location.Y

        positionDeLaBoite2.X = Gn_Btn2.Location.X
        positionDeLaBoite2.Y = Gn_Btn2.Location.Y

        positionDeLaBoite3.X = GN_Btn3.Location.X
        positionDeLaBoite3.Y = GN_Btn3.Location.Y

        positionDeLaBoite4.X = GN_Btn4.Location.X
        positionDeLaBoite4.Y = GN_Btn4.Location.Y

        positionDeLaBoite5.X = GN_Btn5.Location.X
        positionDeLaBoite5.Y = GN_Btn5.Location.Y

        positionDeLaBoite6.X = GN_Btn6.Location.X
        positionDeLaBoite6.Y = GN_Btn6.Location.Y

        Timer1.Start()
    End Sub
    Private Sub GN_Btn1_Click(sender As Object, e As EventArgs) Handles GN_Btn1.Click
        mettreAJourleScore(1, valeurDuScore)
    End Sub
    Private Sub Gn_Btn2_Click(sender As Object, e As EventArgs) Handles Gn_Btn2.Click
        mettreAJourleScore(2, valeurDuScore)
        'If choisirLaBoite = 2 Then
        '    mesPoints += 1
        '    valeurDuScore.Text = mesPoints
        '    GroupBox0.Show()
        'End If
    End Sub

    Private Sub GN_Btn3_Click(sender As Object, e As EventArgs) Handles GN_Btn3.Click
        mettreAJourleScore(3, valeurDuScore)
        'If choisirLaBoite = 3 Then
        '    mesPoints += 1
        '    valeurDuScore.Text = mesPoints
        '    GroupBox0.Show()
        'End If
    End Sub

    Private Sub GN_Btn4_Click(sender As Object, e As EventArgs) Handles GN_Btn4.Click
        mettreAJourleScore(4, valeurDuScore)
        'If choisirLaBoite = 4 Then
        '    mesPoints += 1
        '    valeurDuScore.Text = mesPoints
        '    GroupBox0.Show()
        'End If
    End Sub

    Private Sub GN_Btn5_Click(sender As Object, e As EventArgs) Handles GN_Btn5.Click
        mettreAJourleScore(5, valeurDuScore)
        'If choisirLaBoite = 5 Then
        '    mesPoints += 1
        '    valeurDuScore.Text = mesPoints
        '    GroupBox0.Show()
        'Else
        '    nbDeFausseReponse += 1
        'End If
        'If (nbDeFausseReponse = 2) Then
        '    valeurDuScore.Text = mesPoints - 1
        'End If
    End Sub

    Private Sub GN_Btn6_Click(sender As Object, e As EventArgs) Handles GN_Btn6.Click
        mettreAJourleScore(6, valeurDuScore)
        'If choisirLaBoite = 6 Then
        '    mesPoints += 1
        '    valeurDuScore.Text = mesPoints
        '    GroupBox0.Show()
        'End If
    End Sub




    Private Sub Gn_BtnContinuer_Click_1(sender As Object, e As EventArgs) Handles Gn_BtnContinuer.Click
        Dim lesBoites As New List(Of Guna.UI.WinForms.GunaButton) From {GN_Btn1, Gn_Btn2, GN_Btn3, GN_Btn4, GN_Btn5, GN_Btn6}
        DisposerLesBoites(lesBoites)
        choisirLacouleurDesBoites()
        'On desactive les bouttons pour que pendant qu'il sont entrain de bouger, on ne puisse pas clicker dessus .
        GN_Btn1.Enabled = False
        Gn_Btn2.Enabled = False
        GN_Btn3.Enabled = False
        GN_Btn4.Enabled = False
        GN_Btn5.Enabled = False
        GN_Btn6.Enabled = False

        pointQuelquonque.X = 2
        pointQuelquonque.Y = 510
        nbDeFausseReponse = 0
        positionDeLaBoite.X = GN_Btn1.Location.X
        positionDeLaBoite.Y = GN_Btn1.Location.Y

        positionDeLaBoite2.X = Gn_Btn2.Location.X
        positionDeLaBoite2.Y = Gn_Btn2.Location.Y

        positionDeLaBoite3.X = GN_Btn3.Location.X
        positionDeLaBoite3.Y = GN_Btn3.Location.Y

        positionDeLaBoite4.X = GN_Btn4.Location.X
        positionDeLaBoite4.Y = GN_Btn4.Location.Y

        positionDeLaBoite5.X = GN_Btn5.Location.X
        positionDeLaBoite5.Y = GN_Btn5.Location.Y

        positionDeLaBoite6.X = GN_Btn6.Location.X
        positionDeLaBoite6.Y = GN_Btn6.Location.Y

        compteur = 0
        GroupBox0.Hide()
        Timer1.Start()
    End Sub


    Public Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        'Ici on veut que le panneau qui contient les scores puissent sortir
        'progressivement et lentement en montant à partir du bas.
        If (pointQuelquonque.Y >= lordonneeApasDePasser And nbDeFausseReponse = 2) Then
            pointQuelquonque.Y -= 12
            'Label3.Text = "Pt_quelquonque : " & pointQuelquonque.Y
            GroupBox0.Location = pointQuelquonque
            GroupBox0.Show()
        End If

        If (pointQuelquonque.Y >= lordonneeApasDePasser And nbDeFausseReponse = -1) Then
            pointQuelquonque.Y -= 12
            'Label3.Text = "Pt_quelquonque : " & pointQuelquonque.Y
            GroupBox0.Location = pointQuelquonque
            GroupBox0.Show()
        End If

        If (pointQuelquonque.Y <= lordonneeApasDePasser) Then
            Timer2.Stop()
        End If

    End Sub

    Private Sub Gn_BtnQuitter_Click(sender As Object, e As EventArgs) Handles Gn_BtnQuitter.Click
        Me.Dispose()
    End Sub
End Class
