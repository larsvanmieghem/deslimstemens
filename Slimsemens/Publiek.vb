Public Class Publiek

    Public Sub initieer()
        'Past de weergegeven namen aan aan die van het bestand
        Naam1label.Text = Controle.jan.Naam
        Naam2label.Text = Controle.platypus.Naam
        Naam3label.Text = Controle.miauw.Naam

        'Past de weergegeven seconden aan aan die van de objecten bij begin programma
        Label1.Text = Controle.jan.Seconden.ToString
        Label2.Text = Controle.platypus.Seconden.ToString
        Label3.Text = Controle.miauw.Seconden.ToString

    End Sub

    Public Sub synchroniseer()
        Label1.Text = Controle.jan.Seconden.ToString
        Label2.Text = Controle.platypus.Seconden.ToString
        Label3.Text = Controle.miauw.Seconden.ToString

        'Toont de juiste elementen afhankelijk van de ronde
        Select Case Controle.actieveronde
            Case Controle.actieverondeenum.driezesnegen
                GroupBox2.Visible = True
                'Geeft aan wat de actieve vraag is
                Select Case Controle.ronde1actievevraag
                    Case 1
                        r1v1.ForeColor = Color.Gold
                    Case 2
                        r1v1.ForeColor = Color.White
                        r1v2.ForeColor = Color.Gold
                    Case 3
                        r1v2.ForeColor = Color.White
                        r1v3.ForeColor = Color.Gold
                    Case 4
                        r1v3.ForeColor = Color.White
                        r1v4.ForeColor = Color.Gold
                    Case 5
                        r1v4.ForeColor = Color.White
                        r1v5.ForeColor = Color.Gold
                    Case 6
                        r1v5.ForeColor = Color.White
                        r1v6.ForeColor = Color.Gold
                    Case 7
                        r1v6.ForeColor = Color.White
                        r1v7.ForeColor = Color.Gold
                    Case 8
                        r1v7.ForeColor = Color.White
                        r1v8.ForeColor = Color.Gold
                    Case 9
                        r1v8.ForeColor = Color.White
                        r1v9.ForeColor = Color.Gold
                    Case 10
                        r1v9.ForeColor = Color.White
                        r1v10.ForeColor = Color.Gold
                    Case 11
                        r1v10.ForeColor = Color.White
                        r1v11.ForeColor = Color.Gold
                    Case 12
                        r1v11.ForeColor = Color.White
                        r1v12.ForeColor = Color.Gold
                    Case 13
                        r1v12.ForeColor = Color.White
                        r1v13.ForeColor = Color.Gold
                    Case 14
                        r1v13.ForeColor = Color.White
                        r1v14.ForeColor = Color.Gold
                    Case 15
                        r1v14.ForeColor = Color.White
                        r1v15.ForeColor = Color.Gold
                End Select







            Case Controle.actieverondeenum.Opendeur
                GroupBox2.Visible = False
            Case Controle.actieverondeenum.Puzzel
                GroupBox2.Visible = False
            Case Controle.actieverondeenum.Galerij
                GroupBox2.Visible = False
            Case Controle.actieverondeenum.Collectiefgeheugen
                GroupBox2.Visible = False
            Case Controle.actieverondeenum.Finale
                GroupBox2.Visible = False
        End Select
        'Toont wie er aan de beurt is
        Select Case Controle.aandebeurt
            Case Controle.aandebeurtenum.Jan
                Naam1label.ForeColor = Color.Gold
                Naam2label.ForeColor = Color.White
                Naam3label.ForeColor = Color.White
            Case Controle.aandebeurtenum.Platypus
                Naam1label.ForeColor = Color.White
                Naam2label.ForeColor = Color.Gold
                Naam3label.ForeColor = Color.White
            Case Controle.aandebeurtenum.Miauw
                Naam1label.ForeColor = Color.White
                Naam2label.ForeColor = Color.White
                Naam3label.ForeColor = Color.Gold
        End Select
    End Sub
    
   
End Class