<TestClass()>
Public Class PU_ConexionBBDD

    Public Class ConexionBD

        Private _connectionString As String

        Public Sub New(connectionString As String)
            _connectionString = connectionString
        End Sub

        <TestMethod()>
        Public Function PruebaConexion() As Boolean
            Try
                Dim conn As New SqlClient.SqlConnection(_connectionString)
                conn.Open()
                conn.Close()
                Return True
            Catch ex As Exception
                Return False
            End Try
        End Function

        <TestMethod()>
        Public Function ObtenerConnectionString() As String
            Return _connectionString
        End Function

    End Class

End Class
