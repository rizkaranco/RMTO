Imports System
Imports System.Collections.Generic
Imports System.Text

Namespace BLL

    Public Class BLLPermissionGroup_T
        Inherits BLL.BusinessObjectBase

        Public Enum PermissionGroup_TField
            PermissionGroupID_bint
            PermissionGroup_nvc
            SystemID_tint
        End Enum


        Private _PermissionGroupID_bint As Int64
        Private _PermissionGroup_nvc As String
        Private _SystemID_tint As Nullable(Of Byte)


        Public Property PermissionGroupID_bint() As Int64
            Get
                Return _PermissionGroupID_bint
            End Get
            Set(ByVal value As Int64)
                Me._PermissionGroupID_bint = value
            End Set
        End Property

        Public Property PermissionGroup_nvc() As String
            Get
                Return _PermissionGroup_nvc
            End Get
            Set(ByVal value As String)
                Me._PermissionGroup_nvc = value
            End Set
        End Property

        Public Property SystemID_tint() As Nullable(Of Byte)
            Get
                Return _SystemID_tint
            End Get
            Set(ByVal value As Nullable(Of Byte))
                Me._SystemID_tint = value
            End Set
        End Property

        Friend Overloads Overrides Sub AddValidationRules()
            ValidationRules.AddRules(New Validation.NotNullRule("PermissionGroupID_bint", "کد گروه مجوز"))
            ValidationRules.AddRules(New Validation.NumericRule(Of Int64)("PermissionGroupID_bint", "کد گروه مجوز", 1, Nothing, 4, 0))
            ValidationRules.AddRules(New Validation.NotNullRule("PermissionGroup_nvc", "عنوان گروه مجوز"))
            ValidationRules.AddRules(New Validation.StringMaxLengthRule("PermissionGroup_nvc", "عنوان گروه مجوز", 100))
            ValidationRules.AddRules(New Validation.RelationRule("RelationSystemID_tint", "سیستم", "System_T", "SystemID_tint"))
            ValidationRules.AddRules(New Validation.UniqueRule("UniquePermissionGroupID_bint", "کد گروه مجوز", "PermissionGroup_T", "GroupID_bint"))
            ValidationRules.AddRules(New Validation.UniqueRule("UniquePermissionGroup_nvc", "عنوان گروه مجوز", "PermissionGroup_T", "PermissionGroup_nvc"))
        End Sub

    End Class
End Namespace