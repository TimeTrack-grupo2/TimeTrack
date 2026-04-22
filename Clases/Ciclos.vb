Public Class Ciclos
    Public Property Id_ciclo As Integer
    Public Property NombreCiclo As String

    Public Sub New()

    End Sub
    Public Sub New(id_ciclo As Integer)
        Me.Id_ciclo = id_ciclo
    End Sub
    Public Sub New(id_ciclo As Integer, ciclo As String)
        Me.Id_ciclo = id_ciclo
        Me.NombreCiclo = ciclo
    End Sub
End Class
