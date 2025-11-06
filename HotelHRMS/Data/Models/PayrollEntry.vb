Option Strict On
Option Explicit On

Namespace Data.Models

    Public Class PayrollEntry
        Public Property Id As Integer
        Public Property EmployeeId As Integer
        Public Property EmployeeName As String = String.Empty
        Public Property PayPeriodStart As Date
        Public Property PayPeriodEnd As Date
        Public Property BaseHoursWorked As Decimal
        Public Property OvertimeHours As Decimal
        Public Property BasePay As Decimal
        Public Property OvertimePay As Decimal
        Public Property GrossPay As Decimal
        Public Property TotalDeductions As Decimal
        Public Property NetPay As Decimal
        Public Property Taxes As Decimal
        Public Property GeneratedAt As Date = Date.UtcNow
        Public Property Notes As String = String.Empty

        Public Sub RecalculateTotals()
            GrossPay = BasePay + OvertimePay
            NetPay = Math.Round(GrossPay - TotalDeductions - Taxes, 2, MidpointRounding.AwayFromZero)
        End Sub
    End Class

End Namespace
