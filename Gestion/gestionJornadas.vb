Imports System.Data.SqlClient
Imports BuscarServidor

Public Class gestionJornadas
    Private cadConexion As String

    Public Sub New(ByRef errorConexion As String)
        cadConexion = $"Data Source = {MiServidor.Servidor(errorConexion)}; Initial Catalog = GRUPO2; Integrated Security = SSPI; MultipleActiveResultSets=true"
    End Sub

    Public Function AnadirJornada()

    End Function
    Public Function HorasJornadas(jornadas As String, dni As String) As String
        Dim conexion As New SqlConnection(cadConexion)
        Try
            conexion.Open()

            ' 1. Verificar que el alumno existe
            Dim sqlDni As String = "SELECT COUNT(*) FROM ALUMNO WHERE ALUMNO.DNI = @DNI"
            Dim cmdDni As New SqlCommand(sqlDni, conexion)
            cmdDni.Parameters.AddWithValue("@DNI", dni)
            Dim alumnoExiste As Integer = CInt(cmdDni.ExecuteScalar())

            If alumnoExiste = 0 Then
                Return "No se encontró ningún alumno con DNI: " & dni
            End If

            ' 2. Obtener el total de horas de las jornadas del alumno
            Dim sqlJornadas As String = "SELECT SUM(JORNADA.HORAS) FROM JORNADA WHERE JORNADA.DNI = @DNI"
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

    Public Function HorasTareas(jornadas As String, dni As String) As String
        Dim conexion As New SqlConnection(cadConexion)
        Try
            conexion.Open()

            ' 1. Verificar que el alumno existe
            Dim sqlDni As String = "SELECT COUNT(*) FROM ALUMNO WHERE ALUMNO.DNI = @DNI"
            Dim cmdDni As New SqlCommand(sqlDni, conexion)
            cmdDni.Parameters.AddWithValue("@DNI", dni)
            Dim alumnoExiste As Integer = CInt(cmdDni.ExecuteScalar())

            If alumnoExiste = 0 Then
                Return "No se encontró ningún alumno con DNI: " & dni
            End If

            ' 2. Obtener el total de horas de las tareas del alumno
            Dim sqlTareas As String = "SELECT SUM(TAREA.HORAS) FROM TAREA WHERE TAREA.DNI = @DNI"
            Dim cmdTareas As New SqlCommand(sqlTareas, conexion)
            cmdTareas.Parameters.AddWithValue("@DNI", dni)
            Dim resultado As Object = cmdTareas.ExecuteScalar()

            If resultado Is DBNull.Value OrElse resultado Is Nothing Then
                Return "El alumno con DNI " & dni & " no tiene tareas registradas."
            Else
                Dim totalHoras As Decimal = CDec(resultado)
                Return "El alumno con DNI " & dni & " tiene un total de " & totalHoras & " horas en tareas."
            End If

        Catch ex As Exception
            Return "Error al mostrar el número de horas de las tareas: " & ex.Message
        Finally
            conexion.Close()
        End Try
    End Function
End Class
