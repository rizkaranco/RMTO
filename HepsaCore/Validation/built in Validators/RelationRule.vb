Namespace Validation

    Public Class RelationRule
        Inherits BaseRule

        Private _Table As String = String.Empty
        Private _DataBaseFieldName() As String

        Public Sub New(ByVal PropertyName As String, ByVal FriendlyName As String, ByVal Table As String, ByVal ParamArray Field() As String)
            MyBase.New(PropertyName, FriendlyName)

            For index As Integer = 0 To Field.Count - 1
                ReDim Preserve Me.Field(index)
                ReDim Preserve _DataBaseFieldName(index)
                Dim tmp() As String = Field(index).Split(",")
                If tmp.Count = 1 Then
                    _DataBaseFieldName(index) = tmp(0)
                    Me.Field(index) = tmp(0)
                ElseIf tmp.Count > 1 Then
                    _DataBaseFieldName(index) = tmp(1)
                    Me.Field(index) = tmp(0)
                End If
            Next

            Me._Table = Table
        End Sub

        Public Sub New(ByVal PropertyName As String, ByVal Table As String, ByVal ParamArray Field() As String)
            Me.New(PropertyName, PropertyName, Table, Field)
        End Sub

        Public ReadOnly Property Table() As String
            Get
                Return Me._Table
            End Get
        End Property

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
                For index As Integer = 0 To Value.Count - 1
                    If Value(index) Is Nothing OrElse String.IsNullOrEmpty(Value(index)) = True Then
                        Me.Description = String.Empty
                        Return True
                    End If
                Next

                Dim Condition As String = String.Empty
                Dim AppInfo As New Common.ApplicationInfo(Table)
                For index As Integer = 0 To Value.Count - 1
                    Condition += AppInfo.TableName + ".[" + Me._DataBaseFieldName(index).ToString + "] = N'" + Common.PersentationController.CorrectLike(Value(index).ToString) + "' And "
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
                If obj.GetAllByCondition(Condition).Count > 0 Then
                    Me.Description = String.Empty
                    Return True
                Else
                    Me.Description = String.Format(My.Resources.ValidationMessage.RelationError, FriendlyName)
                    Return False
                End If
            Catch ex As System.Exception
                Me.Description = ex.Message
                Return False
            End Try
        End Function

    End Class

End Namespace