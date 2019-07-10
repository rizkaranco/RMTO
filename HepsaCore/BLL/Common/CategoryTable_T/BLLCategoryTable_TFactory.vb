Imports System
Imports System.Collections.Generic
Imports System.Text
Imports System.Data

Namespace BLL

    Public Class BLLCategoryTable_TFactory
        Inherits BLL.BusinessFactoryBase

        Private _dataObject As DAL.DALCategoryTable_T = Nothing

        Public Sub New()
            MyBase.New("CategoryTable_T")
            _dataObject = MyBase.DataAccessLayer
        End Sub

        Public Sub Insert(ByVal businessObject As BLL.BLLCategoryTable_T)
            Try
                If businessObject.IsValid() = False Then
                    Throw New Validation.InvalidBusinessObjectException(businessObject.BrokenRulesList.ToString())
                End If

                _dataObject.Insert(businessObject)
            Catch ex As System.Exception
                Throw Exception.HandleException.ChangeExceptionLanguage(ex, Me)
            End Try
        End Sub

        Public Function GetBy(ByVal keys As BLL.BLLCategoryTable_TKeys) As BLL.BLLCategoryTable_T
            Try
                Return _dataObject.SelectByPrimaryKey(keys)
            Catch ex As System.Exception
                Throw Exception.HandleException.ChangeExceptionLanguage(ex, Me)
            End Try
        End Function

        Public Sub GetBy(ByVal keys As BLL.BLLCategoryTable_TKeys, ByRef dataSet As System.Data.DataSet, ByVal srcTable As String)
            Try
                _dataObject.SelectByPrimaryKey(keys, dataSet, srcTable)
            Catch ex As System.Exception
                Throw Exception.HandleException.ChangeExceptionLanguage(ex, Me)
            End Try
        End Sub

        Public Sub GetBy(ByVal keys As BLL.BLLCategoryTable_TKeys, ByRef dataSet As System.Data.DataSet)
            Try
                _dataObject.SelectByPrimaryKey(keys, dataSet)
            Catch ex As System.Exception
                Throw Exception.HandleException.ChangeExceptionLanguage(ex, Me)
            End Try
        End Sub

        Public Sub GetBy(ByVal keys As BLL.BLLCategoryTable_TKeys, ByRef dataTable As System.Data.DataTable)
            Try
                _dataObject.SelectByPrimaryKey(keys, dataTable)
            Catch ex As System.Exception
                Throw Exception.HandleException.ChangeExceptionLanguage(ex, Me)
            End Try
        End Sub

        Public Function GetAll() As List(Of BLL.BLLCategoryTable_T)
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

        Public Function GetAllBy(ByVal fieldName As BLL.BLLCategoryTable_T.CategoryTable_TField, ByVal value As Object) As List(Of BLL.BLLCategoryTable_T)
            Try
                Return _dataObject.SelectByField(fieldName.ToString(), value)
            Catch ex As System.Exception
                Throw Exception.HandleException.ChangeExceptionLanguage(ex, Me)
            End Try
        End Function

        Public Function GetAllByCategoryIDAndTableID(ByVal CategoryID As Int64, ByVal TableID As Int64) As List(Of BLL.BLLCategoryTable_T)
            Try
                Dim Condition As String = String.Empty
                Condition += "[CategoryTable_T].[TableID_bint] = " + TableID.ToString + " And "
                Condition += "[CategoryTable_T].[CategoryID_bint] = " + CategoryID.ToString
                Return _dataObject.SelectByCondition(Condition)
            Catch ex As System.Exception
                Throw Exception.HandleException.ChangeExceptionLanguage(ex, Me)
            End Try
        End Function

        Public Sub GetAllByTableID(ByVal TableID As Int64, ByRef DataTable As DataTable)
            Try
                Dim Condition As String = String.Empty
                Condition += "[CategoryTable_T].[TableID_bint] = " + TableID.ToString
                _dataObject.SelectByCondition(Condition, DataTable)
            Catch ex As System.Exception
                Throw Exception.HandleException.ChangeExceptionLanguage(ex, Me)
            End Try
        End Sub

        Public Sub GetAllBy(ByVal fieldName As BLL.BLLCategoryTable_T.CategoryTable_TField, ByVal value As Object, ByRef dataSet As System.Data.DataSet, ByVal srcTable As String)
            Try
                _dataObject.SelectByField(fieldName.ToString(), value, dataSet, srcTable)
            Catch ex As System.Exception
                Throw Exception.HandleException.ChangeExceptionLanguage(ex, Me)
            End Try
        End Sub

        Public Sub GetAllBy(ByVal fieldName As BLL.BLLCategoryTable_T.CategoryTable_TField, ByVal value As Object, ByRef dataSet As System.Data.DataSet)
            Try
                _dataObject.SelectByField(fieldName.ToString(), value, dataSet)
            Catch ex As System.Exception
                Throw Exception.HandleException.ChangeExceptionLanguage(ex, Me)
            End Try
        End Sub

        Public Sub GetAllBy(ByVal fieldName As BLL.BLLCategoryTable_T.CategoryTable_TField, ByVal value As Object, ByRef dataTable As System.Data.DataTable)
            Try
                _dataObject.SelectByField(fieldName.ToString(), value, dataTable)
            Catch ex As System.Exception
                Throw Exception.HandleException.ChangeExceptionLanguage(ex, Me)
            End Try
        End Sub

        Public Function GetAllByCondition(ByVal Condition As String) As List(Of BLL.BLLCategoryTable_T)
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

        Public Sub Delete(ByVal keys As BLL.BLLCategoryTable_TKeys)
            Try
                _dataObject.Delete(keys)
            Catch ex As System.Exception
                Throw Exception.HandleException.ChangeExceptionLanguage(ex, Me)
            End Try
        End Sub

        Public Sub Delete(ByVal fieldName As BLL.BLLCategoryTable_T.CategoryTable_TField, ByVal value As Object)
            Try
                _dataObject.DeleteByField(fieldName.ToString(), value)
            Catch ex As System.Exception
                Throw Exception.HandleException.ChangeExceptionLanguage(ex, Me)
            End Try
        End Sub

        Public Sub GetTablesThatHasCategory(ByRef srcDataTable As DataTable)
            Try
                _dataObject.SelectTablesThatHasCategory(srcDataTable)
            Catch ex As System.Exception
                Throw Exception.HandleException.ChangeExceptionLanguage(ex, Me)
            End Try
        End Sub

        Public Function GetTablesThatHasCategory() As List(Of BLL.BLLCategoryTable_T.TableThatHasCategoryStucture)
            Try
                Return _dataObject.SelectTablesThatHasCategory()
            Catch ex As System.Exception
                Throw Exception.HandleException.ChangeExceptionLanguage(ex, Me)
            End Try
        End Function

    End Class

End Namespace