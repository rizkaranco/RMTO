Namespace Validation

    Public Class DateRule(Of T)
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
                    Dim SplitDate() As String = Value.Split(System.Globalization.CultureInfo.CurrentUICulture.DateTimeFormat.DateSeparator)

                    If SplitDate.Length <> 3 Then
                        Throw New System.Exception(String.Format(My.Resources.ValidationMessage.DataNotValid, FriendlyName))
                    End If

                    If Not (IsNumeric(SplitDate(0)) AndAlso IsNumeric(SplitDate(1)) AndAlso IsNumeric(SplitDate(2))) Then
                        Throw New System.Exception(String.Format(My.Resources.ValidationMessage.DataNotValid, FriendlyName))
                    End If

                    If Not (SplitDate(0).Length = 4 AndAlso SplitDate(1).Length = 2 AndAlso SplitDate(2).Length = 2) Then
                        Throw New System.Exception(String.Format(My.Resources.ValidationMessage.DataNotValid, FriendlyName))
                    End If

                    If Not (Convert.ToInt32(SplitDate(0)) >= 1300 AndAlso Convert.ToInt32(SplitDate(0)) <= 2099) Then
                        Throw New System.Exception(String.Format(My.Resources.ValidationMessage.DataNotValid, FriendlyName))
                    End If

                    If Not (Convert.ToInt32(SplitDate(1)) >= 1 AndAlso Convert.ToInt32(SplitDate(1)) <= 12) Then
                        Throw New System.Exception(String.Format(My.Resources.ValidationMessage.DataNotValid, FriendlyName))
                    End If

                    If Not (Convert.ToInt32(SplitDate(2)) >= 1 AndAlso Convert.ToInt32(SplitDate(2)) <= 31) Then
                        Throw New System.Exception(String.Format(My.Resources.ValidationMessage.DataNotValid, FriendlyName))
                    End If

                    If Convert.ToInt32(SplitDate(1)) >= 7 AndAlso Convert.ToInt32(SplitDate(2)) = 31 Then
                        Throw New System.Exception(String.Format(My.Resources.ValidationMessage.DataNotValid, FriendlyName))
                    End If

                    If Convert.ToInt32(SplitDate(1)) = 12 AndAlso IsLeapYear(SplitDate(0)) = False AndAlso Convert.ToInt32(SplitDate(2)) = 30 Then
                        Throw New System.Exception(String.Format(My.Resources.ValidationMessage.DataNotValid, FriendlyName))
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

        Private Function IsLeapYear(ByVal Year As Integer) As Boolean
            Dim m As Integer = Year Mod 33
            If m = 1 OrElse m = 5 OrElse m = 9 OrElse m = 13 OrElse m = 17 OrElse m = 22 OrElse m = 26 OrElse m = 30 Then
                Return True
            Else
                Return False
            End If
        End Function

    End Class

End Namespace