Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim nrO1 As Integer
        Dim nrO2 As Integer
        Dim rta As Double

        nrO1 = TextBox1.Text
        nrO2 = TextBox2.Text

        rta = nrO1 + nrO2

        TextBox3.Text = rta


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim nrO1 As Integer
        Dim nrO2 As Integer
        Dim rta As Double

        nrO1 = TextBox1.Text
        nrO2 = TextBox2.Text

        rta = nrO1 - nrO2

        TextBox3.Text = rta

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim nrO1 As Integer
        Dim nrO2 As Integer
        Dim rta As Double

        nrO1 = TextBox1.Text
        nrO2 = TextBox2.Text

        rta = nrO1 * nrO2

        TextBox3.Text = rta




    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim nrO1 As Integer
        Dim nrO2 As Integer
        Dim rta As Double

        nrO1 = TextBox1.Text
        nrO2 = TextBox2.Text

        rta = nrO1 / nrO2

        TextBox3.Text = rta




    End Sub


End Class
