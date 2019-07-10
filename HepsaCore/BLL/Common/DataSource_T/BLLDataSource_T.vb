Imports System
Imports System.Collections.Generic
Imports System.Text

Namespace BLL

    Public Class BLLDataSource_T
        Inherits BLL.BusinessObjectBase

        Public Enum DataSource_TField
            DataSourceID_bint
            DataSource_nvc
        End Enum


        Private _DataSourceID_bint As Int64
        Private _DataSource_nvc As String

        Public Property DataSourceID_bint() As Int64
            Get
                Return _DataSourceID_bint
            End Get
            Set(ByVal value As Int64)
                Me._DataSourceID_bint = value
            End Set
        End Property

        Public Property DataSource_nvc() As String
            Get
                Return _DataSource_nvc
            End Get
            Set(ByVal value As String)
                Me._DataSource_nvc = value
            End Set
        End Property

        Friend Overloads Overrides Sub AddValidationRules()
            ValidationRules.AddRules(New Validation.NotNullRule("DataSource_nvc", My.Resources.Captions.DataSourceTitle))
            ValidationRules.AddRules(New Validation.StringMaxLengthRule("DataSource_nvc", My.Resources.Captions.DataSourceTitle, 100))
            ValidationRules.AddRules(New Validation.UniqueRule("UniqueDataSource_nvc", My.Resources.Captions.DataSourceTitle, "DataSource_T", "DataSource_nvc"))
        End Sub

    End Class
End Namespace