Imports System
Imports System.Collections.Generic
Imports System.Text

Namespace BLL

    Public Class BLLExtraFieldDataType_T
        Inherits BLL.BusinessObjectBase

        Public Enum ExtraFieldDataType_TField
            ExtraFieldDataTypeID_tint
            ExtraFieldDataType_nvc
        End Enum


        Private _ExtraFieldDataTypeID_tint As Byte
        Private _ExtraFieldDataType_nvc As String


        Public Property ExtraFieldDataTypeID_tint() As Byte
            Get
                Return _ExtraFieldDataTypeID_tint
            End Get
            Set(ByVal value As Byte)
                Me._ExtraFieldDataTypeID_tint = value
            End Set
        End Property

        Public Property ExtraFieldDataType_nvc() As String
            Get
                Return _ExtraFieldDataType_nvc
            End Get
            Set(ByVal value As String)
                Me._ExtraFieldDataType_nvc = value
            End Set
        End Property

        Friend Overloads Overrides Sub AddValidationRules()
            ValidationRules.AddRules(New Validation.NotNullRule("ExtraFieldDataTypeID_tint", My.Resources.Captions.DataTypeCode))
            ValidationRules.AddRules(New Validation.NumericRule(Of Byte)("ExtraFieldDataTypeID_tint", My.Resources.Captions.DataTypeCode, 1, 100, 2, 0))
            ValidationRules.AddRules(New Validation.NotNullRule("ExtraFieldDataType_nvc", My.Resources.Captions.DataTypeTitle))
            ValidationRules.AddRules(New Validation.StringMaxLengthRule("ExtraFieldDataType_nvc", My.Resources.Captions.DataTypeTitle, 100))
            ValidationRules.AddRules(New Validation.UniqueRule("UniqueExtraFieldDataTypeID_tint", My.Resources.Captions.DataTypeCode, "ExtraFieldDataType_T", "ExtraFieldDataTypeID_tint"))
            ValidationRules.AddRules(New Validation.UniqueRule("UniqueExtraFieldDataType_nvc", My.Resources.Captions.DataTypeTitle, "ExtraFieldDataType_T", "ExtraFieldDataType_nvc"))
        End Sub

    End Class
End Namespace