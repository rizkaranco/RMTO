Imports System
Imports System.Data
Imports System.Data.SqlTypes
Imports System.Data.SqlClient
Imports System.Collections.Generic

Namespace DAL
    Class DALCategoryMember_T
        Inherits DAL.DataLayerBase

        Public Sub New()
            MyBase.New(Common.ConnectionString.ConnectionString)
        End Sub

        Public Sub Insert(ByVal businessObject As BLL.BLLCategoryMember_T)
            Dim ControlConnection As Boolean = Not Me.ConnectionState = Data.ConnectionState.Open
            Me.Command.CommandText = "[sp_CategoryMember_T_Add]"
            Me.Command.CommandType = CommandType.StoredProcedure

            Try
                Me.Command.Parameters.Clear()

                Dim CategotyMemberID_bint As New SqlParameter
                CategotyMemberID_bint.ParameterName = "@CategotyMemberID_bint"
                CategotyMemberID_bint.SqlDbType = SqlDbType.BigInt
                CategotyMemberID_bint.Direction = ParameterDirection.Output
                CategotyMemberID_bint.IsNullable = False
                CategotyMemberID_bint.Value = businessObject.CategotyMemberID_bint
                Me.Command.Parameters.Add(CategotyMemberID_bint)

                Dim CategoryTreeID_bint As New SqlParameter
                CategoryTreeID_bint.ParameterName = "@CategoryTreeID_bint"
                CategoryTreeID_bint.SqlDbType = SqlDbType.BigInt
                CategoryTreeID_bint.Direction = ParameterDirection.Input
                CategoryTreeID_bint.IsNullable = True
                If businessObject.CategoryTreeID_bint.HasValue = False Then
                    CategoryTreeID_bint.Value = DBNull.Value
                Else
                    CategoryTreeID_bint.Value = businessObject.CategoryTreeID_bint
                End If
                Me.Command.Parameters.Add(CategoryTreeID_bint)

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

                Dim MemberID_nvc As New SqlParameter
                MemberID_nvc.ParameterName = "@MemberID_nvc"
                MemberID_nvc.SqlDbType = SqlDbType.NVarChar
                MemberID_nvc.Direction = ParameterDirection.Input
                MemberID_nvc.IsNullable = True
                If String.IsNullOrEmpty(businessObject.MemberID_nvc) Then
                    MemberID_nvc.Value = DBNull.Value
                Else
                    MemberID_nvc.Value = businessObject.MemberID_nvc
                End If
                Me.Command.Parameters.Add(MemberID_nvc)

                If ControlConnection Then
                    Me.BeginTransaction()
                End If

                Me.Command.ExecuteNonQuery()

                businessObject.CategotyMemberID_bint = Me.Command.Parameters("@CategotyMemberID_bint").Value

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

        Public Sub Update(ByVal businessObject As BLL.BLLCategoryMember_T, ByVal businessObjectKey As BLL.BLLCategoryMember_TKeys)
            Dim ControlConnection As Boolean = Not Me.ConnectionState = Data.ConnectionState.Open
            Me.Command.CommandText = "[sp_CategoryMember_T_Update]"
            Me.Command.CommandType = CommandType.StoredProcedure

            Try
                Me.Command.Parameters.Clear()

                Dim CategoryTreeID_bint As New SqlParameter
                CategoryTreeID_bint.ParameterName = "@CategoryTreeID_bint"
                CategoryTreeID_bint.SqlDbType = SqlDbType.BigInt
                CategoryTreeID_bint.Direction = ParameterDirection.Input
                CategoryTreeID_bint.IsNullable = True
                If businessObject.CategoryTreeID_bint.HasValue = False Then
                    CategoryTreeID_bint.Value = DBNull.Value
                Else
                    CategoryTreeID_bint.Value = businessObject.CategoryTreeID_bint
                End If
                Me.Command.Parameters.Add(CategoryTreeID_bint)

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

                Dim MemberID_nvc As New SqlParameter
                MemberID_nvc.ParameterName = "@MemberID_nvc"
                MemberID_nvc.SqlDbType = SqlDbType.NVarChar
                MemberID_nvc.Direction = ParameterDirection.Input
                MemberID_nvc.IsNullable = True
                If String.IsNullOrEmpty(businessObject.MemberID_nvc) Then
                    MemberID_nvc.Value = DBNull.Value
                Else
                    MemberID_nvc.Value = businessObject.MemberID_nvc
                End If
                Me.Command.Parameters.Add(MemberID_nvc)

                Dim pk_CategotyMemberID_bint As New SqlParameter
                pk_CategotyMemberID_bint.ParameterName = "@pk_CategotyMemberID_bint"
                pk_CategotyMemberID_bint.SqlDbType = SqlDbType.BigInt
                pk_CategotyMemberID_bint.Direction = ParameterDirection.Input
                pk_CategotyMemberID_bint.IsNullable = False
                pk_CategotyMemberID_bint.Value = businessObjectKey.CategotyMemberID_bint
                Me.Command.Parameters.Add(pk_CategotyMemberID_bint)

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

        Public Function SelectAll() As List(Of BLL.BLLCategoryMember_T)
            Dim ControlConnection As Boolean = Not Me.ConnectionState = Data.ConnectionState.Open
            Me.Command.CommandText = "[sp_CategoryMember_T_SelectAll]"
            Me.Command.CommandType = CommandType.StoredProcedure

            Try
                Me.Command.Parameters.Clear()

                If ControlConnection Then
                    Me.BeginTransaction()
                End If

                Dim dataReader As IDataReader = Me.Command.ExecuteReader
                Dim Result As New List(Of BLL.BLLCategoryMember_T)
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
            Me.Command.CommandText = "[sp_CategoryMember_T_SelectAll]"
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
            Me.Command.CommandText = "[sp_CategoryMember_T_SelectAll]"
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
            Me.Command.CommandText = "[sp_CategoryMember_T_SelectAll]"
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

        Public Function SelectByPrimaryKey(ByVal businessObjectKey As BLL.BLLCategoryMember_TKeys) As BLL.BLLCategoryMember_T
            Dim ControlConnection As Boolean = Not Me.ConnectionState = Data.ConnectionState.Open
            Me.Command.CommandText = "[sp_CategoryMember_T_SelectByPrimaryKey]"
            Me.Command.CommandType = CommandType.StoredProcedure

            Try
                Me.Command.Parameters.Clear()

                Dim CategotyMemberID_bint As New SqlParameter
                CategotyMemberID_bint.ParameterName = "@CategotyMemberID_bint"
                CategotyMemberID_bint.SqlDbType = SqlDbType.BigInt
                CategotyMemberID_bint.Direction = ParameterDirection.Input
                CategotyMemberID_bint.IsNullable = False
                CategotyMemberID_bint.Value = businessObjectKey.CategotyMemberID_bint
                Me.Command.Parameters.Add(CategotyMemberID_bint)

                If ControlConnection Then
                    Me.BeginTransaction()
                End If

                Dim dataReader As IDataReader = Me.Command.ExecuteReader
                Dim businessObject As New BLL.BLLCategoryMember_T
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

        Public Sub SelectByPrimaryKey(ByVal businessObjectKey As BLL.BLLCategoryMember_TKeys, ByRef dataset As System.Data.DataSet, ByVal srcTable As String)
            Dim ControlConnection As Boolean = Not Me.ConnectionState = Data.ConnectionState.Open
            Dim sqlDataAdapter As New SqlDataAdapter(Me.Command)
            Me.Command.CommandText = "[sp_CategoryMember_T_SelectByPrimaryKey]"
            Me.Command.CommandType = CommandType.StoredProcedure

            Try
                Me.Command.Parameters.Clear()

                Dim CategotyMemberID_bint As New SqlParameter
                CategotyMemberID_bint.ParameterName = "@CategotyMemberID_bint"
                CategotyMemberID_bint.SqlDbType = SqlDbType.BigInt
                CategotyMemberID_bint.Direction = ParameterDirection.Input
                CategotyMemberID_bint.IsNullable = False
                CategotyMemberID_bint.Value = businessObjectKey.CategotyMemberID_bint
                Me.Command.Parameters.Add(CategotyMemberID_bint)

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

        Public Sub SelectByPrimaryKey(ByVal businessObjectKey As BLL.BLLCategoryMember_TKeys, ByRef dataset As System.Data.DataSet)
            Dim ControlConnection As Boolean = Not Me.ConnectionState = Data.ConnectionState.Open
            Dim sqlDataAdapter As New SqlDataAdapter(Me.Command)
            Me.Command.CommandText = "[sp_CategoryMember_T_SelectByPrimaryKey]"
            Me.Command.CommandType = CommandType.StoredProcedure

            Try
                Me.Command.Parameters.Clear()

                Dim CategotyMemberID_bint As New SqlParameter
                CategotyMemberID_bint.ParameterName = "@CategotyMemberID_bint"
                CategotyMemberID_bint.SqlDbType = SqlDbType.BigInt
                CategotyMemberID_bint.Direction = ParameterDirection.Input
                CategotyMemberID_bint.IsNullable = False
                CategotyMemberID_bint.Value = businessObjectKey.CategotyMemberID_bint
                Me.Command.Parameters.Add(CategotyMemberID_bint)

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

        Public Sub SelectByPrimaryKey(ByVal businessObjectKey As BLL.BLLCategoryMember_TKeys, ByRef dataTable As System.Data.DataTable)
            Dim ControlConnection As Boolean = Not Me.ConnectionState = Data.ConnectionState.Open
            Dim sqlDataAdapter As New SqlDataAdapter(Me.Command)
            Me.Command.CommandText = "[sp_CategoryMember_T_SelectByPrimaryKey]"
            Me.Command.CommandType = CommandType.StoredProcedure

            Try
                Me.Command.Parameters.Clear()

                Dim CategotyMemberID_bint As New SqlParameter
                CategotyMemberID_bint.ParameterName = "@CategotyMemberID_bint"
                CategotyMemberID_bint.SqlDbType = SqlDbType.BigInt
                CategotyMemberID_bint.Direction = ParameterDirection.Input
                CategotyMemberID_bint.IsNullable = False
                CategotyMemberID_bint.Value = businessObjectKey.CategotyMemberID_bint
                Me.Command.Parameters.Add(CategotyMemberID_bint)

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

        Public Function SelectByField(ByVal fieldName As String, ByVal value As Object) As List(Of BLL.BLLCategoryMember_T)
            Dim ControlConnection As Boolean = Not Me.ConnectionState = Data.ConnectionState.Open
            Me.Command.CommandText = "[sp_CategoryMember_T_SelectCondition]"
            Me.Command.CommandType = CommandType.StoredProcedure
            Try

                Me.Command.Parameters.Clear()

                If ControlConnection Then
                    Me.BeginTransaction()
                End If

                Me.Command.Parameters.Add(New SqlParameter("@Condition", "[CategoryMember_T]." + fieldName + " = N" + "'" + value.ToString + "'"))

                Dim dataReader As IDataReader = Me.Command.ExecuteReader
                Dim Result As New List(Of BLL.BLLCategoryMember_T)
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
            Me.Command.CommandText = "[sp_CategoryMember_T_SelectCondition]"
            Me.Command.CommandType = CommandType.StoredProcedure
            Try
                Me.Command.Parameters.Clear()

                Me.Command.Parameters.Add(New SqlParameter("@Condition", "[CategoryMember_T]." + fieldName + " = N" + "'" + value.ToString + "'"))

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
            Me.Command.CommandText = "[sp_CategoryMember_T_SelectCondition]"
            Me.Command.CommandType = CommandType.StoredProcedure
            Try
                Me.Command.Parameters.Clear()

                Me.Command.Parameters.Add(New SqlParameter("@Condition", "[CategoryMember_T]." + fieldName + " = N" + "'" + value.ToString + "'"))

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
            Me.Command.CommandText = "[sp_CategoryMember_T_SelectCondition]"
            Me.Command.CommandType = CommandType.StoredProcedure
            Try
                Me.Command.Parameters.Clear()

                Me.Command.Parameters.Add(New SqlParameter("@Condition", "[CategoryMember_T]." + fieldName + " = N" + "'" + value.ToString + "'"))

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

        Public Function SelectByCondition(ByVal Condition As String) As List(Of BLL.BLLCategoryMember_T)
            Dim ControlConnection As Boolean = Not Me.ConnectionState = Data.ConnectionState.Open
            Me.Command.CommandText = "[sp_CategoryMember_T_SelectCondition]"
            Me.Command.CommandType = CommandType.StoredProcedure
            Try
                Me.Command.Parameters.Clear()

                Me.Command.Parameters.Add(New SqlParameter("@Condition", Condition))

                If ControlConnection Then
                    Me.BeginTransaction()
                End If

                Dim dataReader As IDataReader = Me.Command.ExecuteReader
                Dim Result As New List(Of BLL.BLLCategoryMember_T)
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
            Me.Command.CommandText = "[sp_CategoryMember_T_SelectCondition]"
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
            Me.Command.CommandText = "[sp_CategoryMember_T_SelectCondition]"
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
            Me.Command.CommandText = "[sp_CategoryMember_T_SelectCondition]"
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

        Public Sub Delete(ByVal businessObjectKey As BLL.BLLCategoryMember_TKeys)
            Dim ControlConnection As Boolean = Not Me.ConnectionState = Data.ConnectionState.Open
            Me.Command.CommandText = "[sp_CategoryMember_T_DeleteByPrimaryKey]"
            Me.Command.CommandType = CommandType.StoredProcedure

            Try
                Me.Command.Parameters.Clear()

                Dim CategotyMemberID_bint As New SqlParameter
                CategotyMemberID_bint.ParameterName = "@CategotyMemberID_bint"
                CategotyMemberID_bint.SqlDbType = SqlDbType.BigInt
                CategotyMemberID_bint.Direction = ParameterDirection.Input
                CategotyMemberID_bint.IsNullable = False
                CategotyMemberID_bint.Value = businessObjectKey.CategotyMemberID_bint
                Me.Command.Parameters.Add(CategotyMemberID_bint)

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
            Me.Command.CommandText = "[sp_CategoryMember_T_DeleteByField]"
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

        Public Sub DeleteByMemberID_nvc(ByVal MemberID_nvc As String, ByVal TableID_bint As Int64)
            Dim ControlConnection As Boolean = Not Me.ConnectionState = Data.ConnectionState.Open
            Me.Command.CommandText = "[sp_CategoryMember_T_DeleteByMemberID_nvc]"
            Me.Command.CommandType = CommandType.StoredProcedure

            Try
                Me.Command.Parameters.Clear()

                Me.Command.Parameters.Add(New SqlParameter("@MemberID_nvc", MemberID_nvc))
                Me.Command.Parameters.Add(New SqlParameter("@TableID_bint", TableID_bint))

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

        Friend Sub PopulateBusinessObjectFromReader(ByVal businessObject As BLL.BLLCategoryMember_T, ByVal dataReader As IDataReader)
            businessObject.CategotyMemberID_bint = dataReader.GetInt64(dataReader.GetOrdinal(BLL.BLLCategoryMember_T.CategoryMember_TField.CategotyMemberID_bint.ToString))
            If dataReader.IsDBNull(dataReader.GetOrdinal(BLL.BLLCategoryMember_T.CategoryMember_TField.CategoryTreeID_bint.ToString)) = False Then
                businessObject.CategoryTreeID_bint = dataReader.GetInt64(dataReader.GetOrdinal(BLL.BLLCategoryMember_T.CategoryMember_TField.CategoryTreeID_bint.ToString))
            Else
                businessObject.CategoryTreeID_bint = Nothing
            End If

            If dataReader.IsDBNull(dataReader.GetOrdinal(BLL.BLLCategoryMember_T.CategoryMember_TField.TableID_bint.ToString)) = False Then
                businessObject.TableID_bint = dataReader.GetInt64(dataReader.GetOrdinal(BLL.BLLCategoryMember_T.CategoryMember_TField.TableID_bint.ToString))
            Else
                businessObject.TableID_bint = Nothing
            End If

            If dataReader.IsDBNull(dataReader.GetOrdinal(BLL.BLLCategoryMember_T.CategoryMember_TField.MemberID_nvc.ToString)) = False Then
                businessObject.MemberID_nvc = dataReader.GetString(dataReader.GetOrdinal(BLL.BLLCategoryMember_T.CategoryMember_TField.MemberID_nvc.ToString))
            Else
                businessObject.MemberID_nvc = String.Empty
            End If
        End Sub

        Friend Function PopulateObjectsFromReader(ByVal dataReader As IDataReader) As List(Of BLL.BLLCategoryMember_T)
            Dim list As New List(Of BLL.BLLCategoryMember_T)
            While dataReader.Read
                Dim businessObject As New BLL.BLLCategoryMember_T
                PopulateBusinessObjectFromReader(businessObject, dataReader)
                list.Add(businessObject)
            End While
            Return list
        End Function

    End Class
End Namespace