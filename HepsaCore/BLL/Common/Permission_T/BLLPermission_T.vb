Imports System
Imports System.Collections.Generic
Imports System.Text

Namespace BLL

    Public Class BLLPermission_T
        Inherits BLL.BusinessObjectBase

        Public Enum Permission_TField
            PermissionID_bint
            Permission_nvc
            PermissionGroupID_bint
            FormName_nvc
            ControlName_nvc
            PropertyName_nvc
            Value_nvc
            ColumnName_nvc
        End Enum


        Private _PermissionID_bint As Int64
        Private _Permission_nvc As String
        Private _PermissionGroupID_bint As Int64
        Private _FormName_nvc As String
        Private _ControlName_nvc As String
        Private _PropertyName_nvc As String
        Private _Value_nvc As String
        Private _ColumnName_nvc As String


        Public Property PermissionID_bint() As Int64
            Get
                Return _PermissionID_bint
            End Get
            Set(ByVal value As Int64)
                Me._PermissionID_bint = value
            End Set
        End Property

        Public Property Permission_nvc() As String
            Get
                Return _Permission_nvc
            End Get
            Set(ByVal value As String)
                Me._Permission_nvc = value
            End Set
        End Property

        Public Property PermissionGroupID_bint() As Int64
            Get
                Return _PermissionGroupID_bint
            End Get
            Set(ByVal value As Int64)
                Me._PermissionGroupID_bint = value
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

        Public Property ControlName_nvc() As String
            Get
                Return _ControlName_nvc
            End Get
            Set(ByVal value As String)
                Me._ControlName_nvc = value
            End Set
        End Property

        Public Property PropertyName_nvc() As String
            Get
                Return _PropertyName_nvc
            End Get
            Set(ByVal value As String)
                Me._PropertyName_nvc = value
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

        Public Property ColumnName_nvc() As String
            Get
                Return _ColumnName_nvc
            End Get
            Set(ByVal value As String)
                Me._ColumnName_nvc = value
            End Set
        End Property

        Friend Overloads Overrides Sub AddValidationRules()
            ValidationRules.AddRules(New Validation.NotNullRule("PermissionID_bint", "کد مجوز"))
            ValidationRules.AddRules(New Validation.NumericRule(Of Int64)("PermissionID_bint", "کد مجوز", 1, Nothing, 4, 0))

            ValidationRules.AddRules(New Validation.NotNullRule("Permission_nvc", "عنوان مجوز"))
            ValidationRules.AddRules(New Validation.StringMaxLengthRule("Permission_nvc", "عنوان مجوز", 100))

            ValidationRules.AddRules(New Validation.NotNullRule("PermissionGroupID_bint", "کد گروه مجوز"))
            ValidationRules.AddRules(New Validation.NumericRule(Of Int64)("PermissionGroupID_bint", "کد گروه مجوز", Nothing, Nothing, 0, 0))
            ValidationRules.AddRules(New Validation.RelationRule("RelationPermissionGroupID_bint", "گروه مجوز", "PermissionGroup_T", "PermissionGroup_T"))

            ValidationRules.AddRules(New Validation.StringMaxLengthRule("FormName_nvc", "نام فرم", 50))
            ValidationRules.AddRules(New Validation.StringMaxLengthRule("ControlName_nvc", "نام کنترل", 50))
            ValidationRules.AddRules(New Validation.StringMaxLengthRule("PropertyName_nvc", "نام خاصیت", 50))
            ValidationRules.AddRules(New Validation.StringMaxLengthRule("Value_nvc", "مقدار", 50))
            ValidationRules.AddRules(New Validation.StringMaxLengthRule("ColumnName_nvc", "نام ستون ", 50))

            ValidationRules.AddRules(New Validation.UniqueRule("UniquePermissionID_bint", "کد مجوز", "Permission_T", "PermissionID_bint"))
            ValidationRules.AddRules(New Validation.UniqueRule("UniquePermission_nvc", "عنوان مجوز", "Permission_T", "Permission_nvc", "PermissionGroupID_bint"))
        End Sub

    End Class
End Namespace