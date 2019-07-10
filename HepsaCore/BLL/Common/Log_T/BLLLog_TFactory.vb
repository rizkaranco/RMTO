Imports System
Imports System.Collections.Generic
Imports System.Text
Imports System.Data
Imports Hepsa.Core.Validation

Namespace BLL

    Public Class BLLLog_TFactory
        Inherits BLL.BusinessFactoryBase

        Private _dataObject As DAL.DALLog_T = Nothing

        Public Sub New()
            MyBase.New("Log_T")
            _dataObject = MyBase.DataAccessLayer
        End Sub

        Public Sub Insert(ByVal businessObject As BLL.BLLLog_T)
            Try
                If businessObject.IsValid(ValidationExceptionType.Except, "UniqueLogID_bint") = False Then
                    Throw New InvalidBusinessObjectException(businessObject.BrokenRulesList.ToString())
                End If

                _dataObject.Insert(businessObject)
            Catch ex As System.Exception
                Throw ex
            End Try
        End Sub

        Public Sub Update(ByVal businessObject As BLL.BLLLog_T, ByVal businessObjectKey As BLL.BLLLog_TKeys)
            Try
                If businessObject.LogID_bint = businessObjectKey.LogID_bint Then
                    If businessObject.IsValid(ValidationExceptionType.Except, "UniqueLogID_bint") = False Then
                        Throw New InvalidBusinessObjectException(businessObject.BrokenRulesList.ToString())
                    End If
                Else
                    If (businessObject.IsValid = False) Then
                        Throw New InvalidBusinessObjectException(businessObject.BrokenRulesList.ToString())
                    End If
                End If

                _dataObject.Update(businessObject, businessObjectKey)
            Catch ex As System.Exception
                Throw ex
            End Try
        End Sub

        Public Function GetBy(ByVal keys As BLL.BLLLog_TKeys) As BLL.BLLLog_T
            Try
                Return _dataObject.SelectByPrimaryKey(keys)
            Catch ex As System.Exception
                Throw ex
            End Try
        End Function

        Public Sub GetBy(ByVal keys As BLL.BLLLog_TKeys, ByRef dataSet As System.Data.DataSet, ByVal srcTable As String)
            Try
                _dataObject.SelectByPrimaryKey(keys, dataSet, srcTable)
            Catch ex As System.Exception
                Throw ex
            End Try
        End Sub

        Public Sub GetBy(ByVal keys As BLL.BLLLog_TKeys, ByRef dataSet As System.Data.DataSet)
            Try
                _dataObject.SelectByPrimaryKey(keys, dataSet)
            Catch ex As System.Exception
                Throw ex
            End Try
        End Sub

        Public Sub GetBy(ByVal keys As BLL.BLLLog_TKeys, ByRef dataTable As System.Data.DataTable)
            Try
                _dataObject.SelectByPrimaryKey(keys, dataTable)
            Catch ex As System.Exception
                Throw ex
            End Try
        End Sub





        Public Function GetAll() As List(Of BLL.BLLLog_T)
            Try
                Return _dataObject.SelectAll
            Catch ex As System.Exception
                Throw ex
            End Try
        End Function

        Public Sub GetAll(ByRef dataSet As System.Data.DataSet, ByVal srcTable As String)
            Try
                _dataObject.SelectAll(dataSet, srcTable)
            Catch ex As System.Exception
                Throw ex
            End Try
        End Sub

        Public Sub GetAll(ByRef dataSet As System.Data.DataSet)
            Try
                _dataObject.SelectAll(dataSet)
            Catch ex As System.Exception
                Throw ex
            End Try
        End Sub

        Public Sub GetAll(ByRef dataTable As System.Data.DataTable)
            Try
                _dataObject.SelectAll(dataTable)
            Catch ex As System.Exception
                Throw ex
            End Try
        End Sub

        Public Function GetAllBy(ByVal fieldName As BLL.BLLLog_T.Log_TField, ByVal value As Object) As List(Of BLL.BLLLog_T)
            Try
                Return _dataObject.SelectByField(fieldName.ToString(), value)
            Catch ex As System.Exception
                Throw ex
            End Try
        End Function

        Public Sub GetAllBy(ByVal fieldName As BLL.BLLLog_T.Log_TField, ByVal value As Object, ByRef dataSet As System.Data.DataSet, ByVal srcTable As String)
            Try
                _dataObject.SelectByField(fieldName.ToString(), value, dataSet, srcTable)
            Catch ex As System.Exception
                Throw ex
            End Try
        End Sub

        Public Sub GetAllBy(ByVal fieldName As BLL.BLLLog_T.Log_TField, ByVal value As Object, ByRef dataSet As System.Data.DataSet)
            Try
                _dataObject.SelectByField(fieldName.ToString(), value, dataSet)
            Catch ex As System.Exception
                Throw ex
            End Try
        End Sub

        Public Sub GetAllBy(ByVal fieldName As BLL.BLLLog_T.Log_TField, ByVal value As Object, ByRef dataTable As System.Data.dataTable)
            Try
                _dataObject.SelectByField(fieldName.ToString(), value, dataTable)
            Catch ex As System.Exception
                Throw ex
            End Try
        End Sub

        Public Function GetAllByCondition(ByVal Condition As String) As List(Of BLL.BLLLog_T)
            Try
                Return _dataObject.SelectByCondition(Condition.ToString())
            Catch ex As System.Exception
                Throw ex
            End Try
        End Function

        Public Sub GetAllByCondition(ByVal Condition As String, ByRef dataSet As System.Data.DataSet, ByVal srcTable As String)
            Try
                _dataObject.SelectByCondition(Condition.ToString(), dataSet, srcTable)
            Catch ex As System.Exception
                Throw ex
            End Try
        End Sub

        Public Sub GetAllByCondition(ByVal Condition As String, ByRef dataSet As System.Data.DataSet)
            Try
                _dataObject.SelectByCondition(Condition.ToString(), dataSet)
            Catch ex As System.Exception
                Throw ex
            End Try
        End Sub

        Public Sub GetAllByCondition(ByVal Condition As String, ByRef dataTable As System.Data.dataTable)
            Try
                _dataObject.SelectByCondition(Condition.ToString(), dataTable)
            Catch ex As System.Exception
                Throw ex
            End Try
        End Sub

        Public Sub Delete(ByVal keys As BLL.BLLLog_TKeys)
            Try
                _dataObject.Delete(keys)
            Catch ex As System.Exception
                Throw ex
            End Try
        End Sub

        Public Sub Delete(ByVal fieldName As BLL.BLLLog_T.Log_TField, ByVal value As Object)
            Try
                _dataObject.DeleteByField(fieldName.ToString(), value)
            Catch ex As System.Exception
                Throw ex
            End Try
        End Sub

    End Class

End Namespace