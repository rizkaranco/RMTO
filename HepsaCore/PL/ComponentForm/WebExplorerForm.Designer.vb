﻿Namespace PL
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class WebExplorerForm
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
            Me.WebBrowser = New System.Windows.Forms.WebBrowser
            Me.SuspendLayout()
            '
            'WebBrowser
            '
            Me.WebBrowser.Dock = System.Windows.Forms.DockStyle.Fill
            Me.WebBrowser.Location = New System.Drawing.Point(0, 0)
            Me.WebBrowser.MinimumSize = New System.Drawing.Size(20, 20)
            Me.WebBrowser.Name = "WebBrowser"
            Me.WebBrowser.Size = New System.Drawing.Size(755, 454)
            Me.WebBrowser.TabIndex = 0
            '
            'WebExplorerForm
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(755, 454)
            Me.Controls.Add(Me.WebBrowser)
            Me.Name = "WebExplorerForm"
            Me.Text = "راهنما"
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents WebBrowser As System.Windows.Forms.WebBrowser


    End Class
End Namespace