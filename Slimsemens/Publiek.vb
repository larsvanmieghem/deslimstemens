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
                        r1v1.BackColor = Color.Yellow
                    Case 2
                        r1v1.BackColor = Color.Transparent
                        r1v2.BackColor = Color.Yellow
                    Case 3
                        r1v2.BackColor = Color.Transparent
                        r1v3.BackColor = Color.Yellow
                    Case 4
                        r1v3.BackColor = Color.Transparent
                        r1v4.BackColor = Color.Yellow
                    Case 5
                        r1v4.BackColor = Color.Transparent
                        r1v5.BackColor = Color.Yellow
                    Case 6
                        r1v5.BackColor = Color.Transparent
                        r1v6.BackColor = Color.Yellow
                    Case 7
                        r1v6.BackColor = Color.Transparent
                        r1v7.BackColor = Color.Yellow
                    Case 8
                        r1v7.BackColor = Color.Transparent
                        r1v8.BackColor = Color.Yellow
                    Case 9
                        r1v8.BackColor = Color.Transparent
                        r1v9.BackColor = Color.Yellow
                    Case 10
                        r1v9.BackColor = Color.Transparent
                        r1v10.BackColor = Color.Yellow
                    Case 11
                        r1v10.BackColor = Color.Transparent
                        r1v11.BackColor = Color.Yellow
                    Case 12
                        r1v11.BackColor = Color.Transparent
                        r1v12.BackColor = Color.Yellow
                    Case 13
                        r1v12.BackColor = Color.Transparent
                        r1v13.BackColor = Color.Yellow
                    Case 14
                        r1v13.BackColor = Color.Transparent
                        r1v14.BackColor = Color.Yellow
                    Case 15
                        r1v14.BackColor = Color.Transparent
                        r1v15.BackColor = Color.Yellow
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
                Naam1label.BackColor = Color.Yellow
                Naam2label.BackColor = Color.Transparent
                Naam3label.BackColor = Color.Transparent
            Case Controle.aandebeurtenum.Platypus
                Naam1label.BackColor = Color.Transparent
                Naam2label.BackColor = Color.Yellow
                Naam3label.BackColor = Color.Transparent
            Case Controle.aandebeurtenum.Miauw
                Naam1label.BackColor = Color.Transparent
                Naam2label.BackColor = Color.Transparent
                Naam3label.BackColor = Color.Yellow
        End Select
    End Sub
    
   
End Class