Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Start.Click
        For i = 1 To Convert.ToInt32(TextBox1.Text)
            Dim Yoga
            Yoga = Yoga & i
            ListBox1.Items.Add(Yoga)
        Next

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        ListBox1.Items.Clear()
    End Sub
End Class
