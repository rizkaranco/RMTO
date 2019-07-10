Imports System
Imports System.Data
Imports System.Data.SqlTypes
Imports System.Data.SqlClient
Imports System.Collections.Generic

Namespace DAL
    Class DALCategoryTable_T
        Inherits DAL.DataLayerBase

        Public Sub New()
            MyBase.New(Common.ConnectionString.ConnectionString)
        End Sub

        Public Sub Insert(ByVal businessObject As BLL.BLLCategoryTable_T)
            Dim ControlConnection As Boolean = Not Me.ConnectionState = Data.ConnectionState.Open
            Me.Command.CommandText = "[sp_CategoryTable_T_Add]"
            Me.Command.CommandType = CommandType.StoredProcedure

            Try
                Me.Command.Parameters.Clear()

                Dim CategoryTableID_bint As New SqlParameter
                CategoryTableID_bint.ParameterName = "@CategoryTableID_bint"
                CategoryTableID_bint.SqlDbType = SqlDbType.BigInt
                CategoryTableID_bint.Direction = ParameterDirection.Output
                CategoryTableID_bint.IsNullable = False
                CategoryTableID_bint.Value = businessObject.CategoryTableID_bint
                Me.Command.Parameters.Add(CategoryTableID_bint)

                Dim CategoryID_bint As New SqlParameter
                CategoryID_bint.ParameterName = "@CategoryID_bint"
                CategoryID_bint.SqlDbType = SqlDbType.BigInt
                CategoryID_bint.Direction = ParameterDirection.Input
                CategoryID_bint.IsNullable = True
                If businessObject.CategoryID_bint.HasValue = False Then
                    CategoryID_bint.Value = DBNull.Value
                Else
                    CategoryID_bint.Value = businessObject.CategoryID_bint
                End If
                Me.Command.Parameters.Add(CategoryID_bint)

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

                businessObject.CategoryTableID_bint = Me.Command.Parameters("@CategoryTableID_bint").Value

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

        Public Sub Update(ByVal businessObject As BLL.BLLCategoryTable_T, ByVal businessObjectKey As BLL.BLLCategoryTable_TKeys)
            Dim ControlConnection As Boolean = Not Me.ConnectionState = Data.ConnectionState.Open
            Me.Command.CommandText = "[sp_CategoryTable_T_Update]"
            Me.Command.CommandType = CommandType.StoredProcedure

            Try
                Me.Command.Parameters.Clear()

                Dim CategoryID_bint As New SqlParameter
                CategoryID_bint.ParameterName = "@CategoryID_bint"
                CategoryID_bint.SqlDbType = SqlDbType.BigInt
                CategoryID_bint.Direction = ParameterDirection.Input
                CategoryID_bint.IsNullable = True
                If businessObject.CategoryID_bint.HasValue = False Then
                    CategoryID_bint.Value = DBNull.Value
                Else
                    CategoryID_bint.Value = businessObject.CategoryID_bint
                End If
                Me.Command.Parameters.Add(CategoryID_bint)

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

                Dim pk_CategoryTableID_bint As New SqlParameter
                pk_CategoryTableID_bint.ParameterName = "@pk_CategoryTableID_bint"
                pk_CategoryTableID_bint.SqlDbType = SqlDbType.BigInt
                pk_CategoryTableID_bint.Direction = ParameterDirection.Input
                pk_CategoryTableID_bint.IsNullable = False
                pk_CategoryTableID_bint.Value = businessObjectKey.CategoryTableID_bint
                Me.Command.Parameters.Add(pk_CategoryTableID_bint)

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

        Public Function SelectAll() As List(Of BLL.BLLCategoryTable_T)
            Dim ControlConnection As Boolean = Not Me.ConnectionState = Data.ConnectionState.Open
            Me.Command.CommandText = "[sp_CategoryTable_T_SelectAll]"
            Me.Command.CommandType = CommandType.StoredProcedure

            Try
                Me.Command.Parameters.Clear()

                If ControlConnection Then
                    Me.BeginTransaction()
                End If

                Dim dataReader As IDataReader = Me.Command.ExecuteReader
                Dim Result As New List(Of BLL.BLLCategoryTable_T)
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
            Me.Command.CommandText = "[sp_CategoryTable_T_SelectAll]"
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
            Me.Command.CommandText = "[sp_CategoryTable_T_SelectAll]"
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
            Me.Command.CommandText = "[sp_CategoryTable_T_SelectAll]"
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

        Public Function SelectByPrimaryKey(ByVal businessObjectKey As BLL.BLLCategoryTable_TKeys) As BLL.BLLCategoryTable_T
            Dim ControlConnection As Boolean = Not Me.ConnectionState = Data.ConnectionState.Open
            Me.Command.CommandText = "[sp_CategoryTable_T_SelectByPrimaryKey]"
            Me.Command.CommandType = CommandType.StoredProcedure

            Try
                Me.Command.Parameters.Clear()

                Dim CategoryTableID_bint As New SqlParameter
                CategoryTableID_bint.ParameterName = "@CategoryTableID_bint"
                CategoryTableID_bint.SqlDbType = SqlDbType.BigInt
                CategoryTableID_bint.Direction = ParameterDirection.Input
                CategoryTableID_bint.IsNullable = False
                CategoryTableID_bint.Value = businessObjectKey.CategoryTableID_bint
                Me.Command.Parameters.Add(CategoryTableID_bint)

                If ControlConnection Then
                    Me.BeginTransaction()
                End If

                Dim dataReader As IDataReader = Me.Command.ExecuteReader
                Dim businessObject As New BLL.BLLCategoryTable_T
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

        Public Sub SelectByPrimaryKey(ByVal businessObjectKey As BLL.BLLCategoryTable_TKeys, ByRef dataset As System.Data.DataSet, ByVal srcTable As String)
            Dim ControlConnection As Boolean = Not Me.ConnectionState = Data.ConnectionState.Open
            Dim sqlDataAdapter As New SqlDataAdapter(Me.Command)
            Me.Command.CommandText = "[sp_CategoryTable_T_SelectByPrimaryKey]"
            Me.Command.CommandType = CommandType.StoredProcedure

            Try
                Me.Command.Parameters.Clear()

                Dim CategoryTableID_bint As New SqlParameter
                CategoryTableID_bint.ParameterName = "@CategoryTableID_bint"
                CategoryTableID_bint.SqlDbType = SqlDbType.BigInt
                CategoryTableID_bint.Direction = ParameterDirection.Input
                CategoryTableID_bint.IsNullable = False
                CategoryTableID_bint.Value = businessObjectKey.CategoryTableID_bint
                Me.Command.Parameters.Add(CategoryTableID_bint)

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

        Public Sub SelectByPrimaryKey(ByVal businessObjectKey As BLL.BLLCategoryTable_TKeys, ByRef dataset As System.Data.DataSet)
            Dim ControlConnection As Boolean = Not Me.ConnectionState = Data.ConnectionState.Open
            Dim sqlDataAdapter As New SqlDataAdapter(Me.Command)
            Me.Command.CommandText = "[sp_CategoryTable_T_SelectByPrimaryKey]"
            Me.Command.CommandType = CommandType.StoredProcedure

            Try
                Me.Command.Parameters.Clear()

                Dim CategoryTableID_bint As New SqlParameter
                CategoryTableID_bint.ParameterName = "@CategoryTableID_bint"
                CategoryTableID_bint.SqlDbType = SqlDbType.BigInt
                CategoryTableID_bint.Direction = ParameterDirection.Input
                CategoryTableID_bint.IsNullable = False
                CategoryTableID_bint.Value = businessObjectKey.CategoryTableID_bint
                Me.Command.Parameters.Add(CategoryTableID_bint)


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

        Public Sub SelectByPrimaryKey(ByVal businessObjectKey As BLL.BLLCategoryTable_TKeys, ByRef dataTable As System.Data.DataTable)
            Dim ControlConnection As Boolean = Not Me.ConnectionState = Data.ConnectionState.Open
            Dim sqlDataAdapter As New SqlDataAdapter(Me.Command)
            Me.Command.CommandText = "[sp_CategoryTable_T_SelectByPrimaryKey]"
            Me.Command.CommandType = CommandType.StoredProcedure

            Try
                Me.Command.Parameters.Clear()

                Dim CategoryTableID_bint As New SqlParameter
                CategoryTableID_bint.ParameterName = "@CategoryTableID_bint"
                CategoryTableID_bint.SqlDbType = SqlDbType.BigInt
                CategoryTableID_bint.Direction = ParameterDirection.Input
                CategoryTableID_bint.IsNullable = False
                CategoryTableID_bint.Value = businessObjectKey.CategoryTableID_bint
                Me.Command.Parameters.Add(CategoryTableID_bint)

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

        Public Function SelectByField(ByVal fieldName As String, ByVal value As Object) As List(Of BLL.BLLCategoryTable_T)
            Dim ControlConnection As Boolean = Not Me.ConnectionState = Data.ConnectionState.Open
            Me.Command.CommandText = "[sp_CategoryTable_T_SelectCondition]"
            Me.Command.CommandType = CommandType.StoredProcedure
            Try

                Me.Command.Parameters.Clear()

                If ControlConnection Then
                    Me.BeginTransaction()
                End If

                Me.Command.Parameters.Add(New SqlParameter("@Condition", "[CategoryTable_T]." + fieldName + " = N" + "'" + value.ToString + "'"))

                Dim dataReader As IDataReader = Me.Command.ExecuteReader
                Dim Result As New List(Of BLL.BLLCategoryTable_T)
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
            Me.Command.CommandText = "[sp_CategoryTable_T_SelectCondition]"
            Me.Command.CommandType = CommandType.StoredProcedure
            Try
                Me.Command.Parameters.Clear()

                Me.Command.Parameters.Add(New SqlParameter("@Condition", "[CategoryTable_T]." + fieldName + " = N" + "'" + value.ToString + "'"))

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
            Me.Command.CommandText = "[sp_CategoryTable_T_SelectCondition]"
            Me.Command.CommandType = CommandType.StoredProcedure
            Try
                Me.Command.Parameters.Clear()

                Me.Command.Parameters.Add(New SqlParameter("@Condition", "[CategoryTable_T]." + fieldName + " = N" + "'" + value.ToString + "'"))

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
            Me.Command.CommandText = "[sp_CategoryTable_T_SelectCondition]"
            Me.Command.CommandType = CommandType.StoredProcedure
            Try
                Me.Command.Parameters.Clear()

                Me.Command.Parameters.Add(New SqlParameter("@Condition", "[CategoryTable_T]." + fieldName + " = N" + "'" + value.ToString + "'"))

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

        Public Function SelectByCondition(ByVal Condition As String) As List(Of BLL.BLLCategoryTable_T)
            Dim ControlConnection As Boolean = Not Me.ConnectionState = Data.ConnectionState.Open
            Me.Command.CommandText = "[sp_CategoryTable_T_SelectCondition]"
            Me.Command.CommandType = CommandType.StoredProcedure
            Try
                Me.Command.Parameters.Clear()

                Me.Command.Parameters.Add(New SqlParameter("@Condition", Condition))

                If ControlConnection Then
                    Me.BeginTransaction()
                End If

                Dim dataReader As IDataReader = Me.Command.ExecuteReader
                Dim Result As New List(Of BLL.BLLCategoryTable_T)
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
            Me.Command.CommandText = "[sp_CategoryTable_T_SelectCondition]"
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
            Me.Command.CommandText = "[sp_CategoryTable_T_SelectCondition]"
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
            Me.Command.CommandText = "[sp_CategoryTable_T_SelectCondition]"
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

        Public Sub Delete(ByVal businessObjectKey As BLL.BLLCategoryTable_TKeys)
            Dim ControlConnection As Boolean = Not Me.ConnectionState = Data.ConnectionState.Open
            Me.Command.CommandText = "[sp_CategoryTable_T_DeleteByPrimaryKey]"
            Me.Command.CommandType = CommandType.StoredProcedure

            Try
                Me.Command.Parameters.Clear()

                Dim CategoryTableID_bint As New SqlParameter
                CategoryTableID_bint.ParameterName = "@CategoryTableID_bint"
                CategoryTableID_bint.SqlDbType = SqlDbType.BigInt
                CategoryTableID_bint.Direction = ParameterDirection.Input
                CategoryTableID_bint.IsNullable = False
                CategoryTableID_bint.Value = businessObjectKey.CategoryTableID_bint
                Me.Command.Parameters.Add(CategoryTableID_bint)

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
            Me.Command.CommandText = "[sp_CategoryTable_T_DeleteByField]"
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

        Friend Sub PopulateBusinessObjectFromReader(ByVal businessObject As BLL.BLLCategoryTable_T, ByVal dataReader As IDataReader)
            businessObject.CategoryTableID_bint = dataReader.GetInt64(dataReader.GetOrdinal(BLL.BLLCategoryTable_T.CategoryTable_TField.CategoryTableID_bint.ToString))
            If dataReader.IsDBNull(dataReader.GetOrdinal(BLL.BLLCategoryTable_T.CategoryTable_TField.CategoryID_bint.ToString)) = False Then
                businessObject.CategoryID_bint = dataReader.GetInt64(dataReader.GetOrdinal(BLL.BLLCategoryTable_T.CategoryTable_TField.CategoryID_bint.ToString))
            Else
                businessObject.CategoryID_bint = Nothing
            End If

            If dataReader.IsDBNull(dataReader.GetOrdinal(BLL.BLLCategoryTable_T.CategoryTable_TField.TableID_bint.ToString)) = False Then
                businessObject.TableID_bint = dataReader.GetInt64(dataReader.GetOrdinal(BLL.BLLCategoryTable_T.CategoryTable_TField.TableID_bint.ToString))
            Else
                businessObject.TableID_bint = Nothing
            End If
        End Sub

        Friend Function PopulateObjectsFromReader(ByVal dataReader As IDataReader) As List(Of BLL.BLLCategoryTable_T)
            Dim list As New List(Of BLL.BLLCategoryTable_T)
            While dataReader.Read
                Dim businessObject As New BLL.BLLCategoryTable_T
                PopulateBusinessObjectFromReader(businessObject, dataReader)
                list.Add(businessObject)
            End While
            Return list
        End Function

        Public Sub SelectTablesThatHasCategory(ByRef srcDataTable As System.Data.DataTable)
            Dim ControlConnection As Boolean = Not Me.ConnectionState = Data.ConnectionState.Open
            Dim sqlDataAdapter As New SqlDataAdapter(Me.Command)
            Me.Command.CommandText = "[sp_GetTablesThatHasCategory]"
            Me.Command.CommandType = CommandType.StoredProcedure

            Try
                Me.Command.Parameters.Clear()

                If ControlConnection Then
                    Me.BeginTransaction()
                End If

                sqlDataAdapter.Fill(srcDataTable)

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

        Public Function SelectTablesThatHasCategory() As List(Of BLL.BLLCategoryTable_T.TableThatHasCategoryStucture)
            Dim ControlConnection As Boolean = Not Me.ConnectionState = Data.ConnectionState.Open
            Me.Command.CommandText = "[sp_GetTablesThatHasCategory]"
            Me.Command.CommandType = CommandType.StoredProcedure
            Try
                Me.Command.Parameters.Clear()

                If ControlConnection Then
                    Me.BeginTransaction()
                End If

                Dim dataReader As IDataReader = Me.Command.ExecuteReader
                Dim Result As New List(Of BLL.BLLCategoryTable_T.TableThatHasCategoryStucture)
                While dataReader.Read
                    Dim Struct As New BLL.BLLCategoryTable_T.TableThatHasCategoryStucture
                    Struct.TableName = dataReader.GetString(dataReader.GetOrdinal("TableName"))
                    Struct.TableId = dataReader.GetInt32(dataReader.GetOrdinal("TableID"))
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