Namespace Validation

    Public Class UniqueRule
        Inherits BaseRule

        Private _Table As String = String.Empty
        Private _ReturnTrueWhenNullValue As Boolean = True

        Public Sub New(ByVal PropertyName As String, ByVal FriendlyName As String, ByVal Table As String, ByVal ParamArray Field() As String)
            MyBase.New(PropertyName, FriendlyName)
            Me.Field = Field
            Me._Table = Table
        End Sub

        Public Sub New(ByVal PropertyName As String, ByVal FriendlyName As String, ByVal ReturnTrueWhenNullValue As Boolean, ByVal Table As String, ByVal ParamArray Field() As String)
            MyBase.New(PropertyName, FriendlyName)
            Me.Field = Field
            Me._Table = Table
            Me._ReturnTrueWhenNullValue = ReturnTrueWhenNullValue
        End Sub

        Public Sub New(ByVal PropertyName As String, ByVal ReturnTrueWhenNullValue As Boolean, ByVal Table As String, ByVal ParamArray Field() As String)
            Me.New(PropertyName, PropertyName, ReturnTrueWhenNullValue, Table, Field)
        End Sub

        Public Sub New(ByVal PropertyName As String, ByVal Table As String, ByVal ParamArray Field() As String)
            Me.New(PropertyName, PropertyName, Table, Field)
        End Sub

        Public Overrides Function Validate(ByVal ParamArray Value() As Object) As Boolean
            Try
                If Value.Count <> Field.Count Then
                    Me.Description = My.Resources.ValidationMessage.IncorrectDataType
                    Return False
                End If
                If Value.Count = 0 Then
                    Me.Description = String.Empty
                    Return True
                End If
                If Me._ReturnTrueWhenNullValue Then
                    For index As Integer = 0 To Value.Count - 1
                        If Value(index) Is Nothing Then
                            Me.Description = String.Empty
                            Return True
                        End If
                    Next
                End If

                Dim Condition As String = String.Empty
                Dim AppInfo As New Common.ApplicationInfo(_Table)
                For index As Integer = 0 To Value.Count - 1
                    If Value(index) Is Nothing Then
                        Condition += AppInfo.TableName + ".[" + Me.Field(index).ToString + "] IS NULL " + " And "
                    Else
                        Condition += AppInfo.TableName + ".[" + Me.Field(index).ToString + "] = N'" + Common.PersentationController.CorrectLike(Value(index).ToString) + "' And "
                    End If
                Next
                If Condition.EndsWith(" And ") Then
                    Condition = Condition.Substring(0, Condition.Length - 5)
                End If

                Dim obj As Object = Nothing
                If Type.GetType(AppInfo.BusinessLogicLayer) IsNot Nothing Then
                    obj = Activator.CreateInstance(Type.GetType(AppInfo.BusinessLogicLayer))
                Else
                    obj = System.Reflection.Assembly.GetEntryAssembly.CreateInstance(AppInfo.BusinessLogicLayer)
                End If
                If obj.GetAllByCondition(Condition).Count = 0 Then
                    Me.Description = String.Empty
                    Return True
                Else
                    Me.Description = String.Format(My.Resources.ValidationMessage.ValueAlreadyExists, FriendlyName)
                    Return False
                End If
            Catch ex As System.Exception
                Me.Description = ex.Message
                Return False
            End Try
        End Function

    End Class

End Namespace