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


    Public Function CalcularIdTareaPorJornada(idJornada As Integer) As Integer
        Dim conexion As New SqlConnection(cadConexion)
        Try
            conexion.Open()
            Dim sqlMaxId As String = "SELECT ISNULL(MAX(ID_TAREA), 0) + 1 FROM TAREAS WHERE TAREAS.ID_JORNADA = @IDJORNADA"
            Dim cmdMaxId As New SqlCommand(sqlMaxId, conexion)
            cmdMaxId.Parameters.AddWithValue("@IDJORNADA", idJornada)
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

    Private Function InsertarTarea(tarea As Tarea, conexion As SqlConnection, transaccion As SqlTransaction) As String
        Dim sqlTarea As String = "INSERT INTO TAREAS VALUES(@DNI, @ID_JORNADA, @ID_TAREA, @HORAS, @DESCRIPCION)"
        Dim cmdTarea As New SqlCommand(sqlTarea, conexion, transaccion)
        cmdTarea.Parameters.AddWithValue("@DNI", tarea.Dni)
        cmdTarea.Parameters.AddWithValue("@ID_JORNADA", tarea.Id_Jornada)
        cmdTarea.Parameters.AddWithValue("@ID_TAREA", tarea.Id_Tarea)
        cmdTarea.Parameters.AddWithValue("@HORAS", tarea.Horas)
        cmdTarea.Parameters.AddWithValue("@DESCRIPCION", tarea.Descripcion)
        cmdTarea.ExecuteNonQuery()
        Return "OK"
    End Function

    Private Function InsertarTareaRA(tarea As Tarea, idModulo As Integer, idRA As Integer, idCiclo As Integer, conexion As SqlConnection, transaccion As SqlTransaction) As String
        Dim sqlRA As String = "INSERT INTO TAREA_RA VALUES(@ID_CICLO, @ID_MODULO, @ID_RA, @DNI, @ID_JORNADA, @ID_TAREA)"
        Dim cmdRA As New SqlCommand(sqlRA, conexion, transaccion)
        cmdRA.Parameters.AddWithValue("@ID_CICLO", idCiclo)
        cmdRA.Parameters.AddWithValue("@ID_MODULO", idModulo)
        cmdRA.Parameters.AddWithValue("@ID_RA", idRA)
        cmdRA.Parameters.AddWithValue("@DNI", tarea.Dni)
        cmdRA.Parameters.AddWithValue("@ID_JORNADA", tarea.Id_Jornada)
        cmdRA.Parameters.AddWithValue("@ID_TAREA", tarea.Id_Tarea)
        cmdRA.ExecuteNonQuery()
        Return "OK"
    End Function

    Public Function AgregarTarea(tarea As Tarea, idModulo As Integer, idRA As Integer, idCiclo As Integer) As String
        Dim conexion As New SqlConnection(cadConexion)
        Dim transaccion As SqlTransaction = Nothing
        Try
            conexion.Open()
            transaccion = conexion.BeginTransaction()

            InsertarTarea(tarea, conexion, transaccion)
            InsertarTareaRA(tarea, idModulo, idRA, idCiclo, conexion, transaccion)

            transaccion.Commit()
            Return "La tarea se ha añadido con éxito."
        Catch ex As Exception
            If transaccion IsNot Nothing Then transaccion.Rollback()
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
            Dim sql As String = "SELECT T.DNI, T.ID_JORNADA, T.ID_TAREA, M.MODULO, R.RA, T.HORAS, T.DESCRIPCION FROM TAREAS T INNER JOIN TAREA_RA TR ON T.DNI = TR.DNI AND T.ID_JORNADA = TR.ID_JORNADA AND T.ID_TAREA = TR.ID_TAREA INNER JOIN MODULOS M ON TR.ID_CICLO = M.ID_CICLO AND TR.ID_MODULO = M.ID_MODULO INNER JOIN RA R ON TR.ID_CICLO = R.ID_CICLO AND TR.ID_MODULO = R.ID_MODULO AND TR.ID_RA = R.ID_RA WHERE T.DNI = @DNI AND T.ID_JORNADA = @ID"
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
