Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ListBox1_SelectedIndexChanged()

    End Sub

    Private Sub ListBox1_SelectedIndexChanged() Handles ListBox1.SelectedIndexChanged
        Dim Yoga
        For i = 0 To 5
            Yoga = Yoga & i
            ListBox1.Show(Yoga)


        Next


    End Sub
End Class
