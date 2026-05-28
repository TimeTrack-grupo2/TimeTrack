Imports System.Diagnostics.Eventing.Reader
Imports System.Linq.Expressions
Imports Clases
Imports Gestion

Public Class FrmMenu
    Private Sub btnDatos_Click(sender As Object, e As EventArgs) Handles btnDatos.Click
        If logIn = GestionAlumno.TipoLogin.Administrador Then
            Dim frm As New FrmAlumnos()
            frm.ShowDialog()
        Else
            MessageBox.Show("No eres administrador de la aplicación.")
        End If
    End Sub

    Private Sub btnFichar_Click(sender As Object, e As EventArgs) Handles btnFichar.Click
        Dim frm As New FrmFichar()
        frm.ShowDialog()
    End Sub

    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        FrmLogIn.Show()
        Me.Close()
    End Sub

    Private Sub FrmMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim listaJornadas As List(Of Jornada)

        If logIn = GestionAlumno.TipoLogin.Administrador Then
            lblNombre.Text = "Buenos días, ADMIN"

            listaJornadas = gestionJornada.ObtenerJornadaOrdenadasPorDia()

        Else

            lblBuscar.Hide()
            txtBuscarNombre.Hide()
            Dim fila As DataRow = gestionAlumno.ObtenerAlumnoPorDni(alumno.Dni)

            If fila IsNot Nothing Then
                alumno.Nombre = fila("NOMBRE").ToString()
                alumno.Apellido1 = fila("APELLIDO1").ToString()
                alumno.Apellido2 = fila("APELLIDO2").ToString()
            End If

            lblNombre.Text = "Buenos días, " & alumno.Nombre & " " & alumno.Apellido1

            listaJornadas = gestionJornada.ObtenerJornadaOrdenadasPorDia().
            Where(Function(j) j.Dni = alumno.Dni).
            ToList()
        End If

        lblDias.Text = listaJornadas.Count.ToString()

        Dim totalHoras As Integer = gestionJornada.ObtenerHorasTrabajadas(alumno.Nombre, alumno.Apellido1, alumno.Apellido2)

        lblHoras.Text = totalHoras.ToString()

        TimerRecargarJornadas_Tick(Nothing, Nothing)

    End Sub
    Private Sub TimerRecargarJornadas_Tick(sender As Object, e As EventArgs) Handles TimerRecargarJornadas.Tick
        Dim errorMensaje As String = ""

        gestionJornada = New GestionJornadas(errorMensaje)
        gestionTareas = New GestionTareas(errorMensaje)

        Dim tablaAlumnos As DataTable = gestionAlumno.ObtenerAlumnos(errorMensaje)
        Dim listaJornadas As List(Of Jornada)

        If logIn = GestionAlumno.TipoLogin.Administrador Then
            listaJornadas = gestionJornada.ObtenerJornadaOrdenadasPorDia()
        Else
            listaJornadas = gestionJornada.ObtenerJornadaOrdenadasPorDia() _
                        .Where(Function(j) j.Dni = alumno.Dni) _
                        .ToList()
            DataGridViewJornadas.Columns("NombreAlumno").Visible = False
        End If

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

            Dim tablaTareas As DataTable = gestionTareas.BuscarTarea(i.Dni, i.ID_JORNADA, errorMensaje)

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
                i.ID_JORNADA,
                i.Dni,
                nombreCompleto,
                i.FECHA_ENTRADA,
                horasRestantes,
                i.ESTADO
            )

        Next
    End Sub

    Private Sub DataGridViewJornadas_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewJornadas.CellClick

        If e.RowIndex >= 0 AndAlso DataGridViewJornadas.Columns(e.ColumnIndex).Name = "VerTareas" Then

            Dim idJornada As Integer = Convert.ToInt32(DataGridViewJornadas.Rows(e.RowIndex).Cells("ID_JORNADA").Value)
            Dim dni As String = DataGridViewJornadas.Rows(e.RowIndex).Cells("DNI").Value.ToString()

            Dim frm As New FrmTarea(dni, idJornada)
            frm.Show()

        End If

    End Sub

    Private Sub txtBuscarNombre_TextChanged(sender As Object, e As EventArgs) Handles txtBuscarNombre.TextChanged
        Dim texto As String = txtBuscarNombre.Text.Trim().ToLower()
        DataGridViewJornadas.CurrentCell = Nothing
        For Each fila As DataGridViewRow In DataGridViewJornadas.Rows
            If Not fila.IsNewRow Then
                Dim nombre As String = fila.Cells(2).Value.ToString().ToLower()
                fila.Visible = nombre.Contains(texto)
            End If
        Next
    End Sub

    Private Sub btnCiclos_Click(sender As Object, e As EventArgs) Handles btnCiclos.Click
        If logIn = GestionAlumno.TipoLogin.Administrador Then
            Dim frm As New FrmCiclos()
            frm.ShowDialog()
        Else
            MessageBox.Show("No eres administrador de la aplicación.")
        End If
    End Sub
End Class
