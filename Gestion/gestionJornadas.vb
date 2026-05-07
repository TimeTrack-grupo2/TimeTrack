Imports System.Data.SqlClient
Imports BuscarServidor
Imports Clases

Public Class gestionJornadas
    Private cadConexion As String

    Public Sub New(ByRef errorConexion As String)
        cadConexion = $"Data Source = {MiServidor.Servidor(errorConexion)}; Initial Catalog = GRUPO2; Integrated Security = SSPI; MultipleActiveResultSets=true"
    End Sub

    ' Función auxiliar para calcular el siguiente ID_JORNADA
    Private Function ObtenerNuevoId(conexion As SqlConnection, jornada As Jornada) As Integer
        Dim sqlMaxId As String = "SELECT ISNULL(MAX(ID_JORNADA), 0) + 1 FROM JORNADAS WHERE DNI = @DNI"
        Dim cmdMaxId As New SqlCommand(sqlMaxId, conexion)
        cmdMaxId.Parameters.AddWithValue("@DNI", jornada.Dni)
        Return CInt(cmdMaxId.ExecuteScalar())
    End Function

    Public Function AnadirJornada(jornada As Jornada) As String
        Dim conexion As New SqlConnection(cadConexion)
        Try
            conexion.Open()

            ' 1. Verificar que el alumno existe
            Dim sql As String = "SELECT COUNT(*) FROM ALUMNOS WHERE DNI = @dni"
            Dim cmdAlumno As New SqlCommand(sql, conexion)
            cmdAlumno.Parameters.AddWithValue("@dni", jornada.Dni)
            Dim alumnoExiste As Integer = CInt(cmdAlumno.ExecuteScalar())

            If alumnoExiste = 0 Then
                Return "El alumno no existe en la base de datos."
            End If

            ' 2. Obtener el siguiente ID_JORNADA (función separada)
            Dim nuevoId As Integer = ObtenerNuevoId(conexion, jornada)

            ' 3. Insertar la jornada con el nuevo ID
            Dim sql2 As String = "INSERT INTO JORNADAS VALUES(@DNI, @ID_JORNADA, @HORAS, @FECHA_ENTRADA, @ESTADO)"
            Dim cmdAnadir As New SqlCommand(sql2, conexion)
            cmdAnadir.Parameters.AddWithValue("@DNI", jornada.Dni)
            cmdAnadir.Parameters.AddWithValue("@ID_JORNADA", nuevoId)
            cmdAnadir.Parameters.AddWithValue("@HORAS", jornada.HORAS)
            cmdAnadir.Parameters.AddWithValue("@FECHA_ENTRADA", jornada.FECHA_ENTRADA)
            cmdAnadir.Parameters.AddWithValue("@ESTADO", jornada.ESTADO)

            Dim numFilas As Integer = cmdAnadir.ExecuteNonQuery()
            If numFilas = 0 Then
                Return "Error al añadir jornada."
            End If

            ' Actualizar el ID en el objeto jornada
            jornada.ID_JORNADA = nuevoId

            Return $"La jornada {jornada.ID_JORNADA} {jornada.FECHA_ENTRADA}, {jornada.ESTADO} se ha añadido con éxito."

        Catch ex As Exception
            Return ex.Message
        Finally
            conexion.Close()
        End Try
    End Function
    Public Function HorasJornadas(dni As String) As String
        Dim conexion As New SqlConnection(cadConexion)
        Try
            conexion.Open()

            ' 1. Verificar que el alumno existe
            Dim sqlDni As String = "SELECT COUNT(*) FROM ALUMNOS WHERE DNI = @DNI"
            Dim cmdDni As New SqlCommand(sqlDni, conexion)
            cmdDni.Parameters.AddWithValue("@DNI", dni)
            Dim alumnoExiste As Integer = CInt(cmdDni.ExecuteScalar())

            If alumnoExiste = 0 Then
                Return "No se encontró ningún alumno con DNI: " & dni
            End If
            Dim sqlJornadas As String = "SELECT SUM(HORAS) FROM JORNADAS WHERE DNI = @DNI"
            Dim cmdJornada As New SqlCommand(sqlJornadas, conexion)
            cmdJornada.Parameters.AddWithValue("@DNI", dni)
            Dim resultado As Object = cmdJornada.ExecuteScalar()

            If resultado Is DBNull.Value OrElse resultado Is Nothing Then
                Return "El alumno con DNI " & dni & " no tiene jornadas registradas."
            Else
                Dim totalHoras As Decimal = CDec(resultado)
                Return "El alumno con DNI " & dni & " tiene un total de " & totalHoras & " horas en jornadas."
            End If

        Catch ex As Exception
            Return "Error al mostrar el número de horas de las jornadas: " & ex.Message
        Finally
            conexion.Close()
        End Try
    End Function
    Public Function ObtenerJornadasAlumno(dni As String) As DataTable
        Dim conexion As New SqlConnection(cadConexion)
        Dim tabla As New DataTable()
        Try
            conexion.Open()
            Dim sql As String = "SELECT ID_JORNADA, FECHA_ENTRADA, HORAS, ESTADO
                             FROM JORNADAS
                             WHERE DNI = @DNI
                             ORDER BY FECHA_ENTRADA DESC"
            Dim cmd As New SqlCommand(sql, conexion)
            cmd.Parameters.AddWithValue("@DNI", dni)
            Dim adapter As New SqlDataAdapter(cmd)
            adapter.Fill(tabla)
        Catch ex As Exception
        Finally
            conexion.Close()
        End Try
        Return tabla
    End Function

End Class
