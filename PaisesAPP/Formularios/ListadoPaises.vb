Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class ListadoPaises
    Dim connectionStr As String = "Server=Brayan;Database=Paises;Integrated Security=True;TrustServerCertificate=True;"

    Private Sub ListadoPaises_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Listar()
    End Sub
    Private Sub Listar()
        Try
            Using connection As New SqlConnection(connectionStr)
                connection.Open()
                Using command As New SqlCommand("sl_paises", connection)
                    command.CommandType = CommandType.StoredProcedure
                    Dim Listado As New DataTable()

                    Using adapter As New SqlDataAdapter(command)
                        adapter.Fill(Listado)
                    End Using

                    DataGridView1.DataSource = Listado
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al llenar el ListView: " & ex.Message)
        End Try
    End Sub
End Class