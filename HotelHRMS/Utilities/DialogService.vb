Option Strict On
Option Explicit On

Imports System.IO
Imports System.Text
Imports System.Threading.Tasks
Imports System.Windows.Forms

Namespace Utilities

    Public NotInheritable Class DialogService

        Private Shared ReadOnly _instance As New Lazy(Of DialogService)(Function() New DialogService(), Threading.LazyThreadSafetyMode.ExecutionAndPublication)
        Private ReadOnly _logDirectory As String
        Private ReadOnly _logFile As String

        Private Sub New()
            _logDirectory = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "HotelHRMS", "Logs")
            _logFile = Path.Combine(_logDirectory, $"log_{Date.Today:yyyyMMdd}.txt")
        End Sub

        Public Shared ReadOnly Property Instance As DialogService
            Get
                Return _instance.Value
            End Get
        End Property

        Public Sub ShowInfo(message As String, Optional caption As String = "Information")
            MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Sub

        Public Sub ShowError(message As String, Optional exception As Exception = Nothing, Optional caption As String = "Error")
            LogError(message, exception)
            Dim fullMessage = If(exception Is Nothing, message, $"{message}{Environment.NewLine}{exception.Message}")
            MessageBox.Show(fullMessage, caption, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Sub

        Public Sub ShowWarning(message As String, Optional caption As String = "Warning")
            LogWarning(message)
            MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Sub

        Public Function AskConfirmation(message As String, Optional caption As String = "Confirm") As Boolean
            Return MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = DialogResult.Yes
        End Function

        Public Async Function ExecuteWithBusyIndicatorAsync(form As Form, operation As Func(Of Task)) As Task
            Try
                form.UseWaitCursor = True
                form.Enabled = False
                Await operation().ConfigureAwait(False)
            Catch ex As Exception
                ShowError("An error occurred while running the operation.", ex)
            Finally
                form.Invoke(Sub()
                                form.UseWaitCursor = False
                                form.Enabled = True
                            End Sub)
            End Try
        End Function

        Public Sub LogInfo(message As String)
            WriteLog("INFO", message)
        End Sub

        Public Sub LogWarning(message As String)
            WriteLog("WARN", message)
        End Sub

        Public Sub LogError(message As String, Optional exception As Exception = Nothing)
            Dim formatted = If(exception Is Nothing, message, $"{message}{Environment.NewLine}{exception}")
            WriteLog("ERROR", formatted)
        End Sub

        Private Sub WriteLog(level As String, message As String)
            Try
                If Not Directory.Exists(_logDirectory) Then
                    Directory.CreateDirectory(_logDirectory)
                End If

                Dim line = $"[{Date.Now:yyyy-MM-dd HH:mm:ss}] [{level}] {message}"
                SyncLock _instance
                    File.AppendAllText(_logFile, line & Environment.NewLine, Encoding.UTF8)
                End SyncLock
            Catch
                ' Swallow logging errors
            End Try
        End Sub

    End Class

End Namespace
