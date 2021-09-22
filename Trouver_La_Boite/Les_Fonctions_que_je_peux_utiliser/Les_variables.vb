
Module Les_variables
    Public labssicepasDePasser As Integer = 2
    Public lordonneeApasDePasser As Integer = 320 '- 15 width -40 sur Height  
    Public lesLimitesaPasDepasser() As Integer = {0, 0, Form1.Size.Width - Form1.GN_Btn1.Size.Width, Form1.Size.Height - Form1.GN_Btn1.Size.Height} 'sur Axe des ordonnees , sur Axe des abscisses , sur axe des ordonnees (hauteur), sur axe des abscisses (largeur)
    Public compteur As Integer = 0
    Public enlevonsUneValeur, nbDeFausseReponse As Integer
    Public choisirLaBoite As Integer = 0
    Public choisirLaCouleur As Integer
    Public mesPoints As Integer = 0
    Public compteur2 As Integer = 0
    Public onAffichLacroixApartirDe As Integer = 300
    Public onArreteDafficherLacroixA As Integer = 330 'Doit etre superieure à 400
    'On pourrait faire quelque chose sur onArreteDafficherLacroixA , faire un random sur cette valeur pour augmenter ou diminuer la difficulté par rapport à l'affichage de la croix un peu comme ça onAfficheLaCroixA=valeurAleatoire.Next(310,350) et ceci par rapport au score plus le score est grand plus on augmente la difficulté
    Public lesBoitesArreteDeBougerA As Integer = 900
    Public etape, etapeBtn2, etapeBtn3, etapeBtn4, etapeBtn5, etapeBtn6, etapeBtn7, etapeBtn8, etapeBtn9, etapeBtn10 As Char
    Public boite1, boite2, boite3, boite4, boite5, boite6, boite7, boite8, boite9, boite10 As Point
    Public pointQuelquonque As Point
    Public positionDeLaBoite As Point
    Public positionDeLaBoite2 As Point
    Public positionDeLaBoite3 As Point
    Public positionDeLaBoite4 As Point
    Public positionDeLaBoite5 As Point
    Public positionDeLaBoite6 As Point
    Public positionDeLaBoite7 As Point
    Public positionDeLaBoite8 As Point
    Public positionDeLaBoite9 As Point
    Public positionDeLaBoite10 As Point
    Public valeurAleatoire As Random = New Random()
    Public leCaractereaAfficher As Char = "X"

    Public Class Boite
        Private numero As Integer
        Private position As Point

        Public Property Numero1 As Integer
            Get
                Return numero
            End Get
            Set(value As Integer)
                numero = value
            End Set
        End Property

        Public Property Position1 As Point
            Get
                Return position
            End Get
            Set(value As Point)
                position = value
            End Set
        End Property
        Sub New(numero, positionX, positionY)
            Me.numero = numero
            position.X = positionX
            position.Y = positionY
        End Sub

    End Class
End Module
