Imports System
Imports System.Collections.Generic
Imports System.Text

Namespace BLL

    Public Class BLLUser_TKeys

        Private _UserName_nvc As String


        Public Property UserName_nvc() As String
            Get
                Return _UserName_nvc
            End Get
            Set(ByVal value As String)
                Me._UserName_nvc = value
            End Set
        End Property

    End Class

End Namespace