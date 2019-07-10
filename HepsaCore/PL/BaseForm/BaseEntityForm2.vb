Imports Hepsa.Core.Common
Imports Hepsa.Core.My.Resources
Imports Microsoft.VisualBasic.CompilerServices
Imports System
Imports System.Collections
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Diagnostics
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms

Namespace PL
    Public Class BaseEntityForm2

        Public Sub New(ByVal DataTable As DataTable)
            MyBase.New(enmFormType.ToolStripForm, DataTable)
            InitializeComponent()
            MakeClass()
        End Sub

        Public Sub New(ByVal State As BaseEntityParentForm.enmState, ByVal DataTable As DataTable, ByVal Key As Object)
            MyBase.New(enmFormType.ToolStripForm, State, DataTable, Key)
            InitializeComponent()
            MakeClass()
        End Sub

        Public Sub New()
            InitializeComponent()
            MakeClass()
        End Sub

        Private Sub MakeClass()
            MyBase.ShowStackFormWhenFormClosed = True
            MyBase.SaveAndContinueButton = Me.SaveAndContinueToolStripButton
            MyBase.SaveAndExitButton = Me.SaveAndExitToolStripButton
            MyBase.DeleteButton = Me.DeleteToolStripButton
            MyBase.CloseButton = Me.CloseToolstripButton
        End Sub

        Private Sub BaseEntityForm2_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
            If Common.ApplicationInfo.MainForm IsNot Nothing AndAlso Common.ApplicationInfo.MainForm.HasChildren Then
                For Each ctrl As Control In Common.ApplicationInfo.MainForm.Controls
                    If TypeOf ctrl Is Panel Then
                        Common.ApplicationInfo.MainForm.Text = Common.ApplicationInfo.ProgramName
                        Exit For
                    End If
                Next
            End If
        End Sub

        ' Properties
        'Friend Overridable Property CloseToolstripButton() As ToolStripButton
        '    Get
        '        Return Me._CloseToolstripButton
        '    End Get
        '    Set(ByVal WithEventsValue As ToolStripButton)
        '        Me._CloseToolstripButton = WithEventsValue
        '    End Set
        'End Property

        'Friend Overridable Property DeleteToolStripButton() As ToolStripButton
        '    Get
        '        Return Me._DeleteToolStripButton
        '    End Get
        '    Set(ByVal WithEventsValue As ToolStripButton)
        '        Me._DeleteToolStripButton = WithEventsValue
        '    End Set
        'End Property

        'Friend Overridable Property SaveAndConfirmToolStripButton() As ToolStripButton
        '    Get
        '        Return Me._SaveAndConfirmToolStripButton
        '    End Get
        '    Set(ByVal WithEventsValue As ToolStripButton)
        '        Me._SaveAndConfirmToolStripButton = WithEventsValue
        '    End Set
        'End Property

        'Friend Overridable Property SaveAndContinueToolStripButton() As ToolStripButton
        '    Get
        '        Return Me._SaveAndContinueToolStripButton
        '    End Get
        '    Set(ByVal WithEventsValue As ToolStripButton)
        '        Me._SaveAndContinueToolStripButton = WithEventsValue
        '    End Set
        'End Property

        'Friend Overridable Property SaveAndExitToolStripButton() As ToolStripButton
        '    Get
        '        Return Me._SaveAndExitToolStripButton
        '    End Get
        '    Set(ByVal WithEventsValue As ToolStripButton)
        '        Me._SaveAndExitToolStripButton = WithEventsValue
        '    End Set
        'End Property

        'Protected Overridable Property ToolStrip1() As ToolStrip
        '    Get
        '        Return Me._ToolStrip1
        '    End Get
        '    Set(ByVal WithEventsValue As ToolStrip)
        '        Me._ToolStrip1 = WithEventsValue
        '    End Set
        'End Property

    End Class
End Namespace