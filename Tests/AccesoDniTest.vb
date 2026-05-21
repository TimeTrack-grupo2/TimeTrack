Imports NUnit.Framework
Imports NUnit.Framework.Constraints
Imports Gestion

Namespace Tests

    <TestFixture>
    Public Class AccesoDniTest

        Private gestionAlumno As GestionAlumno

        <SetUp>
        Public Sub Setup()

            Dim mensaje As String = ""
            gestionAlumno = New GestionAlumno(mensaje)

        End Sub

        <Test>
        Public Sub LogIn_DniCorrecto_DevuelveAlumno()

            Dim mensaje As String = ""

            Dim resultado = gestionAlumno.LogIn("12345678Z", mensaje)

            Assert.That(resultado, NUnit.Framework.Is.EqualTo(GestionAlumno.TipoLogin.Alumno))

        End Sub

        <Test>
        Public Sub LogIn_DniIncorrecto_DevuelveIncorrecto()

            Dim mensaje As String = ""

            Dim resultado = gestionAlumno.LogIn("AAAA", mensaje)

            Assert.That(resultado, NUnit.Framework.Is.EqualTo(GestionAlumno.TipoLogin.Incorrecto))

        End Sub

    End Class

End Namespace