Public Class Form2
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnCopiar.Click
        My.Computer.FileSystem.CopyDirectory(txtOrigen.Text, txtDestino.Text)
        MessageBox.Show("Copia Finalizada")
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtOrigen.TextChanged

    End Sub

    Private Sub FolderBrowserDialog1_HelpRequest(sender As Object, e As EventArgs) Handles FBD.HelpRequest

    End Sub

    Private Sub btnPuntitos1_Click(sender As Object, e As EventArgs) Handles btnPuntitos1.Click
        FBD.ShowDialog()
        txtOrigen.Text = FBD.SelectedPath
    End Sub

    Private Sub btnPuntitos2_Click(sender As Object, e As EventArgs) Handles btnPuntitos2.Click
        FBD.ShowDialog()
        txtDestino.Text = FBD.SelectedPath
    End Sub
End Class