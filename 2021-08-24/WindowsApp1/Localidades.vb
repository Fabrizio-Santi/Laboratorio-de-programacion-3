Imports System.Data.OleDb

Public Class Localidades

    Dim CONECTOR As New OleDbConnection(My.Settings.CADENA)
    Dim COMANDO As New OleDbCommand
    Dim ADAPTADOR As New OleDbDataAdapter(COMANDO)
    Dim TABLA As New DataTable

    Public Sub New()
        COMANDO.Connection = CONECTOR
        COMANDO.CommandType = CommandType.TableDirect
        COMANDO.CommandText = "Localidades"
        ADAPTADOR.Fill(TABLA)

    End Sub


    Public Function getLocalidades() As DataTable
        Return TABLA
    End Function

    Public Sub Ver(GRILLA As DataGridView)
        GRILLA.DataSource = TABLA
    End Sub

    Public Sub Probar()
        Dim FRUTAS() As String = {"UVA", "PERA", "LIMON", "NARANJA"}

        'Dim POS As Integer = 0
        'Do While POS < FRUTAS.Length
        '    MessageBox.Show(FRUTAS(POS))
        '    POS = POS + 1
        'Loop

        'For Each FRUTA As String In FRUTAS
        '    MessageBox.Show(FRUTA)
        'Next

        'For Each FILA As DataRow In TABLA.Rows

        '    MessageBox.Show(FILA("nombre"))
        'Next

        'Dim POS As Integer = 0
        'Do While POS < TABLA.Rows.Count
        '    MessageBox.Show(TABLA.Rows(POS)("nombre"))
        '    POS = POS + 1
        'Loop

        'Dim POS As Integer = TABLA.Rows.Count - 1
        'Do While POS > -1
        '    MessageBox.Show(TABLA.Rows(POS)("nombre"))
        '    POS = POS - 1
        'Loop

        Dim POS As Integer = 0
        Do While POS < TABLA.Rows.Count
            Dim FILA As DataRow = TABLA.Rows(POS)
            MessageBox.Show(FILA("nombre"))
            POS = POS + 1
        Loop

    End Sub
End Class
