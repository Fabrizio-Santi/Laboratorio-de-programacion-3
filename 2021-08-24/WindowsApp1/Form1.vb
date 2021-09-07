Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim ID As Long = 0
        Dim NOMBRE As String = ""
        Dim SEXO As String = ""
        Dim MARCA As String = ""

        GRILLA.Rows.Clear()

        Try
            FileOpen(1, "DATA.csv", OpenMode.Input)
            Do While Not EOF(1)
                Input(1, ID)
                Input(1, NOMBRE)
                Input(1, SEXO)
                Input(1, MARCA)
                GRILLA.Rows.Add(ID, NOMBRE, SEXO, MARCA)
            Loop
            FileClose(1)
        Catch ex As Exception
            MessageBox.Show("NO SE PUDO ABRIR EL ARCHIVO", "ERROR")
        End Try

    End Sub
End Class
