Imports System
Imports System.Collections.Generic
Imports System.Text

Namespace BLL

    Public Class BLLUserLogin_T
        Inherits BLL.BusinessObjectBase

        Public Enum User_TField
            UserName_nvc
            Password_nvc
        End Enum

        Private _UserName_nvc As String
        Private _Password_nvc As String

        Public Property UserName_nvc() As String
            Get
                Return _UserName_nvc
            End Get
            Set(ByVal value As String)
                Me._UserName_nvc = value
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

        Friend Overloads Overrides Sub AddValidationRules()
            ValidationRules.AddRules(New Validation.NotNullRule("UserName_nvc", "شناسه کاربری"))
            ValidationRules.AddRules(New Validation.StringMaxLengthRule("UserName_nvc", "شناسه کاربری", 100))
            ValidationRules.AddRules(New Validation.NotNullRule("Password_nvc", "گذر واژه"))
            ValidationRules.AddRules(New Validation.StringMaxLengthRule("Password_nvc", "گذر واژه", 300))
        End Sub

    End Class
End Namespace
