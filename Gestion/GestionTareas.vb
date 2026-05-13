Imports System.ComponentModel.Design
Imports System.Data.SqlClient
Imports BuscarServidor
Imports Clases

Public Class GestionTareas
    Private cadConexion As String

    Public Sub New(ByRef errorConexion As String)
        cadConexion = $"Data Source = {MiServidor.Servidor(errorConexion)}; Initial Catalog = GRUPO2; Integrated Security = SSPI; MultipleActiveResultSets=true"
    End Sub

    Public Function ModulosPorCiclo(idCiclo) As List(Of Modulo)
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


    Public Function CalcularIdTareaPorJornada(jornada As Jornada) As Integer
        Dim conexion As New SqlConnection(cadConexion)
        Try
            conexion.Open()
            Dim sqlMaxId As String = "SELECT ISNULL(MAX(ID_TAREA), 0) + 1 FROM TAREAS WHERE TAREAS.ID_JORNADA = @IDJORNADA"
            Dim cmdMaxId As New SqlCommand(sqlMaxId, conexion)
            cmdMaxId.Parameters.AddWithValue("@IDJORNADA", jornada.ID_JORNADA)
            Dim nuevoId As Integer = CInt(cmdMaxId.ExecuteScalar())
            If (nuevoId = 0) Then
                Return Nothing
            End If
            Return nuevoId
        Catch ex As Exception
            Return Nothing
        Finally
            conexion.Close()

        End Try
    End Function
    Public Function RaPorModulos(idModulo) As List(Of Ra)
        Dim conexion As New SqlConnection(cadConexion)
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
        Finally
            conexion.Close()
        End Try
    End Function

    Public Function AgregarTarea(tarea As Tarea) As String
        Dim conexion As New SqlConnection(cadConexion)
        Try
            conexion.Open()
            Dim sqlInsertar As String = "INSERT INTO TAREAS VALUES(@DNI, @ID_JORNADA, @ID_TAREA, @HORAS, @DESCRIPCION)"
            Dim cmdInsert As New SqlCommand(sqlInsertar, conexion)
            cmdInsert.Parameters.AddWithValue("@DNI", tarea.Dni)
            cmdInsert.Parameters.AddWithValue("@ID_JORNADA", tarea.Id_Jornada)
            cmdInsert.Parameters.AddWithValue("@ID_TAREA", tarea.Id_Tarea)
            cmdInsert.Parameters.AddWithValue("@HORAS", tarea.Horas)
            cmdInsert.Parameters.AddWithValue("@DESCRIPCION", tarea.Descripcion)
            Dim numFilas As Integer = cmdInsert.ExecuteNonQuery()
            If numFilas = 0 Then Return "Error al añadir la tarea."
            Return "La tarea se ha añadido con éxito."
        Catch ex As Exception
            Return ex.Message
        Finally
            conexion.Close()
        End Try
    End Function

    Public Function BuscarTarea(dni As String, id As Integer, ByRef mensaje As String) As DataTable
        Dim conexion As New SqlConnection(cadConexion)
        Dim tablaTareas As New DataTable
        Try
            conexion.Open()
            Dim sql As String = "SELECT * FROM TAREAS WHERE TAREAS.DNI = @DNI AND TAREAS.ID_JORNADA = @ID"
            Dim cmd As New SqlCommand(sql, conexion)
            cmd.Parameters.AddWithValue("@DNI", dni)
            cmd.Parameters.AddWithValue("@ID", id)
            Dim adapter As New SqlDataAdapter(cmd)
            adapter.Fill(tablaTareas)

        Catch ex As Exception
            mensaje = ex.Message
        Finally
            conexion.Close()
        End Try
        Return tablaTareas
    End Function

    Public Function AgregarTareaRa(tarea As Tarea, idCiclo As Integer, idModulo As Integer, idRa As Integer) As Boolean
        Dim conexion As New SqlConnection(cadConexion)
        Try
            conexion.Open()
            Dim sql As String = "INSERT INTO TAREA_RA (ID_CICLO, ID_MODULO, ID_RA, DNI, ID_JORNADA) " &
                                "VALUES (@ID_CICLO, @ID_MODULO, @ID_RA, @DNI, @ID_JORNADA)"
            Dim cmd As New SqlCommand(sql, conexion)
            cmd.Parameters.AddWithValue("@ID_CICLO", idCiclo)
            cmd.Parameters.AddWithValue("@ID_MODULO", idModulo)
            cmd.Parameters.AddWithValue("@ID_RA", idRa)
            cmd.Parameters.AddWithValue("@DNI", tarea.Dni)
            cmd.Parameters.AddWithValue("@ID_JORNADA", tarea.Id_Jornada)

            Dim filas As Integer = cmd.ExecuteNonQuery()
            If filas = 0 Then Return True
            Return True
        Catch ex As Exception
            Return False
        Finally
            conexion.Close()
        End Try
    End Function

    Public Function EliminarTareaRa(tarea As Tarea) As Boolean
        Dim conexion As New SqlConnection(cadConexion)
        Try
            conexion.Open()
            Dim sql As String = "DELETE FROM TAREA_RA WHERE DNI = @DNI AND ID_JORNADA = @ID_JORNADA"
            Dim cmd As New SqlCommand(sql, conexion)
            cmd.Parameters.AddWithValue("@DNI", tarea.Dni)
            cmd.Parameters.AddWithValue("@ID_JORNADA", tarea.Id_Jornada)
            cmd.ExecuteNonQuery()
            Return True
        Catch ex As Exception
            Return False
        Finally
            conexion.Close()
        End Try
    End Function
End Class
