Imports System
Imports System.Collections.Generic
Imports System.Text

Namespace BLL

    Public Class BLLCategory_TKeys

        Private _CategoryID_bint As Int64


        Public Property CategoryID_bint() As Int64
            Get
                Return _CategoryID_bint
            End Get
            Set(ByVal value As Int64)
                Me._CategoryID_bint = value
            End Set
        End Property


    End Class
End Namespace