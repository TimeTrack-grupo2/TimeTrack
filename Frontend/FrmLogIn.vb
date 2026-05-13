Imports Clases
Imports Gestion

Public Class FrmLogIn
    Private Sub btnacceder_Click(sender As Object, e As EventArgs) Handles btnacceder.Click
        Dim dniText As String = txtDni.Text
        Dim mensaje As String

        logIn = gestionAlumno.LogIn(dniText, mensaje)
        If logIn = GestionAlumno.TipoLogin.Incorrecto Then
            MessageBox.Show(mensaje)
        Else
            alumno = New Alumno(dniText)
            FrmMenu.Show()
        End If

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtDni.TextChanged

    End Sub

    Private Sub FrmLogIn_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim errorEnLaConexion As String = ""
        gestionAlumno = New GestionAlumno(errorEnLaConexion)
        gestionJornada = New GestionJornadas(errorEnLaConexion)
        If Not String.IsNullOrWhiteSpace(errorEnLaConexion) Then
            MessageBox.Show(errorEnLaConexion)
        End If


    End Sub
End Class
