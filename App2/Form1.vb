Public Class Form1


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim number As Integer

        Randomize()
        ''Acest program genereaza un numar aleatoriu intre 0 si 50
        number = Int(Rnd() * 50) + 1

        TextBox1.Text = number
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs)

    End Sub
End Class
