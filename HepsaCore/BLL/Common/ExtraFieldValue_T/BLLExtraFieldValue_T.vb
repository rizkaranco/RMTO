Imports System
Imports System.Collections.Generic
Imports System.Text

Namespace BLL

    Public Class BLLExtraFieldValue_T
        Inherits BLL.BusinessObjectBase

        Public Enum ExtraFieldValue_TField
            ExtraFieldID_bint
            TableID_bint
            ParentID_nvc
            Value_nvc
            Value_vbin
            FileExtention_nvc
        End Enum


        Private _ExtraFieldID_bint As Int64
        Private _TableID_bint As Int64
        Private _ParentID_nvc As String
        Private _Value_nvc As String
        Private _Value_vbin() As Byte
        Private _FileExtention_nvc As String


        Public Property ExtraFieldID_bint() As Int64
            Get
                Return _ExtraFieldID_bint
            End Get
            Set(ByVal value As Int64)
                Me._ExtraFieldID_bint = value
            End Set
        End Property

        Public Property TableID_bint() As Int64
            Get
                Return _TableID_bint
            End Get
            Set(ByVal value As Int64)
                Me._TableID_bint = value
            End Set
        End Property

        Public Property ParentID_nvc() As String
            Get
                Return _ParentID_nvc
            End Get
            Set(ByVal value As String)
                Me._ParentID_nvc = value
            End Set
        End Property

        Public Property Value_nvc() As String
            Get
                Return _Value_nvc
            End Get
            Set(ByVal value As String)
                Me._Value_nvc = value
            End Set
        End Property

        Public Property Value_vbin() As Byte()
            Get
                Return _Value_vbin
            End Get
            Set(ByVal value As Byte())
                Me._Value_vbin = value
            End Set
        End Property

        Public Property FileExtention_nvc() As String
            Get
                Return _FileExtention_nvc
            End Get
            Set(ByVal value As String)
                Me._FileExtention_nvc = value
            End Set
        End Property

        Friend Overloads Overrides Sub AddValidationRules()
            ValidationRules.AddRules(New Validation.NotNullRule("ExtraFieldID_bint", "خاصیت اضافی"))
            ValidationRules.AddRules(New Validation.RelationRule("RelationExtraFieldID_bint", "خاصیت اضافی", "ExtraField_T", "ExtraFieldID_bint"))
            ValidationRules.AddRules(New Validation.NotNullRule("TableID_bint", "کد جدول"))
            ValidationRules.AddRules(New Validation.NumericRule(Of Int64)("TableID_bint", "کد جدول", Nothing, Nothing, 0, 0))
            ValidationRules.AddRules(New Validation.NotNullRule("ParentID_nvc", "کد والد"))
            ValidationRules.AddRules(New Validation.StringMaxLengthRule("ParentID_nvc", "کد والد", 100))
            ValidationRules.AddRules(New Validation.StringMaxLengthRule("Value_nvc", "مقدار", 100))
            ValidationRules.AddRules(New Validation.StringMaxLengthRule("FileExtention_nvc", "پسوند فایل", 100))
            ValidationRules.AddRules(New Validation.UniqueRule("Unique", "خاصیت اضافی", "ExtraFieldValue_T", "ExtraFieldID_bint", "TableID_bint", "ParentID_nvc"))
        End Sub

    End Class
End Namespace