Imports Newtonsoft.Json.Linq
Imports System.Data.SqlClient
Imports System.IO
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class FormularioPaises
    Dim connectionStr As String = "Server=Brayan;Database=Paises;Integrated Security=True;TrustServerCertificate=True;"
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            'Dim RutaProvisoria = "C:\Users\brada\OneDrive\Escritorio\paises (2).txt"
            Dim Ventana As New OpenFileDialog
            With Ventana
                .Title = "Seleccionar JSON"
                .Filter = "Archivos de texto (*.txt)|*.txt|Archivos JSON (*.json)|*.json|Todos los archivos (*.*)|*.*"
            End With
            Dim jsonSeleccionado As String
            Dim json As String

            If Ventana.ShowDialog() = DialogResult.OK Then
                jsonSeleccionado = Ventana.FileName
            End If

            If Not String.IsNullOrEmpty(jsonSeleccionado) Then

                json = File.ReadAllText(jsonSeleccionado)
                Dim jsonObject As JObject = JObject.Parse(json)
                Dim paises As JArray = jsonObject("paises")

                Dim errores = 0

                If paises.Count > 0 Then
                    Dim query As String = "INSERT INTO Paises (Descripcion, Vigente) VALUES (@Descripcion, @Vigente)"
                    Using connection As New SqlConnection(connectionStr)
                        connection.Open()
                        For Each pais As JObject In paises
                            Dim Descripcion As String = pais("nombre").ToString()
                            Dim Vigente As Integer = pais("vigente").ToObject(Of Integer)()

                            Using command As New SqlCommand(query, connection)
                                command.Parameters.AddWithValue("@Descripcion", Descripcion)
                                command.Parameters.AddWithValue("@Vigente", Vigente)

                                Dim insertados As Integer = command.ExecuteNonQuery()

                                If insertados = 0 Then
                                    errores += 1
                                End If
                            End Using
                        Next
                    End Using
                Else
                    MessageBox.Show($"No se encontraron paises en el json.")
                End If

                If errores = 0 Then
                    MessageBox.Show($"Se insertaron paises.")
                End If

            End If
        Catch ex As Exception
            MessageBox.Show("Error al leer el json de paises: " & ex.Message)
        End Try
    End Sub
End Class