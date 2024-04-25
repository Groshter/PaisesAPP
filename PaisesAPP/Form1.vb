Imports System.Data.SqlClient
Imports System.IO
Imports Newtonsoft.Json.Linq

Public Class Form1
    Private Sub abrirMenuItemInsertar(sender As Object, e As EventArgs) Handles irInsertar.Click
        If Me.ActiveMdiChild IsNot Nothing AndAlso Me.ActiveMdiChild.GetType() = GetType(Form1) Then
            MessageBox.Show("Ya estás en el formulario de paises.")
        Else
            Dim paisesForm As New FormularioPaises()
            paisesForm.Show()
        End If
    End Sub
    Private Sub abrirMenuItemPaises(sender As Object, e As EventArgs) Handles irPaises.Click
        Dim listadoForm As New ListadoPaises()
        listadoForm.Show()
    End Sub
End Class
