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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Controle.jan.Seconden = Controle.jan.Seconden - 1
        initieer()
    End Sub

    Private Sub mintienspelereen_Click(sender As Object, e As EventArgs) Handles mintienspelereen.Click
        Controle.jan.Seconden = Controle.jan.Seconden - 10
        initieer()
    End Sub

    Private Sub pluseenspelereen_Click(sender As Object, e As EventArgs) Handles pluseenspelereen.Click
        Controle.jan.Seconden = Controle.jan.Seconden + 1
        initieer()
    End Sub

    Private Sub plustienspelereen_Click(sender As Object, e As EventArgs) Handles plustienspelereen.Click
        Controle.jan.Seconden = Controle.jan.Seconden + 10
        initieer()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Controle.platypus.Seconden = Controle.platypus.Seconden - 10
        initieer()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Controle.platypus.Seconden = Controle.platypus.Seconden - 1
        initieer()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Controle.platypus.Seconden = Controle.platypus.Seconden + 1
        initieer()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Controle.platypus.Seconden = Controle.platypus.Seconden + 10
        initieer()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Controle.miauw.Seconden = Controle.miauw.Seconden - 10
        initieer()
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Controle.miauw.Seconden = Controle.miauw.Seconden - 1
        initieer()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Controle.miauw.Seconden = Controle.miauw.Seconden + 1
        initieer()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Controle.miauw.Seconden = Controle.miauw.Seconden + 10
        initieer()
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        Controle.startronde2()
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Controle.startronde1()
    End Sub
End Class