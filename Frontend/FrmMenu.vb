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

            If filas.Length > 0 Then
                Dim fila As DataRow = filas(0)
                nombreCompleto = fila("NOMBRE").ToString() & " " &
                             fila("APELLIDO1").ToString() & " " &
                             fila("APELLIDO2").ToString()
            End If

            Dim listaTareas As List(Of Tarea) = gestionTareas.VerTareasPorPersona(i.Dni)

            Dim horasTareas As Integer = 0

            For Each t As Tarea In listaTareas
                If t.Id_Jornada = i.ID_JORNADA Then
                    horasTareas += t.Horas
                End If
            Next

            Dim horasRestantes As Integer = i.HORAS - horasTareas

            DataGridViewJornadas.Rows.Add(
            nombreCompleto,
            i.FECHA_ENTRADA,
            horasRestantes,
            i.ESTADO
        )

        Next
    End Sub

    Private Sub FrmMenu_Load(sender As Object, e As EventArgs) Handles Me.Load
        TimerRecargarJornadas.Interval = 10000
        TimerRecargarJornadas.Start()
        TimerRecargarJornadas_Tick(Nothing, Nothing)
    End Sub

    Private Sub DataGridViewJornadas_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewJornadas.CellContentClick

        If e.RowIndex < 0 Then Exit Sub

        If DataGridViewJornadas.Columns(e.ColumnIndex).Name = "VerTareas" Then

            Dim frm As New FrmTarea()
            frm.ShowDialog()

        End If

    End Sub
End Class
