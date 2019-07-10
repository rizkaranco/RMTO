Namespace PL
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class SearchTreeViewForm
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
            Me.TextBox = New System.Windows.Forms.TextBox
            Me.GroupBox1 = New System.Windows.Forms.GroupBox
            Me.WholeWordCheckBox = New System.Windows.Forms.CheckBox
            Me.SearchFromTopCheckBox = New System.Windows.Forms.CheckBox
            Me.SearchButton = New System.Windows.Forms.Button
            Me.NextButton = New System.Windows.Forms.Button
            Me.CloseButton = New System.Windows.Forms.Button
            Me.CaptionLabel = New System.Windows.Forms.Label
            Me.GroupBox1.SuspendLayout()
            Me.SuspendLayout()
            '
            'TextBox
            '
            Me.TextBox.Location = New System.Drawing.Point(6, 36)
            Me.TextBox.Name = "TextBox"
            Me.TextBox.Size = New System.Drawing.Size(408, 21)
            Me.TextBox.TabIndex = 1
            '
            'GroupBox1
            '
            Me.GroupBox1.Controls.Add(Me.WholeWordCheckBox)
            Me.GroupBox1.Controls.Add(Me.SearchFromTopCheckBox)
            Me.GroupBox1.Controls.Add(Me.TextBox)
            Me.GroupBox1.Controls.Add(Me.CaptionLabel)
            Me.GroupBox1.Location = New System.Drawing.Point(6, 1)
            Me.GroupBox1.Name = "GroupBox1"
            Me.GroupBox1.Size = New System.Drawing.Size(422, 110)
            Me.GroupBox1.TabIndex = 0
            Me.GroupBox1.TabStop = False
            '
            'WholeWordCheckBox
            '
            Me.WholeWordCheckBox.AutoSize = True
            Me.WholeWordCheckBox.Location = New System.Drawing.Point(302, 82)
            Me.WholeWordCheckBox.Name = "WholeWordCheckBox"
            Me.WholeWordCheckBox.Size = New System.Drawing.Size(108, 17)
            Me.WholeWordCheckBox.TabIndex = 3
            Me.WholeWordCheckBox.Text = "جستجو عین کلمه"
            Me.WholeWordCheckBox.UseVisualStyleBackColor = True
            '
            'SearchFromTopCheckBox
            '
            Me.SearchFromTopCheckBox.AutoSize = True
            Me.SearchFromTopCheckBox.Checked = True
            Me.SearchFromTopCheckBox.CheckState = System.Windows.Forms.CheckState.Checked
            Me.SearchFromTopCheckBox.Location = New System.Drawing.Point(317, 63)
            Me.SearchFromTopCheckBox.Name = "SearchFromTopCheckBox"
            Me.SearchFromTopCheckBox.Size = New System.Drawing.Size(93, 17)
            Me.SearchFromTopCheckBox.TabIndex = 2
            Me.SearchFromTopCheckBox.Text = "جستجو از ابتدا"
            Me.SearchFromTopCheckBox.UseVisualStyleBackColor = True
            '
            'SearchButton
            '
            Me.SearchButton.Location = New System.Drawing.Point(434, 16)
            Me.SearchButton.Name = "SearchButton"
            Me.SearchButton.Size = New System.Drawing.Size(75, 23)
            Me.SearchButton.TabIndex = 1
            Me.SearchButton.Text = "جستجو کن"
            Me.SearchButton.UseVisualStyleBackColor = True
            '
            'NextButton
            '
            Me.NextButton.Enabled = False
            Me.NextButton.Location = New System.Drawing.Point(434, 40)
            Me.NextButton.Name = "NextButton"
            Me.NextButton.Size = New System.Drawing.Size(75, 23)
            Me.NextButton.TabIndex = 2
            Me.NextButton.Text = "بعدی"
            Me.NextButton.UseVisualStyleBackColor = True
            '
            'CloseButton
            '
            Me.CloseButton.Location = New System.Drawing.Point(434, 72)
            Me.CloseButton.Name = "CloseButton"
            Me.CloseButton.Size = New System.Drawing.Size(75, 23)
            Me.CloseButton.TabIndex = 3
            Me.CloseButton.Text = "بستن"
            Me.CloseButton.UseVisualStyleBackColor = True
            '
            'CaptionLabel
            '
            Me.CaptionLabel.AutoSize = True
            Me.CaptionLabel.Location = New System.Drawing.Point(352, 20)
            Me.CaptionLabel.Name = "CaptionLabel"
            Me.CaptionLabel.Size = New System.Drawing.Size(62, 13)
            Me.CaptionLabel.TabIndex = 0
            Me.CaptionLabel.Text = "جستجو کن:"
            '
            'SearchTreeViewForm
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(515, 120)
            Me.Controls.Add(Me.CloseButton)
            Me.Controls.Add(Me.NextButton)
            Me.Controls.Add(Me.SearchButton)
            Me.Controls.Add(Me.GroupBox1)
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Name = "SearchTreeViewForm"
            Me.Text = "جستجو"
            Me.TopMost = True
            Me.GroupBox1.ResumeLayout(False)
            Me.GroupBox1.PerformLayout()
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents TextBox As System.Windows.Forms.TextBox
        Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
        Friend WithEvents SearchButton As System.Windows.Forms.Button
        Friend WithEvents NextButton As System.Windows.Forms.Button
        Friend WithEvents CloseButton As System.Windows.Forms.Button
        Friend WithEvents WholeWordCheckBox As System.Windows.Forms.CheckBox
        Friend WithEvents SearchFromTopCheckBox As System.Windows.Forms.CheckBox
        Friend WithEvents CaptionLabel As System.Windows.Forms.Label
    End Class
End Namespace