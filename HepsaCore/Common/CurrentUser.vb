Namespace Common

    Public Class CurrentUser

        Private Shared _User As BLL.BLLUser_T

        Public Shared Property User() As BLL.BLLUser_T
            Get
                Return _User
            End Get
            Set(ByVal value As BLL.BLLUser_T)
                _User = value
            End Set
        End Property

    End Class

End Namespace

