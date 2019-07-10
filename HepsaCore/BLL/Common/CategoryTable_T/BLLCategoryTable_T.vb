Imports System
Imports System.Collections.Generic
Imports System.Text

Namespace BLL
    Public Class BLLCategoryTable_T
        Inherits BLL.BusinessObjectBase

        Public Class TableThatHasCategoryStucture
            Private _TableName As String
            Private _TableId As Int32

            Public Property TableName() As String
                Get
                    Return Me._TableName
                End Get
                Set(ByVal value As String)
                    Me._TableName = value
                End Set
            End Property

            Public Property TableID() As Int32
                Get
                    Return Me._TableId
                End Get
                Set(ByVal value As Int32)
                    Me._TableId = value
                End Set
            End Property
        End Class

        Public Enum CategoryTable_TField
            CategoryTableID_bint
            CategoryID_bint
            TableID_bint
        End Enum

        Private _CategoryTableID_bint As Int64
        Private _CategoryID_bint As Nullable(Of Int64)
        Private _TableID_bint As Nullable(Of Int64)

        Public Property CategoryTableID_bint() As Int64
            Get
                Return _CategoryTableID_bint
            End Get
            Set(ByVal value As Int64)
                Me._CategoryTableID_bint = value
            End Set
        End Property

        Public Property CategoryID_bint() As Nullable(Of Int64)
            Get
                Return _CategoryID_bint
            End Get
            Set(ByVal value As Nullable(Of Int64))
                Me._CategoryID_bint = value
            End Set
        End Property

        Public Property TableID_bint() As Nullable(Of Int64)
            Get
                Return _TableID_bint
            End Get
            Set(ByVal value As Nullable(Of Int64))
                Me._TableID_bint = value
            End Set
        End Property

        Friend Overloads Overrides Sub AddValidationRules()
            ValidationRules.AddRules(New Validation.NotNullRule("CategoryID_bint", My.Resources.Captions.Group))
            ValidationRules.AddRules(New Validation.RelationRule("RelationCategoryID_bint", My.Resources.Captions.Group, "Category_T", "CategoryID_bint"))
            ValidationRules.AddRules(New Validation.NotNullRule("TableID_bint", My.Resources.Captions.Table))
            ValidationRules.AddRules(New Validation.NumericRule(Of Int64)("TableID_bint", My.Resources.Captions.Table, Nothing, Nothing, 0, 0))
            ValidationRules.AddRules(New Validation.UniqueRule("UniqueCategoryTableID_bint", My.Resources.Captions.GroupTable, "CategoryTable_T", "CategoryID_bint", "TableID_bint"))
        End Sub

    End Class
End Namespace