Option Strict On
Option Explicit On

Namespace Data.Models

    Public Class AttendanceRecord
        Public Property Id As Integer
        Public Property EmployeeId As Integer
        Public Property AttendanceDate As Date
        Public Property CheckInTime As Date?
        Public Property CheckOutTime As Date?
        Public Property Notes As String = String.Empty
        Public Property CreatedAt As Date = Date.UtcNow
        Public Property UpdatedAt As Date = Date.UtcNow

        Public ReadOnly Property HoursWorked As Decimal
            Get
                If Not CheckInTime.HasValue OrElse Not CheckOutTime.HasValue Then
                    Return 0D
                End If

                Dim duration = CheckOutTime.Value - CheckInTime.Value
                If duration.TotalHours < 0 Then
                    Return 0D
                End If

                Return Math.Round(CDec(duration.TotalHours), 2, MidpointRounding.AwayFromZero)
            End Get
        End Property
    End Class

End Namespace
