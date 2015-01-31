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
    Public ronde4actievefoto As Short = 1
    Public ronde4rondgaan As Short = 1
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
    Public origineelaandebeurt As aandebeurtenum 'Duid aan wie als eerste de vraag kreeg
    'Variabelen voor ronde 1
    Public ronde1actievevraag As Short
    Public ronde1rondgaan As Short 'Om te tellen of de vraag bij dezelfde persoon is aanbeland en door niemand juist beantwoord (i.p.v. door te gaan tot iemand het juist heeft)
    Public Enum ronde2actievevraagem
        links = 1
        centraal = 2
        rechts = 3
    End Enum
    Public ronde2actievevraag As ronde2actievevraagem
    Public Enum ronde3actievevraagem As Short
        puzzelvoorjan = 1
        puzzelvoorplatypus = 2
        puzzelvoormiauw = 3
    End Enum
    Public ronde3actievevraag As ronde3actievevraagem
    Public ronde3rondgaan As Short
    Public ronde3checkboxvpunten As Boolean = True
    Public ronde4actievereeks As ronde4actievereeksenum
    Public Enum ronde4actievereeksenum As Short
        reeks1 = 1
        reeks2 = 2
        reeks3 = 3
    End Enum
    Public ronde4checkboxvpunten As Boolean = False
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
        lezer.ReadLine() 'Ronde3puzzel1tips---
        For i = 1 To 9
            tipsronde3puzzel1(i, 1) = lezer.ReadLine() 'Tips puzzel 1
        Next
        lezer.ReadLine() '---Ronde3puzzel2---
        For i = 1 To 3
            antwoordenronde3puzzel2(i, 1) = lezer.ReadLine() 'Antwoorden tweede puzzel derde ronde
        Next
        lezer.ReadLine() 'Ronde3puzzel2tips---
        For i = 1 To 9
            tipsronde3puzzel2(i, 1) = lezer.ReadLine() 'Tips puzzel 2
        Next
        lezer.ReadLine() '---Ronde3puzzel3---
        For i = 1 To 3
            antwoordenronde3puzzel3(i, 1) = lezer.ReadLine() 'Antwoorden derde puzzel derde ronde
        Next
        lezer.ReadLine() 'Ronde3puzzel3tips---
        For i = 1 To 9
            tipsronde3puzzel3(i, 1) = lezer.ReadLine() 'Tips puzzel 3
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
                Groupbox7.Visible = False
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
                GroupBox5.Visible = False
                GroupBox6.Visible = False
                PictureBox1.Visible = False
                GroupBox8.Visible = False
                GroupBox9.Visible = False
                GroupBox11.Visible = False
                ToolStripStatusLabel1.Text = "Ronde1/6: 3-6-9"

            Case actieverondeenum.Opendeur
                GroupBox2.Visible = False
                GroupBox3.Visible = False
                ronde1antwoordtekstlbl.Visible = False
                GroupBox4.Visible = True
                Groupbox7.Visible = True
                GroupBox5.Visible = False
                GroupBox6.Visible = False
                PictureBox1.Visible = False
                GroupBox8.Visible = False
                GroupBox9.Visible = False
                GroupBox11.Visible = False
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
                ToolStripStatusLabel1.Text = "Ronde2/6: Open Deur"

            Case actieverondeenum.Puzzel
                GroupBox2.Visible = False
                GroupBox3.Visible = False
                ronde1antwoordtekstlbl.Visible = False
                GroupBox4.Visible = False
                Groupbox7.Visible = False
                ronde2foto1.Visible = False
                ronde2foto2.Visible = False
                ronde2foto3.Visible = False

                GroupBox5.Visible = True
                GroupBox6.Visible = True
                PictureBox1.Visible = False
                GroupBox8.Visible = False
                GroupBox9.Visible = False
                GroupBox11.Visible = False

                Select Case ronde3actievevraag
                    Case ronde3actievevraagem.puzzelvoorjan
                        Ronde3chkantw1.Text = antwoordenronde3puzzel1(1, 1)
                        Ronde3chkantw2.Text = antwoordenronde3puzzel1(2, 1)
                        Ronde3chkantw3.Text = antwoordenronde3puzzel1(3, 1)
                        'Antwoord 1
                        ronde3label3.Text = tipsronde3puzzel1(1, 1) '314
                        ronde3label1.Text = tipsronde3puzzel1(2, 1)
                        ronde3label4.Text = tipsronde3puzzel1(3, 1)
                        ronde3label3.ForeColor = Ronde3chkantw1.ForeColor
                        ronde3label1.ForeColor = Ronde3chkantw1.ForeColor
                        ronde3label4.ForeColor = Ronde3chkantw1.ForeColor
                        'Antwoord2
                        ronde3label2.Text = tipsronde3puzzel1(4, 1) '256
                        ronde3label5.Text = tipsronde3puzzel1(5, 1)
                        ronde3label6.Text = tipsronde3puzzel1(6, 1)
                        ronde3label2.ForeColor = Ronde3chkantw2.ForeColor
                        ronde3label5.ForeColor = Ronde3chkantw2.ForeColor
                        ronde3label6.ForeColor = Ronde3chkantw2.ForeColor
                        'Antwoord3
                        ronde3label9.Text = tipsronde3puzzel1(7, 1) '978
                        ronde3label8.Text = tipsronde3puzzel1(8, 1)
                        ronde3label7.Text = tipsronde3puzzel1(9, 1)
                        ronde3label9.ForeColor = Ronde3chkantw3.ForeColor
                        ronde3label8.ForeColor = Ronde3chkantw3.ForeColor
                        ronde3label7.ForeColor = Ronde3chkantw3.ForeColor


                    Case ronde3actievevraagem.puzzelvoorplatypus
                        Ronde3chkantw1.Text = antwoordenronde3puzzel2(1, 1)
                        Ronde3chkantw2.Text = antwoordenronde3puzzel2(2, 1)
                        Ronde3chkantw3.Text = antwoordenronde3puzzel2(3, 1)
                        'Antwoord 1
                        ronde3label2.Text = tipsronde3puzzel2(1, 1) '271
                        ronde3label7.Text = tipsronde3puzzel2(2, 1)
                        ronde3label1.Text = tipsronde3puzzel2(3, 1)
                        ronde3label2.ForeColor = Ronde3chkantw1.ForeColor
                        ronde3label7.ForeColor = Ronde3chkantw1.ForeColor
                        ronde3label1.ForeColor = Ronde3chkantw1.ForeColor
                        'Antwoord 2
                        ronde3label8.Text = tipsronde3puzzel2(4, 1) '843
                        ronde3label4.Text = tipsronde3puzzel2(5, 1)
                        ronde3label3.Text = tipsronde3puzzel2(6, 1)
                        ronde3label8.ForeColor = Ronde3chkantw2.ForeColor
                        ronde3label4.ForeColor = Ronde3chkantw2.ForeColor
                        ronde3label3.ForeColor = Ronde3chkantw2.ForeColor
                        'Antwoord3
                        ronde3label5.Text = tipsronde3puzzel2(7, 1) '596
                        ronde3label9.Text = tipsronde3puzzel2(8, 1)
                        ronde3label6.Text = tipsronde3puzzel2(9, 1)
                        ronde3label5.ForeColor = Ronde3chkantw3.ForeColor
                        ronde3label9.ForeColor = Ronde3chkantw3.ForeColor
                        ronde3label6.ForeColor = Ronde3chkantw3.ForeColor



                    Case ronde3actievevraagem.puzzelvoormiauw
                        Ronde3chkantw1.Text = antwoordenronde3puzzel3(1, 1)
                        Ronde3chkantw2.Text = antwoordenronde3puzzel3(2, 1)
                        Ronde3chkantw3.Text = antwoordenronde3puzzel3(3, 1)
                        'Antwoord 1
                        ronde3label1.Text = tipsronde3puzzel3(1, 1) '173
                        ronde3label7.Text = tipsronde3puzzel3(2, 1)
                        ronde3label3.Text = tipsronde3puzzel3(3, 1)
                        ronde3label1.ForeColor = Ronde3chkantw1.ForeColor
                        ronde3label7.ForeColor = Ronde3chkantw1.ForeColor
                        ronde3label3.ForeColor = Ronde3chkantw1.ForeColor
                        'Antwoord 2
                        ronde3label4.Text = tipsronde3puzzel3(4, 1) '498
                        ronde3label9.Text = tipsronde3puzzel3(5, 1)
                        ronde3label8.Text = tipsronde3puzzel3(6, 1)
                        ronde3label4.ForeColor = Ronde3chkantw2.ForeColor
                        ronde3label9.ForeColor = Ronde3chkantw2.ForeColor
                        ronde3label8.ForeColor = Ronde3chkantw2.ForeColor
                        'Antwoord3
                        ronde3label2.Text = tipsronde3puzzel3(7, 1) '265
                        ronde3label6.Text = tipsronde3puzzel3(8, 1)
                        ronde3label5.Text = tipsronde3puzzel3(9, 1)
                        ronde3label2.ForeColor = Ronde3chkantw3.ForeColor
                        ronde3label6.ForeColor = Ronde3chkantw3.ForeColor
                        ronde3label5.ForeColor = Ronde3chkantw3.ForeColor




                End Select










                ToolStripStatusLabel1.Text = "Ronde3/6: Puzzel"

            Case actieverondeenum.Galerij
                GroupBox2.Visible = False
                GroupBox3.Visible = False
                ronde1antwoordtekstlbl.Visible = False
                GroupBox4.Visible = False
                Groupbox7.Visible = False
                ronde2foto1.Visible = False
                ronde2foto2.Visible = False
                ronde2foto3.Visible = False
                GroupBox5.Visible = False
                GroupBox6.Visible = False
                GroupBox8.Visible = True
                GroupBox9.Visible = True
                GroupBox11.Visible = True
                ToolStripStatusLabel1.Text = "Ronde4/6: Galerij"

                Select Case ronde4actievereeks
                    Case ronde4actievereeksenum.reeks1
                        ronde4antw1chk.Text = antwoordenronde4fotos1(1, 1)
                        ronde4antw2chk.Text = antwoordenronde4fotos1(2, 1)
                        ronde4antw3chk.Text = antwoordenronde4fotos1(3, 1)
                        ronde4antw4chk.Text = antwoordenronde4fotos1(4, 1)
                        ronde4antw5chk.Text = antwoordenronde4fotos1(5, 1)
                        ronde4antw6chk.Text = antwoordenronde4fotos1(6, 1)
                        ronde4antw7chk.Text = antwoordenronde4fotos1(7, 1)
                        ronde4antw8chk.Text = antwoordenronde4fotos1(8, 1)
                        ronde4antw9chk.Text = antwoordenronde4fotos1(9, 1)
                        ronde4antw10chk.Text = antwoordenronde4fotos1(10, 1)

                    Case ronde4actievereeksenum.reeks2
                        ronde4antw1chk.Text = antwoordenronde4fotos2(1, 1)
                        ronde4antw2chk.Text = antwoordenronde4fotos2(2, 1)
                        ronde4antw3chk.Text = antwoordenronde4fotos2(3, 1)
                        ronde4antw4chk.Text = antwoordenronde4fotos2(4, 1)
                        ronde4antw5chk.Text = antwoordenronde4fotos2(5, 1)
                        ronde4antw6chk.Text = antwoordenronde4fotos2(6, 1)
                        ronde4antw7chk.Text = antwoordenronde4fotos2(7, 1)
                        ronde4antw8chk.Text = antwoordenronde4fotos2(8, 1)
                        ronde4antw9chk.Text = antwoordenronde4fotos2(9, 1)
                        ronde4antw10chk.Text = antwoordenronde4fotos2(10, 1)

                    Case ronde4actievereeksenum.reeks3
                        ronde4antw1chk.Text = antwoordenronde4fotos3(1, 1)
                        ronde4antw2chk.Text = antwoordenronde4fotos3(2, 1)
                        ronde4antw3chk.Text = antwoordenronde4fotos3(3, 1)
                        ronde4antw4chk.Text = antwoordenronde4fotos3(4, 1)
                        ronde4antw5chk.Text = antwoordenronde4fotos3(5, 1)
                        ronde4antw6chk.Text = antwoordenronde4fotos3(6, 1)
                        ronde4antw7chk.Text = antwoordenronde4fotos3(7, 1)
                        ronde4antw8chk.Text = antwoordenronde4fotos3(8, 1)
                        ronde4antw9chk.Text = antwoordenronde4fotos3(9, 1)
                        ronde4antw10chk.Text = antwoordenronde4fotos3(10, 1)

                End Select




















            Case actieverondeenum.Collectiefgeheugen
                GroupBox2.Visible = False
                GroupBox3.Visible = False
                ronde1antwoordtekstlbl.Visible = False
                GroupBox4.Visible = False
                Groupbox7.Visible = True
                ronde2foto1.Visible = False
                ronde2foto2.Visible = False
                ronde2foto3.Visible = False
                GroupBox5.Visible = False
                GroupBox6.Visible = False
                ToolStripStatusLabel1.Text = "Ronde5/6: Collectief Geheugen"
                PictureBox1.Visible = False
                GroupBox8.Visible = False
                GroupBox9.Visible = False
                GroupBox10.Visible = True
                GroupBox11.Visible = False




            Case actieverondeenum.Finale
                ronde1antwoordtekstlbl.Visible = False
                GroupBox2.Visible = False
                GroupBox3.Visible = False
                GroupBox4.Visible = False
                Groupbox7.Visible = False
                ronde2foto1.Visible = False
                ronde2foto2.Visible = False
                ronde2foto3.Visible = False
                GroupBox5.Visible = False
                GroupBox6.Visible = False
                PictureBox1.Visible = False
                GroupBox8.Visible = False
                GroupBox9.Visible = False
                GroupBox11.Visible = False
                ToolStripStatusLabel1.Text = "Ronde 6/6: finale"
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

        If publiekvenster.AxWindowsMediaPlayer1.playState = WMPLib.WMPPlayState.wmppsPlaying Then
            ronde2start.Enabled = False
            ticknaspelen = 0
            publiekvenster.AxWindowsMediaPlayer1.Visible = True
            publiekvenster.AxWindowsMediaPlayer1.uiMode = "none"
            ronde2aanhetspelen.Text = "Aan het spelen"
        Else
            ticknaspelen += 1
            If ticknaspelen < 2 Then
                ronde2start.Enabled = True
            End If
            publiekvenster.AxWindowsMediaPlayer1.Visible = False
            ronde2aanhetspelen.Text = "Niet actief"
        End If


        publiekvenster.synchroniseer()
    End Sub

    '--Editwindow--

    Private Sub Edit_Click(sender As Object, e As EventArgs) Handles Edit.Click
        Dim editvenster As New Edit
        editvenster.Enabled = True
        editvenster.Visible = True
        editvenster.initieer()
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
        startronde2()
    End Sub

    Public Sub startronde2()
        actieveronde = actieverondeenum.Opendeur
        GroupBox4.Enabled = False
        ronde2startronde.Visible = False
        aandebeurt = aandebeurtenum.Jan
        ronde2foto1.Visible = True
        ronde2foto2.Visible = True
        ronde2foto3.Visible = True
    End Sub
    Public Sub startronde1()
        actieveronde = actieverondeenum.driezesnegen
        GroupBox4.Enabled = True
        ronde2startronde.Visible = False
        ronde2actievevraag = 0
        ronde1actievevraag = 1
        aandebeurt = aandebeurtenum.Jan
        ronde2foto1.Visible = False
        ronde2foto2.Visible = False
        ronde2foto3.Visible = False
        r1v1.BackColor = Color.Transparent
        r1v2.BackColor = Color.Transparent
        r1v3.BackColor = Color.Transparent
        r1v4.BackColor = Color.Transparent
        r1v5.BackColor = Color.Transparent
        r1v6.BackColor = Color.Transparent
        r1v7.BackColor = Color.Transparent
        r1v8.BackColor = Color.Transparent
        r1v9.BackColor = Color.Transparent
        r1v10.BackColor = Color.Transparent
        r1v11.BackColor = Color.Transparent
        r1v12.BackColor = Color.Transparent
        r1v13.BackColor = Color.Transparent
        r1v14.BackColor = Color.Transparent
        r1v15.BackColor = Color.Transparent
    End Sub
    '---Ronde2---


    Private Sub ronde2stop_Click(sender As Object, e As EventArgs) Handles ronde2stop.Click
        ronde2stop.Enabled = False
        jan.Istelleraan = False
        platypus.Istelleraan = False
        miauw.Istelleraan = False
        ronde2antw1chk.Enabled = False
        ronde2antwoord2chk.Enabled = False
        ronde2antwoord3chk.Enabled = False
        ronde2antwoord4chk.Enabled = False
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
            ronde2rondgaan = 1
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
    End Sub

    Private Sub ronde2foto1_Click(sender As Object, e As EventArgs) Handles ronde2foto1.Click
        GroupBox4.Enabled = True
        publiekvenster.AxWindowsMediaPlayer1.URL = "openbeurtlinks.wmv"
        ronde2foto1.Visible = False
        ronde2foto2.Visible = False
        ronde2foto3.Visible = False
        ronde2actievevraag = ronde2actievevraagem.links
        origineelaandebeurt = aandebeurt
    End Sub
    'Subs die ervoor zorgen dat de muis in een handje verandert als je over de afbeedingen gaat 
    Private Sub ronde2foto1_hover(sender As Object, e As EventArgs) Handles ronde2foto1.MouseEnter
        Me.Cursor = Cursors.Hand
    End Sub
    Private Sub ronde2foto2_hover(sender As Object, e As EventArgs) Handles ronde2foto2.MouseEnter
        Me.Cursor = Cursors.Hand
    End Sub
    Private Sub ronde2foto3_hover(sender As Object, e As EventArgs) Handles ronde2foto3.MouseEnter
        Me.Cursor = Cursors.Hand
    End Sub
    Private Sub ronde2foto1_unhover(sender As Object, e As EventArgs) Handles ronde2foto1.MouseLeave
        Me.Cursor = Cursors.Default
    End Sub
    Private Sub ronde2foto2_unhover(sender As Object, e As EventArgs) Handles ronde2foto2.MouseLeave
        Me.Cursor = Cursors.Default
    End Sub
    Private Sub ronde2foto3_unhover(sender As Object, e As EventArgs) Handles ronde2foto3.MouseLeave
        Me.Cursor = Cursors.Default
    End Sub
    Private Sub ronde2foto2_Click(sender As Object, e As EventArgs) Handles ronde2foto2.Click
        GroupBox4.Enabled = True
        publiekvenster.AxWindowsMediaPlayer1.URL = "openbeurtcentraal.wmv"
        ronde2foto1.Visible = False
        ronde2foto2.Visible = False
        ronde2foto3.Visible = False
        ronde2actievevraag = ronde2actievevraagem.centraal
        origineelaandebeurt = aandebeurt
    End Sub

    Private Sub ronde2foto3_Click(sender As Object, e As EventArgs) Handles ronde2foto3.Click
        GroupBox4.Enabled = True
        publiekvenster.AxWindowsMediaPlayer1.URL = "openbeurtrechts.wmv"
        ronde2foto1.Visible = False
        ronde2foto2.Visible = False
        ronde2foto3.Visible = False
        ronde2actievevraag = ronde2actievevraagem.rechts
        origineelaandebeurt = aandebeurt
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
                ronde2foto3toonbaar = False
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

        Select Case origineelaandebeurt
            Case aandebeurtenum.Jan
                aandebeurt = aandebeurtenum.Platypus
            Case aandebeurtenum.Platypus
                aandebeurt = aandebeurtenum.Miauw
            Case aandebeurtenum.Miauw
                aandebeurt = aandebeurtenum.Jan
        End Select
        If (ronde2foto1toonbaar = False) And (ronde2foto2toonbaar = False) And (ronde2foto3toonbaar = False) Then
            ronde2start.Visible = False
            ronde2stop.Visible = False
            ronde2antw1chk.Visible = False
            ronde2antwoord2chk.Visible = False
            ronde2antwoord3chk.Visible = False
            ronde2antwoord4chk.Visible = False
            Ronde3startronde.Visible = True
            GroupBox4.Enabled = True
        End If
        ronde2rondgaan = 1
    End Sub
    '---Ronde 3---
    Private Sub Ronde3startronde_Click(sender As Object, e As EventArgs) Handles Ronde3startronde.Click
        startronde3()
    End Sub
    Public Sub startronde3() 'Start de ronde en zet alle benodigde variabelen en properties op begininstellingen
        actieveronde = actieverondeenum.Puzzel
        ronde3actievevraag = ronde3actievevraagem.puzzelvoorjan
        ronde3start.Enabled = True
        ronde3stop.Enabled = False
        Ronde3chkantw1.Enabled = False
        Ronde3chkantw2.Enabled = False
        Ronde3chkantw3.Enabled = False
        origineelaandebeurt = aandebeurtenum.Jan
    End Sub

    Private Sub ronde3start_Click(sender As Object, e As EventArgs) Handles ronde3start.Click 'Start het beantwoorden van de vraag
        ronde3start.Enabled = False
        ronde3stop.Enabled = True
        Ronde3chkantw1.Enabled = True
        Ronde3chkantw2.Enabled = True
        Ronde3chkantw3.Enabled = True

        Select Case aandebeurt
            Case aandebeurtenum.Jan
                jan.Istelleraan = True
            Case aandebeurtenum.Platypus
                platypus.Istelleraan = True
            Case aandebeurtenum.Miauw
                miauw.Istelleraan = True
        End Select

    End Sub

   
    Private Sub Ronde3chkantw1_CheckedChanged(sender As Object, e As EventArgs) Handles Ronde3chkantw1.CheckedChanged
        If ronde3checkboxvpunten = True Then
            If Ronde3chkantw1.Checked = True Then
                Select Case aandebeurt
                    Case aandebeurtenum.Jan
                        jan.Istelleraan = False
                        jan.Seconden += 30
                        jan.Istelleraan = True
                    Case aandebeurtenum.Platypus
                        platypus.Istelleraan = False
                        platypus.Seconden += 30
                        platypus.Istelleraan = True
                    Case aandebeurtenum.Miauw
                        miauw.Istelleraan = False
                        miauw.Seconden += 30
                        miauw.Istelleraan = True
                End Select

                If (Ronde3chkantw1.Checked = True) And (Ronde3chkantw2.Checked = True) And (Ronde3chkantw3.Checked = True) Then
                    ronde3stopactievevraag()
                End If
            ElseIf Ronde3chkantw1.Checked = False Then
                Select Case aandebeurt
                    Case aandebeurtenum.Jan
                        jan.Istelleraan = False
                        jan.Seconden -= 30
                        jan.Istelleraan = True
                    Case aandebeurtenum.Platypus
                        platypus.Istelleraan = False
                        platypus.Seconden -= 30
                        platypus.Istelleraan = True
                    Case aandebeurtenum.Miauw
                        miauw.Istelleraan = False
                        miauw.Seconden -= 30
                        miauw.Istelleraan = True
                End Select

            End If
        End If

    End Sub
    Private Sub Ronde3chkantw2_CheckedChanged(sender As Object, e As EventArgs) Handles Ronde3chkantw2.CheckedChanged
        If ronde3checkboxvpunten = True Then
            If Ronde3chkantw2.Checked = True Then
                Select Case aandebeurt
                    Case aandebeurtenum.Jan
                        jan.Istelleraan = False
                        jan.Seconden += 30
                        jan.Istelleraan = True
                    Case aandebeurtenum.Platypus
                        platypus.Istelleraan = False
                        platypus.Seconden += 30
                        platypus.Istelleraan = True
                    Case aandebeurtenum.Miauw
                        miauw.Istelleraan = False
                        miauw.Seconden += 30
                        miauw.Istelleraan = True
                End Select

                If (Ronde3chkantw1.Checked = True) And (Ronde3chkantw2.Checked = True) And (Ronde3chkantw3.Checked = True) Then
                    ronde3stopactievevraag()
                End If
            ElseIf Ronde3chkantw2.Checked = False Then
                Select Case aandebeurt
                    Case aandebeurtenum.Jan
                        jan.Istelleraan = False
                        jan.Seconden -= 30
                        jan.Istelleraan = True
                    Case aandebeurtenum.Platypus
                        platypus.Istelleraan = False
                        platypus.Seconden -= 30
                        platypus.Istelleraan = True
                    Case aandebeurtenum.Miauw
                        miauw.Istelleraan = False
                        miauw.Seconden -= 30
                        miauw.Istelleraan = True
                End Select

            End If
        End If

    End Sub
    Private Sub Ronde3chkantw3_CheckedChanged(sender As Object, e As EventArgs) Handles Ronde3chkantw3.CheckedChanged
        If ronde3checkboxvpunten = True Then
            If Ronde3chkantw3.Checked = True Then
                Select Case aandebeurt
                    Case aandebeurtenum.Jan
                        jan.Istelleraan = False
                        jan.Seconden += 30
                        jan.Istelleraan = True
                    Case aandebeurtenum.Platypus
                        platypus.Istelleraan = False
                        platypus.Seconden += 30
                        platypus.Istelleraan = True
                    Case aandebeurtenum.Miauw
                        miauw.Istelleraan = False
                        miauw.Seconden += 30
                        miauw.Istelleraan = True
                End Select

                If (Ronde3chkantw1.Checked = True) And (Ronde3chkantw2.Checked = True) And (Ronde3chkantw3.Checked = True) Then
                    ronde3stopactievevraag()
                End If
            ElseIf Ronde3chkantw3.Checked = False Then
                Select Case aandebeurt
                    Case aandebeurtenum.Jan
                        jan.Istelleraan = False
                        jan.Seconden -= 30
                        jan.Istelleraan = True
                    Case aandebeurtenum.Platypus
                        platypus.Istelleraan = False
                        platypus.Seconden -= 30
                        platypus.Istelleraan = True
                    Case aandebeurtenum.Miauw
                        miauw.Istelleraan = False
                        miauw.Seconden -= 30
                        miauw.Istelleraan = True
                End Select

            End If
        End If
    End Sub
    Public Sub ronde3stopactievevraag()
        Ronde3chkantw1.Enabled = False
        Ronde3chkantw2.Enabled = False
        Ronde3chkantw3.Enabled = False
        Ronde3stop.enabled = False
        ronde3start.Enabled = True
        jan.Istelleraan = False
        platypus.Istelleraan = False
        miauw.Istelleraan = False
        ronde3checkboxvpunten = False
        Ronde3chkantw1.Checked = False
        Ronde3chkantw2.Checked = False
        Ronde3chkantw3.Checked = False
        ronde3checkboxvpunten = True
