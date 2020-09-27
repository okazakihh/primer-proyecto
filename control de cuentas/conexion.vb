Imports System.Data.SqlClient
Module conexion
    Public Class CB
        Dim cn As New SqlConnection("Server=tcp:adminnn.database.windows.net,1433;Initial Catalog=pacho;Persist Security Info=False;User ID=pacho;Password=1101178610Jf;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;")
        Sub conexion()
            Try
                cn.Open()
                MessageBox.Show("Conectado")
                cn.Close()
            Catch ex As Exception
                MessageBox.Show("Error de conexion")
            End Try

        End Sub
        Sub consultar(ByVal tabla As DataGridView, ByVal sql As String)
            Try
                Dim DA As New SqlDataAdapter(sql, cn)
                Dim DT As New DataTable
                DA.Fill(DT)
                tabla.DataSource = DT

            Catch ex As Exception





            End Try
        End Sub
        Sub operaciones(ByVal tabla As DataGridView, ByVal sql As String)
            cn.Open()
            Try
                Dim cmd As New SqlCommand(sql, cn)
                cmd.ExecuteNonQuery()
            Catch ex As Exception

                MessageBox.Show("Error de operacion")





            End Try
            cn.Close()
        End Sub
    End Class

End Module
