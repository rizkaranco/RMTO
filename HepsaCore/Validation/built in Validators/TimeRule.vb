Namespace Validation

    Public Class TimeRule(Of T)
        Inherits BaseRule

        Private _MinValue As T
        Private _MaxValue As T

        Public Sub New(ByVal PropertyName As String, ByVal FriendlyName As String, ByVal MinValue As T, ByVal MaxValue As T)
            MyBase.New(PropertyName, FriendlyName)
            Me._MinValue = MinValue
            Me._MaxValue = MaxValue
        End Sub

        Public Sub New(ByVal PropertyName As String, ByVal MinValue As T, ByVal MaxValue As T)
            Me.New(PropertyName, PropertyName, MinValue, MaxValue)
        End Sub

        Public ReadOnly Property MinValue() As T
            Get
                Return Me._MinValue
            End Get
        End Property

        Public ReadOnly Property MaxValue() As T
            Get
                Return Me._MaxValue
            End Get
        End Property

        Public Overrides Function Validate(ByVal Value As Object) As Boolean
            Try
                If String.IsNullOrEmpty(Value) Then
                    Return True
                End If
                If GetType(T) Is GetType(String) Then
                    ValidateString(Value.ToString)
                ElseIf GetType(T) Is GetType(Date) OrElse GetType(T) Is GetType(Nullable(Of Date)) Then
                    ValidateDateTime(Convert.ToDateTime(Value))
                Else
                    Throw New System.Exception(String.Format(My.Resources.ValidationMessage.IncorrectDataType, FriendlyName))
                End If
                Me.Description = String.Empty
                Return True
            Catch ex As FormatException
                Me.Description = String.Format(My.Resources.ValidationMessage.IncorrectDataType, FriendlyName)
                Return False
            Catch ex As System.Exception
                Me.Description = ex.Message
                Return False
            End Try
        End Function

        Private Sub ValidateString(ByVal Value As String)
            Try
                If String.IsNullOrEmpty(Value) = False Then
                    Dim SplitTime() As String = Value.Split(System.Globalization.CultureInfo.CurrentUICulture.DateTimeFormat.TimeSeparator)

                    If SplitTime.Length < 2 Then
                        Throw New System.Exception(String.Format(My.Resources.ValidationMessage.DataNotValid, FriendlyName))
                    End If
                    For Each Str As String In SplitTime
                        If IsNumeric(Str) = False OrElse Str.Length <> 2 Then
                            Throw New System.Exception(String.Format(My.Resources.ValidationMessage.DataNotValid, FriendlyName))
                        End If
                    Next

                    If Not (Convert.ToInt32(SplitTime(0)) >= 0 AndAlso Convert.ToInt32(SplitTime(0)) <= 23) Then
                        Throw New System.Exception(String.Format(My.Resources.ValidationMessage.DataNotValid, FriendlyName))
                    End If

                    If Not (Convert.ToInt32(SplitTime(1)) >= 0 AndAlso Convert.ToInt32(SplitTime(1)) <= 59) Then
                        Throw New System.Exception(String.Format(My.Resources.ValidationMessage.DataNotValid, FriendlyName))
                    End If
                    If SplitTime.Length > 2 Then
                        If Not (Convert.ToInt32(SplitTime(2)) >= 0 AndAlso Convert.ToInt32(SplitTime(2)) <= 59) Then
                            Throw New System.Exception(String.Format(My.Resources.ValidationMessage.DataNotValid, FriendlyName))
                        End If
                    End If

                    If MinValue IsNot Nothing AndAlso String.IsNullOrEmpty(MinValue.ToString) = False AndAlso Value < MinValue.ToString Then
                        Throw New System.Exception(String.Format(My.Resources.ValidationMessage.ValueShouldNotLess, FriendlyName, Me.MinValue.ToString))
                    End If

                    If MaxValue IsNot Nothing AndAlso String.IsNullOrEmpty(MaxValue.ToString) = False AndAlso Value > MaxValue.ToString Then
                        Throw New System.Exception(String.Format(My.Resources.ValidationMessage.ValueShouldNotGreater, FriendlyName, Me.MaxValue.ToString))
                    End If
                End If
            Catch ex As System.Exception
                Throw ex
            End Try
        End Sub

        Private Sub ValidateDateTime(ByVal value As DateTime)
            Try
                If value <> Nothing AndAlso MinValue IsNot Nothing AndAlso value < MinValue.ToString Then
                    Throw New System.Exception(String.Format(My.Resources.ValidationMessage.ValueShouldNotLess, FriendlyName, Convert.ToDateTime(MinValue).ToLongDateString.ToString))
                End If

                If value <> Nothing AndAlso MaxValue IsNot Nothing AndAlso value > MaxValue.ToString Then
                    Throw New System.Exception(String.Format(My.Resources.ValidationMessage.ValueShouldNotGreater, FriendlyName, Convert.ToDateTime(MaxValue).ToLongDateString.ToString))
                End If
            Catch ex As System.Exception
                Throw ex
            End Try
        End Sub

    End Class

End Namespace