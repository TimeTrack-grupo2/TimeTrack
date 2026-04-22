Public Class Alumno
    Implements IEquatable(Of Alumno)

    Public Property Nombre As String
    Public Property Apellido1 As String
    Public Property Apellido2 As String
    Public Property Dni As String
    Public Property Id_ciclo As Integer
    Public Sub New()
    End Sub

    Public Sub New(dni As String)
        Me.Dni = dni
    End Sub

    Public Sub New(dni As String, nombre As String, apellido1 As String, apellido2 As String, id_ciclo As Integer)
        Me.Dni = dni
        Me.Nombre = nombre
        Me.Apellido1 = apellido1
        Me.Apellido2 = apellido2
        Me.Id_ciclo = id_ciclo
    End Sub

    Public Overrides Function Equals(obj As Object) As Boolean
        Return Equals(TryCast(obj, Alumno))
    End Function

    Public Overloads Function Equals(other As Alumno) As Boolean Implements IEquatable(Of Alumno).Equals
        Return other IsNot Nothing AndAlso
               Dni.ToUpper = other.Dni.ToUpper
    End Function

    Public Overrides Function GetHashCode() As Integer
        Dim hashCode As Long = -1758108069
        hashCode = (hashCode * -1521134295 + EqualityComparer(Of String).Default.GetHashCode(Dni)).GetHashCode()
        Return hashCode
    End Function

    Public Shared Operator =(left As Alumno, right As Alumno) As Boolean
        Return EqualityComparer(Of Alumno).Default.Equals(left, right)
    End Operator

    Public Shared Operator <>(left As Alumno, right As Alumno) As Boolean
        Return Not left = right
    End Operator

End Class
