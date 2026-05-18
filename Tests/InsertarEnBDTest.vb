Imports BuscarServidor
Imports Clases
Imports Gestion
Imports Microsoft.Data.SqlClient
Imports NUnit.Framework
Imports NUnit.Framework.Constraints

Namespace Tests

    <TestFixture>
    Public Class InsertarEnBDTest

        Private errorConexion As String = ""
        Private cadConexion As String = $"Data Source = {MiServidor.Servidor(errorConexion)}; Initial Catalog = GRUPO2; Integrated Security = SSPI; MultipleActiveResultSets=true"

        <Test>
        Public Sub Insert_Ciclos()

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


    End Class

End Namespace