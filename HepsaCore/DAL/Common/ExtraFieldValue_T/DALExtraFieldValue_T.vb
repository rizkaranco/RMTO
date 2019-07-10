Imports System
Imports System.Data
Imports System.Data.SqlTypes
Imports System.Data.SqlClient
Imports System.Collections.Generic

Namespace DAL
    Class DALExtraFieldValue_T
        Inherits DAL.DataLayerBase

        Public Sub New()
            MyBase.New(Common.ConnectionString.ConnectionString)
        End Sub

        Public Sub Insert(ByVal businessObject As BLL.BLLExtraFieldValue_T)
            Dim ControlConnection As Boolean = Not Me.ConnectionState = Data.ConnectionState.Open
            Me.Command.CommandText = "[sp_ExtraFieldValue_T_Add]"
            Me.Command.CommandType = CommandType.StoredProcedure

            Try
                Me.Command.Parameters.Clear()

                Dim ExtraFieldID_bint As New SqlParameter
                ExtraFieldID_bint.ParameterName = "@ExtraFieldID_bint"
                ExtraFieldID_bint.SqlDbType = SqlDbType.BigInt
                ExtraFieldID_bint.Direction = ParameterDirection.Input
                ExtraFieldID_bint.IsNullable = False
                ExtraFieldID_bint.Value = businessObject.ExtraFieldID_bint
                Me.Command.Parameters.Add(ExtraFieldID_bint)

                Dim TableID_bint As New SqlParameter
                TableID_bint.ParameterName = "@TableID_bint"
                TableID_bint.SqlDbType = SqlDbType.BigInt
                TableID_bint.Direction = ParameterDirection.Input
                TableID_bint.IsNullable = False
                TableID_bint.Value = businessObject.TableID_bint
                Me.Command.Parameters.Add(TableID_bint)

                Dim ParentID_nvc As New SqlParameter
                ParentID_nvc.ParameterName = "@ParentID_nvc"
                ParentID_nvc.SqlDbType = SqlDbType.NVarChar
                ParentID_nvc.Direction = ParameterDirection.Input
                ParentID_nvc.IsNullable = False
                ParentID_nvc.Value = businessObject.ParentID_nvc
                Me.Command.Parameters.Add(ParentID_nvc)

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

                Dim Value_vbin As New SqlParameter
                Value_vbin.ParameterName = "@Value_vbin"
                Value_vbin.SqlDbType = SqlDbType.Image
                Value_vbin.Direction = ParameterDirection.Input
                Value_vbin.IsNullable = True
                If businessObject.Value_vbin Is Nothing OrElse businessObject.Value_vbin.Length = 0 Then
                    Value_vbin.Value = DBNull.Value
                Else
                    Value_vbin.Value = businessObject.Value_vbin.Clone
                End If
                Me.Command.Parameters.Add(Value_vbin)

                Dim FileExtention_nvc As New SqlParameter
                FileExtention_nvc.ParameterName = "@FileExtention_nvc"
                FileExtention_nvc.SqlDbType = SqlDbType.NVarChar
                FileExtention_nvc.Direction = ParameterDirection.Input
                FileExtention_nvc.IsNullable = True
                If String.IsNullOrEmpty(businessObject.FileExtention_nvc) Then
                    FileExtention_nvc.Value = DBNull.Value
                Else
                    FileExtention_nvc.Value = businessObject.FileExtention_nvc
                End If
                Me.Command.Parameters.Add(FileExtention_nvc)

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

        Public Function SelectAll() As List(Of BLL.BLLExtraFieldValue_T)
            Dim ControlConnection As Boolean = Not Me.ConnectionState = Data.ConnectionState.Open
            Me.Command.CommandText = "[sp_ExtraFieldValue_T_SelectAll]"
            Me.Command.CommandType = CommandType.StoredProcedure

            Try
                Me.Command.Parameters.Clear()

                If ControlConnection Then
                    Me.BeginTransaction()
                End If

                Dim dataReader As IDataReader = Me.Command.ExecuteReader
                Dim Result As New List(Of BLL.BLLExtraFieldValue_T)
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
            Me.Command.CommandText = "[sp_ExtraFieldValue_T_SelectAll]"
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
            Me.Command.CommandText = "[sp_ExtraFieldValue_T_SelectAll]"
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
            Me.Command.CommandText = "[sp_ExtraFieldValue_T_SelectAll]"
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

        Public Function SelectByPrimaryKey(ByVal businessObjectKey As BLL.BLLExtraFieldValue_TKeys) As BLL.BLLExtraFieldValue_T
            Dim ControlConnection As Boolean = Not Me.ConnectionState = Data.ConnectionState.Open
            Me.Command.CommandText = "[sp_ExtraFieldValue_T_SelectByPrimaryKey]"
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

                Dim TableID_bint As New SqlParameter
                TableID_bint.ParameterName = "@TableID_bint"
                TableID_bint.SqlDbType = SqlDbType.BigInt
                TableID_bint.Direction = ParameterDirection.Input
                TableID_bint.IsNullable = False
                TableID_bint.Value = businessObjectKey.TableID_bint
                Me.Command.Parameters.Add(TableID_bint)

                Dim ParentID_nvc As New SqlParameter
                ParentID_nvc.ParameterName = "@ParentID_nvc"
                ParentID_nvc.SqlDbType = SqlDbType.NVarChar
                ParentID_nvc.Direction = ParameterDirection.Input
                ParentID_nvc.IsNullable = False
                ParentID_nvc.Value = businessObjectKey.ParentID_nvc
                Me.Command.Parameters.Add(ParentID_nvc)

                If ControlConnection Then
                    Me.BeginTransaction()
                End If

                Dim dataReader As IDataReader = Me.Command.ExecuteReader
                Dim businessObject As New BLL.BLLExtraFieldValue_T
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

        Public Sub SelectByPrimaryKey(ByVal businessObjectKey As BLL.BLLExtraFieldValue_TKeys, ByRef dataset As System.Data.DataSet, ByVal srcTable As String)
            Dim ControlConnection As Boolean = Not Me.ConnectionState = Data.ConnectionState.Open
            Dim sqlDataAdapter As New SqlDataAdapter(Me.Command)
            Me.Command.CommandText = "[sp_ExtraFieldValue_T_SelectByPrimaryKey]"
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

                Dim TableID_bint As New SqlParameter
                TableID_bint.ParameterName = "@TableID_bint"
                TableID_bint.SqlDbType = SqlDbType.BigInt
                TableID_bint.Direction = ParameterDirection.Input
                TableID_bint.IsNullable = False
                TableID_bint.Value = businessObjectKey.TableID_bint
                Me.Command.Parameters.Add(TableID_bint)

                Dim ParentID_nvc As New SqlParameter
                ParentID_nvc.ParameterName = "@ParentID_nvc"
                ParentID_nvc.SqlDbType = SqlDbType.NVarChar
                ParentID_nvc.Direction = ParameterDirection.Input
                ParentID_nvc.IsNullable = False
                ParentID_nvc.Value = businessObjectKey.ParentID_nvc
                Me.Command.Parameters.Add(ParentID_nvc)

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

        Public Sub SelectByPrimaryKey(ByVal businessObjectKey As BLL.BLLExtraFieldValue_TKeys, ByRef dataset As System.Data.DataSet)
            Dim ControlConnection As Boolean = Not Me.ConnectionState = Data.ConnectionState.Open
            Dim sqlDataAdapter As New SqlDataAdapter(Me.Command)
            Me.Command.CommandText = "[sp_ExtraFieldValue_T_SelectByPrimaryKey]"
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

                Dim TableID_bint As New SqlParameter
                TableID_bint.ParameterName = "@TableID_bint"
                TableID_bint.SqlDbType = SqlDbType.BigInt
                TableID_bint.Direction = ParameterDirection.Input
                TableID_bint.IsNullable = False
                TableID_bint.Value = businessObjectKey.TableID_bint
                Me.Command.Parameters.Add(TableID_bint)

                Dim ParentID_nvc As New SqlParameter
                ParentID_nvc.ParameterName = "@ParentID_nvc"
                ParentID_nvc.SqlDbType = SqlDbType.NVarChar
                ParentID_nvc.Direction = ParameterDirection.Input
                ParentID_nvc.IsNullable = False
                ParentID_nvc.Value = businessObjectKey.ParentID_nvc
                Me.Command.Parameters.Add(ParentID_nvc)

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

        Public Sub SelectByPrimaryKey(ByVal businessObjectKey As BLL.BLLExtraFieldValue_TKeys, ByRef dataTable As System.Data.DataTable)
            Dim ControlConnection As Boolean = Not Me.ConnectionState = Data.ConnectionState.Open
            Dim sqlDataAdapter As New SqlDataAdapter(Me.Command)
            Me.Command.CommandText = "[sp_ExtraFieldValue_T_SelectByPrimaryKey]"
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

                Dim TableID_bint As New SqlParameter
                TableID_bint.ParameterName = "@TableID_bint"
                TableID_bint.SqlDbType = SqlDbType.BigInt
                TableID_bint.Direction = ParameterDirection.Input
                TableID_bint.IsNullable = False
                TableID_bint.Value = businessObjectKey.TableID_bint
                Me.Command.Parameters.Add(TableID_bint)

                Dim ParentID_nvc As New SqlParameter
                ParentID_nvc.ParameterName = "@ParentID_nvc"
                ParentID_nvc.SqlDbType = SqlDbType.NVarChar
                ParentID_nvc.Direction = ParameterDirection.Input
                ParentID_nvc.IsNullable = False
                ParentID_nvc.Value = businessObjectKey.ParentID_nvc
                Me.Command.Parameters.Add(ParentID_nvc)

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

        Public Function SelectByField(ByVal fieldName As String, ByVal value As Object) As List(Of BLL.BLLExtraFieldValue_T)
            Dim ControlConnection As Boolean = Not Me.ConnectionState = Data.ConnectionState.Open
            Me.Command.CommandText = "[sp_ExtraFieldValue_T_SelectCondition]"
            Me.Command.CommandType = CommandType.StoredProcedure
            Try

                Me.Command.Parameters.Clear()

                If ControlConnection Then
                    Me.BeginTransaction()
                End If

                Me.Command.Parameters.Add(New SqlParameter("@Condition", "[ExtraFieldValue_T]." + fieldName + " = N" + "'" + value.ToString + "'"))

                Dim dataReader As IDataReader = Me.Command.ExecuteReader
                Dim Result As New List(Of BLL.BLLExtraFieldValue_T)
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
            Me.Command.CommandText = "[sp_ExtraFieldValue_T_SelectCondition]"
            Me.Command.CommandType = CommandType.StoredProcedure
            Try
                Me.Command.Parameters.Clear()

                Me.Command.Parameters.Add(New SqlParameter("@Condition", "[ExtraFieldValue_T]." + fieldName + " = N" + "'" + value.ToString + "'"))

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
            Me.Command.CommandText = "[sp_ExtraFieldValue_T_SelectCondition]"
            Me.Command.CommandType = CommandType.StoredProcedure
            Try
                Me.Command.Parameters.Clear()

                Me.Command.Parameters.Add(New SqlParameter("@Condition", "[ExtraFieldValue_T]." + fieldName + " = N" + "'" + value.ToString + "'"))

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
            Me.Command.CommandText = "[sp_ExtraFieldValue_T_SelectCondition]"
            Me.Command.CommandType = CommandType.StoredProcedure
            Try
                Me.Command.Parameters.Clear()

                Me.Command.Parameters.Add(New SqlParameter("@Condition", "[ExtraFieldValue_T]." + fieldName + " = N" + "'" + value.ToString + "'"))

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

        Public Function SelectByCondition(ByVal Condition As String) As List(Of BLL.BLLExtraFieldValue_T)
            Dim ControlConnection As Boolean = Not Me.ConnectionState = Data.ConnectionState.Open
            Me.Command.CommandText = "[sp_ExtraFieldValue_T_SelectCondition]"
            Me.Command.CommandType = CommandType.StoredProcedure
            Try
                Me.Command.Parameters.Clear()

                Me.Command.Parameters.Add(New SqlParameter("@Condition", Condition))

                If ControlConnection Then
                    Me.BeginTransaction()
                End If

                Dim dataReader As IDataReader = Me.Command.ExecuteReader
                Dim Result As New List(Of BLL.BLLExtraFieldValue_T)
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
            Me.Command.CommandText = "[sp_ExtraFieldValue_T_SelectCondition]"
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
            Me.Command.CommandText = "[sp_ExtraFieldValue_T_SelectCondition]"
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
            Me.Command.CommandText = "[sp_ExtraFieldValue_T_SelectCondition]"
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

        Public Sub Delete(ByVal businessObjectKey As BLL.BLLExtraFieldValue_TKeys)
            Dim ControlConnection As Boolean = Not Me.ConnectionState = Data.ConnectionState.Open
            Me.Command.CommandText = "[sp_ExtraFieldValue_T_DeleteByPrimaryKey]"
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

                Dim TableID_bint As New SqlParameter
                TableID_bint.ParameterName = "@TableID_bint"
                TableID_bint.SqlDbType = SqlDbType.BigInt
                TableID_bint.Direction = ParameterDirection.Input
                TableID_bint.IsNullable = False
                TableID_bint.Value = businessObjectKey.TableID_bint
                Me.Command.Parameters.Add(TableID_bint)

                Dim ParentID_nvc As New SqlParameter
                ParentID_nvc.ParameterName = "@ParentID_nvc"
                ParentID_nvc.SqlDbType = SqlDbType.NVarChar
                ParentID_nvc.Direction = ParameterDirection.Input
                ParentID_nvc.IsNullable = False
                ParentID_nvc.Value = businessObjectKey.ParentID_nvc
                Me.Command.Parameters.Add(ParentID_nvc)


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
            Me.Command.CommandText = "[sp_ExtraFieldValue_T_DeleteByField]"
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

        Public Sub DeleteByCondition(ByVal Condition As String)
            Dim ControlConnection As Boolean = Not Me.ConnectionState = Data.ConnectionState.Open
            Me.Command.CommandText = "[sp_ExtraFieldValue_T_DeleteByCondition]"
            Me.Command.CommandType = CommandType.StoredProcedure

            Try
                Me.Command.Parameters.Clear()

                Me.Command.Parameters.Add(New SqlParameter("@Condition", Condition))

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

        Friend Sub PopulateBusinessObjectFromReader(ByVal businessObject As BLL.BLLExtraFieldValue_T, ByVal dataReader As IDataReader)
            businessObject.ExtraFieldID_bint = dataReader.GetInt64(dataReader.GetOrdinal(BLL.BLLExtraFieldValue_T.ExtraFieldValue_TField.ExtraFieldID_bint.ToString))
            businessObject.TableID_bint = dataReader.GetInt64(dataReader.GetOrdinal(BLL.BLLExtraFieldValue_T.ExtraFieldValue_TField.TableID_bint.ToString))
            businessObject.ParentID_nvc = dataReader.GetString(dataReader.GetOrdinal(BLL.BLLExtraFieldValue_T.ExtraFieldValue_TField.ParentID_nvc.ToString))
            If dataReader.IsDBNull(dataReader.GetOrdinal(BLL.BLLExtraFieldValue_T.ExtraFieldValue_TField.Value_nvc.ToString)) = False Then
                businessObject.Value_nvc = dataReader.GetString(dataReader.GetOrdinal(BLL.BLLExtraFieldValue_T.ExtraFieldValue_TField.Value_nvc.ToString))
            Else
                businessObject.Value_nvc = String.Empty
            End If

            If dataReader.IsDBNull(dataReader.GetOrdinal(BLL.BLLExtraFieldValue_T.ExtraFieldValue_TField.Value_vbin.ToString)) = False Then
                businessObject.Value_vbin = DirectCast(dataReader.GetValue(dataReader.GetOrdinal(BLL.BLLExtraFieldValue_T.ExtraFieldValue_TField.Value_vbin.ToString)), Byte())
            Else
                businessObject.Value_vbin = Nothing
            End If

            If dataReader.IsDBNull(dataReader.GetOrdinal(BLL.BLLExtraFieldValue_T.ExtraFieldValue_TField.FileExtention_nvc.ToString)) = False Then
                businessObject.FileExtention_nvc = dataReader.GetString(dataReader.GetOrdinal(BLL.BLLExtraFieldValue_T.ExtraFieldValue_TField.FileExtention_nvc.ToString))
            Else
                businessObject.FileExtention_nvc = String.Empty
            End If

        End Sub

        Friend Function PopulateObjectsFromReader(ByVal dataReader As IDataReader) As List(Of BLL.BLLExtraFieldValue_T)
            Dim list As New List(Of BLL.BLLExtraFieldValue_T)
            While dataReader.Read
                Dim businessObject As New BLL.BLLExtraFieldValue_T
                PopulateBusinessObjectFromReader(businessObject, dataReader)
                list.Add(businessObject)
            End While
            Return list
        End Function

    End Class
End Namespace