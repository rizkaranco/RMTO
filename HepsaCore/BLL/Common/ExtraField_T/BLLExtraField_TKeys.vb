Imports System
Imports System.Collections.Generic
Imports System.Text

Namespace BLL

    Public Class BLLExtraField_TKeys

        Private _ExtraFieldID_bint As Int64


        Public Property ExtraFieldID_bint() As Int64
            Get
                Return _ExtraFieldID_bint
            End Get
            Set(ByVal value As Int64)
                Me._ExtraFieldID_bint = value
            End Set
        End Property


    End Class
End Namespace