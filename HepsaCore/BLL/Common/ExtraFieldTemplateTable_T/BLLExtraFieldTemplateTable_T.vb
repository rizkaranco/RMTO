Imports System
Imports System.Collections.Generic
Imports System.Text

Namespace BLL

    Public Class BLLExtraFieldTemplateTable_T
        Inherits BLL.BusinessObjectBase

        Public Class TableThatHasExtraFieldTemplateStucture
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

        Public Enum ExtraFieldTemplateTable_TField
            ExtraFieldTemplateTableID_bint
            ExtraFieldTemplateID_bint
            TableID_bint
        End Enum

        Private _ExtraFieldTemplateTableID_bint As Int64
        Private _ExtraFieldTemplateID_bint As Nullable(Of Int64)
        Private _TableID_bint As Nullable(Of Int64)

        Public Property ExtraFieldTemplateTableID_bint() As Int64
            Get
                Return _ExtraFieldTemplateTableID_bint
            End Get
            Set(ByVal value As Int64)
                Me._ExtraFieldTemplateTableID_bint = value
            End Set
        End Property

        Public Property ExtraFieldTemplateID_bint() As Nullable(Of Int64)
            Get
                Return _ExtraFieldTemplateID_bint
            End Get
            Set(ByVal value As Nullable(Of Int64))
                Me._ExtraFieldTemplateID_bint = value
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
            ValidationRules.AddRules(New Validation.NotNullRule("ExtraFieldTemplateTableID_bint", My.Resources.Captions.ExtaFieldTableID))
            ValidationRules.AddRules(New Validation.NumericRule(Of Int64)("ExtraFieldTemplateTableID_bint", My.Resources.Captions.ExtaFieldTableID, Nothing, Nothing, 0, 0))

            ValidationRules.AddRules(New Validation.RelationRule("RelationExtraFieldTemplateID_bint", "الگوی اطلاعات اضافی", "ExtraFieldTemplate_T", "ExtraFieldTemplateID_bint"))
            ValidationRules.AddRules(New Validation.NumericRule(Of Int64)("TableID_bint", "شناسه جدول", Nothing, Nothing, 0, 0))
            ValidationRules.AddRules(New Validation.UniqueRule("UniqueExtraFieldTemplateTableID_bint", "شناسه جدول-فیلد اضافه", "ExtraFieldTemplateTable_T", "ExtraFieldTemplateID_bint", "TableID_bint"))
        End Sub

    End Class

End Namespace