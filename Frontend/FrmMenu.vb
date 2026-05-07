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

<<<<<<< HEAD
    Private Sub FrmMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim tablaJornadas As DataTable = gestionJornada.ObtenerJornadasAlumno(alumno.Dni)

        lblTitulo.Text = "Jornadas trabajadas — " & alumno.Nombre & " " & alumno.Apellido1 & " " & alumno.Apellido2

        lblDias.Text = tablaJornadas.Rows.Count.ToString()

        Dim totalHoras As Integer = tablaJornadas.AsEnumerable().Sum(Function(r) Convert.ToInt32(r("HORAS")))
        lblHoras.Text = totalHoras.ToString()

=======
    Private Sub TimerRecargarJornadas_Tick(sender As Object, e As EventArgs) Handles TimerRecargarJornadas.Tick
        Dim errorMensaje As String = ""

        gestionJornada = New gestionJornadas(errorMensaje)
        gestionTareas = New GestionTareas(errorMensaje)

        Dim tablaAlumnos As DataTable = gestionAlumno.ObtenerAlumnos(errorMensaje)
        Dim listaJornadas As List(Of Jornada) = gestionJornada.ObtenerJornadaOrdenadasPorDia()

        DataGridViewJornadas.Rows.Clear()

        For Each i As Jornada In listaJornadas

            ' Buscar alumno por DNI en la tabla
            Dim filas() As DataRow = tablaAlumnos.Select("DNI = '" & i.Dni & "'")

            Dim nombreCompleto As String = ""
            Dim alumnoActual As Alumno = Nothing

            If filas.Length > 0 Then
                Dim fila As DataRow = filas(0)

                nombreCompleto = fila("NOMBRE").ToString() & " " &
                             fila("APELLIDO1").ToString() & " " &
                             fila("APELLIDO2").ToString()

                ' 🔹 Creamos el objeto Alumno con el DNI
                alumnoActual = New Alumno(fila("DNI").ToString())
            Else
                ' Por si acaso no encuentra el alumno
                alumnoActual = New Alumno(i.Dni)
            End If

            ' 🔹 Ahora sí usamos tu método sin tocarlo
            Dim listaTareas As List(Of Tarea) = gestionTareas.BuscarTarea(alumnoActual)

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
>>>>>>> 3392bd4599d1646f4bb9ee1ce1901e69fb6333fb
    End Sub
End Class
