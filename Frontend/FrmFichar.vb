Public Class FrmFichar


    Private Sub FrmFichar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        lblFecha.Text = Today.ToString("dd/MM/yyyy")


    End Sub


End Class