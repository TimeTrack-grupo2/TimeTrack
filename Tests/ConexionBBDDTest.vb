Imports System.Data
Imports BuscarServidor
Imports Clases
Imports Gestion
Imports Microsoft.Data.SqlClient
Imports NUnit.Framework
Imports NUnit.Framework.Constraints

Namespace Tests

    <TestFixture>
    Public Class ConexionBBDDTest

        Private errorConexion As String = ""
        Private cadConexion As String = $"Data Source={MiServidor.Servidor(errorConexion)}; Initial Catalog=GRUPO2; Integrated Security=SSPI; MultipleActiveResultSets=true; TrustServerCertificate=True"

        <Test>
        Public Sub ConexionBBDD()

            Dim conexion As New SqlConnection(cadConexion)

            Try
                conexion.Open()

                Assert.That(conexion.State,
                    NUnit.Framework.Is.EqualTo(ConnectionState.Open))

            Catch ex As Exception
                Assert.Fail(ex.Message)

            Finally
                conexion.Close()
            End Try

        End Sub


    End Class

End Namespace