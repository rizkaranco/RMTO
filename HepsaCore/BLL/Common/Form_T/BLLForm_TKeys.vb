Imports System
Imports System.Collections.Generic
Imports System.Text
Namespace BLL

    Public Class BLLForm_TKeys


        Private _FormID_int As Int32
        Public Property FormID_int() As Int32
            Get
                Return _FormID_int
            End Get
            Set(ByVal value As Int32)
                Me._FormID_int = value
            End Set
        End Property


    End Class
End Namespace
