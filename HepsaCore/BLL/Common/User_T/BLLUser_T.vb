Imports System
Imports System.Collections.Generic
Imports System.Text

Namespace BLL

    Public Class BLLUser_T
        Inherits BLL.BusinessObjectBase

        Public Enum User_TField
            UserName_nvc
            FullName_nvc
            Password_nvc
            StartDate_vc
            ExpireDate_vc
            Permissions_vc
            Picture_img
            Activity_bit
            ExtraFieldTemplateID_bint
        End Enum

        Private _UserName_nvc As String
        Private _FullName_nvc As String
        Private _Password_nvc As String
        Private _StartDate_vc As String
        Private _ExpireDate_vc As String
        Private _Permissions_vc As String
        Private _Picture_img() As Byte
        Private _Activity_bit As Boolean
        Private _ExtraFieldTemplateID_bint As Nullable(Of Int64)
        Private _ConfirmPassword_nvc As String
        Private _Permissions As New List(Of Hepsa.Core.BLL.BLLPermission_T)

        Public Property UserName_nvc() As String
            Get
                Return _UserName_nvc
            End Get
            Set(ByVal value As String)
                Me._UserName_nvc = value
            End Set
        End Property

        Public Property FullName_nvc() As String
            Get
                Return _FullName_nvc
            End Get
            Set(ByVal value As String)
                Me._FullName_nvc = value
            End Set
        End Property

        Public Property Password_nvc() As String
            Get
                Return _Password_nvc
            End Get
            Set(ByVal value As String)
                Me._Password_nvc = value
            End Set
        End Property

        Public Property ConfirmPassword_nvc() As String
            Get
                Return _ConfirmPassword_nvc
            End Get
            Set(ByVal value As String)
                Me._ConfirmPassword_nvc = value
            End Set
        End Property

        Public Property StartDate_vc() As String
            Get
                Return _StartDate_vc
            End Get
            Set(ByVal value As String)
                Me._StartDate_vc = value
            End Set
        End Property

        Public Property ExpireDate_vc() As String
            Get
                Return _ExpireDate_vc
            End Get
            Set(ByVal value As String)
                Me._ExpireDate_vc = value
            End Set
        End Property

        Public Property Permissions_vc() As String
            Get
                Return _Permissions_vc
            End Get
            Set(ByVal value As String)
                Me._Permissions_vc = value
            End Set
        End Property

        Public Property Picture_img() As Byte()
            Get
                Return _Picture_img
            End Get
            Set(ByVal value As Byte())
                Me._Picture_img = value
            End Set
        End Property

        Public Property Activity_bit() As Boolean
            Get
                Return _Activity_bit
            End Get
            Set(ByVal value As Boolean)
                Me._Activity_bit = value
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

        Public Property Permissions() As List(Of BLL.BLLPermission_T)
            Get
                Return Me._Permissions
            End Get
            Set(ByVal value As List(Of BLL.BLLPermission_T))
                Me._Permissions = value
            End Set
        End Property

        Friend Overloads Overrides Sub AddValidationRules()
            ValidationRules.AddRules(New Validation.NotNullRule("UserName_nvc", "شناسه کاربری"))
            ValidationRules.AddRules(New Validation.StringMaxLengthRule("UserName_nvc", "شناسه کاربری", 100))
            ValidationRules.AddRules(New Validation.NotNullRule("FullName_nvc", "نام و نام خانوادگی کاربر"))
            ValidationRules.AddRules(New Validation.StringMaxLengthRule("FullName_nvc", "نام و نام خانوادگی کاربر", 100))

            Dim PasswordEqualValidation As New Validation.LogicalOperationRule("PasswordEqualValidation")
            PasswordEqualValidation.AddItem("Password_nvc", Validation.LogicalOperationRule.enumLogicOperator.Equal, "ConfirmPassword_nvc", "گذر واژه", "تکرار گذر واژه", True)
            ValidationRules.AddRules(PasswordEqualValidation)

            ValidationRules.AddRules(New Validation.NotNullRule("Password_nvc", "گذر واژه"))
            ValidationRules.AddRules(New Validation.StringMaxLengthRule("Password_nvc", "گذر واژه", 100))
            ValidationRules.AddRules(New Validation.DateRule(Of String)("StartDate_vc", "تاریخ شروع اعتبار", Nothing, Nothing))
            ValidationRules.AddRules(New Validation.DateRule(Of String)("ExpireDate_vc", "تاریخ انقضای اعتبار", Nothing, Nothing))

            Dim DateLogicValidation As New Validation.LogicalOperationRule("DateLogicValidation")
            DateLogicValidation.AddItem("StartDate_vc", Validation.LogicalOperationRule.enumLogicOperator.LessOrEqual, "ExpireDate_vc", "تاریخ شروع اعتبار", "تاریخ انقضای اعتبار", False)
            ValidationRules.AddRules(DateLogicValidation)

            ValidationRules.AddRules(New Validation.RelationRule("RelationExtraFieldTemplateID_bint", "اطلاعات شناور", "ExtraFieldTemplate_T", "ExtraFieldTemplateID_bint"))
            ValidationRules.AddRules(New Validation.UniqueRule("UniqueUserName_nvc", "شناسه کاربری", "User_T", "UserName_nvc"))
        End Sub

    End Class
End Namespace