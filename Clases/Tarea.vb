Public Class Tarea
    Implements IEquatable(Of Tarea)

    Public Property Dni As String
    Public Property Id_Jornada As Integer
    Public Property Id_Tarea As Integer
    Public Property Horas As Integer
    Public Property Descripcion As String

    Public Sub New()

    End Sub
    Public Sub New(dni As String, id_Jornada As Integer, id_Tarea As Integer, horas As Integer, descripcion As String)
        Me.Dni = dni
        Me.Id_Jornada = id_Jornada
        Me.Id_Tarea = id_Tarea
        Me.Horas = horas
        Me.Descripcion = descripcion
    End Sub

    Public Overrides Function Equals(obj As Object) As Boolean
        Return Equals(TryCast(obj, Tarea))
    End Function

    Public Overloads Function Equals(other As Tarea) As Boolean Implements IEquatable(Of Tarea).Equals
        Return other IsNot Nothing AndAlso
               Dni.ToUpper = other.Dni.ToUpper
    End Function

    Public Overrides Function GetHashCode() As Integer
        Return (Dni, Id_Jornada, Id_Tarea, Horas, Descripcion).GetHashCode()
    End Function

    Public Shared Operator =(left As Tarea, right As Tarea) As Boolean
        Return EqualityComparer(Of Tarea).Default.Equals(left, right)
    End Operator

    Public Shared Operator <>(left As Tarea, right As Tarea) As Boolean
        Return Not left = right
    End Operator
End Class
