Imports System.Data.SqlClient
Imports System.Net
Imports BuscarServidor
Imports Clases

Public Class GestionCiclos

    Private cadConexion As String

    Public Sub New(ByRef errorConexion As String)
        cadConexion = $"Data Source = {MiServidor.Servidor(errorConexion)}; Initial Catalog = GRUPO2; Integrated Security = SSPI; MultipleActiveResultSets=true"
    End Sub

    Public Function AnadirCiclo(nombreCiclo As String) As String
        Dim conexion As New SqlConnection(cadConexion)

        Try
            conexion.Open()

            Dim sqlExiste As String = "SELECT COUNT(*) FROM CICLOS WHERE NOMBRECICLO = @nombre"
            Dim cmdExiste As New SqlCommand(sqlExiste, conexion)
            cmdExiste.Parameters.AddWithValue("@nombre", nombreCiclo)

            Dim cicloExiste As Integer = CInt(cmdExiste.ExecuteScalar())

            If cicloExiste > 0 Then
                Return "Ese ciclo ya existe en la base de datos."
            End If

            Dim sqlId As String = "SELECT ISNULL(MAX(ID_CICLO), 0) + 1 FROM CICLOS"
            Dim cmdId As New SqlCommand(sqlId, conexion)

            Dim nuevoId As Integer = CInt(cmdId.ExecuteScalar())

            Dim sqlInsert As String = "INSERT INTO CICLOS (ID_CICLO, NOMBRECICLO) VALUES (@id, @nombre)"
            Dim cmdAnadir As New SqlCommand(sqlInsert, conexion)

            cmdAnadir.Parameters.AddWithValue("@id", nuevoId)
            cmdAnadir.Parameters.AddWithValue("@nombre", nombreCiclo)

            Dim numFilas As Integer = cmdAnadir.ExecuteNonQuery()

            If numFilas = 0 Then
                Return "Error al añadir el ciclo."
            End If

            Return $"El ciclo {nuevoId} - {nombreCiclo} se ha añadido con éxito."

        Catch ex As Exception
            Return ex.Message

        Finally
            conexion.Close()
        End Try
    End Function

    Public Function AnadirModulo(idCiclo As Integer, nombreModulo As String) As String
        Dim conexion As New SqlConnection(cadConexion)

        Try
            conexion.Open()

            Dim sqlCiclo As String = "SELECT COUNT(*) FROM CICLOS WHERE ID_CICLO = @idCiclo"
            Dim cmdCiclo As New SqlCommand(sqlCiclo, conexion)
            cmdCiclo.Parameters.AddWithValue("@idCiclo", idCiclo)

            Dim cicloExiste As Integer = CInt(cmdCiclo.ExecuteScalar())

            If cicloExiste = 0 Then
                Return "El ciclo no existe en la base de datos."
            End If

            Dim sqlExiste As String = "SELECT COUNT(*) FROM MODULOS WHERE ID_CICLO = @idCiclo AND MODULO = @modulo"
            Dim cmdExiste As New SqlCommand(sqlExiste, conexion)

            cmdExiste.Parameters.AddWithValue("@idCiclo", idCiclo)
            cmdExiste.Parameters.AddWithValue("@modulo", nombreModulo)

            Dim moduloExiste As Integer = CInt(cmdExiste.ExecuteScalar())

            If moduloExiste > 0 Then
                Return "Ese módulo ya existe en este ciclo."
            End If

            Dim sqlId As String = "SELECT ISNULL(MAX(ID_MODULO), 0) + 1 FROM MODULOS WHERE ID_CICLO = @idCiclo"
            Dim cmdId As New SqlCommand(sqlId, conexion)
            cmdId.Parameters.AddWithValue("@idCiclo", idCiclo)

            Dim nuevoId As Integer = CInt(cmdId.ExecuteScalar())

            Dim sqlInsert As String = "INSERT INTO MODULOS (ID_CICLO, ID_MODULO, MODULO) VALUES (@idCiclo, @idModulo, @modulo)"
            Dim cmdAnadir As New SqlCommand(sqlInsert, conexion)

            cmdAnadir.Parameters.AddWithValue("@idCiclo", idCiclo)
            cmdAnadir.Parameters.AddWithValue("@idModulo", nuevoId)
            cmdAnadir.Parameters.AddWithValue("@modulo", nombreModulo)

            Dim numFilas As Integer = cmdAnadir.ExecuteNonQuery()

            If numFilas = 0 Then
                Return "Error al añadir el módulo."
            End If

            Return $"El módulo {nuevoId} - {nombreModulo} se ha añadido con éxito al ciclo {idCiclo}."

        Catch ex As Exception
            Return ex.Message

        Finally
            conexion.Close()
        End Try
    End Function

    Public Function ObtenerCiclos(ByRef errorMensaje As String) As DataTable
        Dim conexion As New SqlConnection(cadConexion)
        Dim tabla As New DataTable()

        Try
            conexion.Open()

            Dim sql As String = "SELECT ID_CICLO, NOMBRECICLO FROM CICLOS ORDER BY ID_CICLO"

            Dim cmd As New SqlCommand(sql, conexion)
            Dim adaptador As New SqlDataAdapter(cmd)

            adaptador.Fill(tabla)

        Catch ex As Exception
            errorMensaje = ex.Message

        Finally
            conexion.Close()
        End Try

        Return tabla
    End Function

    Public Function ObtenerModulosPorCiclo(idCiclo As Integer, ByRef errorMensaje As String) As DataTable
        Dim conexion As New SqlConnection(cadConexion)
        Dim tabla As New DataTable()

        Try
            conexion.Open()

            Dim sql As String = "SELECT ID_CICLO, ID_MODULO, MODULO FROM MODULOS WHERE ID_CICLO = @idCiclo ORDER BY ID_MODULO"

            Dim cmd As New SqlCommand(sql, conexion)
            cmd.Parameters.AddWithValue("@idCiclo", idCiclo)

            Dim adaptador As New SqlDataAdapter(cmd)
            adaptador.Fill(tabla)

        Catch ex As Exception
            errorMensaje = ex.Message

        Finally
            conexion.Close()
        End Try

        Return tabla
    End Function

    Public Function ObtenerHorasCiclos(ByRef errorMensaje As String) As DataTable
        Dim conexion As New SqlConnection(cadConexion)
        Dim tabla As New DataTable()

        Try
            conexion.Open()

            Dim sql As String = "SELECT CICLOS.NOMBRECICLO AS Nombre, ISNULL(SUM(TAREAS.HORAS),0) AS HorasTotales, COUNT(DISTINCT CAST(JORNADAS.FECHA_ENTRADA AS DATE)) AS DiasTrabajados FROM CICLOS LEFT JOIN ALUMNOS ON CICLOS.ID_CICLO = ALUMNOS.ID_CICLO LEFT JOIN JORNADAS ON ALUMNOS.DNI = JORNADAS.DNI LEFT JOIN TAREAS ON JORNADAS.DNI = TAREAS.DNI AND JORNADAS.ID_JORNADA = TAREAS.ID_JORNADA GROUP BY CICLOS.NOMBRECICLO ORDER BY CICLOS.NOMBRECICLO"

            Dim cmd As New SqlCommand(sql, conexion)
            Dim adaptador As New SqlDataAdapter(cmd)

            adaptador.Fill(tabla)

        Catch ex As Exception
            errorMensaje = ex.Message

        Finally
            conexion.Close()
        End Try

        Return tabla
    End Function

    Public Function ObtenerHorasModulos(idCiclo As Integer, ByRef errorMensaje As String) As DataTable
        Dim conexion As New SqlConnection(cadConexion)
        Dim tabla As New DataTable()

        Try
            conexion.Open()

            Dim sql As String = "SELECT MODULOS.MODULO AS Nombre, ISNULL(SUM(TAREAS.HORAS),0) AS HorasTotales, COUNT(DISTINCT CAST(JORNADAS.FECHA_ENTRADA AS DATE)) AS DiasTrabajados FROM MODULOS LEFT JOIN TAREA_RA ON MODULOS.ID_CICLO = TAREA_RA.ID_CICLO AND MODULOS.ID_MODULO = TAREA_RA.ID_MODULO LEFT JOIN TAREAS ON TAREA_RA.DNI = TAREAS.DNI AND TAREA_RA.ID_JORNADA = TAREAS.ID_JORNADA AND TAREA_RA.ID_TAREA = TAREAS.ID_TAREA LEFT JOIN JORNADAS ON TAREAS.DNI = JORNADAS.DNI AND TAREAS.ID_JORNADA = JORNADAS.ID_JORNADA WHERE MODULOS.ID_CICLO = @idCiclo GROUP BY MODULOS.MODULO ORDER BY MODULOS.MODULO"

            Dim cmd As New SqlCommand(sql, conexion)
            cmd.Parameters.AddWithValue("@idCiclo", idCiclo)

            Dim adaptador As New SqlDataAdapter(cmd)

            adaptador.Fill(tabla)

        Catch ex As Exception
            errorMensaje = ex.Message

        Finally
            conexion.Close()
        End Try

        Return tabla
    End Function

End Class
