Imports System
Imports System.Collections.Generic
Imports System.Text
Namespace BLL

    Public Class BLLLog_TKeys


        Private _LogID_bint As Int64
        Public Property LogID_bint() As Int64
            Get
                Return _LogID_bint
            End Get
            Set(ByVal value As Int64)
                Me._LogID_bint = Value
            End Set
        End Property


    End Class
End Namespace
