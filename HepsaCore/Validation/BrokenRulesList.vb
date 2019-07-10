Imports System
Imports System.Collections.Generic
Imports System.Text

Namespace Validation

    Public Class BrokenRulesList
        Inherits List(Of BrokenRule)

        Public Sub Add(ByVal Rule As BaseRule)
            Remove(Rule)
            MyBase.Add(New BrokenRule(Rule))
        End Sub

        Friend Sub Remove(ByVal Rule As BaseRule)
            For i As Integer = MyBase.Count - 1 To 0 Step -1
                If MyBase.Item(i).RuleName = Rule.RuleName Then
                    MyBase.RemoveAt(i)
                    Exit For
                End If
            Next
        End Sub

        Public Function GetBrokenRulesDescription() As String
            Return GetBrokenRulesDescription(Nothing)
        End Function

        Public Function GetBrokenRulesDescription(ByVal PropertyName As String) As String
            Dim res As New StringBuilder()
            For Each br As BrokenRule In Me
                If String.IsNullOrEmpty(PropertyName) OrElse br.PropertyName = PropertyName Then
                    If String.IsNullOrEmpty(br.Description) = False Then
                        If res.Length > 0 Then
                            res.Append(Environment.NewLine)
                        End If
                        res.Append(br.Description)
                    End If
                End If
            Next
            Return res.ToString()
        End Function

        Public Overloads Overrides Function ToString() As String
            Return GetBrokenRulesDescription()
        End Function

    End Class

End Namespace