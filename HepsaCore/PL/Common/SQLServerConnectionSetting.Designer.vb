Namespace PL
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class SQLServerConnectionSetting
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SQLServerConnectionSetting))
            Me.ServerNameLabel = New System.Windows.Forms.Label
            Me.ServerNameTextBox = New System.Windows.Forms.TextBox
            Me.StatusLabel = New System.Windows.Forms.Label
            Me.LogoPictureBox = New System.Windows.Forms.PictureBox
            Me.Label4 = New System.Windows.Forms.Label
            Me.AuthenticationMode = New System.Windows.Forms.Label
            Me.WindowsAuthenticationRadioButton = New System.Windows.Forms.RadioButton
            Me.SQLServerAuthenticationRadioButton = New System.Windows.Forms.RadioButton
            Me.UserNameTextBox = New System.Windows.Forms.TextBox
            Me.UserNameLabel = New System.Windows.Forms.Label
            Me.PasswordTextBox = New System.Windows.Forms.TextBox
            Me.PasswordLabel = New System.Windows.Forms.Label
            Me.Label6 = New System.Windows.Forms.Label
            Me.Label7 = New System.Windows.Forms.Label
            Me.DataBaseNameTextBox = New System.Windows.Forms.TextBox
            Me.DatabeseNameLabel = New System.Windows.Forms.Label
            Me.Label9 = New System.Windows.Forms.Label
            Me.SaveButton = New System.Windows.Forms.Button
            Me.CloseButton = New System.Windows.Forms.Button
            CType(Me.LogoPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'ServerNameLabel
            '
            Me.ServerNameLabel.AutoSize = True
            Me.ServerNameLabel.Location = New System.Drawing.Point(9, 85)
            Me.ServerNameLabel.Name = "ServerNameLabel"
            Me.ServerNameLabel.Size = New System.Drawing.Size(79, 13)
            Me.ServerNameLabel.TabIndex = 2
            Me.ServerNameLabel.Text = "نام و/یا IP سرور"
            '
            'ServerNameTextBox
            '
            Me.ServerNameTextBox.Location = New System.Drawing.Point(92, 82)
            Me.ServerNameTextBox.Name = "ServerNameTextBox"
            Me.ServerNameTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.ServerNameTextBox.Size = New System.Drawing.Size(235, 21)
            Me.ServerNameTextBox.TabIndex = 3
            '
            'StatusLabel
            '
            Me.StatusLabel.ForeColor = System.Drawing.SystemColors.ControlText
            Me.StatusLabel.Location = New System.Drawing.Point(72, 20)
            Me.StatusLabel.Name = "StatusLabel"
            Me.StatusLabel.Size = New System.Drawing.Size(273, 35)
            Me.StatusLabel.TabIndex = 0
            Me.StatusLabel.Text = "تنظیمات مربوط به ایجاد اتصال به پایگاه داده را مشخص نمایید."
            '
            'LogoPictureBox
            '
            Me.LogoPictureBox.Image = CType(resources.GetObject("LogoPictureBox.Image"), System.Drawing.Image)
            Me.LogoPictureBox.Location = New System.Drawing.Point(16, 15)
            Me.LogoPictureBox.Name = "LogoPictureBox"
            Me.LogoPictureBox.Size = New System.Drawing.Size(47, 45)
            Me.LogoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
            Me.LogoPictureBox.TabIndex = 28
            Me.LogoPictureBox.TabStop = False
            '
            'Label4
            '
            Me.Label4.AutoSize = True
            Me.Label4.ForeColor = System.Drawing.SystemColors.ButtonShadow
            Me.Label4.Location = New System.Drawing.Point(10, 56)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New System.Drawing.Size(331, 13)
            Me.Label4.TabIndex = 1
            Me.Label4.Text = "______________________________________________________"
            '
            'AuthenticationMode
            '
            Me.AuthenticationMode.AutoSize = True
            Me.AuthenticationMode.Location = New System.Drawing.Point(20, 122)
            Me.AuthenticationMode.Name = "AuthenticationMode"
            Me.AuthenticationMode.Size = New System.Drawing.Size(50, 13)
            Me.AuthenticationMode.TabIndex = 5
            Me.AuthenticationMode.Text = "نوع اتصال"
            '
            'WindowsAuthenticationRadioButton
            '
            Me.WindowsAuthenticationRadioButton.AutoSize = True
            Me.WindowsAuthenticationRadioButton.Location = New System.Drawing.Point(37, 145)
            Me.WindowsAuthenticationRadioButton.Name = "WindowsAuthenticationRadioButton"
            Me.WindowsAuthenticationRadioButton.Size = New System.Drawing.Size(70, 17)
            Me.WindowsAuthenticationRadioButton.TabIndex = 6
            Me.WindowsAuthenticationRadioButton.TabStop = True
            Me.WindowsAuthenticationRadioButton.Text = "اتصال امن"
            Me.WindowsAuthenticationRadioButton.UseVisualStyleBackColor = True
            '
            'SQLServerAuthenticationRadioButton
            '
            Me.SQLServerAuthenticationRadioButton.AutoSize = True
            Me.SQLServerAuthenticationRadioButton.Location = New System.Drawing.Point(37, 168)
            Me.SQLServerAuthenticationRadioButton.Name = "SQLServerAuthenticationRadioButton"
            Me.SQLServerAuthenticationRadioButton.Size = New System.Drawing.Size(183, 17)
            Me.SQLServerAuthenticationRadioButton.TabIndex = 7
            Me.SQLServerAuthenticationRadioButton.TabStop = True
            Me.SQLServerAuthenticationRadioButton.Text = "اتصال با استفاده از اکانت پایگاه داده"
            Me.SQLServerAuthenticationRadioButton.UseVisualStyleBackColor = True
            '
            'UserNameTextBox
            '
            Me.UserNameTextBox.Location = New System.Drawing.Point(92, 191)
            Me.UserNameTextBox.Name = "UserNameTextBox"
            Me.UserNameTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.UserNameTextBox.Size = New System.Drawing.Size(235, 21)
            Me.UserNameTextBox.TabIndex = 9
            '
            'UserNameLabel
            '
            Me.UserNameLabel.AutoSize = True
            Me.UserNameLabel.Location = New System.Drawing.Point(35, 194)
            Me.UserNameLabel.Name = "UserNameLabel"
            Me.UserNameLabel.Size = New System.Drawing.Size(53, 13)
            Me.UserNameLabel.TabIndex = 8
            Me.UserNameLabel.Text = "شناسه کاربری"
            '
            'PasswordTextBox
            '
            Me.PasswordTextBox.Location = New System.Drawing.Point(92, 215)
            Me.PasswordTextBox.Name = "PasswordTextBox"
            Me.PasswordTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.PasswordTextBox.Size = New System.Drawing.Size(235, 21)
            Me.PasswordTextBox.TabIndex = 11
            Me.PasswordTextBox.UseSystemPasswordChar = True
            '
            'PasswordLabel
            '
            Me.PasswordLabel.AutoSize = True
            Me.PasswordLabel.Location = New System.Drawing.Point(35, 218)
            Me.PasswordLabel.Name = "PasswordLabel"
            Me.PasswordLabel.Size = New System.Drawing.Size(42, 13)
            Me.PasswordLabel.TabIndex = 10
            Me.PasswordLabel.Text = "گذر واژه"
            '
            'Label6
            '
            Me.Label6.AutoSize = True
            Me.Label6.ForeColor = System.Drawing.SystemColors.ButtonShadow
            Me.Label6.Location = New System.Drawing.Point(10, 101)
            Me.Label6.Name = "Label6"
            Me.Label6.Size = New System.Drawing.Size(331, 13)
            Me.Label6.TabIndex = 4
            Me.Label6.Text = "______________________________________________________"
            '
            'Label7
            '
            Me.Label7.AutoSize = True
            Me.Label7.ForeColor = System.Drawing.SystemColors.ButtonShadow
            Me.Label7.Location = New System.Drawing.Point(10, 234)
            Me.Label7.Name = "Label7"
            Me.Label7.Size = New System.Drawing.Size(331, 13)
            Me.Label7.TabIndex = 12
            Me.Label7.Text = "______________________________________________________"
            '
            'DataBaseNameTextBox
            '
            Me.DataBaseNameTextBox.Location = New System.Drawing.Point(92, 254)
            Me.DataBaseNameTextBox.Name = "DataBaseNameTextBox"
            Me.DataBaseNameTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.DataBaseNameTextBox.Size = New System.Drawing.Size(235, 21)
            Me.DataBaseNameTextBox.TabIndex = 14
            '
            'DatabeseNameLabel
            '
            Me.DatabeseNameLabel.AutoSize = True
            Me.DatabeseNameLabel.Location = New System.Drawing.Point(9, 257)
            Me.DatabeseNameLabel.Name = "DatabeseNameLabel"
            Me.DatabeseNameLabel.Size = New System.Drawing.Size(67, 13)
            Me.DatabeseNameLabel.TabIndex = 13
            Me.DatabeseNameLabel.Text = "نام پایگاه داده"
            '
            'Label9
            '
            Me.Label9.AutoSize = True
            Me.Label9.ForeColor = System.Drawing.SystemColors.ButtonShadow
            Me.Label9.Location = New System.Drawing.Point(10, 271)
            Me.Label9.Name = "Label9"
            Me.Label9.Size = New System.Drawing.Size(331, 13)
            Me.Label9.TabIndex = 15
            Me.Label9.Text = "______________________________________________________"
            '
            'SaveButton
            '
            Me.SaveButton.Location = New System.Drawing.Point(13, 291)
            Me.SaveButton.Name = "SaveButton"
            Me.SaveButton.Size = New System.Drawing.Size(75, 23)
            Me.SaveButton.TabIndex = 16
            Me.SaveButton.Text = "تایید"
            Me.SaveButton.UseVisualStyleBackColor = True
            '
            'CloseButton
            '
            Me.CloseButton.Location = New System.Drawing.Point(94, 291)
            Me.CloseButton.Name = "CloseButton"
            Me.CloseButton.Size = New System.Drawing.Size(75, 23)
            Me.CloseButton.TabIndex = 17
            Me.CloseButton.Text = "لغو"
            Me.CloseButton.UseVisualStyleBackColor = True
            '
            'SQLServerConnectionSetting
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(350, 322)
            Me.ControlBox = False
            Me.Controls.Add(Me.CloseButton)
            Me.Controls.Add(Me.SaveButton)
            Me.Controls.Add(Me.DataBaseNameTextBox)
            Me.Controls.Add(Me.DatabeseNameLabel)
            Me.Controls.Add(Me.PasswordTextBox)
            Me.Controls.Add(Me.PasswordLabel)
            Me.Controls.Add(Me.UserNameTextBox)
            Me.Controls.Add(Me.UserNameLabel)
            Me.Controls.Add(Me.SQLServerAuthenticationRadioButton)
            Me.Controls.Add(Me.WindowsAuthenticationRadioButton)
            Me.Controls.Add(Me.AuthenticationMode)
            Me.Controls.Add(Me.StatusLabel)
            Me.Controls.Add(Me.LogoPictureBox)
            Me.Controls.Add(Me.Label4)
            Me.Controls.Add(Me.ServerNameTextBox)
            Me.Controls.Add(Me.ServerNameLabel)
            Me.Controls.Add(Me.Label6)
            Me.Controls.Add(Me.Label7)
            Me.Controls.Add(Me.Label9)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Name = "SQLServerConnectionSetting"
            Me.ShowInTaskbar = True
            Me.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultLocation
            Me.Text = "تنظیمات اتصال به پایگاه داده"
            CType(Me.LogoPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents ServerNameLabel As System.Windows.Forms.Label
        Friend WithEvents ServerNameTextBox As System.Windows.Forms.TextBox
        Friend WithEvents StatusLabel As System.Windows.Forms.Label
        Friend WithEvents LogoPictureBox As System.Windows.Forms.PictureBox
        Friend WithEvents Label4 As System.Windows.Forms.Label
        Friend WithEvents AuthenticationMode As System.Windows.Forms.Label
        Friend WithEvents WindowsAuthenticationRadioButton As System.Windows.Forms.RadioButton
        Friend WithEvents SQLServerAuthenticationRadioButton As System.Windows.Forms.RadioButton
        Friend WithEvents UserNameTextBox As System.Windows.Forms.TextBox
        Friend WithEvents UserNameLabel As System.Windows.Forms.Label
        Friend WithEvents PasswordTextBox As System.Windows.Forms.TextBox
        Friend WithEvents PasswordLabel As System.Windows.Forms.Label
        Friend WithEvents Label6 As System.Windows.Forms.Label
        Friend WithEvents Label7 As System.Windows.Forms.Label
        Friend WithEvents DataBaseNameTextBox As System.Windows.Forms.TextBox
        Friend WithEvents DatabeseNameLabel As System.Windows.Forms.Label
        Friend WithEvents Label9 As System.Windows.Forms.Label
        Friend WithEvents SaveButton As System.Windows.Forms.Button
        Friend WithEvents CloseButton As System.Windows.Forms.Button
    End Class
End Namespace