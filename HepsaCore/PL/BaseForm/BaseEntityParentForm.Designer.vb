Namespace PL
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class BaseEntityParentForm
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
            Me.ToolTip1 = New System.Windows.Forms.ToolTip()
            Me.SuspendLayout()
            '
            'BaseEntityParentForm
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 23.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(964, 428)
            Me.Font = New System.Drawing.Font("B Mitra", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
            Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
            Me.Name = "BaseEntityParentForm"
            Me.ShowInTaskbar = True
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    End Class
End Namespace