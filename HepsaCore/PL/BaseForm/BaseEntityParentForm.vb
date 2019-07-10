Namespace PL
    Public Class BaseEntityParentForm

        Public Enum enmState
            Edit = 1
            View = 2
        End Enum

        Public Enum enmFormType
            ToolStripForm
            ButtonForm
        End Enum

        Protected Enum enmFormState
            Add = 0
            Edit = 1
            View = 2
            UnKnown = 3
        End Enum

        Private Structure FileObject
            Dim File() As Byte
            Dim FileExtention As String
        End Structure

        Private _File As Dictionary(Of String, FileObject)

        Private _DeleteButton As Object
        Private _SaveAndExitButton As Object
        Private _SaveAndContinueButton As Object
        Private _CloseButton As Object
        Private _ConfirmOnClose As Boolean
        Private _FormType As enmFormType
        Private _FormState As Nullable(Of enmFormState)
        Private _DataTable As DataTable
        Private _Key As Object
        Private _SetFocus As Boolean
        Private _ExtraFieldTemplateComboBox As ComboBox
        Private _ExtraFieldTemplateTabPage As TabPage
        Private _TabControl As TabControl
        Private _ExtraFieldPanel As Panel
        Private _TableID As Integer
        Private Shared Y As Integer = 20
        Private _LastExtraFieldTemplateID As Integer
        Private _EditAndClose As Boolean = True
        Private _LastKey As Object
        Private _EntityLogBody As String = String.Empty

#Region "Constractor"

        Public Sub New(ByVal FormType As enmFormType, ByVal DataTable As DataTable)
            InitializeComponent()
            Me._FormState = enmFormState.Add
            Me._DataTable = DataTable
            Me._FormType = FormType
        End Sub

        Public Sub New(ByVal FormType As enmFormType, ByVal State As enmState, ByVal DataTable As DataTable, ByVal Key As Object)
            InitializeComponent()
            Me._FormState = State
            Me._DataTable = DataTable
            Me.Key = Key
            Me._FormType = FormType
        End Sub

        Public Sub New()
            InitializeComponent()
            Me._FormState = enmFormState.UnKnown
            Me._DataTable = Nothing
            Me.Key = Nothing
        End Sub

#End Region

