Imports System
Imports System.Collections.Generic
Imports System.Text

Namespace BLL

    Public Class BLLSystem_TKeys

        Private _SystemID_tint As Byte


        Public Property SystemID_tint() As Byte
            Get
                Return _SystemID_tint
            End Get
            Set(ByVal value As Byte)
                Me._SystemID_tint = value
            End Set
        End Property


    End Class
End Namespace