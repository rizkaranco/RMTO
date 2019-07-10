Imports System
Imports System.Collections.Generic
Imports System.Text
Imports System.Data

Namespace BLL

    Public Class BLLUser_TFactory
        Inherits BLL.BusinessFactoryBase

        Private _dataObject As DAL.DALUser_T = Nothing

        Public Sub New()
            MyBase.New("User_T")
            _dataObject = MyBase.DataAccessLayer
        End Sub

        Public Sub Insert(ByVal businessObject As BLL.BLLUser_T)
            Try
                If businessObject.IsValid = False Then
                    Throw New Validation.InvalidBusinessObjectException(businessObject.BrokenRulesList.ToString())
                End If

                _dataObject.Insert(businessObject)
            Catch ex As System.Exception
                Throw Exception.HandleException.ChangeExceptionLanguage(ex, Me)
            End Try
        End Sub

        Public Sub Update(ByVal businessObject As BLL.BLLUser_T, ByVal businessObjectKey As BLL.BLLUser_TKeys)
            Try
                If businessObject.UserName_nvc.ToLower = businessObjectKey.UserName_nvc.ToLower Then
                    If businessObject.IsValid(Validation.ValidationExceptionType.Except, "UniqueUserName_nvc") = False Then
                        Throw New Validation.InvalidBusinessObjectException(businessObject.BrokenRulesList.ToString())
                    End If
                Else
                    If (businessObject.IsValid = False) Then
                        Throw New Validation.InvalidBusinessObjectException(businessObject.BrokenRulesList.ToString())
                    End If
                End If

                _dataObject.Update(businessObject, businessObjectKey)
            Catch ex As System.Exception
                Throw Exception.HandleException.ChangeExceptionLanguage(ex, Me)
            End Try
        End Sub

        Public Function GetBy(ByVal keys As BLL.BLLUser_TKeys) As BLL.BLLUser_T
            Try
                Return _dataObject.SelectByPrimaryKey(keys)
            Catch ex As System.Exception
                Throw Exception.HandleException.ChangeExceptionLanguage(ex, Me)
            End Try
        End Function

        Public Sub GetBy(ByVal keys As BLL.BLLUser_TKeys, ByRef dataSet As System.Data.DataSet, ByVal srcTable As String)
            Try
                _dataObject.SelectByPrimaryKey(keys, dataSet, srcTable)
            Catch ex As System.Exception
                Throw Exception.HandleException.ChangeExceptionLanguage(ex, Me)
            End Try
        End Sub

        Public Sub GetBy(ByVal keys As BLL.BLLUser_TKeys, ByRef dataSet As System.Data.DataSet)
            Try
                _dataObject.SelectByPrimaryKey(keys, dataSet)
            Catch ex As System.Exception
                Throw Exception.HandleException.ChangeExceptionLanguage(ex, Me)
            End Try
        End Sub

        Public Sub GetBy(ByVal keys As BLL.BLLUser_TKeys, ByRef dataTable As System.Data.DataTable)
            Try
                _dataObject.SelectByPrimaryKey(keys, dataTable)
            Catch ex As System.Exception
                Throw Exception.HandleException.ChangeExceptionLanguage(ex, Me)
            End Try
        End Sub

        Public Function GetAll() As List(Of BLL.BLLUser_T)
            Try
                Return _dataObject.SelectAll
            Catch ex As System.Exception
                Throw Exception.HandleException.ChangeExceptionLanguage(ex, Me)
            End Try
        End Function

        Public Sub GetAll(ByRef dataSet As System.Data.DataSet, ByVal srcTable As String)
            Try
                _dataObject.SelectAll(dataSet, srcTable)
            Catch ex As System.Exception
                Throw Exception.HandleException.ChangeExceptionLanguage(ex, Me)
            End Try
        End Sub

        Public Sub GetAll(ByRef dataSet As System.Data.DataSet)
            Try
                _dataObject.SelectAll(dataSet)
            Catch ex As System.Exception
                Throw Exception.HandleException.ChangeExceptionLanguage(ex, Me)
            End Try
        End Sub

        Public Sub GetAll(ByRef dataTable As System.Data.DataTable)
            Try
                _dataObject.SelectAll(dataTable)
            Catch ex As System.Exception
                Throw Exception.HandleException.ChangeExceptionLanguage(ex, Me)
            End Try
        End Sub

        Public Function GetAllBy(ByVal fieldName As BLL.BLLUser_T.User_TField, ByVal value As Object) As List(Of BLL.BLLUser_T)
            Try
                Return _dataObject.SelectByField(fieldName.ToString(), value)
            Catch ex As System.Exception
                Throw Exception.HandleException.ChangeExceptionLanguage(ex, Me)
            End Try
        End Function

        Public Sub GetAllBy(ByVal fieldName As BLL.BLLUser_T.User_TField, ByVal value As Object, ByRef dataSet As System.Data.DataSet, ByVal srcTable As String)
            Try
                _dataObject.SelectByField(fieldName.ToString(), value, dataSet, srcTable)
            Catch ex As System.Exception
                Throw Exception.HandleException.ChangeExceptionLanguage(ex, Me)
            End Try
        End Sub

        Public Sub GetAllBy(ByVal fieldName As BLL.BLLUser_T.User_TField, ByVal value As Object, ByRef dataSet As System.Data.DataSet)
            Try
                _dataObject.SelectByField(fieldName.ToString(), value, dataSet)
            Catch ex As System.Exception
                Throw Exception.HandleException.ChangeExceptionLanguage(ex, Me)
            End Try
        End Sub

        Public Sub GetAllBy(ByVal fieldName As BLL.BLLUser_T.User_TField, ByVal value As Object, ByRef dataTable As System.Data.DataTable)
            Try
                _dataObject.SelectByField(fieldName.ToString(), value, dataTable)
            Catch ex As System.Exception
                Throw Exception.HandleException.ChangeExceptionLanguage(ex, Me)
            End Try
        End Sub

        Public Function GetAllByCondition(ByVal Condition As String) As List(Of BLL.BLLUser_T)
            Try
                Return _dataObject.SelectByCondition(Condition.ToString())
            Catch ex As System.Exception
                Throw Exception.HandleException.ChangeExceptionLanguage(ex, Me)
            End Try
        End Function

        Public Sub GetAllByCondition(ByVal Condition As String, ByRef dataSet As System.Data.DataSet, ByVal srcTable As String)
            Try
                _dataObject.SelectByCondition(Condition.ToString(), dataSet, srcTable)
            Catch ex As System.Exception
                Throw Exception.HandleException.ChangeExceptionLanguage(ex, Me)
            End Try
        End Sub

        Public Sub GetAllByCondition(ByVal Condition As String, ByRef dataSet As System.Data.DataSet)
            Try
                _dataObject.SelectByCondition(Condition.ToString(), dataSet)
            Catch ex As System.Exception
                Throw Exception.HandleException.ChangeExceptionLanguage(ex, Me)
            End Try
        End Sub

        Public Sub GetAllByCondition(ByVal Condition As String, ByRef dataTable As System.Data.DataTable)
            Try
                _dataObject.SelectByCondition(Condition.ToString(), dataTable)
            Catch ex As System.Exception
                Throw Exception.HandleException.ChangeExceptionLanguage(ex, Me)
            End Try
        End Sub

        Public Sub Delete(ByVal keys As BLL.BLLUser_TKeys)
            Try
                _dataObject.Delete(keys)
            Catch ex As System.Exception
                Throw Exception.HandleException.ChangeExceptionLanguage(ex, Me)
            End Try
        End Sub

        Public Sub Delete(ByVal fieldName As BLL.BLLUser_T.User_TField, ByVal value As Object)
            Try
                _dataObject.DeleteByField(fieldName.ToString(), value)
            Catch ex As System.Exception
                Throw Exception.HandleException.ChangeExceptionLanguage(ex, Me)
            End Try
        End Sub

        Public Function Login(ByVal User As BLL.BLLUserLogin_T) As BLL.BLLUser_T
            Try
                If User.IsValid = False Then
                    Throw New Validation.InvalidBusinessObjectException(User.BrokenRulesList.ToString())
                End If

                Dim UserEntity As New BLL.BLLUser_T
                Dim UserKey As New BLL.BLLUser_TKeys
                UserKey.UserName_nvc = User.UserName_nvc
                UserEntity = Me.GetBy(UserKey)
                If UserEntity IsNot Nothing AndAlso UserEntity.Password_nvc = User.Password_nvc Then
                    If UserEntity.Activity_bit = True Then
                        Dim ServerDate As String = Me.ServerJalaliDate
                        If String.IsNullOrEmpty(UserEntity.StartDate_vc) = False AndAlso UserEntity.StartDate_vc > ServerDate Then
                            Throw New Exception.UserStartDateError(UserEntity.StartDate_vc)
                        ElseIf String.IsNullOrEmpty(UserEntity.ExpireDate_vc) = False AndAlso UserEntity.ExpireDate_vc < ServerDate Then
                            Throw New Exception.UserExpireDateError(UserEntity.ExpireDate_vc)
                        Else
                            Return UserEntity
                        End If
                    Else
                        Throw New Exception.UserIsNotActive
                    End If
                Else
                    Throw New Exception.InvalidUserNameOrPassword
                End If
            Catch ex As System.Exception
                Throw Exception.HandleException.ChangeExceptionLanguage(ex, Me)
            End Try
        End Function

    End Class

End Namespace