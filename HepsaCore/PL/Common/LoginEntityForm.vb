Namespace PL
    Public Class LoginForm

        Private Sub CloseFormButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloseFormButton.Click
            Application.Exit()
        End Sub

        Private Sub LoginEntityForm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
            While True
                Dim UserFactory As New Hepsa.Core.BLL.BLLUser_TFactory
                Try
                    UserFactory.BeginProc()
                    Me.ShowSetting()
                    Exit While
                Catch ex As System.Exception
                    Dim frm As New SQLServerConnectionSetting(SQLServerConnectionSetting.enmCloseMode.EndProgram)
                    frm.ShowDialog()
                Finally
                    UserFactory.RollBackProc()
                End Try
            End While
        End Sub

        Private Sub AcceptButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AcceptButton.Click
            Try
                Dim UserFacotry As New Hepsa.Core.BLL.BLLUser_TFactory
                Dim UserLogin As New Hepsa.Core.BLL.BLLUserLogin_T
                UserLogin.UserName_nvc = Me.UserName_nvcTextBox.Text
                UserLogin.Password_nvc = Hepsa.Core.Common.Security.MD5(Me.Password_nvcTextBox.Text)
                Dim UserEntity As Hepsa.Core.BLL.BLLUser_T = UserFacotry.Login(UserLogin)
                If UserEntity IsNot Nothing Then
                    Hepsa.Core.Common.CurrentUser.User = UserEntity
                    Me.SaveSetting()
                    If Hepsa.Core.Common.ApplicationInfo.MainForm IsNot Nothing Then
                        Hepsa.Core.Common.ApplicationInfo.MainForm.WindowState = FormWindowState.Maximized
                        Hepsa.Core.Common.ApplicationInfo.MainForm.Show()
                    End If
                    Me.Hide()
                Else
                    Throw New Hepsa.Core.Exception.UserNotFound
                End If
            Catch ex As System.Exception
                Hepsa.Core.Common.MessageBox.ErrorMessage(ex.Message)
            End Try
        End Sub

        Private Sub SaveSetting()
            If Me.RememberMeCheckBox.Checked Then
                My.Settings.UserName = Me.UserName_nvcTextBox.Text
            Else
                My.Settings.UserName = String.Empty
            End If
            If Me.RememberMyPasswordCheckBox.Checked = True Then
                My.Settings.Password = Me.Password_nvcTextBox.Text
            Else
                My.Settings.Password = String.Empty
            End If
            My.Settings.Save()
        End Sub

        Private Sub ShowSetting()
            If String.IsNullOrEmpty(My.Settings.UserName) = False Then
                Me.UserName_nvcTextBox.Text = My.Settings.UserName
                Me.UserName_nvcTextBox_Leave(Me.UserName_nvcTextBox, New EventArgs)
                Me.RememberMeCheckBox.Checked = True
            End If
            If String.IsNullOrEmpty(My.Settings.Password) = False Then
                Me.Password_nvcTextBox.Text = My.Settings.Password
                Me.RememberMyPasswordCheckBox.Checked = True
            End If
        End Sub

        Private Sub RememberMyPasswordCheckBox_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RememberMyPasswordCheckBox.CheckedChanged
            If Me.RememberMyPasswordCheckBox.Checked Then
                Me.RememberMeCheckBox.Checked = True
            End If
        End Sub

        Private Sub RememberMeCheckBox_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RememberMeCheckBox.CheckedChanged
            If Me.RememberMeCheckBox.Checked = False Then
                Me.RememberMyPasswordCheckBox.Checked = False
            End If
        End Sub

        Private Sub UserName_nvcTextBox_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UserName_nvcTextBox.Leave
            Try
                Dim UserFactory As New Hepsa.Core.BLL.BLLUser_TFactory
                Dim UserKey As New Hepsa.Core.BLL.BLLUser_TKeys
                UserKey.UserName_nvc = Me.UserName_nvcTextBox.Text
                Dim UserEntity As Hepsa.Core.BLL.BLLUser_T = UserFactory.GetBy(UserKey)
                If UserEntity IsNot Nothing Then
                    If UserEntity.Picture_img IsNot Nothing Then
                        Dim MemoryStream As New IO.MemoryStream
                        MemoryStream.Write(UserEntity.Picture_img, 0, UserEntity.Picture_img.Length - 1)
                        Me.UserPictureBox.Image = System.Drawing.Image.FromStream(MemoryStream)
                    End If
                Else
                    Me.UserPictureBox.Image = My.Resources.Login
                End If
            Catch ex As System.Exception
            End Try
        End Sub

    End Class
End Namespace