Public Class Ra
    Implements IEquatable(Of Ra)

    Public idCiclo As String
    Public idRa As String
    Public idModulo As String
    Public ra As String

    Public Sub New(idCiclo As String, idRa As String, idModulo As String, ra As String)
        Me.idCiclo = idCiclo
        Me.idRa = idRa
        Me.idModulo = idModulo
        Me.ra = ra
    End Sub

    Public Overrides Function Equals(obj As Object) As Boolean
        Return Equals(TryCast(obj, Ra))
    End Function

    Public Overloads Function Equals(other As Ra) As Boolean Implements IEquatable(Of Ra).Equals
        Return other IsNot Nothing AndAlso
               idCiclo = other.idCiclo AndAlso
               idRa = other.idRa AndAlso
               idModulo = other.idModulo
    End Function

    Public Overrides Function GetHashCode() As Integer
        Return (idCiclo, idRa, idModulo).GetHashCode()
    End Function

    Public Shared Operator =(left As Ra, right As Ra) As Boolean
        Return EqualityComparer(Of Ra).Default.Equals(left, right)
    End Operator

    Public Shared Operator <>(left As Ra, right As Ra) As Boolean
        Return Not left = right
    End Operator
End Class
