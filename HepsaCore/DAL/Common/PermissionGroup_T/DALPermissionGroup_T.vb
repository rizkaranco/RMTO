Imports System
Imports System.Data
Imports System.Data.SqlTypes
Imports System.Data.SqlClient
Imports System.Collections.Generic

Namespace DAL
    Class DALPermissionGroup_T

        Inherits DAL.DataLayerBase

        Public Sub New()
            MyBase.New(Common.ConnectionString.ConnectionString)
        End Sub

        Public Sub Insert(ByVal businessObject As BLL.BLLPermissionGroup_T)
            Dim ControlConnection As Boolean = Not Me.ConnectionState = Data.ConnectionState.Open
            Me.Command.CommandText = "[sp_PermissionGroup_T_Add]"
            Me.Command.CommandType = CommandType.StoredProcedure

            Try
                Me.Command.Parameters.Clear()

                Dim PermissionGroupID_bint As New SqlParameter
                PermissionGroupID_bint.ParameterName = "@PermissionGroupID_bint"
                PermissionGroupID_bint.SqlDbType = SqlDbType.BigInt
                PermissionGroupID_bint.Direction = ParameterDirection.Input
                PermissionGroupID_bint.IsNullable = False
                PermissionGroupID_bint.Value = businessObject.PermissionGroupID_bint
                Me.Command.Parameters.Add(PermissionGroupID_bint)

                Dim PermissionGroup_nvc As New SqlParameter
                PermissionGroup_nvc.ParameterName = "@PermissionGroup_nvc"
                PermissionGroup_nvc.SqlDbType = SqlDbType.NVarChar
                PermissionGroup_nvc.Direction = ParameterDirection.Input
                PermissionGroup_nvc.IsNullable = False
                PermissionGroup_nvc.Value = businessObject.PermissionGroup_nvc
                Me.Command.Parameters.Add(PermissionGroup_nvc)

                Dim SystemID_tint As New SqlParameter
                SystemID_tint.ParameterName = "@SystemID_tint"
                SystemID_tint.SqlDbType = SqlDbType.TinyInt
                SystemID_tint.Direction = ParameterDirection.Input
                SystemID_tint.IsNullable = True
                If businessObject.SystemID_tint.HasValue = False Then
                    SystemID_tint.Value = DBNull.Value
                Else
                    SystemID_tint.Value = businessObject.SystemID_tint
                End If
                Me.Command.Parameters.Add(SystemID_tint)

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

        Public Sub Update(ByVal businessObject As BLL.BLLPermissionGroup_T, ByVal businessObjectKey As BLL.BLLPermissionGroup_TKeys)
            Dim ControlConnection As Boolean = Not Me.ConnectionState = Data.ConnectionState.Open
            Me.Command.CommandText = "[sp_PermissionGroup_T_Update]"
            Me.Command.CommandType = CommandType.StoredProcedure

            Try
                Me.Command.Parameters.Clear()

                Dim PermissionGroupID_bint As New SqlParameter
                PermissionGroupID_bint.ParameterName = "@PermissionGroupID_bint"
                PermissionGroupID_bint.SqlDbType = SqlDbType.BigInt
                PermissionGroupID_bint.Direction = ParameterDirection.Input
                PermissionGroupID_bint.IsNullable = False
                PermissionGroupID_bint.Value = businessObject.PermissionGroupID_bint
                Me.Command.Parameters.Add(PermissionGroupID_bint)

                Dim PermissionGroup_nvc As New SqlParameter
                PermissionGroup_nvc.ParameterName = "@PermissionGroup_nvc"
                PermissionGroup_nvc.SqlDbType = SqlDbType.NVarChar
                PermissionGroup_nvc.Direction = ParameterDirection.Input
                PermissionGroup_nvc.IsNullable = False
                PermissionGroup_nvc.Value = businessObject.PermissionGroup_nvc
                Me.Command.Parameters.Add(PermissionGroup_nvc)

                Dim SystemID_tint As New SqlParameter
                SystemID_tint.ParameterName = "@SystemID_tint"
                SystemID_tint.SqlDbType = SqlDbType.TinyInt
                SystemID_tint.Direction = ParameterDirection.Input
                SystemID_tint.IsNullable = True
                If businessObject.SystemID_tint.HasValue = False Then
                    SystemID_tint.Value = DBNull.Value
                Else
                    SystemID_tint.Value = businessObject.SystemID_tint
                End If
                Me.Command.Parameters.Add(SystemID_tint)

                Dim pk_PermissionGroupID_bint As New SqlParameter
                pk_PermissionGroupID_bint.ParameterName = "@pk_PermissionGroupID_bint"
                pk_PermissionGroupID_bint.SqlDbType = SqlDbType.BigInt
                pk_PermissionGroupID_bint.Direction = ParameterDirection.Input
                pk_PermissionGroupID_bint.IsNullable = False
                pk_PermissionGroupID_bint.Value = businessObjectKey.PermissionGroupID_bint
                Me.Command.Parameters.Add(pk_PermissionGroupID_bint)

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

        Public Function SelectAll() As List(Of BLL.BLLPermissionGroup_T)
            Dim ControlConnection As Boolean = Not Me.ConnectionState = Data.ConnectionState.Open
            Me.Command.CommandText = "[sp_PermissionGroup_T_SelectAll]"
            Me.Command.CommandType = CommandType.StoredProcedure

            Try
                Me.Command.Parameters.Clear()

                If ControlConnection Then
                    Me.BeginTransaction()
                End If

                Dim dataReader As IDataReader = Me.Command.ExecuteReader
                Dim Result As New List(Of BLL.BLLPermissionGroup_T)
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
            Me.Command.CommandText = "[sp_PermissionGroup_T_SelectAll]"
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
            Me.Command.CommandText = "[sp_PermissionGroup_T_SelectAll]"
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
            Me.Command.CommandText = "[sp_PermissionGroup_T_SelectAll]"
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

        Public Function SelectByPrimaryKey(ByVal businessObjectKey As BLL.BLLPermissionGroup_TKeys) As BLL.BLLPermissionGroup_T
            Dim ControlConnection As Boolean = Not Me.ConnectionState = Data.ConnectionState.Open
            Me.Command.CommandText = "[sp_PermissionGroup_T_SelectByPrimaryKey]"
            Me.Command.CommandType = CommandType.StoredProcedure

            Try
                Me.Command.Parameters.Clear()

                Dim PermissionGroupID_bint As New SqlParameter
                PermissionGroupID_bint.ParameterName = "@PermissionGroupID_bint"
                PermissionGroupID_bint.SqlDbType = SqlDbType.BigInt
                PermissionGroupID_bint.Direction = ParameterDirection.Input
                PermissionGroupID_bint.IsNullable = False
                PermissionGroupID_bint.Value = businessObjectKey.PermissionGroupID_bint
                Me.Command.Parameters.Add(PermissionGroupID_bint)

                If ControlConnection Then
                    Me.BeginTransaction()
                End If

                Dim dataReader As IDataReader = Me.Command.ExecuteReader
                Dim businessObject As New BLL.BLLPermissionGroup_T
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

        Public Sub SelectByPrimaryKey(ByVal businessObjectKey As BLL.BLLPermissionGroup_TKeys, ByRef dataset As System.Data.DataSet, ByVal srcTable As String)
            Dim ControlConnection As Boolean = Not Me.ConnectionState = Data.ConnectionState.Open
            Dim sqlDataAdapter As New SqlDataAdapter(Me.Command)
            Me.Command.CommandText = "[sp_PermissionGroup_T_SelectByPrimaryKey]"
            Me.Command.CommandType = CommandType.StoredProcedure

            Try
                Me.Command.Parameters.Clear()

                Dim PermissionGroupID_bint As New SqlParameter
                PermissionGroupID_bint.ParameterName = "@PermissionGroupID_bint"
                PermissionGroupID_bint.SqlDbType = SqlDbType.BigInt
                PermissionGroupID_bint.Direction = ParameterDirection.Input
                PermissionGroupID_bint.IsNullable = False
                PermissionGroupID_bint.Value = businessObjectKey.PermissionGroupID_bint
                Me.Command.Parameters.Add(PermissionGroupID_bint)

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

        Public Sub SelectByPrimaryKey(ByVal businessObjectKey As BLL.BLLPermissionGroup_TKeys, ByRef dataset As System.Data.DataSet)
            Dim ControlConnection As Boolean = Not Me.ConnectionState = Data.ConnectionState.Open
            Dim sqlDataAdapter As New SqlDataAdapter(Me.Command)
            Me.Command.CommandText = "[sp_PermissionGroup_T_SelectByPrimaryKey]"
            Me.Command.CommandType = CommandType.StoredProcedure

            Try
                Me.Command.Parameters.Clear()

                Dim PermissionGroupID_bint As New SqlParameter
                PermissionGroupID_bint.ParameterName = "@PermissionGroupID_bint"
                PermissionGroupID_bint.SqlDbType = SqlDbType.BigInt
                PermissionGroupID_bint.Direction = ParameterDirection.Input
                PermissionGroupID_bint.IsNullable = False
                PermissionGroupID_bint.Value = businessObjectKey.PermissionGroupID_bint
                Me.Command.Parameters.Add(PermissionGroupID_bint)


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

        Public Sub SelectByPrimaryKey(ByVal businessObjectKey As BLL.BLLPermissionGroup_TKeys, ByRef dataTable As System.Data.DataTable)
            Dim ControlConnection As Boolean = Not Me.ConnectionState = Data.ConnectionState.Open
            Dim sqlDataAdapter As New SqlDataAdapter(Me.Command)
            Me.Command.CommandText = "[sp_PermissionGroup_T_SelectByPrimaryKey]"
            Me.Command.CommandType = CommandType.StoredProcedure

            Try
                Me.Command.Parameters.Clear()

                Dim PermissionGroupID_bint As New SqlParameter
                PermissionGroupID_bint.ParameterName = "@PermissionGroupID_bint"
                PermissionGroupID_bint.SqlDbType = SqlDbType.BigInt
                PermissionGroupID_bint.Direction = ParameterDirection.Input
                PermissionGroupID_bint.IsNullable = False
                PermissionGroupID_bint.Value = businessObjectKey.PermissionGroupID_bint
                Me.Command.Parameters.Add(PermissionGroupID_bint)

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

        Public Function SelectByField(ByVal fieldName As String, ByVal value As Object) As List(Of BLL.BLLPermissionGroup_T)
            Dim ControlConnection As Boolean = Not Me.ConnectionState = Data.ConnectionState.Open
            Me.Command.CommandText = "[sp_PermissionGroup_T_SelectCondition]"
            Me.Command.CommandType = CommandType.StoredProcedure
            Try

                Me.Command.Parameters.Clear()

                If ControlConnection Then
                    Me.BeginTransaction()
                End If

                Me.Command.Parameters.Add(New SqlParameter("@Condition", "[PermissionGroup_T]." + fieldName + " = N" + "'" + value.ToString + "'"))

                Dim dataReader As IDataReader = Me.Command.ExecuteReader
                Dim Result As New List(Of BLL.BLLPermissionGroup_T)
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
            Me.Command.CommandText = "[sp_PermissionGroup_T_SelectCondition]"
            Me.Command.CommandType = CommandType.StoredProcedure
            Try
                Me.Command.Parameters.Clear()

                Me.Command.Parameters.Add(New SqlParameter("@Condition", "[PermissionGroup_T]." + fieldName + " = N" + "'" + value.ToString + "'"))

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
            Me.Command.CommandText = "[sp_PermissionGroup_T_SelectCondition]"
            Me.Command.CommandType = CommandType.StoredProcedure
            Try
                Me.Command.Parameters.Clear()

                Me.Command.Parameters.Add(New SqlParameter("@Condition", "[PermissionGroup_T]." + fieldName + " = N" + "'" + value.ToString + "'"))

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
            Me.Command.CommandText = "[sp_PermissionGroup_T_SelectCondition]"
            Me.Command.CommandType = CommandType.StoredProcedure
            Try
                Me.Command.Parameters.Clear()

                Me.Command.Parameters.Add(New SqlParameter("@Condition", "[PermissionGroup_T]." + fieldName + " = N" + "'" + value.ToString + "'"))

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

        Public Function SelectByCondition(ByVal Condition As String) As List(Of BLL.BLLPermissionGroup_T)
            Dim ControlConnection As Boolean = Not Me.ConnectionState = Data.ConnectionState.Open
            Me.Command.CommandText = "[sp_PermissionGroup_T_SelectCondition]"
            Me.Command.CommandType = CommandType.StoredProcedure
            Try
                Me.Command.Parameters.Clear()

                Me.Command.Parameters.Add(New SqlParameter("@Condition", Condition))

                If ControlConnection Then
                    Me.BeginTransaction()
                End If

                Dim dataReader As IDataReader = Me.Command.ExecuteReader
                Dim Result As New List(Of BLL.BLLPermissionGroup_T)
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
            Me.Command.CommandText = "[sp_PermissionGroup_T_SelectCondition]"
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
            Me.Command.CommandText = "[sp_PermissionGroup_T_SelectCondition]"
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
            Me.Command.CommandText = "[sp_PermissionGroup_T_SelectCondition]"
            Me.Command.CommandType = CommandType.StoredProcedure
            Try
                Me.Command.Parameters.Clear()

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

        Public Sub Delete(ByVal businessObjectKey As BLL.BLLPermissionGroup_TKeys)
            Dim ControlConnection As Boolean = Not Me.ConnectionState = Data.ConnectionState.Open
            Me.Command.CommandText = "[sp_PermissionGroup_T_DeleteByPrimaryKey]"
            Me.Command.CommandType = CommandType.StoredProcedure

            Try
                Me.Command.Parameters.Clear()

                Dim PermissionGroupID_bint As New SqlParameter
                PermissionGroupID_bint.ParameterName = "@PermissionGroupID_bint"
                PermissionGroupID_bint.SqlDbType = SqlDbType.BigInt
                PermissionGroupID_bint.Direction = ParameterDirection.Input
                PermissionGroupID_bint.IsNullable = False
                PermissionGroupID_bint.Value = businessObjectKey.PermissionGroupID_bint
                Me.Command.Parameters.Add(PermissionGroupID_bint)


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
            Me.Command.CommandText = "[sp_PermissionGroup_T_DeleteByField]"
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

        Friend Sub PopulateBusinessObjectFromReader(ByVal businessObject As BLL.BLLPermissionGroup_T, ByVal dataReader As IDataReader)
            businessObject.PermissionGroupID_bint = dataReader.GetInt64(dataReader.GetOrdinal(BLL.BLLPermissionGroup_T.PermissionGroup_TField.PermissionGroupID_bint.ToString))
            businessObject.PermissionGroup_nvc = dataReader.GetString(dataReader.GetOrdinal(BLL.BLLPermissionGroup_T.PermissionGroup_TField.PermissionGroup_nvc.ToString))
            If dataReader.IsDBNull(dataReader.GetOrdinal(BLL.BLLPermissionGroup_T.PermissionGroup_TField.SystemID_tint.ToString)) = False Then
                businessObject.SystemID_tint = dataReader.GetByte(dataReader.GetOrdinal(BLL.BLLPermissionGroup_T.PermissionGroup_TField.SystemID_tint.ToString))
            Else
                businessObject.SystemID_tint = Nothing
            End If

        End Sub

        Friend Function PopulateObjectsFromReader(ByVal dataReader As IDataReader) As List(Of BLL.BLLPermissionGroup_T)
            Dim list As New List(Of BLL.BLLPermissionGroup_T)
            While dataReader.Read
                Dim businessObject As New BLL.BLLPermissionGroup_T
                PopulateBusinessObjectFromReader(businessObject, dataReader)
                list.Add(businessObject)
            End While
            Return list
        End Function

    End Class
End Namespace