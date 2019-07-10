Imports System
Imports System.Data
Imports System.Data.SqlTypes
Imports System.Data.SqlClient
Imports System.Collections.Generic


Namespace DAL

    Class DALPermission_T

        Inherits DAL.DataLayerBase

        Public Sub New()
            MyBase.New(Common.ConnectionString.ConnectionString)
        End Sub

        Public Sub Insert(ByVal businessObject As BLL.BLLPermission_T)
            Dim ControlConnection As Boolean = Not Me.ConnectionState = Data.ConnectionState.Open
            Me.Command.CommandText = "[sp_Permission_T_Add]"
            Me.Command.CommandType = CommandType.StoredProcedure

            Try
                Me.Command.Parameters.Clear()

                Dim PermissionID_bint As New SqlParameter
                PermissionID_bint.ParameterName = "@PermissionID_bint"
                PermissionID_bint.SqlDbType = SqlDbType.BigInt
                PermissionID_bint.Direction = ParameterDirection.Input
                PermissionID_bint.IsNullable = False
                PermissionID_bint.Value = businessObject.PermissionID_bint
                Me.Command.Parameters.Add(PermissionID_bint)

                Dim Permission_nvc As New SqlParameter
                Permission_nvc.ParameterName = "@Permission_nvc"
                Permission_nvc.SqlDbType = SqlDbType.NVarChar
                Permission_nvc.Direction = ParameterDirection.Input
                Permission_nvc.IsNullable = False
                Permission_nvc.Value = businessObject.Permission_nvc
                Me.Command.Parameters.Add(Permission_nvc)

                Dim PermissionGroupID_bint As New SqlParameter
                PermissionGroupID_bint.ParameterName = "@PermissionGroupID_bint"
                PermissionGroupID_bint.SqlDbType = SqlDbType.BigInt
                PermissionGroupID_bint.Direction = ParameterDirection.Input
                PermissionGroupID_bint.IsNullable = False
                PermissionGroupID_bint.Value = businessObject.PermissionGroupID_bint
                Me.Command.Parameters.Add(PermissionGroupID_bint)

                Dim FormName_nvc As New SqlParameter
                FormName_nvc.ParameterName = "@FormName_nvc"
                FormName_nvc.SqlDbType = SqlDbType.NVarChar
                FormName_nvc.Direction = ParameterDirection.Input
                FormName_nvc.IsNullable = True
                If String.IsNullOrEmpty(businessObject.FormName_nvc) Then
                    FormName_nvc.Value = DBNull.Value
                Else
                    FormName_nvc.Value = businessObject.FormName_nvc
                End If
                Me.Command.Parameters.Add(FormName_nvc)

                Dim ControlName_nvc As New SqlParameter
                ControlName_nvc.ParameterName = "@ControlName_nvc"
                ControlName_nvc.SqlDbType = SqlDbType.NVarChar
                ControlName_nvc.Direction = ParameterDirection.Input
                ControlName_nvc.IsNullable = True
                If String.IsNullOrEmpty(businessObject.ControlName_nvc) Then
                    ControlName_nvc.Value = DBNull.Value
                Else
                    ControlName_nvc.Value = businessObject.ControlName_nvc
                End If
                Me.Command.Parameters.Add(ControlName_nvc)

                Dim PropertyName_nvc As New SqlParameter
                PropertyName_nvc.ParameterName = "@PropertyName_nvc"
                PropertyName_nvc.SqlDbType = SqlDbType.NVarChar
                PropertyName_nvc.Direction = ParameterDirection.Input
                PropertyName_nvc.IsNullable = True
                If String.IsNullOrEmpty(businessObject.PropertyName_nvc) Then
                    PropertyName_nvc.Value = DBNull.Value
                Else
                    PropertyName_nvc.Value = businessObject.PropertyName_nvc
                End If
                Me.Command.Parameters.Add(PropertyName_nvc)

                Dim Value_nvc As New SqlParameter
                Value_nvc.ParameterName = "@Value_nvc"
                Value_nvc.SqlDbType = SqlDbType.NVarChar
                Value_nvc.Direction = ParameterDirection.Input
                Value_nvc.IsNullable = True
                If String.IsNullOrEmpty(businessObject.Value_nvc) Then
                    Value_nvc.Value = DBNull.Value
                Else
                    Value_nvc.Value = businessObject.Value_nvc
                End If
                Me.Command.Parameters.Add(Value_nvc)

                Dim ColumnName_nvc As New SqlParameter
                ColumnName_nvc.ParameterName = "@ColumnName_nvc"
                ColumnName_nvc.SqlDbType = SqlDbType.NVarChar
                ColumnName_nvc.Direction = ParameterDirection.Input
                ColumnName_nvc.IsNullable = True
                If String.IsNullOrEmpty(businessObject.ColumnName_nvc) Then
                    ColumnName_nvc.Value = DBNull.Value
                Else
                    ColumnName_nvc.Value = businessObject.ColumnName_nvc
                End If
                Me.Command.Parameters.Add(ColumnName_nvc)



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

        Public Sub Update(ByVal businessObject As BLL.BLLPermission_T, ByVal businessObjectKey As BLL.BLLPermission_TKeys)
            Dim ControlConnection As Boolean = Not Me.ConnectionState = Data.ConnectionState.Open
            Me.Command.CommandText = "[sp_Permission_T_Update]"
            Me.Command.CommandType = CommandType.StoredProcedure

            Try
                Me.Command.Parameters.Clear()

                Dim PermissionID_bint As New SqlParameter
                PermissionID_bint.ParameterName = "@PermissionID_bint"
                PermissionID_bint.SqlDbType = SqlDbType.BigInt
                PermissionID_bint.Direction = ParameterDirection.Input
                PermissionID_bint.IsNullable = False
                PermissionID_bint.Value = businessObject.PermissionID_bint
                Me.Command.Parameters.Add(PermissionID_bint)

                Dim Permission_nvc As New SqlParameter
                Permission_nvc.ParameterName = "@Permission_nvc"
                Permission_nvc.SqlDbType = SqlDbType.NVarChar
                Permission_nvc.Direction = ParameterDirection.Input
                Permission_nvc.IsNullable = False
                Permission_nvc.Value = businessObject.Permission_nvc
                Me.Command.Parameters.Add(Permission_nvc)

                Dim PermissionGroupID_bint As New SqlParameter
                PermissionGroupID_bint.ParameterName = "@PermissionGroupID_bint"
                PermissionGroupID_bint.SqlDbType = SqlDbType.BigInt
                PermissionGroupID_bint.Direction = ParameterDirection.Input
                PermissionGroupID_bint.IsNullable = False
                PermissionGroupID_bint.Value = businessObject.PermissionGroupID_bint
                Me.Command.Parameters.Add(PermissionGroupID_bint)

                Dim FormName_nvc As New SqlParameter
                FormName_nvc.ParameterName = "@FormName_nvc"
                FormName_nvc.SqlDbType = SqlDbType.NVarChar
                FormName_nvc.Direction = ParameterDirection.Input
                FormName_nvc.IsNullable = True
                If String.IsNullOrEmpty(businessObject.FormName_nvc) Then
                    FormName_nvc.Value = DBNull.Value
                Else
                    FormName_nvc.Value = businessObject.FormName_nvc
                End If
                Me.Command.Parameters.Add(FormName_nvc)

                Dim ControlName_nvc As New SqlParameter
                ControlName_nvc.ParameterName = "@ControlName_nvc"
                ControlName_nvc.SqlDbType = SqlDbType.NVarChar
                ControlName_nvc.Direction = ParameterDirection.Input
                ControlName_nvc.IsNullable = True
                If String.IsNullOrEmpty(businessObject.ControlName_nvc) Then
                    ControlName_nvc.Value = DBNull.Value
                Else
                    ControlName_nvc.Value = businessObject.ControlName_nvc
                End If
                Me.Command.Parameters.Add(ControlName_nvc)

                Dim PropertyName_nvc As New SqlParameter
                PropertyName_nvc.ParameterName = "@PropertyName_nvc"
                PropertyName_nvc.SqlDbType = SqlDbType.NVarChar
                PropertyName_nvc.Direction = ParameterDirection.Input
                PropertyName_nvc.IsNullable = True
                If String.IsNullOrEmpty(businessObject.PropertyName_nvc) Then
                    PropertyName_nvc.Value = DBNull.Value
                Else
                    PropertyName_nvc.Value = businessObject.PropertyName_nvc
                End If
                Me.Command.Parameters.Add(PropertyName_nvc)

                Dim Value_nvc As New SqlParameter
                Value_nvc.ParameterName = "@Value_nvc"
                Value_nvc.SqlDbType = SqlDbType.NVarChar
                Value_nvc.Direction = ParameterDirection.Input
                Value_nvc.IsNullable = True
                If String.IsNullOrEmpty(businessObject.Value_nvc) Then
                    Value_nvc.Value = DBNull.Value
                Else
                    Value_nvc.Value = businessObject.Value_nvc
                End If
                Me.Command.Parameters.Add(Value_nvc)

                Dim ColumnName_nvc As New SqlParameter
                ColumnName_nvc.ParameterName = "@ColumnName_nvc"
                ColumnName_nvc.SqlDbType = SqlDbType.NVarChar
                ColumnName_nvc.Direction = ParameterDirection.Input
                ColumnName_nvc.IsNullable = True
                If String.IsNullOrEmpty(businessObject.ColumnName_nvc) Then
                    ColumnName_nvc.Value = DBNull.Value
                Else
                    ColumnName_nvc.Value = businessObject.ColumnName_nvc
                End If
                Me.Command.Parameters.Add(ColumnName_nvc)


                Dim pk_PermissionID_bint As New SqlParameter
                pk_PermissionID_bint.ParameterName = "@pk_PermissionID_bint"
                pk_PermissionID_bint.SqlDbType = SqlDbType.BigInt
                pk_PermissionID_bint.Direction = ParameterDirection.Input
                pk_PermissionID_bint.IsNullable = False
                pk_PermissionID_bint.Value = businessObjectKey.PermissionID_bint
                Me.Command.Parameters.Add(pk_PermissionID_bint)



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

        Public Function SelectAll() As List(Of BLL.BLLPermission_T)
            Dim ControlConnection As Boolean = Not Me.ConnectionState = Data.ConnectionState.Open
            Me.Command.CommandText = "[sp_Permission_T_SelectAll]"
            Me.Command.CommandType = CommandType.StoredProcedure

            Try
                Me.Command.Parameters.Clear()

                If ControlConnection Then
                    Me.BeginTransaction()
                End If

                Dim dataReader As IDataReader = Me.Command.ExecuteReader
                Dim Result As New List(Of BLL.BLLPermission_T)
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
            Me.Command.CommandText = "[sp_Permission_T_SelectAll]"
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
            Me.Command.CommandText = "[sp_Permission_T_SelectAll]"
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
            Me.Command.CommandText = "[sp_Permission_T_SelectAll]"
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

        Public Function SelectByPrimaryKey(ByVal businessObjectKey As BLL.BLLPermission_TKeys) As BLL.BLLPermission_T
            Dim ControlConnection As Boolean = Not Me.ConnectionState = Data.ConnectionState.Open
            Me.Command.CommandText = "[sp_Permission_T_SelectByPrimaryKey]"
            Me.Command.CommandType = CommandType.StoredProcedure

            Try
                Me.Command.Parameters.Clear()

                Dim PermissionID_bint As New SqlParameter
                PermissionID_bint.ParameterName = "@PermissionID_bint"
                PermissionID_bint.SqlDbType = SqlDbType.BigInt
                PermissionID_bint.Direction = ParameterDirection.Input
                PermissionID_bint.IsNullable = False
                PermissionID_bint.Value = businessObjectKey.PermissionID_bint
                Me.Command.Parameters.Add(PermissionID_bint)



                If ControlConnection Then
                    Me.BeginTransaction()
                End If

                Dim dataReader As IDataReader = Me.Command.ExecuteReader
                Dim businessObject As New BLL.BLLPermission_T
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

        Public Sub SelectByPrimaryKey(ByVal businessObjectKey As BLL.BLLPermission_TKeys, ByRef dataset As System.Data.DataSet, ByVal srcTable As String)
            Dim ControlConnection As Boolean = Not Me.ConnectionState = Data.ConnectionState.Open
            Dim sqlDataAdapter As New SqlDataAdapter(Me.Command)
            Me.Command.CommandText = "[sp_Permission_T_SelectByPrimaryKey]"
            Me.Command.CommandType = CommandType.StoredProcedure

            Try
                Me.Command.Parameters.Clear()

                Dim PermissionID_bint As New SqlParameter
                PermissionID_bint.ParameterName = "@PermissionID_bint"
                PermissionID_bint.SqlDbType = SqlDbType.BigInt
                PermissionID_bint.Direction = ParameterDirection.Input
                PermissionID_bint.IsNullable = False
                PermissionID_bint.Value = businessObjectKey.PermissionID_bint
                Me.Command.Parameters.Add(PermissionID_bint)


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

        Public Sub SelectByPrimaryKey(ByVal businessObjectKey As BLL.BLLPermission_TKeys, ByRef dataset As System.Data.DataSet)
            Dim ControlConnection As Boolean = Not Me.ConnectionState = Data.ConnectionState.Open
            Dim sqlDataAdapter As New SqlDataAdapter(Me.Command)
            Me.Command.CommandText = "[sp_Permission_T_SelectByPrimaryKey]"
            Me.Command.CommandType = CommandType.StoredProcedure

            Try
                Me.Command.Parameters.Clear()

                Dim PermissionID_bint As New SqlParameter
                PermissionID_bint.ParameterName = "@PermissionID_bint"
                PermissionID_bint.SqlDbType = SqlDbType.BigInt
                PermissionID_bint.Direction = ParameterDirection.Input
                PermissionID_bint.IsNullable = False
                PermissionID_bint.Value = businessObjectKey.PermissionID_bint
                Me.Command.Parameters.Add(PermissionID_bint)


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

        Public Sub SelectByPrimaryKey(ByVal businessObjectKey As BLL.BLLPermission_TKeys, ByRef dataTable As System.Data.DataTable)
            Dim ControlConnection As Boolean = Not Me.ConnectionState = Data.ConnectionState.Open
            Dim sqlDataAdapter As New SqlDataAdapter(Me.Command)
            Me.Command.CommandText = "[sp_Permission_T_SelectByPrimaryKey]"
            Me.Command.CommandType = CommandType.StoredProcedure

            Try
                Me.Command.Parameters.Clear()

                Dim PermissionID_bint As New SqlParameter
                PermissionID_bint.ParameterName = "@PermissionID_bint"
                PermissionID_bint.SqlDbType = SqlDbType.BigInt
                PermissionID_bint.Direction = ParameterDirection.Input
                PermissionID_bint.IsNullable = False
                PermissionID_bint.Value = businessObjectKey.PermissionID_bint
                Me.Command.Parameters.Add(PermissionID_bint)



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

        Public Function SelectByField(ByVal fieldName As String, ByVal value As Object) As List(Of BLL.BLLPermission_T)
            Dim ControlConnection As Boolean = Not Me.ConnectionState = Data.ConnectionState.Open
            Me.Command.CommandText = "[sp_Permission_T_SelectCondition]"
            Me.Command.CommandType = CommandType.StoredProcedure
            Try

                Me.Command.Parameters.Clear()

                If ControlConnection Then
                    Me.BeginTransaction()
                End If

                Me.Command.Parameters.Add(New SqlParameter("@Condition", "[Permission_T]." + fieldName + " = N" + "'" + value.ToString + "'"))

                Dim dataReader As IDataReader = Me.Command.ExecuteReader
                Dim Result As New List(Of BLL.BLLPermission_T)
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
            Me.Command.CommandText = "[sp_Permission_T_SelectCondition]"
            Me.Command.CommandType = CommandType.StoredProcedure
            Try
                Me.Command.Parameters.Clear()

                Me.Command.Parameters.Add(New SqlParameter("@Condition", "[Permission_T]." + fieldName + " = N" + "'" + value.ToString + "'"))

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
            Me.Command.CommandText = "[sp_Permission_T_SelectCondition]"
            Me.Command.CommandType = CommandType.StoredProcedure
            Try
                Me.Command.Parameters.Clear()

                Me.Command.Parameters.Add(New SqlParameter("@Condition", "[Permission_T]." + fieldName + " = N" + "'" + value.ToString + "'"))

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
            Me.Command.CommandText = "[sp_Permission_T_SelectCondition]"
            Me.Command.CommandType = CommandType.StoredProcedure
            Try
                Me.Command.Parameters.Clear()

                Me.Command.Parameters.Add(New SqlParameter("@Condition", "[Permission_T]." + fieldName + " = N" + "'" + value.ToString + "'"))

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

        Public Function SelectByCondition(ByVal Condition As String) As List(Of BLL.BLLPermission_T)
            Dim ControlConnection As Boolean = Not Me.ConnectionState = Data.ConnectionState.Open
            Me.Command.CommandText = "[sp_Permission_T_SelectCondition]"
            Me.Command.CommandType = CommandType.StoredProcedure
            Try
                Me.Command.Parameters.Clear()

                Me.Command.Parameters.Add(New SqlParameter("@Condition", Condition))

                If ControlConnection Then
                    Me.BeginTransaction()
                End If

                Dim dataReader As IDataReader = Me.Command.ExecuteReader
                Dim Result As New List(Of BLL.BLLPermission_T)
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
            Me.Command.CommandText = "[sp_Permission_T_SelectCondition]"
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
            Me.Command.CommandText = "[sp_Permission_T_SelectCondition]"
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
            Me.Command.CommandText = "[sp_Permission_T_SelectCondition]"
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

        Public Sub Delete(ByVal businessObjectKey As BLL.BLLPermission_TKeys)
            Dim ControlConnection As Boolean = Not Me.ConnectionState = Data.ConnectionState.Open
            Me.Command.CommandText = "[sp_Permission_T_DeleteByPrimaryKey]"
            Me.Command.CommandType = CommandType.StoredProcedure

            Try
                Me.Command.Parameters.Clear()

                Dim PermissionID_bint As New SqlParameter
                PermissionID_bint.ParameterName = "@PermissionID_bint"
                PermissionID_bint.SqlDbType = SqlDbType.BigInt
                PermissionID_bint.Direction = ParameterDirection.Input
                PermissionID_bint.IsNullable = False
                PermissionID_bint.Value = businessObjectKey.PermissionID_bint
                Me.Command.Parameters.Add(PermissionID_bint)


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
            Me.Command.CommandText = "[sp_Permission_T_DeleteByField]"
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

        Friend Sub PopulateBusinessObjectFromReader(ByVal businessObject As BLL.BLLPermission_T, ByVal dataReader As IDataReader)
            businessObject.PermissionID_bint = dataReader.GetInt64(dataReader.GetOrdinal(BLL.BLLPermission_T.Permission_TField.PermissionID_bint.ToString))
            businessObject.Permission_nvc = dataReader.GetString(dataReader.GetOrdinal(BLL.BLLPermission_T.Permission_TField.Permission_nvc.ToString))
            businessObject.PermissionGroupID_bint = dataReader.GetInt64(dataReader.GetOrdinal(BLL.BLLPermission_T.Permission_TField.PermissionGroupID_bint.ToString))
            If dataReader.IsDBNull(dataReader.GetOrdinal(BLL.BLLPermission_T.Permission_TField.FormName_nvc.ToString)) = False Then
                businessObject.FormName_nvc = dataReader.GetString(dataReader.GetOrdinal(BLL.BLLPermission_T.Permission_TField.FormName_nvc.ToString))
            Else
                businessObject.FormName_nvc = String.Empty
            End If

            If dataReader.IsDBNull(dataReader.GetOrdinal(BLL.BLLPermission_T.Permission_TField.ControlName_nvc.ToString)) = False Then
                businessObject.ControlName_nvc = dataReader.GetString(dataReader.GetOrdinal(BLL.BLLPermission_T.Permission_TField.ControlName_nvc.ToString))
            Else
                businessObject.ControlName_nvc = String.Empty
            End If

            If dataReader.IsDBNull(dataReader.GetOrdinal(BLL.BLLPermission_T.Permission_TField.PropertyName_nvc.ToString)) = False Then
                businessObject.PropertyName_nvc = dataReader.GetString(dataReader.GetOrdinal(BLL.BLLPermission_T.Permission_TField.PropertyName_nvc.ToString))
            Else
                businessObject.PropertyName_nvc = String.Empty
            End If

            If dataReader.IsDBNull(dataReader.GetOrdinal(BLL.BLLPermission_T.Permission_TField.Value_nvc.ToString)) = False Then
                businessObject.Value_nvc = dataReader.GetString(dataReader.GetOrdinal(BLL.BLLPermission_T.Permission_TField.Value_nvc.ToString))
            Else
                businessObject.Value_nvc = String.Empty
            End If

            If dataReader.IsDBNull(dataReader.GetOrdinal(BLL.BLLPermission_T.Permission_TField.ColumnName_nvc.ToString)) = False Then
                businessObject.ColumnName_nvc = dataReader.GetString(dataReader.GetOrdinal(BLL.BLLPermission_T.Permission_TField.ColumnName_nvc.ToString))
            Else
                businessObject.ColumnName_nvc = String.Empty
            End If

        End Sub

        Friend Function PopulateObjectsFromReader(ByVal dataReader As IDataReader) As List(Of BLL.BLLPermission_T)
            Dim list As New List(Of BLL.BLLPermission_T)
            While dataReader.Read
                Dim businessObject As New BLL.BLLPermission_T
                PopulateBusinessObjectFromReader(businessObject, dataReader)
                list.Add(businessObject)
            End While
            Return list
        End Function

    End Class

End Namespace