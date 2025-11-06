Option Strict On
Option Explicit On

Namespace Data.Models

    Public Structure PayPeriod
        Public Property StartDate As Date
        Public Property EndDate As Date

        Public Sub New(startDate As Date, endDate As Date)
            If endDate < startDate Then
                Throw New ArgumentException("Pay period end date cannot be earlier than start date.", NameOf(endDate))
            End If
            StartDate = startDate.Date
            EndDate = endDate.Date
        End Sub

        Public Overrides Function ToString() As String
            Return $"{StartDate:MMM dd, yyyy} - {EndDate:MMM dd, yyyy}"
        End Function
    End Structure

End Namespace
