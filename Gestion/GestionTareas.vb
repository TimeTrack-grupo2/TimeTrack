Imports System.Data.SqlClient
Imports BuscarServidor

Public Class GestionTareas
    Private cadConexion As String

    Public Sub New(ByRef errorConexion As String)
        cadConexion = $"Data Source = {MiServidor.Servidor(errorConexion)}; Initial Catalog = GRUPO2; Integrated Security = SSPI; MultipleActiveResultSets=true"
    End Sub


    Public Function agregarTarea(idJornada As String)
        Dim conexion As New SqlConnection(cadConexion)
        Try
            conexion.Open()
            Dim sql As String = ""
        Catch ex As Exception

        End Try
    End Function
End Class
