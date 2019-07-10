Imports System
Imports System.Configuration
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.SqlTypes

Namespace DAL

    MustInherit Class DataLayerBase
        Implements IDisposable

        Private _ConnectionString As String
        Private Shared _mainConnection As SqlConnection
        Private Shared _mainTransaction As SqlTransaction
        Private Shared _mainCommand As SqlCommand

        Private ReadOnly Property Connection() As SqlConnection
            Get
                If _mainConnection Is Nothing Then
                    _mainConnection = New SqlClient.SqlConnection(_ConnectionString)
                End If
                Return _mainConnection
            End Get
        End Property

        Public ReadOnly Property ConnectionState() As Data.ConnectionState
            Get
                Return Connection.State
            End Get
        End Property

        Protected ReadOnly Property Command() As SqlCommand
            Get
                If _mainCommand Is Nothing Then
                    _mainCommand = New SqlClient.SqlCommand
                    _mainCommand.Connection = Connection
                End If
                Return _mainCommand
            End Get
        End Property

        Public Sub New(ByVal ConnectionString As String)
            _ConnectionString = ConnectionString
        End Sub

        Public Sub BeginTransaction()
            Try
                If Connection.State = ConnectionState.Closed Then
                    Connection.Open()
                    _mainTransaction = Connection.BeginTransaction
                    Command.Transaction = _mainTransaction
                End If
            Catch ex As System.Exception
                Throw ex
            End Try
        End Sub

        Public Sub Commit()
            Try
                If Connection.State = ConnectionState.Open Then
                    _mainTransaction.Commit()
                    Me.Connection.Close()
                End If
            Catch ex As System.Exception
                Throw ex
            Finally
                Dispose(True)
            End Try
        End Sub

        Public Sub RollBack()
            Try
                If Connection.State = ConnectionState.Open Then
                    _mainTransaction.Rollback()
                    Me.Connection.Close()
                End If
            Catch ex As System.Exception
                Throw ex
            Finally
                Dispose(True)
            End Try
        End Sub

        Public ReadOnly Property TableID(ByVal TableName As String) As Int64
            Get
                Dim Res As Int64
                Dim ControlConnection As Boolean = Not Me.ConnectionState = Data.ConnectionState.Open
                Me.Command.CommandText = "[sp_GetTableID]"
                Me.Command.CommandType = CommandType.StoredProcedure

                Try
                    Me.Command.Parameters.Clear()

                    Dim TableName_nvc As New SqlParameter
                    TableName_nvc.ParameterName = "@TableName_nvc"
                    TableName_nvc.SqlDbType = SqlDbType.NVarChar
                    TableName_nvc.Direction = ParameterDirection.Input
                    TableName_nvc.IsNullable = False
                    TableName_nvc.Value = TableName
                    Me.Command.Parameters.Add(TableName_nvc)

                    Dim TableID_bint As New SqlParameter
                    TableID_bint.ParameterName = "@TableID_bint"
                    TableID_bint.SqlDbType = SqlDbType.BigInt
                    TableID_bint.Direction = ParameterDirection.Output
                    TableID_bint.IsNullable = False
                    Me.Command.Parameters.Add(TableID_bint)

                    If ControlConnection Then
                        Me.BeginTransaction()
                    End If

                    Me.Command.ExecuteNonQuery()

                    Res = Me.Command.Parameters("@TableID_bint").Value

                    If ControlConnection Then
                        Me.Commit()
                    End If

                    Return Res
                Catch ex As System.Exception
                    If ControlConnection Then
                        Me.RollBack()
                    End If
                    Throw ex
                End Try
            End Get
        End Property

        Public ReadOnly Property TablePersianName(ByVal TableID As Int64) As String
            Get
                Dim Res As String
                Dim ControlConnection As Boolean = Not Me.ConnectionState = Data.ConnectionState.Open
                Me.Command.CommandText = "[sp_GetTablePersianName]"
                Me.Command.CommandType = CommandType.StoredProcedure

                Try
                    Me.Command.Parameters.Clear()

                    Dim TableID_bint As New SqlParameter
                    TableID_bint.ParameterName = "@TableID_bint"
                    TableID_bint.SqlDbType = SqlDbType.BigInt
                    TableID_bint.Direction = ParameterDirection.Input
                    TableID_bint.IsNullable = False
                    TableID_bint.Value = TableID
                    Me.Command.Parameters.Add(TableID_bint)

                    Dim TableName_nvc As New SqlParameter
                    TableName_nvc.ParameterName = "@TableName_nvc"
                    TableName_nvc.SqlDbType = SqlDbType.NVarChar
                    TableName_nvc.Size = 100
                    TableName_nvc.Direction = ParameterDirection.Output
                    TableName_nvc.IsNullable = True
                    Me.Command.Parameters.Add(TableName_nvc)

                    If ControlConnection Then
                        Me.BeginTransaction()
                    End If

                    Me.Command.ExecuteNonQuery()

                    Res = Me.Command.Parameters("@TableName_nvc").Value.ToString

                    If ControlConnection Then
                        Me.Commit()
                    End If

                    Return Res
                Catch ex As System.Exception
                    If ControlConnection Then
                        Me.RollBack()
                    End If
                    Throw ex
                End Try
            End Get
        End Property

        Public ReadOnly Property ServerDate() As Date
            Get
                Dim Result As Date
                Dim ControlConnection As Boolean = Not Me.ConnectionState = Data.ConnectionState.Open
                Me.Command.CommandText = "select getdate()"
                Me.Command.CommandType = CommandType.Text

                Try
                    Me.Command.Parameters.Clear()

                    If ControlConnection Then
                        Me.BeginTransaction()
                    End If

                    Dim mdt As New Common.MyDateTime(DirectCast(Me.Command.ExecuteScalar(), Date))
                    Result = mdt.MyDate

                    If ControlConnection Then
                        Me.Commit()
                    End If

                    Return Result
                Catch ex As System.Exception
                    If ControlConnection Then
                        Me.RollBack()
                    End If
                    Throw ex
                End Try
            End Get
        End Property

        Public Sub Dispose() Implements System.IDisposable.Dispose
            Dispose(True)
            GC.SuppressFinalize(Me)
        End Sub

        Protected Overridable Sub Dispose(ByVal bIsDisposing As Boolean)
            If bIsDisposing Then
                If _mainConnection.State = Data.ConnectionState.Open Then
                    _mainConnection.Close()
                End If
                If _mainCommand IsNot Nothing Then
                    _mainCommand.Dispose()
                    _mainCommand = Nothing
                End If
                If _mainConnection IsNot Nothing Then
                    _mainConnection.Dispose()
                    _mainConnection = Nothing
                End If
                If _mainTransaction IsNot Nothing Then
                    _mainTransaction.Dispose()
                    _mainTransaction = Nothing
                End If
            End If
        End Sub

    End Class

End Namespace