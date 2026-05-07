Imports Clases
Imports Gestion

Public Class FrmAlumnos
    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click

        ' Validación: Nombre no vacío
        If String.IsNullOrWhiteSpace(txtNombre.Text) Then
            MessageBox.Show("El nombre no puede estar vacío.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtNombre.Focus()
            Return
        End If

        ' Validación: DNI no vacío
        If String.IsNullOrWhiteSpace(txtDNI.Text) Then
            MessageBox.Show("El DNI no puede estar vacío.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtDNI.Focus()
            Return
        End If

        ' Validación: formato DNI (8 números + 1 letra)
        Dim regexDNI As New System.Text.RegularExpressions.Regex("^\d{8}[A-Za-z]$")
        If Not regexDNI.IsMatch(txtDNI.Text.Trim()) Then
            MessageBox.Show("El DNI debe tener 8 números seguidos de una letra (Ej: 12345678A).", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtDNI.Focus()
            Return
        End If

        ' Instanciar gestionAlumno
        Dim errorConexion As String = ""
        Dim gestor As New gestionAlumno(errorConexion)

        If Not String.IsNullOrEmpty(errorConexion) Then
            MessageBox.Show($"Error de conexión: {errorConexion}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Obtener el ID del ciclo a partir del nombre escrito
        Dim mensajeCiclo As String = ""
        Dim ciclo As Ciclos = TryCast(cboCiclos.SelectedItem, Ciclos)
        Dim idCiclo As Integer = ciclo.Id_ciclo

        If Not String.IsNullOrEmpty(mensajeCiclo) Then
            MessageBox.Show(mensajeCiclo, "Error en Ciclo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            cboCiclos.Focus()
            Return
        End If

        ' Crear objeto Alumno
        Dim alumno As New Alumno()
        alumno.Nombre = txtNombre.Text.Trim()
        alumno.Apellido1 = txtApellido.Text.Trim()
        alumno.Apellido2 = txtApellido2.Text.Trim()
        alumno.Id_ciclo = idCiclo  ' Usamos el ID obtenido de la BD
        alumno.Dni = txtDNI.Text.Trim().ToUpper()

        ' Llamar a AñadirAlumno
        Dim resultado As String = gestor.AñadirAlumno(alumno)

        MessageBox.Show(resultado, "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information)

        ' Si se añadió con éxito, limpiar y recargar la tabla
        If resultado.Contains("con exito") Then
            LimpiarFormulario()
            CargarDatosGrid()
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

        DataGridView1.DataSource = Nothing  ' <- Limpia cualquier enlace previo
        DataGridView1.DataSource = tabla
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
        Dim ciclos = gestionAlumno.ciclos
        For Each ciclo In ciclos
            cboCiclos.Items.Add(ciclo)
        Next
        cboCiclos.DisplayMember = "NombreCiclo"
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        If e.RowIndex >= 0 Then
            Dim fila As DataGridViewRow = DataGridView1.Rows(e.RowIndex)
            Dim dniSeleccionado As String = fila.Cells(0).Value.ToString()

            ' Guardarlo en una variable global o textbox
            txtDNI.Text = dniSeleccionado
        End If
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If gestionAlumno.ComprobarDatosAlumno(txtDNI.Text) Then
            Dim resultado As DialogResult
            resultado = MessageBox.Show("¿Estás seguro de que quieres eliminar el alumno?",
                                "Confirmar eliminación",
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Warning)
            If resultado = DialogResult.No Then Exit Sub
        End If
        MessageBox.Show(gestionAlumno.EliminarAlumno(txtDNI.Text))
        CargarDatosGrid()

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class
