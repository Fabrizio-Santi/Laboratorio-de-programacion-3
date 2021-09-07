Public Class Form3

    Dim objLOC As New Localidades
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        SAPITO.DataSource = objLOC.getLocalidades()


    End Sub



    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        objLOC.Ver(SAPITO)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        objLOC.Probar()

    End Sub
End Class