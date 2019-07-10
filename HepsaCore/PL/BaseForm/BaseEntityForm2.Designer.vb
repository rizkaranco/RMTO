Namespace PL
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class BaseEntityForm2
        Inherits PL.BaseEntityParentForm

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
            Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
            Me.SaveAndContinueToolStripButton = New System.Windows.Forms.ToolStripButton
            Me.SaveAndExitToolStripButton = New System.Windows.Forms.ToolStripButton
            Me.SaveAndConfirmToolStripButton = New System.Windows.Forms.ToolStripButton
            Me.DeleteToolStripButton = New System.Windows.Forms.ToolStripButton
            Me.CloseToolstripButton = New System.Windows.Forms.ToolStripButton
            Me.ToolStrip1.SuspendLayout()
            Me.SuspendLayout()
            '
            'ToolStrip1
            '
            Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
            Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SaveAndContinueToolStripButton, Me.SaveAndExitToolStripButton, Me.SaveAndConfirmToolStripButton, Me.DeleteToolStripButton, Me.CloseToolstripButton})
            Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
            Me.ToolStrip1.Name = "ToolStrip1"
            Me.ToolStrip1.Padding = New System.Windows.Forms.Padding(0, 0, 2, 0)
            Me.ToolStrip1.Size = New System.Drawing.Size(1005, 25)
            Me.ToolStrip1.TabIndex = 0
            Me.ToolStrip1.Text = "ToolStrip1"
            '
            'SaveAndContinueToolStripButton
            '
            Me.SaveAndContinueToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
            Me.SaveAndContinueToolStripButton.Image = Global.Hepsa.Core.My.Resources.Resources.SaveAndContinue
            Me.SaveAndContinueToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.SaveAndContinueToolStripButton.Name = "SaveAndContinueToolStripButton"
            Me.SaveAndContinueToolStripButton.Size = New System.Drawing.Size(23, 22)
            Me.SaveAndContinueToolStripButton.Text = "ثبت و ادامه"
            '
            'SaveAndExitToolStripButton
            '
            Me.SaveAndExitToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
            Me.SaveAndExitToolStripButton.Image = Global.Hepsa.Core.My.Resources.Resources.save
            Me.SaveAndExitToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.SaveAndExitToolStripButton.Name = "SaveAndExitToolStripButton"
            Me.SaveAndExitToolStripButton.Size = New System.Drawing.Size(23, 22)
            Me.SaveAndExitToolStripButton.Text = "ثبت و خروج"
            '
            'SaveAndConfirmToolStripButton
            '
            Me.SaveAndConfirmToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
            Me.SaveAndConfirmToolStripButton.Image = Global.Hepsa.Core.My.Resources.Resources.ConfirmVoucher
            Me.SaveAndConfirmToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.SaveAndConfirmToolStripButton.Name = "SaveAndConfirmToolStripButton"
            Me.SaveAndConfirmToolStripButton.Size = New System.Drawing.Size(23, 22)
            Me.SaveAndConfirmToolStripButton.Text = "ثبت و تایید"
            Me.SaveAndConfirmToolStripButton.Visible = False
            '
            'DeleteToolStripButton
            '
            Me.DeleteToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
            Me.DeleteToolStripButton.Image = Global.Hepsa.Core.My.Resources.Resources.Delete
            Me.DeleteToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.DeleteToolStripButton.Name = "DeleteToolStripButton"
            Me.DeleteToolStripButton.Size = New System.Drawing.Size(23, 22)
            Me.DeleteToolStripButton.Text = "حذف"
            '
            'CloseToolstripButton
            '
            Me.CloseToolstripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
            Me.CloseToolstripButton.Image = Global.Hepsa.Core.My.Resources.Resources.Close
            Me.CloseToolstripButton.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.CloseToolstripButton.Name = "CloseToolstripButton"
            Me.CloseToolstripButton.Size = New System.Drawing.Size(23, 22)
            Me.CloseToolstripButton.Text = "بستن"
            '
            'BaseEntityForm2
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 23.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(1005, 450)
            Me.Controls.Add(Me.ToolStrip1)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
            Me.Margin = New System.Windows.Forms.Padding(7, 9, 7, 9)
            Me.Name = "BaseEntityForm2"
            Me.ToolStrip1.ResumeLayout(False)
            Me.ToolStrip1.PerformLayout()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents SaveAndContinueToolStripButton As System.Windows.Forms.ToolStripButton
        Friend WithEvents SaveAndExitToolStripButton As System.Windows.Forms.ToolStripButton
        Friend WithEvents DeleteToolStripButton As System.Windows.Forms.ToolStripButton
        Friend WithEvents CloseToolstripButton As System.Windows.Forms.ToolStripButton
        Protected WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
        Friend WithEvents SaveAndConfirmToolStripButton As System.Windows.Forms.ToolStripButton
    End Class
End Namespace