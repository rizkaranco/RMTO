Imports System
Imports System.Collections.Generic
Imports System.Text

Namespace BLL

    Public Class BLLDataSourceItem_T
        Inherits BLL.BusinessObjectBase

        Public Enum DataSourceItem_TField
            DataSourceItemID_bint
            DataSourceID_bint
            DataSourceItem_nvc
        End Enum


        Private _DataSourceItemID_bint As Int64
        Private _DataSourceID_bint As Nullable(Of Int64)
        Private _DataSourceItem_nvc As String


        Public Property DataSourceItemID_bint() As Int64
            Get
                Return _DataSourceItemID_bint
            End Get
            Set(ByVal value As Int64)
                Me._DataSourceItemID_bint = value
            End Set
        End Property

        Public Property DataSourceID_bint() As Nullable(Of Int64)
            Get
                Return _DataSourceID_bint
            End Get
            Set(ByVal value As Nullable(Of Int64))
                Me._DataSourceID_bint = value
            End Set
        End Property

        Public Property DataSourceItem_nvc() As String
            Get
                Return _DataSourceItem_nvc
            End Get
            Set(ByVal value As String)
                Me._DataSourceItem_nvc = value
            End Set
        End Property


        Friend Overloads Overrides Sub AddValidationRules()
            ValidationRules.AddRules(New Validation.RelationRule("RelationDataSourceID_bint", My.Resources.Captions.DataSource, "DataSource_T", "DataSourceID_bint"))
            ValidationRules.AddRules(New Validation.NotNullRule("DataSourceItem_nvc", My.Resources.Captions.DataSourceDetailTitle))
            ValidationRules.AddRules(New Validation.StringMaxLengthRule("DataSourceItem_nvc", My.Resources.Captions.DataSourceDetailTitle, 100))
            ValidationRules.AddRules(New Validation.UniqueRule("UniqueDataSourceItem_nvc", My.Resources.Captions.DataSourceDetailTitle, "DataSourceItem_T", "DataSourceItem_nvc", "DataSourceID_bint"))
        End Sub

    End Class
End Namespace