Imports System
Imports System.Data
Imports System.Data.SqlTypes
Imports System.Data.SqlClient
Imports System.Collections.Generic

Namespace DAL
    Class DALExtraFieldTemplateTable_T
        Inherits DAL.DataLayerBase

        Public Sub New()
            MyBase.New(Common.ConnectionString.ConnectionString)
        End Sub

        Public Sub Insert(ByVal businessObject As BLL.BLLExtraFieldTemplateTable_T)
            Dim ControlConnection As Boolean = Not Me.ConnectionState = Data.ConnectionState.Open
            Me.Command.CommandText = "[sp_ExtraFieldTemplateTable_T_Add]"
            Me.Command.CommandType = CommandType.StoredProcedure

            Try
                Me.Command.Parameters.Clear()

                Dim ExtraFieldTemplateTableID_bint As New SqlParameter
                ExtraFieldTemplateTableID_bint.ParameterName = "@ExtraFieldTemplateTableID_bint"
                ExtraFieldTemplateTableID_bint.SqlDbType = SqlDbType.BigInt
                ExtraFieldTemplateTableID_bint.Direction = ParameterDirection.Output
                ExtraFieldTemplateTableID_bint.IsNullable = True
                ExtraFieldTemplateTableID_bint.Value = DBNull.Value
                Me.Command.Parameters.Add(ExtraFieldTemplateTableID_bint)

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

                Dim TableID_bint As New SqlParameter
                TableID_bint.ParameterName = "@TableID_bint"
                TableID_bint.SqlDbType = SqlDbType.BigInt
                TableID_bint.Direction = ParameterDirection.Input
                TableID_bint.IsNullable = True
                If businessObject.TableID_bint.HasValue = False Then
                    TableID_bint.Value = DBNull.Value
                Else
                    TableID_bint.Value = businessObject.TableID_bint
                End If
                Me.Command.Parameters.Add(TableID_bint)

                If ControlConnection Then
                    Me.BeginTransaction()
                End If

                Me.Command.ExecuteNonQuery()

                businessObject.ExtraFieldTemplateTableID_bint = Me.Command.Parameters.Item("@ExtraFieldTemplateTableID_bint").Value

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

        Public Sub Update(ByVal businessObject As BLL.BLLExtraFieldTemplateTable_T, ByVal businessObjectKey As BLL.BLLExtraFieldTemplateTable_TKeys)
            Dim ControlConnection As Boolean = Not Me.ConnectionState = Data.ConnectionState.Open
            Me.Command.CommandText = "[sp_ExtraFieldTemplateTable_T_Update]"
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

                Dim TableID_bint As New SqlParameter
                TableID_bint.ParameterName = "@TableID_bint"
                TableID_bint.SqlDbType = SqlDbType.BigInt
                TableID_bint.Direction = ParameterDirection.Input
                TableID_bint.IsNullable = True
                If businessObject.TableID_bint.HasValue = False Then
                    TableID_bint.Value = DBNull.Value
                Else
                    TableID_bint.Value = businessObject.TableID_bint
                End If
                Me.Command.Parameters.Add(TableID_bint)

                Dim pk_ExtraFieldTemplateTableID_bint As New SqlParameter
                pk_ExtraFieldTemplateTableID_bint.ParameterName = "@pk_ExtraFieldTemplateTableID_bint"
                pk_ExtraFieldTemplateTableID_bint.SqlDbType = SqlDbType.BigInt
                pk_ExtraFieldTemplateTableID_bint.Direction = ParameterDirection.Input
                pk_ExtraFieldTemplateTableID_bint.IsNullable = False
                pk_ExtraFieldTemplateTableID_bint.Value = businessObjectKey.ExtraFieldTemplateTableID_bint
                Me.Command.Parameters.Add(pk_ExtraFieldTemplateTableID_bint)

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

        Public Function SelectAll() As List(Of BLL.BLLExtraFieldTemplateTable_T)
            Dim ControlConnection As Boolean = Not Me.ConnectionState = Data.ConnectionState.Open
            Me.Command.CommandText = "[sp_ExtraFieldTemplateTable_T_SelectAll]"
            Me.Command.CommandType = CommandType.StoredProcedure

            Try
                Me.Command.Parameters.Clear()

                If ControlConnection Then
                    Me.BeginTransaction()
                End If

                Dim dataReader As IDataReader = Me.Command.ExecuteReader
                Dim Result As New List(Of BLL.BLLExtraFieldTemplateTable_T)
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
            Me.Command.CommandText = "[sp_ExtraFieldTemplateTable_T_SelectAll]"
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
            Me.Command.CommandText = "[sp_ExtraFieldTemplateTable_T_SelectAll]"
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
            Me.Command.CommandText = "[sp_ExtraFieldTemplateTable_T_SelectAll]"
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

        Public Function SelectByPrimaryKey(ByVal businessObjectKey As BLL.BLLExtraFieldTemplateTable_TKeys) As BLL.BLLExtraFieldTemplateTable_T
            Dim ControlConnection As Boolean = Not Me.ConnectionState = Data.ConnectionState.Open
            Me.Command.CommandText = "[sp_ExtraFieldTemplateTable_T_SelectByPrimaryKey]"
            Me.Command.CommandType = CommandType.StoredProcedure

            Try
                Me.Command.Parameters.Clear()

                Dim ExtraFieldTemplateTableID_bint As New SqlParameter
                ExtraFieldTemplateTableID_bint.ParameterName = "@ExtraFieldTemplateTableID_bint"
                ExtraFieldTemplateTableID_bint.SqlDbType = SqlDbType.BigInt
                ExtraFieldTemplateTableID_bint.Direction = ParameterDirection.Input
                ExtraFieldTemplateTableID_bint.IsNullable = False
                ExtraFieldTemplateTableID_bint.Value = businessObjectKey.ExtraFieldTemplateTableID_bint
                Me.Command.Parameters.Add(ExtraFieldTemplateTableID_bint)

                If ControlConnection Then
                    Me.BeginTransaction()
                End If

                Dim dataReader As IDataReader = Me.Command.ExecuteReader
                Dim businessObject As New BLL.BLLExtraFieldTemplateTable_T
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

        Public Sub SelectByPrimaryKey(ByVal businessObjectKey As BLL.BLLExtraFieldTemplateTable_TKeys, ByRef dataset As System.Data.DataSet, ByVal srcTable As String)
            Dim ControlConnection As Boolean = Not Me.ConnectionState = Data.ConnectionState.Open
            Dim sqlDataAdapter As New SqlDataAdapter(Me.Command)
            Me.Command.CommandText = "[sp_ExtraFieldTemplateTable_T_SelectByPrimaryKey]"
            Me.Command.CommandType = CommandType.StoredProcedure

            Try
                Me.Command.Parameters.Clear()

                Dim ExtraFieldTemplateTableID_bint As New SqlParameter
                ExtraFieldTemplateTableID_bint.ParameterName = "@ExtraFieldTemplateTableID_bint"
                ExtraFieldTemplateTableID_bint.SqlDbType = SqlDbType.BigInt
                ExtraFieldTemplateTableID_bint.Direction = ParameterDirection.Input
                ExtraFieldTemplateTableID_bint.IsNullable = False
                ExtraFieldTemplateTableID_bint.Value = businessObjectKey.ExtraFieldTemplateTableID_bint
                Me.Command.Parameters.Add(ExtraFieldTemplateTableID_bint)

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

        Public Sub SelectByPrimaryKey(ByVal businessObjectKey As BLL.BLLExtraFieldTemplateTable_TKeys, ByRef dataset As System.Data.DataSet)
            Dim ControlConnection As Boolean = Not Me.ConnectionState = Data.ConnectionState.Open
            Dim sqlDataAdapter As New SqlDataAdapter(Me.Command)
            Me.Command.CommandText = "[sp_ExtraFieldTemplateTable_T_SelectByPrimaryKey]"
            Me.Command.CommandType = CommandType.StoredProcedure

            Try
                Me.Command.Parameters.Clear()

                Dim ExtraFieldTemplateTableID_bint As New SqlParameter
                ExtraFieldTemplateTableID_bint.ParameterName = "@ExtraFieldTemplateTableID_bint"
                ExtraFieldTemplateTableID_bint.SqlDbType = SqlDbType.BigInt
                ExtraFieldTemplateTableID_bint.Direction = ParameterDirection.Input
                ExtraFieldTemplateTableID_bint.IsNullable = False
                ExtraFieldTemplateTableID_bint.Value = businessObjectKey.ExtraFieldTemplateTableID_bint
                Me.Command.Parameters.Add(ExtraFieldTemplateTableID_bint)

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

        Public Sub SelectByPrimaryKey(ByVal businessObjectKey As BLL.BLLExtraFieldTemplateTable_TKeys, ByRef dataTable As System.Data.DataTable)
            Dim ControlConnection As Boolean = Not Me.ConnectionState = Data.ConnectionState.Open
            Dim sqlDataAdapter As New SqlDataAdapter(Me.Command)
            Me.Command.CommandText = "[sp_ExtraFieldTemplateTable_T_SelectByPrimaryKey]"
            Me.Command.CommandType = CommandType.StoredProcedure

            Try
                Me.Command.Parameters.Clear()

                Dim ExtraFieldTemplateTableID_bint As New SqlParameter
                ExtraFieldTemplateTableID_bint.ParameterName = "@ExtraFieldTemplateTableID_bint"
                ExtraFieldTemplateTableID_bint.SqlDbType = SqlDbType.BigInt
                ExtraFieldTemplateTableID_bint.Direction = ParameterDirection.Input
                ExtraFieldTemplateTableID_bint.IsNullable = False
                ExtraFieldTemplateTableID_bint.Value = businessObjectKey.ExtraFieldTemplateTableID_bint
                Me.Command.Parameters.Add(ExtraFieldTemplateTableID_bint)

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

        Public Function SelectByField(ByVal fieldName As String, ByVal value As Object) As List(Of BLL.BLLExtraFieldTemplateTable_T)
            Dim ControlConnection As Boolean = Not Me.ConnectionState = Data.ConnectionState.Open
            Me.Command.CommandText = "[sp_ExtraFieldTemplateTable_T_SelectCondition]"
            Me.Command.CommandType = CommandType.StoredProcedure
            Try

                Me.Command.Parameters.Clear()

                If ControlConnection Then
                    Me.BeginTransaction()
                End If

                Me.Command.Parameters.Add(New SqlParameter("@Condition", "[ExtraFieldTemplateTable_T]." + fieldName + " = N" + "'" + value.ToString + "'"))

                Dim dataReader As IDataReader = Me.Command.ExecuteReader
                Dim Result As New List(Of BLL.BLLExtraFieldTemplateTable_T)
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
            Me.Command.CommandText = "[sp_ExtraFieldTemplateTable_T_SelectCondition]"
            Me.Command.CommandType = CommandType.StoredProcedure
            Try
                Me.Command.Parameters.Clear()

                Me.Command.Parameters.Add(New SqlParameter("@Condition", "[ExtraFieldTemplateTable_T]." + fieldName + " = N" + "'" + value.ToString + "'"))

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
            Me.Command.CommandText = "[sp_ExtraFieldTemplateTable_T_SelectCondition]"
            Me.Command.CommandType = CommandType.StoredProcedure
            Try
                Me.Command.Parameters.Clear()

                Me.Command.Parameters.Add(New SqlParameter("@Condition", "[ExtraFieldTemplateTable_T]." + fieldName + " = N" + "'" + value.ToString + "'"))

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
            Me.Command.CommandText = "[sp_ExtraFieldTemplateTable_T_SelectCondition]"
            Me.Command.CommandType = CommandType.StoredProcedure
            Try
                Me.Command.Parameters.Clear()

                Me.Command.Parameters.Add(New SqlParameter("@Condition", "[ExtraFieldTemplateTable_T]." + fieldName + " = N" + "'" + value.ToString + "'"))

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

        Public Function SelectByCondition(ByVal Condition As String) As List(Of BLL.BLLExtraFieldTemplateTable_T)
            Dim ControlConnection As Boolean = Not Me.ConnectionState = Data.ConnectionState.Open
            Me.Command.CommandText = "[sp_ExtraFieldTemplateTable_T_SelectCondition]"
            Me.Command.CommandType = CommandType.StoredProcedure
            Try
                Me.Command.Parameters.Clear()

                Me.Command.Parameters.Add(New SqlParameter("@Condition", Condition))

                If ControlConnection Then
                    Me.BeginTransaction()
                End If

                Dim dataReader As IDataReader = Me.Command.ExecuteReader
                Dim Result As New List(Of BLL.BLLExtraFieldTemplateTable_T)
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
            Me.Command.CommandText = "[sp_ExtraFieldTemplateTable_T_SelectCondition]"
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
            Me.Command.CommandText = "[sp_ExtraFieldTemplateTable_T_SelectCondition]"
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
            Me.Command.CommandText = "[sp_ExtraFieldTemplateTable_T_SelectCondition]"
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

        Public Sub Delete(ByVal businessObjectKey As BLL.BLLExtraFieldTemplateTable_TKeys)
            Dim ControlConnection As Boolean = Not Me.ConnectionState = Data.ConnectionState.Open
            Me.Command.CommandText = "[sp_ExtraFieldTemplateTable_T_DeleteByPrimaryKey]"
            Me.Command.CommandType = CommandType.StoredProcedure

            Try
                Me.Command.Parameters.Clear()

                Dim ExtraFieldTemplateTableID_bint As New SqlParameter
                ExtraFieldTemplateTableID_bint.ParameterName = "@ExtraFieldTemplateTableID_bint"
                ExtraFieldTemplateTableID_bint.SqlDbType = SqlDbType.BigInt
                ExtraFieldTemplateTableID_bint.Direction = ParameterDirection.Input
                ExtraFieldTemplateTableID_bint.IsNullable = False
                ExtraFieldTemplateTableID_bint.Value = businessObjectKey.ExtraFieldTemplateTableID_bint
                Me.Command.Parameters.Add(ExtraFieldTemplateTableID_bint)

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
            Me.Command.CommandText = "[sp_ExtraFieldTemplateTable_T_DeleteByField]"
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

        Friend Sub PopulateBusinessObjectFromReader(ByVal businessObject As BLL.BLLExtraFieldTemplateTable_T, ByVal dataReader As IDataReader)
            businessObject.ExtraFieldTemplateTableID_bint = dataReader.GetInt64(dataReader.GetOrdinal(BLL.BLLExtraFieldTemplateTable_T.ExtraFieldTemplateTable_TField.ExtraFieldTemplateTableID_bint.ToString))
            If dataReader.IsDBNull(dataReader.GetOrdinal(BLL.BLLExtraFieldTemplateTable_T.ExtraFieldTemplateTable_TField.ExtraFieldTemplateID_bint.ToString)) = False Then
                businessObject.ExtraFieldTemplateID_bint = dataReader.GetInt64(dataReader.GetOrdinal(BLL.BLLExtraFieldTemplateTable_T.ExtraFieldTemplateTable_TField.ExtraFieldTemplateID_bint.ToString))
            Else
                businessObject.ExtraFieldTemplateID_bint = Nothing
            End If

            If dataReader.IsDBNull(dataReader.GetOrdinal(BLL.BLLExtraFieldTemplateTable_T.ExtraFieldTemplateTable_TField.TableID_bint.ToString)) = False Then
                businessObject.TableID_bint = dataReader.GetInt64(dataReader.GetOrdinal(BLL.BLLExtraFieldTemplateTable_T.ExtraFieldTemplateTable_TField.TableID_bint.ToString))
            Else
                businessObject.TableID_bint = Nothing
            End If

        End Sub

        Friend Function PopulateObjectsFromReader(ByVal dataReader As IDataReader) As List(Of BLL.BLLExtraFieldTemplateTable_T)
            Dim list As New List(Of BLL.BLLExtraFieldTemplateTable_T)
            While dataReader.Read
                Dim businessObject As New BLL.BLLExtraFieldTemplateTable_T
                PopulateBusinessObjectFromReader(businessObject, dataReader)
                list.Add(businessObject)
            End While
            Return list
        End Function

        Public Function SelectTablesThatHasExtraField() As List(Of BLL.BLLExtraFieldTemplateTable_T.TableThatHasExtraFieldTemplateStucture)
            Dim ControlConnection As Boolean = Not Me.ConnectionState = Data.ConnectionState.Open
            Me.Command.CommandText = "[sp_GetTablesThatHasExtraField]"
            Me.Command.CommandType = CommandType.StoredProcedure
            Try
                Me.Command.Parameters.Clear()

                If ControlConnection Then
                    Me.BeginTransaction()
                End If

                Dim dataReader As IDataReader = Me.Command.ExecuteReader
                Dim Result As New List(Of BLL.BLLExtraFieldTemplateTable_T.TableThatHasExtraFieldTemplateStucture)
                While dataReader.Read
                    Dim Struct As New BLL.BLLExtraFieldTemplateTable_T.TableThatHasExtraFieldTemplateStucture
                    Struct.TableName = dataReader.GetString(dataReader.GetOrdinal("TableName"))
                    Struct.TableID = dataReader.GetInt32(dataReader.GetOrdinal("TableID"))
                    Result.Add(Struct)
                End While

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

    End Class
End Namespace