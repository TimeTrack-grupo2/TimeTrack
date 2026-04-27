Imports System.Data.SqlClient
Imports System.Runtime.Remoting.Messaging
Imports BuscarServidor
Imports Clases
Public Class GestionAlumno
    Public Enum TipoLogin
        Incorrecto
        Alumno
        Administrador
    End Enum
    Private cadConexion As String

    Public Sub New(ByRef errorConexion As String)
        cadConexion = $"Data Source = {MiServidor.Servidor(errorConexion)}; Initial Catalog = GRUPO2; Integrated Security = SSPI; MultipleActiveResultSets=true"
    End Sub

    Public Function LogIn(dni As String, ByRef mensaje As String) As TipoLogin
        mensaje = ""
        Dim conexion As New SqlConnection(cadConexion)
        If dni.Equals("ADMIN") Then
            Return TipoLogin.Administrador
        End If

        Dim letraParte As String
        Dim numeroParte As String
        Dim letraCorrecta As Char
        Dim numero As Integer
        Dim letras As String = "TRWAGMYFPDXBNJZSQVHLCKE"
        Dim resto As Integer

        If Not dni.Length = 9 Then
            mensaje = "El DNI debe tener 9 caracteres."
            Return TipoLogin.Incorrecto

        Else
            numeroParte = dni.Substring(0, 8)
            If Not Integer.TryParse(numeroParte, numero) Then
                mensaje = "No has introducido un nvalor numerico"
                Return 0

            Else
                letraParte = dni.Chars(8)
                resto = numeroParte Mod 23
                letraCorrecta = letras.Chars(resto)
                If letraParte = letraCorrecta Then

                Else
                    Return 0
                    mensaje = "El DNI no es válido. La letra correcta debería ser: " & letraCorrecta
                End If
            End If
        End If

        Try
            conexion.Open()
            Dim sql As String = "SELECT DNI FORM ALUMNOS WHERE DNI=@DNI"
            Dim cmdAlumno As New SqlCommand(sql, conexion)
            cmdAlumno.Parameters.AddWithValue("@DNI", dni)
            Dim drAlumn As SqlDataReader = cmdAlumno.ExecuteReader
            If drAlumn.HasRows Then
                Return 1
            End If
            mensaje = "El DNI introducido no esta en la base de datos."
            Return 0
        Catch ex As Exception
            Return ex.Message
        Finally
            conexion.Close()
        End Try
    End Function
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

    ' Método 2: Elimina tareas, jornadas y el alumno directamente
    Public Function EliminarAlumno(dni As String) As String
        Dim conexion As New SqlConnection(cadConexion)
        Try
            conexion.Open()

            Dim sqlTareaRA As String = "DELETE FROM TAREA_RA WHERE DNI = @DNI"
            Dim cmdTareaRA As New SqlCommand(sqlTareaRA, conexion)
            cmdTareaRA.Parameters.AddWithValue("@DNI", dni)
            cmdTareaRA.ExecuteNonQuery()

            Dim sqlTarea As String = "DELETE FROM TAREA WHERE DNI = @DNI"
            Dim cmdTarea As New SqlCommand(sqlTarea, conexion)
            cmdTarea.Parameters.AddWithValue("@DNI", dni)
            cmdTarea.ExecuteNonQuery()

            Dim sqlJornada As String = "DELETE FROM JORNADA WHERE DNI = @DNI"
            Dim cmdJornada As New SqlCommand(sqlJornada, conexion)
            cmdJornada.Parameters.AddWithValue("@DNI", dni)
            cmdJornada.ExecuteNonQuery()

            Dim sqlAlumno As String = "DELETE FROM ALUMNO WHERE DNI = @DNI"
            Dim cmdAlumno As New SqlCommand(sqlAlumno, conexion)
            cmdAlumno.Parameters.AddWithValue("@DNI", dni)
            Dim filas As Integer = cmdAlumno.ExecuteNonQuery()

            If filas = 0 Then
                Return "No se encontró ningún alumno con ese DNI."
            Else
                Return "Alumno eliminado correctamente."
            End If

        Catch ex As Exception
            Return "Error al eliminar alumno: " & ex.Message
        Finally
            conexion.Close()
        End Try
    End Function
    Public Function ObtenerAlumnos(ByRef errorMensaje As String) As DataTable
        Dim conexion As New SqlConnection(cadConexion)
        Dim tabla As New DataTable()
        Try
            conexion.Open()
            Dim sql As String = "SELECT A.DNI, A.APELLIDO1, A.APELLIDO2, A.NOMBRE, C.NOMBRECICLO AS CICLO
                             FROM ALUMNOS A
                             INNER JOIN CICLOS C ON A.ID_CICLO = C.ID_CICLO"
            Dim cmd As New SqlCommand(sql, conexion)
            Dim adapter As New SqlDataAdapter(cmd)
            adapter.Fill(tabla)
        Catch ex As Exception
            errorMensaje = ex.Message
        Finally
            conexion.Close()
        End Try
        Return tabla
    End Function

End Class

