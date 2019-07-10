Namespace Validation

    Public Class StringMaxLengthRule
        Inherits BaseRule

        Private _Length As Integer = 50

        Public Sub New(ByVal PropertyName As String, ByVal FriendlyName As String, ByVal Length As Integer)
            MyBase.New(PropertyName, FriendlyName)
            Me._Length = Length
        End Sub

        Public Sub New(ByVal PropertyName As String, ByVal Length As Integer)
            Me.New(PropertyName, PropertyName, Length)
        End Sub

        Public ReadOnly Property Length() As Integer
            Get
                Return _Length
            End Get
        End Property

        Public Overrides Function Validate(ByVal Value As Object) As Boolean
            Try
                If String.IsNullOrEmpty(Value) Then
                    Return True
                End If

                If Value.ToString.Length > Me.Length Then
                    Me.Description = String.Format(My.Resources.ValidationMessage.ValueMaxLen, Me.FriendlyName, Me.Length.ToString)
                    Return False
                Else
                    Me.Description = String.Empty
                    Return True
                End If
            Catch ex As System.Exception
                Me.Description = String.Format(My.Resources.ValidationMessage.IncorrectDataType, Me.FriendlyName)
                Return False
            End Try
        End Function

    End Class

End Namespace