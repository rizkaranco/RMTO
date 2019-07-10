Namespace PL
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class BaseEntityForm1
        Inherits PL.BaseEntityParentForm

        'Form overrides dispose to clean up the component list.
        <System.Diagnostics.DebuggerNonUserCode()> _
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

        'Required by the Windows Form Designer
        Private components As System.ComponentModel.IContainer

        'NOTE: The following procedure is required by the Windows Form Designer
        'It can be modified using the Windows Form Designer.  
        'Do not modify it using the code editor.
        <System.Diagnostics.DebuggerStepThrough()> _
        Private Sub InitializeComponent()
            Me.SaveAndNextButton = New System.Windows.Forms.Button()
            Me.SaveAndCloseButton = New System.Windows.Forms.Button()
            Me.DeleteRecordButton = New System.Windows.Forms.Button()
            Me.CloseFormButton = New System.Windows.Forms.Button()
            Me.SuspendLayout()
            '
            'SaveAndNextButton
            '
            Me.SaveAndNextButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.SaveAndNextButton.Location = New System.Drawing.Point(660, 30)
            Me.SaveAndNextButton.Margin = New System.Windows.Forms.Padding(5)
            Me.SaveAndNextButton.Name = "SaveAndNextButton"
            Me.SaveAndNextButton.Size = New System.Drawing.Size(100, 32)
            Me.SaveAndNextButton.TabIndex = 1
            Me.SaveAndNextButton.Text = "ثبت و بعدی"
            Me.SaveAndNextButton.UseVisualStyleBackColor = True
            '
            'SaveAndCloseButton
            '
            Me.SaveAndCloseButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.SaveAndCloseButton.Location = New System.Drawing.Point(660, 72)
            Me.SaveAndCloseButton.Margin = New System.Windows.Forms.Padding(5)
            Me.SaveAndCloseButton.Name = "SaveAndCloseButton"
            Me.SaveAndCloseButton.Size = New System.Drawing.Size(100, 32)
            Me.SaveAndCloseButton.TabIndex = 2
            Me.SaveAndCloseButton.Text = "ثبت و خروج"
            Me.SaveAndCloseButton.UseVisualStyleBackColor = True
            '
            'DeleteRecordButton
            '
            Me.DeleteRecordButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.DeleteRecordButton.Location = New System.Drawing.Point(660, 114)
            Me.DeleteRecordButton.Margin = New System.Windows.Forms.Padding(5)
            Me.DeleteRecordButton.Name = "DeleteRecordButton"
            Me.DeleteRecordButton.Size = New System.Drawing.Size(100, 32)
            Me.DeleteRecordButton.TabIndex = 3
            Me.DeleteRecordButton.Text = "حذف"
            Me.DeleteRecordButton.UseVisualStyleBackColor = True
            '
            'CloseFormButton
            '
            Me.CloseFormButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.CloseFormButton.Location = New System.Drawing.Point(660, 156)
            Me.CloseFormButton.Margin = New System.Windows.Forms.Padding(5)
            Me.CloseFormButton.Name = "CloseFormButton"
            Me.CloseFormButton.Size = New System.Drawing.Size(100, 32)
            Me.CloseFormButton.TabIndex = 4
            Me.CloseFormButton.Text = "انصراف"
            Me.CloseFormButton.UseVisualStyleBackColor = True
            '
            'BaseEntityForm1
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 23.0!)
            Me.ClientSize = New System.Drawing.Size(782, 370)
            Me.Controls.Add(Me.CloseFormButton)
            Me.Controls.Add(Me.DeleteRecordButton)
            Me.Controls.Add(Me.SaveAndCloseButton)
            Me.Controls.Add(Me.SaveAndNextButton)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
            Me.Margin = New System.Windows.Forms.Padding(7, 9, 7, 9)
            Me.MaximizeBox = False
            Me.Name = "BaseEntityForm1"
            Me.ResumeLayout(False)

        End Sub
        Public WithEvents SaveAndNextButton As System.Windows.Forms.Button
        Public WithEvents SaveAndCloseButton As System.Windows.Forms.Button
        Public WithEvents DeleteRecordButton As System.Windows.Forms.Button
        Public WithEvents CloseFormButton As System.Windows.Forms.Button

    End Class
End Namespace