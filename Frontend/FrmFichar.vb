Imports Clases
Imports Gestion

Public Class FrmFichar


    Private Sub FrmFichar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TimerFecha.Start()
        If logIn <> GestionAlumno.TipoLogin.Administrador Then
            txtDNI.Text = alumno.Dni
            txtNombre.Text = alumno.Nombre & " " & alumno.Apellido1 & " " & alumno.Apellido2
        End If

        Dim fila As DataRow = gestionAlumno.ObtenerAlumnoPorDni(alumno.Dni)

        If fila IsNot Nothing Then
            txtDNI.Text = fila("DNI").ToString()
            txtNombre.Text = fila("NOMBRE").ToString() & " " &
                             fila("APELLIDO1").ToString() & " " &
                             fila("APELLIDO2").ToString()
            txtCurso.Text = fila("NOMBRECICLO").ToString()
        End If

        txtDNI.ReadOnly = True
        txtNombre.ReadOnly = True
        txtCurso.Enabled = False

        If logIn = GestionAlumno.TipoLogin.Administrador Then

            btnEntrada.Location = New Point(80, btnEntrada.Location.Y + 100)

            Dim calendario As New MonthCalendar()

            calendario.Location = New Point(250, 60)
            calendario.MaxSelectionCount = 1

            calendario.Name = "calendario"

            Me.Controls.Add(calendario)

            Dim horaPicker As New DateTimePicker()

            horaPicker.Format = DateTimePickerFormat.Time
            horaPicker.ShowUpDown = True

            horaPicker.Size = New Size(100, 30)
            horaPicker.Location = New Point(calendario.Left + (calendario.Width - horaPicker.Width) \ 2, 230)

            horaPicker.Name = "horaPicker"

            Me.Controls.Add(horaPicker)


            Dim cbo As New ComboBox()

            cbo.Location = txtNombre.Location
            cbo.Size = txtNombre.Size
            cbo.Name = "cboAlumno"
            cbo.DropDownStyle = ComboBoxStyle.DropDownList

            Me.Controls.Add(cbo)

            Me.Controls.Remove(txtNombre)
            txtNombre.Dispose()

            Dim errorMensaje As String = ""

            Dim tabla As DataTable = gestionAlumno.ObtenerAlumnos(errorMensaje)

            For Each filaNombre As DataRow In tabla.Rows
                filaNombre("NOMBRE") = filaNombre("NOMBRE").ToString() & " " &
                     filaNombre("APELLIDO1").ToString() & " " &
                     filaNombre("APELLIDO2").ToString()
            Next

            cbo.DataSource = tabla
            cbo.DisplayMember = "NOMBRE"
            cbo.ValueMember = "DNI"
            AddHandler cbo.SelectedIndexChanged, AddressOf cboAlumno_SelectedIndexChanged
            cboAlumno_SelectedIndexChanged(cbo, Nothing)

        End If

    End Sub

    Private Sub cboAlumno_SelectedIndexChanged(sender As Object, e As EventArgs)

        Dim cbo As ComboBox = TryCast(sender, ComboBox)

        If cbo IsNot Nothing AndAlso cbo.SelectedItem IsNot Nothing Then

            Dim fila As DataRowView = TryCast(cbo.SelectedItem, DataRowView)

            If fila IsNot Nothing Then
                txtDNI.Text = fila("DNI").ToString()
                txtCurso.Text = fila("CICLO").ToString()
            End If

        End If

        Dim tabla As DataTable = gestionJornada.ObtenerJornadasAlumno(txtDNI.Text)

        DataGridViewMovimientos.Rows.Clear()

        For Each fila As DataRow In tabla.Rows

            Dim fecha As DateTime = Convert.ToDateTime(fila("FECHA_ENTRADA"))

            Dim dia As String = fecha.ToString("dd/MM/yyyy")
            Dim hora As String = fecha.ToString("HH:mm")
            Dim horasJornada As Integer = Convert.ToInt32(fila("HORAS"))

            DataGridViewMovimientos.Rows.Add(dia, hora, horasJornada)

        Next

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles TimerFecha.Tick

        lblFecha.Text = Today.ToString("dd/MM/yyyy")


    End Sub

    Private Sub btnEntrada_Click(sender As Object, e As EventArgs) Handles btnEntrada.Click
        Dim dni As String = txtDNI.Text
        Dim horas As Integer

        If Integer.TryParse(txtHoras.Text, horas) = False Then
            MessageBox.Show("Introduce un número válido.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim jornada As Jornada = Nothing

        If logIn = GestionAlumno.TipoLogin.Administrador Then

            Dim calendario As MonthCalendar = TryCast(Me.Controls("calendario"), MonthCalendar)
            Dim horaPicker As DateTimePicker = TryCast(Me.Controls("horaPicker"), DateTimePicker)

            If calendario Is Nothing OrElse horaPicker Is Nothing Then
                MessageBox.Show("No se encontraron los controles.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            Dim fecha As Date = calendario.SelectionStart.Date
            Dim hora As Date = horaPicker.Value

            Dim fechaCompleta As DateTime = fecha.Add(hora.TimeOfDay)

            jornada = New Jornada(dni, 0, horas, fechaCompleta, "SIN EMPEZAR")

        Else

            jornada = New Jornada(dni, 0, horas, DateTime.Now, "SIN EMPEZAR")

        End If


        Dim errorConexion As String = ""
        Dim gestionJornada As New GestionJornadas(errorConexion)
        Dim resultado As String = gestionJornada.AnadirJornada(jornada)



        If resultado.Contains("con éxito") Then
            Dim fila As New DataGridViewRow()

            fila.CreateCells(DataGridViewMovimientos)

            fila.Cells(0).Value = jornada.FECHA_ENTRADA.ToString("dd/MM/yyyy")
            fila.Cells(1).Value = jornada.FECHA_ENTRADA.ToString("HH:mm")
            fila.Cells(2).Value = jornada.HORAS

            DataGridViewMovimientos.Rows.Add(fila)
        Else
            MessageBox.Show(resultado, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If

        Dim tablaJornadas As DataTable = gestionJornada.ObtenerJornadasAlumno(alumno.Dni)

        Dim menu As FrmMenu = CType(Application.OpenForms("FrmMenu"), FrmMenu)
        If menu IsNot Nothing Then
            menu.lblDias.Text = tablaJornadas.Rows.Count.ToString()
            Dim totalHoras As Integer = tablaJornadas.AsEnumerable().Sum(Function(r) Convert.ToInt32(r("HORAS")))
            menu.lblHoras.Text = totalHoras.ToString()
        End If

    End Sub

    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        Me.Close()
    End Sub

End Class