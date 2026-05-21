Imports Clases
Imports Gestion

Public Class FrmCiclos

    Private Sub FrmCiclos_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim errorConexion As String = ""
        gestionCiclos = New GestionCiclos(errorConexion)
        Dim errorMensaje As String = ""

        Dim tablaCiclos As DataTable = gestionCiclos.ObtenerCiclos(errorMensaje)

        If errorMensaje <> "" Then
            MessageBox.Show(errorMensaje)
            Exit Sub
        End If

        cboCiclo.DataSource = tablaCiclos
        cboCiclo.DisplayMember = "NOMBRECICLO"
        cboCiclo.ValueMember = "ID_CICLO"

        cboCiclo.SelectedIndex = -1

        cboModulo.DataSource = Nothing
        cboModulo.Items.Clear()

        CargarDataGrid()
    End Sub

    Private Sub cboCiclo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboCiclo.SelectedIndexChanged
        Dim errorConexion As String = ""
        gestionCiclos = New GestionCiclos(errorConexion)
        If cboCiclo.SelectedIndex = -1 Then Exit Sub

        Dim errorMensaje As String = ""

        cboModulo.DataSource = Nothing
        cboModulo.Items.Clear()
        cboModulo.Text = ""

        Dim filaSeleccionada As DataRowView = CType(cboCiclo.SelectedItem, DataRowView)
        Dim idCiclo As Integer = CInt(filaSeleccionada("ID_CICLO"))

        Dim tablaModulos As DataTable = gestionCiclos.ObtenerModulosPorCiclo(idCiclo, errorMensaje)

        If errorMensaje <> "" Then
            MessageBox.Show(errorMensaje)
            Exit Sub
        End If

        cboModulo.DataSource = tablaModulos
        cboModulo.DisplayMember = "MODULO"
        cboModulo.ValueMember = "ID_MODULO"

        cboModulo.SelectedIndex = -1

        CargarDataGrid()
    End Sub

    Private Sub cboModulo_SelectedIndexChanged(sender As Object, e As EventArgs) 
        If cboModulo.SelectedIndex = -1 Then Exit Sub

        Dim filaSeleccionada As DataRowView = CType(cboModulo.SelectedItem, DataRowView)

        Dim idModulo As Integer = CInt(filaSeleccionada("ID_MODULO"))
        Dim nombreModulo As String = filaSeleccionada("MODULO").ToString()

        CargarDataGrid()
    End Sub

    Private Sub cboCiclo_TextChanged(sender As Object, e As EventArgs) Handles cboCiclo.TextChanged
        cboModulo.DataSource = Nothing
        cboModulo.Items.Clear()
        cboModulo.Text = ""
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Dim errorConexion As String = ""
        gestionCiclos = New GestionCiclos(errorConexion)

        If errorConexion <> "" Then
            MessageBox.Show(errorConexion)
            Exit Sub
        End If

        Dim nombreCiclo As String = cboCiclo.Text.Trim()
        Dim nombreModulo As String = cboModulo.Text.Trim()

        If nombreCiclo = "" Then
            MessageBox.Show("Introduce un nombre para el ciclo.")
            Exit Sub
        End If

        Dim idCiclo As Integer = -1

        Dim mensajeCiclo As String = gestionCiclos.AnadirCiclo(nombreCiclo)

        Dim errorMensaje As String = ""
        Dim tablaCiclos As DataTable = gestionCiclos.ObtenerCiclos(errorMensaje)

        If errorMensaje <> "" Then
            MessageBox.Show(errorMensaje)
            Exit Sub
        End If

        For Each fila As DataRow In tablaCiclos.Rows
            If fila("NOMBRECICLO").ToString().Trim().ToLower() = nombreCiclo.ToLower() Then
                idCiclo = CInt(fila("ID_CICLO"))
                Exit For
            End If
        Next

        If idCiclo = -1 Then
            MessageBox.Show("No se pudo obtener el ciclo.")
            Exit Sub
        End If

        If mensajeCiclo <> "" AndAlso
       Not mensajeCiclo.ToLower().Contains("éxito") AndAlso
       Not mensajeCiclo.ToLower().Contains("existe") Then

            MessageBox.Show(mensajeCiclo)
            Exit Sub
        End If

        If nombreModulo <> "" Then
            Dim mensajeModulo As String =
            gestionCiclos.AnadirModulo(idCiclo, nombreModulo)

            If mensajeModulo <> "" AndAlso
           Not mensajeModulo.ToLower().Contains("éxito") Then

                MessageBox.Show(mensajeModulo)
                Exit Sub
            End If
        End If

        FrmCiclos_Load(Nothing, Nothing)

        cboCiclo.Text = nombreCiclo

        cboCiclo_SelectedIndexChanged(Nothing, Nothing)

        cboModulo.Text = ""
    End Sub

    Private Sub CargarDataGrid()
        Dim errorConexion As String = ""
        gestionCiclos = New GestionCiclos(errorConexion)

        If errorConexion <> "" Then
            MessageBox.Show(errorConexion)
            Exit Sub
        End If

        Dim errorMensaje As String = ""
        Dim tabla As DataTable

        If cboCiclo.SelectedIndex = -1 Then
            tabla = gestionCiclos.ObtenerHorasCiclos(errorMensaje)
        Else
            Dim filaSeleccionada As DataRowView =
                CType(cboCiclo.SelectedItem, DataRowView)

            Dim idCiclo As Integer =
                CInt(filaSeleccionada("ID_CICLO"))

            tabla = gestionCiclos.ObtenerHorasModulos(idCiclo, errorMensaje)
        End If

        If errorMensaje <> "" Then
            MessageBox.Show(errorMensaje)
            Exit Sub
        End If

        DataGridViewCiclos.DataSource = tabla
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        cboCiclo.SelectedIndex = -1
        cboCiclo.Text = ""

        cboModulo.SelectedIndex = -1
        cboModulo.Text = ""

        cboModulo.DataSource = Nothing
        cboModulo.Items.Clear()

        CargarDataGrid()
    End Sub

    Private Sub DataGridViewCiclos_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewCiclos.CellDoubleClick
        If e.RowIndex < 0 Then Exit Sub

        If cboCiclo.SelectedIndex <> -1 Then Exit Sub

        Dim nombreCiclo As String =
        DataGridViewCiclos.Rows(e.RowIndex).Cells("Nombre").Value.ToString()

        For i As Integer = 0 To cboCiclo.Items.Count - 1
            Dim fila As DataRowView =
            CType(cboCiclo.Items(i), DataRowView)

            If fila("NOMBRECICLO").ToString() = nombreCiclo Then
                cboCiclo.SelectedIndex = i
                Exit For
            End If
        Next
    End Sub

End Class