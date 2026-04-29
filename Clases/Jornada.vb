Public Class Jornada
    Implements IEquatable(Of Jornada)

    Public Property Dni As String
    Public Property ID_JORNADA As String
    Public Property HORAS As Integer
    Public Property FECHA_ENTRADA As Date
    Public Property ESTADO As String

    Public Sub New(dni As String)
        Me.Dni = dni
    End Sub

    Public Sub New(dni As String, iD_JORNADA As String, hORAS As Integer, fECHA_ENTRADA As Date, eSTADO As String)
        Me.Dni = dni
        Me.ID_JORNADA = iD_JORNADA
        Me.HORAS = hORAS
        Me.FECHA_ENTRADA = fECHA_ENTRADA
        Me.ESTADO = eSTADO
    End Sub

    Public Overrides Function Equals(obj As Object) As Boolean
        Return Equals(TryCast(obj, Jornada))
    End Function

    Public Overloads Function Equals(other As Jornada) As Boolean Implements IEquatable(Of Jornada).Equals
        Return other IsNot Nothing AndAlso
               Dni.ToUpper = other.Dni.ToUpper

    End Function

    Public Overrides Function GetHashCode() As Integer
        Return (Dni, ID_JORNADA, HORAS, FECHA_ENTRADA, ESTADO).GetHashCode()
    End Function

    Public Shared Operator =(left As Jornada, right As Jornada) As Boolean
        Return EqualityComparer(Of Jornada).Default.Equals(left, right)
    End Operator

    Public Shared Operator <>(left As Jornada, right As Jornada) As Boolean
        Return Not left = right
    End Operator
End Class
