Imports BuscarServidor
Imports Clases
Imports Gestion
Imports Microsoft.Data.SqlClient
Imports NUnit.Framework

Namespace Tests

    <TestFixture>
    Public Class ObtenerAlumnoQueIniciaSesionTest

        Private errorConexion As String = ""
        Private cadConexion As String = $"Data Source={MiServidor.Servidor(errorConexion)}; Initial Catalog=GRUPO2; Integrated Security=SSPI; MultipleActiveResultSets=true; TrustServerCertificate=True"

        <OneTimeSetUp>
        Public Sub InsertarAlumnoPrueba()
            Dim conexion As New SqlConnection(cadConexion)
            Try
                conexion.Open()

                ' Primero eliminamos por si quedó de una ejecución anterior
                Dim sqlDelete As String = "DELETE FROM ALUMNOS WHERE DNI = '99999999Z'"
                Dim cmdDelete As New SqlCommand(sqlDelete, conexion)
                cmdDelete.ExecuteNonQuery()

                ' Ahora insertamos limpio
                Dim sqlInsert As String = "INSERT INTO ALUMNOS (DNI, NOMBRE, APELLIDO1, APELLIDO2, ID_CICLO) " &
                                  "VALUES ('99999999Z', 'TEST', 'APELLIDO1TEST', 'APELLIDO2TEST', 1)"
                Dim cmdInsert As New SqlCommand(sqlInsert, conexion)
                cmdInsert.ExecuteNonQuery()

            Catch ex As Exception
                Assert.Fail("Error en SetUp: " & ex.Message)
            Finally
                conexion.Close()
            End Try
        End Sub

        <OneTimeTearDown>
        Public Sub EliminarAlumnoPrueba()
            Dim conexion As New SqlConnection(cadConexion)
            Try
                conexion.Open()
                Dim sql As String = "DELETE FROM ALUMNOS WHERE DNI = '99999999Z'"
                Dim cmd As New SqlCommand(sql, conexion)
                cmd.ExecuteNonQuery()
            Finally
                conexion.Close()
            End Try
        End Sub

        <Test>
        <Order(1)>
        Public Sub ObtenerAlumno_DNIExistente_DevuelveAlumnoCorrecto()
            Dim gestion As New GestionAlumno(cadConexion)

            Dim resultado As Alumno = gestion.ObtenerAlumnoQueIniciaSesion("99999999Z")

            Assert.That(resultado, [Is].Not.Null)
            Assert.That(resultado.Dni, [Is].EqualTo("99999999Z"))
            Assert.That(resultado.Nombre, [Is].EqualTo("TEST"))
            Assert.That(resultado.Apellido1, [Is].EqualTo("APELLIDO1TEST"))
            Assert.That(resultado.Apellido2, [Is].EqualTo("APELLIDO2TEST"))
        End Sub

        <Test>
        <Order(2)>
        Public Sub ObtenerAlumno_DNIInexistente_DevuelveAlumnoVacio()
            Dim gestion As New GestionAlumno(cadConexion)

            Dim resultado As Alumno = gestion.ObtenerAlumnoQueIniciaSesion("00000000X")

            Assert.That(resultado, [Is].Not.Null)
            Assert.That(resultado.Dni, [Is].Null.Or.Empty)
        End Sub

        <Test>
        <Order(3)>
        Public Sub ObtenerAlumno_DNINulo_DevuelveNothing()
            Dim gestion As New GestionAlumno(cadConexion)

            Dim resultado As Alumno = gestion.ObtenerAlumnoQueIniciaSesion(Nothing)

            Assert.That(resultado Is Nothing OrElse String.IsNullOrEmpty(resultado.Dni), [Is].True)
        End Sub

        <Test>
        <Order(4)>
        Public Sub ObtenerAlumno_DNIExistente_IdCicloEsCorrecto()
            Dim gestion As New GestionAlumno(cadConexion)

            Dim resultado As Alumno = gestion.ObtenerAlumnoQueIniciaSesion("99999999Z")

            Assert.That(resultado, [Is].Not.Null)
            Assert.That(resultado.Id_ciclo, [Is].EqualTo(1))
        End Sub

    End Class

End Namespace
