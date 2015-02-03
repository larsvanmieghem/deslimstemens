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

        If Controle.actieveronde = Controle.actieverondeenum.driezesnegen Then
            ronde1()
        End If
        If Controle.actieveronde = Controle.actieverondeenum.Opendeur Then
            ronde2()
        End If
        If Controle.actieveronde = Controle.actieverondeenum.Puzzel Then
            ronde3()
        End If
        If Controle.actieveronde = Controle.actieverondeenum.Galerij Then
            ronde4()
        End If
        If Controle.actieveronde = Controle.actieverondeenum.Collectiefgeheugen Then
            ronde5()
        End If
        If Controle.actieveronde = Controle.actieverondeenum.Finale Then
            ronde6()
        End If
        'Toont de juiste elementen afhankelijk van de ronde
        algemeen()








    End Sub
    Sub algemeen()
        Label1.Text = Controle.jan.Seconden.ToString
        Label2.Text = Controle.platypus.Seconden.ToString
        Label3.Text = Controle.miauw.Seconden.ToString

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

        Naam1label.Location = New Point(Me.Width * (1 / 10), Me.Height * (3 / 4))
        Naam2label.Location = New Point(Me.Width * (4.5 / 10), Me.Height * (3 / 4))
        Naam3label.Location = New Point(Me.Width * (8 / 10), Me.Height * (3 / 4))
        Label1.Location = New Point((Me.Width * (1 / 10)) + (Naam1label.Width / 3), Me.Height * (8.5 / 10))
        Label2.Location = New Point(Me.Width * (4.5 / 10) + (Naam2label.Width / 3), Me.Height * (8.5 / 10))
        Label3.Location = New Point(Me.Width * (8 / 10) + (Naam3label.Width / 3), Me.Height * (8.5 / 10))

    End Sub
    Sub ronde1()
        vragen.Text = Controle.vragenronde1(Controle.ronde1actievevraag)
        PictureBox1.Visible = True
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
        If Controle.GroupBox2.Visible = True Then
            Panel1.Visible = True
        Else
            Panel1.Visible = False
        End If
        Panel1.Width = Me.Width
        Panel1.Location = New Point(0, Me.Height * (2 / 4))
        r1v1.Location = New Point(Panel1.Width * (1 / 32), r1v1.Location.Y)
        r1v2.Location = New Point(Panel1.Width * (3 / 32), r1v1.Location.Y)
        r1v3.Location = New Point(Panel1.Width * (5 / 32), r1v1.Location.Y - 10)
        r1v4.Location = New Point(Panel1.Width * (7 / 32), r1v1.Location.Y)
        r1v5.Location = New Point(Panel1.Width * (9 / 32), r1v1.Location.Y)
        r1v6.Location = New Point(Panel1.Width * (11 / 32), r1v1.Location.Y - 10)
        r1v7.Location = New Point(Panel1.Width * (13 / 32), r1v1.Location.Y)
        r1v8.Location = New Point(Panel1.Width * (15 / 32), r1v1.Location.Y)
        r1v9.Location = New Point(Panel1.Width * (17 / 32), r1v1.Location.Y - 10)
        r1v10.Location = New Point(Panel1.Width * (19 / 32), r1v1.Location.Y)
        r1v11.Location = New Point(Panel1.Width * (21 / 32), r1v1.Location.Y)
        r1v12.Location = New Point(Panel1.Width * (23 / 32), r1v1.Location.Y - 10)
        r1v13.Location = New Point(Panel1.Width * (25 / 32), r1v1.Location.Y)
        r1v14.Location = New Point(Panel1.Width * (27 / 32), r1v1.Location.Y)
        r1v15.Location = New Point(Panel1.Width * (29 / 32), r1v1.Location.Y - 10)
        PictureBox1.Width = Me.Width
        PictureBox1.Height = (Me.Height / 2)
        PictureBox1.Location = New Point(0, 0)
    End Sub
    Sub ronde2()
        Panel1.Visible = False
        vragen.Visible = False
        PictureBox1.Visible = False
        If Controle.ronde2antw1chk.Checked Then
            Antw1.Visible = True
            Antw1.Text = Controle.ronde2antw1chk.Text
        Else
            Antw1.Visible = False
        End If
        If Controle.ronde2antwoord2chk.Checked Then
            Antw2.Visible = True
            Antw2.Text = Controle.ronde2antwoord2chk.Text
        Else
            Antw2.Visible = False
        End If
        If Controle.ronde2antwoord3chk.Checked Then
            Antw3.Visible = True
            Antw3.Text = Controle.ronde2antwoord3chk.Text
        Else
            Antw3.Visible = False
        End If
        If Controle.ronde2antwoord4chk.Checked Then
            Antw4.Visible = True
            Antw4.Text = Controle.ronde2antwoord4chk.Text
        Else
            Antw4.Visible = False
        End If
    End Sub
    Sub ronde3()
        Panel1.Visible = False
        PictureBox1.Visible = False
    End Sub
    Sub ronde4()
        Panel1.Visible = False
        PictureBox1.Visible = False
    End Sub
    Sub ronde5()
        Panel1.Visible = False
        PictureBox1.Visible = False
    End Sub
    Sub ronde6()
        Panel1.Visible = False
        PictureBox1.Visible = False
    End Sub
End Class