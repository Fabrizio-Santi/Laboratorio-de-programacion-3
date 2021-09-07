Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        CD.ShowDialog()
        Label1.ForeColor = CD.Color
        'Me.BackColor = CD.Color
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        FD.ShowDialog()
        Label2.Font = FD.Font
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        FBD.ShowDialog()
        TextBox1.Text = FBD.SelectedPath
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        OFD.ShowDialog()
        TextBox2.Text = OFD.FileName
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        SFD.ShowDialog()
        TextBox3.Text = SFD.FileName
    End Sub
End Class
