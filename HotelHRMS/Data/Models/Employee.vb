Option Strict On
Option Explicit On

Namespace Data.Models

    Public Class Employee
        Public Property Id As Integer
        Public Property EmployeeCode As String = String.Empty
        Public Property FirstName As String = String.Empty
        Public Property LastName As String = String.Empty
        Public Property Email As String = String.Empty
        Public Property PhoneNumber As String = String.Empty
        Public Property Position As String = String.Empty
        Public Property Department As String = String.Empty
        Public Property HireDate As Date
        Public Property BasicSalary As Decimal
        Public Property IsActive As Boolean = True
        Public Property LastModified As Date = Date.UtcNow

        Public ReadOnly Property FullName As String
            Get
                Return $"{FirstName} {LastName}".Trim()
            End Get
        End Property

        Public Function Clone() As Employee
            Return CType(MemberwiseClone(), Employee)
        End Function

        Public Overrides Function ToString() As String
            Return $"{EmployeeCode} - {FullName}"
        End Function
    End Class

End Namespace
