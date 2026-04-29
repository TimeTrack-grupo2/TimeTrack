Public Class FrmFichar


    Private Sub FrmFichar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()

        txtDNI.Text = alumno.Dni
        txtNombre.Text = alumno.Nombre & " " & alumno.Apellido1 & " " & alumno.Apellido2

        cmbCurso.SelectedValue = alumno.Id_ciclo

        txtDNI.ReadOnly = True
        txtNombre.ReadOnly = True
        cmbCurso.Enabled = False

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        lblFecha.Text = Today.ToString("dd/MM/yyyy")


    End Sub


End Class