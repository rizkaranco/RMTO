Imports System.Text.RegularExpressions

Namespace Validation

    Public Class RegularExpressionRule
        Inherits BaseRule

        Private _Pattern As String = String.Empty

        Public Sub New(ByVal PropertyName As String, ByVal FriendlyName As String, ByVal Pattern As String)
            MyBase.New(PropertyName, FriendlyName)
            Me._Pattern = Pattern
        End Sub

        Public Sub New(ByVal PropertyName As String, ByVal Pattern As String)
            Me.New(PropertyName, PropertyName, Pattern)
        End Sub

        Public ReadOnly Property Pattern() As String
            Get
                Return Me._Pattern
            End Get
        End Property

        Public Overrides Function Validate(ByVal Value As Object) As Boolean
            Try
                If String.IsNullOrEmpty(Value) Then
                    Return True
                End If

                If Regex.IsMatch(Value.ToString, Pattern) = False Then
                    Me.Description = String.Format(My.Resources.ValidationMessage.DataNotValid, Me.FriendlyName)
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