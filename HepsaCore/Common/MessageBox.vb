Namespace Common

    Public Class MessageBox

        Public Shared Sub ErrorMessage(ByVal Message As String)
            Dim MSG As New CMessageBox
            MSG.ShowMessage(0, Message, "خطا", "تایید", "", "", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign)
        End Sub

        Public Shared Sub InformationMessage(ByVal Message As String)
            Dim MSG As New CMessageBox
            MSG.ShowMessage(0, Message, "پیغام", "تایید", "", "", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2, MessageBoxOptions.RightAlign)
        End Sub

        Public Shared Function ConfirmDeleteMessage() As Boolean
            Dim MSG As New CMessageBox
            If MSG.ShowMessage(0, My.Resources.Exceptions.DeleteConfirm, "هشدار", "خیر", "بلی", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign) = DialogResult.No Then
                Return True
            Else
                Return False
            End If
        End Function

        Public Shared Function ConfirmMessage(ByVal Message As String) As Boolean
            Dim MSG As New CMessageBox
            If MSG.ShowMessage(0, Message, "پرسش", "خیر", "بلی", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2, MessageBoxOptions.RightAlign) = DialogResult.No Then
                Return True
            Else
                Return False
            End If
        End Function

        Public Shared Sub CompleteSuccessfulMessage()
            Dim MSG As New CMessageBox
            MSG.ShowMessage(0, My.Resources.Exceptions.CompletSuccessful, "اطلاع", "تایید", "", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign)
        End Sub

    End Class

End Namespace
