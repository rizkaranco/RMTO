Namespace PL
    Public Class SQLServerConnectionSetting

        Public Enum enmCloseMode
            CloseForm
            EndProgram
        End Enum

        Private _CloseMode As enmCloseMode

        Public Sub New(ByVal CloseMode As enmCloseMode)
            InitializeComponent()
            MyBase.EnglishControls.Add(UserNameTextBox.Name, Me.UserNameTextBox)
            MyBase.EnglishControls.Add(PasswordTextBox.Name, Me.PasswordTextBox)
            MyBase.EnglishControls.Add(ServerNameTextBox.Name, Me.ServerNameTextBox)
            MyBase.EnglishControls.Add(DataBaseNameTextBox.Name, Me.DataBaseNameTextBox)
            Me._CloseMode = CloseMode
            If Me._CloseMode = enmCloseMode.EndProgram Then
                Me.CloseButton.Text = "خروج"
            End If
        End Sub

        Private Sub SQLServerConnectionSetting_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
            Me.UserNameTextBox.Text = Hepsa.Core.Common.ConnectionString.UserName
            Me.PasswordTextBox.Text = Hepsa.Core.Common.ConnectionString.Password
            Me.DataBaseNameTextBox.Text = Hepsa.Core.Common.ConnectionString.DataBase
            Me.ServerNameTextBox.Text = Hepsa.Core.Common.ConnectionString.Server
            If Hepsa.Core.Common.ConnectionString.AuthenticationMode = Hepsa.Core.Common.ConnectionString.enmAuthenticationMode.SQLServerAuthentication Then
                Me.SQLServerAuthenticationRadioButton.Checked = True
            Else
                Me.WindowsAuthenticationRadioButton.Checked = True
            End If
        End Sub

        Private Sub CloseButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloseButton.Click
            If Me._CloseMode = enmCloseMode.EndProgram Then
                Application.Exit()
            Else
                Me.Close()
            End If
        End Sub

        Private Sub WindowsAuthenticationRadioButton_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles WindowsAuthenticationRadioButton.CheckedChanged
            If Me.WindowsAuthenticationRadioButton.Checked = True Then
                Me.UserNameTextBox.Clear()
                Me.PasswordTextBox.Clear()
                Me.UserNameTextBox.Enabled = False
                Me.PasswordTextBox.Enabled = False
                Me.UserNameLabel.Enabled = False
                Me.PasswordLabel.Enabled = False
            Else
                Me.UserNameTextBox.Enabled = True
                Me.PasswordTextBox.Enabled = True
                Me.UserNameLabel.Enabled = True
                Me.PasswordLabel.Enabled = True
            End If
        End Sub

        Private Sub SaveButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveButton.Click
            Hepsa.Core.Common.ConnectionString.UserName = Me.UserNameTextBox.Text
            Hepsa.Core.Common.ConnectionString.Password = Me.PasswordTextBox.Text
            Hepsa.Core.Common.ConnectionString.DataBase = Me.DataBaseNameTextBox.Text
            Hepsa.Core.Common.ConnectionString.Server = Me.ServerNameTextBox.Text
            If Me.WindowsAuthenticationRadioButton.Checked Then
                Hepsa.Core.Common.ConnectionString.AuthenticationMode = Hepsa.Core.Common.ConnectionString.enmAuthenticationMode.WindowsAuthentication
            Else
                Hepsa.Core.Common.ConnectionString.AuthenticationMode = Hepsa.Core.Common.ConnectionString.enmAuthenticationMode.SQLServerAuthentication
            End If
            Me.Close()
        End Sub

    End Class
End Namespace