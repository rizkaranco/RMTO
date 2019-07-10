Imports System
Imports System.Collections.Generic
Imports System.Text

Namespace BLL

    Public Class BLLCategory_T
        Inherits BLL.BusinessObjectBase

        Public Enum Category_TField
            CategoryID_bint
            Category_nvc
            Description_nvc
        End Enum

        Private _CategoryID_bint As Int64
        Private _Category_nvc As String
        Private _Description_nvc As String

        Public Property CategoryID_bint() As Int64
            Get
                Return _CategoryID_bint
            End Get
            Set(ByVal value As Int64)
                Me._CategoryID_bint = value
            End Set
        End Property

        Public Property Category_nvc() As String
            Get
                Return _Category_nvc
            End Get
            Set(ByVal value As String)
                Me._Category_nvc = value
            End Set
        End Property

        Public Property Description_nvc() As String
            Get
                Return _Description_nvc
            End Get
            Set(ByVal value As String)
                Me._Description_nvc = value
            End Set
        End Property

        Friend Overloads Overrides Sub AddValidationRules()
            ValidationRules.AddRules(New Validation.NotNullRule("Category_nvc", My.Resources.Captions.Title))
            ValidationRules.AddRules(New Validation.StringMaxLengthRule("Category_nvc", My.Resources.Captions.Title, 100))
            ValidationRules.AddRules(New Validation.StringMaxLengthRule("Description_nvc", My.Resources.Captions.Description, 500))
            ValidationRules.AddRules(New Validation.UniqueRule("UniqueCategory_nvc", My.Resources.Captions.Title, "Category_T", "Category_nvc"))
        End Sub

    End Class
End Namespace