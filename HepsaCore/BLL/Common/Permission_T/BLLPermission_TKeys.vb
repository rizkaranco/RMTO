Imports System
Imports System.Collections.Generic
Imports System.Text

Namespace BLL

    Public Class BLLPermission_TKeys

        Private _PermissionID_bint As Int64


        Public Property PermissionID_bint() As Int64
            Get
                Return _PermissionID_bint
            End Get
            Set(ByVal value As Int64)
                Me._PermissionID_bint = Value
            End Set
        End Property


    End Class
End Namespace