Imports System
Imports System.Collections.Generic
Imports System.Text
Namespace BLL

    Public Class BLLAction_TKeys


        Private _ActionID_int As Int32
        Public Property ActionID_int() As Int32
            Get
                Return _ActionID_int
            End Get
            Set(ByVal value As Int32)
                Me._ActionID_int = value
            End Set
        End Property


    End Class
End Namespace
