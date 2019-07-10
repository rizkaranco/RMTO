Imports System
Imports System.Data
Imports System.Data.SqlTypes
Imports System.Data.SqlClient
Imports System.Collections.Generic

Namespace DAL
    Class DALCategoryTree_T
        Inherits DAL.DataLayerBase

        Public Sub New()
            MyBase.New(Common.ConnectionString.ConnectionString)
        End Sub

        Public Sub Insert(ByVal businessObject As BLL.BLLCategoryTree_T)
            Dim ControlConnection As Boolean = Not Me.ConnectionState = Data.ConnectionState.Open
            Me.Command.CommandText = "[sp_CategoryTree_T_Add]"
            Me.Command.CommandType = CommandType.StoredProcedure

            Try
                Me.Command.Parameters.Clear()

                Dim CategoryTreeID_bint As New SqlParameter
                CategoryTreeID_bint.ParameterName = "@CategoryTreeID_bint"
                CategoryTreeID_bint.SqlDbType = SqlDbType.BigInt
                CategoryTreeID_bint.Direction = ParameterDirection.Output
                CategoryTreeID_bint.IsNullable = False
                CategoryTreeID_bint.Value = businessObject.CategoryTreeID_bint
                Me.Command.Parameters.Add(CategoryTreeID_bint)

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

                Dim Node_nvc As New SqlParameter
                Node_nvc.ParameterName = "@Node_nvc"
                Node_nvc.SqlDbType = SqlDbType.NVarChar
                Node_nvc.Direction = ParameterDirection.Input
                Node_nvc.IsNullable = False
                Node_nvc.Value = businessObject.Node_nvc
                Me.Command.Parameters.Add(Node_nvc)

                Dim ParentID_bint As New SqlParameter
                ParentID_bint.ParameterName = "@ParentID_bint"
                ParentID_bint.SqlDbType = SqlDbType.BigInt
                ParentID_bint.Direction = ParameterDirection.Input
                ParentID_bint.IsNullable = True
                If businessObject.ParentID_bint.HasValue = False Then
                    ParentID_bint.Value = DBNull.Value
                Else
                    ParentID_bint.Value = businessObject.ParentID_bint
                End If
                Me.Command.Parameters.Add(ParentID_bint)

                If ControlConnection Then
                    Me.BeginTransaction()
                End If

                Me.Command.ExecuteNonQuery()

                businessObject.CategoryTreeID_bint = Me.Command.Parameters("@CategoryTreeID_bint").Value

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

        Public Sub Update(ByVal businessObject As BLL.BLLCategoryTree_T, ByVal businessObjectKey As BLL.BLLCategoryTree_TKeys)
            Dim ControlConnection As Boolean = Not Me.ConnectionState = Data.ConnectionState.Open
            Me.Command.CommandText = "[sp_CategoryTree_T_Update]"
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

                Dim Node_nvc As New SqlParameter
                Node_nvc.ParameterName = "@Node_nvc"
                Node_nvc.SqlDbType = SqlDbType.NVarChar
                Node_nvc.Direction = ParameterDirection.Input
                Node_nvc.IsNullable = False
                Node_nvc.Value = businessObject.Node_nvc
                Me.Command.Parameters.Add(Node_nvc)

                Dim ParentID_bint As New SqlParameter
                ParentID_bint.ParameterName = "@ParentID_bint"
                ParentID_bint.SqlDbType = SqlDbType.BigInt
                ParentID_bint.Direction = ParameterDirection.Input
                ParentID_bint.IsNullable = True
                If businessObject.ParentID_bint.HasValue = False Then
                    ParentID_bint.Value = DBNull.Value
                Else
                    ParentID_bint.Value = businessObject.ParentID_bint
                End If
                Me.Command.Parameters.Add(ParentID_bint)

                Dim pk_CategoryTreeID_bint As New SqlParameter
                pk_CategoryTreeID_bint.ParameterName = "@pk_CategoryTreeID_bint"
                pk_CategoryTreeID_bint.SqlDbType = SqlDbType.BigInt
                pk_CategoryTreeID_bint.Direction = ParameterDirection.Input
                pk_CategoryTreeID_bint.IsNullable = False
                pk_CategoryTreeID_bint.Value = businessObjectKey.CategoryTreeID_bint
                Me.Command.Parameters.Add(pk_CategoryTreeID_bint)

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

        Public Function SelectAll() As List(Of BLL.BLLCategoryTree_T)
            Dim ControlConnection As Boolean = Not Me.ConnectionState = Data.ConnectionState.Open
            Me.Command.CommandText = "[sp_CategoryTree_T_SelectAll]"
            Me.Command.CommandType = CommandType.StoredProcedure

            Try
                Me.Command.Parameters.Clear()

                If ControlConnection Then
                    Me.BeginTransaction()
                End If

                Dim dataReader As IDataReader = Me.Command.ExecuteReader
                Dim Result As New List(Of BLL.BLLCategoryTree_T)
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
            Me.Command.CommandText = "[sp_CategoryTree_T_SelectAll]"
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
            Me.Command.CommandText = "[sp_CategoryTree_T_SelectAll]"
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
            Me.Command.CommandText = "[sp_CategoryTree_T_SelectAll]"
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

        Public Function SelectByPrimaryKey(ByVal businessObjectKey As BLL.BLLCategoryTree_TKeys) As BLL.BLLCategoryTree_T
            Dim ControlConnection As Boolean = Not Me.ConnectionState = Data.ConnectionState.Open
            Me.Command.CommandText = "[sp_CategoryTree_T_SelectByPrimaryKey]"
            Me.Command.CommandType = CommandType.StoredProcedure

            Try
                Me.Command.Parameters.Clear()

                Dim CategoryTreeID_bint As New SqlParameter
                CategoryTreeID_bint.ParameterName = "@CategoryTreeID_bint"
                CategoryTreeID_bint.SqlDbType = SqlDbType.BigInt
                CategoryTreeID_bint.Direction = ParameterDirection.Input
                CategoryTreeID_bint.IsNullable = False
                CategoryTreeID_bint.Value = businessObjectKey.CategoryTreeID_bint
                Me.Command.Parameters.Add(CategoryTreeID_bint)

                If ControlConnection Then
                    Me.BeginTransaction()
                End If

                Dim dataReader As IDataReader = Me.Command.ExecuteReader
                Dim businessObject As New BLL.BLLCategoryTree_T
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

        Public Sub SelectByPrimaryKey(ByVal businessObjectKey As BLL.BLLCategoryTree_TKeys, ByRef dataset As System.Data.DataSet, ByVal srcTable As String)
            Dim ControlConnection As Boolean = Not Me.ConnectionState = Data.ConnectionState.Open
            Dim sqlDataAdapter As New SqlDataAdapter(Me.Command)
            Me.Command.CommandText = "[sp_CategoryTree_T_SelectByPrimaryKey]"
            Me.Command.CommandType = CommandType.StoredProcedure

            Try
                Me.Command.Parameters.Clear()

                Dim CategoryTreeID_bint As New SqlParameter
                CategoryTreeID_bint.ParameterName = "@CategoryTreeID_bint"
                CategoryTreeID_bint.SqlDbType = SqlDbType.BigInt
                CategoryTreeID_bint.Direction = ParameterDirection.Input
                CategoryTreeID_bint.IsNullable = False
                CategoryTreeID_bint.Value = businessObjectKey.CategoryTreeID_bint
                Me.Command.Parameters.Add(CategoryTreeID_bint)

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

        Public Sub SelectByPrimaryKey(ByVal businessObjectKey As BLL.BLLCategoryTree_TKeys, ByRef dataset As System.Data.DataSet)
            Dim ControlConnection As Boolean = Not Me.ConnectionState = Data.ConnectionState.Open
            Dim sqlDataAdapter As New SqlDataAdapter(Me.Command)
            Me.Command.CommandText = "[sp_CategoryTree_T_SelectByPrimaryKey]"
            Me.Command.CommandType = CommandType.StoredProcedure

            Try
                Me.Command.Parameters.Clear()

                Dim CategoryTreeID_bint As New SqlParameter
                CategoryTreeID_bint.ParameterName = "@CategoryTreeID_bint"
                CategoryTreeID_bint.SqlDbType = SqlDbType.BigInt
                CategoryTreeID_bint.Direction = ParameterDirection.Input
                CategoryTreeID_bint.IsNullable = False
                CategoryTreeID_bint.Value = businessObjectKey.CategoryTreeID_bint
                Me.Command.Parameters.Add(CategoryTreeID_bint)

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

        Public Sub SelectByPrimaryKey(ByVal businessObjectKey As BLL.BLLCategoryTree_TKeys, ByRef dataTable As System.Data.DataTable)
            Dim ControlConnection As Boolean = Not Me.ConnectionState = Data.ConnectionState.Open
            Dim sqlDataAdapter As New SqlDataAdapter(Me.Command)
            Me.Command.CommandText = "[sp_CategoryTree_T_SelectByPrimaryKey]"
            Me.Command.CommandType = CommandType.StoredProcedure

            Try
                Me.Command.Parameters.Clear()

                Dim CategoryTreeID_bint As New SqlParameter
                CategoryTreeID_bint.ParameterName = "@CategoryTreeID_bint"
                CategoryTreeID_bint.SqlDbType = SqlDbType.BigInt
                CategoryTreeID_bint.Direction = ParameterDirection.Input
                CategoryTreeID_bint.IsNullable = False
                CategoryTreeID_bint.Value = businessObjectKey.CategoryTreeID_bint
                Me.Command.Parameters.Add(CategoryTreeID_bint)

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

        Public Function SelectByField(ByVal fieldName As String, ByVal value As Object) As List(Of BLL.BLLCategoryTree_T)
            Dim ControlConnection As Boolean = Not Me.ConnectionState = Data.ConnectionState.Open
            Me.Command.CommandText = "[sp_CategoryTree_T_SelectCondition]"
            Me.Command.CommandType = CommandType.StoredProcedure
            Try

                Me.Command.Parameters.Clear()

                If ControlConnection Then
                    Me.BeginTransaction()
                End If

                Me.Command.Parameters.Add(New SqlParameter("@Condition", "[CategoryTree_T]." + fieldName + " = N" + "'" + value.ToString + "'"))

                Dim dataReader As IDataReader = Me.Command.ExecuteReader
                Dim Result As New List(Of BLL.BLLCategoryTree_T)
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
            Me.Command.CommandText = "[sp_CategoryTree_T_SelectCondition]"
            Me.Command.CommandType = CommandType.StoredProcedure
            Try
                Me.Command.Parameters.Clear()

                Me.Command.Parameters.Add(New SqlParameter("@Condition", "[CategoryTree_T]." + fieldName + " = N" + "'" + value.ToString + "'"))

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
            Me.Command.CommandText = "[sp_CategoryTree_T_SelectCondition]"
            Me.Command.CommandType = CommandType.StoredProcedure
            Try
                Me.Command.Parameters.Clear()

                Me.Command.Parameters.Add(New SqlParameter("@Condition", "[CategoryTree_T]." + fieldName + " = N" + "'" + value.ToString + "'"))

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
            Me.Command.CommandText = "[sp_CategoryTree_T_SelectCondition]"
            Me.Command.CommandType = CommandType.StoredProcedure
            Try
                Me.Command.Parameters.Clear()

                Me.Command.Parameters.Add(New SqlParameter("@Condition", "[CategoryTree_T]." + fieldName + " = N" + "'" + value.ToString + "'"))

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

        Public Function SelectByCondition(ByVal Condition As String) As List(Of BLL.BLLCategoryTree_T)
            Dim ControlConnection As Boolean = Not Me.ConnectionState = Data.ConnectionState.Open
            Me.Command.CommandText = "[sp_CategoryTree_T_SelectCondition]"
            Me.Command.CommandType = CommandType.StoredProcedure
            Try
                Me.Command.Parameters.Clear()

                Me.Command.Parameters.Add(New SqlParameter("@Condition", Condition))

                If ControlConnection Then
                    Me.BeginTransaction()
                End If

                Dim dataReader As IDataReader = Me.Command.ExecuteReader
                Dim Result As New List(Of BLL.BLLCategoryTree_T)
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
            Me.Command.CommandText = "[sp_CategoryTree_T_SelectCondition]"
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
            Me.Command.CommandText = "[sp_CategoryTree_T_SelectCondition]"
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
            Me.Command.CommandText = "[sp_CategoryTree_T_SelectCondition]"
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

        Public Sub Delete(ByVal businessObjectKey As BLL.BLLCategoryTree_TKeys)
            Dim ControlConnection As Boolean = Not Me.ConnectionState = Data.ConnectionState.Open
            Me.Command.CommandText = "[sp_CategoryTree_T_DeleteByPrimaryKey]"
            Me.Command.CommandType = CommandType.StoredProcedure

            Try
                Me.Command.Parameters.Clear()

                Dim CategoryTreeID_bint As New SqlParameter
                CategoryTreeID_bint.ParameterName = "@CategoryTreeID_bint"
                CategoryTreeID_bint.SqlDbType = SqlDbType.BigInt
                CategoryTreeID_bint.Direction = ParameterDirection.Input
                CategoryTreeID_bint.IsNullable = False
                CategoryTreeID_bint.Value = businessObjectKey.CategoryTreeID_bint
                Me.Command.Parameters.Add(CategoryTreeID_bint)


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
            Me.Command.CommandText = "[sp_CategoryTree_T_DeleteByField]"
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

        Friend Sub PopulateBusinessObjectFromReader(ByVal businessObject As BLL.BLLCategoryTree_T, ByVal dataReader As IDataReader)
            businessObject.CategoryTreeID_bint = dataReader.GetInt64(dataReader.GetOrdinal(BLL.BLLCategoryTree_T.CategoryTree_TField.CategoryTreeID_bint.ToString))
            If dataReader.IsDBNull(dataReader.GetOrdinal(BLL.BLLCategoryTree_T.CategoryTree_TField.CategoryID_bint.ToString)) = False Then
                businessObject.CategoryID_bint = dataReader.GetInt64(dataReader.GetOrdinal(BLL.BLLCategoryTree_T.CategoryTree_TField.CategoryID_bint.ToString))
            Else
                businessObject.CategoryID_bint = Nothing
            End If

            businessObject.Node_nvc = dataReader.GetString(dataReader.GetOrdinal(BLL.BLLCategoryTree_T.CategoryTree_TField.Node_nvc.ToString))
            If dataReader.IsDBNull(dataReader.GetOrdinal(BLL.BLLCategoryTree_T.CategoryTree_TField.ParentID_bint.ToString)) = False Then
                businessObject.ParentID_bint = dataReader.GetInt64(dataReader.GetOrdinal(BLL.BLLCategoryTree_T.CategoryTree_TField.ParentID_bint.ToString))
            Else
                businessObject.ParentID_bint = Nothing
            End If

        End Sub

        Friend Function PopulateObjectsFromReader(ByVal dataReader As IDataReader) As List(Of BLL.BLLCategoryTree_T)
            Dim list As New List(Of BLL.BLLCategoryTree_T)
            While dataReader.Read
                Dim businessObject As New BLL.BLLCategoryTree_T
                PopulateBusinessObjectFromReader(businessObject, dataReader)
                list.Add(businessObject)
            End While
            Return list
        End Function

    End Class
End Namespace