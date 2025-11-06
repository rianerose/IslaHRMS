Option Strict On
Option Explicit On

Imports System.Collections.Generic
Imports System.Globalization
Imports System.IO
Imports System.Text
Imports System.Threading.Tasks
Imports CsvHelper
Imports CsvHelper.Configuration
Imports Data.Models

Namespace Utilities

    Public Class CsvExportService

        Public Shared Async Function ExportPayrollAsync(entries As IEnumerable(Of PayrollEntry), filePath As String) As Task
            Dim directory = Path.GetDirectoryName(filePath)
            If Not String.IsNullOrEmpty(directory) Then
                Directory.CreateDirectory(directory)
            End If

            Dim config As New CsvConfiguration(CultureInfo.InvariantCulture) With {
                .HasHeaderRecord = True,
                .Encoding = Encoding.UTF8,
                .TrimOptions = TrimOptions.Trim
            }

            Using writer As New StreamWriter(filePath, False, Encoding.UTF8)
                Using csv As New CsvWriter(writer, config)
                    csv.Context.RegisterClassMap(Of PayrollEntryMap)()
                    Await csv.WriteRecordsAsync(entries).ConfigureAwait(False)
                    Await writer.FlushAsync().ConfigureAwait(False)
                End Using
            End Using
        End Function

        Private Class PayrollEntryMap
            Inherits ClassMap(Of PayrollEntry)

            Public Sub New()
                Map(Function(e) e.EmployeeName).Name("Employee")
                Map(Function(e) e.PayPeriodStart).Name("Period Start").TypeConverterOption.Format("yyyy-MM-dd")
                Map(Function(e) e.PayPeriodEnd).Name("Period End").TypeConverterOption.Format("yyyy-MM-dd")
                Map(Function(e) e.BaseHoursWorked).Name("Base Hours")
                Map(Function(e) e.OvertimeHours).Name("OT Hours")
                Map(Function(e) e.BasePay).Name("Base Pay")
                Map(Function(e) e.OvertimePay).Name("OT Pay")
                Map(Function(e) e.GrossPay).Name("Gross Pay")
                Map(Function(e) e.Taxes).Name("Taxes")
                Map(Function(e) e.TotalDeductions).Name("Deductions")
                Map(Function(e) e.NetPay).Name("Net Pay")
                Map(Function(e) e.GeneratedAt).Name("Generated At").TypeConverterOption.Format("yyyy-MM-dd HH:mm")
                Map(Function(e) e.Notes).Name("Notes")
            End Sub
        End Class

    End Class

End Namespace
