Imports System
Imports System.Collections.Generic
Imports System.Text
Imports Hepsa.Core.Validation

Namespace BLL

    Public Class BLLForm_T
        Inherits BusinessObjectBase

        Public Enum Form_TField
            FormID_int
            FormName_nvc
            FormText_nvc
        End Enum


        Private _FormID_int As Int32
        Private _FormName_nvc As String
        Private _FormText_nvc As String


        Public Property FormID_int() As Int32
            Get
                Return _FormID_int
            End Get
            Set(ByVal value As Int32)
                Me._FormID_int = value
            End Set
        End Property

        Public Property FormName_nvc() As String
            Get
                Return _FormName_nvc
            End Get
            Set(ByVal value As String)
                Me._FormName_nvc = value
            End Set
        End Property

        Public Property FormText_nvc() As String
            Get
                Return _FormText_nvc
            End Get
            Set(ByVal value As String)
                Me._FormText_nvc = value
            End Set
        End Property


        Friend Overloads Overrides Sub AddValidationRules()
            ValidationRules.AddRules(New NotNullRule("FormName_nvc", "نام فرم"))
            ValidationRules.AddRules(New StringMaxLengthRule("FormName_nvc", "نام فرم", 200))
            ValidationRules.AddRules(New NotNullRule("FormText_nvc", "عنوان فرم"))
            ValidationRules.AddRules(New StringMaxLengthRule("FormText_nvc", "عنوان فرم", 200))
            ValidationRules.AddRules(New UniqueRule("UniqueFormID_int", "شناسه فرم", "Form_T", "FormID_int"))
        End Sub
    End Class
End Namespace