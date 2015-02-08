Public Class Speler
    'KLasse waarmee de punten van de spelers worden bewaard en het telsysteem aan of uitgezet
    Dim mnaam As String
    Dim mseconden As Integer
    Dim mistelleraan As Boolean
    Dim mtellernaam As String
    Dim WithEvents timer As New Timer
    Dim mleeftijd As Short
    'Contructor
    Public Sub New()
        mnaam = "Heusnoorn"
        mseconden = 60
        mistelleraan = False
        timer.Enabled = False
        timer.Interval = 1000 'milliseconden
        mleeftijd = 42
    End Sub
    'Houdt spelersnaam bij
    Public Property Naam() As String
        Get
            Return mnaam
        End Get
        Set(value As String)
            mnaam = value.Trim
            If (mnaam.ToLower = "heusnoorn") Or (mnaam.ToLower = "lars") Then
                Seconden += 1000 ':)
            End If
        End Set
    End Property
    'Houdt aantal seconden bij
    Public Property Seconden() As Integer
        Get
            Return mseconden
        End Get
        Set(ByVal value As Integer)
            mseconden = value
        End Set
    End Property
    'Houdt bij of afteller aan staat
    Public Property Istelleraan() As Boolean
        Get
            Return mistelleraan
        End Get
        Set(ByVal value As Boolean)
            If (mistelleraan <> value) Then
                mistelleraan = value
                If mistelleraan = True Then
                    timer.Enabled = True
                ElseIf mistelleraan = False Then
                    timer.Enabled = False
                End If
            End If
        End Set
    End Property
    Public Property leeftijd() As Short
        Get
            Return mleeftijd
        End Get
        Set(value As Short)
            value = mleeftijd
        End Set
    End Property

    Private Sub timertick(sender As Object, e As EventArgs) Handles timer.Tick
        mseconden -= 1
    End Sub



End Class
