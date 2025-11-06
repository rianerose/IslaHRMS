Option Strict On
Option Explicit On

Imports System.Runtime.CompilerServices
Imports System.Threading.Tasks
Imports System.Windows.Forms

Namespace Utilities

    Public Module FormExtensions

        <Extension>
        Public Sub InvokeIfRequired(control As Control, action As Action)
            If control.InvokeRequired Then
                control.Invoke(New MethodInvoker(Sub() action()))
            Else
                action()
            End If
        End Sub

        <Extension>
        Public Async Function RunOperationAsync(form As Form, operation As Func(Of Task)) As Task
            form.Cursor = Cursors.WaitCursor
            Try
                Await operation().ConfigureAwait(False)
            Finally
                form.Invoke(Sub() form.Cursor = Cursors.Default)
            End Try
        End Function

        <Extension>
        Public Sub ConfigureDataGrid(grid As DataGridView)
            grid.AutoGenerateColumns = False
            grid.AllowUserToAddRows = False
            grid.AllowUserToDeleteRows = False
            grid.ReadOnly = True
            grid.SelectionMode = DataGridViewSelectionMode.FullRowSelect
            grid.MultiSelect = False
            grid.RowHeadersVisible = False
            grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            grid.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(240, 240, 240)
        End Sub

    End Module

End Namespace
