Imports System
Imports System.Collections.Generic
Imports System.Text

Namespace Validation

    Public Class BrokenRule

        Private _RuleName As String = String.Empty
        Private _Description As String = String.Empty
        Private _PropertyName As String = String.Empty

        Public Sub New(ByVal Rule As BaseRule)
            _RuleName = Rule.RuleName
            _Description = Rule.Description
            _PropertyName = Rule.PropertyName
        End Sub

        Public ReadOnly Property RuleName() As String
            Get
                Return _RuleName
            End Get
        End Property

        Public ReadOnly Property Description() As String
            Get
                Return _Description
            End Get
        End Property

        Public ReadOnly Property PropertyName() As String
            Get
                Return _PropertyName
            End Get
        End Property

    End Class

End Namespace