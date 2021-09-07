Public Class Form2
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        FileOpen(1, "ENCUESTA.txt", OpenMode.Append)
        WriteLine(1, txtNombre.Text.Trim.ToUpper, txtFruta.Text.Trim.ToUpper)
        txtNombre.Text = ""
        txtFruta.Text = ""
        FileClose(1)


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim objLOC As New Localidades
        DataGridView1.DataSource = objLOC.getLocalidades()


    End Sub
End Class