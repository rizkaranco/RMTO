Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Reflection

Namespace BLL

    Public MustInherit Class BusinessObjectBase
        Private _ValidationRules As Validation.ValidationRules = Nothing

        Friend ReadOnly Property ValidationRules() As Validation.ValidationRules
            Get
                If _ValidationRules Is Nothing Then
                    _ValidationRules = New Validation.ValidationRules(Me)
                    AddValidationRules()
                End If
                Return _ValidationRules
            End Get
        End Property

        Public ReadOnly Property IsValid() As Boolean
            Get
                Me.CorrectCodePage()
                Return Me.ValidationRules.IsValid
            End Get
        End Property

        Public ReadOnly Property IsValid(ByVal ExceptType As Validation.ValidationExceptionType, ByVal ParamArray Except() As String) As Boolean
            Get
                Me.CorrectCodePage()
                Return Me.ValidationRules.IsValid(ExceptType, Except)
            End Get
        End Property

        Public ReadOnly Property BrokenRulesList() As Validation.BrokenRulesList
            Get
                Return ValidationRules.BrokenRules
            End Get
        End Property

        Public Sub CorrectCodePage()
            'Dim MyType As Type = Me.GetType
            'Dim MyPropertyInfo() As PropertyInfo = MyType.GetProperties
            'For index As Integer = 0 To MyPropertyInfo.Count - 1
            '    If MyPropertyInfo(index).CanRead AndAlso MyPropertyInfo(index).CanWrite AndAlso MyPropertyInfo(index).GetValue(Me, Nothing) IsNot Nothing AndAlso MyPropertyInfo(index).PropertyType Is GetType(System.String) Then
            '        Dim Value As String = DirectCast(MyPropertyInfo(index).GetValue(Me, Nothing), String).Trim
            '        MyPropertyInfo(index).SetValue(Me, Value, Nothing)
            '    End If
            'Next
        End Sub

        Friend Overridable Sub AddValidationRules()
        End Sub

        Public Function GetXML() As String
            Dim XmlStr As String = String.Empty
            Try
                Return Me.MakeContentXML(Me)
            Catch ex As System.Exception
                Throw ex
            End Try
        End Function

        Private Function MakeContentXML(ByVal obj As Object) As String
            Dim str As String = String.Empty
            Try
                Dim pInfo() As PropertyInfo = obj.GetType.GetProperties(BindingFlags.Instance Or BindingFlags.Public Or BindingFlags.DeclaredOnly)
                If pInfo IsNot Nothing AndAlso pInfo.Length > 0 Then
                    For Each p As PropertyInfo In pInfo
                        If (TypeOf (p.PropertyType.BaseType) Is System.Object AndAlso p.CanRead = True AndAlso p.CanWrite = True) OrElse (p.PropertyType.BaseType.IsClass = True AndAlso p.CanRead = True) Then
                            If p.PropertyType.BaseType.Name.Contains("List") Then
                                Dim ItemCount As Integer = p.GetValue(obj, Nothing).GetType.GetProperty("Count").GetValue(p.GetValue(obj, Nothing), Nothing)
                                For index As Integer = 0 To ItemCount - 1
                                    For Each c As PropertyInfo In p.GetValue(obj, Nothing).GetType.GetProperties(BindingFlags.Instance Or BindingFlags.Public Or BindingFlags.DeclaredOnly)
                                        If c.Name = "Item" Then
                                            str = String.Format("{0}<{1}>{2}</{1}>", str, p.Name, Me.MakeContentXML(c.GetValue(p.GetValue(obj, Nothing), New Object() {index})))
                                            Exit For
                                        End If
                                    Next
                                Next
                            ElseIf TypeOf (p.GetValue(obj, Nothing)) Is BLL.BusinessObjectBase Then
                                str = String.Format("{0}<{1}>{2}</{1}>", str, p.Name, DirectCast(p.GetValue(obj, Nothing), BLL.BusinessObjectBase).GetXML)
                            Else
                                str = String.Format("{0}<{1}>{2}</{1}>", str, p.Name, p.GetValue(obj, Nothing).ToString)
                            End If
                        End If
                    Next
                End If
                Return String.Format("<{0}>{1}</{0}>", obj.GetType.Name, str)
            Catch ex As System.Exception
                Throw ex
            End Try
        End Function

    End Class

End Namespace