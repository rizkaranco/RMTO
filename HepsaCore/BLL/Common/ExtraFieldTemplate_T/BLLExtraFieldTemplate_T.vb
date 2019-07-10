Imports System
Imports System.Collections.Generic
Imports System.Text

Namespace BLL

    Public Class BLLExtraFieldTemplate_T
        Inherits BLL.BusinessObjectBase

        Public Enum ExtraFieldTemplate_TField
            ExtraFieldTemplateID_bint
            ExtraFieldTemplate_nvc
        End Enum

        Private _ExtraFieldTemplateID_bint As Int64
        Private _ExtraFieldTemplate_nvc As String

        Public Property ExtraFieldTemplateID_bint() As Int64
            Get
                Return _ExtraFieldTemplateID_bint
            End Get
            Set(ByVal value As Int64)
                Me._ExtraFieldTemplateID_bint = value
            End Set
        End Property

        Public Property ExtraFieldTemplate_nvc() As String
            Get
                Return _ExtraFieldTemplate_nvc
            End Get
            Set(ByVal value As String)
                Me._ExtraFieldTemplate_nvc = value
            End Set
        End Property

        Friend Overloads Overrides Sub AddValidationRules()
            ValidationRules.AddRules(New Validation.NotNullRule("ExtraFieldTemplate_nvc", My.Resources.Captions.FieldTemplateTitle))
            ValidationRules.AddRules(New Validation.StringMaxLengthRule("ExtraFieldTemplate_nvc", My.Resources.Captions.FieldTemplateTitle, 100))
            ValidationRules.AddRules(New Validation.UniqueRule("UniqueExtraFieldTemplate_nvc", My.Resources.Captions.FieldTemplateTitle, "ExtraFieldTemplate_T", "ExtraFieldTemplate_nvc"))
        End Sub

    End Class
End Namespace