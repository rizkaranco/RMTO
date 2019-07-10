Imports System
Imports System.Data
Imports System.Data.SqlTypes
Imports System.Data.SqlClient
Imports System.Collections.Generic

Namespace DAL
    Class DALExtraField_T

        Inherits DAL.DataLayerBase

        Public Sub New()
            MyBase.New(Common.ConnectionString.ConnectionString)
        End Sub

        Public Sub Insert(ByVal businessObject As BLL.BLLExtraField_T)
            Dim ControlConnection As Boolean = Not Me.ConnectionState = Data.ConnectionState.Open
            Me.Command.CommandText = "[sp_ExtraField_T_Add]"
            Me.Command.CommandType = CommandType.StoredProcedure

            Try
                Me.Command.Parameters.Clear()

                Dim ExtraFieldID_bint As New SqlParameter
                ExtraFieldID_bint.ParameterName = "@ExtraFieldID_bint"
                ExtraFieldID_bint.SqlDbType = SqlDbType.BigInt
                ExtraFieldID_bint.Direction = ParameterDirection.Output
                ExtraFieldID_bint.IsNullable = False
                ExtraFieldID_bint.Value = businessObject.ExtraFieldID_bint
                Me.Command.Parameters.Add(ExtraFieldID_bint)

                Dim ExtraFieldTemplateID_bint As New SqlParameter
                ExtraFieldTemplateID_bint.ParameterName = "@ExtraFieldTemplateID_bint"
                ExtraFieldTemplateID_bint.SqlDbType = SqlDbType.BigInt
                ExtraFieldTemplateID_bint.Direction = ParameterDirection.Input
                ExtraFieldTemplateID_bint.IsNullable = True
                If businessObject.ExtraFieldTemplateID_bint.HasValue = False Then
                    ExtraFieldTemplateID_bint.Value = DBNull.Value
                Else
                    ExtraFieldTemplateID_bint.Value = businessObject.ExtraFieldTemplateID_bint
                End If
                Me.Command.Parameters.Add(ExtraFieldTemplateID_bint)

                Dim ExtraField_nvc As New SqlParameter
                ExtraField_nvc.ParameterName = "@ExtraField_nvc"
                ExtraField_nvc.SqlDbType = SqlDbType.NVarChar
                ExtraField_nvc.Direction = ParameterDirection.Input
                ExtraField_nvc.IsNullable = False
                ExtraField_nvc.Value = businessObject.ExtraField_nvc
                Me.Command.Parameters.Add(ExtraField_nvc)

                Dim ExtraFieldDataTypeID_tint As New SqlParameter
                ExtraFieldDataTypeID_tint.ParameterName = "@ExtraFieldDataTypeID_tint"
                ExtraFieldDataTypeID_tint.SqlDbType = SqlDbType.TinyInt
                ExtraFieldDataTypeID_tint.Direction = ParameterDirection.Input
                ExtraFieldDataTypeID_tint.IsNullable = True
                If businessObject.ExtraFieldDataTypeID_tint.HasValue = False Then
                    ExtraFieldDataTypeID_tint.Value = DBNull.Value
                Else
                    ExtraFieldDataTypeID_tint.Value = businessObject.ExtraFieldDataTypeID_tint
                End If
                Me.Command.Parameters.Add(ExtraFieldDataTypeID_tint)

                Dim DataSourceID_bint As New SqlParameter
                DataSourceID_bint.ParameterName = "@DataSourceID_bint"
                DataSourceID_bint.SqlDbType = SqlDbType.BigInt
                DataSourceID_bint.Direction = ParameterDirection.Input
                DataSourceID_bint.IsNullable = True
                If businessObject.DataSourceID_bint.HasValue = False Then
                    DataSourceID_bint.Value = DBNull.Value
                Else
                    DataSourceID_bint.Value = businessObject.DataSourceID_bint
                End If
                Me.Command.Parameters.Add(DataSourceID_bint)


                If ControlConnection Then
                    Me.BeginTransaction()
                End If

                Me.Command.ExecuteNonQuery()

                businessObject.ExtraFieldID_bint = Me.Command.Parameters("@ExtraFieldID_bint").Value

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

        Public Sub Update(ByVal businessObject As BLL.BLLExtraField_T, ByVal businessObjectKey As BLL.BLLExtraField_TKeys)
            Dim ControlConnection As Boolean = Not Me.ConnectionState = Data.ConnectionState.Open
            Me.Command.CommandText = "[sp_ExtraField_T_Update]"
            Me.Command.CommandType = CommandType.StoredProcedure

            Try
                Me.Command.Parameters.Clear()

                Dim ExtraFieldTemplateID_bint As New SqlParameter
                ExtraFieldTemplateID_bint.ParameterName = "@ExtraFieldTemplateID_bint"
                ExtraFieldTemplateID_bint.SqlDbType = SqlDbType.BigInt
                ExtraFieldTemplateID_bint.Direction = ParameterDirection.Input
                ExtraFieldTemplateID_bint.IsNullable = True
                If businessObject.ExtraFieldTemplateID_bint.HasValue = False Then
                    ExtraFieldTemplateID_bint.Value = DBNull.Value
                Else
                    ExtraFieldTemplateID_bint.Value = businessObject.ExtraFieldTemplateID_bint
                End If
                Me.Command.Parameters.Add(ExtraFieldTemplateID_bint)

                Dim ExtraField_nvc As New SqlParameter
                ExtraField_nvc.ParameterName = "@ExtraField_nvc"
                ExtraField_nvc.SqlDbType = SqlDbType.NVarChar
                ExtraField_nvc.Direction = ParameterDirection.Input
                ExtraField_nvc.IsNullable = False
                ExtraField_nvc.Value = businessObject.ExtraField_nvc
                Me.Command.Parameters.Add(ExtraField_nvc)

                Dim ExtraFieldDataTypeID_tint As New SqlParameter
                ExtraFieldDataTypeID_tint.ParameterName = "@ExtraFieldDataTypeID_tint"
                ExtraFieldDataTypeID_tint.SqlDbType = SqlDbType.TinyInt
                ExtraFieldDataTypeID_tint.Direction = ParameterDirection.Input
                ExtraFieldDataTypeID_tint.IsNullable = True
                If businessObject.ExtraFieldDataTypeID_tint.HasValue = False Then
                    ExtraFieldDataTypeID_tint.Value = DBNull.Value
                Else
                    ExtraFieldDataTypeID_tint.Value = businessObject.ExtraFieldDataTypeID_tint
                End If
                Me.Command.Parameters.Add(ExtraFieldDataTypeID_tint)

                Dim DataSourceID_bint As New SqlParameter
                DataSourceID_bint.ParameterName = "@DataSourceID_bint"
                DataSourceID_bint.SqlDbType = SqlDbType.BigInt
                DataSourceID_bint.Direction = ParameterDirection.Input
                DataSourceID_bint.IsNullable = True
                If businessObject.DataSourceID_bint.HasValue = False Then
                    DataSourceID_bint.Value = DBNull.Value
                Else
                    DataSourceID_bint.Value = businessObject.DataSourceID_bint
                End If
                Me.Command.Parameters.Add(DataSourceID_bint)


                Dim pk_ExtraFieldID_bint As New SqlParameter
                pk_ExtraFieldID_bint.ParameterName = "@pk_ExtraFieldID_bint"
                pk_ExtraFieldID_bint.SqlDbType = SqlDbType.BigInt
                pk_ExtraFieldID_bint.Direction = ParameterDirection.Input
                pk_ExtraFieldID_bint.IsNullable = False
                pk_ExtraFieldID_bint.Value = businessObjectKey.ExtraFieldID_bint
                Me.Command.Parameters.Add(pk_ExtraFieldID_bint)

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

        Public Function SelectAll() As List(Of BLL.BLLExtraField_T)
            Dim ControlConnection As Boolean = Not Me.ConnectionState = Data.ConnectionState.Open
            Me.Command.CommandText = "[sp_ExtraField_T_SelectAll]"
            Me.Command.CommandType = CommandType.StoredProcedure
            Try
                Me.Command.Parameters.Clear()

                If ControlConnection Then
                    Me.BeginTransaction()
                End If

                Dim dataReader As IDataReader = Me.Command.ExecuteReader
                Dim Result As New List(Of BLL.BLLExtraField_T)
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
            Me.Command.CommandText = "[sp_ExtraField_T_SelectAll]"
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
            Me.Command.CommandText = "[sp_ExtraField_T_SelectAll]"
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
            Me.Command.CommandText = "[sp_ExtraField_T_SelectAll]"
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

        Public Function SelectByPrimaryKey(ByVal businessObjectKey As BLL.BLLExtraField_TKeys) As BLL.BLLExtraField_T
            Dim ControlConnection As Boolean = Not Me.ConnectionState = Data.ConnectionState.Open
            Me.Command.CommandText = "[sp_ExtraField_T_SelectByPrimaryKey]"
            Me.Command.CommandType = CommandType.StoredProcedure

            Try
                Me.Command.Parameters.Clear()

                Dim ExtraFieldID_bint As New SqlParameter
                ExtraFieldID_bint.ParameterName = "@ExtraFieldID_bint"
                ExtraFieldID_bint.SqlDbType = SqlDbType.BigInt
                ExtraFieldID_bint.Direction = ParameterDirection.Input
                ExtraFieldID_bint.IsNullable = False
                ExtraFieldID_bint.Value = businessObjectKey.ExtraFieldID_bint
                Me.Command.Parameters.Add(ExtraFieldID_bint)

                If ControlConnection Then
                    Me.BeginTransaction()
                End If

                Dim dataReader As IDataReader = Me.Command.ExecuteReader
                Dim businessObject As New BLL.BLLExtraField_T
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

        Public Sub SelectByPrimaryKey(ByVal businessObjectKey As BLL.BLLExtraField_TKeys, ByRef dataset As System.Data.DataSet, ByVal srcTable As String)
            Dim ControlConnection As Boolean = Not Me.ConnectionState = Data.ConnectionState.Open
            Dim sqlDataAdapter As New SqlDataAdapter(Me.Command)
            Me.Command.CommandText = "[sp_ExtraField_T_SelectByPrimaryKey]"
            Me.Command.CommandType = CommandType.StoredProcedure

            Try
                Me.Command.Parameters.Clear()

                Dim ExtraFieldID_bint As New SqlParameter
                ExtraFieldID_bint.ParameterName = "@ExtraFieldID_bint"
                ExtraFieldID_bint.SqlDbType = SqlDbType.BigInt
                ExtraFieldID_bint.Direction = ParameterDirection.Input
                ExtraFieldID_bint.IsNullable = False
                ExtraFieldID_bint.Value = businessObjectKey.ExtraFieldID_bint
                Me.Command.Parameters.Add(ExtraFieldID_bint)


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

        Public Sub SelectByPrimaryKey(ByVal businessObjectKey As BLL.BLLExtraField_TKeys, ByRef dataset As System.Data.DataSet)
            Dim ControlConnection As Boolean = Not Me.ConnectionState = Data.ConnectionState.Open
            Dim sqlDataAdapter As New SqlDataAdapter(Me.Command)
            Me.Command.CommandText = "[sp_ExtraField_T_SelectByPrimaryKey]"
            Me.Command.CommandType = CommandType.StoredProcedure

            Try
                Me.Command.Parameters.Clear()

                Dim ExtraFieldID_bint As New SqlParameter
                ExtraFieldID_bint.ParameterName = "@ExtraFieldID_bint"
                ExtraFieldID_bint.SqlDbType = SqlDbType.BigInt
                ExtraFieldID_bint.Direction = ParameterDirection.Input
                ExtraFieldID_bint.IsNullable = False
                ExtraFieldID_bint.Value = businessObjectKey.ExtraFieldID_bint
                Me.Command.Parameters.Add(ExtraFieldID_bint)


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

        Public Sub SelectByPrimaryKey(ByVal businessObjectKey As BLL.BLLExtraField_TKeys, ByRef dataTable As System.Data.DataTable)
            Dim ControlConnection As Boolean = Not Me.ConnectionState = Data.ConnectionState.Open
            Dim sqlDataAdapter As New SqlDataAdapter(Me.Command)
            Me.Command.CommandText = "[sp_ExtraField_T_SelectByPrimaryKey]"
            Me.Command.CommandType = CommandType.StoredProcedure

            Try
                Me.Command.Parameters.Clear()

                Dim ExtraFieldID_bint As New SqlParameter
                ExtraFieldID_bint.ParameterName = "@ExtraFieldID_bint"
                ExtraFieldID_bint.SqlDbType = SqlDbType.BigInt
                ExtraFieldID_bint.Direction = ParameterDirection.Input
                ExtraFieldID_bint.IsNullable = False
                ExtraFieldID_bint.Value = businessObjectKey.ExtraFieldID_bint
                Me.Command.Parameters.Add(ExtraFieldID_bint)

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

        Public Function SelectByField(ByVal fieldName As String, ByVal value As Object) As List(Of BLL.BLLExtraField_T)
            Dim ControlConnection As Boolean = Not Me.ConnectionState = Data.ConnectionState.Open
            Me.Command.CommandText = "[sp_ExtraField_T_SelectCondition]"
            Me.Command.CommandType = CommandType.StoredProcedure
            Try

                Me.Command.Parameters.Clear()

                If ControlConnection Then
                    Me.BeginTransaction()
                End If

                Me.Command.Parameters.Add(New SqlParameter("@Condition", "[ExtraField_T]." + fieldName + " = N" + "'" + value.ToString + "'"))

                Dim dataReader As IDataReader = Me.Command.ExecuteReader
                Dim Result As New List(Of BLL.BLLExtraField_T)
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
            Me.Command.CommandText = "[sp_ExtraField_T_SelectCondition]"
            Me.Command.CommandType = CommandType.StoredProcedure
            Try
                Me.Command.Parameters.Clear()

                Me.Command.Parameters.Add(New SqlParameter("@Condition", "[ExtraField_T]." + fieldName + " = N" + "'" + value.ToString + "'"))

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
            Me.Command.CommandText = "[sp_ExtraField_T_SelectCondition]"
            Me.Command.CommandType = CommandType.StoredProcedure
            Try
                Me.Command.Parameters.Clear()

                Me.Command.Parameters.Add(New SqlParameter("@Condition", "[ExtraField_T]." + fieldName + " = N" + "'" + value.ToString + "'"))

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
            Me.Command.CommandText = "[sp_ExtraField_T_SelectCondition]"
            Me.Command.CommandType = CommandType.StoredProcedure
            Try
                Me.Command.Parameters.Clear()

                Me.Command.Parameters.Add(New SqlParameter("@Condition", "[ExtraField_T]." + fieldName + " = N" + "'" + value.ToString + "'"))

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

        Public Function SelectByCondition(ByVal Condition As String) As List(Of BLL.BLLExtraField_T)
            Dim ControlConnection As Boolean = Not Me.ConnectionState = Data.ConnectionState.Open
            Me.Command.CommandText = "[sp_ExtraField_T_SelectCondition]"
            Me.Command.CommandType = CommandType.StoredProcedure
            Try
                Me.Command.Parameters.Clear()

                Me.Command.Parameters.Add(New SqlParameter("@Condition", Condition))

                If ControlConnection Then
                    Me.BeginTransaction()
                End If

                Dim dataReader As IDataReader = Me.Command.ExecuteReader
                Dim Result As New List(Of BLL.BLLExtraField_T)
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
            Me.Command.CommandText = "[sp_ExtraField_T_SelectCondition]"
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
            Me.Command.CommandText = "[sp_ExtraField_T_SelectCondition]"
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
            Me.Command.CommandText = "[sp_ExtraField_T_SelectCondition]"
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

        Public Sub Delete(ByVal businessObjectKey As BLL.BLLExtraField_TKeys)
            Dim ControlConnection As Boolean = Not Me.ConnectionState = Data.ConnectionState.Open
            Me.Command.CommandText = "[sp_ExtraField_T_DeleteByPrimaryKey]"
            Me.Command.CommandType = CommandType.StoredProcedure

            Try
                Me.Command.Parameters.Clear()

                Dim ExtraFieldID_bint As New SqlParameter
                ExtraFieldID_bint.ParameterName = "@ExtraFieldID_bint"
                ExtraFieldID_bint.SqlDbType = SqlDbType.BigInt
                ExtraFieldID_bint.Direction = ParameterDirection.Input
                ExtraFieldID_bint.IsNullable = False
                ExtraFieldID_bint.Value = businessObjectKey.ExtraFieldID_bint
                Me.Command.Parameters.Add(ExtraFieldID_bint)


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
            Me.Command.CommandText = "[sp_ExtraField_T_DeleteByField]"
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

        Friend Sub PopulateBusinessObjectFromReader(ByVal businessObject As BLL.BLLExtraField_T, ByVal dataReader As IDataReader)
            businessObject.ExtraFieldID_bint = dataReader.GetInt64(dataReader.GetOrdinal(BLL.BLLExtraField_T.ExtraField_TField.ExtraFieldID_bint.ToString))
            If dataReader.IsDBNull(dataReader.GetOrdinal(BLL.BLLExtraField_T.ExtraField_TField.ExtraFieldTemplateID_bint.ToString)) = False Then
                businessObject.ExtraFieldTemplateID_bint = dataReader.GetInt64(dataReader.GetOrdinal(BLL.BLLExtraField_T.ExtraField_TField.ExtraFieldTemplateID_bint.ToString))
            Else
                businessObject.ExtraFieldTemplateID_bint = Nothing
            End If

            businessObject.ExtraField_nvc = dataReader.GetString(dataReader.GetOrdinal(BLL.BLLExtraField_T.ExtraField_TField.ExtraField_nvc.ToString))
            If dataReader.IsDBNull(dataReader.GetOrdinal(BLL.BLLExtraField_T.ExtraField_TField.ExtraFieldDataTypeID_tint.ToString)) = False Then
                businessObject.ExtraFieldDataTypeID_tint = dataReader.GetByte(dataReader.GetOrdinal(BLL.BLLExtraField_T.ExtraField_TField.ExtraFieldDataTypeID_tint.ToString))
            Else
                businessObject.ExtraFieldDataTypeID_tint = Nothing
            End If

            If dataReader.IsDBNull(dataReader.GetOrdinal(BLL.BLLExtraField_T.ExtraField_TField.DataSourceID_bint.ToString)) = False Then
                businessObject.DataSourceID_bint = dataReader.GetInt64(dataReader.GetOrdinal(BLL.BLLExtraField_T.ExtraField_TField.DataSourceID_bint.ToString))
            Else
                businessObject.DataSourceID_bint = Nothing
            End If
        End Sub

        Friend Function PopulateObjectsFromReader(ByVal dataReader As IDataReader) As List(Of BLL.BLLExtraField_T)
            Dim list As New List(Of BLL.BLLExtraField_T)
            While dataReader.Read
                Dim businessObject As New BLL.BLLExtraField_T
                PopulateBusinessObjectFromReader(businessObject, dataReader)
                list.Add(businessObject)
            End While
            Return list
        End Function

    End Class
End Namespace