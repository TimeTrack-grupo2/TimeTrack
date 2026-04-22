Imports System.Data.SqlClient
Imports System.Runtime.Remoting.Messaging
Imports BuscarServidor
Imports Clases
Public Class gestionAlumno

    Private cadConexion As String

    Public Sub New(ByRef errorConexion As String)
        cadConexion = $"Data Source = {MiServidor.Servidor(errorConexion)}; Initial Catalog = GRUPO2; Integrated Security = SSPI; MultipleActiveResultSets=true"
    End Sub

    Public Function AñadirAlumno(alumno As Alumno) As String

        Dim conexion As New SqlConnection(cadConexion)
        Try
            conexion.Open()
            Dim sql As String = "Select dni From ALUMNOS Where dni=@dni"
            Dim cmdAlumno As New SqlCommand(sql, conexion)
            cmdAlumno.Parameters.AddWithValue("@dni", alumno.Dni)
            Dim drAlumn As SqlDataReader = cmdAlumno.ExecuteReader
            If drAlumn.HasRows Then
                conexion.Close()
                Return "El alumno ya esta en la base de datos."
            End If
            Dim sql2 As String = "INSERT INTO ALUMNOS VALUES(@DNI, @NOMBRE, @APELLIDO1, @APELLIDO2, @ID_CICLO)"
            Dim cmdAnadir As New SqlCommand(sql2, conexion)
            cmdAnadir.Parameters.AddWithValue("@DNI", alumno.Dni)
            cmdAnadir.Parameters.AddWithValue("@NOMBRE", alumno.Nombre)
            cmdAnadir.Parameters.AddWithValue("@APELLIDO1", alumno.Apellido1)
            cmdAnadir.Parameters.AddWithValue("@APELLIDO2", alumno.Apellido2)
            cmdAnadir.Parameters.AddWithValue("@ID_CICLO", alumno.Id_ciclo)
            Dim numFilas As Integer = cmdAnadir.ExecuteNonQuery
            If numFilas = 0 Then
                Return "Error al añadir usuario"
            End If
            Return $"El alumno {alumno.Apellido1} {alumno.Apellido2}, {alumno.Nombre} se ha añadido con exito."
        Catch ex As Exception
            Return ex.Message
        Finally
            conexion.Close()
        End Try

    End Function

    Public Function ciclos() As List(Of Ciclos)
        Dim conexion As New SqlConnection(cadConexion)
        Try
            conexion.Open()
            Dim sql As String = "SELECT CICLOS.ID_CICLO, CICLOS.NOMBRECICLO FROM CICLOS"
            Dim cmdCiclos As New SqlCommand(sql, conexion)
            Dim drCiclos As SqlDataReader = cmdCiclos.ExecuteReader
            Dim listaCiclos As New List(Of Ciclos)

            While drCiclos.Read
                listaCiclos.Add(New Ciclos(drCiclos("ID_CICLO"), drCiclos("NOMBRECICLO")))
            End While
            Return listaCiclos
        Catch ex As Exception
        Finally
            conexion.Close()
        End Try
    End Function
    Public Function IdCicloPorNombre(ciclo As String, ByRef mesage As String) As Integer
        Dim conexion As New SqlConnection(cadConexion)
        Try
            conexion.Open()
            Dim sql As String = "SELECT CICLOS.ID_CICLO FROM CICLOS WHERE CICLOS.NOMBRECICLO=@NOMBRE_CICLO"
            Dim cmdCiclo As New SqlCommand(sql, conexion)
            cmdCiclo.Parameters.AddWithValue("@NOMBRE_CICLO", ciclo)
            Dim drCiclo As SqlDataReader = cmdCiclo.ExecuteReader
            If drCiclo.Read Then
                Dim id_Ciclo As Integer = drCiclo.GetInt16(0) ' Convert.ToInt32(drCiclo("id_ciclo")) ' drCiclo.GetInt32(id_Ciclo)
                Return id_Ciclo
            End If
            mesage = "No existe ningun ciclo con ese nombre"
            Return Nothing
        Catch ex As Exception
            mesage = ex.Message
        End Try
    End Function
End Class