#Region "Buttons"

        Protected Overridable Sub Insert()
        End Sub

        Protected Overridable Sub Edit()
        End Sub

        Protected Overridable Sub Delete()
        End Sub

        Protected Overridable Sub ShowForm()
        End Sub

        Protected Property DeleteButton() As Object
            Get
                Return Me._DeleteButton
            End Get
            Set(ByVal value As Object)
                If Me._FormType = enmFormType.ButtonForm AndAlso TypeOf value Is Button Then
                    Me._DeleteButton = value
                    Dim KeyConvertor As New KeysConverter
                    ToolTip1.SetToolTip(Me._DeleteButton, Me._DeleteButton.Text + " : " + KeyConvertor.ConvertToString(Int32.Parse(My.Settings.DeleteButton)))
                    AddHandler DirectCast(Me._DeleteButton, Button).Click, AddressOf DeleteButtonEvent
                ElseIf Me._FormType = enmFormType.ToolStripForm AndAlso TypeOf value Is ToolStripButton Then
                    Me._DeleteButton = value
                    Dim KeyConvertor As New KeysConverter
                    Me._DeleteButton.ToolTipText += " : " + KeyConvertor.ConvertToString(Int32.Parse(My.Settings.DeleteButton))
                    AddHandler DirectCast(Me._DeleteButton, ToolStripButton).Click, AddressOf DeleteButtonEvent
                End If
            End Set
        End Property

        Protected Property SaveAndExitButton() As Object
            Get
                Return Me._SaveAndExitButton
            End Get
            Set(ByVal value As Object)
                If Me._FormType = enmFormType.ButtonForm AndAlso TypeOf value Is Button Then
                    Me._SaveAndExitButton = value
                    Dim KeyConvertor As New KeysConverter
                    ToolTip1.SetToolTip(Me._SaveAndExitButton, Me._SaveAndExitButton.Text + " : " + KeyConvertor.ConvertToString(Int32.Parse(My.Settings.SaveAndCloseButton)))
                    AddHandler DirectCast(Me._SaveAndExitButton, Button).Click, AddressOf SaveAndExitButtonEvent
                End If
                If Me._FormType = enmFormType.ToolStripForm AndAlso TypeOf value Is ToolStripButton Then
                    Me._SaveAndExitButton = value
                    Dim KeyConvertor As New KeysConverter
                    Me._SaveAndExitButton.TooltipText += " : " + KeyConvertor.ConvertToString(Int32.Parse(My.Settings.SaveAndCloseButton))
                    AddHandler DirectCast(Me._SaveAndExitButton, ToolStripButton).Click, AddressOf SaveAndExitButtonEvent
                End If
            End Set
        End Property

        Protected Property SaveAndContinueButton() As Object
            Get
                Return Me._SaveAndContinueButton
            End Get
            Set(ByVal value As Object)
                If Me._FormType = enmFormType.ButtonForm AndAlso TypeOf value Is Button Then
                    Me._SaveAndContinueButton = value
                    Dim KeyConvertor As New KeysConverter
                    ToolTip1.SetToolTip(Me._SaveAndContinueButton, Me._SaveAndContinueButton.Text + " : " + KeyConvertor.ConvertToString(Int32.Parse(My.Settings.SaveAndContinueButton)))
                    AddHandler DirectCast(Me._SaveAndContinueButton, Button).Click, AddressOf SaveAndContinueButtonEvent
                End If
                If Me._FormType = enmFormType.ToolStripForm AndAlso TypeOf value Is ToolStripButton Then
                    Me._SaveAndContinueButton = value
                    Dim KeyConvertor As New KeysConverter
                    Me._SaveAndContinueButton.ToolTipText += " : " + KeyConvertor.ConvertToString(Int32.Parse(My.Settings.SaveAndContinueButton))
                    AddHandler DirectCast(Me._SaveAndContinueButton, ToolStripButton).Click, AddressOf SaveAndContinueButtonEvent
                End If
            End Set
        End Property

        Protected Property CloseButton() As Object
            Get
                Return Me._CloseButton
            End Get
            Set(ByVal value As Object)
                If Me._FormType = enmFormType.ButtonForm AndAlso TypeOf value Is Button Then
                    Me._CloseButton = value
                    Dim KeyConvertor As New KeysConverter
                    ToolTip1.SetToolTip(Me._CloseButton, Me._CloseButton.Text + " : " + KeyConvertor.ConvertToString(Int32.Parse(My.Settings.CloseButton)))
                    AddHandler DirectCast(Me._CloseButton, Button).Click, AddressOf CloseButtonEvent
                End If
                If Me._FormType = enmFormType.ToolStripForm AndAlso TypeOf value Is ToolStripButton Then
                    Me._CloseButton = value
                    Dim KeyConvertor As New KeysConverter
                    Me._CloseButton.ToolTipText += " : " + KeyConvertor.ConvertToString(Int32.Parse(My.Settings.CloseButton))
                    AddHandler DirectCast(Me._CloseButton, ToolStripButton).Click, AddressOf CloseButtonEvent
                End If
            End Set
        End Property

        Private Sub DeleteButtonEvent(ByVal sender As Object, ByVal e As EventArgs)
            Dim LogFactory As New Hepsa.Core.BLL.BLLLog_TFactory
            Dim LogEntity As New Hepsa.Core.BLL.BLLLog_T
            Try
                LogEntity.Date_nvc = LogFactory.ServerJalaliDate
                LogEntity.Time_nvc = LogFactory.ServerTime
                LogEntity.IPAddress_nvc = Hepsa.Core.Common.ApplicationInfo.IpAddress
                LogEntity.MacAddress_nvc = Hepsa.Core.Common.ApplicationInfo.MacAddress
                LogEntity.UserName_nvc = Hepsa.Core.Common.CurrentUser.User.UserName_nvc
                LogEntity.FormText_nvc = IIf(String.IsNullOrEmpty(Me.Text), Me.Name, Me.Text)
                LogEntity.ActionID_int = Hepsa.Core.BLL.BLLAction_T.Actions.Delete
                LogFactory.BeginProc()
                LogEntity.Body_nvc = Me._EntityLogBody
                Me.Delete()

                If String.IsNullOrEmpty(LogEntity.Body_nvc) = False Then
                    LogFactory.Insert(LogEntity)
                End If

                LogFactory.CommitProc()
            Catch ex As System.Exception
                LogFactory.RollBackProc()
                Common.MessageBox.ErrorMessage(ex.Message)
            End Try
        End Sub

        Public Sub SaveAndContinueButtonEvent(ByVal sender As Object, ByVal e As EventArgs)
            Dim LogFactory As New Hepsa.Core.BLL.BLLLog_TFactory
            Dim LogEntity As New Hepsa.Core.BLL.BLLLog_T
            Try
                LogEntity.Date_nvc = LogFactory.ServerJalaliDate
                LogEntity.Time_nvc = LogFactory.ServerTime
                LogEntity.IPAddress_nvc = Hepsa.Core.Common.ApplicationInfo.IpAddress
                LogEntity.MacAddress_nvc = Hepsa.Core.Common.ApplicationInfo.MacAddress
                LogEntity.UserName_nvc = Hepsa.Core.Common.CurrentUser.User.UserName_nvc
                LogEntity.FormText_nvc = IIf(String.IsNullOrEmpty(Me.Text), Me.Name, Me.Text)
                LogFactory.BeginProc()
                Select Case Me.State
                    Case enmFormState.Add
                        LogEntity.Body_nvc = Me.MakeLog(Me)
                        Me.Insert()
                        LogEntity.ActionID_int = Hepsa.Core.BLL.BLLAction_T.Actions.Add
                    Case enmFormState.Edit
                        Dim NewLogBody As String = Me.MakeLog(Me)
                        Me.Edit()
                        LogEntity.ActionID_int = Hepsa.Core.BLL.BLLAction_T.Actions.Edit
                        If Me._EntityLogBody <> NewLogBody Then
                            LogEntity.Body_nvc = String.Format("{0} <br /> {1} <br /> {2} <br /> {3}", "قبل از ویرایش", String.Format("<table border='1' style='direction: rtl;'>{0}</table>", Me._EntityLogBody), "بعد از ویرایش", String.Format("<table border='1' style='direction: rtl;'>{0}</table>", NewLogBody))
                        End If
                End Select
                If String.IsNullOrEmpty(LogEntity.Body_nvc) = False Then
                    LogFactory.Insert(LogEntity)
                End If

                LogFactory.CommitProc()
            Catch ex As System.Exception
                LogFactory.RollBackProc()
                Common.MessageBox.ErrorMessage(ex.Message)
            Finally
                Me.SetFocus(Me)
            End Try
        End Sub

        Private Sub SaveAndExitButtonEvent(ByVal sender As Object, ByVal e As EventArgs)
            Dim LogFactory As New Hepsa.Core.BLL.BLLLog_TFactory
            Dim LogEntity As New Hepsa.Core.BLL.BLLLog_T
            Try
                LogEntity.Date_nvc = LogFactory.ServerJalaliDate
                LogEntity.Time_nvc = LogFactory.ServerTime
                LogEntity.IPAddress_nvc = Hepsa.Core.Common.ApplicationInfo.IpAddress
                LogEntity.MacAddress_nvc = Hepsa.Core.Common.ApplicationInfo.MacAddress
                LogEntity.UserName_nvc = Hepsa.Core.Common.CurrentUser.User.UserName_nvc
                LogEntity.FormText_nvc = IIf(String.IsNullOrEmpty(Me.Text), Me.Name, Me.Text)
                LogFactory.BeginProc()
                Select Case Me.State
                    Case enmFormState.Add
                        LogEntity.Body_nvc = Me.MakeLog(Me)
                        Me.Insert()
                        LogEntity.ActionID_int = Hepsa.Core.BLL.BLLAction_T.Actions.Add
                    Case enmFormState.Edit
                        Dim NewLogBody As String = Me.MakeLog(Me)
                        Me.Edit()
                        LogEntity.ActionID_int = Hepsa.Core.BLL.BLLAction_T.Actions.Edit
                        If Me._EntityLogBody <> NewLogBody Then
                            LogEntity.Body_nvc = String.Format("{0} <br /> {1} <br /> {2} <br /> {3}", "قبل از ویرایش", String.Format("<table border='1' style='direction: rtl;'>{0}</table>", Me._EntityLogBody), "بعد از ویرایش", String.Format("<table border='1' style='direction: rtl;'>{0}</table>", NewLogBody))
                        End If
                End Select
                If String.IsNullOrEmpty(LogEntity.Body_nvc) = False Then
                    LogFactory.Insert(LogEntity)
                End If

                LogFactory.CommitProc()
                If Me.State = enmFormState.Add Then
                    Me.Close()
                ElseIf Me.State = enmFormState.Edit AndAlso Me.EditAndClose Then
                    Me.Close()
                End If
            Catch ex As System.Exception
                LogFactory.RollBackProc()
                Common.MessageBox.ErrorMessage(ex.Message)
            Finally
                Me.SetFocus(Me)
            End Try
        End Sub

        Protected Property ConfirmOnClose() As Boolean
            Get
                Return Me._ConfirmOnClose
            End Get
            Set(ByVal value As Boolean)
                Me._ConfirmOnClose = value
            End Set
        End Property


        Private Sub CloseButtonEvent(ByVal sender As Object, ByVal e As EventArgs)
            Me.Close()
        End Sub

#End Region

