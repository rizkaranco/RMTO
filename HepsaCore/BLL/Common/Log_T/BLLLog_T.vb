Imports System
Imports System.Collections.Generic
Imports System.Text

Namespace BLL

    Public Class BLLLog_T
        Inherits BusinessObjectBase

        Public Enum Log_TField
            LogID_bint
            UserName_nvc
            Date_nvc
            Time_nvc
            IPAddress_nvc
            MacAddress_nvc
            FormText_nvc
            ActionID_int
            Body_nvc
        End Enum


        Private _LogID_bint As Int64
        Private _UserName_nvc As String
        Private _Date_nvc As String
        Private _Time_nvc As String
        Private _IPAddress_nvc As String
        Private _MacAddress_nvc As String
        Private _FormText_nvc As String
        Private _ActionID_int As Int32
        Private _Body_nvc As String


        Public Property LogID_bint() As Int64
            Get
                Return _LogID_bint
            End Get
            Set(ByVal value As Int64)
                Me._LogID_bint = Value
            End Set
        End Property

        Public Property UserName_nvc() As String
            Get
                Return _UserName_nvc
            End Get
            Set(ByVal value As String)
                Me._UserName_nvc = Value
            End Set
        End Property

        Public Property Date_nvc() As String
            Get
                Return _Date_nvc
            End Get
            Set(ByVal value As String)
                Me._Date_nvc = Value
            End Set
        End Property

        Public Property Time_nvc() As String
            Get
                Return _Time_nvc
            End Get
            Set(ByVal value As String)
                Me._Time_nvc = Value
            End Set
        End Property

        Public Property IPAddress_nvc() As String
            Get
                Return _IPAddress_nvc
            End Get
            Set(ByVal value As String)
                Me._IPAddress_nvc = Value
            End Set
        End Property

        Public Property MacAddress_nvc() As String
            Get
                Return _MacAddress_nvc
            End Get
            Set(ByVal value As String)
                Me._MacAddress_nvc = Value
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

        Public Property ActionID_int() As Int32
            Get
                Return _ActionID_int
            End Get
            Set(ByVal value As Int32)
                Me._ActionID_int = Value
            End Set
        End Property

        Public Property Body_nvc() As String
            Get
                Return _Body_nvc
            End Get
            Set(ByVal value As String)
                Me._Body_nvc = Value
            End Set
        End Property


        Friend Overloads Overrides Sub AddValidationRules()
            ValidationRules.AddRules(New Validation.NotNullRule("UserName_nvc", "نام کاربری"))
            ValidationRules.AddRules(New Validation.StringMaxLengthRule("UserName_nvc", "نام کاربری", 100))
            ValidationRules.AddRules(New Validation.RelationRule("UserName_nvc", "نام کاربری", "User_T", "UserName_nvc"))
            ValidationRules.AddRules(New Validation.NotNullRule("Date_nvc", "تاریخ"))
            ValidationRules.AddRules(New Validation.StringMaxLengthRule("Date_nvc", "تاریخ", 10))
            ValidationRules.AddRules(New Validation.NotNullRule("Time_nvc", "ساعت"))
            ValidationRules.AddRules(New Validation.StringMaxLengthRule("Time_nvc", "ساعت", 10))
            ValidationRules.AddRules(New Validation.NotNullRule("IPAddress_nvc", "آدرس IP"))
            ValidationRules.AddRules(New Validation.StringMaxLengthRule("IPAddress_nvc", "آدرس IP", 50))
            ValidationRules.AddRules(New Validation.NotNullRule("MacAddress_nvc", "آدرس Mac"))
            ValidationRules.AddRules(New Validation.StringMaxLengthRule("MacAddress_nvc", "آدرس Mac", 50))
            ValidationRules.AddRules(New Validation.NotNullRule("FormText_nvc", "نام فرم"))
            ValidationRules.AddRules(New Validation.NotNullRule("ActionID_int", "عملیات"))
            ValidationRules.AddRules(New Validation.RelationRule("ActionID_int", "عملیات", "Action_T", "ActionID_int"))
            ValidationRules.AddRules(New Validation.NotNullRule("Body_nvc", "log متن"))
            ValidationRules.AddRules(New Validation.StringMaxLengthRule("Body_nvc", "log متن", 3000))
            ValidationRules.AddRules(New Validation.UniqueRule("UniqueLogID_bint", "log شناسه", "Log_T", "LogID_bint"))
        End Sub
    End Class
End Namespace