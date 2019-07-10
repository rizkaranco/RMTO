Imports System
Imports System.Collections.Generic
Imports System.Text

Namespace BLL

    Public Class BLLSystem_T
        Inherits Hepsa.Core.BLL.BusinessObjectBase

        Public Enum System_TField
            SystemID_int
            System_nvc
            Image
        End Enum

        Public Enum Systems As Byte
            Accounting = 1
            WareHouse = 2
            Sale = 3
            Administration = 4
            Civil = 5
        End Enum

        Private _SystemID_int As Byte
        Private _System_nvc As String
        Private _Image() As Byte

        Public Property SystemID_int() As Int32
            Get
                Return _SystemID_int
            End Get
            Set(ByVal value As Int32)
                Me._SystemID_int = value
            End Set
        End Property

        Public Property System_nvc() As String
            Get
                Return _System_nvc
            End Get
            Set(ByVal value As String)
                Me._System_nvc = value
            End Set
        End Property

        Public Property Image() As Byte()
            Get
                Return _Image
            End Get
            Set(ByVal value As Byte())
                _Image = value
            End Set
        End Property



        Friend Overloads Overrides Sub AddValidationRules()
            ValidationRules.AddRules(New Hepsa.Core.Validation.NotNullRule("System_nvc", "عنوان سیستم"))
            ValidationRules.AddRules(New Hepsa.Core.Validation.StringMaxLengthRule("System_nvc", "عنوان سیستم", 100))
            ValidationRules.AddRules(New Hepsa.Core.Validation.UniqueRule("UniqueSystem_nvc", "عنوان سیستم", "System_T", "System_nvc"))
            ValidationRules.AddRules(New Hepsa.Core.Validation.NotNullRule("Image", "آیکن سیستم"))
        End Sub

    End Class
End Namespace