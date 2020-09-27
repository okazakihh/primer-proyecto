Imports System.Data.SqlClient
Public Class Recibo
    Dim pin As New CB
    Private Sub Recibo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim sql As String = "select *from pagos"
    End Sub
    Private Sub imprimir_Click(sender As Object, e As EventArgs) Handles imprimir.Click
        Dim sql As String = "select *from pagos Where Cedula = '" & TextBoxC.Text & "'"
        pin.consultar(DGVclientes, sql)
        Me.TextBoxC.Text = Me.DGVclientes.CurrentRow.Cells(0).Value
        Me.TextBoxN.Text = Me.DGVclientes.CurrentRow.Cells(1).Value
        Me.TextBoxA.Text = Me.DGVclientes.CurrentRow.Cells(2).Value
        Me.TextBoxF.Text = Me.DGVclientes.CurrentRow.Cells(3).Value
        Me.TextBoxV.Text = Me.DGVclientes.CurrentRow.Cells(4).Value

        Richimp.Text = vbCrLf & vbCrLf & " " & TextBox2.Text & vbCrLf &
        vbCrLf & "Fecha: " & TextBoxF.Text & vbCrLf &
         vbCrLf & "Serie: " & TextBox1.Text & vbCrLf &
        vbCrLf & "Cedula: " & TextBoxC.Text & vbCrLf &
         vbCrLf & "Nombre: " & TextBoxN.Text & vbCrLf &
         vbCrLf & "Apellido: " & TextBoxA.Text & vbCrLf &
         vbCrLf & "Valor: " & TextBoxV.Text & vbCrLf
    End Sub

    Private Sub PictureBox5_Click_1(sender As Object, e As EventArgs) Handles PictureBox5.Click
        If PrintPreviewDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            PrintDocument1.Print()
        End If
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim LAPIZ As New SolidBrush(Richimp.ForeColor)
        Dim AREA_IMPRESION As Graphics = e.Graphics
        AREA_IMPRESION.DrawString(Richimp.Text, Richimp.Font, LAPIZ, 300, 20)
    End Sub


End Class