Imports System
Imports System.Data
Imports System.Data.SqlTypes
Imports System.Data.SqlClient
Imports System.Collections.Generic
Imports Hepsa.Core.DAL


Namespace DAL
    Class DALLog_T

        Inherits DataLayerBase

        Public Sub New()
            MyBase.New(Hepsa.Core.Common.ConnectionString.ConnectionString)
        End Sub

        Public Sub Insert(ByVal businessObject As BLL.BLLLog_T)
            Dim ControlConnection As Boolean = Not Me.ConnectionState = Data.ConnectionState.Open
            Me.Command.CommandText = "[sp_Log_T_Add]"
            Me.Command.CommandType = CommandType.StoredProcedure

            Try
                Me.Command.Parameters.Clear()

                Dim LogID_bint As New SqlParameter
                LogID_bint.ParameterName = "@LogID_bint"
                LogID_bint.SqlDbType = SqlDbType.BigInt
                LogID_bint.Direction = ParameterDirection.Output
                LogID_bint.IsNullable = False
                LogID_bint.Value = businessObject.LogID_bint
                Me.Command.Parameters.Add(LogID_bint)

                Dim UserName_nvc As New SqlParameter
                UserName_nvc.ParameterName = "@UserName_nvc"
                UserName_nvc.SqlDbType = SqlDbType.NVarChar
                UserName_nvc.Direction = ParameterDirection.Input
                UserName_nvc.IsNullable = False
                UserName_nvc.Value = businessObject.UserName_nvc
                Me.Command.Parameters.Add(UserName_nvc)

                Dim Date_nvc As New SqlParameter
                Date_nvc.ParameterName = "@Date_nvc"
                Date_nvc.SqlDbType = SqlDbType.NVarChar
                Date_nvc.Direction = ParameterDirection.Input
                Date_nvc.IsNullable = False
                Date_nvc.Value = businessObject.Date_nvc
                Me.Command.Parameters.Add(Date_nvc)

                Dim Time_nvc As New SqlParameter
                Time_nvc.ParameterName = "@Time_nvc"
                Time_nvc.SqlDbType = SqlDbType.NVarChar
                Time_nvc.Direction = ParameterDirection.Input
                Time_nvc.IsNullable = False
                Time_nvc.Value = businessObject.Time_nvc
                Me.Command.Parameters.Add(Time_nvc)

                Dim IPAddress_nvc As New SqlParameter
                IPAddress_nvc.ParameterName = "@IPAddress_nvc"
                IPAddress_nvc.SqlDbType = SqlDbType.NVarChar
                IPAddress_nvc.Direction = ParameterDirection.Input
                IPAddress_nvc.IsNullable = False
                IPAddress_nvc.Value = businessObject.IPAddress_nvc
                Me.Command.Parameters.Add(IPAddress_nvc)

                Dim MacAddress_nvc As New SqlParameter
                MacAddress_nvc.ParameterName = "@MacAddress_nvc"
                MacAddress_nvc.SqlDbType = SqlDbType.NVarChar
                MacAddress_nvc.Direction = ParameterDirection.Input
                MacAddress_nvc.IsNullable = False
                MacAddress_nvc.Value = businessObject.MacAddress_nvc
                Me.Command.Parameters.Add(MacAddress_nvc)

                Dim FormText_nvc As New SqlParameter
                FormText_nvc.ParameterName = "@FormText_nvc"
                FormText_nvc.SqlDbType = SqlDbType.NVarChar
                FormText_nvc.Direction = ParameterDirection.Input
                FormText_nvc.IsNullable = False
                FormText_nvc.Value = businessObject.FormText_nvc
                Me.Command.Parameters.Add(FormText_nvc)

                Dim ActionID_int As New SqlParameter
                ActionID_int.ParameterName = "@ActionID_int"
                ActionID_int.SqlDbType = SqlDbType.Int
                ActionID_int.Direction = ParameterDirection.Input
                ActionID_int.IsNullable = False
                ActionID_int.Value = businessObject.ActionID_int
                Me.Command.Parameters.Add(ActionID_int)

                Dim Body_nvc As New SqlParameter
                Body_nvc.ParameterName = "@Body_nvc"
                Body_nvc.SqlDbType = SqlDbType.NVarChar
                Body_nvc.Direction = ParameterDirection.Input
                Body_nvc.IsNullable = False
                Body_nvc.Value = businessObject.Body_nvc
                Me.Command.Parameters.Add(Body_nvc)



                If ControlConnection Then
                    Me.BeginTransaction()
                End If

                Me.Command.ExecuteNonQuery()

                businessObject.LogID_bint = Me.Command.Parameters("@LogID_bint").Value

                If ControlConnection Then
                    Me.Commit()
                End If
            Catch ex As System.Exception
                If ControlConnection Then
                    Me.RollBack()
                End If
                Throw ex
            End Try
        End Sub

        Public Sub Update(ByVal businessObject As BLL.BLLLog_T, ByVal businessObjectKey As BLL.BLLLog_TKeys)
            Dim ControlConnection As Boolean = Not Me.ConnectionState = Data.ConnectionState.Open
            Me.Command.CommandText = "[sp_Log_T_Update]"
            Me.Command.CommandType = CommandType.StoredProcedure

            Try
                Me.Command.Parameters.Clear()

                Dim UserName_nvc As New SqlParameter
                UserName_nvc.ParameterName = "@UserName_nvc"
                UserName_nvc.SqlDbType = SqlDbType.NVarChar
                UserName_nvc.Direction = ParameterDirection.Input
                UserName_nvc.IsNullable = False
                UserName_nvc.Value = businessObject.UserName_nvc
                Me.Command.Parameters.Add(UserName_nvc)

                Dim Date_nvc As New SqlParameter
                Date_nvc.ParameterName = "@Date_nvc"
                Date_nvc.SqlDbType = SqlDbType.NVarChar
                Date_nvc.Direction = ParameterDirection.Input
                Date_nvc.IsNullable = False
                Date_nvc.Value = businessObject.Date_nvc
                Me.Command.Parameters.Add(Date_nvc)

                Dim Time_nvc As New SqlParameter
                Time_nvc.ParameterName = "@Time_nvc"
                Time_nvc.SqlDbType = SqlDbType.NVarChar
                Time_nvc.Direction = ParameterDirection.Input
                Time_nvc.IsNullable = False
                Time_nvc.Value = businessObject.Time_nvc
                Me.Command.Parameters.Add(Time_nvc)

                Dim IPAddress_nvc As New SqlParameter
                IPAddress_nvc.ParameterName = "@IPAddress_nvc"
                IPAddress_nvc.SqlDbType = SqlDbType.NVarChar
                IPAddress_nvc.Direction = ParameterDirection.Input
                IPAddress_nvc.IsNullable = False
                IPAddress_nvc.Value = businessObject.IPAddress_nvc
                Me.Command.Parameters.Add(IPAddress_nvc)

                Dim MacAddress_nvc As New SqlParameter
                MacAddress_nvc.ParameterName = "@MacAddress_nvc"
                MacAddress_nvc.SqlDbType = SqlDbType.NVarChar
                MacAddress_nvc.Direction = ParameterDirection.Input
                MacAddress_nvc.IsNullable = False
                MacAddress_nvc.Value = businessObject.MacAddress_nvc
                Me.Command.Parameters.Add(MacAddress_nvc)

                Dim FormText_nvc As New SqlParameter
                FormText_nvc.ParameterName = "@FormText_nvc"
                FormText_nvc.SqlDbType = SqlDbType.NVarChar
                FormText_nvc.Direction = ParameterDirection.Input
                FormText_nvc.IsNullable = False
                FormText_nvc.Value = businessObject.FormText_nvc
                Me.Command.Parameters.Add(FormText_nvc)

                Dim ActionID_int As New SqlParameter
                ActionID_int.ParameterName = "@ActionID_int"
                ActionID_int.SqlDbType = SqlDbType.Int
                ActionID_int.Direction = ParameterDirection.Input
                ActionID_int.IsNullable = False
                ActionID_int.Value = businessObject.ActionID_int
                Me.Command.Parameters.Add(ActionID_int)

                Dim Body_nvc As New SqlParameter
                Body_nvc.ParameterName = "@Body_nvc"
                Body_nvc.SqlDbType = SqlDbType.NVarChar
                Body_nvc.Direction = ParameterDirection.Input
                Body_nvc.IsNullable = False
                Body_nvc.Value = businessObject.Body_nvc
                Me.Command.Parameters.Add(Body_nvc)


                Dim pk_LogID_bint As New SqlParameter
                pk_LogID_bint.ParameterName = "@pk_LogID_bint"
                pk_LogID_bint.SqlDbType = SqlDbType.BigInt
                pk_LogID_bint.Direction = ParameterDirection.Input
                pk_LogID_bint.IsNullable = False
                pk_LogID_bint.Value = businessObjectKey.LogID_bint
                Me.Command.Parameters.Add(pk_LogID_bint)



                If ControlConnection Then
                    Me.BeginTransaction()
                End If

                Me.Command.ExecuteNonQuery()

                If ControlConnection Then
                    Me.Commit()
                End If
            Catch ex As System.Exception
                If ControlConnection Then
                    Me.RollBack()
                End If
                Throw ex
            End Try
        End Sub

        Public Function SelectAll() As List(Of BLL.BLLLog_T)
            Dim ControlConnection As Boolean = Not Me.ConnectionState = Data.ConnectionState.Open
            Me.Command.CommandText = "[sp_Log_T_SelectAll]"
            Me.Command.CommandType = CommandType.StoredProcedure

            Try
                Me.Command.Parameters.Clear()

                If ControlConnection Then
                    Me.BeginTransaction()
                End If

                Dim dataReader As IDataReader = Me.Command.ExecuteReader
                Dim Result As New List(Of BLL.BLLLog_T)
                Result = PopulateObjectsFromReader(dataReader)

                If dataReader.IsClosed = False Then
                    dataReader.Close()
                End If

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
        End Function

        Public Sub SelectAll(ByRef dataSet As System.Data.DataSet, ByVal srcTable As String)
            Dim ControlConnection As Boolean = Not Me.ConnectionState = Data.ConnectionState.Open
            Dim sqlDataAdapter As New SqlDataAdapter(Me.Command)
            Me.Command.CommandText = "[sp_Log_T_SelectAll]"
            Me.Command.CommandType = CommandType.StoredProcedure

            Try
                Me.Command.Parameters.Clear()

                If ControlConnection Then
                    Me.BeginTransaction()
                End If

                sqlDataAdapter.Fill(dataSet, srcTable)

                If ControlConnection Then
                    Me.Commit()
                End If
            Catch ex As System.Exception
                If ControlConnection Then
                    Me.RollBack()
                End If
                Throw ex
            End Try
        End Sub

        Public Sub SelectAll(ByRef dataSet As System.Data.DataSet)
            Dim ControlConnection As Boolean = Not Me.ConnectionState = Data.ConnectionState.Open
            Dim sqlDataAdapter As New SqlDataAdapter(Me.Command)
            Me.Command.CommandText = "[sp_Log_T_SelectAll]"
            Me.Command.CommandType = CommandType.StoredProcedure

            Try
                Me.Command.Parameters.Clear()

                If ControlConnection Then
                    Me.BeginTransaction()
                End If

                sqlDataAdapter.Fill(dataSet)

                If ControlConnection Then
                    Me.Commit()
                End If
            Catch ex As System.Exception
                If ControlConnection Then
                    Me.RollBack()
                End If
                Throw ex
            End Try
        End Sub

        Public Sub SelectAll(ByRef dataTable As System.Data.DataTable)
            Dim ControlConnection As Boolean = Not Me.ConnectionState = Data.ConnectionState.Open
            Dim sqlDataAdapter As New SqlDataAdapter(Me.Command)
            Me.Command.CommandText = "[sp_Log_T_SelectAll]"
            Me.Command.CommandType = CommandType.StoredProcedure

            Try
                Me.Command.Parameters.Clear()

                If ControlConnection Then
                    Me.BeginTransaction()
                End If

                sqlDataAdapter.Fill(dataTable)

                If ControlConnection Then
                    Me.Commit()
                End If
            Catch ex As System.Exception
                If ControlConnection Then
                    Me.RollBack()
                End If
                Throw ex
            End Try
        End Sub

        Public Function SelectByPrimaryKey(ByVal businessObjectKey As BLL.BLLLog_TKeys) As BLL.BLLLog_T
            Dim ControlConnection As Boolean = Not Me.ConnectionState = Data.ConnectionState.Open
            Me.Command.CommandText = "[sp_Log_T_SelectByPrimaryKey]"
            Me.Command.CommandType = CommandType.StoredProcedure

            Try
                Me.Command.Parameters.Clear()

                Dim LogID_bint As New SqlParameter
                LogID_bint.ParameterName = "@LogID_bint"
                LogID_bint.SqlDbType = SqlDbType.BigInt
                LogID_bint.Direction = ParameterDirection.Input
                LogID_bint.IsNullable = False
                LogID_bint.Value = businessObjectKey.LogID_bint
                Me.Command.Parameters.Add(LogID_bint)



                If ControlConnection Then
                    Me.BeginTransaction()
                End If

                Dim dataReader As IDataReader = Me.Command.ExecuteReader
                Dim businessObject As New BLL.BLLLog_T
                If dataReader.Read Then
                    PopulateBusinessObjectFromReader(businessObject, dataReader)
                Else
                    businessObject = Nothing
                End If

                If dataReader.IsClosed = False Then
                    dataReader.Close()
                End If


                If ControlConnection Then
                    Me.Commit()
                End If
                Return businessObject
            Catch ex As System.Exception
                If ControlConnection Then
                    Me.RollBack()
                End If
                Throw ex
            End Try
        End Function

        Public Sub SelectByPrimaryKey(ByVal businessObjectKey As BLL.BLLLog_TKeys, ByRef dataset As System.Data.DataSet, ByVal srcTable As String)
            Dim ControlConnection As Boolean = Not Me.ConnectionState = Data.ConnectionState.Open
            Dim sqlDataAdapter As New SqlDataAdapter(Me.Command)
            Me.Command.CommandText = "[sp_Log_T_SelectByPrimaryKey]"
            Me.Command.CommandType = CommandType.StoredProcedure

            Try
                Me.Command.Parameters.Clear()

                Dim LogID_bint As New SqlParameter
                LogID_bint.ParameterName = "@LogID_bint"
                LogID_bint.SqlDbType = SqlDbType.BigInt
                LogID_bint.Direction = ParameterDirection.Input
                LogID_bint.IsNullable = False
                LogID_bint.Value = businessObjectKey.LogID_bint
                Me.Command.Parameters.Add(LogID_bint)


                If ControlConnection Then
                    Me.BeginTransaction()
                End If

                sqlDataAdapter.Fill(dataset, srcTable)

                If ControlConnection Then
                    Me.Commit()
                End If
            Catch ex As System.Exception
                If ControlConnection Then
                    Me.RollBack()
                End If
                Throw ex
            End Try
        End Sub

        Public Sub SelectByPrimaryKey(ByVal businessObjectKey As BLL.BLLLog_TKeys, ByRef dataset As System.Data.DataSet)
            Dim ControlConnection As Boolean = Not Me.ConnectionState = Data.ConnectionState.Open
            Dim sqlDataAdapter As New SqlDataAdapter(Me.Command)
            Me.Command.CommandText = "[sp_Log_T_SelectByPrimaryKey]"
            Me.Command.CommandType = CommandType.StoredProcedure

            Try
                Me.Command.Parameters.Clear()

                Dim LogID_bint As New SqlParameter
                LogID_bint.ParameterName = "@LogID_bint"
                LogID_bint.SqlDbType = SqlDbType.BigInt
                LogID_bint.Direction = ParameterDirection.Input
                LogID_bint.IsNullable = False
                LogID_bint.Value = businessObjectKey.LogID_bint
                Me.Command.Parameters.Add(LogID_bint)


                If ControlConnection Then
                    Me.BeginTransaction()
                End If

                sqlDataAdapter.Fill(dataset)

                If ControlConnection Then
                    Me.Commit()
                End If
            Catch ex As System.Exception
                If ControlConnection Then
                    Me.RollBack()
                End If
                Throw ex
            End Try
        End Sub

        Public Sub SelectByPrimaryKey(ByVal businessObjectKey As BLL.BLLLog_TKeys, ByRef dataTable As System.Data.DataTable)
            Dim ControlConnection As Boolean = Not Me.ConnectionState = Data.ConnectionState.Open
            Dim sqlDataAdapter As New SqlDataAdapter(Me.Command)
            Me.Command.CommandText = "[sp_Log_T_SelectByPrimaryKey]"
            Me.Command.CommandType = CommandType.StoredProcedure

            Try
                Me.Command.Parameters.Clear()

                Dim LogID_bint As New SqlParameter
                LogID_bint.ParameterName = "@LogID_bint"
                LogID_bint.SqlDbType = SqlDbType.BigInt
                LogID_bint.Direction = ParameterDirection.Input
                LogID_bint.IsNullable = False
                LogID_bint.Value = businessObjectKey.LogID_bint
                Me.Command.Parameters.Add(LogID_bint)



                If ControlConnection Then
                    Me.BeginTransaction()
                End If

                sqlDataAdapter.Fill(dataTable)

                If ControlConnection Then
                    Me.Commit()
                End If
            Catch ex As System.Exception
                If ControlConnection Then
                    Me.RollBack()
                End If
                Throw ex
            End Try
        End Sub





        Public Function SelectByField(ByVal fieldName As String, ByVal value As Object) As List(Of BLL.BLLLog_T)
            Dim ControlConnection As Boolean = Not Me.ConnectionState = Data.ConnectionState.Open
            Me.Command.CommandText = "[sp_Log_T_SelectCondition]"
            Me.Command.CommandType = CommandType.StoredProcedure
            Try

                Me.Command.Parameters.Clear()

                If ControlConnection Then
                    Me.BeginTransaction()
                End If

                Me.Command.Parameters.Add(New SqlParameter("@Condition", "[Log_T]." + fieldName + " = N" + "'" + value.ToString + "'"))

                Dim dataReader As IDataReader = Me.Command.ExecuteReader
                Dim Result As New List(Of BLL.BLLLog_T)
                Result = PopulateObjectsFromReader(dataReader)

                If dataReader.IsClosed = False Then
                    dataReader.Close()
                End If

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
        End Function

        Public Sub SelectByField(ByVal fieldName As String, ByVal value As Object, ByRef dataset As System.Data.DataSet, ByVal srcTable As String)
            Dim ControlConnection As Boolean = Not Me.ConnectionState = Data.ConnectionState.Open
            Dim sqlDataAdapter As New SqlDataAdapter(Me.Command)
            Me.Command.CommandText = "[sp_Log_T_SelectCondition]"
            Me.Command.CommandType = CommandType.StoredProcedure
            Try
                Me.Command.Parameters.Clear()

                Me.Command.Parameters.Add(New SqlParameter("@Condition", "[Log_T]." + fieldName + " = N" + "'" + value.ToString + "'"))

                If ControlConnection Then
                    Me.BeginTransaction()
                End If

                sqlDataAdapter.Fill(dataset, srcTable)

                If ControlConnection Then
                    Me.Commit()
                End If

            Catch ex As System.Exception
                If ControlConnection Then
                    Me.RollBack()
                End If
                Throw ex
            End Try
        End Sub

        Public Sub SelectByField(ByVal fieldName As String, ByVal value As Object, ByRef dataset As System.Data.DataSet)
            Dim ControlConnection As Boolean = Not Me.ConnectionState = Data.ConnectionState.Open
            Dim sqlDataAdapter As New SqlDataAdapter(Me.Command)
            Me.Command.CommandText = "[sp_Log_T_SelectCondition]"
            Me.Command.CommandType = CommandType.StoredProcedure
            Try
                Me.Command.Parameters.Clear()

                Me.Command.Parameters.Add(New SqlParameter("@Condition", "[Log_T]." + fieldName + " = N" + "'" + value.ToString + "'"))

                If ControlConnection Then
                    Me.BeginTransaction()
                End If

                sqlDataAdapter.Fill(dataset)

                If ControlConnection Then
                    Me.Commit()
                End If

            Catch ex As System.Exception
                If ControlConnection Then
                    Me.RollBack()
                End If
                Throw ex
            End Try
        End Sub

        Public Sub SelectByField(ByVal fieldName As String, ByVal value As Object, ByRef dataTable As System.Data.DataTable)
            Dim ControlConnection As Boolean = Not Me.ConnectionState = Data.ConnectionState.Open
            Dim sqlDataAdapter As New SqlDataAdapter(Me.Command)
            Me.Command.CommandText = "[sp_Log_T_SelectCondition]"
            Me.Command.CommandType = CommandType.StoredProcedure
            Try
                Me.Command.Parameters.Clear()

                Me.Command.Parameters.Add(New SqlParameter("@Condition", "[Log_T]." + fieldName + " = N" + "'" + value.ToString + "'"))

                If ControlConnection Then
                    Me.BeginTransaction()
                End If

                sqlDataAdapter.Fill(dataTable)

                If ControlConnection Then
                    Me.Commit()
                End If

            Catch ex As System.Exception
                If ControlConnection Then
                    Me.RollBack()
                End If
                Throw ex
            End Try
        End Sub

        Public Function SelectByCondition(ByVal Condition As String) As List(Of BLL.BLLLog_T)
            Dim ControlConnection As Boolean = Not Me.ConnectionState = Data.ConnectionState.Open
            Me.Command.CommandText = "[sp_Log_T_SelectCondition]"
            Me.Command.CommandType = CommandType.StoredProcedure
            Try
                Me.Command.Parameters.Clear()

                Me.Command.Parameters.Add(New SqlParameter("@Condition", Condition))

                If ControlConnection Then
                    Me.BeginTransaction()
                End If

                Dim dataReader As IDataReader = Me.Command.ExecuteReader
                Dim Result As New List(Of BLL.BLLLog_T)
                Result = PopulateObjectsFromReader(dataReader)

                If dataReader.IsClosed = False Then
                    dataReader.Close()
                End If

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
        End Function

        Public Sub SelectByCondition(ByVal Condition As String, ByRef dataset As System.Data.DataSet, ByVal srcTable As String)
            Dim ControlConnection As Boolean = Not Me.ConnectionState = Data.ConnectionState.Open
            Dim sqlDataAdapter As New SqlDataAdapter(Me.Command)
            Me.Command.CommandText = "[sp_Log_T_SelectCondition]"
            Me.Command.CommandType = CommandType.StoredProcedure
            Try
                Me.Command.Parameters.Clear()

                Me.Command.Parameters.Add(New SqlParameter("@Condition", Condition))

                If ControlConnection Then
                    Me.BeginTransaction()
                End If

                sqlDataAdapter.Fill(dataset, srcTable)

                If ControlConnection Then
                    Me.Commit()
                End If

            Catch ex As System.Exception
                If ControlConnection Then
                    Me.RollBack()
                End If
                Throw ex
            End Try
        End Sub

        Public Sub SelectByCondition(ByVal Condition As String, ByRef dataset As System.Data.DataSet)
            Dim ControlConnection As Boolean = Not Me.ConnectionState = Data.ConnectionState.Open
            Dim sqlDataAdapter As New SqlDataAdapter(Me.Command)
            Me.Command.CommandText = "[sp_Log_T_SelectCondition]"
            Me.Command.CommandType = CommandType.StoredProcedure
            Try
                Me.Command.Parameters.Clear()

                Me.Command.Parameters.Add(New SqlParameter("@Condition", Condition))

                If ControlConnection Then
                    Me.BeginTransaction()
                End If

                sqlDataAdapter.Fill(dataset)

                If ControlConnection Then
                    Me.Commit()
                End If

            Catch ex As System.Exception
                If ControlConnection Then
                    Me.RollBack()
                End If
                Throw ex
            End Try
        End Sub

        Public Sub SelectByCondition(ByVal Condition As String, ByRef dataTable As System.Data.DataTable)
            Dim ControlConnection As Boolean = Not Me.ConnectionState = Data.ConnectionState.Open
            Dim sqlDataAdapter As New SqlDataAdapter(Me.Command)
            Me.Command.CommandText = "[sp_Log_T_SelectCondition]"
            Me.Command.CommandType = CommandType.StoredProcedure
            Try
                Me.Command.Parameters.Clear()
                Command.CommandTimeout = 300
                Me.Command.Parameters.Add(New SqlParameter("@Condition", Condition))

                If ControlConnection Then
                    Me.BeginTransaction()
                End If

                sqlDataAdapter.Fill(dataTable)

                If ControlConnection Then
                    Me.Commit()
                End If

            Catch ex As System.Exception
                If ControlConnection Then
                    Me.RollBack()
                End If
                Throw ex
            End Try
        End Sub

        Public Sub Delete(ByVal businessObjectKey As BLL.BLLLog_TKeys)
            Dim ControlConnection As Boolean = Not Me.ConnectionState = Data.ConnectionState.Open
            Me.Command.CommandText = "[sp_Log_T_DeleteByPrimaryKey]"
            Me.Command.CommandType = CommandType.StoredProcedure

            Try
                Me.Command.Parameters.Clear()

                Dim LogID_bint As New SqlParameter
                LogID_bint.ParameterName = "@LogID_bint"
                LogID_bint.SqlDbType = SqlDbType.BigInt
                LogID_bint.Direction = ParameterDirection.Input
                LogID_bint.IsNullable = False
                LogID_bint.Value = businessObjectKey.LogID_bint
                Me.Command.Parameters.Add(LogID_bint)


                If ControlConnection Then
                    Me.BeginTransaction()
                End If

                Me.Command.ExecuteNonQuery()

                If ControlConnection Then
                    Me.Commit()
                End If
            Catch ex As System.Exception
                If ControlConnection Then
                    Me.RollBack()
                End If
                Throw ex
            End Try
        End Sub

        Public Sub DeleteByField(ByVal fieldName As String, ByVal value As Object)
            Dim ControlConnection As Boolean = Not Me.ConnectionState = Data.ConnectionState.Open
            Me.Command.CommandText = "[sp_Log_T_DeleteByField]"
            Me.Command.CommandType = CommandType.StoredProcedure

            Try
                Me.Command.Parameters.Clear()

                Me.Command.Parameters.Add(New SqlParameter("@FieldName", fieldName))
                Me.Command.Parameters.Add(New SqlParameter("@Value", value))

                If ControlConnection Then
                    Me.BeginTransaction()
                End If

                Me.Command.ExecuteNonQuery()

                If ControlConnection Then
                    Me.Commit()
                End If
            Catch ex As System.Exception
                If ControlConnection Then
                    Me.RollBack()
                End If
                Throw ex
            End Try
        End Sub

        Friend Sub PopulateBusinessObjectFromReader(ByVal businessObject As BLL.BLLLog_T, ByVal dataReader As IDataReader)
            businessObject.LogID_bint = dataReader.GetInt64(dataReader.GetOrdinal(BLL.BLLLog_T.Log_TField.LogID_bint.ToString))
            businessObject.UserName_nvc = dataReader.GetString(dataReader.GetOrdinal(BLL.BLLLog_T.Log_TField.UserName_nvc.ToString))
            businessObject.Date_nvc = dataReader.GetString(dataReader.GetOrdinal(BLL.BLLLog_T.Log_TField.Date_nvc.ToString))
            businessObject.Time_nvc = dataReader.GetString(dataReader.GetOrdinal(BLL.BLLLog_T.Log_TField.Time_nvc.ToString))
            businessObject.IPAddress_nvc = dataReader.GetString(dataReader.GetOrdinal(BLL.BLLLog_T.Log_TField.IPAddress_nvc.ToString))
            businessObject.MacAddress_nvc = dataReader.GetString(dataReader.GetOrdinal(BLL.BLLLog_T.Log_TField.MacAddress_nvc.ToString))
            businessObject.FormText_nvc = dataReader.GetString(dataReader.GetOrdinal(BLL.BLLLog_T.Log_TField.FormText_nvc.ToString))
            businessObject.ActionID_int = dataReader.GetInt32(dataReader.GetOrdinal(BLL.BLLLog_T.Log_TField.ActionID_int.ToString))
            businessObject.Body_nvc = dataReader.GetString(dataReader.GetOrdinal(BLL.BLLLog_T.Log_TField.Body_nvc.ToString))
        End Sub

        Friend Function PopulateObjectsFromReader(ByVal dataReader As IDataReader) As List(Of BLL.BLLLog_T)
            Dim list As New List(Of BLL.BLLLog_T)
            While dataReader.Read
                Dim businessObject As New BLL.BLLLog_T
                PopulateBusinessObjectFromReader(businessObject, dataReader)
                list.Add(businessObject)
            End While
            Return list
        End Function

    End Class
End Namespace