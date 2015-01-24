Public Class Edit

    Public Sub initieer()

        'Past de weergegeven namen aan aan die van het bestand
        Label2.Text = Controle.jan.Naam
        Label3.Text = Controle.platypus.Naam
        Label5.Text = Controle.miauw.Naam

        'Past de weergegeven seconden aan
        Label1.Text = Controle.jan.Seconden.ToString
        Label4.Text = Controle.platypus.Seconden.ToString
        Label6.Text = Controle.miauw.Seconden.ToString

    End Sub


End Class