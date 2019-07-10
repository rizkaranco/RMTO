Namespace Validation

    Public Class NotNullRule
        Inherits BaseRule

        Public Sub New(ByVal PropertyName As String, ByVal FriendlyName As String)
            MyBase.New(PropertyName, FriendlyName)
        End Sub

        Public Sub New(ByVal PropertyName As String)
            Me.New(PropertyName, PropertyName)
        End Sub

        Public Overrides Function Validate(ByVal Value As Object) As Boolean
            Try
                If TypeOf Value Is Byte() Then
                    If Value IsNot Nothing AndAlso Value.length > 0 Then
                        Me.Description = String.Empty
                        Return True
                    Else
                        Me.Description = String.Format(My.Resources.ValidationMessage.DataIsEmpty, Me.FriendlyName)
                        Return False
                    End If
                Else
                    If String.IsNullOrEmpty(Value) Then
                        Me.Description = String.Format(My.Resources.ValidationMessage.DataIsEmpty, Me.FriendlyName)
                        Return False
                    Else
                        Me.Description = String.Empty
                        Return True
                    End If
                End If
            Catch ex As System.Exception
                Me.Description = String.Format(My.Resources.ValidationMessage.IncorrectDataType, Me.FriendlyName)
                Return False
            End Try
        End Function

    End Class

End Namespace