Imports System
Imports System.Collections.Generic
Imports System.Text

Namespace BLL

    Public Class BLLExtraField_T
        Inherits BLL.BusinessObjectBase

        Public Enum ExtraField_TField
            ExtraFieldID_bint
            ExtraFieldTemplateID_bint
            ExtraField_nvc
            ExtraFieldDataTypeID_tint
            DataSourceID_bint
        End Enum


        Private _ExtraFieldID_bint As Int64
        Private _ExtraFieldTemplateID_bint As Nullable(Of Int64)
        Private _ExtraField_nvc As String
        Private _ExtraFieldDataTypeID_tint As Nullable(Of Byte)
        Private _DataSourceID_bint As Nullable(Of Int64)


        Public Property ExtraFieldID_bint() As Int64
            Get
                Return _ExtraFieldID_bint
            End Get
            Set(ByVal value As Int64)
                Me._ExtraFieldID_bint = value
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

        Public Property ExtraField_nvc() As String
            Get
                Return _ExtraField_nvc
            End Get
            Set(ByVal value As String)
                Me._ExtraField_nvc = value
            End Set
        End Property

        Public Property ExtraFieldDataTypeID_tint() As Nullable(Of Byte)
            Get
                Return _ExtraFieldDataTypeID_tint
            End Get
            Set(ByVal value As Nullable(Of Byte))
                Me._ExtraFieldDataTypeID_tint = value
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

        Friend Overloads Overrides Sub AddValidationRules()
            ValidationRules.AddRules(New Validation.NotNullRule("ExtraField_nvc", My.Resources.Captions.ExtraField))
            ValidationRules.AddRules(New Validation.StringMaxLengthRule("ExtraField_nvc", My.Resources.Captions.ExtraField, 100))
            ValidationRules.AddRules(New Validation.NotNullRule("ExtraFieldDataTypeID_tint", My.Resources.Captions.ExtraFieldDataType))
            ValidationRules.AddRules(New Validation.NotNullRule("ExtraFieldTemplateID_bint", My.Resources.Captions.ExtraFieldInformation))
            ValidationRules.AddRules(New Validation.NotNullRule("DataSourceID_bint", My.Resources.Captions.DataSource))
            ValidationRules.AddRules(New Validation.RelationRule("RelationExtraFieldDataTypeID_tint", My.Resources.Captions.ExtraFieldDataType, "ExtraFieldDataType_T", "ExtraFieldDataTypeID_tint"))
            ValidationRules.AddRules(New Validation.RelationRule("RelationExtraFieldTemplateID_bint", My.Resources.Captions.ExtraFieldTemplate, "ExtraFieldTemplate_T", "ExtraFieldTemplateID_bint"))
            ValidationRules.AddRules(New Validation.RelationRule("RelationDataSourceID_bint", My.Resources.Captions.DataSource, "DataSource_T", "DataSourceID_bint"))
            ValidationRules.AddRules(New Validation.UniqueRule("UniqueExtraField_nvc", My.Resources.Captions.ExtraField, "ExtraField_T", "ExtraField_nvc", "ExtraFieldTemplateID_bint"))
        End Sub

    End Class
End Namespace