Imports System
Imports System.Data
Imports System.Data.SqlTypes
Imports System.Data.SqlClient
Imports System.Collections.Generic


Namespace DAL
    Class DALForm_T

        Inherits DataLayerBase

        Public Sub New()
            MyBase.New("")
        End Sub

        Public Sub Insert(ByVal businessObject As BLL.BLLForm_T)
            Dim ControlConnection As Boolean = Not Me.ConnectionState = Data.ConnectionState.Open
            Me.Command.CommandText = "[sp_Form_T_Add]"
            Me.Command.CommandType = CommandType.StoredProcedure

            Try
                Me.Command.Parameters.Clear()

                Dim FormID_int As New SqlParameter
                FormID_int.ParameterName = "@FormID_int"
                FormID_int.SqlDbType = SqlDbType.Int
                FormID_int.Direction = ParameterDirection.Output
                FormID_int.IsNullable = False
                FormID_int.Value = businessObject.FormID_int
                Me.Command.Parameters.Add(FormID_int)

                Dim FormName_nvc As New SqlParameter
                FormName_nvc.ParameterName = "@FormName_nvc"
                FormName_nvc.SqlDbType = SqlDbType.NVarChar
                FormName_nvc.Direction = ParameterDirection.Input
                FormName_nvc.IsNullable = False
                FormName_nvc.Value = businessObject.FormName_nvc
                Me.Command.Parameters.Add(FormName_nvc)

                Dim FormText_nvc As New SqlParameter
                FormText_nvc.ParameterName = "@FormText_nvc"
                FormText_nvc.SqlDbType = SqlDbType.NVarChar
                FormText_nvc.Direction = ParameterDirection.Input
                FormText_nvc.IsNullable = False
                FormText_nvc.Value = businessObject.FormText_nvc
                Me.Command.Parameters.Add(FormText_nvc)



                If ControlConnection Then
                    Me.BeginTransaction()
                End If

                Me.Command.ExecuteNonQuery()

                businessObject.FormID_int = Me.Command.Parameters("@FormID_int").Value

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

        Public Sub Update(ByVal businessObject As BLL.BLLForm_T, ByVal businessObjectKey As BLL.BLLForm_TKeys)
            Dim ControlConnection As Boolean = Not Me.ConnectionState = Data.ConnectionState.Open
            Me.Command.CommandText = "[sp_Form_T_Update]"
            Me.Command.CommandType = CommandType.StoredProcedure

            Try
                Me.Command.Parameters.Clear()

                Dim FormName_nvc As New SqlParameter
                FormName_nvc.ParameterName = "@FormName_nvc"
                FormName_nvc.SqlDbType = SqlDbType.NVarChar
                FormName_nvc.Direction = ParameterDirection.Input
                FormName_nvc.IsNullable = False
                FormName_nvc.Value = businessObject.FormName_nvc
                Me.Command.Parameters.Add(FormName_nvc)

                Dim FormText_nvc As New SqlParameter
                FormText_nvc.ParameterName = "@FormText_nvc"
                FormText_nvc.SqlDbType = SqlDbType.NVarChar
                FormText_nvc.Direction = ParameterDirection.Input
                FormText_nvc.IsNullable = False
                FormText_nvc.Value = businessObject.FormText_nvc
                Me.Command.Parameters.Add(FormText_nvc)


                Dim pk_FormID_int As New SqlParameter
                pk_FormID_int.ParameterName = "@pk_FormID_int"
                pk_FormID_int.SqlDbType = SqlDbType.Int
                pk_FormID_int.Direction = ParameterDirection.Input
                pk_FormID_int.IsNullable = False
                pk_FormID_int.Value = businessObjectKey.FormID_int
                Me.Command.Parameters.Add(pk_FormID_int)



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

        Public Function SelectAll() As List(Of BLL.BLLForm_T)
            Dim ControlConnection As Boolean = Not Me.ConnectionState = Data.ConnectionState.Open
            Me.Command.CommandText = "[sp_Form_T_SelectAll]"
            Me.Command.CommandType = CommandType.StoredProcedure

            Try
                Me.Command.Parameters.Clear()

                If ControlConnection Then
                    Me.BeginTransaction()
                End If

                Dim dataReader As IDataReader = Me.Command.ExecuteReader
                Dim Result As New List(Of BLL.BLLForm_T)
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
            Me.Command.CommandText = "[sp_Form_T_SelectAll]"
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
            Me.Command.CommandText = "[sp_Form_T_SelectAll]"
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
            Me.Command.CommandText = "[sp_Form_T_SelectAll]"
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

        Public Function SelectByPrimaryKey(ByVal businessObjectKey As BLL.BLLForm_TKeys) As BLL.BLLForm_T
            Dim ControlConnection As Boolean = Not Me.ConnectionState = Data.ConnectionState.Open
            Me.Command.CommandText = "[sp_Form_T_SelectByPrimaryKey]"
            Me.Command.CommandType = CommandType.StoredProcedure

            Try
                Me.Command.Parameters.Clear()

                Dim FormID_int As New SqlParameter
                FormID_int.ParameterName = "@FormID_int"
                FormID_int.SqlDbType = SqlDbType.Int
                FormID_int.Direction = ParameterDirection.Input
                FormID_int.IsNullable = False
                FormID_int.Value = businessObjectKey.FormID_int
                Me.Command.Parameters.Add(FormID_int)



                If ControlConnection Then
                    Me.BeginTransaction()
                End If

                Dim dataReader As IDataReader = Me.Command.ExecuteReader
                Dim businessObject As New BLL.BLLForm_T
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

        Public Sub SelectByPrimaryKey(ByVal businessObjectKey As BLL.BLLForm_TKeys, ByRef dataset As System.Data.DataSet, ByVal srcTable As String)
            Dim ControlConnection As Boolean = Not Me.ConnectionState = Data.ConnectionState.Open
            Dim sqlDataAdapter As New SqlDataAdapter(Me.Command)
            Me.Command.CommandText = "[sp_Form_T_SelectByPrimaryKey]"
            Me.Command.CommandType = CommandType.StoredProcedure

            Try
                Me.Command.Parameters.Clear()

                Dim FormID_int As New SqlParameter
                FormID_int.ParameterName = "@FormID_int"
                FormID_int.SqlDbType = SqlDbType.Int
                FormID_int.Direction = ParameterDirection.Input
                FormID_int.IsNullable = False
                FormID_int.Value = businessObjectKey.FormID_int
                Me.Command.Parameters.Add(FormID_int)


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

        Public Sub SelectByPrimaryKey(ByVal businessObjectKey As BLL.BLLForm_TKeys, ByRef dataset As System.Data.DataSet)
            Dim ControlConnection As Boolean = Not Me.ConnectionState = Data.ConnectionState.Open
            Dim sqlDataAdapter As New SqlDataAdapter(Me.Command)
            Me.Command.CommandText = "[sp_Form_T_SelectByPrimaryKey]"
            Me.Command.CommandType = CommandType.StoredProcedure

            Try
                Me.Command.Parameters.Clear()

                Dim FormID_int As New SqlParameter
                FormID_int.ParameterName = "@FormID_int"
                FormID_int.SqlDbType = SqlDbType.Int
                FormID_int.Direction = ParameterDirection.Input
                FormID_int.IsNullable = False
                FormID_int.Value = businessObjectKey.FormID_int
                Me.Command.Parameters.Add(FormID_int)


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

        Public Sub SelectByPrimaryKey(ByVal businessObjectKey As BLL.BLLForm_TKeys, ByRef dataTable As System.Data.DataTable)
            Dim ControlConnection As Boolean = Not Me.ConnectionState = Data.ConnectionState.Open
            Dim sqlDataAdapter As New SqlDataAdapter(Me.Command)
            Me.Command.CommandText = "[sp_Form_T_SelectByPrimaryKey]"
            Me.Command.CommandType = CommandType.StoredProcedure

            Try
                Me.Command.Parameters.Clear()

                Dim FormID_int As New SqlParameter
                FormID_int.ParameterName = "@FormID_int"
                FormID_int.SqlDbType = SqlDbType.Int
                FormID_int.Direction = ParameterDirection.Input
                FormID_int.IsNullable = False
                FormID_int.Value = businessObjectKey.FormID_int
                Me.Command.Parameters.Add(FormID_int)



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





        Public Function SelectByField(ByVal fieldName As String, ByVal value As Object) As List(Of BLL.BLLForm_T)
            Dim ControlConnection As Boolean = Not Me.ConnectionState = Data.ConnectionState.Open
            Me.Command.CommandText = "[sp_Form_T_SelectCondition]"
            Me.Command.CommandType = CommandType.StoredProcedure
            Try

                Me.Command.Parameters.Clear()

                If ControlConnection Then
                    Me.BeginTransaction()
                End If

                Me.Command.Parameters.Add(New SqlParameter("@Condition", "[Form_T]." + fieldName + " = N" + "'" + value.ToString + "'"))

                Dim dataReader As IDataReader = Me.Command.ExecuteReader
                Dim Result As New List(Of BLL.BLLForm_T)
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
            Me.Command.CommandText = "[sp_Form_T_SelectCondition]"
            Me.Command.CommandType = CommandType.StoredProcedure
            Try
                Me.Command.Parameters.Clear()

                Me.Command.Parameters.Add(New SqlParameter("@Condition", "[Form_T]." + fieldName + " = N" + "'" + value.ToString + "'"))

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
            Me.Command.CommandText = "[sp_Form_T_SelectCondition]"
            Me.Command.CommandType = CommandType.StoredProcedure
            Try
                Me.Command.Parameters.Clear()

                Me.Command.Parameters.Add(New SqlParameter("@Condition", "[Form_T]." + fieldName + " = N" + "'" + value.ToString + "'"))

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
            Me.Command.CommandText = "[sp_Form_T_SelectCondition]"
            Me.Command.CommandType = CommandType.StoredProcedure
            Try
                Me.Command.Parameters.Clear()

                Me.Command.Parameters.Add(New SqlParameter("@Condition", "[Form_T]." + fieldName + " = N" + "'" + value.ToString + "'"))

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

        Public Function SelectByCondition(ByVal Condition As String) As List(Of BLL.BLLForm_T)
            Dim ControlConnection As Boolean = Not Me.ConnectionState = Data.ConnectionState.Open
            Me.Command.CommandText = "[sp_Form_T_SelectCondition]"
            Me.Command.CommandType = CommandType.StoredProcedure
            Try
                Me.Command.Parameters.Clear()

                Me.Command.Parameters.Add(New SqlParameter("@Condition", Condition))

                If ControlConnection Then
                    Me.BeginTransaction()
                End If

                Dim dataReader As IDataReader = Me.Command.ExecuteReader
                Dim Result As New List(Of BLL.BLLForm_T)
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
            Me.Command.CommandText = "[sp_Form_T_SelectCondition]"
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
            Me.Command.CommandText = "[sp_Form_T_SelectCondition]"
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
            Me.Command.CommandText = "[sp_Form_T_SelectCondition]"
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

        Public Sub Delete(ByVal businessObjectKey As BLL.BLLForm_TKeys)
            Dim ControlConnection As Boolean = Not Me.ConnectionState = Data.ConnectionState.Open
            Me.Command.CommandText = "[sp_Form_T_DeleteByPrimaryKey]"
            Me.Command.CommandType = CommandType.StoredProcedure

            Try
                Me.Command.Parameters.Clear()

                Dim FormID_int As New SqlParameter
                FormID_int.ParameterName = "@FormID_int"
                FormID_int.SqlDbType = SqlDbType.Int
                FormID_int.Direction = ParameterDirection.Input
                FormID_int.IsNullable = False
                FormID_int.Value = businessObjectKey.FormID_int
                Me.Command.Parameters.Add(FormID_int)


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
            Me.Command.CommandText = "[sp_Form_T_DeleteByField]"
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

        Friend Sub PopulateBusinessObjectFromReader(ByVal businessObject As BLL.BLLForm_T, ByVal dataReader As IDataReader)
            businessObject.FormID_int = dataReader.GetInt32(dataReader.GetOrdinal(BLL.BLLForm_T.Form_TField.FormID_int.ToString))
            businessObject.FormName_nvc = dataReader.GetString(dataReader.GetOrdinal(BLL.BLLForm_T.Form_TField.FormName_nvc.ToString))
            businessObject.FormText_nvc = dataReader.GetString(dataReader.GetOrdinal(BLL.BLLForm_T.Form_TField.FormText_nvc.ToString))
        End Sub

        Friend Function PopulateObjectsFromReader(ByVal dataReader As IDataReader) As List(Of BLL.BLLForm_T)
            Dim list As New List(Of BLL.BLLForm_T)
            While dataReader.Read
                Dim businessObject As New BLL.BLLForm_T
                PopulateBusinessObjectFromReader(businessObject, dataReader)
                list.Add(businessObject)
            End While
            Return list
        End Function

    End Class
End Namespace