Select origineelaandebeurt
            Case aandebeurtenum.Jan
                aandebeurt = aandebeurtenum.Platypus
                origineelaandebeurt += 1
            Case aandebeurtenum.Platypus
                aandebeurt = aandebeurtenum.Miauw
                origineelaandebeurt += 1
            Case aandebeurtenum.Miauw
                ronde3start.Visible = False
                ronde3stop.Visible = False
                Ronde3chkantw1.Visible = False
                Ronde3chkantw2.Visible = False
                Ronde3chkantw3.Visible = False
                ronde4startronde.Visible = True
        End Select
        Select Case ronde3actievevraag
            Case ronde3actievevraagem.puzzelvoorjan
                ronde3actievevraag = ronde3actievevraagem.puzzelvoorplatypus
            Case ronde3actievevraagem.puzzelvoorplatypus
                ronde3actievevraag = ronde3actievevraagem.puzzelvoormiauw
        End Select
        ronde3rondgaan = 1
    End Sub

    Private Sub ronde3stop_Click(sender As Object, e As EventArgs) Handles ronde3stop.Click
        ronde3stop.Enabled = False
        ronde3start.Enabled = True
        jan.Istelleraan = False
        platypus.Istelleraan = False
        miauw.Istelleraan = False
        Select Case aandebeurt
            Case aandebeurtenum.Jan
                aandebeurt = aandebeurtenum.Platypus
            Case aandebeurtenum.Platypus
                aandebeurt = aandebeurtenum.Miauw
            Case aandebeurtenum.Miauw
                aandebeurt = aandebeurtenum.Jan
        End Select
        ronde3rondgaan += 1
        If ronde3rondgaan >= 4 Then
            ronde3stopactievevraag()
            ronde3rondgaan = 1
        End If

    End Sub
    '---Ronde4---
    Private Sub ronde4startronde_Click(sender As Object, e As EventArgs) Handles ronde4startronde.Click
        startronde4()
    End Sub

    Public Sub startronde4()
        aandebeurt = aandebeurtenum.Jan
        actieveronde = actieverondeenum.Galerij
        PictureBox1.Load("reeks1foto1.jpg")
        ronde4actievereeks = ronde4actievereeksenum.reeks1
        PictureBox1.Visible = False
        GroupBox9.Enabled = False
        ronde4rondgaan = 1
        ronde5startronde.Visible = False
        ronde4juist.Enabled = False
        ronde4pas.Enabled = False
        ronde4start.Enabled = False
        ronde4stop.Enabled = False
    End Sub
    Private Sub Ronde4startreeks_Click(sender As Object, e As EventArgs) Handles ronde4startreeks.Click
        origineelaandebeurt = aandebeurt
        ronde4startreeks.Enabled = False
        ronde4juist.Enabled = True
        ronde4pas.Enabled = True
        ronde4start.Enabled = False
        ronde4stop.Enabled = False
        Select Case aandebeurt
            Case aandebeurtenum.Jan
                jan.Istelleraan = True
            Case aandebeurtenum.Platypus
                platypus.Istelleraan = True
            Case aandebeurtenum.Miauw
                miauw.Istelleraan = True
        End Select
        PictureBox1.Visible = True
        ronde4actievefoto = 1
        ronde4rondgaan = 1
    End Sub








    


    
    Private Sub ronde4juist_Click(sender As Object, e As EventArgs) Handles ronde4juist.Click
        If ronde4actievereeks = ronde4actievereeksenum.reeks1 Then
            Select Case ronde4actievefoto
                Case 1
                    PictureBox1.Load("reeks1foto2.jpg")
                    ronde4antw1chk.Checked = True
                Case 2
                    PictureBox1.Load("reeks1foto3.jpg")
                    ronde4antw2chk.Checked = True
                Case 3
                    PictureBox1.Load("reeks1foto4.jpg")
                    ronde4antw3chk.Checked = True
                Case 4
                    PictureBox1.Load("reeks1foto5.jpg")
                    ronde4antw4chk.Checked = True
                Case 5
                    PictureBox1.Load("reeks1foto6.jpg")
                    ronde4antw5chk.Checked = True
                Case 6
                    PictureBox1.Load("reeks1foto7.jpg")
                    ronde4antw6chk.Checked = True
                Case 7
                    PictureBox1.Load("reeks1foto8.jpg")
                    ronde4antw7chk.Checked = True
                Case 8
                    PictureBox1.Load("reeks1foto9.jpg")
                    ronde4antw8chk.Checked = True
                Case 9
                    ronde4antw9chk.Checked = True
                    PictureBox1.Load("reeks1foto10.jpg")
                Case 10
                    ronde4anderespelers()   'Zeer belangrijk dat dit voor chk10 = true komt => dit activeert de mogelijkheid voor de andere spelers 
                    'om deze reeks te beantwoorden; als alles al juist is, dan zorgt chk10 = true voor het beïndigen van de reeks. Omgekeerd  niet zou de volgende reeks worden beïndigd en zouden de andere spelers vervolgens de kans krijgen om die reeks als eerste te beantwoorden, wat totaal 
                    'niet de bedoeling is
                    ronde4antw10chk.Checked = True
            End Select
        ElseIf ronde4actievereeks = ronde4actievereeksenum.reeks2 Then
            Select Case ronde4actievefoto
                Case 1
                    PictureBox1.Load("reeks2foto2.jpg")
                    ronde4antw1chk.Checked = True
                Case 2
                    PictureBox1.Load("reeks2foto3.jpg")
                    ronde4antw2chk.Checked = True
                Case 3
                    PictureBox1.Load("reeks2foto4.jpg")
                    ronde4antw3chk.Checked = True
                Case 4
                    PictureBox1.Load("reeks2foto5.jpg")
                    ronde4antw4chk.Checked = True
                Case 5
                    PictureBox1.Load("reeks2foto6.jpg")
                    ronde4antw5chk.Checked = True
                Case 6
                    PictureBox1.Load("reeks2foto7.jpg")
                    ronde4antw6chk.Checked = True
                Case 7
                    PictureBox1.Load("reeks2foto8.jpg")
                    ronde4antw7chk.Checked = True
                Case 8
                    PictureBox1.Load("reeks2foto9.jpg")
                    ronde4antw8chk.Checked = True
                Case 9
                    ronde4antw9chk.Checked = True
                    PictureBox1.Load("reeks2foto10.jpg")
                Case 10
                    ronde4anderespelers()
                    ronde4antw10chk.Checked = True
            End Select
        ElseIf ronde4actievereeks = ronde4actievereeksenum.reeks3 Then
            Select Case ronde4actievefoto
                Case 1
                    PictureBox1.Load("reeks3foto2.jpg")
                    ronde4antw1chk.Checked = True
                Case 2
                    PictureBox1.Load("reeks3foto3.jpg")
                    ronde4antw2chk.Checked = True
                Case 3
                    PictureBox1.Load("reeks3foto4.jpg")
                    ronde4antw3chk.Checked = True
                Case 4
                    PictureBox1.Load("reeks3foto5.jpg")
                    ronde4antw4chk.Checked = True
                Case 5
                    PictureBox1.Load("reeks3foto6.jpg")
                    ronde4antw5chk.Checked = True
                Case 6
                    PictureBox1.Load("reeks3foto7.jpg")
                    ronde4antw6chk.Checked = True
                Case 7
                    PictureBox1.Load("reeks3foto8.jpg")
                    ronde4antw7chk.Checked = True
                Case 8
                    PictureBox1.Load("reeks3foto9.jpg")
                    ronde4antw8chk.Checked = True
                Case 9
                    ronde4antw9chk.Checked = True
                    PictureBox1.Load("reeks3foto10.jpg")
                Case 10
                    ronde4anderespelers()
                    ronde4antw10chk.Checked = True
            End Select
        End If
        ronde4actievefoto += 1
    End Sub

    Private Sub ronde4pas_Click(sender As Object, e As EventArgs) Handles ronde4pas.Click
        If ronde4actievereeks = ronde4actievereeksenum.reeks1 Then
            Select Case ronde4actievefoto
                Case 1
                    PictureBox1.Load("reeks1foto2.jpg")

                Case 2
                    PictureBox1.Load("reeks1foto3.jpg")

                Case 3
                    PictureBox1.Load("reeks1foto4.jpg")

                Case 4
                    PictureBox1.Load("reeks1foto5.jpg")

                Case 5
                    PictureBox1.Load("reeks1foto6.jpg")

                Case 6
                    PictureBox1.Load("reeks1foto7.jpg")

                Case 7
                    PictureBox1.Load("reeks1foto8.jpg")

                Case 8
                    PictureBox1.Load("reeks1foto9.jpg")

                Case 9

                    PictureBox1.Load("reeks1foto10.jpg")
                Case 10
                    ronde4anderespelers()
            End Select
        ElseIf ronde4actievereeks = ronde4actievereeksenum.reeks2 Then
            Select Case ronde4actievefoto
                Case 1
                    PictureBox1.Load("reeks2foto2.jpg")

                Case 2
                    PictureBox1.Load("reeks2foto3.jpg")

                Case 3
                    PictureBox1.Load("reeks2foto4.jpg")

                Case 4
                    PictureBox1.Load("reeks2foto5.jpg")

                Case 5
                    PictureBox1.Load("reeks2foto6.jpg")

                Case 6
                    PictureBox1.Load("reeks2foto7.jpg")

                Case 7
                    PictureBox1.Load("reeks2foto8.jpg")

                Case 8
                    PictureBox1.Load("reeks2foto9.jpg")

                Case 9

                    PictureBox1.Load("reeks2foto10.jpg")
                Case 10
                    ronde4anderespelers()
            End Select
        ElseIf ronde4actievereeks = ronde4actievereeksenum.reeks3 Then
            Select Case ronde4actievefoto
                Case 1
                    PictureBox1.Load("reeks3foto2.jpg")

                Case 2
                    PictureBox1.Load("reeks3foto3.jpg")

                Case 3
                    PictureBox1.Load("reeks3foto4.jpg")

                Case 4
                    PictureBox1.Load("reeks3foto5.jpg")

                Case 5
                    PictureBox1.Load("reeks3foto6.jpg")

                Case 6
                    PictureBox1.Load("reeks3foto7.jpg")

                Case 7
                    PictureBox1.Load("reeks3foto8.jpg")

                Case 8
                    PictureBox1.Load("reeks3foto9.jpg")

                Case 9
                    PictureBox1.Load("reeks3foto10.jpg")
                Case 10
                    ronde4anderespelers()
            End Select
        End If
        ronde4actievefoto += 1
    End Sub

    Private Sub ronde4antw1chk_CheckedChanged(sender As Object, e As EventArgs) Handles ronde4antw1chk.CheckedChanged
        If ronde4antw1chk.Checked = True Then
            ronde4telpuntenbij()
        Else
            ronde4trekpuntenaf()
        End If
    End Sub

    Private Sub ronde4antw2chk_CheckedChanged(sender As Object, e As EventArgs) Handles ronde4antw2chk.CheckedChanged
        If ronde4antw2chk.Checked = True Then
            ronde4telpuntenbij()
        Else
            ronde4trekpuntenaf()
        End If
    End Sub

    Private Sub ronde4antw3chk_CheckedChanged(sender As Object, e As EventArgs) Handles ronde4antw3chk.CheckedChanged
        If ronde4antw3chk.Checked = True Then
            ronde4telpuntenbij()
        Else
            ronde4trekpuntenaf()
        End If
    End Sub

    Private Sub ronde4antw4chk_CheckedChanged(sender As Object, e As EventArgs) Handles ronde4antw4chk.CheckedChanged

        If ronde4antw4chk.Checked = True Then
            ronde4telpuntenbij()
        Else
            ronde4trekpuntenaf()
        End If
    End Sub

    Private Sub ronde4antw5chk_CheckedChanged(sender As Object, e As EventArgs) Handles ronde4antw5chk.CheckedChanged
        If ronde4antw5chk.Checked = True Then
            ronde4telpuntenbij()
        Else
            ronde4trekpuntenaf()
        End If
    End Sub

    Private Sub ronde4antw6chk_CheckedChanged(sender As Object, e As EventArgs) Handles ronde4antw6chk.CheckedChanged
        If ronde4antw6chk.Checked = True Then
            ronde4telpuntenbij()
        Else
            ronde4trekpuntenaf()
        End If
    End Sub

    Private Sub ronde4antw7chk_CheckedChanged(sender As Object, e As EventArgs) Handles ronde4antw7chk.CheckedChanged
        If ronde4antw7chk.Checked = True Then
            ronde4telpuntenbij()
        Else
            ronde4trekpuntenaf()
        End If
    End Sub

    Private Sub ronde4antw8chk_CheckedChanged(sender As Object, e As EventArgs) Handles ronde4antw8chk.CheckedChanged
        If ronde4antw8chk.Checked = True Then
            ronde4telpuntenbij()
        Else
            ronde4trekpuntenaf()
        End If
    End Sub

    Private Sub ronde4antw9chk_CheckedChanged(sender As Object, e As EventArgs) Handles ronde4antw9chk.CheckedChanged
        If ronde4antw9chk.Checked = True Then
            ronde4telpuntenbij()
        Else
            ronde4trekpuntenaf()
        End If
    End Sub

    Private Sub ronde4antw10chk_CheckedChanged(sender As Object, e As EventArgs) Handles ronde4antw10chk.CheckedChanged
        If ronde4antw10chk.Checked = True Then
            ronde4telpuntenbij()
        Else
            ronde4trekpuntenaf()
        End If
    End Sub
    Private Sub ronde4telpuntenbij()
        If ronde4checkboxvpunten = False Then
            Select Case aandebeurt
                Case aandebeurtenum.Jan
                    jan.Istelleraan = False
                    jan.Seconden += 10
                    jan.Istelleraan = True
                Case aandebeurtenum.Platypus
                    platypus.Istelleraan = False
                    platypus.Seconden += 10
                    platypus.Istelleraan = True
                Case aandebeurtenum.Miauw
                    miauw.Istelleraan = False
                    miauw.Seconden += 10
                    miauw.Istelleraan = True
            End Select
            If (ronde4antw1chk.Checked = True) And (ronde4antw2chk.Checked = True) And (ronde4antw3chk.Checked = True) And (ronde4antw4chk.Checked = True) And (ronde4antw5chk.Checked = True) And (ronde4antw6chk.Checked = True) And (ronde4antw7chk.Checked = True) And (ronde4antw8chk.Checked = True) And (ronde4antw9chk.Checked = True) And (ronde4antw10chk.Checked = True) Then
                ronde4volgendereeks()
            End If
        End If
    End Sub
    Private Sub ronde4trekpuntenaf()
        If ronde4checkboxvpunten = False Then
            Select Case aandebeurt
                Case aandebeurtenum.Jan
                    jan.Istelleraan = False
                    jan.Seconden -= 10
                    jan.Istelleraan = True
                Case aandebeurtenum.Platypus
                    platypus.Istelleraan = False
                    platypus.Seconden -= 10
                    platypus.Istelleraan = True
                Case aandebeurtenum.Miauw
                    miauw.Istelleraan = False
                    miauw.Seconden -= 10
                    miauw.Istelleraan = True
            End Select
        End If
    End Sub
    Private Sub ronde4anderespelers()
        jan.Istelleraan = False
        platypus.Istelleraan = False
        miauw.Istelleraan = False
        ronde4juist.Enabled = False
        ronde4pas.Enabled = False
        PictureBox1.Visible = False
        ronde4start.Enabled = True
        ronde4stop.Enabled = False
        ronde4rondgaan += 1
        Select Case aandebeurt
            Case aandebeurtenum.Jan
                aandebeurt = aandebeurtenum.Platypus
            Case aandebeurtenum.Platypus
                aandebeurt = aandebeurtenum.Miauw
            Case aandebeurtenum.Miauw
                aandebeurt = aandebeurtenum.Jan
        End Select

    End Sub

    Private Sub ronde4start_Click(sender As Object, e As EventArgs) Handles ronde4start.Click
        GroupBox9.Enabled = True
        ronde4start.Enabled = False
        ronde4stop.Enabled = True
        Select Case aandebeurt
            Case aandebeurtenum.Jan
                jan.Istelleraan = True
            Case aandebeurtenum.Platypus
                platypus.Istelleraan = True
            Case aandebeurtenum.Miauw
                miauw.Istelleraan = True
        End Select
    End Sub

    Private Sub ronde4stop_Click(sender As Object, e As EventArgs) Handles ronde4stop.Click
        GroupBox9.Enabled = False
        ronde4start.Enabled = True
        ronde4stop.Enabled = False
        jan.Istelleraan = False
        platypus.Istelleraan = False
        miauw.Istelleraan = False
        ronde4rondgaan += 1
        Select Case aandebeurt
            Case aandebeurtenum.Jan
                aandebeurt = aandebeurtenum.Platypus
            Case aandebeurtenum.Platypus
                aandebeurt = aandebeurtenum.Miauw
            Case aandebeurtenum.Miauw
                aandebeurt = aandebeurtenum.Jan
        End Select
        If ronde4rondgaan >= 4 Then
            ronde4volgendereeks()
        End If
    End Sub
    Private Sub ronde4volgendereeks()
        ronde4rondgaan = 1
        Select Case origineelaandebeurt
            Case aandebeurtenum.Jan
                aandebeurt = aandebeurtenum.Platypus
            Case aandebeurtenum.Platypus
                aandebeurt = aandebeurtenum.Miauw
            Case aandebeurtenum.Miauw
                GroupBox9.Visible = False
                ronde5startronde.Visible = True
                ronde4start.Visible = False
                ronde4stop.Visible = False
                ronde4juist.Visible = False
                ronde4pas.Visible = False
        End Select
        ronde4checkboxvpunten = True
        ronde4antw1chk.Checked = False
        ronde4antw2chk.Checked = False
        ronde4antw3chk.Checked = False
        ronde4antw4chk.Checked = False
        ronde4antw5chk.Checked = False
        ronde4antw6chk.Checked = False
        ronde4antw7chk.Checked = False
        ronde4antw8chk.Checked = False
        ronde4antw9chk.Checked = False
        ronde4antw10chk.Checked = False
        ronde4checkboxvpunten = False
        ronde4stop.Enabled = False
        ronde4startreeks.Enabled = True
        Select Case ronde4actievereeks
            Case ronde4actievereeksenum.reeks1
                ronde4actievereeks = ronde4actievereeksenum.reeks2
                PictureBox1.Load("reeks2foto1.jpg")
            Case ronde4actievereeksenum.reeks2
                ronde4actievereeks = ronde4actievereeksenum.reeks3
                PictureBox1.Load("reeks3foto1.jpg")
        End Select
        origineelaandebeurt = aandebeurt
    End Sub
    '---Ronde5---
    Private Sub ronde5startronde_Click(sender As Object, e As EventArgs) Handles ronde5startronde.Click
        startronde5()
    End Sub
    Public Sub startronde5()
        actieveronde = actieverondeenum.Collectiefgeheugen
        aandebeurt = aandebeurtenum.Jan
        origineelaandebeurt = aandebeurt
    End Sub







    Public Sub startronde6()
        actieveronde = actieverondeenum.Finale
    End Sub
End Class
