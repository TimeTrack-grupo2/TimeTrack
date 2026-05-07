Imports System.Linq.Expressions
Imports Clases
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

        TimerRecargarJornadas_Tick(Nothing, Nothing)
    End Sub
    Private Sub TimerRecargarJornadas_Tick(sender As Object, e As EventArgs) Handles TimerRecargarJornadas.Tick
        Dim errorMensaje As String = ""

        gestionJornada = New gestionJornadas(errorMensaje)
        gestionTareas = New GestionTareas(errorMensaje)

        Dim tablaAlumnos As DataTable = gestionAlumno.ObtenerAlumnos(errorMensaje)
        Dim listaJornadas As List(Of Jornada) = gestionJornada.ObtenerJornadaOrdenadasPorDia()

        DataGridViewJornadas.Rows.Clear()

        For Each i As Jornada In listaJornadas

            Dim filas() As DataRow = tablaAlumnos.Select("DNI = '" & i.Dni & "'")

            Dim nombreCompleto As String = ""
            Dim alumnoActual As Alumno = New Alumno(i.Dni)

            If filas.Length > 0 Then
                Dim fila As DataRow = filas(0)

                nombreCompleto = fila("NOMBRE").ToString() & " " &
                             fila("APELLIDO1").ToString() & " " &
                             fila("APELLIDO2").ToString()
            End If

            Dim tablaTareas As DataTable = gestionTareas.BuscarTarea(alumnoActual, errorMensaje)

            Dim horasTareas As Integer = 0

            If tablaTareas IsNot Nothing Then
                For Each row As DataRow In tablaTareas.Rows
                    If row("ID_JORNADA") = i.ID_JORNADA Then
                        horasTareas += Convert.ToInt32(row("HORAS"))
                    End If
                Next
            End If

            Dim horasRestantes As Integer = i.HORAS - horasTareas

            DataGridViewJornadas.Rows.Add(
            nombreCompleto,
            i.FECHA_ENTRADA,
            horasRestantes,
            i.ESTADO
        )

        Next
    End Sub

    Private Sub DataGridViewJornadas_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewJornadas.CellContentClick

        If e.RowIndex >= 0 AndAlso DataGridViewJornadas.Columns(e.ColumnIndex).Name = "VerTareas" Then
            Dim frm As New FrmTarea()
            frm.Show()
        End If

    End Sub
End Class
