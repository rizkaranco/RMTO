Imports System
Imports System.Data
Imports System.Data.SqlTypes
Imports System.Data.SqlClient
Imports System.Collections.Generic

Namespace DAL
    Class DALSystem_T
        Inherits Hepsa.Core.DAL.DataLayerBase

        Public Sub New()
            MyBase.New(Hepsa.Core.Common.ConnectionString.ConnectionString)
        End Sub

        Public Sub Insert(ByVal businessObject As Hepsa.Core.BLL.BLLSystem_T)
            Dim ControlConnection As Boolean = Not Me.ConnectionState = Data.ConnectionState.Open
            Me.Command.CommandText = "[sp_System_T_Add]"
            Me.Command.CommandType = CommandType.StoredProcedure

            Try
                Me.Command.Parameters.Clear()

                Dim SystemID_tint As New SqlParameter
                SystemID_tint.ParameterName = "@SystemID_tint"
                SystemID_tint.SqlDbType = SqlDbType.TinyInt
                SystemID_tint.Direction = ParameterDirection.Output
                SystemID_tint.IsNullable = False
                SystemID_tint.Value = businessObject.SystemID_int
                Me.Command.Parameters.Add(SystemID_tint)

                Dim System_nvc As New SqlParameter
                System_nvc.ParameterName = "@System_nvc"
                System_nvc.SqlDbType = SqlDbType.NVarChar
                System_nvc.Direction = ParameterDirection.Input
                System_nvc.IsNullable = False
                System_nvc.Value = businessObject.System_nvc
                Me.Command.Parameters.Add(System_nvc)

                Dim Image As New SqlParameter
                Image.ParameterName = "@Image"
                Image.SqlDbType = SqlDbType.Image
                Image.Direction = ParameterDirection.Input
                Image.IsNullable = False
                Image.Value = businessObject.Image
                Me.Command.Parameters.Add(Image)

                If ControlConnection Then
                    Me.BeginTransaction()
                End If

                Me.Command.ExecuteNonQuery()

                businessObject.SystemID_int = Me.Command.Parameters("@SystemID_int").Value

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

        Public Sub Update(ByVal businessObject As Hepsa.Core.BLL.BLLSystem_T, ByVal businessObjectKey As Hepsa.Core.BLL.BLLSystem_TKeys)
            Dim ControlConnection As Boolean = Not Me.ConnectionState = Data.ConnectionState.Open
            Me.Command.CommandText = "[sp_System_T_Update]"
            Me.Command.CommandType = CommandType.StoredProcedure

            Try
                Me.Command.Parameters.Clear()

                Dim System_nvc As New SqlParameter
                System_nvc.ParameterName = "@System_nvc"
                System_nvc.SqlDbType = SqlDbType.NVarChar
                System_nvc.Direction = ParameterDirection.Input
                System_nvc.IsNullable = False
                System_nvc.Value = businessObject.System_nvc
                Me.Command.Parameters.Add(System_nvc)

                Dim Image As New SqlParameter
                Image.ParameterName = "@Image"
                Image.SqlDbType = SqlDbType.Image
                Image.Direction = ParameterDirection.Input
                Image.IsNullable = False
                Image.Value = businessObject.Image
                Me.Command.Parameters.Add(Image)

                Dim pk_SystemID_tint As New SqlParameter
                pk_SystemID_tint.ParameterName = "@pk_SystemID_tint"
                pk_SystemID_tint.SqlDbType = SqlDbType.TinyInt
                pk_SystemID_tint.Direction = ParameterDirection.Input
                pk_SystemID_tint.IsNullable = False
                pk_SystemID_tint.Value = businessObjectKey.SystemID_tint
                Me.Command.Parameters.Add(pk_SystemID_tint)

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

        Public Function SelectAll() As List(Of Hepsa.Core.BLL.BLLSystem_T)
            Dim ControlConnection As Boolean = Not Me.ConnectionState = Data.ConnectionState.Open
            Me.Command.CommandText = "[sp_System_T_SelectAll]"
            Me.Command.CommandType = CommandType.StoredProcedure

            Try
                Me.Command.Parameters.Clear()

                If ControlConnection Then
                    Me.BeginTransaction()
                End If

                Dim dataReader As IDataReader = Me.Command.ExecuteReader
                Dim Result As New List(Of Hepsa.Core.BLL.BLLSystem_T)
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
            Me.Command.CommandText = "[sp_System_T_SelectAll]"
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
            Me.Command.CommandText = "[sp_System_T_SelectAll]"
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
            Me.Command.CommandText = "[sp_System_T_SelectAll]"
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

        Public Function SelectByPrimaryKey(ByVal businessObjectKey As Hepsa.Core.BLL.BLLSystem_TKeys) As Hepsa.Core.BLL.BLLSystem_T
            Dim ControlConnection As Boolean = Not Me.ConnectionState = Data.ConnectionState.Open
            Me.Command.CommandText = "[sp_System_T_SelectByPrimaryKey]"
            Me.Command.CommandType = CommandType.StoredProcedure

            Try
                Me.Command.Parameters.Clear()

                Dim SystemID_tint As New SqlParameter
                SystemID_tint.ParameterName = "@SystemID_tint"
                SystemID_tint.SqlDbType = SqlDbType.TinyInt
                SystemID_tint.Direction = ParameterDirection.Input
                SystemID_tint.IsNullable = False
                SystemID_tint.Value = businessObjectKey.SystemID_tint
                Me.Command.Parameters.Add(SystemID_tint)

                If ControlConnection Then
                    Me.BeginTransaction()
                End If

                Dim dataReader As IDataReader = Me.Command.ExecuteReader
                Dim businessObject As New Hepsa.Core.BLL.BLLSystem_T
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

        Public Sub SelectByPrimaryKey(ByVal businessObjectKey As Hepsa.Core.BLL.BLLSystem_TKeys, ByRef dataset As System.Data.DataSet, ByVal srcTable As String)
            Dim ControlConnection As Boolean = Not Me.ConnectionState = Data.ConnectionState.Open
            Dim sqlDataAdapter As New SqlDataAdapter(Me.Command)
            Me.Command.CommandText = "[sp_System_T_SelectByPrimaryKey]"
            Me.Command.CommandType = CommandType.StoredProcedure

            Try
                Me.Command.Parameters.Clear()

                Dim SystemID_tint As New SqlParameter
                SystemID_tint.ParameterName = "@SystemID_tint"
                SystemID_tint.SqlDbType = SqlDbType.TinyInt
                SystemID_tint.Direction = ParameterDirection.Input
                SystemID_tint.IsNullable = False
                SystemID_tint.Value = businessObjectKey.SystemID_tint
                Me.Command.Parameters.Add(SystemID_tint)

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

        Public Sub SelectByPrimaryKey(ByVal businessObjectKey As Hepsa.Core.BLL.BLLSystem_TKeys, ByRef dataset As System.Data.DataSet)
            Dim ControlConnection As Boolean = Not Me.ConnectionState = Data.ConnectionState.Open
            Dim sqlDataAdapter As New SqlDataAdapter(Me.Command)
            Me.Command.CommandText = "[sp_System_T_SelectByPrimaryKey]"
            Me.Command.CommandType = CommandType.StoredProcedure

            Try
                Me.Command.Parameters.Clear()

                Dim SystemID_tint As New SqlParameter
                SystemID_tint.ParameterName = "@SystemID_tint"
                SystemID_tint.SqlDbType = SqlDbType.TinyInt
                SystemID_tint.Direction = ParameterDirection.Input
                SystemID_tint.IsNullable = False
                SystemID_tint.Value = businessObjectKey.SystemID_tint
                Me.Command.Parameters.Add(SystemID_tint)

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

        Public Sub SelectByPrimaryKey(ByVal businessObjectKey As Hepsa.Core.BLL.BLLSystem_TKeys, ByRef dataTable As System.Data.DataTable)
            Dim ControlConnection As Boolean = Not Me.ConnectionState = Data.ConnectionState.Open
            Dim sqlDataAdapter As New SqlDataAdapter(Me.Command)
            Me.Command.CommandText = "[sp_System_T_SelectByPrimaryKey]"
            Me.Command.CommandType = CommandType.StoredProcedure

            Try
                Me.Command.Parameters.Clear()

                Dim SystemID_tint As New SqlParameter
                SystemID_tint.ParameterName = "@SystemID_tint"
                SystemID_tint.SqlDbType = SqlDbType.TinyInt
                SystemID_tint.Direction = ParameterDirection.Input
                SystemID_tint.IsNullable = False
                SystemID_tint.Value = businessObjectKey.SystemID_tint
                Me.Command.Parameters.Add(SystemID_tint)

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

        Public Function SelectByField(ByVal fieldName As String, ByVal value As Object) As List(Of Hepsa.Core.BLL.BLLSystem_T)
            Dim ControlConnection As Boolean = Not Me.ConnectionState = Data.ConnectionState.Open
            Me.Command.CommandText = "[sp_System_T_SelectCondition]"
            Me.Command.CommandType = CommandType.StoredProcedure
            Try

                Me.Command.Parameters.Clear()

                If ControlConnection Then
                    Me.BeginTransaction()
                End If

                Me.Command.Parameters.Add(New SqlParameter("@Condition", "[System_T]." + fieldName + " = N" + "'" + value.ToString + "'"))

                Dim dataReader As IDataReader = Me.Command.ExecuteReader
                Dim Result As New List(Of Hepsa.Core.BLL.BLLSystem_T)
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
            Me.Command.CommandText = "[sp_System_T_SelectCondition]"
            Me.Command.CommandType = CommandType.StoredProcedure
            Try
                Me.Command.Parameters.Clear()

                Me.Command.Parameters.Add(New SqlParameter("@Condition", "[System_T]." + fieldName + " = N" + "'" + value.ToString + "'"))

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
            Me.Command.CommandText = "[sp_System_T_SelectCondition]"
            Me.Command.CommandType = CommandType.StoredProcedure
            Try
                Me.Command.Parameters.Clear()

                Me.Command.Parameters.Add(New SqlParameter("@Condition", "[System_T]." + fieldName + " = N" + "'" + value.ToString + "'"))

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
            Me.Command.CommandText = "[sp_System_T_SelectCondition]"
            Me.Command.CommandType = CommandType.StoredProcedure
            Try
                Me.Command.Parameters.Clear()

                Me.Command.Parameters.Add(New SqlParameter("@Condition", "[System_T]." + fieldName + " = N" + "'" + value.ToString + "'"))

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

        Public Function SelectByCondition(ByVal Condition As String) As List(Of Hepsa.Core.BLL.BLLSystem_T)
            Dim ControlConnection As Boolean = Not Me.ConnectionState = Data.ConnectionState.Open
            Me.Command.CommandText = "[sp_System_T_SelectCondition]"
            Me.Command.CommandType = CommandType.StoredProcedure
            Try
                Me.Command.Parameters.Clear()

                Me.Command.Parameters.Add(New SqlParameter("@Condition", Condition))

                If ControlConnection Then
                    Me.BeginTransaction()
                End If

                Dim dataReader As IDataReader = Me.Command.ExecuteReader
                Dim Result As New List(Of Hepsa.Core.BLL.BLLSystem_T)
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
            Me.Command.CommandText = "[sp_System_T_SelectCondition]"
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
            Me.Command.CommandText = "[sp_System_T_SelectCondition]"
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
            Me.Command.CommandText = "[sp_System_T_SelectCondition]"
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

        Public Sub Delete(ByVal businessObjectKey As Hepsa.Core.BLL.BLLSystem_TKeys)
            Dim ControlConnection As Boolean = Not Me.ConnectionState = Data.ConnectionState.Open
            Me.Command.CommandText = "[sp_System_T_DeleteByPrimaryKey]"
            Me.Command.CommandType = CommandType.StoredProcedure

            Try
                Me.Command.Parameters.Clear()

                Dim SystemID_tint As New SqlParameter
                SystemID_tint.ParameterName = "@SystemID_tint"
                SystemID_tint.SqlDbType = SqlDbType.TinyInt
                SystemID_tint.Direction = ParameterDirection.Input
                SystemID_tint.IsNullable = False
                SystemID_tint.Value = businessObjectKey.SystemID_tint
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

        Public Sub DeleteByField(ByVal fieldName As String, ByVal value As Object)
            Dim ControlConnection As Boolean = Not Me.ConnectionState = Data.ConnectionState.Open
            Me.Command.CommandText = "[sp_System_T_DeleteByField]"
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

        Friend Sub PopulateBusinessObjectFromReader(ByVal businessObject As Hepsa.Core.BLL.BLLSystem_T, ByVal dataReader As IDataReader)
            businessObject.SystemID_int = dataReader.GetInt32(dataReader.GetOrdinal(Hepsa.Core.BLL.BLLSystem_T.System_TField.SystemID_int.ToString))
            businessObject.System_nvc = dataReader.GetString(dataReader.GetOrdinal(Hepsa.Core.BLL.BLLSystem_T.System_TField.System_nvc.ToString))
            businessObject.Image = DirectCast(dataReader.GetValue(dataReader.GetOrdinal(Hepsa.Core.BLL.BLLSystem_T.System_TField.Image.ToString)), Byte())
        End Sub

        Friend Function PopulateObjectsFromReader(ByVal dataReader As IDataReader) As List(Of Hepsa.Core.BLL.BLLSystem_T)
            Dim list As New List(Of Hepsa.Core.BLL.BLLSystem_T)
            While dataReader.Read
                Dim businessObject As New Hepsa.Core.BLL.BLLSystem_T
                PopulateBusinessObjectFromReader(businessObject, dataReader)
                list.Add(businessObject)
            End While
            Return list
        End Function

    End Class
End Namespace