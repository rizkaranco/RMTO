Namespace Validation

    Public Class LogicalOperationRule
        Inherits BaseRule

        Public Enum enumLogicOperator As Byte
            GratherThan = 0
            GratherOrEqual = 1
            LessThan = 2
            LessOrEqual = 3
            Equal = 4
            NotEqual = 5
        End Enum

        Private Logic As DataTable
        Private OperandList As List(Of String)

        Public Sub New(ByVal PropertyName As String)
            MyBase.New(PropertyName, PropertyName)
            Logic = New DataTable
            OperandList = New List(Of String)
            Logic.Columns.Add(New DataColumn("Operand1"))
            Logic.Columns.Add(New DataColumn("Operator", GetType(Byte)))
            Logic.Columns.Add(New DataColumn("Operand2"))
            Logic.Columns.Add(New DataColumn("FriendName1"))
            Logic.Columns.Add(New DataColumn("FriendName2"))
            Logic.Columns.Add(New DataColumn("CompareNullOrEmpty", GetType(Boolean)))
        End Sub

        Public Sub AddItem(ByVal Operand1 As String, ByVal _Operator As enumLogicOperator, ByVal Operand2 As String, ByVal FriendName1 As String, ByVal FriendName2 As String, ByVal CompareNullOrEmpty As Boolean)
            If OperandList.Contains(Operand1) = False Then
                OperandList.Add(Operand1)
            End If
            If OperandList.Contains(Operand2) = False Then
                OperandList.Add(Operand2)
            End If
            Dim dr() As DataRow = Logic.Select("Operand1='" + Common.PersentationController.CorrectLike(Operand1) + "' And Operand2 = '" + Common.PersentationController.CorrectLike(Operand2) + "' And Operator = " + Byte.Parse(_Operator).ToString)
            If dr.Length = 0 Then
                Dim NewRow As DataRow = Logic.NewRow
                NewRow.Item("Operand1") = Operand1
                NewRow.Item("Operand2") = Operand2
                NewRow.Item("Operator") = Byte.Parse(_Operator)
                NewRow.Item("FriendName1") = FriendName1
                NewRow.Item("FriendName2") = FriendName2
                NewRow.Item("CompareNullOrEmpty") = CompareNullOrEmpty
                Logic.Rows.Add(NewRow)
            End If
            MyBase.Field = OperandList.ToArray
        End Sub

        Public Overrides Function Validate(ByVal ParamArray Value() As Object) As Boolean
            Try
                Dim ValidateResult As New System.Text.StringBuilder

                If Value.Count <> Field.Count Then
                    Me.Description = My.Resources.ValidationMessage.IncorrectDataType
                    Return False
                End If
                If Value.Count = 0 Then
                    Me.Description = String.Empty
                    Return True
                End If

                For Each dr As DataRow In Logic.Rows
                    If Me.Result(Me.GetOperandValue(dr.Item("Operand1"), Value), Me.GetOperandValue(dr.Item("Operand2"), Value), dr.Item("Operator"), dr.Item("CompareNullOrEmpty")) = False Then
                        ValidateResult.AppendLine(Me.GetDescription(dr.Item("FriendName1"), dr.Item("FriendName2"), dr.Item("Operator")))
                    End If
                Next

                Me.Description = ValidateResult.ToString.Trim
                If Description = String.Empty Then
                    Return True
                End If
            Catch ex As System.Exception
                Me.Description = ex.Message
                Return False
            End Try
        End Function

        Private Function Result(ByVal Operand1 As Object, ByVal Operand2 As Object, ByVal _Operator As enumLogicOperator, ByVal CompareNullOrEmpty As Boolean) As Boolean
            If CompareNullOrEmpty = False AndAlso (Operand1 Is Nothing OrElse Operand2 Is Nothing OrElse ((TypeOf Operand1 Is String AndAlso String.IsNullOrEmpty(Operand1)) OrElse (TypeOf Operand2 Is String AndAlso String.IsNullOrEmpty(Operand2)))) Then
                Return True
            End If

            Select Case _Operator
                Case enumLogicOperator.Equal
                    If Operand1 = Operand2 Then
                        Return True
                    End If
                Case enumLogicOperator.GratherOrEqual
                    If Operand1 >= Operand2 Then
                        Return True
                    End If
                Case enumLogicOperator.GratherThan
                    If Operand1 > Operand2 Then
                        Return True
                    End If
                Case enumLogicOperator.LessOrEqual
                    If Operand1 <= Operand2 Then
                        Return True
                    End If
                Case enumLogicOperator.LessThan
                    If Operand1 < Operand2 Then
                        Return True
                    End If
                Case enumLogicOperator.NotEqual
                    If Operand1 <> Operand2 Then
                        Return True
                    End If
                Case Else
                    Return True
            End Select

            Return False
        End Function

        Private Function GetOperandValue(ByVal Operand As String, ByVal Value() As Object) As Object
            Dim OperandPointer As Integer = -1
            For index As Integer = 0 To MyBase.Field.Length - 1
                If MyBase.Field(index) = Operand Then
                    OperandPointer = index
                End If
            Next
            If OperandPointer > -1 Then
                Return Value(OperandPointer)
            Else
                Return Nothing
            End If
        End Function

        Private Function GetDescription(ByVal FriendName1 As String, ByVal FriendName2 As String, ByVal _Operator As enumLogicOperator) As String
            Select Case _Operator
                Case enumLogicOperator.Equal
                    Return String.Format(My.Resources.ValidationMessage.LogicOperationEqualError, FriendName1, FriendName2)
                Case enumLogicOperator.GratherOrEqual
                    Return String.Format(My.Resources.ValidationMessage.LogicOperationGratherOrEqualError, FriendName1, FriendName2)
                Case enumLogicOperator.GratherThan
                    Return String.Format(My.Resources.ValidationMessage.LogicOperationGratherThanError, FriendName1, FriendName2)
                Case enumLogicOperator.LessOrEqual
                    Return String.Format(My.Resources.ValidationMessage.LogicOperationLessOrEqualError, FriendName1, FriendName2)
                Case enumLogicOperator.LessThan
                    Return String.Format(My.Resources.ValidationMessage.LogicOperationLessThanError, FriendName1, FriendName2)
                Case enumLogicOperator.NotEqual
                    Return String.Format(My.Resources.ValidationMessage.LogicOperationNotEqualError, FriendName1, FriendName2)
                Case Else
                    Return String.Empty
            End Select

        End Function

    End Class

End Namespace