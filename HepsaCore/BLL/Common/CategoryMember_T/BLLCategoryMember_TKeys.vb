Imports System
Imports System.Collections.Generic
Imports System.Text

Namespace BLL

    Public Class BLLCategoryMember_TKeys

        Private _CategotyMemberID_bint As Int64


        Public Property CategotyMemberID_bint() As Int64
            Get
                Return _CategotyMemberID_bint
            End Get
            Set(ByVal value As Int64)
                Me._CategotyMemberID_bint = value
            End Set
        End Property


    End Class
End Namespace