Imports System
Imports System.Data
Imports System.Data.SqlTypes
Imports System.Data.SqlClient
Imports System.Collections.Generic

Namespace DAL
    Class DALUser_T

        Inherits DAL.DataLayerBase

        Public Sub New()
            MyBase.New(Common.ConnectionString.ConnectionString)
        End Sub

        Public Sub Insert(ByVal businessObject As BLL.BLLUser_T)
            Dim ControlConnection As Boolean = Not Me.ConnectionState = Data.ConnectionState.Open
            Me.Command.CommandText = "[sp_User_T_Add]"
            Me.Command.CommandType = CommandType.StoredProcedure

            Try
                Me.Command.Parameters.Clear()

                Dim UserName_nvc As New SqlParameter
                UserName_nvc.ParameterName = "@UserName_nvc"
                UserName_nvc.SqlDbType = SqlDbType.NVarChar
                UserName_nvc.Direction = ParameterDirection.Input
                UserName_nvc.IsNullable = False
                UserName_nvc.Value = businessObject.UserName_nvc
                Me.Command.Parameters.Add(UserName_nvc)

                Dim FullName_nvc As New SqlParameter
                FullName_nvc.ParameterName = "@FullName_nvc"
                FullName_nvc.SqlDbType = SqlDbType.NVarChar
                FullName_nvc.Direction = ParameterDirection.Input
                FullName_nvc.IsNullable = False
                FullName_nvc.Value = businessObject.FullName_nvc
                Me.Command.Parameters.Add(FullName_nvc)

                Dim Password_nvc As New SqlParameter
                Password_nvc.ParameterName = "@Password_nvc"
                Password_nvc.SqlDbType = SqlDbType.NVarChar
                Password_nvc.Direction = ParameterDirection.Input
                Password_nvc.IsNullable = False
                Password_nvc.Value = businessObject.Password_nvc
                Me.Command.Parameters.Add(Password_nvc)

                Dim StartDate_vc As New SqlParameter
                StartDate_vc.ParameterName = "@StartDate_vc"
                StartDate_vc.SqlDbType = SqlDbType.VarChar
                StartDate_vc.Direction = ParameterDirection.Input
                StartDate_vc.IsNullable = True
                If String.IsNullOrEmpty(businessObject.StartDate_vc) Then
                    StartDate_vc.Value = DBNull.Value
                Else
                    StartDate_vc.Value = businessObject.StartDate_vc
                End If
                Me.Command.Parameters.Add(StartDate_vc)

                Dim ExpireDate_vc As New SqlParameter
                ExpireDate_vc.ParameterName = "@ExpireDate_vc"
                ExpireDate_vc.SqlDbType = SqlDbType.VarChar
                ExpireDate_vc.Direction = ParameterDirection.Input
                ExpireDate_vc.IsNullable = True
                If String.IsNullOrEmpty(businessObject.ExpireDate_vc) Then
                    ExpireDate_vc.Value = DBNull.Value
                Else
                    ExpireDate_vc.Value = businessObject.ExpireDate_vc
                End If
                Me.Command.Parameters.Add(ExpireDate_vc)

                Dim Permissions_vc As New SqlParameter
                Permissions_vc.ParameterName = "@Permissions_vc"
                Permissions_vc.SqlDbType = SqlDbType.NText
                Permissions_vc.Direction = ParameterDirection.Input
                Permissions_vc.IsNullable = True
                If String.IsNullOrEmpty(businessObject.Permissions_vc) Then
                    Permissions_vc.Value = DBNull.Value
                Else
                    Permissions_vc.Value = businessObject.Permissions_vc
                End If
                Me.Command.Parameters.Add(Permissions_vc)

                Dim Picture_img As New SqlParameter
                Picture_img.ParameterName = "@Picture_img"
                Picture_img.SqlDbType = SqlDbType.Image
                Picture_img.Direction = ParameterDirection.Input
                Picture_img.IsNullable = True
                If businessObject.Picture_img Is Nothing OrElse businessObject.Picture_img.Length = 0 Then
                    Picture_img.Value = DBNull.Value
                Else
                    Picture_img.Value = businessObject.Picture_img
                End If
                Me.Command.Parameters.Add(Picture_img)

                Dim isActive_bit As New SqlParameter
                isActive_bit.ParameterName = "@isActive_bit"
                isActive_bit.SqlDbType = SqlDbType.Bit
                isActive_bit.Direction = ParameterDirection.Input
                isActive_bit.IsNullable = False
                isActive_bit.Value = businessObject.Activity_bit
                Me.Command.Parameters.Add(isActive_bit)

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

        Public Sub Update(ByVal businessObject As BLL.BLLUser_T, ByVal businessObjectKey As BLL.BLLUser_TKeys)
            Dim ControlConnection As Boolean = Not Me.ConnectionState = Data.ConnectionState.Open
            Me.Command.CommandText = "[sp_User_T_Update]"
            Me.Command.CommandType = CommandType.StoredProcedure

            Try
                Me.Command.Parameters.Clear()

                Dim UserName_nvc As New SqlParameter
                UserName_nvc.ParameterName = "@UserName_nvc"
                UserName_nvc.SqlDbType = SqlDbType.NVarChar
                UserName_nvc.Direction = ParameterDirection.Input
                UserName_nvc.IsNullable = False
                UserName_nvc.Value = businessObject.UserName_nvc
                Me.Command.Parameters.Add(UserName_nvc)

                Dim FullName_nvc As New SqlParameter
                FullName_nvc.ParameterName = "@FullName_nvc"
                FullName_nvc.SqlDbType = SqlDbType.NVarChar
                FullName_nvc.Direction = ParameterDirection.Input
                FullName_nvc.IsNullable = False
                FullName_nvc.Value = businessObject.FullName_nvc
                Me.Command.Parameters.Add(FullName_nvc)

                Dim Password_nvc As New SqlParameter
                Password_nvc.ParameterName = "@Password_nvc"
                Password_nvc.SqlDbType = SqlDbType.NVarChar
                Password_nvc.Direction = ParameterDirection.Input
                Password_nvc.IsNullable = False
                Password_nvc.Value = businessObject.Password_nvc
                Me.Command.Parameters.Add(Password_nvc)

                Dim StartDate_vc As New SqlParameter
                StartDate_vc.ParameterName = "@StartDate_vc"
                StartDate_vc.SqlDbType = SqlDbType.VarChar
                StartDate_vc.Direction = ParameterDirection.Input
                StartDate_vc.IsNullable = True
                If String.IsNullOrEmpty(businessObject.StartDate_vc) Then
                    StartDate_vc.Value = DBNull.Value
                Else
                    StartDate_vc.Value = businessObject.StartDate_vc
                End If
                Me.Command.Parameters.Add(StartDate_vc)

                Dim ExpireDate_vc As New SqlParameter
                ExpireDate_vc.ParameterName = "@ExpireDate_vc"
                ExpireDate_vc.SqlDbType = SqlDbType.VarChar
                ExpireDate_vc.Direction = ParameterDirection.Input
                ExpireDate_vc.IsNullable = True
                If String.IsNullOrEmpty(businessObject.ExpireDate_vc) Then
                    ExpireDate_vc.Value = DBNull.Value
                Else
                    ExpireDate_vc.Value = businessObject.ExpireDate_vc
                End If
                Me.Command.Parameters.Add(ExpireDate_vc)

                Dim Permissions_vc As New SqlParameter
                Permissions_vc.ParameterName = "@Permissions_vc"
                Permissions_vc.SqlDbType = SqlDbType.NText
                Permissions_vc.Direction = ParameterDirection.Input
                Permissions_vc.IsNullable = True
                If String.IsNullOrEmpty(businessObject.Permissions_vc) Then
                    Permissions_vc.Value = DBNull.Value
                Else
                    Permissions_vc.Value = businessObject.Permissions_vc
                End If
                Me.Command.Parameters.Add(Permissions_vc)

                Dim Picture_img As New SqlParameter
                Picture_img.ParameterName = "@Picture_img"
                Picture_img.SqlDbType = SqlDbType.Image
                Picture_img.Direction = ParameterDirection.Input
                Picture_img.IsNullable = True
                If businessObject.Picture_img Is Nothing OrElse businessObject.Picture_img.Length = 0 Then
                    Picture_img.Value = DBNull.Value
                Else
                    Picture_img.Value = businessObject.Picture_img
                End If
                Me.Command.Parameters.Add(Picture_img)

                Dim isActive_bit As New SqlParameter
                isActive_bit.ParameterName = "@isActive_bit"
                isActive_bit.SqlDbType = SqlDbType.Bit
                isActive_bit.Direction = ParameterDirection.Input
                isActive_bit.IsNullable = False
                isActive_bit.Value = businessObject.Activity_bit
                Me.Command.Parameters.Add(isActive_bit)

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


                Dim pk_UserName_nvc As New SqlParameter
                pk_UserName_nvc.ParameterName = "@pk_UserName_nvc"
                pk_UserName_nvc.SqlDbType = SqlDbType.NVarChar
                pk_UserName_nvc.Direction = ParameterDirection.Input
                pk_UserName_nvc.IsNullable = False
                pk_UserName_nvc.Value = businessObjectKey.UserName_nvc
                Me.Command.Parameters.Add(pk_UserName_nvc)

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

        Public Function SelectAll() As List(Of BLL.BLLUser_T)
            Dim ControlConnection As Boolean = Not Me.ConnectionState = Data.ConnectionState.Open
            Me.Command.CommandText = "[sp_User_T_SelectAll]"
            Me.Command.CommandType = CommandType.StoredProcedure

            Try
                Me.Command.Parameters.Clear()

                If ControlConnection Then
                    Me.BeginTransaction()
                End If

                Dim dataReader As IDataReader = Me.Command.ExecuteReader
                Dim Result As New List(Of BLL.BLLUser_T)
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
            Me.Command.CommandText = "[sp_User_T_SelectAll]"
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
            Me.Command.CommandText = "[sp_User_T_SelectAll]"
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
            Me.Command.CommandText = "[sp_User_T_SelectAll]"
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

        Public Function SelectByPrimaryKey(ByVal businessObjectKey As BLL.BLLUser_TKeys) As BLL.BLLUser_T
            Dim ControlConnection As Boolean = Not Me.ConnectionState = Data.ConnectionState.Open
            Me.Command.CommandText = "[sp_User_T_SelectByPrimaryKey]"
            Me.Command.CommandType = CommandType.StoredProcedure

            Try
                Me.Command.Parameters.Clear()

                Dim UserName_nvc As New SqlParameter
                UserName_nvc.ParameterName = "@UserName_nvc"
                UserName_nvc.SqlDbType = SqlDbType.NVarChar
                UserName_nvc.Direction = ParameterDirection.Input
                UserName_nvc.IsNullable = False
                UserName_nvc.Value = businessObjectKey.UserName_nvc
                Me.Command.Parameters.Add(UserName_nvc)

                If ControlConnection Then
                    Me.BeginTransaction()
                End If

                Dim dataReader As IDataReader = Me.Command.ExecuteReader
                Dim businessObject As New BLL.BLLUser_T
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

        Public Sub SelectByPrimaryKey(ByVal businessObjectKey As BLL.BLLUser_TKeys, ByRef dataset As System.Data.DataSet, ByVal srcTable As String)
            Dim ControlConnection As Boolean = Not Me.ConnectionState = Data.ConnectionState.Open
            Dim sqlDataAdapter As New SqlDataAdapter(Me.Command)
            Me.Command.CommandText = "[sp_User_T_SelectByPrimaryKey]"
            Me.Command.CommandType = CommandType.StoredProcedure

            Try
                Me.Command.Parameters.Clear()

                Dim UserName_nvc As New SqlParameter
                UserName_nvc.ParameterName = "@UserName_nvc"
                UserName_nvc.SqlDbType = SqlDbType.NVarChar
                UserName_nvc.Direction = ParameterDirection.Input
                UserName_nvc.IsNullable = False
                UserName_nvc.Value = businessObjectKey.UserName_nvc
                Me.Command.Parameters.Add(UserName_nvc)


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

        Public Sub SelectByPrimaryKey(ByVal businessObjectKey As BLL.BLLUser_TKeys, ByRef dataset As System.Data.DataSet)
            Dim ControlConnection As Boolean = Not Me.ConnectionState = Data.ConnectionState.Open
            Dim sqlDataAdapter As New SqlDataAdapter(Me.Command)
            Me.Command.CommandText = "[sp_User_T_SelectByPrimaryKey]"
            Me.Command.CommandType = CommandType.StoredProcedure

            Try
                Me.Command.Parameters.Clear()

                Dim UserName_nvc As New SqlParameter
                UserName_nvc.ParameterName = "@UserName_nvc"
                UserName_nvc.SqlDbType = SqlDbType.NVarChar
                UserName_nvc.Direction = ParameterDirection.Input
                UserName_nvc.IsNullable = False
                UserName_nvc.Value = businessObjectKey.UserName_nvc
                Me.Command.Parameters.Add(UserName_nvc)


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

        Public Sub SelectByPrimaryKey(ByVal businessObjectKey As BLL.BLLUser_TKeys, ByRef dataTable As System.Data.DataTable)
            Dim ControlConnection As Boolean = Not Me.ConnectionState = Data.ConnectionState.Open
            Dim sqlDataAdapter As New SqlDataAdapter(Me.Command)
            Me.Command.CommandText = "[sp_User_T_SelectByPrimaryKey]"
            Me.Command.CommandType = CommandType.StoredProcedure

            Try
                Me.Command.Parameters.Clear()

                Dim UserName_nvc As New SqlParameter
                UserName_nvc.ParameterName = "@UserName_nvc"
                UserName_nvc.SqlDbType = SqlDbType.NVarChar
                UserName_nvc.Direction = ParameterDirection.Input
                UserName_nvc.IsNullable = False
                UserName_nvc.Value = businessObjectKey.UserName_nvc
                Me.Command.Parameters.Add(UserName_nvc)

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

        Public Function SelectByField(ByVal fieldName As String, ByVal value As Object) As List(Of BLL.BLLUser_T)
            Dim ControlConnection As Boolean = Not Me.ConnectionState = Data.ConnectionState.Open
            Me.Command.CommandText = "[sp_User_T_SelectCondition]"
            Me.Command.CommandType = CommandType.StoredProcedure
            Try

                Me.Command.Parameters.Clear()

                If ControlConnection Then
                    Me.BeginTransaction()
                End If

                Me.Command.Parameters.Add(New SqlParameter("@Condition", "[User_T]." + fieldName + " = N" + "'" + value.ToString + "'"))

                Dim dataReader As IDataReader = Me.Command.ExecuteReader
                Dim Result As New List(Of BLL.BLLUser_T)
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
            Me.Command.CommandText = "[sp_User_T_SelectCondition]"
            Me.Command.CommandType = CommandType.StoredProcedure
            Try
                Me.Command.Parameters.Clear()

                Me.Command.Parameters.Add(New SqlParameter("@Condition", "[User_T]." + fieldName + " = N" + "'" + value.ToString + "'"))

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
            Me.Command.CommandText = "[sp_User_T_SelectCondition]"
            Me.Command.CommandType = CommandType.StoredProcedure
            Try
                Me.Command.Parameters.Clear()

                Me.Command.Parameters.Add(New SqlParameter("@Condition", "[User_T]." + fieldName + " = N" + "'" + value.ToString + "'"))

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
            Me.Command.CommandText = "[sp_User_T_SelectCondition]"
            Me.Command.CommandType = CommandType.StoredProcedure
            Try
                Me.Command.Parameters.Clear()

                Me.Command.Parameters.Add(New SqlParameter("@Condition", "[User_T]." + fieldName + " = N" + "'" + value.ToString + "'"))

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

        Public Function SelectByCondition(ByVal Condition As String) As List(Of BLL.BLLUser_T)
            Dim ControlConnection As Boolean = Not Me.ConnectionState = Data.ConnectionState.Open
            Me.Command.CommandText = "[sp_User_T_SelectCondition]"
            Me.Command.CommandType = CommandType.StoredProcedure
            Try
                Me.Command.Parameters.Clear()

                Me.Command.Parameters.Add(New SqlParameter("@Condition", Condition))

                If ControlConnection Then
                    Me.BeginTransaction()
                End If

                Dim dataReader As IDataReader = Me.Command.ExecuteReader
                Dim Result As New List(Of BLL.BLLUser_T)
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
            Me.Command.CommandText = "[sp_User_T_SelectCondition]"
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
            Me.Command.CommandText = "[sp_User_T_SelectCondition]"
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
            Me.Command.CommandText = "[sp_User_T_SelectCondition]"
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

        Public Sub Delete(ByVal businessObjectKey As BLL.BLLUser_TKeys)
            Dim ControlConnection As Boolean = Not Me.ConnectionState = Data.ConnectionState.Open
            Me.Command.CommandText = "[sp_User_T_DeleteByPrimaryKey]"
            Me.Command.CommandType = CommandType.StoredProcedure

            Try
                Me.Command.Parameters.Clear()

                Dim UserName_nvc As New SqlParameter
                UserName_nvc.ParameterName = "@UserName_nvc"
                UserName_nvc.SqlDbType = SqlDbType.NVarChar
                UserName_nvc.Direction = ParameterDirection.Input
                UserName_nvc.IsNullable = False
                UserName_nvc.Value = businessObjectKey.UserName_nvc
                Me.Command.Parameters.Add(UserName_nvc)


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
            Me.Command.CommandText = "[sp_User_T_DeleteByField]"
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

        Friend Sub PopulateBusinessObjectFromReader(ByVal businessObject As BLL.BLLUser_T, ByVal dataReader As IDataReader)
            businessObject.UserName_nvc = dataReader.GetString(dataReader.GetOrdinal(BLL.BLLUser_T.User_TField.UserName_nvc.ToString))
            businessObject.FullName_nvc = dataReader.GetString(dataReader.GetOrdinal(BLL.BLLUser_T.User_TField.FullName_nvc.ToString))
            businessObject.Password_nvc = dataReader.GetString(dataReader.GetOrdinal(BLL.BLLUser_T.User_TField.Password_nvc.ToString))
            If dataReader.IsDBNull(dataReader.GetOrdinal(BLL.BLLUser_T.User_TField.StartDate_vc.ToString)) = False Then
                businessObject.StartDate_vc = dataReader.GetString(dataReader.GetOrdinal(BLL.BLLUser_T.User_TField.StartDate_vc.ToString))
            Else
                businessObject.StartDate_vc = String.Empty
            End If

            If dataReader.IsDBNull(dataReader.GetOrdinal(BLL.BLLUser_T.User_TField.ExpireDate_vc.ToString)) = False Then
                businessObject.ExpireDate_vc = dataReader.GetString(dataReader.GetOrdinal(BLL.BLLUser_T.User_TField.ExpireDate_vc.ToString))
            Else
                businessObject.ExpireDate_vc = String.Empty
            End If

            If dataReader.IsDBNull(dataReader.GetOrdinal(BLL.BLLUser_T.User_TField.Permissions_vc.ToString)) = False Then
                businessObject.Permissions_vc = dataReader.GetString(dataReader.GetOrdinal(BLL.BLLUser_T.User_TField.Permissions_vc.ToString))
            Else
                businessObject.Permissions_vc = String.Empty
            End If

            If dataReader.IsDBNull(dataReader.GetOrdinal(BLL.BLLUser_T.User_TField.Picture_img.ToString)) = False Then
                businessObject.Picture_img = DirectCast(dataReader.GetValue(dataReader.GetOrdinal(BLL.BLLUser_T.User_TField.Picture_img.ToString)), Byte())
            Else
                businessObject.Picture_img = Nothing
            End If

            businessObject.Activity_bit = dataReader.GetBoolean(dataReader.GetOrdinal(BLL.BLLUser_T.User_TField.Activity_bit.ToString))
            'businessObject.isActive_bit = dataReader.GetBoolean(dataReader.GetOrdinal("Activity_bit"))
            If dataReader.IsDBNull(dataReader.GetOrdinal(BLL.BLLUser_T.User_TField.ExtraFieldTemplateID_bint.ToString)) = False Then
                businessObject.ExtraFieldTemplateID_bint = dataReader.GetInt64(dataReader.GetOrdinal(BLL.BLLUser_T.User_TField.ExtraFieldTemplateID_bint.ToString))
            Else
                businessObject.ExtraFieldTemplateID_bint = Nothing
            End If
        End Sub

        Friend Function PopulateObjectsFromReader(ByVal dataReader As IDataReader) As List(Of BLL.BLLUser_T)
            Dim list As New List(Of BLL.BLLUser_T)
            While dataReader.Read
                Dim businessObject As New BLL.BLLUser_T
                PopulateBusinessObjectFromReader(businessObject, dataReader)
                list.Add(businessObject)
            End While
            Return list
        End Function

    End Class
End Namespace