#Region "Form"

        Protected Property EditAndClose() As Boolean
            Get
                Return Me._EditAndClose
            End Get
            Set(ByVal value As Boolean)
                Me._EditAndClose = value
            End Set
        End Property

        Protected Property State() As enmFormState
            Get
                Return _FormState
            End Get
            Set(ByVal value As enmFormState)
                Me._FormState = value
                Me.GotoState()
            End Set
        End Property

        Public ReadOnly Property DataTable() As DataTable
            Get
                Return _DataTable
            End Get
        End Property

        Protected Property TableID() As Integer
            Get
                Return Me._TableID
            End Get
            Set(ByVal value As Integer)
                Me._TableID = value
            End Set
        End Property

        Public Property Key() As Object
            Get
                Return Me._Key
            End Get
            Set(ByVal value As Object)
                Me._LastKey = Me._Key
                Me._Key = value
            End Set
        End Property

        Private Sub BaseEntityParentForm_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
            If e.KeyCode = My.Settings.SaveAndContinueButton AndAlso Me._SaveAndContinueButton IsNot Nothing AndAlso Me._SaveAndContinueButton.Enabled = True AndAlso Me._SaveAndContinueButton IsNot Nothing AndAlso Me._SaveAndContinueButton.Visible = True Then
                Me.SaveAndContinueButtonEvent(sender, e)
            ElseIf e.KeyCode = My.Settings.SaveAndCloseButton AndAlso Me._SaveAndExitButton IsNot Nothing AndAlso Me._SaveAndExitButton.Enabled = True AndAlso Me._SaveAndExitButton IsNot Nothing AndAlso Me._SaveAndExitButton.Visible = True Then
                Me.SaveAndExitButtonEvent(sender, e)
            End If
        End Sub

        Private Sub BaseEntityParentForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
            Try
                Me.Visible = False
                Me.GotoState()
                Me.ClearForm(Me)
                If State <> enmFormState.Add AndAlso Key IsNot Nothing Then
                    Me.ShowForm()
                    Me._EntityLogBody = Me.MakeLog(Me)
                End If
                Me.Visible = True

                If Me._DeleteButton IsNot Nothing Then
                    Me._DeleteButton.Visible = False
                End If

                Me.SetFocus(Me)
            Catch ex As System.Exception
                Common.MessageBox.ErrorMessage(ex.Message)
                Me.Close()
            End Try
        End Sub

        Private Sub GotoState()
            Select Case State
                Case enmFormState.Add
                    Me._DeleteButton.Visible = False
                    Me._SaveAndContinueButton.Visible = True
                    Me._SaveAndExitButton.Visible = True
                    Me._SaveAndContinueButton.Enabled = True
                    Me._SaveAndExitButton.Enabled = True
                    If Me._FormType = enmFormType.ButtonForm Then
                        Me._CloseButton.Location = Me._DeleteButton.Location
                    End If
                    Dim KeyConvertor As New KeysConverter
                    If TypeOf _SaveAndExitButton Is ToolStripButton Then
                        Me._SaveAndExitButton.ToolTipText = My.Resources.Captions.SaveAndClose + " : " + KeyConvertor.ConvertToString(Int32.Parse(My.Settings.SaveAndCloseButton))
                    Else
                        Me._SaveAndExitButton.Text = My.Resources.Captions.SaveAndClose
                        ToolTip1.SetToolTip(Me._SaveAndExitButton, My.Resources.Captions.SaveAndClose + " : " + KeyConvertor.ConvertToString(Int32.Parse(My.Settings.SaveAndCloseButton)))
                    End If

                Case enmFormState.Edit
                    Me._DeleteButton.Visible = False 'True
                    Me._SaveAndContinueButton.Visible = False
                    Me._SaveAndExitButton.Visible = True

                    If Me._FormType = enmFormType.ButtonForm Then
                        Me._SaveAndExitButton.Location = Me._SaveAndContinueButton.Location
                    End If
                    Dim KeyConvertor As New KeysConverter
                    If TypeOf _SaveAndExitButton Is ToolStripButton Then
                        Me._SaveAndExitButton.ToolTipText = My.Resources.Captions.Save + " : " + KeyConvertor.ConvertToString(Int32.Parse(My.Settings.SaveAndCloseButton))
                    Else
                        Me._SaveAndExitButton.Text = My.Resources.Captions.Save
                        ToolTip1.SetToolTip(Me._SaveAndExitButton, My.Resources.Captions.Save + " : " + KeyConvertor.ConvertToString(Int32.Parse(My.Settings.SaveAndCloseButton)))
                    End If

                Case enmFormState.View
                    Me._DeleteButton.Visible = False 'True
                    Me._SaveAndContinueButton.Visible = False
                    Me._SaveAndExitButton.Visible = False

                    If Me._FormType = enmFormType.ButtonForm Then
                        Me._DeleteButton.Location = Me._SaveAndContinueButton.Location
                        Me._CloseButton.Location = Me._SaveAndExitButton.Location
                    End If
            End Select
        End Sub

#End Region

