Imports System
Imports System.Collections.Generic
Imports System.Text

Namespace BLL

    Public Class BLLCategoryTree_T
        Inherits BLL.BusinessObjectBase

        Public Enum CategoryTree_TField
            CategoryTreeID_bint
            CategoryID_bint
            Node_nvc
            ParentID_bint
        End Enum

        Private _CategoryTreeID_bint As Int64
        Private _CategoryID_bint As Nullable(Of Int64)
        Private _Node_nvc As String
        Private _ParentID_bint As Nullable(Of Int64)

        Public Property CategoryTreeID_bint() As Int64
            Get
                Return _CategoryTreeID_bint
            End Get
            Set(ByVal value As Int64)
                Me._CategoryTreeID_bint = value
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

        Public Property Node_nvc() As String
            Get
                Return _Node_nvc
            End Get
            Set(ByVal value As String)
                Me._Node_nvc = value
            End Set
        End Property

        Public Property ParentID_bint() As Nullable(Of Int64)
            Get
                Return _ParentID_bint
            End Get
            Set(ByVal value As Nullable(Of Int64))
                Me._ParentID_bint = value
            End Set
        End Property

        Friend Overloads Overrides Sub AddValidationRules()
            ValidationRules.AddRules(New Validation.NotNullRule("CategoryID_bint", My.Resources.Captions.Group))
            ValidationRules.AddRules(New Validation.RelationRule("RelationCategoryID_bint", My.Resources.Captions.Group, "Category_T", "CategoryID_bint"))
            ValidationRules.AddRules(New Validation.NotNullRule("Node_nvc", My.Resources.Captions.TieName))
            ValidationRules.AddRules(New Validation.StringMaxLengthRule("Node_nvc", My.Resources.Captions.TieName, 100))
            ValidationRules.AddRules(New Validation.NumericRule(Of Int64)("ParentID_bint", My.Resources.Captions.Parent, Nothing, Nothing, 0, 0))
            ValidationRules.AddRules(New Validation.UniqueRule("UniqueNode_nvc", My.Resources.Captions.TieName, False, "CategoryTree_T", "Node_nvc", "CategoryID_bint", "ParentID_bint"))
        End Sub

    End Class
End Namespace