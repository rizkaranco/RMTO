Imports System
Imports System.Collections.Generic
Imports System.Text
Imports System.Reflection

Namespace Validation

    Public Enum ValidationExceptionType As Byte
        Except = 1
        Validate = 2
    End Enum

    Public Class ValidationRules

        Private _BrokenRulesList As BrokenRulesList = Nothing
        Private _ValidationRulesList As Dictionary(Of String, List(Of BaseRule)) = Nothing
        Private _ParentObject As Object = Nothing

        Public Sub New(ByVal ParentObject As Object)
            _ParentObject = ParentObject
        End Sub

        Public ReadOnly Property ValidationRulesList() As Dictionary(Of String, List(Of BaseRule))
            Get
                If _ValidationRulesList Is Nothing Then
                    _ValidationRulesList = New Dictionary(Of String, List(Of BaseRule))()
                End If
                Return _ValidationRulesList
            End Get
        End Property

        Public Function BrokenRules() As BrokenRulesList

            If _BrokenRulesList Is Nothing Then
                _BrokenRulesList = New BrokenRulesList()
            End If
            Return _BrokenRulesList

        End Function

        Public Function IsValid() As Boolean

            BrokenRules.Clear()
            ValidateRules()
            Return (BrokenRules.Count = 0)

        End Function

        Public Function IsValid(ByVal ExceptionType As ValidationExceptionType, ByVal ParamArray Except() As String) As Boolean

            BrokenRules.Clear()
            ValidateRules(ExceptionType, Except)
            Return (BrokenRules.Count = 0)

        End Function

        Public Sub ValidateRules()
            For Each key As String In ValidationRulesList.Keys
                ValidateRules(key)
            Next
        End Sub

        Public Sub ValidateRules(ByVal ExceptionType As ValidationExceptionType, ByVal ParamArray Except() As String)
            For Each key As String In ValidationRulesList.Keys
                If ExceptionType = ValidationExceptionType.Except Then
                    If Except.Contains(key) = False Then
                        ValidateRules(key)
                    End If
                Else
                    If Except.Contains(key) = True Then
                        ValidateRules(key)
                    End If
                End If
            Next
        End Sub

        Public Sub ValidateRules(ByVal PropertyName As String)
            If ValidationRulesList.ContainsKey(PropertyName) Then
                Dim Rules As List(Of BaseRule) = ValidationRulesList(PropertyName)
                If Rules IsNot Nothing Then
                    ValidateRulesList(Rules)
                End If
            End If
        End Sub

        Private Sub ValidateRulesList(ByVal list As List(Of BaseRule))
            For Each Rule As BaseRule In list
                If Rule.Field IsNot Nothing Then
                    Dim PropertyList() As String = Rule.Field
                    Dim Value(PropertyList.Length - 1) As Object

                    For index As Integer = 0 To PropertyList.Length - 1
                        Value(index) = GetPropertyValue(PropertyList(index))
                    Next

                    If Rule.Validate(Value) Then
                        BrokenRules.Remove(Rule)
                    Else
                        BrokenRules.Add(Rule)
                    End If
                Else
                    Dim Value As Object
                    Value = GetPropertyValue(Rule.PropertyName)
                    If Rule.Validate(Value) Then
                        BrokenRules.Remove(Rule)
                    Else
                        BrokenRules.Add(Rule)
                    End If
                End If
            Next
        End Sub

        Private Function GetPropertyValue(ByVal PropertyName As String) As Object
            Dim PropertyPath() As String = PropertyName.Split(".")
            Dim obj As Object
            Dim info As PropertyInfo
            Dim Value As Object
            For index As Integer = 0 To PropertyPath.Count - 1
                If index = 0 Then
                    info = _ParentObject.GetType.GetProperty(PropertyPath(index), BindingFlags.Instance Or BindingFlags.Public Or BindingFlags.DeclaredOnly)
                Else
                    info = obj.GetType.GetProperty(PropertyPath(index), BindingFlags.Instance Or BindingFlags.Public Or BindingFlags.DeclaredOnly)
                End If
                If info Is Nothing Then
                    If index = 0 Then
                        info = _ParentObject.GetType.GetProperty(PropertyPath(index))
                    Else
                        info = obj.GetType.GetProperty(PropertyPath(index))
                    End If
                End If
                If info Is Nothing Then
                    Return Nothing
                End If
                If PropertyPath.Count - 1 = 0 Then
                    Value = info.GetValue(_ParentObject, Nothing)
                    If Convert.GetTypeCode(Value) = System.TypeCode.Object Then
                        Return Value
                    Else
                        Return Convert.ChangeType(Value, Convert.GetTypeCode(Value))
                    End If
                ElseIf index < PropertyPath.Count - 1 Then
                    If obj IsNot Nothing Then
                        obj = info.GetValue(obj, Nothing)
                    Else
                        obj = info.GetValue(_ParentObject, Nothing)
                    End If
                    If obj Is Nothing Then
                        Return Nothing
                    End If
                ElseIf PropertyPath.Count - 1 = index Then
                    Value = info.GetValue(obj, Nothing)
                    If Convert.GetTypeCode(Value) = TypeCode.Empty OrElse Convert.GetTypeCode(Value) = TypeCode.Object Then
                        Return Value
                    Else
                        Return Convert.ChangeType(Value, Convert.GetTypeCode(Value))
                    End If
                End If
            Next
        End Function

        Private Function GetPropertyRules(ByVal PropertyName As String) As List(Of BaseRule)
            Dim list As List(Of BaseRule) = Nothing

            If ValidationRulesList.ContainsKey(PropertyName) Then
                list = ValidationRulesList(PropertyName)
            Else
                list = New List(Of BaseRule)
                ValidationRulesList.Add(PropertyName, list)
            End If

            Return list
        End Function

        Public Sub AddRules(ByVal ValidationRule As BaseRule)
            Dim RuleList As List(Of BaseRule) = GetPropertyRules(ValidationRule.PropertyName)
            RuleList.Add(ValidationRule)
        End Sub

    End Class

End Namespace