#Region "ExtraField"

        Protected Property ExtraFieldComboBox() As ComboBox
            Get
                Return Me._ExtraFieldTemplateComboBox
            End Get
            Set(ByVal value As ComboBox)
                Me._ExtraFieldTemplateComboBox = value
                Me.ExtraFieldAddHandler()
            End Set
        End Property

        Protected Property ExtraFieldTabPage() As TabPage
            Get
                Return Me._ExtraFieldTemplateTabPage
            End Get
            Set(ByVal value As TabPage)
                Me._ExtraFieldTemplateTabPage = value
                Me.ExtraFieldAddHandler()
            End Set
        End Property

        Protected Property TabControl() As TabControl
            Get
                Return Me._TabControl
            End Get
            Set(ByVal value As TabControl)
                Me._TabControl = value
                Me.ExtraFieldAddHandler()
            End Set
        End Property

        Protected Property ExtraFieldPanel() As Panel
            Get
                Return Me._ExtraFieldPanel
            End Get
            Set(ByVal value As Panel)
                Me._ExtraFieldPanel = value
                Me._ExtraFieldPanel.BorderStyle = BorderStyle.FixedSingle
                Me._ExtraFieldPanel.AutoScroll = True
                Me.ExtraFieldAddHandler()
            End Set
        End Property

        Private Sub ExtraFieldTemplateComboBox_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
            Dim Combo As ComboBox = DirectCast(sender, ComboBox)
            If Combo.SelectedValue IsNot Nothing Then
                If Me.TabControl.Contains(Me.ExtraFieldTabPage) = False Then
                    Me.TabControl.TabPages.Add(Me._ExtraFieldTemplateTabPage)
                End If
                If Combo.SelectedValue <> Me._LastExtraFieldTemplateID OrElse (Key IsNot Nothing AndAlso Me._LastKey IsNot Nothing AndAlso Key.Equals(Me._LastKey) = False) Then
                    Dim ExtraFieldTemplateKey As New BLL.BLLExtraFieldTemplate_TKeys
                    ExtraFieldTemplateKey.ExtraFieldTemplateID_bint = Combo.SelectedValue
                    Me.MakeExtraField(Me.ExtraFieldPanel, ExtraFieldTemplateKey)
                    Me._LastKey = Key
                End If
            Else
                If Me.TabControl.TabPages.Contains(Me.ExtraFieldTabPage) = True Then
                    Me.TabControl.TabPages.Remove(Me.ExtraFieldTabPage)
                End If
            End If
        End Sub

        Private Sub ExtraFieldTemplateComboBox_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs)
            Dim Combo As ComboBox = DirectCast(sender, ComboBox)
            If Combo.DataSource IsNot Nothing Then
                If Combo.Text = String.Empty Then
                    Combo.SelectedIndex = -1
                    ExtraFieldTemplateComboBox_SelectedValueChanged(sender, e)
                Else
                    Dim dr() As DataRow = DirectCast(Combo.DataSource, DataTable).Select("ExtraFieldTemplateID_bintExtraFieldTemplate_nvc" + " = '" + Combo.Text.Replace("'", "''") + "'")
                    If dr.Length > 0 Then
                        Combo.SelectedValue = dr(0).Item(BLL.BLLExtraFieldTemplate_T.ExtraFieldTemplate_TField.ExtraFieldTemplateID_bint.ToString)
                    Else
                        Combo.SelectedIndex = -1
                    End If
                End If
            End If
        End Sub

        Private Sub ExtraFieldAddHandler()
            If Me.ExtraFieldComboBox IsNot Nothing AndAlso Me.TabControl IsNot Nothing AndAlso Me.ExtraFieldPanel IsNot Nothing AndAlso Me.ExtraFieldTabPage IsNot Nothing Then
                AddHandler Me._ExtraFieldTemplateComboBox.SelectedValueChanged, AddressOf ExtraFieldTemplateComboBox_SelectedValueChanged
                AddHandler Me._ExtraFieldTemplateComboBox.SelectedIndexChanged, AddressOf ExtraFieldTemplateComboBox_SelectedValueChanged
                AddHandler Me._ExtraFieldTemplateComboBox.TextChanged, AddressOf ExtraFieldTemplateComboBox_TextChanged
            End If
        End Sub

        Private Sub DeleteFileButton_Click(ByVal sender As Object, ByVal e As EventArgs)
            If Common.MessageBox.ConfirmDeleteMessage = True Then
                Me._File.Remove(DirectCast(sender, Button).Tag)
                Dim button As Button = DirectCast(sender, Button)
                DirectCast(Me.ExtraFieldPanel.Controls(button.Tag.ToString + "DeleteButton"), Button).Enabled = False
                DirectCast(Me.ExtraFieldPanel.Controls(button.Tag.ToString + "SaveButton"), Button).Enabled = False
            End If
        End Sub

        Private Sub SaveFileButton_Click(ByVal sender As Object, ByVal e As EventArgs)
            Try
                Dim button As Button = DirectCast(sender, Button)
                If Me._File.ContainsKey(button.Tag.ToString) Then
                    If Me._File.Item(button.Tag).Equals(Nothing) = False Then
                        Dim FileExtention As String
                        If Me._File.Item(button.Tag).FileExtention.ToString().StartsWith(".") Then
                            FileExtention = Me._File.Item(button.Tag).FileExtention.ToString.Substring(1)
                        Else
                            FileExtention = Me._File.Item(button.Tag).FileExtention.ToString
                        End If
                        If String.IsNullOrEmpty(FileExtention) Then
                            FileExtention = "*"
                        End If
                        Dim Path As New SaveFileDialog
                        Path.CheckFileExists = False
                        Path.CheckPathExists = True
                        Path.Filter = "*." + FileExtention + "|" + "*." + FileExtention
                        If Path.ShowDialog = Windows.Forms.DialogResult.OK Then
                            System.IO.File.WriteAllBytes(Path.FileName, Me._File.Item(button.Tag).File)
                        End If
                    End If
                End If
            Catch ex As System.Exception
                Common.MessageBox.ErrorMessage(ex.Message)
            End Try
        End Sub

        Private Sub UploadFileButton_Click(ByVal sender As Object, ByVal e As EventArgs)
            Try
                Dim BrowseFile As New OpenFileDialog
                BrowseFile.Filter = "All Files|*.*"
                BrowseFile.Multiselect = False
                BrowseFile.CheckFileExists = True
                BrowseFile.CheckPathExists = True
                If BrowseFile.ShowDialog = Windows.Forms.DialogResult.OK Then
                    Dim fs As New System.IO.FileStream(BrowseFile.FileName, IO.FileMode.Open)
                    Dim bytes(fs.Length) As Byte
                    fs.Read(bytes, 0, fs.Length)
                    fs.Close()
                    Dim FileInfo As New System.IO.FileInfo(BrowseFile.FileName)
                    Dim File As FileObject
                    File.FileExtention = FileInfo.Extension
                    File.File = bytes
                    If Me._File.ContainsKey(DirectCast(sender, Button).Tag) Then
                        Me._File.Item(DirectCast(sender, Button).Tag) = File
                    Else
                        Me._File.Add(DirectCast(sender, Button).Tag, File)
                        Dim button As Button = DirectCast(sender, Button)
                        DirectCast(Me.ExtraFieldPanel.Controls(button.Tag.ToString + "DeleteButton"), Button).Enabled = True
                        DirectCast(Me.ExtraFieldPanel.Controls(button.Tag.ToString + "SaveButton"), Button).Enabled = True
                    End If
                End If
            Catch ex As System.Exception
                Common.MessageBox.ErrorMessage(ex.Message)
            End Try
        End Sub

        Private Sub MakeExtraField(ByRef Container As Panel, ByVal ExtraFieldTemplate As BLL.BLLExtraFieldTemplate_TKeys)
            Try
                If ExtraFieldTemplate IsNot Nothing AndAlso (ExtraFieldTemplate.ExtraFieldTemplateID_bint <> Me._LastExtraFieldTemplateID OrElse (Key IsNot Nothing AndAlso Me._LastKey IsNot Nothing AndAlso Key.Equals(Me._LastKey) = False)) Then
                    Me._File = New Dictionary(Of String, FileObject)

                    Y = 10
                    For Each Ctrl As Control In Container.Controls
                        If Me.EnglishControls.ContainsKey(Ctrl.Name) Then
                            Me.EnglishControls.Remove(Ctrl.Name)
                        End If
                    Next
                    Container.Controls.Clear()
                    Dim ExtraFieldFactory As New BLL.BLLExtraField_TFactory
                    Dim ExtraFieldValueFactory As New BLL.BLLExtraFieldValue_TFactory
                    Dim ExtraFieldEntity As List(Of BLL.BLLExtraField_T) = ExtraFieldFactory.GetAllBy(BLL.BLLExtraField_T.ExtraField_TField.ExtraFieldTemplateID_bint, ExtraFieldTemplate.ExtraFieldTemplateID_bint)
                    Dim ExtraFieldValueDataTable As New DataTable

                    If Key IsNot Nothing Then
                        Dim PropertyType As Type = Key.GetType
                        Dim PropertyInfo() As System.Reflection.PropertyInfo = PropertyType.GetProperties

                        Dim Condition As String
                        Condition = BLL.BLLExtraFieldValue_T.ExtraFieldValue_TField.TableID_bint.ToString + " = " + TableID.ToString + " And "
                        Condition += BLL.BLLExtraFieldValue_T.ExtraFieldValue_TField.ParentID_nvc.ToString + " = N'" + PropertyInfo(0).GetValue(Key, Nothing).ToString.Replace("'", "''") + "'"
                        ExtraFieldValueFactory.GetAllByCondition(Condition, ExtraFieldValueDataTable)
                    End If

                    For index As Int32 = 0 To ExtraFieldEntity.Count - 1
                        Dim dr() As DataRow
                        If ExtraFieldValueDataTable.Columns.Count > 0 Then
                            dr = ExtraFieldValueDataTable.Select(BLL.BLLExtraFieldValue_T.ExtraFieldValue_TField.ExtraFieldID_bint.ToString + " = " + ExtraFieldEntity.Item(index).ExtraFieldID_bint.ToString)
                        End If
                        Dim CaptionLabel As New Label
                        CaptionLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
                        CaptionLabel.Name = ExtraFieldEntity.Item(index).ExtraFieldID_bint.ToString + "Label"
                        CaptionLabel.Text = ExtraFieldEntity.Item(index).ExtraField_nvc.ToString

                        If ExtraFieldEntity.Item(index).ExtraFieldDataTypeID_tint = 1 Then
                            Dim NumericTextBox As New HamrahanSystem.TextBox.NumericTextBox
                            NumericTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
                            NumericTextBox.Name = ExtraFieldEntity.Item(index).ExtraFieldID_bint
                            NumericTextBox.MaxWholeDigits = 30
                            NumericTextBox.MaxDecimalPlaces = 5
                            CalculateControlLocationAndSize(Container, NumericTextBox, CaptionLabel)
                            If dr IsNot Nothing AndAlso dr.Length > 0 Then
                                NumericTextBox.Text = dr(0).Item(BLL.BLLExtraFieldValue_T.ExtraFieldValue_TField.Value_nvc.ToString).ToString
                            End If
                            Container.Controls.Add(CaptionLabel)
                            Container.Controls.Add(NumericTextBox)
                            CaptionLabel.SendToBack()
                            NumericTextBox.BringToFront()
                        ElseIf ExtraFieldEntity.Item(index).ExtraFieldDataTypeID_tint = 2 Then
                            Dim TextBox As New TextBox
                            TextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
                            TextBox.Name = ExtraFieldEntity.Item(index).ExtraFieldID_bint
                            TextBox.MaxLength = 100
                            CalculateControlLocationAndSize(Container, TextBox, CaptionLabel)
                            If dr IsNot Nothing AndAlso dr.Length > 0 Then
                                TextBox.Text = dr(0).Item(BLL.BLLExtraFieldValue_T.ExtraFieldValue_TField.Value_nvc.ToString).ToString
                            End If
                            Container.Controls.Add(CaptionLabel)
                            Container.Controls.Add(TextBox)
                            CaptionLabel.SendToBack()
                            TextBox.BringToFront()
                        ElseIf ExtraFieldEntity.Item(index).ExtraFieldDataTypeID_tint = 3 Then

                        ElseIf ExtraFieldEntity.Item(index).ExtraFieldDataTypeID_tint = 4 Then
                            Dim CurrencyTextBox As New HamrahanSystem.TextBox.CurrencyTextBox
                            CurrencyTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
                            CurrencyTextBox.Name = ExtraFieldEntity.Item(index).ExtraFieldID_bint
                            CurrencyTextBox.DigitsInGroup = 3
                            CurrencyTextBox.MaxDecimalPlaces = 0
                            CurrencyTextBox.MaxWholeDigits = 20
                            CalculateControlLocationAndSize(Container, CurrencyTextBox, CaptionLabel)
                            If dr IsNot Nothing AndAlso dr.Length > 0 Then
                                CurrencyTextBox.Text = dr(0).Item(BLL.BLLExtraFieldValue_T.ExtraFieldValue_TField.Value_nvc.ToString).ToString
                            End If
                            Container.Controls.Add(CaptionLabel)
                            Container.Controls.Add(CurrencyTextBox)
                            CaptionLabel.SendToBack()
                            CurrencyTextBox.BringToFront()
                        ElseIf ExtraFieldEntity.Item(index).ExtraFieldDataTypeID_tint = 5 Then
                            Dim CheckBox As New CheckBox
                            CheckBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
                            CheckBox.Text = String.Empty
                            CheckBox.Name = ExtraFieldEntity.Item(index).ExtraFieldID_bint
                            CalculateControlLocationAndSize(Container, CheckBox, CaptionLabel)
                            If dr IsNot Nothing AndAlso dr.Length > 0 Then
                                CheckBox.Checked = Convert.ToBoolean(dr(0).Item(BLL.BLLExtraFieldValue_T.ExtraFieldValue_TField.Value_nvc.ToString)).ToString
                            End If
                            Container.Controls.Add(CaptionLabel)
                            Container.Controls.Add(CheckBox)
                            CaptionLabel.SendToBack()
                            CheckBox.BringToFront()
                        ElseIf ExtraFieldEntity.Item(index).ExtraFieldDataTypeID_tint = 6 Then
                            Dim DeleteButton As New Button
                            DeleteButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
                            DeleteButton.Name = ExtraFieldEntity.Item(index).ExtraFieldID_bint.ToString + "DeleteButton"
                            DeleteButton.Tag = ExtraFieldEntity.Item(index).ExtraFieldID_bint.ToString
                            DeleteButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
                            DeleteButton.BackgroundImage = My.Resources.Resources.Delete
                            DeleteButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
                            DeleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
                            DeleteButton.Size = New System.Drawing.Size(22, 21)
                            DeleteButton.TabStop = False
                            DeleteButton.UseVisualStyleBackColor = True
                            DeleteButton.Enabled = False
                            Me.ToolTip1.SetToolTip(DeleteButton, My.Resources.Captions.DeleteExtraFieldFile)
                            AddHandler DeleteButton.Click, AddressOf DeleteFileButton_Click

                            Dim SaveButton As New Button
                            SaveButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
                            SaveButton.Name = ExtraFieldEntity.Item(index).ExtraFieldID_bint.ToString + "SaveButton"
                            SaveButton.Tag = ExtraFieldEntity.Item(index).ExtraFieldID_bint.ToString
                            SaveButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
                            SaveButton.BackgroundImage = My.Resources.Resources.Download
                            SaveButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
                            SaveButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
                            SaveButton.Size = New System.Drawing.Size(22, 21)
                            SaveButton.TabStop = False
                            SaveButton.UseVisualStyleBackColor = True
                            SaveButton.Enabled = False
                            Me.ToolTip1.SetToolTip(SaveButton, My.Resources.Captions.SaveExtraFieldFile)
                            AddHandler SaveButton.Click, AddressOf SaveFileButton_Click

                            Dim UploadButton As New Button
                            UploadButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
                            UploadButton.Name = ExtraFieldEntity.Item(index).ExtraFieldID_bint.ToString + "UploadButton"
                            UploadButton.Tag = ExtraFieldEntity.Item(index).ExtraFieldID_bint.ToString
                            UploadButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
                            UploadButton.BackgroundImage = My.Resources.Resources.Upload
                            UploadButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
                            UploadButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
                            UploadButton.Size = New System.Drawing.Size(22, 21)
                            UploadButton.TabStop = False
                            UploadButton.UseVisualStyleBackColor = True
                            Me.ToolTip1.SetToolTip(UploadButton, My.Resources.Captions.UploadExtraFieldFile)
                            AddHandler UploadButton.Click, AddressOf UploadFileButton_Click

                            Me.CalculateControlLocation(Container, DeleteButton, UploadButton, SaveButton, CaptionLabel)
                            If dr IsNot Nothing AndAlso dr.Length > 0 Then
                                Dim Data As FileObject
                                If IsDBNull(dr(0).Item(BLL.BLLExtraFieldValue_T.ExtraFieldValue_TField.Value_vbin.ToString)) = False Then
                                    Data.File = CType(dr(0).Item(BLL.BLLExtraFieldValue_T.ExtraFieldValue_TField.Value_vbin.ToString), Byte()).Clone
                                    Data.FileExtention = dr(0).Item(BLL.BLLExtraFieldValue_T.ExtraFieldValue_TField.FileExtention_nvc.ToString).ToString
                                    Me._File.Add(ExtraFieldEntity.Item(index).ExtraFieldID_bint.ToString, Data)
                                    DeleteButton.Enabled = True
                                    SaveButton.Enabled = True
                                End If
                            End If
                            Container.Controls.Add(CaptionLabel)
                            Container.Controls.Add(UploadButton)
                            Container.Controls.Add(SaveButton)
                            Container.Controls.Add(DeleteButton)
                            CaptionLabel.SendToBack()
                            UploadButton.BringToFront()
                            SaveButton.BringToFront()
                            DeleteButton.BringToFront()
                        ElseIf ExtraFieldEntity.Item(index).ExtraFieldDataTypeID_tint = 7 Then
                            Dim TextBox As New TextBox
                            TextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
                            TextBox.Name = ExtraFieldEntity.Item(index).ExtraFieldID_bint
                            TextBox.MaxLength = 100
                            TextBox.RightToLeft = Windows.Forms.RightToLeft.No
                            TextBox.TextAlign = HorizontalAlignment.Left
                            Me.EnglishControls.Add(TextBox.Name, TextBox)
                            CalculateControlLocationAndSize(Container, TextBox, CaptionLabel)
                            If dr IsNot Nothing AndAlso dr.Length > 0 Then
                                TextBox.Text = dr(0).Item(BLL.BLLExtraFieldValue_T.ExtraFieldValue_TField.Value_nvc.ToString).ToString
                            End If
                            Container.Controls.Add(CaptionLabel)
                            Container.Controls.Add(TextBox)
                            TextBox.BringToFront()
                            CaptionLabel.SendToBack()
                        ElseIf ExtraFieldEntity.Item(index).ExtraFieldDataTypeID_tint = 8 Then
                            Dim TextBox As New TextBox
                            TextBox.BringToFront()
                            TextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
                            TextBox.Name = ExtraFieldEntity.Item(index).ExtraFieldID_bint
                            TextBox.MaxLength = 100
                            TextBox.RightToLeft = Windows.Forms.RightToLeft.No
                            TextBox.TextAlign = HorizontalAlignment.Left
                            Me.EnglishControls.Add(TextBox.Name, TextBox)
                            CalculateControlLocationAndSize(Container, TextBox, CaptionLabel)
                            If dr IsNot Nothing AndAlso dr.Length > 0 Then
                                TextBox.Text = dr(0).Item(BLL.BLLExtraFieldValue_T.ExtraFieldValue_TField.Value_nvc.ToString).ToString
                            End If
                            Container.Controls.Add(CaptionLabel)
                            Container.Controls.Add(TextBox)
                            TextBox.BringToFront()
                            CaptionLabel.SendToBack()
                        ElseIf ExtraFieldEntity.Item(index).ExtraFieldDataTypeID_tint = 9 Then
                            Dim TextBox As New HamrahanSystem.TextBox.NumericTextBox
                            TextBox.BringToFront()
                            TextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
                            TextBox.Name = ExtraFieldEntity.Item(index).ExtraFieldID_bint
                            TextBox.AllowNegative = False
                            TextBox.MaxDecimalPlaces = 0
                            TextBox.MaxWholeDigits = 11
                            TextBox.TextAlign = HorizontalAlignment.Right
                            CalculateControlLocationAndSize(Container, TextBox, CaptionLabel)
                            If dr IsNot Nothing AndAlso dr.Length > 0 Then
                                TextBox.Text = dr(0).Item(BLL.BLLExtraFieldValue_T.ExtraFieldValue_TField.Value_nvc.ToString).ToString
                            End If
                            Container.Controls.Add(CaptionLabel)
                            Container.Controls.Add(TextBox)
                            TextBox.BringToFront()
                            CaptionLabel.SendToBack()
                        ElseIf ExtraFieldEntity.Item(index).ExtraFieldDataTypeID_tint = 10 Then
                            Dim TextBox As New HamrahanSystem.TextBox.NumericTextBox
                            TextBox.BringToFront()
                            TextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
                            TextBox.Name = ExtraFieldEntity.Item(index).ExtraFieldID_bint
                            TextBox.AllowNegative = False
                            TextBox.MaxDecimalPlaces = 0
                            TextBox.MaxWholeDigits = 100
                            TextBox.TextAlign = HorizontalAlignment.Right
                            CalculateControlLocationAndSize(Container, TextBox, CaptionLabel)
                            If dr IsNot Nothing AndAlso dr.Length > 0 Then
                                TextBox.Text = dr(0).Item(BLL.BLLExtraFieldValue_T.ExtraFieldValue_TField.Value_nvc.ToString).ToString
                            End If
                            Container.Controls.Add(CaptionLabel)
                            Container.Controls.Add(TextBox)
                            TextBox.BringToFront()
                            CaptionLabel.SendToBack()
                        ElseIf ExtraFieldEntity.Item(index).ExtraFieldDataTypeID_tint = 11 Then
                            Dim TextBox As New HamrahanSystem.TextBox.NumericTextBox
                            TextBox.BringToFront()
                            TextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
                            TextBox.Name = ExtraFieldEntity.Item(index).ExtraFieldID_bint
                            TextBox.AllowNegative = False
                            TextBox.MaxDecimalPlaces = 0
                            TextBox.MaxWholeDigits = 100
                            TextBox.TextAlign = HorizontalAlignment.Right
                            CalculateControlLocationAndSize(Container, TextBox, CaptionLabel)
                            If dr IsNot Nothing AndAlso dr.Length > 0 Then
                                TextBox.Text = dr(0).Item(BLL.BLLExtraFieldValue_T.ExtraFieldValue_TField.Value_nvc.ToString).ToString
                            End If
                            Container.Controls.Add(CaptionLabel)
                            Container.Controls.Add(TextBox)
                            TextBox.BringToFront()
                            CaptionLabel.SendToBack()
                        ElseIf ExtraFieldEntity.Item(index).ExtraFieldDataTypeID_tint = 100 Then
                            Dim ComboBox As New ComboBox
                            ComboBox.BringToFront()
                            ComboBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
                            ComboBox.DroppedDown = False
                            ComboBox.Name = ExtraFieldEntity.Item(index).ExtraFieldID_bint.ToString
                            Dim DataSourceItemFactory As New BLL.BLLDataSourceItem_TFactory
                            Dim DataSourceItemDataTable As New DataTable
                            DataSourceItemFactory.GetAllBy(BLL.BLLDataSourceItem_T.DataSourceItem_TField.DataSourceID_bint, ExtraFieldEntity.Item(index).DataSourceID_bint, DataSourceItemDataTable)
                            ComboBox.DisplayMember = BLL.BLLDataSourceItem_T.DataSourceItem_TField.DataSourceItem_nvc.ToString
                            ComboBox.ValueMember = BLL.BLLDataSourceItem_T.DataSourceItem_TField.DataSourceItemID_bint.ToString
                            ComboBox.DataSource = DataSourceItemDataTable
                            CalculateControlLocationAndSize(Container, ComboBox, CaptionLabel)
                            Container.Controls.Add(CaptionLabel)
                            Container.Controls.Add(ComboBox)
                            ComboBox.BringToFront()
                            CaptionLabel.SendToBack()
                            If dr IsNot Nothing AndAlso dr.Length > 0 Then
                                ComboBox.SelectedValue = dr(0).Item(BLL.BLLExtraFieldValue_T.ExtraFieldValue_TField.Value_nvc.ToString)
                            End If
                        End If
                    Next

                    If Container.VerticalScroll.Visible = False Then
                        For Each ctrl As Control In Container.Controls
                            ctrl.Location = New Drawing.Point(ctrl.Location.X + 12, ctrl.Location.Y)
                        Next
                    End If

                    Me.AddEventHandlers(Me.ExtraFieldPanel)
                    Me._LastExtraFieldTemplateID = ExtraFieldTemplate.ExtraFieldTemplateID_bint
                End If
            Catch ex As System.Exception
                Throw ex
            End Try
        End Sub

        Protected Sub SaveExtraField(ByRef Container As Panel, ByVal ExtraFieldTemplateID As Nullable(Of Long), ByVal ParentID As String, ByVal TableID As Long)
            Try
                Dim ExtraFieldValueFactory As New BLL.BLLExtraFieldValue_TFactory
                ExtraFieldValueFactory.Delete(ParentID, TableID)

                If ExtraFieldTemplateID IsNot Nothing Then
                    Dim ExtraFieldFactory As New BLL.BLLExtraField_TFactory
                    Dim ExtraFieldEntity As List(Of BLL.BLLExtraField_T)
                    ExtraFieldEntity = ExtraFieldFactory.GetAllBy(BLL.BLLExtraField_T.ExtraField_TField.ExtraFieldTemplateID_bint, ExtraFieldTemplateID)

                    For index As Int32 = 0 To ExtraFieldEntity.Count - 1
                        Dim ExtraFieldValue As New BLL.BLLExtraFieldValue_T
                        ExtraFieldValue.ParentID_nvc = ParentID
                        ExtraFieldValue.TableID_bint = TableID
                        ExtraFieldValue.Value_nvc = Nothing
                        ExtraFieldValue.FileExtention_nvc = Nothing
                        ExtraFieldValue.Value_vbin = Nothing
                        ExtraFieldValue.ExtraFieldID_bint = ExtraFieldEntity.Item(index).ExtraFieldID_bint

                        Select Case ExtraFieldEntity.Item(index).ExtraFieldDataTypeID_tint
                            Case 1
                                If DirectCast(Container.Controls(ExtraFieldEntity.Item(index).ExtraFieldID_bint.ToString), HamrahanSystem.TextBox.NumericTextBox).NumericText <> String.Empty Then
                                    ExtraFieldValue.Value_nvc = DirectCast(Container.Controls(ExtraFieldEntity.Item(index).ExtraFieldID_bint.ToString), HamrahanSystem.TextBox.NumericTextBox).NumericText
                                    ExtraFieldValueFactory.Insert(ExtraFieldValue)
                                End If
                            Case 2
                                If DirectCast(Container.Controls(ExtraFieldEntity.Item(index).ExtraFieldID_bint.ToString), TextBox).Text <> String.Empty Then
                                    ExtraFieldValue.Value_nvc = DirectCast(Container.Controls(ExtraFieldEntity.Item(index).ExtraFieldID_bint.ToString), TextBox).Text
                                    ExtraFieldValueFactory.Insert(ExtraFieldValue)
                                End If
                            Case 3

                            Case 4
                                If DirectCast(Container.Controls(ExtraFieldEntity.Item(index).ExtraFieldID_bint.ToString), HamrahanSystem.TextBox.CurrencyTextBox).NumericText <> String.Empty Then
                                    ExtraFieldValue.Value_nvc = DirectCast(Container.Controls(ExtraFieldEntity.Item(index).ExtraFieldID_bint.ToString), HamrahanSystem.TextBox.CurrencyTextBox).NumericText
                                    ExtraFieldValueFactory.Insert(ExtraFieldValue)
                                End If
                            Case 5
                                ExtraFieldValue.Value_nvc = DirectCast(Container.Controls(ExtraFieldEntity.Item(index).ExtraFieldID_bint.ToString), CheckBox).Checked
                                ExtraFieldValueFactory.Insert(ExtraFieldValue)
                            Case 6
                                If Me._File IsNot Nothing Then
                                    If Me._File.ContainsKey(ExtraFieldEntity.Item(index).ExtraFieldID_bint.ToString) Then
                                        If Me._File.Item(ExtraFieldEntity.Item(index).ExtraFieldID_bint.ToString).Equals(Nothing) = False Then
                                            ExtraFieldValue.Value_vbin = Me._File.Item(ExtraFieldEntity.Item(index).ExtraFieldID_bint.ToString).File.Clone
                                            ExtraFieldValue.FileExtention_nvc = Me._File.Item(ExtraFieldEntity.Item(index).ExtraFieldID_bint.ToString).FileExtention
                                            ExtraFieldValueFactory.Insert(ExtraFieldValue)
                                        End If
                                    End If
                                End If
                            Case 7
                                If DirectCast(Container.Controls(ExtraFieldEntity.Item(index).ExtraFieldID_bint.ToString), TextBox).Text <> String.Empty Then
                                    ExtraFieldValue.Value_nvc = DirectCast(Container.Controls(ExtraFieldEntity.Item(index).ExtraFieldID_bint.ToString), TextBox).Text
                                    ExtraFieldValue.ValidationRules.AddRules(New Validation.RegularExpressionRule("Value_nvc", ExtraFieldEntity.Item(index).ExtraField_nvc, My.Resources.RegularExpressionPattern.Email))
                                    ExtraFieldValueFactory.Insert(ExtraFieldValue)
                                End If
                            Case 8
                                If DirectCast(Container.Controls(ExtraFieldEntity.Item(index).ExtraFieldID_bint.ToString), TextBox).Text <> String.Empty Then
                                    ExtraFieldValue.Value_nvc = DirectCast(Container.Controls(ExtraFieldEntity.Item(index).ExtraFieldID_bint.ToString), TextBox).Text
                                    ExtraFieldValue.ValidationRules.AddRules(New Validation.RegularExpressionRule("Value_nvc", ExtraFieldEntity.Item(index).ExtraField_nvc, My.Resources.RegularExpressionPattern.WebSite))
                                    ExtraFieldValueFactory.Insert(ExtraFieldValue)
                                End If
                            Case 9
                                If DirectCast(Container.Controls(ExtraFieldEntity.Item(index).ExtraFieldID_bint.ToString), HamrahanSystem.TextBox.NumericTextBox).Text <> String.Empty Then
                                    ExtraFieldValue.Value_nvc = DirectCast(Container.Controls(ExtraFieldEntity.Item(index).ExtraFieldID_bint.ToString), HamrahanSystem.TextBox.NumericTextBox).NumericText
                                    ExtraFieldValue.ValidationRules.AddRules(New Validation.RegularExpressionRule("Value_nvc", ExtraFieldEntity.Item(index).ExtraField_nvc, My.Resources.RegularExpressionPattern.Mobile))
                                    ExtraFieldValueFactory.Insert(ExtraFieldValue)
                                End If
                            Case 10
                                If DirectCast(Container.Controls(ExtraFieldEntity.Item(index).ExtraFieldID_bint.ToString), HamrahanSystem.TextBox.NumericTextBox).Text <> String.Empty Then
                                    ExtraFieldValue.Value_nvc = DirectCast(Container.Controls(ExtraFieldEntity.Item(index).ExtraFieldID_bint.ToString), HamrahanSystem.TextBox.NumericTextBox).NumericText
                                    ExtraFieldValueFactory.Insert(ExtraFieldValue)
                                End If
                            Case 11
                                If DirectCast(Container.Controls(ExtraFieldEntity.Item(index).ExtraFieldID_bint.ToString), HamrahanSystem.TextBox.NumericTextBox).Text <> String.Empty Then
                                    ExtraFieldValue.Value_nvc = DirectCast(Container.Controls(ExtraFieldEntity.Item(index).ExtraFieldID_bint.ToString), HamrahanSystem.TextBox.NumericTextBox).NumericText
                                    ExtraFieldValueFactory.Insert(ExtraFieldValue)
                                End If
                            Case 100
                                If DirectCast(Container.Controls(ExtraFieldEntity.Item(index).ExtraFieldID_bint.ToString), ComboBox).SelectedValue IsNot Nothing Then
                                    ExtraFieldValue.Value_nvc = DirectCast(Container.Controls(ExtraFieldEntity.Item(index).ExtraFieldID_bint.ToString), ComboBox).SelectedValue
                                    ExtraFieldValueFactory.Insert(ExtraFieldValue)
                                End If
                        End Select
                    Next
                End If
            Catch ex As System.Exception
                Throw ex
            End Try
        End Sub

        Private Sub CalculateControlLocationAndSize(ByVal Container As Panel, ByRef Control As Control, ByRef Caption As Label)
            Dim Graphic As Graphics = Container.CreateGraphics
            Dim ContainerWidth As Single = Container.Width - 25
            Dim Width As Single = 0
            Dim Line As Integer = 0
            Dim X As Integer = 0

            Caption.AutoSize = False
            Line = Math.Ceiling((Graphic.MeasureString(Caption.Text, Container.Font).Width + 4) / ContainerWidth)
            Caption.Height = Line * Graphic.MeasureString(Caption.Text, Container.Font).Height + 4
            If Line > 1 Then
                Caption.Width = ContainerWidth - 10
            Else
                Caption.Width = Graphic.MeasureString(Caption.Text, Container.Font).Width + 4
            End If
            Caption.Location = New Point(ContainerWidth - Caption.Width, Y + 3)

            If TypeOf Control Is CheckBox Then
                DirectCast(Control, CheckBox).AutoSize = False
                DirectCast(Control, CheckBox).Width = 15
                DirectCast(Control, CheckBox).Text = String.Empty
                If ContainerWidth - Caption.Width - 8 < 15 Then
                    Y += Caption.Height + 0
                    X = ContainerWidth - Control.Width
                    Control.Location = New Point(X, Y)
                    Y += Control.Height + 2
                Else
                    X = ContainerWidth - Caption.Width - Control.Width - 3
                    Control.Location = New Point(X, Y - 2)
                    Y += Control.Height + 2
                End If
            Else
                If Line = 1 Then
                    Width = ContainerWidth - Caption.Width - 8
                    If Width < 100 Then
                        Width = ContainerWidth - 8
                        Y += Caption.Height + 0
                        X = ContainerWidth - Width
                    Else
                        X = ContainerWidth - Caption.Width - Width
                    End If
                    Control.Width = Width
                    Control.Location = New Point(X, Y)
                    Y += Control.Height + 4
                Else
                    Y += Caption.Height + 4
                    X = 8
                    Control.Width = ContainerWidth - 8
                    Control.Location = New Point(X, Y)
                    Y += Control.Height + 5
                End If
            End If

        End Sub

        Private Sub CalculateControlLocation(ByVal Container As Panel, ByRef DeleteFileButton As Button, ByRef UploadFileButton As Button, ByRef SaveFileButton As Button, ByRef Caption As Label)
            Dim Graphic As Graphics = Container.CreateGraphics
            Dim ContainerWidth As Single = Container.Width - 25
            Dim Width As Single = 0
            Dim Line As Integer = 0
            Dim X As Integer = 0

            Caption.AutoSize = False
            Line = Math.Ceiling((Graphic.MeasureString(Caption.Text, Container.Font).Width + 4) / ContainerWidth)
            Caption.Height = Line * Graphic.MeasureString(Caption.Text, Container.Font).Height + 4
            If Line > 1 Then
                Caption.Width = ContainerWidth - 10
            Else
                Caption.Width = Graphic.MeasureString(Caption.Text, Container.Font).Width + 4
            End If
            Caption.Location = New Point(ContainerWidth - Caption.Width, Y + 3)

            If Line = 1 Then
                Width = ContainerWidth - Caption.Width
                If Width < DeleteFileButton.Size.Width + SaveFileButton.Size.Width + UploadFileButton.Size.Width Then
                    Width = ContainerWidth
                    Y += Math.Max(Math.Max(Math.Max(Caption.Height, DeleteFileButton.Size.Height), SaveFileButton.Size.Height), UploadFileButton.Size.Height) + 2
                    X = Width - UploadFileButton.Size.Width
                    UploadFileButton.Location = New Point(X, Y)
                    X = X - SaveFileButton.Size.Width - 1
                    SaveFileButton.Location = New Point(X, Y)
                    X = X - DeleteFileButton.Size.Width - 1
                    DeleteFileButton.Location = New Point(X, Y)
                Else
                    X = Width - UploadFileButton.Size.Width
                    UploadFileButton.Location = New Point(X, Y)
                    X = X - SaveFileButton.Size.Width - 1
                    SaveFileButton.Location = New Point(X, Y)
                    X = X - DeleteFileButton.Size.Width - 1
                    DeleteFileButton.Location = New Point(X, Y)
                End If
            Else
                Width = ContainerWidth
                Y += Caption.Height + 3
                X = Width - UploadFileButton.Size.Width
                UploadFileButton.Location = New Point(X, Y)
                X = X - SaveFileButton.Size.Width - 1
                SaveFileButton.Location = New Point(X, Y)
                X = X - DeleteFileButton.Size.Width - 1
                DeleteFileButton.Location = New Point(X, Y)
            End If
            Y += Math.Max(Math.Max(Math.Max(SaveFileButton.Size.Height, DeleteFileButton.Size.Height), UploadFileButton.Size.Height), Caption.Size.Height) + 4
        End Sub

