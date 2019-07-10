Imports System
Imports System.Collections.Generic
Imports System.Text

Namespace BLL

    Public Class BLLPermissionGroup_TKeys

        Private _PermissionGroupID_bint As Int64

        Public Property PermissionGroupID_bint() As Int64
            Get
                Return _PermissionGroupID_bint
            End Get
            Set(ByVal value As Int64)
                Me._PermissionGroupID_bint = value
            End Set
        End Property

    End Class

End Namespace