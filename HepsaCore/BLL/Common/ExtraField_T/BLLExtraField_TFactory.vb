Imports System
Imports System.Collections.Generic
Imports System.Text
Imports System.Data

Namespace BLL

    Public Class BLLExtraField_TFactory
        Inherits BLL.BusinessFactoryBase

        Private _dataObject As DAL.DALExtraField_T = Nothing

        Public Sub New()
            MyBase.New("ExtraField_T")
            _dataObject = MyBase.DataAccessLayer
        End Sub

        Public Sub Insert(ByVal businessObject As BLL.BLLExtraField_T)
            Try
                If businessObject.ExtraFieldDataTypeID_tint.HasValue AndAlso businessObject.ExtraFieldDataTypeID_tint.Value = 100 Then
                    If businessObject.IsValid() = False Then
                        Throw New Validation.InvalidBusinessObjectException(businessObject.BrokenRulesList.ToString())
                    End If
                Else
                    If businessObject.IsValid(Validation.ValidationExceptionType.Except, "DataSourceID_bint") = False Then
                        Throw New Validation.InvalidBusinessObjectException(businessObject.BrokenRulesList.ToString())
                    End If
                End If

                _dataObject.Insert(businessObject)
            Catch ex As System.Exception
                Throw Exception.HandleException.ChangeExceptionLanguage(ex, Me)
            End Try
        End Sub

        Public Sub Update(ByVal businessObject As BLL.BLLExtraField_T, ByVal businessObjectKey As BLL.BLLExtraField_TKeys)
            Try
                Dim businessObjectEntity As BLL.BLLExtraField_T = Me._dataObject.SelectByPrimaryKey(businessObjectKey)
                If businessObjectEntity IsNot Nothing AndAlso businessObjectEntity.ExtraField_nvc.ToLower = businessObject.ExtraField_nvc.ToLower Then
                    If businessObject.ExtraFieldDataTypeID_tint.HasValue AndAlso businessObject.ExtraFieldDataTypeID_tint.Value <> 100 Then
                        If businessObject.IsValid(Validation.ValidationExceptionType.Except, "DataSourceID_bint", "UniqueExtraField_nvc") = False Then
                            Throw New Validation.InvalidBusinessObjectException(businessObject.BrokenRulesList.ToString())
                        End If
                    Else
                        If businessObject.IsValid(Validation.ValidationExceptionType.Except, "UniqueExtraField_nvc") = False Then
                            Throw New Validation.InvalidBusinessObjectException(businessObject.BrokenRulesList.ToString())
                        End If
                    End If
                Else
                    If businessObject.ExtraFieldDataTypeID_tint.HasValue AndAlso businessObject.ExtraFieldDataTypeID_tint.Value <> 100 Then
                        If businessObject.IsValid(Validation.ValidationExceptionType.Except, "DataSourceID_bint") = False Then
                            Throw New Validation.InvalidBusinessObjectException(businessObject.BrokenRulesList.ToString())
                        End If
                    Else
                        If businessObject.IsValid() = False Then
                            Throw New Validation.InvalidBusinessObjectException(businessObject.BrokenRulesList.ToString())
                        End If
                    End If
                End If

                _dataObject.Update(businessObject, businessObjectKey)
            Catch ex As System.Exception
                Throw Exception.HandleException.ChangeExceptionLanguage(ex, Me)
            End Try
        End Sub

        Public Function GetBy(ByVal keys As BLL.BLLExtraField_TKeys) As BLL.BLLExtraField_T
            Try
                Return _dataObject.SelectByPrimaryKey(keys)
            Catch ex As System.Exception
                Throw Exception.HandleException.ChangeExceptionLanguage(ex, Me)
            End Try
        End Function

        Public Sub GetBy(ByVal keys As BLL.BLLExtraField_TKeys, ByRef dataSet As System.Data.DataSet, ByVal srcTable As String)
            Try
                _dataObject.SelectByPrimaryKey(keys, dataSet, srcTable)
            Catch ex As System.Exception
                Throw Exception.HandleException.ChangeExceptionLanguage(ex, Me)
            End Try
        End Sub

        Public Sub GetBy(ByVal keys As BLL.BLLExtraField_TKeys, ByRef dataSet As System.Data.DataSet)
            Try
                _dataObject.SelectByPrimaryKey(keys, dataSet)
            Catch ex As System.Exception
                Throw Exception.HandleException.ChangeExceptionLanguage(ex, Me)
            End Try
        End Sub

        Public Sub GetBy(ByVal keys As BLL.BLLExtraField_TKeys, ByRef dataTable As System.Data.DataTable)
            Try
                _dataObject.SelectByPrimaryKey(keys, dataTable)
            Catch ex As System.Exception
                Throw Exception.HandleException.ChangeExceptionLanguage(ex, Me)
            End Try
        End Sub

        Public Function GetAll() As List(Of BLL.BLLExtraField_T)
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

        Public Function GetAllBy(ByVal fieldName As BLL.BLLExtraField_T.ExtraField_TField, ByVal value As Object) As List(Of BLL.BLLExtraField_T)
            Try
                Return _dataObject.SelectByField(fieldName.ToString(), value)
            Catch ex As System.Exception
                Throw Exception.HandleException.ChangeExceptionLanguage(ex, Me)
            End Try
        End Function

        Public Sub GetAllBy(ByVal fieldName As BLL.BLLExtraField_T.ExtraField_TField, ByVal value As Object, ByRef dataSet As System.Data.DataSet, ByVal srcTable As String)
            Try
                _dataObject.SelectByField(fieldName.ToString(), value, dataSet, srcTable)
            Catch ex As System.Exception
                Throw Exception.HandleException.ChangeExceptionLanguage(ex, Me)
            End Try
        End Sub

        Public Sub GetAllBy(ByVal fieldName As BLL.BLLExtraField_T.ExtraField_TField, ByVal value As Object, ByRef dataSet As System.Data.DataSet)
            Try
                _dataObject.SelectByField(fieldName.ToString(), value, dataSet)
            Catch ex As System.Exception
                Throw Exception.HandleException.ChangeExceptionLanguage(ex, Me)
            End Try
        End Sub

        Public Sub GetAllBy(ByVal fieldName As BLL.BLLExtraField_T.ExtraField_TField, ByVal value As Object, ByRef dataTable As System.Data.DataTable)
            Try
                _dataObject.SelectByField(fieldName.ToString(), value, dataTable)
            Catch ex As System.Exception
                Throw Exception.HandleException.ChangeExceptionLanguage(ex, Me)
            End Try
        End Sub

        Public Function GetAllByCondition(ByVal Condition As String) As List(Of BLL.BLLExtraField_T)
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

        Public Sub Delete(ByVal keys As BLL.BLLExtraField_TKeys)
            Dim ControlTransaction As Boolean = Not Me._dataObject.ConnectionState = ConnectionState.Open
            Try
                If ControlTransaction Then
                    Me.BeginProc()
                End If
                _dataObject.Delete(keys)
                If ControlTransaction Then
                    Me.CommitProc()
                End If
            Catch ex As System.Exception
                If ControlTransaction Then
                    Me.RollBackProc()
                End If
                Throw Exception.HandleException.ChangeExceptionLanguage(ex, Me)
            End Try
        End Sub

        Public Sub Delete(ByVal fieldName As BLL.BLLExtraField_T.ExtraField_TField, ByVal value As Object)
            Dim ControlTransaction As Boolean = Not Me._dataObject.ConnectionState = ConnectionState.Open
            Try
                If ControlTransaction Then
                    Me.BeginProc()
                End If
                _dataObject.DeleteByField(fieldName.ToString(), value)
                If ControlTransaction Then
                    Me.CommitProc()
                End If
            Catch ex As System.Exception
                If ControlTransaction Then
                    Me.RollBackProc()
                End If
                Throw Exception.HandleException.ChangeExceptionLanguage(ex, Me)
            End Try
        End Sub

    End Class

End Namespace