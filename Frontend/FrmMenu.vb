Imports Gestion

Public Class FrmMenu


    Private Sub btnDatos_Click(sender As Object, e As EventArgs) Handles btnDatos.Click
        If logIn = GestionAlumno.TipoLogin.Administrador Then
            Dim f1 As New FrmAlumnos
            f1.ShowDialog()
        Else
            MessageBox.Show("No eres administrador de la aplicación.")
        End If
    End Sub

    Private Sub btnFichar_Click(sender As Object, e As EventArgs) Handles btnFichar.Click
        Dim f2 As New FrmFichar
        f2.ShowDialog()

    End Sub
End Class
