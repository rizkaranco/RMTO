Namespace Validation

    Public MustInherit Class BaseRule
        Private _PropertyName As String
        Private _FriendlyName As String
        Private _Description As String
        Private _Field() As String = Nothing

        Public ReadOnly Property RuleName() As String
            Get
                Return PropertyName + "_" + Me.GetType.ToString
            End Get
        End Property

        Public ReadOnly Property PropertyName() As String
            Get
                Return _PropertyName
            End Get
        End Property

        Public ReadOnly Property FriendlyName() As String
            Get
                Return _FriendlyName
            End Get
        End Property

        Public Property Description() As String
            Get
                Return _Description
            End Get
            Set(ByVal value As String)
                Me._Description = value
            End Set
        End Property

        Public Property Field() As String()
            Get
                Return _Field
            End Get
            Set(ByVal value() As String)
                Me._Field = value
            End Set
        End Property

        Public Sub New(ByVal PropertyName As String, ByVal FriendlyName As String)
            Me._PropertyName = PropertyName
            Me._FriendlyName = FriendlyName
        End Sub

        Public Overridable Function Validate(ByVal Value As Object) As Boolean
        End Function

        Public Overridable Function Validate(ByVal ParamArray value() As Object) As Boolean
        End Function

    End Class

End Namespace