Namespace Validation

    Public Class NumericRule(Of T As IComparable(Of T))
        Inherits BaseRule

        Private _MinValue As Object
        Private _MaxValue As Object
        Private _RealPartDigitCount As Nullable(Of Integer)
        Private _FloatingPartDigitCount As Nullable(Of Integer)

        Public Sub New(ByVal PropertyName As String, ByVal FriendlyName As String, ByVal MinValue As Object, ByVal MaxValue As Object, ByVal RealPartDigitCount As Nullable(Of Integer), ByVal FloatingPartDigitCount As Nullable(Of Integer))
            MyBase.New(PropertyName, FriendlyName)
            Me._RealPartDigitCount = RealPartDigitCount
            Me._FloatingPartDigitCount = FloatingPartDigitCount
            Me._MinValue = MinValue
            Me._MaxValue = MaxValue
        End Sub

        Public Sub New(ByVal PropertyName As String, ByVal MinValue As T, ByVal MaxValue As T, ByVal RealPartDigitCount As Nullable(Of Integer), ByVal FloatingPartDigitCount As Nullable(Of Integer))
            Me.New(PropertyName, PropertyName, MinValue, MaxValue, RealPartDigitCount, FloatingPartDigitCount)
        End Sub

        Public ReadOnly Property MinValue() As Object
            Get
                Return Me._MinValue
            End Get
        End Property

        Public ReadOnly Property MaxValue() As Object
            Get
                Return Me._MaxValue
            End Get
        End Property

        Public ReadOnly Property RealPartDigitCount() As Nullable(Of Integer)
            Get
                Return Me._RealPartDigitCount
            End Get
        End Property

        Public ReadOnly Property FloatingPartDigitCount() As Nullable(Of Integer)
            Get
                Return Me._FloatingPartDigitCount
            End Get
        End Property

        Public Overrides Function Validate(ByVal Value As Object) As Boolean
            Dim Val As T
            If String.IsNullOrEmpty(Value) Then
                Return True
            End If

            Dim IsNegetive As Boolean = False
            If IsNumeric(Value) AndAlso Value < 0 Then
                IsNegetive = True
                Value *= -1
            End If

            Try
                'Val = DirectCast(Value, T)
                Val = Convert.ChangeType(Value, GetType(T))
            Catch ex As System.Exception
                Me.Description = String.Format(My.Resources.ValidationMessage.IncorrectDataType, FriendlyName)
                Return False
            End Try

            Dim SplitPart() As String = Val.ToString.Split(".")
            If SplitPart.Length = 0 Then
                Me.Description = String.Empty
                Return True
            End If

            If RealPartDigitCount > 0 Then
                If RealPartDigitCount.HasValue AndAlso SplitPart(0).Length > RealPartDigitCount Then
                    Me.Description = String.Format(My.Resources.ValidationMessage.DataNotValid, FriendlyName)
                    Return False
                End If

                If RealPartDigitCount.HasValue AndAlso SplitPart.Length = 2 AndAlso SplitPart(1).Length > FloatingPartDigitCount Then
                    Me.Description = String.Format(My.Resources.ValidationMessage.DataNotValid, FriendlyName)
                    Return False
                End If
            End If

            If IsNegetive Then
                Value *= -1
                Val = Convert.ChangeType(Value, GetType(T))
            End If

            If MinValue IsNot Nothing AndAlso IsNumeric(MinValue) AndAlso Val.CompareTo(MinValue) = -1 Then
                Me.Description = String.Format(My.Resources.ValidationMessage.ValueShouldNotLess, FriendlyName, Me.MinValue.ToString)
                Return False
            End If

            If MaxValue IsNot Nothing AndAlso IsNumeric(MinValue) AndAlso Val.CompareTo(MaxValue) > 0 Then
                Me.Description = String.Format(My.Resources.ValidationMessage.ValueShouldNotGreater, FriendlyName, Me.MaxValue.ToString)
                Return False
            End If

            Me.Description = String.Empty
            Return True
        End Function
    End Class

End Namespace