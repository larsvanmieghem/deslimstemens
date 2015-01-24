Imports System.IO
Public Class Controle
    Public jan As New Speler()
    Public platypus As New Speler()
    Public miauw As New Speler()
    Dim publiekvenster As New Publiek
    Public antwoordenronde1(15) As String
    Public antwoordenronde2links(4, 2) As String
    Public antwoordenronde2centraal(4, 2) As String
    Public antwoordenronde2rechts(4, 2) As String
    Public antwoordenronde3puzzel1(3, 2) As String
    Public antwoordenronde3puzzel2(3, 2) As String
    Public antwoordenronde3puzzel3(3, 2) As String
    Public tipsronde3puzzel1(9, 2) As String
    Public tipsronde3puzzel2(9, 2) As String
    Public tipsronde3puzzel3(9, 2) As String
    Public antwoordenronde4fotos1(10, 2) As String
    Public antwoordenronde4fotos2(10, 2) As String
    Public antwoordenronde4fotos3(10, 2) As String
    Public antwoordenronde5video1(5, 2) As String
    Public antwoordenronde5video2(5, 2) As String
    Public antwoordenronde5video3(5, 2) As String
    Public ticknaspelen As Short
    Public ronde2foto1toonbaar As Boolean = True
    Public ronde2foto2toonbaar As Boolean = True
    Public ronde2foto3toonbaar As Boolean = True
    Public ronde2checkboxvpunten As Boolean = True
    Public ronde2rondgaan As Short = 1
    Public Enum actieverondeenum As Short
        driezesnegen = 1
        Opendeur = 2
        Puzzel = 3
        Galerij = 4
        Collectiefgeheugen = 5
        Finale = 6
    End Enum
    Public actieveronde As actieverondeenum
    Public Enum aandebeurtenum As Short
        Jan = 1
        Platypus = 2
        Miauw = 3
    End Enum
    Public aandebeurt As aandebeurtenum
    'Variabelen voor ronde 1
    Public ronde1actievevraag As Short
    Public ronde1rondgaan As Short 'Om te tellen of de vraag bij dezelfde persoon is aanbeland en door niemand juist beantwoord (i.p.v. door te gaan tot iemand het juist heeft)
    Public Enum ronde2actievevraagem
        links = 1
        centraal = 2
        rechts = 3
    End Enum
    Public ronde2actievevraag As ronde2actievevraagem

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Inladen namen en vragen uit bestand koop een heusnoorn
        Dim lezer As New StreamReader("spelbestandje.txt")
        lezer.ReadLine() '---Naam---
        jan.Naam = lezer.ReadLine() 'spelernaam 1
        platypus.Naam = lezer.ReadLine() 'spelernaam 2
        miauw.Naam = lezer.ReadLine() 'spelernaam 3
        lezer.ReadLine() '---Ronde1---
        For i = 1 To 15
            antwoordenronde1(i) = lezer.ReadLine() 'Antwoorden van de eerste ronde
        Next
        lezer.ReadLine() '---Ronde2links---
        For i = 1 To 4
            antwoordenronde2links(i, 1) = lezer.ReadLine() 'Antwoorden linkervraagsteller tweede ronde
        Next
        lezer.ReadLine() '---Ronde2centraal---
        For i = 1 To 4
            antwoordenronde2centraal(i, 1) = lezer.ReadLine() 'Antwoorden centrale vraagsteller tweede ronde
        Next
        lezer.ReadLine() '---Ronde2rechts---
        For i = 1 To 4
            antwoordenronde2rechts(i, 1) = lezer.ReadLine() 'Antwoorden rechtervraagsteller tweede ronde
        Next
        lezer.ReadLine() '---Ronde3puzzel1---
        For i = 1 To 3
            antwoordenronde3puzzel1(i, 1) = lezer.ReadLine() 'Antwoorden eerste puzzel derde ronde
        Next
        lezer.ReadLine() '---Ronde3puzzel2---
        For i = 1 To 3
            antwoordenronde3puzzel2(i, 1) = lezer.ReadLine() 'Antwoorden tweede puzzel derde ronde
        Next
        lezer.ReadLine() '---Ronde3puzzel3---
        For i = 1 To 3
            antwoordenronde3puzzel3(i, 1) = lezer.ReadLine() 'Antwoorden derde puzzel derde ronde
        Next
        lezer.ReadLine() '---Ronde4fotos1---
        For i = 1 To 10
            antwoordenronde4fotos1(i, 1) = lezer.ReadLine() 'Antwoorden eerste fotoreeks vierde ronde
        Next
        lezer.ReadLine() '---Ronde4fotos2---
        For i = 1 To 10
            antwoordenronde4fotos2(i, 1) = lezer.ReadLine() 'Antwoorden tweede fotoreeks vierde ronde
        Next
        lezer.ReadLine() '---Ronde4fotos3---
        For i = 1 To 10
            antwoordenronde4fotos3(i, 1) = lezer.ReadLine() 'Antwoorden derde fotoreeks vierde ronde
        Next
        lezer.ReadLine() '---Ronde5video1---
        For i = 1 To 5
            antwoordenronde5video1(i, 1) = lezer.ReadLine() 'Antwoorden eerste video vijfde ronde
        Next
        lezer.ReadLine() '---Ronde5video2---
        For i = 1 To 5
            antwoordenronde5video2(i, 1) = lezer.ReadLine() 'Antwoorden tweede video vijfde ronde
        Next
        lezer.ReadLine() '---Ronde5video3---
        For i = 1 To 5
            antwoordenronde5video3(i, 1) = lezer.ReadLine() 'Antwoorden derde video vijfde ronde
        Next
        lezer.Close()


        'Past de weergegeven namen aan aan die van het bestand
        Naam1label.Text = jan.Naam
        Naam2label.Text = platypus.Naam
        Naam3label.Text = miauw.Naam

        'Past de weergegeven seconden aan aan die van de objecten bij begin programma
        label1.Text = jan.Seconden.ToString
        Label2.Text = platypus.Seconden.ToString
        Label3.Text = miauw.Seconden.ToString

        actieveronde = actieverondeenum.driezesnegen
        aandebeurt = aandebeurtenum.Jan
        ronde1actievevraag = 1
        publiekvenster.Enabled = True
        publiekvenster.Visible = True
        publiekvenster.initieer()

    End Sub

    'Past de weergegeven seconden aan aan die van de objecten
    Private Sub labelteller_Tick(sender As Object, e As EventArgs) Handles labelteller.Tick
        label1.Text = jan.Seconden.ToString
        Label2.Text = platypus.Seconden.ToString
        Label3.Text = miauw.Seconden.ToString
       


        'Toont de juiste elementen afhankelijk van de ronde
        Select Case actieveronde
            Case actieverondeenum.driezesnegen
                GroupBox2.Visible = True
                GroupBox3.Visible = True
                GroupBox4.Visible = False
                ronde1antwoordtekstlbl.Text = antwoordenronde1(ronde1actievevraag) 'Toont het actieve antwoord   
                ronde1antwoordtekstlbl.Visible = True
                AxWindowsMediaPlayer1.Visible = False
                'Geeft aan wat de actieve vraag is
                Select Case ronde1actievevraag
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

                ronde2foto1.Visible = False
                ronde2foto2.Visible = False
                ronde2foto3.Visible = False


            Case actieverondeenum.Opendeur
                GroupBox2.Visible = False
                GroupBox3.Visible = False
                ronde1antwoordtekstlbl.Visible = False
                GroupBox4.Visible = True
                AxWindowsMediaPlayer1.Visible = True

                Select Case ronde2actievevraag
                    Case ronde2actievevraagem.links
                        ronde2antw1chk.Text = antwoordenronde2links(1, 1)
                        ronde2antwoord2chk.Text = antwoordenronde2links(2, 1)
                        ronde2antwoord3chk.Text = antwoordenronde2links(3, 1)
                        ronde2antwoord4chk.Text = antwoordenronde2links(4, 1)
                    Case ronde2actievevraagem.centraal
                        ronde2antw1chk.Text = antwoordenronde2centraal(1, 1)
                        ronde2antwoord2chk.Text = antwoordenronde2centraal(2, 1)
                        ronde2antwoord3chk.Text = antwoordenronde2centraal(3, 1)
                        ronde2antwoord4chk.Text = antwoordenronde2centraal(4, 1)
                    Case ronde2actievevraagem.rechts
                        ronde2antw1chk.Text = antwoordenronde2rechts(1, 1)
                        ronde2antwoord2chk.Text = antwoordenronde2rechts(2, 1)
                        ronde2antwoord3chk.Text = antwoordenronde2rechts(3, 1)
                        ronde2antwoord4chk.Text = antwoordenronde2rechts(4, 1)
                End Select

            Case actieverondeenum.Puzzel
                GroupBox2.Visible = False
                GroupBox3.Visible = False
                ronde1antwoordtekstlbl.Visible = False
                GroupBox4.Visible = False
                AxWindowsMediaPlayer1.Visible = False
                ronde2foto1.Visible = False
                ronde2foto2.Visible = False
                ronde2foto3.Visible = False

            Case actieverondeenum.Galerij
                GroupBox2.Visible = False
                GroupBox3.Visible = False
                ronde1antwoordtekstlbl.Visible = False
                GroupBox4.Visible = False
                AxWindowsMediaPlayer1.Visible = False
                ronde2foto1.Visible = False
                ronde2foto2.Visible = False
                ronde2foto3.Visible = False

            Case actieverondeenum.Collectiefgeheugen
                GroupBox2.Visible = False
                GroupBox3.Visible = False
                ronde1antwoordtekstlbl.Visible = False
                GroupBox4.Visible = False
                AxWindowsMediaPlayer1.Visible = True
                ronde2foto1.Visible = False
                ronde2foto2.Visible = False
                ronde2foto3.Visible = False

            Case actieverondeenum.Finale
                ronde1antwoordtekstlbl.Visible = False
                GroupBox2.Visible = False
                GroupBox3.Visible = False
                GroupBox4.Visible = False
                AxWindowsMediaPlayer1.Visible = False
                ronde2foto1.Visible = False
                ronde2foto2.Visible = False
                ronde2foto3.Visible = False
        End Select
        'Toont wie er aan de beurt is
        Select Case aandebeurt
            Case aandebeurtenum.Jan
                Naam1label.BackColor = Color.Yellow
                Naam2label.BackColor = Color.Transparent
                Naam3label.BackColor = Color.Transparent
            Case aandebeurtenum.Platypus
                Naam1label.BackColor = Color.Transparent
                Naam2label.BackColor = Color.Yellow
                Naam3label.BackColor = Color.Transparent
            Case aandebeurtenum.Miauw
                Naam1label.BackColor = Color.Transparent
                Naam2label.BackColor = Color.Transparent
                Naam3label.BackColor = Color.Yellow
        End Select

        'Zorgt ervoor dat de speler nog niet kan beginnen als de video aan staat 

        If AxWindowsMediaPlayer1.playState = WMPLib.WMPPlayState.wmppsPlaying Then
            ronde2start.Enabled = False
            ticknaspelen = 0
        Else
            ticknaspelen += 1
            If ticknaspelen < 2 Then
                ronde2start.Enabled = True
            End If
        End If
       

            publiekvenster.synchroniseer()
    End Sub



    '---Ronde1---

    Private Sub ronde1j_Click(sender As Object, e As EventArgs) Handles ronde1j.Click 'Speler heeft het antwoord juist (ronde 1)s

        If (ronde1actievevraag = 3) Or (ronde1actievevraag = 6) Or (ronde1actievevraag = 9) Or (ronde1actievevraag = 12) Or (ronde1actievevraag = 15) Then
            Select Case aandebeurt
                Case aandebeurtenum.Jan
                    jan.Seconden += 10
                Case aandebeurtenum.Platypus
                    platypus.Seconden += 10
                Case aandebeurtenum.Miauw
                    miauw.Seconden += 10
            End Select
        End If
        If ronde1actievevraag = 15 Then
            ronde1j.Visible = False
            ronde1f.Visible = False
            ronde2startronde.Visible = True
        ElseIf ronde1actievevraag < 15 Then
            ronde1actievevraag += 1
            ronde1rondgaan = 1
        End If
       
    End Sub

    Private Sub ronde1f_Click(sender As Object, e As EventArgs) Handles ronde1f.Click 'Speler heeft het antwoord fout (ronde1)

        Select Case aandebeurt
            Case aandebeurtenum.Jan
                aandebeurt = aandebeurtenum.Platypus
            Case aandebeurtenum.Platypus
                aandebeurt = aandebeurtenum.Miauw
            Case aandebeurtenum.Miauw
                aandebeurt = aandebeurtenum.Jan
        End Select
        If ronde1rondgaan < 4 Then
            ronde1rondgaan += 1
        End If
        If ronde1rondgaan >= 4 Then
            ronde1actievevraag += 1
            ronde1rondgaan = 1
        End If
    End Sub

    Private Sub ronde2startronde_Click(sender As Object, e As EventArgs) Handles ronde2startronde.Click
        actieveronde = actieverondeenum.Opendeur
        GroupBox4.Enabled = False
        ronde2startronde.Visible = False
        aandebeurt = aandebeurtenum.Jan
        ronde2foto1.Visible = True
        ronde2foto2.Visible = True
        ronde2foto3.Visible = True
    End Sub
    '---Ronde2---
  

    Private Sub ronde2stop_Click(sender As Object, e As EventArgs) Handles ronde2stop.Click
        ronde2stop.Enabled = False
        jan.Istelleraan = False
        platypus.Istelleraan = False
        miauw.Istelleraan = False
        ronde2rondgaan += 1
            Select Case aandebeurt
                Case aandebeurtenum.Jan
                    aandebeurt = aandebeurtenum.Platypus
                Case aandebeurtenum.Platypus
                    aandebeurt = aandebeurtenum.Miauw
                Case aandebeurtenum.Miauw
                    aandebeurt = aandebeurtenum.Jan
        End Select
        If ronde2rondgaan = 4 Then
            ronde2stopvraag()
        Else
            ronde2start.Enabled = True
        End If

    End Sub

    Private Sub ronde2start_Click(sender As Object, e As EventArgs) Handles ronde2start.Click
        ronde2start.Enabled = False
        ronde2stop.Enabled = True
        Select Case aandebeurt
            Case aandebeurtenum.Jan
                jan.Istelleraan = True
            Case aandebeurtenum.Platypus
                platypus.Istelleraan = True
            Case aandebeurtenum.Miauw
                miauw.Istelleraan = True
        End Select
        ronde2antw1chk.Enabled = True
        ronde2antwoord2chk.Enabled = True
        ronde2antwoord3chk.Enabled = True
        ronde2antwoord4chk.Enabled = True
        ronde2rondgaan = 1
    End Sub

    Private Sub ronde2foto1_Click(sender As Object, e As EventArgs) Handles ronde2foto1.Click
        GroupBox4.Enabled = True
        AxWindowsMediaPlayer1.URL = "openbeurtlinks.wmv"
        ronde2foto1.Visible = False
        ronde2foto2.Visible = False
        ronde2foto3.Visible = False
        ronde2actievevraag = ronde2actievevraagem.links
    End Sub

    Private Sub ronde2foto2_Click(sender As Object, e As EventArgs) Handles ronde2foto2.Click
        GroupBox4.Enabled = True
        AxWindowsMediaPlayer1.URL = "openbeurtcentraal.wmv"
        ronde2foto1.Visible = False
        ronde2foto2.Visible = False
        ronde2foto3.Visible = False
        ronde2actievevraag = ronde2actievevraagem.centraal
    End Sub

    Private Sub ronde2foto3_Click(sender As Object, e As EventArgs) Handles ronde2foto3.Click
        GroupBox4.Enabled = True
        AxWindowsMediaPlayer1.URL = "openbeurtrechts.wmv"
        ronde2foto1.Visible = False
        ronde2foto2.Visible = False
        ronde2foto3.Visible = False
        ronde2actievevraag = ronde2actievevraagem.rechts
    End Sub

    Private Sub ronde2antw1chk_CheckedChanged(sender As Object, e As EventArgs) Handles ronde2antw1chk.CheckedChanged
        If ronde2checkboxvpunten = True Then
            If ronde2antw1chk.Checked = True Then
                Select Case aandebeurt
                    Case aandebeurtenum.Jan
                        jan.Istelleraan = False
                        jan.Seconden += 20
                        jan.Istelleraan = True
                    Case aandebeurtenum.Platypus
                        platypus.Istelleraan = False
                        platypus.Seconden += 20
                        platypus.Istelleraan = True
                    Case aandebeurtenum.Miauw
                        miauw.Istelleraan = False
                        miauw.Seconden += 20
                        miauw.Istelleraan = True
                End Select
                If (ronde2antwoord2chk.Checked = True) And (ronde2antwoord3chk.Checked) = True And (ronde2antwoord4chk.Checked) Then
                    ronde2stopvraag()
                End If
            ElseIf ronde2antw1chk.Checked = False Then
                Select Case aandebeurt
                    Case aandebeurtenum.Jan
                        jan.Istelleraan = False
                        jan.Seconden -= 20
                        jan.Istelleraan = True
                    Case aandebeurtenum.Platypus
                        platypus.Istelleraan = False
                        platypus.Seconden -= 20
                        platypus.Istelleraan = True
                    Case aandebeurtenum.Miauw
                        miauw.Istelleraan = False
                        miauw.Seconden -= 20
                        miauw.Istelleraan = True
                End Select
            End If
        End If
    End Sub
    Private Sub ronde2antwoord2chk_CheckedChanged(sender As Object, e As EventArgs) Handles ronde2antwoord2chk.CheckedChanged
        If ronde2checkboxvpunten = True Then
            If ronde2antwoord2chk.Checked = True Then
                Select Case aandebeurt
                    Case aandebeurtenum.Jan
                        jan.Istelleraan = False
                        jan.Seconden += 20
                        jan.Istelleraan = True
                    Case aandebeurtenum.Platypus
                        platypus.Istelleraan = False
                        platypus.Seconden += 20
                        platypus.Istelleraan = True
                    Case aandebeurtenum.Miauw
                        miauw.Istelleraan = False
                        miauw.Seconden += 20
                        miauw.Istelleraan = True
                End Select
                If (ronde2antw1chk.Checked = True) And (ronde2antwoord3chk.Checked) = True And (ronde2antwoord4chk.Checked) Then
                    ronde2stopvraag()
                End If
            ElseIf ronde2antwoord2chk.Checked = False Then
                Select Case aandebeurt
                    Case aandebeurtenum.Jan
                        jan.Istelleraan = False
                        jan.Seconden -= 20
                        jan.Istelleraan = True
                    Case aandebeurtenum.Platypus
                        platypus.Istelleraan = False
                        platypus.Seconden -= 20
                        platypus.Istelleraan = True
                    Case aandebeurtenum.Miauw
                        miauw.Istelleraan = False
                        miauw.Seconden -= 20
                        miauw.Istelleraan = True
                End Select
            End If
        End If
    End Sub

    Private Sub ronde2antwoord3chk_CheckedChanged(sender As Object, e As EventArgs) Handles ronde2antwoord3chk.CheckedChanged
        If ronde2checkboxvpunten = True Then
            If ronde2antwoord3chk.Checked = True Then
                Select Case aandebeurt
                    Case aandebeurtenum.Jan
                        jan.Istelleraan = False
                        jan.Seconden += 20
                        jan.Istelleraan = True
                    Case aandebeurtenum.Platypus
                        platypus.Istelleraan = False
                        platypus.Seconden += 20
                        platypus.Istelleraan = True
                    Case aandebeurtenum.Miauw
                        miauw.Istelleraan = False
                        miauw.Seconden += 20
                        miauw.Istelleraan = True
                End Select
                If (ronde2antwoord2chk.Checked = True) And (ronde2antw1chk.Checked) = True And (ronde2antwoord4chk.Checked) Then
                    ronde2stopvraag()
                End If
            ElseIf ronde2antwoord3chk.Checked = False Then
                Select Case aandebeurt
                    Case aandebeurtenum.Jan
                        jan.Istelleraan = False
                        jan.Seconden -= 20
                        jan.Istelleraan = True
                    Case aandebeurtenum.Platypus
                        platypus.Istelleraan = False
                        platypus.Seconden -= 20
                        platypus.Istelleraan = True
                    Case aandebeurtenum.Miauw
                        miauw.Istelleraan = False
                        miauw.Seconden -= 20
                        miauw.Istelleraan = True
                End Select
            End If
        End If
    End Sub

    Private Sub ronde2antwoord4chk_CheckedChanged(sender As Object, e As EventArgs) Handles ronde2antwoord4chk.CheckedChanged
        If ronde2checkboxvpunten = True Then
            If ronde2antwoord4chk.Checked = True Then
                Select Case aandebeurt
                    Case aandebeurtenum.Jan
                        jan.Istelleraan = False
                        jan.Seconden += 20
                        jan.Istelleraan = True
                    Case aandebeurtenum.Platypus
                        platypus.Istelleraan = False
                        platypus.Seconden += 20
                        platypus.Istelleraan = True
                    Case aandebeurtenum.Miauw
                        miauw.Istelleraan = False
                        miauw.Seconden += 20
                        miauw.Istelleraan = True
                End Select
                If (ronde2antwoord2chk.Checked = True) And (ronde2antwoord3chk.Checked) = True And (ronde2antw1chk.Checked) Then
                    ronde2stopvraag()
                End If
            ElseIf ronde2antwoord4chk.Checked = False Then
                Select Case aandebeurt
                    Case aandebeurtenum.Jan
                        jan.Istelleraan = False
                        jan.Seconden -= 20
                        jan.Istelleraan = True
                    Case aandebeurtenum.Platypus
                        platypus.Istelleraan = False
                        platypus.Seconden -= 20
                        platypus.Istelleraan = True
                    Case aandebeurtenum.Miauw
                        miauw.Istelleraan = False
                        miauw.Seconden -= 20
                        miauw.Istelleraan = True
                End Select
            End If
        End If
    End Sub

    Public Sub ronde2stopvraag()
        jan.Istelleraan = False
        platypus.Istelleraan = False
        miauw.Istelleraan = False
        Select Case ronde2actievevraag
            Case ronde2actievevraagem.links
                ronde2foto1toonbaar = False
            Case ronde2actievevraagem.centraal
                ronde2foto2toonbaar = False
            Case ronde2actievevraagem.rechts
                ronde2foto2toonbaar = False
        End Select
        If ronde2foto1toonbaar = True Then
            ronde2foto1.Visible = True
        End If
        If ronde2foto2toonbaar = True Then
            ronde2foto2.Visible = True
        End If
        If ronde2foto3toonbaar = True Then
            ronde2foto3.Visible = True
        End If

        ronde2checkboxvpunten = False 'Zorgt dat de punten er niet terug af gaan bij het unchecken

        ronde2antwoord2chk.Checked = False
        ronde2antw1chk.Checked = False
        ronde2antwoord3chk.Checked = False
        ronde2antwoord4chk.Checked = False
        ronde2checkboxvpunten = True

        ronde2antwoord2chk.Enabled = False
        ronde2antw1chk.Enabled = False
        ronde2antwoord3chk.Enabled = False
        ronde2antwoord4chk.Enabled = False
        ronde2start.Enabled = False
        ronde2stop.Enabled = False
        GroupBox4.Enabled = False

        Select Case aandebeurt
            Case aandebeurtenum.Jan
                aandebeurt = aandebeurtenum.Platypus
            Case aandebeurtenum.Platypus
                aandebeurt = aandebeurtenum.Miauw
            Case aandebeurtenum.Miauw
                aandebeurt = aandebeurtenum.Jan
        End Select
        If (ronde2foto1toonbaar = False) And (ronde2foto2toonbaar = False) And (ronde2foto3toonbaar = False) Then

        End If
    End Sub
End Class
