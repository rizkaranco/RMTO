Namespace PL
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class LoginForm
        Inherits PL.BaseForm

        'Form overrides dispose to clean up the component list.
        <System.Diagnostics.DebuggerNonUserCode()> _
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            Try
                If disposing AndAlso components IsNot Nothing Then
                    components.Dispose()
                End If
            Finally
                MyBase.Dispose(disposing)
            End Try
        End Sub

        'Required by the Windows Form Designer
        Private components As System.ComponentModel.IContainer

        'NOTE: The following procedure is required by the Windows Form Designer
        'It can be modified using the Windows Form Designer.  
        'Do not modify it using the code editor.
        <System.Diagnostics.DebuggerStepThrough()> _
        Private Sub InitializeComponent()
            Me.UserName_nvcTextBox = New System.Windows.Forms.TextBox
            Me.PasswordLabel = New System.Windows.Forms.Label
            Me.UserNameLabel = New System.Windows.Forms.Label
            Me.Password_nvcTextBox = New System.Windows.Forms.TextBox
            Me.GroupBox1 = New System.Windows.Forms.GroupBox
            Me.RememberMyPasswordCheckBox = New System.Windows.Forms.CheckBox
            Me.RememberMeCheckBox = New System.Windows.Forms.CheckBox
            Me.UserPictureBox = New System.Windows.Forms.PictureBox
            Me.CloseFormButton = New System.Windows.Forms.Button
            Me.AcceptButton = New System.Windows.Forms.Button
            Me.Label5 = New System.Windows.Forms.Label
            Me.HeaderPictureBox = New System.Windows.Forms.PictureBox
            Me.Label1 = New System.Windows.Forms.Label
            Me.GroupBox1.SuspendLayout()
            CType(Me.UserPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.HeaderPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'UserName_nvcTextBox
            '
            Me.UserName_nvcTextBox.Location = New System.Drawing.Point(86, 14)
            Me.UserName_nvcTextBox.MaxLength = 100
            Me.UserName_nvcTextBox.Name = "UserName_nvcTextBox"
            Me.UserName_nvcTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes
            Me.UserName_nvcTextBox.Size = New System.Drawing.Size(273, 21)
            Me.UserName_nvcTextBox.TabIndex = 1
            '
            'PasswordLabel
            '
            Me.PasswordLabel.AutoSize = True
            Me.PasswordLabel.Location = New System.Drawing.Point(362, 40)
            Me.PasswordLabel.Name = "PasswordLabel"
            Me.PasswordLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes
            Me.PasswordLabel.Size = New System.Drawing.Size(42, 13)
            Me.PasswordLabel.TabIndex = 2
            Me.PasswordLabel.Text = "گذر واژه"
            '
            'UserNameLabel
            '
            Me.UserNameLabel.AutoSize = True
            Me.UserNameLabel.Location = New System.Drawing.Point(362, 17)
            Me.UserNameLabel.Name = "UserNameLabel"
            Me.UserNameLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes
            Me.UserNameLabel.Size = New System.Drawing.Size(43, 13)
            Me.UserNameLabel.TabIndex = 0
            Me.UserNameLabel.Text = "نام کاربر"
            '
            'Password_nvcTextBox
            '
            Me.Password_nvcTextBox.Location = New System.Drawing.Point(86, 37)
            Me.Password_nvcTextBox.MaxLength = 100
            Me.Password_nvcTextBox.Name = "Password_nvcTextBox"
            Me.Password_nvcTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes
            Me.Password_nvcTextBox.Size = New System.Drawing.Size(273, 21)
            Me.Password_nvcTextBox.TabIndex = 3
            Me.Password_nvcTextBox.UseSystemPasswordChar = True
            '
            'GroupBox1
            '
            Me.GroupBox1.Controls.Add(Me.Label1)
            Me.GroupBox1.Controls.Add(Me.RememberMyPasswordCheckBox)
            Me.GroupBox1.Controls.Add(Me.RememberMeCheckBox)
            Me.GroupBox1.Controls.Add(Me.UserPictureBox)
            Me.GroupBox1.Controls.Add(Me.CloseFormButton)
            Me.GroupBox1.Controls.Add(Me.AcceptButton)
            Me.GroupBox1.Controls.Add(Me.UserName_nvcTextBox)
            Me.GroupBox1.Controls.Add(Me.PasswordLabel)
            Me.GroupBox1.Controls.Add(Me.UserNameLabel)
            Me.GroupBox1.Controls.Add(Me.Password_nvcTextBox)
            Me.GroupBox1.Controls.Add(Me.Label5)
            Me.GroupBox1.Location = New System.Drawing.Point(5, 58)
            Me.GroupBox1.Name = "GroupBox1"
            Me.GroupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
            Me.GroupBox1.Size = New System.Drawing.Size(412, 149)
            Me.GroupBox1.TabIndex = 0
            Me.GroupBox1.TabStop = False
            '
            'RememberMyPasswordCheckBox
            '
            Me.RememberMyPasswordCheckBox.AutoSize = True
            Me.RememberMyPasswordCheckBox.Location = New System.Drawing.Point(215, 86)
            Me.RememberMyPasswordCheckBox.Name = "RememberMyPasswordCheckBox"
            Me.RememberMyPasswordCheckBox.Size = New System.Drawing.Size(144, 17)
            Me.RememberMyPasswordCheckBox.TabIndex = 9
            Me.RememberMyPasswordCheckBox.Text = "گذر واژه مرا به خاطر بسپار"
            Me.RememberMyPasswordCheckBox.UseVisualStyleBackColor = True
            '
            'RememberMeCheckBox
            '
            Me.RememberMeCheckBox.AutoSize = True
            Me.RememberMeCheckBox.Location = New System.Drawing.Point(253, 67)
            Me.RememberMeCheckBox.Name = "RememberMeCheckBox"
            Me.RememberMeCheckBox.Size = New System.Drawing.Size(106, 17)
            Me.RememberMeCheckBox.TabIndex = 8
            Me.RememberMeCheckBox.Text = "مرا به خاطر بسپار"
            Me.RememberMeCheckBox.UseVisualStyleBackColor = True
            '
            'UserPictureBox
            '
            Me.UserPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
            Me.UserPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.UserPictureBox.Image = My.Resources.Resources.Login
            Me.UserPictureBox.Location = New System.Drawing.Point(11, 13)
            Me.UserPictureBox.Name = "UserPictureBox"
            Me.UserPictureBox.Size = New System.Drawing.Size(70, 94)
            Me.UserPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
            Me.UserPictureBox.TabIndex = 12
            Me.UserPictureBox.TabStop = False
            '
            'CloseFormButton
            '
            Me.CloseFormButton.Location = New System.Drawing.Point(251, 119)
            Me.CloseFormButton.Name = "CloseFormButton"
            Me.CloseFormButton.Size = New System.Drawing.Size(75, 23)
            Me.CloseFormButton.TabIndex = 12
            Me.CloseFormButton.Text = "انصراف"
            Me.CloseFormButton.TextAlign = System.Drawing.ContentAlignment.TopCenter
            Me.CloseFormButton.UseVisualStyleBackColor = True
            '
            'AcceptButton
            '
            Me.AcceptButton.Location = New System.Drawing.Point(327, 119)
            Me.AcceptButton.Name = "AcceptButton"
            Me.AcceptButton.Size = New System.Drawing.Size(75, 23)
            Me.AcceptButton.TabIndex = 11
            Me.AcceptButton.Text = "ورود"
            Me.AcceptButton.TextAlign = System.Drawing.ContentAlignment.TopCenter
            Me.AcceptButton.UseVisualStyleBackColor = True
            '
            'Label5
            '
            Me.Label5.AutoSize = True
            Me.Label5.ForeColor = System.Drawing.SystemColors.ControlDark
            Me.Label5.Location = New System.Drawing.Point(6, 99)
            Me.Label5.Name = "Label5"
            Me.Label5.Size = New System.Drawing.Size(403, 13)
            Me.Label5.TabIndex = 10
            Me.Label5.Text = "__________________________________________________________________"
            '
            'HeaderPictureBox
            '
            Me.HeaderPictureBox.Image = My.Resources.Resources.HamrahanSystemLogo
            Me.HeaderPictureBox.Location = New System.Drawing.Point(-2, 0)
            Me.HeaderPictureBox.Name = "HeaderPictureBox"
            Me.HeaderPictureBox.Size = New System.Drawing.Size(429, 60)
            Me.HeaderPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
            Me.HeaderPictureBox.TabIndex = 19
            Me.HeaderPictureBox.TabStop = False
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.Location = New System.Drawing.Point(11, 123)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(55, 13)
            Me.Label1.TabIndex = 13
            Me.Label1.Text = "F1: راهنما"
            '
            'LoginForm
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(422, 213)
            Me.Controls.Add(Me.HeaderPictureBox)
            Me.Controls.Add(Me.GroupBox1)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Name = "LoginForm"
            Me.ShowInTaskbar = True
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "ورود به سیستم"
            Me.GroupBox1.ResumeLayout(False)
            Me.GroupBox1.PerformLayout()
            CType(Me.UserPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.HeaderPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents UserName_nvcTextBox As System.Windows.Forms.TextBox
        Friend WithEvents PasswordLabel As System.Windows.Forms.Label
        Friend WithEvents UserNameLabel As System.Windows.Forms.Label
        Friend WithEvents Password_nvcTextBox As System.Windows.Forms.TextBox
        Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
        Friend WithEvents AcceptButton As System.Windows.Forms.Button
        Friend WithEvents CloseFormButton As System.Windows.Forms.Button
        Friend WithEvents UserPictureBox As System.Windows.Forms.PictureBox
        Friend WithEvents HeaderPictureBox As System.Windows.Forms.PictureBox
        Friend WithEvents RememberMeCheckBox As System.Windows.Forms.CheckBox
        Friend WithEvents RememberMyPasswordCheckBox As System.Windows.Forms.CheckBox
        Friend WithEvents Label5 As System.Windows.Forms.Label
        Friend WithEvents Label1 As System.Windows.Forms.Label
    End Class
End Namespace