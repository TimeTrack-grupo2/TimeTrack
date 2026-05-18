Imports NUnit.Framework
Imports Gestion
Imports System.Data.SqlClient

Namespace Tests
    <TestFixture>
    Public Class ConexionTests

        Private gestionBD As BuscarServidor

        <SetUp>
        Public Sub Setup()
            Dim msg As String = ""

            gestionBD = New GestionAlumno(msg)
        End Sub

        <Test>
        Public Sub BaseDatos_DebeEncontrarServidorYConectar()

            Dim errorServidor As String = ""

            Dim servidorDetectado As String = gestionBD.BuscarServidor(errorServidor)

            Assert.That(servidorDetectado, [Is].Not.Null.And.Not.Empty,
                $"No se encontró ningún servidor SQL activo. Último error: {errorServidor}")

            Assert.That(errorServidor, [Is].Empty, $"Hubo un error en el proceso de búsqueda: {errorServidor}")
        End Sub

        <Test>
        Public Sub Consulta_CargaDatosDeGrupo2_TrasConectar()

            Dim mensaje As String = ""
            'login de prueba 
            Dim resultado = gestionBD.LogIn("12345678Z", mensaje)

            Assert.That(mensaje, [Is].Not.Contains("network-related"),
                "Error de red al intentar consultar la base de datos GRUPO2.")
        End Sub
    End Class
End Namespace