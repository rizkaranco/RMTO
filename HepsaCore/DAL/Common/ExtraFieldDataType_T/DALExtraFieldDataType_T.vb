Imports System
Imports System.Data
Imports System.Data.SqlTypes
Imports System.Data.SqlClient
Imports System.Collections.Generic

Namespace DAL
    Class DALExtraFieldDataType_T

        Inherits DAL.DataLayerBase

        Public Sub New()
            MyBase.New(Common.ConnectionString.ConnectionString)
        End Sub

        Public Sub Insert(ByVal businessObject As BLL.BLLExtraFieldDataType_T)
            Dim ControlConnection As Boolean = Not Me.ConnectionState = Data.ConnectionState.Open
            Me.Command.CommandText = "[sp_ExtraFieldDataType_T_Add]"
            Me.Command.CommandType = CommandType.StoredProcedure

            Try
                Me.Command.Parameters.Clear()

                Dim ExtraFieldDataTypeID_tint As New SqlParameter
                ExtraFieldDataTypeID_tint.ParameterName = "@ExtraFieldDataTypeID_tint"
                ExtraFieldDataTypeID_tint.SqlDbType = SqlDbType.TinyInt
                ExtraFieldDataTypeID_tint.Direction = ParameterDirection.Input
                ExtraFieldDataTypeID_tint.IsNullable = False
                ExtraFieldDataTypeID_tint.Value = businessObject.ExtraFieldDataTypeID_tint
                Me.Command.Parameters.Add(ExtraFieldDataTypeID_tint)

                Dim ExtraFieldDataType_nvc As New SqlParameter
                ExtraFieldDataType_nvc.ParameterName = "@ExtraFieldDataType_nvc"
                ExtraFieldDataType_nvc.SqlDbType = SqlDbType.NVarChar
                ExtraFieldDataType_nvc.Direction = ParameterDirection.Input
                ExtraFieldDataType_nvc.IsNullable = False
                ExtraFieldDataType_nvc.Value = businessObject.ExtraFieldDataType_nvc
                Me.Command.Parameters.Add(ExtraFieldDataType_nvc)

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

        Public Sub Update(ByVal businessObject As BLL.BLLExtraFieldDataType_T, ByVal businessObjectKey As BLL.BLLExtraFieldDataType_TKeys)
            Dim ControlConnection As Boolean = Not Me.ConnectionState = Data.ConnectionState.Open
            Me.Command.CommandText = "[sp_ExtraFieldDataType_T_Update]"
            Me.Command.CommandType = CommandType.StoredProcedure

            Try
                Me.Command.Parameters.Clear()

                Dim ExtraFieldDataTypeID_tint As New SqlParameter
                ExtraFieldDataTypeID_tint.ParameterName = "@ExtraFieldDataTypeID_tint"
                ExtraFieldDataTypeID_tint.SqlDbType = SqlDbType.TinyInt
                ExtraFieldDataTypeID_tint.Direction = ParameterDirection.Input
                ExtraFieldDataTypeID_tint.IsNullable = False
                ExtraFieldDataTypeID_tint.Value = businessObject.ExtraFieldDataTypeID_tint
                Me.Command.Parameters.Add(ExtraFieldDataTypeID_tint)

                Dim ExtraFieldDataType_nvc As New SqlParameter
                ExtraFieldDataType_nvc.ParameterName = "@ExtraFieldDataType_nvc"
                ExtraFieldDataType_nvc.SqlDbType = SqlDbType.NVarChar
                ExtraFieldDataType_nvc.Direction = ParameterDirection.Input
                ExtraFieldDataType_nvc.IsNullable = False
                ExtraFieldDataType_nvc.Value = businessObject.ExtraFieldDataType_nvc
                Me.Command.Parameters.Add(ExtraFieldDataType_nvc)


                Dim pk_ExtraFieldDataTypeID_tint As New SqlParameter
                pk_ExtraFieldDataTypeID_tint.ParameterName = "@pk_ExtraFieldDataTypeID_tint"
                pk_ExtraFieldDataTypeID_tint.SqlDbType = SqlDbType.TinyInt
                pk_ExtraFieldDataTypeID_tint.Direction = ParameterDirection.Input
                pk_ExtraFieldDataTypeID_tint.IsNullable = False
                pk_ExtraFieldDataTypeID_tint.Value = businessObjectKey.ExtraFieldDataTypeID_tint
                Me.Command.Parameters.Add(pk_ExtraFieldDataTypeID_tint)

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

        Public Function SelectAll() As List(Of BLL.BLLExtraFieldDataType_T)
            Dim ControlConnection As Boolean = Not Me.ConnectionState = Data.ConnectionState.Open
            Me.Command.CommandText = "[sp_ExtraFieldDataType_T_SelectAll]"
            Me.Command.CommandType = CommandType.StoredProcedure

            Try
                Me.Command.Parameters.Clear()

                If ControlConnection Then
                    Me.BeginTransaction()
                End If

                Dim dataReader As IDataReader = Me.Command.ExecuteReader
                Dim Result As New List(Of BLL.BLLExtraFieldDataType_T)
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
            Me.Command.CommandText = "[sp_ExtraFieldDataType_T_SelectAll]"
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
            Me.Command.CommandText = "[sp_ExtraFieldDataType_T_SelectAll]"
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
            Me.Command.CommandText = "[sp_ExtraFieldDataType_T_SelectAll]"
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

        Public Function SelectByPrimaryKey(ByVal businessObjectKey As BLL.BLLExtraFieldDataType_TKeys) As BLL.BLLExtraFieldDataType_T
            Dim ControlConnection As Boolean = Not Me.ConnectionState = Data.ConnectionState.Open
            Me.Command.CommandText = "[sp_ExtraFieldDataType_T_SelectByPrimaryKey]"
            Me.Command.CommandType = CommandType.StoredProcedure

            Try
                Me.Command.Parameters.Clear()

                Dim ExtraFieldDataTypeID_tint As New SqlParameter
                ExtraFieldDataTypeID_tint.ParameterName = "@ExtraFieldDataTypeID_tint"
                ExtraFieldDataTypeID_tint.SqlDbType = SqlDbType.TinyInt
                ExtraFieldDataTypeID_tint.Direction = ParameterDirection.Input
                ExtraFieldDataTypeID_tint.IsNullable = False
                ExtraFieldDataTypeID_tint.Value = businessObjectKey.ExtraFieldDataTypeID_tint
                Me.Command.Parameters.Add(ExtraFieldDataTypeID_tint)


                If ControlConnection Then
                    Me.BeginTransaction()
                End If

                Dim dataReader As IDataReader = Me.Command.ExecuteReader
                Dim businessObject As New BLL.BLLExtraFieldDataType_T
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

        Public Sub SelectByPrimaryKey(ByVal businessObjectKey As BLL.BLLExtraFieldDataType_TKeys, ByRef dataset As System.Data.DataSet, ByVal srcTable As String)
            Dim ControlConnection As Boolean = Not Me.ConnectionState = Data.ConnectionState.Open
            Dim sqlDataAdapter As New SqlDataAdapter(Me.Command)
            Me.Command.CommandText = "[sp_ExtraFieldDataType_T_SelectByPrimaryKey]"
            Me.Command.CommandType = CommandType.StoredProcedure

            Try
                Me.Command.Parameters.Clear()

                Dim ExtraFieldDataTypeID_tint As New SqlParameter
                ExtraFieldDataTypeID_tint.ParameterName = "@ExtraFieldDataTypeID_tint"
                ExtraFieldDataTypeID_tint.SqlDbType = SqlDbType.TinyInt
                ExtraFieldDataTypeID_tint.Direction = ParameterDirection.Input
                ExtraFieldDataTypeID_tint.IsNullable = False
                ExtraFieldDataTypeID_tint.Value = businessObjectKey.ExtraFieldDataTypeID_tint
                Me.Command.Parameters.Add(ExtraFieldDataTypeID_tint)


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

        Public Sub SelectByPrimaryKey(ByVal businessObjectKey As BLL.BLLExtraFieldDataType_TKeys, ByRef dataset As System.Data.DataSet)
            Dim ControlConnection As Boolean = Not Me.ConnectionState = Data.ConnectionState.Open
            Dim sqlDataAdapter As New SqlDataAdapter(Me.Command)
            Me.Command.CommandText = "[sp_ExtraFieldDataType_T_SelectByPrimaryKey]"
            Me.Command.CommandType = CommandType.StoredProcedure

            Try
                Me.Command.Parameters.Clear()

                Dim ExtraFieldDataTypeID_tint As New SqlParameter
                ExtraFieldDataTypeID_tint.ParameterName = "@ExtraFieldDataTypeID_tint"
                ExtraFieldDataTypeID_tint.SqlDbType = SqlDbType.TinyInt
                ExtraFieldDataTypeID_tint.Direction = ParameterDirection.Input
                ExtraFieldDataTypeID_tint.IsNullable = False
                ExtraFieldDataTypeID_tint.Value = businessObjectKey.ExtraFieldDataTypeID_tint
                Me.Command.Parameters.Add(ExtraFieldDataTypeID_tint)


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

        Public Sub SelectByPrimaryKey(ByVal businessObjectKey As BLL.BLLExtraFieldDataType_TKeys, ByRef dataTable As System.Data.DataTable)
            Dim ControlConnection As Boolean = Not Me.ConnectionState = Data.ConnectionState.Open
            Dim sqlDataAdapter As New SqlDataAdapter(Me.Command)
            Me.Command.CommandText = "[sp_ExtraFieldDataType_T_SelectByPrimaryKey]"
            Me.Command.CommandType = CommandType.StoredProcedure

            Try
                Me.Command.Parameters.Clear()

                Dim ExtraFieldDataTypeID_tint As New SqlParameter
                ExtraFieldDataTypeID_tint.ParameterName = "@ExtraFieldDataTypeID_tint"
                ExtraFieldDataTypeID_tint.SqlDbType = SqlDbType.TinyInt
                ExtraFieldDataTypeID_tint.Direction = ParameterDirection.Input
                ExtraFieldDataTypeID_tint.IsNullable = False
                ExtraFieldDataTypeID_tint.Value = businessObjectKey.ExtraFieldDataTypeID_tint
                Me.Command.Parameters.Add(ExtraFieldDataTypeID_tint)

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

        Public Function SelectByField(ByVal fieldName As String, ByVal value As Object) As List(Of BLL.BLLExtraFieldDataType_T)
            Dim ControlConnection As Boolean = Not Me.ConnectionState = Data.ConnectionState.Open
            Me.Command.CommandText = "[sp_ExtraFieldDataType_T_SelectCondition]"
            Me.Command.CommandType = CommandType.StoredProcedure
            Try

                Me.Command.Parameters.Clear()

                If ControlConnection Then
                    Me.BeginTransaction()
                End If

                Me.Command.Parameters.Add(New SqlParameter("@Condition", "[ExtraFieldDataType_T]." + fieldName + " = N" + "'" + value.ToString + "'"))

                Dim dataReader As IDataReader = Me.Command.ExecuteReader
                Dim Result As New List(Of BLL.BLLExtraFieldDataType_T)
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
            Me.Command.CommandText = "[sp_ExtraFieldDataType_T_SelectCondition]"
            Me.Command.CommandType = CommandType.StoredProcedure
            Try
                Me.Command.Parameters.Clear()

                Me.Command.Parameters.Add(New SqlParameter("@Condition", "[ExtraFieldDataType_T]." + fieldName + " = N" + "'" + value.ToString + "'"))

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
            Me.Command.CommandText = "[sp_ExtraFieldDataType_T_SelectCondition]"
            Me.Command.CommandType = CommandType.StoredProcedure
            Try
                Me.Command.Parameters.Clear()

                Me.Command.Parameters.Add(New SqlParameter("@Condition", "[ExtraFieldDataType_T]." + fieldName + " = N" + "'" + value.ToString + "'"))

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
            Me.Command.CommandText = "[sp_ExtraFieldDataType_T_SelectCondition]"
            Me.Command.CommandType = CommandType.StoredProcedure
            Try
                Me.Command.Parameters.Clear()

                Me.Command.Parameters.Add(New SqlParameter("@Condition", "[ExtraFieldDataType_T]." + fieldName + " = N" + "'" + value.ToString + "'"))

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

        Public Function SelectByCondition(ByVal Condition As String) As List(Of BLL.BLLExtraFieldDataType_T)
            Dim ControlConnection As Boolean = Not Me.ConnectionState = Data.ConnectionState.Open
            Me.Command.CommandText = "[sp_ExtraFieldDataType_T_SelectCondition]"
            Me.Command.CommandType = CommandType.StoredProcedure
            Try
                Me.Command.Parameters.Clear()

                Me.Command.Parameters.Add(New SqlParameter("@Condition", Condition))

                If ControlConnection Then
                    Me.BeginTransaction()
                End If

                Dim dataReader As IDataReader = Me.Command.ExecuteReader
                Dim Result As New List(Of BLL.BLLExtraFieldDataType_T)
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
            Me.Command.CommandText = "[sp_ExtraFieldDataType_T_SelectCondition]"
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
            Me.Command.CommandText = "[sp_ExtraFieldDataType_T_SelectCondition]"
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
            Me.Command.CommandText = "[sp_ExtraFieldDataType_T_SelectCondition]"
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

        Public Sub Delete(ByVal businessObjectKey As BLL.BLLExtraFieldDataType_TKeys)
            Dim ControlConnection As Boolean = Not Me.ConnectionState = Data.ConnectionState.Open
            Me.Command.CommandText = "[sp_ExtraFieldDataType_T_DeleteByPrimaryKey]"
            Me.Command.CommandType = CommandType.StoredProcedure

            Try
                Me.Command.Parameters.Clear()

                Dim ExtraFieldDataTypeID_tint As New SqlParameter
                ExtraFieldDataTypeID_tint.ParameterName = "@ExtraFieldDataTypeID_tint"
                ExtraFieldDataTypeID_tint.SqlDbType = SqlDbType.TinyInt
                ExtraFieldDataTypeID_tint.Direction = ParameterDirection.Input
                ExtraFieldDataTypeID_tint.IsNullable = False
                ExtraFieldDataTypeID_tint.Value = businessObjectKey.ExtraFieldDataTypeID_tint
                Me.Command.Parameters.Add(ExtraFieldDataTypeID_tint)

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
            Me.Command.CommandText = "[sp_ExtraFieldDataType_T_DeleteByField]"
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

        Friend Sub PopulateBusinessObjectFromReader(ByVal businessObject As BLL.BLLExtraFieldDataType_T, ByVal dataReader As IDataReader)
            businessObject.ExtraFieldDataTypeID_tint = dataReader.GetByte(dataReader.GetOrdinal(BLL.BLLExtraFieldDataType_T.ExtraFieldDataType_TField.ExtraFieldDataTypeID_tint.ToString))
            businessObject.ExtraFieldDataType_nvc = dataReader.GetString(dataReader.GetOrdinal(BLL.BLLExtraFieldDataType_T.ExtraFieldDataType_TField.ExtraFieldDataType_nvc.ToString))
        End Sub

        Friend Function PopulateObjectsFromReader(ByVal dataReader As IDataReader) As List(Of BLL.BLLExtraFieldDataType_T)
            Dim list As New List(Of BLL.BLLExtraFieldDataType_T)
            While dataReader.Read
                Dim businessObject As New BLL.BLLExtraFieldDataType_T
                PopulateBusinessObjectFromReader(businessObject, dataReader)
                list.Add(businessObject)
            End While
            Return list
        End Function

    End Class
End Namespace