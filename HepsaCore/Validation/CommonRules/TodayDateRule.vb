Namespace Validation
    Public Class TodayDateRule
        Inherits BaseRule

        Public Sub New(ByVal PropertyName As String, ByVal FriendlyName As String)
            MyBase.New(PropertyName, FriendlyName)
        End Sub

        Public Overrides Function Validate(ByVal Value As Object) As Boolean
            Dim SystemFactory As New Hepsa.Core.BLL.BLLSystem_TFactory
            Try
                Me.Description = String.Empty
                If String.IsNullOrEmpty(Value) Then
                    Return True
                End If
                If Value < SystemFactory.ServerJalaliDate Then
                    Me.Description = String.Format(My.Resources.ValidationMessage.ValueShouldNotLess, Me.FriendlyName, SystemFactory.ServerJalaliDate)
                    Return False
                End If
                Return True
            Catch ex As System.Exception
                Me.Description = ex.Message
                Return False
            End Try
        End Function
    End Class
End Namespace
