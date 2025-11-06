Option Strict On
Option Explicit On

Imports System.Configuration
Imports System.Data
Imports System.Linq
Imports System.Threading.Tasks
Imports MySqlConnector

Namespace Data

    Friend Class DatabaseContext

        Private ReadOnly _connectionString As String

        Public Sub New()
            Dim connection As ConnectionStringSettings = ConfigurationManager.ConnectionStrings("HotelHRMS")
            If connection Is Nothing OrElse String.IsNullOrWhiteSpace(connection.ConnectionString) Then
                Throw New InvalidOperationException("Missing connection string 'HotelHRMS' in App.config.")
            End If

            _connectionString = connection.ConnectionString
        End Sub

        Public Function CreateConnection() As MySqlConnection
            Dim builder As New MySqlConnectionStringBuilder(_connectionString)
            builder.AllowPublicKeyRetrieval = True
            Return New MySqlConnection(builder.ConnectionString)
        End Function

        Public Async Function TestConnectionAsync() As Task
            Using connection = CreateConnection()
                Await connection.OpenAsync().ConfigureAwait(False)
            End Using
        End Function

        Public Async Function ExecuteNonQueryAsync(commandText As String, parameters As IEnumerable(Of MySqlParameter)) As Task(Of Integer)
            Using connection = CreateConnection()
                Await connection.OpenAsync().ConfigureAwait(False)
                Using command As New MySqlCommand(commandText, connection)
                    command.Parameters.AddRange(parameters.ToArray())
                    Return Await command.ExecuteNonQueryAsync().ConfigureAwait(False)
                End Using
            End Using
        End Function

        Public Async Function ExecuteScalarAsync(Of T)(commandText As String, parameters As IEnumerable(Of MySqlParameter)) As Task(Of T)
            Using connection = CreateConnection()
                Await connection.OpenAsync().ConfigureAwait(False)
                Using command As New MySqlCommand(commandText, connection)
                    command.Parameters.AddRange(parameters.ToArray())
                    Dim result = Await command.ExecuteScalarAsync().ConfigureAwait(False)
                    If result Is Nothing OrElse result Is DBNull.Value Then
                        Return Nothing
                    End If
                    Return CType(Convert.ChangeType(result, GetType(T), Globalization.CultureInfo.InvariantCulture), T)
                End Using
            End Using
        End Function

        Public Async Function GetDataTableAsync(commandText As String, parameters As IEnumerable(Of MySqlParameter)) As Task(Of DataTable)
            Using connection = CreateConnection()
                Await connection.OpenAsync().ConfigureAwait(False)
                Using command As New MySqlCommand(commandText, connection)
                    command.Parameters.AddRange(parameters.ToArray())
                    Using reader = Await command.ExecuteReaderAsync(CommandBehavior.CloseConnection).ConfigureAwait(False)
                        Dim table As New DataTable()
                        table.Load(reader)
                        Return table
                    End Using
                End Using
            End Using
        End Function

    End Class

End Namespace
