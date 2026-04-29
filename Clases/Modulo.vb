Public Class Modulo
    Implements IEquatable(Of Modulo)

    Public idCiclo As String
    Public idModulo As String
    Public modulo As String


    Public Sub New(idCiclo As String, idModulo As String, modulo As String)
        Me.idCiclo = idCiclo
        Me.idModulo = idModulo
        Me.modulo = modulo
    End Sub

    Public Overrides Function Equals(obj As Object) As Boolean
        Return Equals(TryCast(obj, Modulo))
    End Function

    Public Overloads Function Equals(other As Modulo) As Boolean Implements IEquatable(Of Modulo).Equals
        Return other IsNot Nothing AndAlso
               idCiclo = other.idCiclo AndAlso
               idModulo = other.idModulo
    End Function

    Public Overrides Function GetHashCode() As Integer
        Return (idCiclo, idModulo).GetHashCode()
    End Function

    Public Shared Operator =(left As Modulo, right As Modulo) As Boolean
        Return EqualityComparer(Of Modulo).Default.Equals(left, right)
    End Operator

    Public Shared Operator <>(left As Modulo, right As Modulo) As Boolean
        Return Not left = right
    End Operator
End Class
