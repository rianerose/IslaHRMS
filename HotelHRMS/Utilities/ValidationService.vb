Option Strict On
Option Explicit On

Imports System.Collections.Generic
Imports System.Text.RegularExpressions
Imports Data.Models

Namespace Utilities

    Public Class ValidationService

        Public Shared ReadOnly Instance As New ValidationService()

        Private ReadOnly _emailRegex As New Regex("^[^@\s]+@[^@\s]+\.[^@\s]+$", RegexOptions.Compiled Or RegexOptions.IgnoreCase)
        Private ReadOnly _phoneRegex As New Regex("^[0-9\-\+\(\)\s]{6,20}$", RegexOptions.Compiled)

        Private Sub New()
        End Sub

        Public Function ValidateEmployee(employee As Employee) As ValidationSummary
            Dim errors As New Dictionary(Of String, String)(StringComparer.OrdinalIgnoreCase)

            If String.IsNullOrWhiteSpace(employee.EmployeeCode) Then
                errors("EmployeeCode") = "Employee code is required."
            End If
            If String.IsNullOrWhiteSpace(employee.FirstName) Then
                errors("FirstName") = "First name is required."
            End If
            If String.IsNullOrWhiteSpace(employee.LastName) Then
                errors("LastName") = "Last name is required."
            End If
            If Not String.IsNullOrWhiteSpace(employee.Email) AndAlso Not _emailRegex.IsMatch(employee.Email) Then
                errors("Email") = "Email address format is invalid."
            End If
            If Not String.IsNullOrWhiteSpace(employee.PhoneNumber) AndAlso Not _phoneRegex.IsMatch(employee.PhoneNumber) Then
                errors("PhoneNumber") = "Phone number format is invalid."
            End If
            If employee.BasicSalary < 0D Then
                errors("BasicSalary") = "Basic salary cannot be negative."
            End If

            Return New ValidationSummary(errors)
        End Function

        Public Function ValidateAttendance(record As AttendanceRecord) As ValidationSummary
            Dim errors As New Dictionary(Of String, String)(StringComparer.OrdinalIgnoreCase)

            If record.AttendanceDate = Date.MinValue Then
                errors("AttendanceDate") = "Attendance date is required."
            End If

            If record.CheckInTime.HasValue AndAlso record.CheckOutTime.HasValue Then
                If record.CheckOutTime.Value < record.CheckInTime.Value Then
                    errors("CheckOutTime") = "Check-out time cannot be earlier than check-in time."
                End If
            End If

            Return New ValidationSummary(errors)
        End Function

    End Class

    Public Class ValidationSummary
        Public ReadOnly Property Errors As IReadOnlyDictionary(Of String, String)

        Public Sub New(errors As IDictionary(Of String, String))
            Me.Errors = New Dictionary(Of String, String)(errors)
        End Sub

        Public ReadOnly Property IsValid As Boolean
            Get
                Return Errors.Count = 0
            End Get
        End Property

        Public Sub ApplyTo(errorProvider As System.Windows.Forms.ErrorProvider, controlMap As IDictionary(Of String, System.Windows.Forms.Control))
            For Each pair In controlMap
                errorProvider.SetError(pair.Value, String.Empty)
            Next

            For Each errorItem In Errors
                If controlMap.ContainsKey(errorItem.Key) Then
                    errorProvider.SetError(controlMap(errorItem.Key), errorItem.Value)
                End If
            Next
        End Sub
    End Class

End Namespace
