Imports System
Imports System.Collections.Generic
Imports System.Text
Imports System.Data

Namespace BLL

    Public Class BLLExtraFieldTemplateTable_TFactory
        Inherits BLL.BusinessFactoryBase

        Private _dataObject As DAL.DALExtraFieldTemplateTable_T = Nothing

        Public Sub New()
            MyBase.New("ExtraFieldTemplateTable_T")
            _dataObject = MyBase.DataAccessLayer
        End Sub

        Public Sub Insert(ByVal businessObject As BLL.BLLExtraFieldTemplateTable_T)
            Try
                If businessObject.IsValid = False Then
                    Throw New Validation.InvalidBusinessObjectException(businessObject.BrokenRulesList.ToString())
                End If

                _dataObject.Insert(businessObject)
            Catch ex As System.Exception
                Throw Exception.HandleException.ChangeExceptionLanguage(ex, Me)
            End Try
        End Sub

        Public Sub Update(ByVal businessObject As BLL.BLLExtraFieldTemplateTable_T, ByVal businessObjectKey As BLL.BLLExtraFieldTemplateTable_TKeys)
            Try
                Dim Entity As BLL.BLLExtraFieldTemplateTable_T = _dataObject.SelectByPrimaryKey(businessObjectKey)

                If Entity IsNot Nothing AndAlso businessObject.ExtraFieldTemplateID_bint = Entity.ExtraFieldTemplateID_bint AndAlso businessObject.ExtraFieldTemplateTableID_bint = businessObject.ExtraFieldTemplateTableID_bint Then
                    If businessObject.IsValid("UniqueExtraFieldTemplateTableID_bint") = False Then
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

        Public Function GetBy(ByVal keys As BLL.BLLExtraFieldTemplateTable_TKeys) As BLL.BLLExtraFieldTemplateTable_T
            Try
                Return _dataObject.SelectByPrimaryKey(keys)
            Catch ex As System.Exception
                Throw Exception.HandleException.ChangeExceptionLanguage(ex, Me)
            End Try
        End Function

        Public Sub GetBy(ByVal keys As BLL.BLLExtraFieldTemplateTable_TKeys, ByRef dataSet As System.Data.DataSet, ByVal srcTable As String)
            Try
                _dataObject.SelectByPrimaryKey(keys, dataSet, srcTable)
            Catch ex As System.Exception
                Throw Exception.HandleException.ChangeExceptionLanguage(ex, Me)
            End Try
        End Sub

        Public Sub GetBy(ByVal keys As BLL.BLLExtraFieldTemplateTable_TKeys, ByRef dataSet As System.Data.DataSet)
            Try
                _dataObject.SelectByPrimaryKey(keys, dataSet)
            Catch ex As System.Exception
                Throw Exception.HandleException.ChangeExceptionLanguage(ex, Me)
            End Try
        End Sub

        Public Sub GetBy(ByVal keys As BLL.BLLExtraFieldTemplateTable_TKeys, ByRef dataTable As System.Data.DataTable)
            Try
                _dataObject.SelectByPrimaryKey(keys, dataTable)
            Catch ex As System.Exception
                Throw Exception.HandleException.ChangeExceptionLanguage(ex, Me)
            End Try
        End Sub

        Public Function GetAll() As List(Of BLL.BLLExtraFieldTemplateTable_T)
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

        Public Function GetAllBy(ByVal fieldName As BLL.BLLExtraFieldTemplateTable_T.ExtraFieldTemplateTable_TField, ByVal value As Object) As List(Of BLL.BLLExtraFieldTemplateTable_T)
            Try
                Return _dataObject.SelectByField(fieldName.ToString(), value)
            Catch ex As System.Exception
                Throw Exception.HandleException.ChangeExceptionLanguage(ex, Me)
            End Try
        End Function

        Public Sub GetAllBy(ByVal fieldName As BLL.BLLExtraFieldTemplateTable_T.ExtraFieldTemplateTable_TField, ByVal value As Object, ByRef dataSet As System.Data.DataSet, ByVal srcTable As String)
            Try
                _dataObject.SelectByField(fieldName.ToString(), value, dataSet, srcTable)
            Catch ex As System.Exception
                Throw Exception.HandleException.ChangeExceptionLanguage(ex, Me)
            End Try
        End Sub

        Public Sub GetAllBy(ByVal fieldName As BLL.BLLExtraFieldTemplateTable_T.ExtraFieldTemplateTable_TField, ByVal value As Object, ByRef dataSet As System.Data.DataSet)
            Try
                _dataObject.SelectByField(fieldName.ToString(), value, dataSet)
            Catch ex As System.Exception
                Throw Exception.HandleException.ChangeExceptionLanguage(ex, Me)
            End Try
        End Sub

        Public Sub GetAllBy(ByVal fieldName As BLL.BLLExtraFieldTemplateTable_T.ExtraFieldTemplateTable_TField, ByVal value As Object, ByRef dataTable As System.Data.DataTable)
            Try
                _dataObject.SelectByField(fieldName.ToString(), value, dataTable)
            Catch ex As System.Exception
                Throw Exception.HandleException.ChangeExceptionLanguage(ex, Me)
            End Try
        End Sub

        Public Function GetAllByCondition(ByVal Condition As String) As List(Of BLL.BLLExtraFieldTemplateTable_T)
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

        Public Sub Delete(ByVal keys As BLL.BLLExtraFieldTemplateTable_TKeys)
            Try
                _dataObject.Delete(keys)
            Catch ex As System.Exception
                Throw Exception.HandleException.ChangeExceptionLanguage(ex, Me)
            End Try
        End Sub

        Public Sub Delete(ByVal fieldName As BLL.BLLExtraFieldTemplateTable_T.ExtraFieldTemplateTable_TField, ByVal value As Object)
            Try
                _dataObject.DeleteByField(fieldName.ToString(), value)
            Catch ex As System.Exception
                Throw Exception.HandleException.ChangeExceptionLanguage(ex, Me)
            End Try
        End Sub

        Public Function GetTableThatHasExtraFieldTemplate() As List(Of BLL.BLLExtraFieldTemplateTable_T.TableThatHasExtraFieldTemplateStucture)
            Try
                Return _dataObject.SelectTablesThatHasExtraField()
            Catch ex As System.Exception
                Throw Exception.HandleException.ChangeExceptionLanguage(ex, Me)
            End Try
        End Function

        Public Function GetAllByExtraFieldTemplateIDAndTableID(ByVal ExtraFieldTemplateID As Int64, ByVal TableID As Int64) As List(Of BLL.BLLExtraFieldTemplateTable_T)
            Try
                Dim Condition As String = String.Empty
                Condition += "[ExtraFieldTemplateTable_T].[TableID_bint] = " + TableID.ToString + " And "
                Condition += "[ExtraFieldTemplateTable_T].[ExtraFieldTemplateID_bint] = " + ExtraFieldTemplateID.ToString
                Return _dataObject.SelectByCondition(Condition)
            Catch ex As System.Exception
                Throw Exception.HandleException.ChangeExceptionLanguage(ex, Me)
            End Try
        End Function

        Public Sub GetAllByTableID(ByVal TableID As Int64, ByRef DataTable As DataTable)
            Try
                Dim Condition As String = String.Empty
                Condition += "[ExtraFieldTemplateTable_T].[TableID_bint] = " + TableID.ToString
                _dataObject.SelectByCondition(Condition, DataTable)
            Catch ex As System.Exception
                Throw Exception.HandleException.ChangeExceptionLanguage(ex, Me)
            End Try
        End Sub

    End Class

End Namespace