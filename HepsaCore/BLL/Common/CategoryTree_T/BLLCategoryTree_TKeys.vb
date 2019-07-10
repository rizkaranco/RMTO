Imports System
Imports System.Collections.Generic
Imports System.Text

Namespace BLL

    Public Class BLLCategoryTree_TKeys

        Private _CategoryTreeID_bint As Int64


        Public Property CategoryTreeID_bint() As Int64
            Get
                Return _CategoryTreeID_bint
            End Get
            Set(ByVal value As Int64)
                Me._CategoryTreeID_bint = value
            End Set
        End Property


    End Class
End Namespace