Imports BuscarServidor
Imports Clases
Imports Gestion
Imports Microsoft.Data.SqlClient
Imports NUnit.Framework
Imports NUnit.Framework.Constraints

Namespace Tests

    <TestFixture>
    Public Class EstructuraBBDDTest

        Private errorConexion As String = ""
        Private cadConexion As String = $"Data Source={MiServidor.Servidor(errorConexion)}; Initial Catalog=GRUPO2; Integrated Security=SSPI; MultipleActiveResultSets=true; TrustServerCertificate=True"

        <Test>
        <Order(1)>
        Public Sub Insert_Ciclo()

            Dim conexion As New SqlConnection(cadConexion)

            Try
                conexion.Open()

                Dim sql As String = "INSERT INTO CICLOS VALUES(10000, 'CICLO PRUEBA')"
                Dim cmdAnadir As New SqlCommand(sql, conexion)
                Dim numFilas As Integer = cmdAnadir.ExecuteNonQuery()

                Assert.That(numFilas, NUnit.Framework.Is.EqualTo(1))

            Catch ex As Exception
                Assert.Fail(ex.Message)
            Finally
                conexion.Close()
            End Try

        End Sub

        <Test>
        <Order(2)>
        Public Sub Insert_Modulo()

            Dim conexion As New SqlConnection(cadConexion)

            Try
                conexion.Open()

                Dim sql As String = "INSERT INTO MODULOS (id_ciclo, id_modulo, MODULO) VALUES (10000,1, 'Administracion de Sistemas Operativos')"
                Dim cmdAnadir As New SqlCommand(sql, conexion)
                Dim numFilas As Integer = cmdAnadir.ExecuteNonQuery()

                Assert.That(numFilas, NUnit.Framework.Is.EqualTo(1))

            Catch ex As Exception
                Assert.Fail(ex.Message)
            Finally
                conexion.Close()
            End Try

        End Sub

        <Test>
        <Order(3)>
        Public Sub Insert_RA()

            Dim conexion As New SqlConnection(cadConexion)

            Try
                conexion.Open()

                Dim sql As String = "INSERT INTO RA (id_ra, id_modulo, id_ciclo, RA	) VALUES (1,1,10000, 'Administra sistemas operativos en red')"
                Dim cmdAnadir As New SqlCommand(sql, conexion)
                Dim numFilas As Integer = cmdAnadir.ExecuteNonQuery()

                Assert.That(numFilas, NUnit.Framework.Is.EqualTo(1))

            Catch ex As Exception
                Assert.Fail(ex.Message)
            Finally
                conexion.Close()
            End Try

        End Sub

        <Test>
        <Order(4)>
        Public Sub Insert_Alumno()

            Dim conexion As New SqlConnection(cadConexion)

            Try
                conexion.Open()

                Dim sql As String = "INSERT INTO ALUMNOS (DNI, NOMBRE, APELLIDO1, APELLIDO2, ID_CICLO) VALUES ('11111112L', 'AAA', 'BBB', 'CCC', 10000)"
                Dim cmdAnadir As New SqlCommand(sql, conexion)
                Dim numFilas As Integer = cmdAnadir.ExecuteNonQuery()

                Assert.That(numFilas, NUnit.Framework.Is.EqualTo(1))

            Catch ex As Exception
                Assert.Fail(ex.Message)
            Finally
                conexion.Close()
            End Try

        End Sub

        <Test>
        <Order(5)>
        Public Sub Insert_Jornada()

            Dim conexion As New SqlConnection(cadConexion)

            Try
                conexion.Open()

                Dim sql As String = "INSERT INTO JORNADAS (DNI, ID_JORNADA, HORAS, FECHA_ENTRADA, ESTADO) VALUES ('11111112L', 1, 8, GETDATE(), 'EN CURSO')"
                Dim cmdAnadir As New SqlCommand(sql, conexion)
                Dim numFilas As Integer = cmdAnadir.ExecuteNonQuery()

                Assert.That(numFilas, NUnit.Framework.Is.EqualTo(1))

            Catch ex As Exception
                Assert.Fail(ex.Message)
            Finally
                conexion.Close()
            End Try

        End Sub

        <Test>
        <Order(6)>
        Public Sub Insert_Tarea()

            Dim conexion As New SqlConnection(cadConexion)

            Try
                conexion.Open()

                Dim sql As String = "INSERT INTO TAREAS (DNI, ID_JORNADA, ID_TAREA, HORAS, DESCRIPCION) VALUES ('11111112L', 1, 1, 1, 'Analisis de requisitos')"
                Dim cmdAnadir As New SqlCommand(sql, conexion)
                Dim numFilas As Integer = cmdAnadir.ExecuteNonQuery()

                Assert.That(numFilas, NUnit.Framework.Is.EqualTo(1))

            Catch ex As Exception
                Assert.Fail(ex.Message)
            Finally
                conexion.Close()
            End Try

        End Sub

        <Test>
        <Order(7)>
        Public Sub Insert_Tarea_RA()

            Dim conexion As New SqlConnection(cadConexion)

            Try
                conexion.Open()

                Dim sql As String = "INSERT INTO TAREA_RA (ID_CICLO, ID_MODULO, ID_RA, DNI, ID_JORNADA, ID_TAREA) VALUES (10000, 1, 1, '11111112L', 1, 1)"
                Dim cmdAnadir As New SqlCommand(sql, conexion)
                Dim numFilas As Integer = cmdAnadir.ExecuteNonQuery()

                Assert.That(numFilas, NUnit.Framework.Is.EqualTo(1))

            Catch ex As Exception
                Assert.Fail(ex.Message)
            Finally
                conexion.Close()
            End Try

        End Sub

        <Test>
        <Order(8)>
        Public Sub DeleteAllData()

            Dim conexion As New SqlConnection(cadConexion)

            Try
                conexion.Open()

                Dim sql1 As String = "DELETE FROM TAREA_RA WHERE ID_CICLO = 10000"
                Dim cmdAnadir1 As New SqlCommand(sql1, conexion)
                Dim numFilas1 As Integer = cmdAnadir1.ExecuteNonQuery()

                Dim sql2 As String = "DELETE FROM RA WHERE ID_CICLO = 10000"
                Dim cmdAnadir2 As New SqlCommand(sql2, conexion)
                Dim numFilas2 As Integer = cmdAnadir2.ExecuteNonQuery()

                Dim sql3 As String = "DELETE FROM MODULOS WHERE ID_CICLO = 10000"
                Dim cmdAnadir3 As New SqlCommand(sql3, conexion)
                Dim numFilas3 As Integer = cmdAnadir3.ExecuteNonQuery()

                Dim sql4 As String = "DELETE FROM TAREAS WHERE DNI = '11111112L'"
                Dim cmdAnadir4 As New SqlCommand(sql4, conexion)
                Dim numFilas4 As Integer = cmdAnadir4.ExecuteNonQuery()

                Dim sql5 As String = "DELETE FROM JORNADAS WHERE DNI = '11111112L'"
                Dim cmdAnadir5 As New SqlCommand(sql5, conexion)
                Dim numFilas5 As Integer = cmdAnadir5.ExecuteNonQuery()

                Dim sql6 As String = "DELETE FROM ALUMNOS WHERE DNI = '11111112L'"
                Dim cmdAnadir6 As New SqlCommand(sql6, conexion)
                Dim numFilas6 As Integer = cmdAnadir6.ExecuteNonQuery()

                Dim sql7 As String = "DELETE FROM CICLOS WHERE ID_CICLO = 10000"
                Dim cmdAnadir7 As New SqlCommand(sql7, conexion)
                Dim numFilas7 As Integer = cmdAnadir7.ExecuteNonQuery()

                Assert.That(numFilas7, NUnit.Framework.Is.EqualTo(1))

            Catch ex As Exception
                Assert.Fail(ex.Message)
            Finally
                conexion.Close()
            End Try

        End Sub

    End Class

End Namespace