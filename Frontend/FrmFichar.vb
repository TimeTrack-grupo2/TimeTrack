Imports Clases
Imports Gestion

Public Class FrmFichar


    Private Sub FrmFichar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()

        txtDNI.Text = alumno.Dni
        txtNombre.Text = alumno.Nombre & " " & alumno.Apellido1 & " " & alumno.Apellido2

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

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        lblFecha.Text = Today.ToString("dd/MM/yyyy")


    End Sub

    Private Sub btnEntrada_Click(sender As Object, e As EventArgs) Handles btnEntrada.Click
        ' Los datos DNI, Nombre y Curso ya están cargados automáticamente
        Dim dni As String = txtDNI.Text
        Dim horas As Integer = CInt(txtHoras.Text)

        Dim jornada As New Jornada(dni, 0, horas, DateTime.Now, "EN CURSO")

        ' Llamar a AnadirJornada solo con la jornada
        Dim errorConexion As String = ""
        Dim gestionJornada As New GestionJornadas(errorConexion)
        Dim resultado As String = gestionJornada.AnadirJornada(jornada)

        MessageBox.Show(resultado, "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information)

        If resultado.Contains("con éxito") Then
            Dim fila As New DataGridViewRow()
            fila.CreateCells(DataGridViewMovimientos)
            fila.Cells(0).Value = DateTime.Now.ToShortDateString
            fila.Cells(1).Value = txtHoras.Text
            DataGridViewMovimientos.Rows.Add(fila)
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