#End Region

        Private Sub BaseEntityParentForm_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
            If Hepsa.Core.Common.MessageBox.ConfirmMessage(Hepsa.Core.My.Resources.Exceptions.AreYouSureToCloseForm) = False Then
                e.Cancel() = True
                Return
            End If
        End Sub

#Region "Log"

        Public Function MakeLog(ByVal Parent As Control) As String
            Dim logStr As String = ""
            Dim TempStr As String = ""
            For Each ctrl As Control In Parent.Controls
                If ctrl.Controls.Count > 0 Then
                    logStr += MakeLog(ctrl)
                ElseIf ctrl.Tag IsNot Nothing Then
                    TempStr = ctrl.Tag
                    If TypeOf ctrl Is TextBox Then
                        logStr += "<TR><TD>" + TempStr + "</TD><TD>" + ctrl.Text + "</TD></TR>"
                    ElseIf TypeOf ctrl Is MaskedTextBox Then
                        logStr += "<TR><TD>" + TempStr + "</TD><TD>" + Hepsa.Core.Common.PersentationController.GetMaskedTextBoxValue(ctrl) + "</TD></TR>"
                    ElseIf TypeOf ctrl Is ComboBox Then
                        logStr += "<TR><TD>" + TempStr + "</TD><TD>" + ctrl.Text + "</TD></TR>"
                    ElseIf TypeOf ctrl Is CheckBox Then
                        If DirectCast(ctrl, CheckBox).Checked = True Then
                            logStr += "<TR><TD>" + TempStr + "</TD><TD>√</TD></TR>"
                        Else
                            logStr += "<TR><TD>" + TempStr + "</TD><TD></TD></TR>"
                        End If

                    ElseIf TypeOf ctrl Is CheckedListBox Then
                        'For index As Integer = 0 To DirectCast(ctrl, CheckedListBox).Items.Count - 1
                        '    'DirectCast(ctrl, CheckedListBox).SetItemCheckState(index, CheckState.Unchecked)
                        '    logStr += "<TR><TD>" + TempStr + "</TD><TD>" + ctrl.Text + "</TD></TR>"
                        'Next
                    End If
                End If


            Next
            Return logStr
        End Function
#End Region
    End Class
End Namespace