Imports System.Data.SqlClient
Imports System.Data
Public Class Form1
    Dim obj As New CB

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        obj.conexion()
        Dim sql As String = "select *from pagos"
        obj.consultar(DGVclientes, sql)

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim sql As String = "select *from pagos"
        obj.consultar(DGVclientes, sql)
        Dim suma As Double = 0
        Dim fila As DataGridViewRow = New DataGridViewRow()

        For Each fila In DGVclientes.Rows
            suma += Convert.ToDouble(fila.Cells("Valor").Value)
        Next
        TextBoxsuma.Text = Convert.ToString(suma)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim sql As String = "insert into pagos ( Cedula , Nombre, Apellido , Fecha , Valor ) Select " & TextBoxC.Text & ",'" & TextBoxN.Text & "', '" & TextBoxA.Text & "', '" & TextBoxF.Text & "','" & TextBoxV.Text & "' "
        obj.operaciones(DGVclientes, sql)
        TextBoxC.Clear()
        TextBoxN.Clear()
        TextBoxA.Clear()
        TextBoxV.Clear()



        Dim suma As Double = 0
        Dim fila As DataGridViewRow = New DataGridViewRow()

        For Each fila In DGVclientes.Rows
            suma += Convert.ToDouble(fila.Cells("Valor").Value)
        Next
        TextBoxsuma.Text = Convert.ToString(suma)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim sql As String = "select *from pagos Where Cedula = '" & TextBoxB.Text & "'"
        obj.consultar(DGVclientes, sql)
        If True Then
            Me.TextBoxC.Text = Me.DGVclientes.CurrentRow.Cells(0).Value
            Me.TextBoxN.Text = Me.DGVclientes.CurrentRow.Cells(1).Value
            Me.TextBoxA.Text = Me.DGVclientes.CurrentRow.Cells(2).Value
            Me.TextBoxF.Text = Me.DGVclientes.CurrentRow.Cells(3).Value
            Me.TextBoxV.Text = Me.DGVclientes.CurrentRow.Cells(4).Value


            Dim suma As Double = 0
            Dim fila As DataGridViewRow = New DataGridViewRow()



            For Each fila In DGVclientes.Rows
                suma += Convert.ToDouble(fila.Cells("Valor").Value)
            Next
            TextBoxsuma.Text = Convert.ToString(suma)

        End If
    End Sub



    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        TextBoxC.Clear()
        TextBoxN.Clear()
        TextBoxA.Clear()
        TextBoxF.Clear()
        TextBoxV.Clear()
        TextBoxB.Clear()
        TextBoxFecha.Clear()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim sql As String = "Delete  pagos Where Cedula = '" & TextBoxC.Text & "'"
        obj.operaciones(DGVclientes, sql)



        Dim suma As Double = 0
        Dim fila As DataGridViewRow = New DataGridViewRow()

        For Each fila In DGVclientes.Rows
            suma += Convert.ToDouble(fila.Cells("Valor").Value)
        Next
        TextBoxsuma.Text = Convert.ToString(suma)
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        llenarExcel(DGVclientes)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim Sql As String = "Update pagos set Nombre = '" & TextBoxN.Text & "',Apellido = '" & TextBoxA.Text & "', Fecha = '" & TextBoxF.Text & "', Valor = '" & TextBoxV.Text & "' where Cedula= '" & TextBoxC.Text & "'"
        obj.operaciones(DGVclientes, Sql)
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        confirmacion.Show()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim sql As String = "select *from pagos Where Fecha = '" & TextBoxFecha.Text & "'"
        obj.consultar(DGVclientes, sql)
        If True Then


            Dim suma As Double = 0
            Dim fila As DataGridViewRow = New DataGridViewRow()



            For Each fila In DGVclientes.Rows
                suma += Convert.ToDouble(fila.Cells("Valor").Value)
            Next
            TextBoxsuma.Text = Convert.ToString(suma)

        End If
    End Sub



    Private Sub DGVclientes_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVclientes.CellContentClick
        Dim sql As String = "select *from  Cedula, Nombre, Apellido, Fecha, Valor "
        obj.consultar(DGVclientes, sql)
        If True Then
            Me.TextBoxC.Text = Me.DGVclientes.CurrentRow.Cells(0).Value
            Me.TextBoxN.Text = Me.DGVclientes.CurrentRow.Cells(1).Value
            Me.TextBoxA.Text = Me.DGVclientes.CurrentRow.Cells(2).Value
            Me.TextBoxF.Text = Me.DGVclientes.CurrentRow.Cells(3).Value
            Me.TextBoxV.Text = Me.DGVclientes.CurrentRow.Cells(4).Value
        End If
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        Preview.Document = PrintDocument1
        Preview.Height = 100
        Preview.Width = 200
        Preview.PrintPreviewControl.Zoom = 1
        Preview.ShowDialog()
    End Sub
    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage

        Dim tan As Integer
        Dim fil As Integer
        Dim fil2 As Integer
        Dim col As Integer
        Dim tit As Integer
        Dim des As Integer
        Dim sum As Integer
        fil = 105
        fil2 = 80
        col = 90
        tit = 60
        des = 40
        sum = 110
        e.Graphics.DrawString("INFORME", Label6.Font, Brushes.Blue, col + 160, des)
        e.Graphics.DrawString("REPORTE DE PAGOS", Label6.Font, Brushes.Blue, col + 140, tit)
        e.Graphics.DrawString("Cedula", Label6.Font, Brushes.Blue, col, fil2)
        e.Graphics.DrawString("Nombre", Label6.Font, Brushes.Blue, col + 80, fil2)
        e.Graphics.DrawString("Apellido", Label6.Font, Brushes.Blue, col + 160, fil2)
        e.Graphics.DrawString("Fecha", Label6.Font, Brushes.Blue, col + 260, fil2)
        e.Graphics.DrawString("Valor", Label6.Font, Brushes.Blue, col + 360, fil2)


        For i = 0 To DGVclientes.RowCount - 1
            e.Graphics.DrawString(DGVclientes.Item(0, i).Value, TextBoxC.Font, Brushes.Black, col, fil + tan)
            e.Graphics.DrawString(DGVclientes.Item(1, i).Value, TextBoxC.Font, Brushes.Black, col + 80, fil + tan)
            e.Graphics.DrawString(DGVclientes.Item(2, i).Value, TextBoxC.Font, Brushes.Black, col + 160, fil + tan)
            e.Graphics.DrawString(DGVclientes.Item(3, i).Value, TextBoxC.Font, Brushes.Black, col + 260, fil + tan)
            e.Graphics.DrawString(DGVclientes.Item(4, i).Value, TextBoxC.Font, Brushes.Black, col + 360, fil + tan)
            tan += 20
        Next




    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Recibo.Show()
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        System.Diagnostics.Process.Start("https://okazakih22.wixsite.com/tecnoolohhgy")
    End Sub
End Class