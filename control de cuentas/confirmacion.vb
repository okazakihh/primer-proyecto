Imports System.Data.SqlClient
Imports System.Data
Public Class confirmacion
    Dim obj As New CB
    Public Property DGVclientes As DataGridView

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim sql As String = "Delete  pagos"

        obj.operaciones(DGVclientes, sql)
        Me.Close()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form1.Show()
        Me.Close()
    End Sub

End Class