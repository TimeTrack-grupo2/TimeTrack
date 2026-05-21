Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports System.Data.SqlClient

<TestClass()>
Public Class BaseDatosTests

    <TestMethod()>
    Public Sub Test_VerificarConexion_Exitosa()
        Dim gestorBD As New BuscarServidor()

        Dim cadenaConexionValida As String = "Server=localhost;Database=GRUPO2;Trusted_Connection=True;"
        Dim estadoEsperado As String = "Open"

        Dim estadoReal As String = gestorBD.IntentarConectar(cadenaConexionValida)

        Assert.AreEqual(estadoEsperado, estadoReal)
    End Sub

End Class
