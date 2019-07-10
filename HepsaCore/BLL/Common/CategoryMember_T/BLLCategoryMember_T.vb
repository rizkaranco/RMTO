Imports System
Imports System.Collections.Generic
Imports System.Text

Namespace BLL

    Public Class BLLCategoryMember_T
        Inherits BLL.BusinessObjectBase

        Public Enum CategoryMember_TField
            CategotyMemberID_bint
            CategoryTreeID_bint
            TableID_bint
            MemberID_nvc
        End Enum

        Private _CategotyMemberID_bint As Int64
        Private _CategoryTreeID_bint As Nullable(Of Int64)
        Private _TableID_bint As Nullable(Of Int64)
        Private _MemberID_nvc As String

        Public Property CategotyMemberID_bint() As Int64
            Get
                Return _CategotyMemberID_bint
            End Get
            Set(ByVal value As Int64)
                Me._CategotyMemberID_bint = value
            End Set
        End Property

        Public Property CategoryTreeID_bint() As Nullable(Of Int64)
            Get
                Return _CategoryTreeID_bint
            End Get
            Set(ByVal value As Nullable(Of Int64))
                Me._CategoryTreeID_bint = value
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

        Public Property MemberID_nvc() As String
            Get
                Return _MemberID_nvc
            End Get
            Set(ByVal value As String)
                Me._MemberID_nvc = value
            End Set
        End Property

        Friend Overloads Overrides Sub AddValidationRules()
            ValidationRules.AddRules(New Validation.NotNullRule("CategoryTreeID_bint", My.Resources.Captions.Tie))
            ValidationRules.AddRules(New Validation.RelationRule("CategoryTreeID_bint", My.Resources.Captions.Tie, "CategoryTree_T", "CategoryTreeID_bint"))

            ValidationRules.AddRules(New Validation.NotNullRule("TableID_bint", My.Resources.Captions.Table))
            ValidationRules.AddRules(New Validation.NumericRule(Of Int64)("TableID_bint", My.Resources.Captions.Table, Nothing, Nothing, 0, 0))

            ValidationRules.AddRules(New Validation.NotNullRule("MemberID_nvc", My.Resources.Captions.Value))
            ValidationRules.AddRules(New Validation.StringMaxLengthRule("MemberID_nvc", My.Resources.Captions.Value, 100))

            ValidationRules.AddRules(New Validation.UniqueRule("UniqueMemberID", My.Resources.Captions.Group, "CategoryMember_T", "MemberID_nvc", "TableID_bint", "CategoryTreeID_bint"))
        End Sub

    End Class
End Namespace