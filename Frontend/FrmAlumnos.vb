Imports Clases
Imports Gestion

Public Class FrmAlumnos
    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click

        If String.IsNullOrWhiteSpace(txtNombre.Text) Then
            MessageBox.Show("El nombre no puede estar vacío.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtNombre.Focus()
            Return
        End If

        If String.IsNullOrWhiteSpace(txtApellido.Text) Then
            MessageBox.Show("El apellido no puede estar vacío.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtNombre.Focus()
            Return
        End If

        If String.IsNullOrWhiteSpace(txtDNI.Text) Then
            MessageBox.Show("El DNI no puede estar vacío.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtDNI.Focus()
            Return
        End If

        Dim regexDNI As New System.Text.RegularExpressions.Regex("^\d{8}[A-Za-z]$")
        If Not regexDNI.IsMatch(txtDNI.Text.Trim()) Then
            MessageBox.Show("El DNI debe tener 8 números seguidos de una letra (Ej: 12345678A).", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtDNI.Focus()
            Return
        End If

        Dim errorConexion As String = ""
        Dim gestor As New gestionAlumno(errorConexion)

        If Not String.IsNullOrEmpty(errorConexion) Then
            MessageBox.Show($"Error de conexión: {errorConexion}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Dim mensajeCiclo As String = ""
        Dim ciclo As Ciclos = TryCast(cboCiclos.SelectedItem, Ciclos)

        If ciclo Is Nothing Then
            MessageBox.Show("Debes seleccionar un ciclo.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            cboCiclos.Focus()
            Return
        End If

        Dim idCiclo As Integer = ciclo.Id_ciclo

        If Not String.IsNullOrEmpty(mensajeCiclo) Then
            MessageBox.Show(mensajeCiclo, "Error en Ciclo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            cboCiclos.Focus()
            Return
        End If

        Dim alumno As New Alumno()
        alumno.Nombre = txtNombre.Text.Trim()
        alumno.Apellido1 = txtApellido.Text.Trim()
        alumno.Apellido2 = txtApellido2.Text.Trim()
        alumno.Id_ciclo = idCiclo
        alumno.Dni = txtDNI.Text.Trim().ToUpper()

        Dim resultado As String = gestor.AñadirAlumno(alumno)



        If resultado.Contains("con exito") Then
            LimpiarFormulario()
            CargarDatosGrid()
        Else
            MessageBox.Show(resultado, "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If

    End Sub

    Private Sub CargarDatosGrid()
        Dim errorConexion As String = ""
        Dim gestor As New GestionAlumno(errorConexion)

        If Not String.IsNullOrEmpty(errorConexion) Then
            MessageBox.Show($"Error de conexión: {errorConexion}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If
        Dim errorMensaje As String = ""
        Dim tabla As DataTable = gestor.ObtenerAlumnos(errorMensaje)

        If Not String.IsNullOrEmpty(errorMensaje) Then
            MessageBox.Show($"Error al obtener alumnos: {errorMensaje}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Dim tablaHoras As DataTable = gestor.ObtenerDiasYHorasAlumnos(errorMensaje)

        tabla.Columns.Add("DIAS_TRABAJADOS", GetType(Integer))
        tabla.Columns.Add("HORAS_TOTALES", GetType(Double))

        For Each fila As DataRow In tabla.Rows

            Dim dni As String = fila("DNI").ToString()

            Dim resultado() As DataRow =
        tablaHoras.Select("DNI = '" & dni & "'")

            If resultado.Length > 0 Then
                fila("DIAS_TRABAJADOS") = resultado(0)("DIAS_TRABAJADOS")
                fila("HORAS_TOTALES") = resultado(0)("HORAS_TOTALES")
            Else
                fila("DIAS_TRABAJADOS") = 0
                fila("HORAS_TOTALES") = 0
            End If

        Next

        DataGridViewAlumnos.DataSource = Nothing
        DataGridViewAlumnos.DataSource = tabla
    End Sub
    Private Sub LimpiarFormulario()
        txtNombre.Text = ""
        txtApellido.Text = ""
        txtApellido2.Text = ""
        cboCiclos.Text = ""
        txtDNI.Text = ""
        txtNombre.Focus()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarDatosGrid()
        Dim ciclos = gestionAlumno.Ciclos
        For Each ciclo In ciclos
            cboCiclos.Items.Add(ciclo)
        Next
        cboCiclos.DisplayMember = "NombreCiclo"
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewAlumnos.CellClick
        If e.RowIndex >= 0 Then
            Dim fila As DataGridViewRow = DataGridViewAlumnos.Rows(e.RowIndex)
            Dim dniSeleccionado As String = fila.Cells(0).Value.ToString()

            txtDNI.Text = dniSeleccionado
        End If
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If gestionAlumno.ComprobarDatosAlumno(txtDNI.Text) Then
            Dim resultado As DialogResult
            resultado = MessageBox.Show("¿Estás seguro de que quieres eliminar el alumno?" + " Ya que tiene jornadas y tareas", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

            If resultado = DialogResult.No Then Exit Sub
        End If
        Dim mensaje As String = ""
        mensaje = gestionAlumno.EliminarAlumno(txtDNI.Text)
        If mensaje.Contains("Alumno eliminado correctamente.") Then
            CargarDatosGrid()
            txtDNI.Text = ""
        Else
            MessageBox.Show(mensaje, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If



    End Sub


End Class
