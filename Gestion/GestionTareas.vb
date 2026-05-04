Imports System.Data.SqlClient
Imports BuscarServidor
Imports Clases

Public Class GestionTareas
    Private cadConexion As String

    Public Sub New(ByRef errorConexion As String)
        cadConexion = $"Data Source = {MiServidor.Servidor(errorConexion)}; Initial Catalog = GRUPO2; Integrated Security = SSPI; MultipleActiveResultSets=true"
    End Sub

    Public Function modulosPorCiclo(idCiclo) As List(Of Modulo)
        Dim conexion As New SqlConnection(cadConexion)
        Dim listaModulos As New List(Of Modulo)
        Try
            conexion.Open()
            Dim sql As String = "SELECT MODULOS.ID_CICLO, MODULOS.ID_MODULO, MODULOS.MODULO FROM MODULOS WHERE MODULOS.ID_CICLO = @ID_CICLO"
            Dim cmd As New SqlCommand(sql, conexion)
            cmd.Parameters.AddWithValue("@ID_CICLO", idCiclo)
            Dim drModulos As SqlDataReader = cmd.ExecuteReader

            While drModulos.Read
                listaModulos.Add(New Modulo(drModulos("ID_CICLO"), drModulos("ID_MODULO"), drModulos("MODULO")))
            End While
            Return listaModulos
        Catch ex As Exception
            Return Nothing
        Finally
            conexion.Close()
        End Try

    End Function

    Public Function raPorModulos(idModulo) As List(Of Ra)
        Dim conexion As New SqlConnection
        Dim listaRa As New List(Of Ra)
        Try
            conexion.Open()
            Dim sql As String = "SELECT ID_CICLO, ID_MODULO, ID_RA, RA FROM RA WHERE ID_MODULO = @ID_MODULO"
            Dim cmd As New SqlCommand(sql, conexion)
            cmd.Parameters.AddWithValue("@ID_MODULO", idModulo)
            Dim drRas As SqlDataReader = cmd.ExecuteReader
            While drRas.Read
                listaRa.Add(New Ra(drRas("ID_CICLO"), drRas("ID_RA"), drRas("ID_MODULO"), drRas("RA")))
            End While
            Return listaRa
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    Public Function agregarTarea(idJornada As String)
        Dim conexion As New SqlConnection(cadConexion)
        Try
            conexion.Open()
            Dim sql As String = ""
        Catch ex As Exception
        End Try
    End Function
End Class
