Option Strict On
Option Explicit On

Namespace My
    Partial Friend Class MyApplication

        Private ReadOnly _startupLogger As Utilities.DialogService = Utilities.DialogService.Instance

        Private Sub MyApplication_Startup(sender As Object, e As Global.Microsoft.VisualBasic.ApplicationServices.StartupEventArgs) Handles Me.Startup
            Try
                Utilities.DialogService.Instance.LogInfo("Hotel HRMS starting up")
            Catch ex As Exception
                Utilities.DialogService.Instance.LogError("Startup logging failed", ex)
            End Try
        End Sub

        Private Sub MyApplication_UnhandledException(sender As Object, e As Global.Microsoft.VisualBasic.ApplicationServices.UnhandledExceptionEventArgs) Handles Me.UnhandledException
            Utilities.DialogService.Instance.ShowError($"An unexpected error occurred: {e.Exception.Message}")
            e.ExitApplication = False
        End Sub

    End Class
End Namespace
