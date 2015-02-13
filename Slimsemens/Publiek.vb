Public Class Publiek
    Dim vlcaangeschakeld As Boolean = False
    Dim teller As Short = 0
    Dim vlcbezet As Boolean = False
    Public Sub initieer()
        'Past de weergegeven namen aan aan die van het bestand
        Naam1label.Text = Controle.jan.Naam
        Naam2label.Text = Controle.platypus.Naam
        Naam3label.Text = Controle.miauw.Naam
       
        'Past de weergegeven seconden aan aan die van de objecten bij begin programma
        Label1.Text = Controle.jan.Seconden.ToString
        Label2.Text = Controle.platypus.Seconden.ToString
        Label3.Text = Controle.miauw.Seconden.ToString
        AxVLCPlugin21.playlist.add(Controle.map & "\generiek.mp3")
        AxVLCPlugin21.playlist.add(Controle.map & "\klok.mp3")
        AxVLCPlugin21.playlist.add(Controle.map & "\goed.mp3")
        AxVLCPlugin21.playlist.add(Controle.map & "\finale.mp3")
        AxVLCPlugin21.playlist.add(Controle.map & "\klokeind.mp3")
        ronde2foto1.Load(Controle.map & "\ronde2foto1.jpg")
        ronde2foto2.Load(Controle.map & "\ronde2foto2.jpg")
        ronde2foto3.Load(Controle.map & "\ronde2foto3.jpg")
    End Sub

    Public Sub synchroniseer()
        finalenaamlabel1.Text = Controle.heusnoorn.Naam
        Finalenaamlabel2.Text = Controle.abricoos.Naam

        If Controle.actieveronde = Controle.actieverondeenum.driezesnegen Then
            ronde1()
        ElseIf Controle.actieveronde = Controle.actieverondeenum.Opendeur Then
            ronde2()
        ElseIf Controle.actieveronde = Controle.actieverondeenum.Puzzel Then
            ronde3()
        ElseIf Controle.actieveronde = Controle.actieverondeenum.Galerij Then
            ronde4()
        ElseIf Controle.actieveronde = Controle.actieverondeenum.Collectiefgeheugen Then
            ronde5()
        ElseIf Controle.actieveronde = Controle.actieverondeenum.Finale Then
            ronde6()
        ElseIf Controle.actieveronde = Controle.actieverondeenum.Winnaar Then
            ronde7()
        End If
        'Toont de juiste elementen afhankelijk van de ronde
        algemeen()








    End Sub
    Sub algemeen()
        Label1.Text = Controle.jan.Seconden.ToString
        Label2.Text = Controle.platypus.Seconden.ToString
        Label3.Text = Controle.miauw.Seconden.ToString
        'Zorgt voor het afspelen van het klokgeluidje
        If vlcbezet = False Then
            If (Controle.jan.Istelleraan = True) Or (Controle.platypus.Istelleraan = True) Or (Controle.miauw.Istelleraan = True) Or (Controle.heusnoorn.Istelleraan = True) Or (Controle.abricoos.Istelleraan = True) Then
                If vlcaangeschakeld = False Then
                    vlcaangeschakeld = True
                    AxVLCPlugin21.playlist.playItem(1)
                End If
            Else
                If vlcaangeschakeld = True Then
                    vlcaangeschakeld = False
                    AxVLCPlugin21.playlist.stop()
                End If
            End If
        End If
        If Controle.GroupBox1.Visible = True Then
            Naam1label.Visible = True
            Naam2label.Visible = True
            Naam3label.Visible = True
            Label1.Visible = True
            Label2.Visible = True
            Label3.Visible = True
            PictureBox2.Visible = True
            PictureBox3.Visible = True
            PictureBox4.Visible = True
            finalenaamlabel1.Visible = False
            Finalenaamlabel2.Visible = False
            finaleteller1.Visible = False
            finaleteller2.Visible = False
            PictureBox6.Visible = False
            PictureBox7.Visible = False
        ElseIf Controle.GroupBox12.Visible = True Then
            Naam1label.Visible = False
            Naam2label.Visible = False
            Naam3label.Visible = False
            Label1.Visible = False
            Label2.Visible = False
            Label3.Visible = False
            PictureBox2.Visible = False
            PictureBox3.Visible = False
            PictureBox4.Visible = False
            finalenaamlabel1.Visible = True
            Finalenaamlabel2.Visible = True
            finaleteller1.Visible = True
            finaleteller2.Visible = True
            PictureBox6.Visible = True
            PictureBox7.Visible = True
        End If

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
        finalenaamlabel1.Location = New Point(Me.Width * (2.75 / 10), Me.Height * (3 / 4))
        Finalenaamlabel2.Location = New Point(Me.Width * (6.25 / 10), Me.Height * (3 / 4))
        Label1.Location = New Point((Me.Width * (1 / 10)) + (Naam1label.Width / 3), Me.Height * (8.5 / 10))
        Label2.Location = New Point(Me.Width * (4.5 / 10) + (Naam2label.Width / 3), Me.Height * (8.5 / 10))
        Label3.Location = New Point(Me.Width * (8 / 10) + (Naam3label.Width / 3), Me.Height * (8.5 / 10))
        finaleteller1.Location = New Point(finalenaamlabel1.Location.X, Label1.Location.Y)
        finaleteller2.Location = New Point(Finalenaamlabel2.Location.X, Label1.Location.Y)
        PictureBox2.Location = New Point(Naam1label.Location.X - 40, Naam1label.Location.Y)
        PictureBox3.Location = New Point(Naam2label.Location.X - 40, Naam1label.Location.Y)
        PictureBox4.Location = New Point(Naam3label.Location.X - 40, Naam1label.Location.Y)
        PictureBox6.Location = New Point(finalenaamlabel1.Location.X - 40, finalenaamlabel1.Location.Y)
        PictureBox7.Location = New Point(Finalenaamlabel2.Location.X - 40, finalenaamlabel1.Location.Y)
        AxWindowsMediaPlayer1.Width = Me.Width
        AxWindowsMediaPlayer1.Height = Me.Height
        AxWindowsMediaPlayer1.Location = New Point(0, 0)
        ronde2foto1.Location = New Point(Me.Width * (1 / 10), 20)
        ronde2foto2.Location = New Point(Me.Width * (1 / 10), Me.Height * (1 / 4) + 20)
        ronde2foto3.Location = New Point(Me.Width * (1 / 10), Me.Height * (2 / 4) + 20)
        ronde2foto1.Width = Me.Width * (2 / 10)
        ronde2foto1.Height = Me.Height * (1 / 5)
        ronde2foto2.Width = Me.Width * (2 / 10)
        ronde2foto2.Height = Me.Height * (1 / 5)
        ronde2foto3.Width = Me.Width * (2 / 10)
        ronde2foto3.Height = Me.Height * (1 / 5)
        ronde6antw1.Location = New Point(Me.Width * (1 / 10), Me.Height * (1 / 2))
        ronde6antw2.Location = New Point(Me.Width * (2.8 / 10), Me.Height * (5 / 9))
        ronde6antw3.Location = New Point(Me.Width * (4.6 / 10), Me.Height * (1 / 2))
        ronde6antw4.Location = New Point(Me.Width * (6.4 / 10), Me.Height * (5 / 9))
        ronde6antw5.Location = New Point(Me.Width * (8.2 / 10), Me.Height * (1 / 2))
        logo6.Location = New Point(ronde6antw1.Location.X - 50, ronde6antw1.Location.Y)
        logo7.Location = New Point(ronde6antw2.Location.X - 50, ronde6antw2.Location.Y)
        logo8.Location = New Point(ronde6antw3.Location.X - 50, ronde6antw3.Location.Y)
        logo9.Location = New Point(ronde6antw4.Location.X - 50, ronde6antw4.Location.Y)
        logo10.Location = New Point(ronde6antw5.Location.X - 50, ronde6antw5.Location.Y)
        If Controle.ronde2foto1.Visible = True Then
            ronde2foto1.Visible = True
        Else
            ronde2foto1.Visible = False
        End If

        If Controle.ronde2foto2.Visible = True Then
            ronde2foto2.Visible = True
        Else
            ronde2foto2.Visible = False
        End If

        If Controle.ronde2foto3.Visible = True Then
            ronde2foto3.Visible = True
        Else
            ronde2foto3.Visible = False
        End If
        ronde2Antw1.Location = New Point(Me.Width * (2 / 3), 20)
        ronde2Antw2.Location = New Point(Me.Width * (2 / 3), Me.Height * (1 / 8) + 20)
        ronde2Antw3.Location = New Point(Me.Width * (2 / 3), Me.Height * (2 / 8) + 20)
        ronde2Antw4.Location = New Point(Me.Width * (2 / 3), Me.Height * (3 / 8) + 20)
        logo201.Location = New Point(ronde2Antw1.Location.X - 50, ronde2Antw1.Location.Y - 10)
        logo202.Location = New Point(ronde2Antw2.Location.X - 50, ronde2Antw2.Location.Y - 10)
        logo203.Location = New Point(ronde2Antw3.Location.X - 50, ronde2Antw3.Location.Y - 10)
        logo204.Location = New Point(ronde2Antw4.Location.X - 50, ronde2Antw4.Location.Y - 10)
        ronde3antw1.Location = New Point(Me.Width * (5 / 6), 20)
        ronde3antw2.Location = New Point(Me.Width * (5 / 6), Me.Height * (1 / 6) + 20)
        ronde3antw3.Location = New Point(Me.Width * (5 / 6), Me.Height * (2 / 6) + 20)
        logo301.Location = New Point(ronde3antw1.Location.X - 50, ronde3antw1.Location.Y - 10)
        logo302.Location = New Point(ronde3antw2.Location.X - 50, ronde3antw2.Location.Y - 10)
        logo303.Location = New Point(ronde3antw3.Location.X - 50, ronde3antw3.Location.Y - 10)
        ronde3antw1.Text = Controle.Ronde3chkantw1.Text
        ronde3antw2.Text = Controle.Ronde3chkantw2.Text
        ronde3antw3.Text = Controle.Ronde3chkantw3.Text
        ronde4tip1.Text = Controle.ronde3label1.Text
        ronde4tip2.Text = Controle.ronde3label2.Text
        ronde4tip3.Text = Controle.ronde3label3.Text
        ronde4tip4.Text = Controle.ronde3label4.Text
        ronde4tip5.Text = Controle.ronde3label5.Text
        ronde4tip6.Text = Controle.ronde3label6.Text
        ronde4tip7.Text = Controle.ronde3label7.Text
        ronde4tip8.Text = Controle.ronde3label8.Text
        ronde4tip9.Text = Controle.ronde3label9.Text
        ronde4tips.Width = (Me.Width * (5 / 6) - 50)
        ronde4tips.Height = (Me.Height * (2 / 3))
        ronde4tips.Location = New Point(0, 0)
        ronde4tip1.Location = New Point(ronde4tips.Width * (1 / 10), ronde4tips.Height * (1 / 10))
        ronde4tip2.Location = New Point(ronde4tips.Width * (4 / 10), ronde4tips.Height * (1 / 10))
        ronde4tip3.Location = New Point(ronde4tips.Width * (7 / 10), ronde4tips.Height * (1 / 10))
        ronde4tip4.Location = New Point(ronde4tips.Width * (1 / 10), ronde4tips.Height * (4 / 10))
        ronde4tip5.Location = New Point(ronde4tips.Width * (4 / 10), ronde4tips.Height * (4 / 10))
        ronde4tip6.Location = New Point(ronde4tips.Width * (7 / 10), ronde4tips.Height * (4 / 10))
        ronde4tip7.Location = New Point(ronde4tips.Width * (1 / 10), ronde4tips.Height * (7 / 10))
        ronde4tip8.Location = New Point(ronde4tips.Width * (4 / 10), ronde4tips.Height * (7 / 10))
        ronde4tip9.Location = New Point(ronde4tips.Width * (7 / 10), ronde4tips.Height * (7 / 10))
        ronde4foto.Size = Me.Size
        ronde4foto.Location = New Point(0, 0)
        ronde5antw1.Location = New Point(Me.Width * (2 / 3), 20)
        ronde5antw2.Location = New Point(Me.Width * (2 / 3), Me.Height * (2 / 3) * (1 / 5) + 20)
        ronde5antw3.Location = New Point(Me.Width * (2 / 3), Me.Height * (2 / 3) * (2 / 5) + 20)
        ronde5antw4.Location = New Point(Me.Width * (2 / 3), Me.Height * (2 / 3) * (3 / 5) + 20)
        ronde5antw5.Location = New Point(Me.Width * (2 / 3), Me.Height * (2 / 3) * (4 / 5) + 20)
        logo1.Location = logo201.Location
        logo2.Location = New Point(ronde5antw2.Location.X - 50, ronde5antw2.Location.Y - 10)
        logo3.Location = New Point(ronde5antw3.Location.X - 50, ronde5antw3.Location.Y - 10)
        logo4.Location = New Point(ronde5antw4.Location.X - 50, ronde5antw4.Location.Y - 10)
        logo5.Location = New Point(ronde5antw5.Location.X - 50, ronde5antw5.Location.Y - 10)
        ronde5antw1.Text = Controle.ronde5antw1chk.Text
        ronde5antw2.Text = Controle.ronde5antw2chk.Text
        ronde5antw3.Text = Controle.ronde5antw3chk.Text
        ronde5antw4.Text = Controle.ronde5antw4chk.Text
        ronde5antw5.Text = Controle.ronde5antw5chk.Text
        If Controle.PictureBox1.Visible = True Then
            ronde4foto.Visible = True
        Else
            ronde4foto.Visible = False
        End If
    End Sub
    Sub ronde1()
        ronde6onzichtbaar()
        vragen.Text = Controle.vragenronde1(Controle.ronde1actievevraag)
        ronde5onzichtbaar()
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
        PictureBox5.Width = PictureBox1.Width * (2 / 3)
        PictureBox5.Height = PictureBox1.Height
        PictureBox5.Location = PictureBox1.Location
        PictureBox1.Location = New Point(0, 0)
        ronde2onzichtbaar()
        ronde3onzichtbaar()
    End Sub
    Sub ronde2()
        ronde6onzichtbaar()
        Panel1.Visible = False
        vragen.Visible = False
        ronde5onzichtbaar()
        PictureBox1.Visible = False
        If Controle.ronde2antw1chk.Checked Then
            ronde2Antw1.Visible = True
            ronde2Antw1.Text = Controle.ronde2antw1chk.Text
            logo201.Visible = True
        Else
            ronde2Antw1.Visible = False
            logo201.Visible = False
        End If
        If Controle.ronde2antwoord2chk.Checked Then
            ronde2Antw2.Visible = True
            ronde2Antw2.Text = Controle.ronde2antwoord2chk.Text
            logo202.Visible = True
        Else
            ronde2Antw2.Visible = False
            logo202.Visible = False
        End If
        If Controle.ronde2antwoord3chk.Checked Then
            ronde2Antw3.Visible = True
            ronde2Antw3.Text = Controle.ronde2antwoord3chk.Text
            logo203.Visible = True
        Else
            ronde2Antw3.Visible = False
            logo203.Visible = False
        End If
        If Controle.ronde2antwoord4chk.Checked Then
            ronde2Antw4.Visible = True
            ronde2Antw4.Text = Controle.ronde2antwoord4chk.Text
            logo204.Visible = True
        Else
            ronde2Antw4.Visible = False
            logo204.Visible = False
        End If
        ronde3onzichtbaar()
    End Sub
    Sub ronde3()
        ronde6onzichtbaar()
        Panel1.Visible = False
        PictureBox1.Visible = False
        vragen.Visible = False
        If (Controle.jan.Istelleraan = True) Or (Controle.platypus.Istelleraan = True) Or (Controle.miauw.Istelleraan = True) Then
            ronde4tips.Visible = True
        Else
            ronde4tips.Visible = False
        End If

        ronde2onzichtbaar()
        If Controle.Ronde3chkantw1.Checked Then
            ronde3antw1.Visible = True
            logo301.Visible = True
        Else
            ronde3antw1.Visible = False
            logo301.Visible = False
        End If
        If Controle.Ronde3chkantw2.Checked Then
            ronde3antw2.Visible = True
            logo302.Visible = True
        Else
            ronde3antw2.Visible = False
            logo302.Visible = False
        End If
        If Controle.Ronde3chkantw3.Checked Then
            ronde3antw3.Visible = True
            logo303.Visible = True
        Else
            ronde3antw3.Visible = False
            logo303.Visible = False
        End If
        ronde5onzichtbaar()
    End Sub
    Sub ronde4()
        Panel1.Visible = False
        PictureBox1.Visible = True
        vragen.Visible = False
        ronde2onzichtbaar()
        ronde3onzichtbaar()
        ronde5onzichtbaar()
        ronde6onzichtbaar()
    End Sub
    Sub ronde5()
        vragen.Visible = False
        Panel1.Visible = False
        PictureBox1.Visible = False
        PictureBox5.Visible = True
        If Controle.ronde5antw1chk.Checked = True Then
            ronde5antw1.Visible = True
            logo1.Visible = True
        Else
            ronde5antw1.Visible = False
            logo1.Visible = False
        End If
        If Controle.ronde5antw2chk.Checked = True Then
            logo2.Visible = True
            ronde5antw2.Visible = True
        Else
            ronde5antw2.Visible = False
            logo2.Visible = False
        End If
        If Controle.ronde5antw3chk.Checked = True Then
            logo3.Visible = True
            ronde5antw3.Visible = True
        Else
            logo3.Visible = False
            ronde5antw3.Visible = False
        End If
        If Controle.ronde5antw4chk.Checked = True Then
            logo4.Visible = True
            ronde5antw4.Visible = True
        Else
            ronde5antw4.Visible = False
            logo4.Visible = False
        End If
        If Controle.ronde5antw5chk.Checked = True Then
            ronde5antw5.Visible = True
            logo5.Visible = True
        Else
            ronde5antw5.Visible = False
            logo5.Visible = False
        End If
        ronde2onzichtbaar()
        ronde3onzichtbaar()
    End Sub
    Sub ronde6()
        vragen.Visible = False
        Panel1.Visible = False
        PictureBox1.Visible = True
        ronde2onzichtbaar()
        ronde3onzichtbaar()
        ronde5onzichtbaar()
        finaleteller1.Text = Controle.heusnoorn.Seconden.ToString
        finaleteller2.Text = Controle.abricoos.Seconden.ToString
        ronde6antw1.Text = Controle.antwoordenfinale(Controle.ronde6actievevraag, 1)
        ronde6antw2.Text = Controle.antwoordenfinale(Controle.ronde6actievevraag, 2)
        ronde6antw3.Text = Controle.antwoordenfinale(Controle.ronde6actievevraag, 3)
        ronde6antw4.Text = Controle.antwoordenfinale(Controle.ronde6actievevraag, 4)
        ronde6antw5.Text = Controle.antwoordenfinale(Controle.ronde6actievevraag, 5)
        If Controle.finaleaandebeurt = Controle.finaleaandebeurtem.heusnoorn Then
        Else
            finalenaamlabel1.ForeColor = Color.Gold
            Finalenaamlabel2.ForeColor = Color.White
        End If
        finalenaamlabel1.ForeColor = Color.White
        Finalenaamlabel2.ForeColor = Color.Gold
        If Controle.ronde6antw1.Checked Then
            ronde6antw1.Visible = True
            logo6.Visible = True
        Else
            ronde6antw1.Visible = False
            logo6.Visible = False
        End If
        If Controle.ronde6antw2.Checked Then
            ronde6antw2.Visible = True
            logo7.Visible = True
        Else
            ronde6antw2.Visible = False
            logo7.Visible = False
        End If
        If Controle.ronde6antw3.Checked Then
            ronde6antw3.Visible = True
            logo8.Visible = True
        Else
            ronde6antw3.Visible = False
            logo8.Visible = False
        End If
        If Controle.ronde6antw4.Checked Then
            ronde6antw4.Visible = True
            logo9.Visible = True
        Else
            ronde6antw4.Visible = False
            logo9.Visible = False
        End If
        If Controle.ronde6antw5.Checked Then
            ronde6antw5.Visible = True
            logo10.Visible = True
        Else
            ronde6antw5.Visible = False
            logo10.Visible = False
        End If
    End Sub
    Sub ronde7()
        vragen.Visible = False
        Panel1.Visible = False
        PictureBox1.Visible = False
        ronde2onzichtbaar()
        ronde3onzichtbaar()
        ronde5onzichtbaar()
        ronde6onzichtbaar()
    End Sub
    Public Sub juistgeluid()
        vlcbezet = True
        AxVLCPlugin21.playlist.playItem(2)
        teller = 0
        Timer1.Enabled = True


    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        teller += 1
        If teller >= 10 Then
            Timer1.Enabled = False
            vlcbezet = False
            AxVLCPlugin21.playlist.stop()
            If vlcaangeschakeld = True Then
                vlcaangeschakeld = False
            End If
        End If

    End Sub
    Sub ronde2onzichtbaar()
        logo201.Visible = False
        logo202.Visible = False
        logo203.Visible = False
        logo204.Visible = False
        ronde2Antw1.Visible = False
        ronde2Antw2.Visible = False
        ronde2Antw3.Visible = False
        ronde2Antw4.Visible = False
    End Sub
    Sub ronde3onzichtbaar()
        ronde4tips.Visible = False  'Dat had eigelijk ronde4 moeten heten :)
        logo301.Visible = False
        logo302.Visible = False
        logo303.Visible = False
        ronde3antw1.Visible = False
        ronde3antw2.Visible = False
        ronde3antw3.Visible = False
    End Sub
    Sub ronde5onzichtbaar()
        ronde5antw1.Visible = False
        ronde5antw2.Visible = False
        ronde5antw3.Visible = False
        ronde5antw4.Visible = False
        ronde5antw5.Visible = False
        logo1.Visible = False
        logo2.Visible = False
        logo3.Visible = False
        logo4.Visible = False
        logo5.Visible = False
        PictureBox5.Visible = False
    End Sub
    Sub ronde6onzichtbaar()
        ronde6antw1.Visible = False
        ronde6antw2.Visible = False
        ronde6antw3.Visible = False
        ronde6antw4.Visible = False
        ronde6antw5.Visible = False
        logo6.Visible = False
        logo7.Visible = False
        logo8.Visible = False
        logo9.Visible = False
        logo10.Visible = False
    End Sub

  
End Class