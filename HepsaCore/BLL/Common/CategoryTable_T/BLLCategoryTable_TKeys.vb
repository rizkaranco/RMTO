Imports System
Imports System.Collections.Generic
Imports System.Text

Namespace BLL

    Public Class BLLCategoryTable_TKeys

        Private _CategoryTableID_bint As Int64


        Public Property CategoryTableID_bint() As Int64
            Get
                Return _CategoryTableID_bint
            End Get
            Set(ByVal value As Int64)
                Me._CategoryTableID_bint = value
            End Set
        End Property


    End Class
End Namespace