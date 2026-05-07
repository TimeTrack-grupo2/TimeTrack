Imports System.Linq.Expressions
Imports Gestion

Public Class FrmMenu


    Private Sub btnDatos_Click(sender As Object, e As EventArgs) Handles btnDatos.Click
        If logIn = GestionAlumno.TipoLogin.Administrador Then
            FrmAlumnos.ShowDialog()
        Else
            MessageBox.Show("No eres administrador de la aplicación.")
        End If
    End Sub

    Private Sub btnFichar_Click(sender As Object, e As EventArgs) Handles btnFichar.Click
        FrmFichar.ShowDialog()

    End Sub

    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        FrmLogIn.Show()
        Me.Close()
    End Sub

    Private Sub btnTareas_Click(sender As Object, e As EventArgs) Handles btnTareas.Click
        FrmTarea.Show()
    End Sub

    Private Sub FrmMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim tablaJornadas As DataTable = gestionJornada.ObtenerJornadasAlumno(alumno.Dni)

        lblTitulo.Text = "Jornadas trabajadas — " & alumno.Nombre & " " & alumno.Apellido1 & " " & alumno.Apellido2

        lblDias.Text = tablaJornadas.Rows.Count.ToString()

        Dim totalHoras As Integer = tablaJornadas.AsEnumerable().Sum(Function(r) Convert.ToInt32(r("HORAS")))
        lblHoras.Text = totalHoras.ToString()

    End Sub
End Class
