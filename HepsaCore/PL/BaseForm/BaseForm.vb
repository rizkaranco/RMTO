Namespace PL
    Public Class BaseForm
        Private _Selectionstart As Int32
        Public Class Category

            Public Enum enmCategoryState
                Add = 1
                Edit = 3
                View = 4
            End Enum

            Private _Key As String
            Private _CategoryComboBox As ComboBox
            Private _CategoryTreeView As TreeView
            Private _SelectedCategory As List(Of String)
            Private _CategorySearchButton As Button

            Private _State As enmCategoryState

            Public Sub New()
                Me._SelectedCategory = New List(Of String)
            End Sub

            Public Property CategorySearchButton() As Button
                Get
                    Return _CategorySearchButton
                End Get
                Set(ByVal value As Button)
                    Me._CategorySearchButton = value
                End Set
            End Property

            Public Property State() As enmCategoryState
                Get
                    Return _State
                End Get
                Set(ByVal value As enmCategoryState)
                    Me._State = value
                End Set
            End Property

            Public Property Key() As String
                Get
                    Return Me._Key
                End Get
                Set(ByVal value As String)
                    Me._Key = value
                End Set
            End Property

            Public Property CategoryComboBox() As ComboBox
                Get
                    Return Me._CategoryComboBox
                End Get
                Set(ByVal value As ComboBox)
                    Me._CategoryComboBox = value
                End Set
            End Property

            Public Property CategoryTreeView() As TreeView
                Get
                    Return Me._CategoryTreeView
                End Get
                Set(ByVal value As TreeView)
                    Me._CategoryTreeView = value
                End Set
            End Property

            Public Property SelectedCategory() As List(Of String)
                Get
                    Return Me._SelectedCategory
                End Get
                Set(ByVal value As List(Of String))
                    Me._SelectedCategory = value
                End Set
            End Property

        End Class

        Private _settings As My.MySettings
        Private _EnglishControls As New Dictionary(Of String, Control)
        Private _ControlsDefaultValue As New Collection
        Private _ShowStackFormWhenFormClosed As Boolean
        Private _ControlBackColor As Color
        Private _PrinterButton As Object
        Private _RaiseKeyDownEvent As Boolean = True

        Private _CategoryList As New List(Of Category)

        Public Property RaiseKeyDownEvent() As Boolean
            Get
                Return Me._RaiseKeyDownEvent
            End Get
            Set(ByVal value As Boolean)
                Me._RaiseKeyDownEvent = value
            End Set
        End Property

        Public WriteOnly Property PrinterButton() As Object
            Set(ByVal value As Object)
                Me._PrinterButton = value
                If TypeOf Me._PrinterButton Is Button Then
                    AddHandler DirectCast(Me._PrinterButton, Button).Click, AddressOf PrinterButton_Click
                ElseIf TypeOf Me._PrinterButton Is ToolStripButton Then
                    AddHandler DirectCast(Me._PrinterButton, ToolStripButton).Click, AddressOf PrinterButton_Click
                ElseIf TypeOf Me._PrinterButton Is ToolStripMenuItem Then
                    AddHandler DirectCast(Me._PrinterButton, ToolStripMenuItem).Click, AddressOf PrinterButton_Click
                End If
            End Set
        End Property

        Private Sub PrinterButton_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim Print As New PrintDialog
            If String.IsNullOrEmpty(Me.Printer) = False Then
                Print.PrinterSettings.PrinterName = Me.Printer
            End If
            If Print.ShowDialog() = Windows.Forms.DialogResult.OK Then
                Me.Printer = Print.PrinterSettings.PrinterName
            End If
        End Sub

        Public Property Printer() As String
            Get
                Settings.SettingsKey = Me.Name
                Dim theSettings As My.MySettings
                theSettings = DirectCast(Settings, My.MySettings)
                Return theSettings.PrinterName
            End Get
            Set(ByVal value As String)
                Settings.SettingsKey = Me.Name
                Dim theSettings As My.MySettings
                theSettings = DirectCast(Settings, My.MySettings)
                theSettings.PrinterName = value
                Settings.Save()
            End Set
        End Property

        Public Property EnglishControls() As Dictionary(Of String, Control)
            Get
                Return Me._EnglishControls
            End Get
            Set(ByVal value As Dictionary(Of String, Control))
                Me._EnglishControls = value
            End Set
        End Property

        Protected Property ControlsDefaultValue() As Collection
            Get
                Return Me._ControlsDefaultValue
            End Get
            Set(ByVal value As Collection)
                Me._ControlsDefaultValue = value
            End Set
        End Property

        Private ReadOnly Property Settings() As System.Configuration.ApplicationSettingsBase
            Get
                If _settings Is Nothing Then
                    _settings = New My.MySettings
                End If
                Return _settings
            End Get
        End Property

        Public Property ShowStackFormWhenFormClosed() As Boolean
            Get
                Return Me._ShowStackFormWhenFormClosed
            End Get
            Set(ByVal value As Boolean)
                Me._ShowStackFormWhenFormClosed = value
            End Set
        End Property

        Private Sub BaseForm_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
            If ShowStackFormWhenFormClosed Then
                If Common.ApplicationInfo.MainForm IsNot Nothing AndAlso Common.ApplicationInfo.MainForm.HasChildren Then
                    For Each ctrl As Control In Common.ApplicationInfo.MainForm.Controls
                        If TypeOf ctrl Is Panel Then
                            Common.PersentationController.ShowStackForm(ctrl)
                            Exit For
                        End If
                    Next
                End If
            End If
        End Sub

        Private Sub BaseForm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

            Try
                AddEventHandlers(Me)
                ApplySettings()
                Me.SetPermission(Me)
            Catch ex As System.Exception
                Common.MessageBox.ErrorMessage(ex.Message)
            End Try
        End Sub

        Private Sub BaseForm_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing

            SaveSettings()
        End Sub

        Protected Sub AddEventHandlers(ByVal ctrlContainer As Control)
            For Each ctrl As Control In ctrlContainer.Controls
                If TypeOf ctrl Is TextBox OrElse TypeOf ctrl Is ComboBox OrElse TypeOf ctrl Is MaskedTextBox Then
                    AddHandler ctrl.Enter, AddressOf ProcessEnter
                    AddHandler ctrl.Leave, AddressOf ProcessLeave
                    AddHandler ctrl.TextChanged, AddressOf TextChange
                    AddHandler ctrl.EnabledChanged, AddressOf ProcessEnableChanged
                End If
                If Not (TypeOf ctrl Is TextBox AndAlso DirectCast(ctrl, TextBox).Multiline = True) AndAlso ctrl.HasChildren = False Then
                    AddHandler ctrl.KeyDown, AddressOf ProcessKeyDown
                End If

                If ctrl.HasChildren Then
                    AddEventHandlers(ctrl)
                End If
            Next
        End Sub

        Private Sub ProcessEnableChanged(ByVal sender As Object, ByVal e As EventArgs)
            If sender.enabled = False Then
                sender.backcolor = System.Drawing.SystemColors.Control
            Else
                sender.backcolor = System.Drawing.SystemColors.Window
            End If
        End Sub

        Private Sub ApplySettings()
            Settings.SettingsKey = Me.Name
            Dim theSettings As My.MySettings
            theSettings = DirectCast(Settings, My.MySettings)
            If theSettings.FormSize <> Drawing.Size.Empty Then
                If theSettings.FormSize.Height = -1 Then
                    Me.WindowState = FormWindowState.Minimized
                ElseIf theSettings.FormSize.Height = -2 Then
                    Me.WindowState = FormWindowState.Maximized
                ElseIf Me.FormBorderStyle.ToString.ToLower.Contains("sizable") Then
                    Me.Size = theSettings.FormSize
                End If
            End If
            If theSettings.FormLocation <> Drawing.Point.Empty Then
                Me.Location = theSettings.FormLocation
            End If
        End Sub

        Private Sub SaveSettings()
            Settings.SettingsKey = Me.Name
            Dim theSettings As My.MySettings
            theSettings = DirectCast(Settings, My.MySettings)

            If Me.WindowState = FormWindowState.Normal Then
                theSettings.FormSize = Me.Size
            ElseIf Me.WindowState = FormWindowState.Minimized Then
                theSettings.FormSize = New Drawing.Point(0, -1)
            Else
                theSettings.FormSize = New Drawing.Point(0, -2)
            End If

            theSettings.FormLocation = Me.Location
            Settings.Save()
        End Sub

        Private Sub ProcessEnter(ByVal sender As Object, ByVal e As System.EventArgs)
            Me._ControlBackColor = DirectCast(sender, Control).BackColor
            DirectCast(sender, Control).BackColor = System.Drawing.Color.FromArgb(248, 225, 160)
            If EnglishControls.ContainsKey(sender.name) Then
                For Each lng As InputLanguage In InputLanguage.InstalledInputLanguages
                    If lng.LayoutName = "US" Then
                        InputLanguage.CurrentInputLanguage = lng
                    End If
                Next
            Else
                For Each lng As InputLanguage In InputLanguage.InstalledInputLanguages
                    If lng.LayoutName = "Farsi" Then
                        InputLanguage.CurrentInputLanguage = lng
                    End If
                Next
            End If

            If TypeOf sender Is TextBox Then
                CType(sender, TextBox).SelectAll()
            End If
        End Sub

        Private Sub ProcessLeave(ByVal sender As Object, ByVal e As System.EventArgs)
            DirectCast(sender, Control).BackColor = Me._ControlBackColor
        End Sub

        Private Sub TextChange(ByVal sender As Object, ByVal e As System.EventArgs)


            If TypeOf sender Is ComboBox Then
                CType(sender, ComboBox).Text = CType(sender, ComboBox).Text.Replace("ی", "ي").Replace("ک", "ك")
                _Selectionstart = CType(sender, ComboBox).Text.Length

                CType(sender, ComboBox).Select(_Selectionstart, 0)


            End If

            If TypeOf sender Is TextBox Then
                CType(sender, TextBox).Text = CType(sender, TextBox).Text.Replace("ی", "ي").Replace("ک", "ك")
                _Selectionstart = CType(sender, TextBox).Text.Length

                CType(sender, TextBox).Select(_Selectionstart, 0)
            End If
        End Sub


        Private Sub ProcessKeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
            If (TypeOf sender Is TextBox OrElse TypeOf sender Is MaskedTextBox OrElse TypeOf sender Is CheckBox OrElse TypeOf sender Is RadioButton OrElse TypeOf sender Is ComboBox) AndAlso Not (TypeOf sender.parent Is ToolStrip) Then
                If e.KeyCode = Keys.Enter AndAlso Me._RaiseKeyDownEvent = True Then
                    System.Windows.Forms.SendKeys.Send("{tab}")
                Else
                    Me._RaiseKeyDownEvent = True
                End If
            End If

        End Sub

        Private Sub BaseForm_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
            If e.KeyCode = My.Settings.CloseButton Then
                Me.Close()
            End If
        End Sub

        Protected Overridable Sub ClearForm(ByVal Parent As Control)
            For index As Integer = 0 To Me._CategoryList.Count - 1
                Me._CategoryList.Item(index).SelectedCategory.Clear()
            Next

            For Each ctrl As Control In Parent.Controls
                If ctrl.Controls.Count > 0 Then
                    ClearForm(ctrl)
                ElseIf TypeOf ctrl Is TextBox Then
                    DirectCast(ctrl, TextBox).Clear()
                    If ControlsDefaultValue.Contains(ctrl.Name) Then
                        DirectCast(ctrl, TextBox).Text = ControlsDefaultValue.Item(ctrl.Name).ToString
                    End If
                ElseIf TypeOf ctrl Is MaskedTextBox Then
                    DirectCast(ctrl, MaskedTextBox).Clear()

                    If ControlsDefaultValue.Contains(ctrl.Name) Then
                        DirectCast(ctrl, MaskedTextBox).Text = ControlsDefaultValue.Item(ctrl.Name).ToString
                    End If
                ElseIf TypeOf ctrl Is ComboBox Then
                    DirectCast(ctrl, ComboBox).SelectedIndex = -1
                    DirectCast(ctrl, ComboBox).Text = String.Empty
                    If ControlsDefaultValue.Contains(ctrl.Name) Then
                        DirectCast(ctrl, ComboBox).Text = ControlsDefaultValue.Item(ctrl.Name).ToString
                    End If
                ElseIf TypeOf ctrl Is CheckBox Then
                    DirectCast(ctrl, CheckBox).Checked = False
                    If ControlsDefaultValue.Contains(ctrl.Name) Then
                        DirectCast(ctrl, CheckBox).Checked = Boolean.Parse(ControlsDefaultValue.Item(ctrl.Name))
                    End If
                ElseIf TypeOf ctrl Is CheckedListBox Then
                    For index As Integer = 0 To DirectCast(ctrl, CheckedListBox).Items.Count - 1
                        DirectCast(ctrl, CheckedListBox).SetItemCheckState(index, CheckState.Unchecked)
                    Next
                End If
            Next

            Me.SetFocus(Me)
        End Sub

        Protected Function SetFocus(ByVal Parent As Control) As Boolean
            Dim ControlCollection As New List(Of Object)
            For Each ctrl As Control In Parent.Controls
                ControlCollection.Add(ctrl)
            Next
            For index As Integer = 0 To ControlCollection.Count - 2
                For Follow As Integer = index + 1 To ControlCollection.Count - 1
                    If ControlCollection.Item(index).TabIndex > ControlCollection.Item(Follow).TabIndex Then
                        Dim tmpControl As Object = ControlCollection.Item(Follow)
                        ControlCollection.Item(Follow) = ControlCollection.Item(index)
                        ControlCollection.Item(index) = tmpControl
                    End If
                Next
            Next
            For index As Integer = 0 To ControlCollection.Count - 1
                If ControlCollection.Item(index).Controls.Count > 0 Then
                    If SetFocus(ControlCollection(index)) = False Then
                        Return False
                    End If
                ElseIf TypeOf ControlCollection(index) Is TextBox OrElse TypeOf ControlCollection(index) Is MaskedTextBox OrElse TypeOf ControlCollection(index) Is ComboBox OrElse TypeOf ControlCollection(index) Is CheckBox OrElse TypeOf ControlCollection(index) Is RadioButton Then
                    If TypeOf ControlCollection(index) Is TextBox OrElse TypeOf ControlCollection(index) Is MaskedTextBox OrElse TypeOf ControlCollection(index) Is ComboBox Then
                        ControlCollection(index).SelectAll()
                        Me.ActiveControl = ControlCollection(index)
                        Return False
                    Else
                        ControlCollection(index).Select()
                        ControlCollection(index).Focus()
                        Return False
                    End If
                End If
            Next
            Return True
        End Function

        '<Hamed>
        Protected Sub SetPermission(ByVal ctrlContainer As Object)
            If Hepsa.Core.Common.CurrentUser.User Is Nothing OrElse Hepsa.Core.Common.CurrentUser.User.Permissions Is Nothing OrElse Hepsa.Core.Common.CurrentUser.User.Permissions.Count = 0 Then
                Return
            End If
            Dim PermissionList As List(Of Hepsa.Core.BLL.BLLPermission_T) = Hepsa.Core.Common.CurrentUser.User.Permissions.FindAll(Function(c As Hepsa.Core.BLL.BLLPermission_T) (c.FormName_nvc = Me.Name AndAlso c.ControlName_nvc = ctrlContainer.Name))
            If PermissionList IsNot Nothing AndAlso PermissionList.Count > 0 Then
                For Each p As Hepsa.Core.BLL.BLLPermission_T In PermissionList
                    Try
                        If TypeOf (ctrlContainer) Is TabControl Then
                            If String.IsNullOrEmpty(p.ColumnName_nvc) Then
                                Dim pInfo As System.Reflection.PropertyInfo = ctrlContainer.GetType.GetProperty(p.PropertyName_nvc)
                                If pInfo IsNot Nothing Then
                                    pInfo.SetValue(ctrlContainer, Convert.ChangeType(p.Value_nvc, pInfo.PropertyType), Nothing)
                                End If
                            Else
                                If p.PropertyName_nvc = "Visible" OrElse p.PropertyName_nvc = "Enabled" Then
                                    DirectCast(ctrlContainer, TabControl).TabPages.RemoveByKey(p.ColumnName_nvc)
                                Else
                                    Dim pInfo As System.Reflection.PropertyInfo = DirectCast(ctrlContainer, TabControl).TabPages(p.ColumnName_nvc).GetType.GetProperty(p.PropertyName_nvc)
                                    If pInfo IsNot Nothing Then
                                        pInfo.SetValue(DirectCast(ctrlContainer, TabControl).TabPages(p.ColumnName_nvc), Convert.ChangeType(p.Value_nvc, pInfo.PropertyType), Nothing)
                                    End If
                                End If
                            End If
                        ElseIf TypeOf (ctrlContainer) Is DataGridView Then
                            If String.IsNullOrEmpty(p.ColumnName_nvc) Then
                                Dim pInfo As System.Reflection.PropertyInfo = ctrlContainer.GetType.GetProperty(p.PropertyName_nvc)
                                If pInfo IsNot Nothing Then
                                    pInfo.SetValue(ctrlContainer, Convert.ChangeType(p.Value_nvc, pInfo.PropertyType), Nothing)
                                End If
                            Else
                                Dim pInfo As System.Reflection.PropertyInfo = DirectCast(ctrlContainer, DataGridView).Columns(p.ColumnName_nvc).GetType.GetProperty(p.PropertyName_nvc)
                                If pInfo IsNot Nothing Then
                                    pInfo.SetValue(DirectCast(ctrlContainer, DataGridView).Columns(p.ColumnName_nvc), Convert.ChangeType(p.Value_nvc, pInfo.PropertyType), Nothing)
                                End If
                            End If
                        ElseIf TypeOf ctrlContainer Is ToolStrip Then
                            If String.IsNullOrEmpty(p.ColumnName_nvc) Then
                                Dim pInfo As System.Reflection.PropertyInfo = ctrlContainer.GetType.GetProperty(p.PropertyName_nvc)
                                If pInfo IsNot Nothing Then
                                    pInfo.SetValue(ctrlContainer, Convert.ChangeType(p.Value_nvc, pInfo.PropertyType), Nothing)
                                End If
                            Else
                                Dim pInfo As System.Reflection.PropertyInfo = DirectCast(ctrlContainer, ToolStrip).Items(p.ColumnName_nvc).GetType.GetProperty(p.PropertyName_nvc)
                                If pInfo IsNot Nothing Then
                                    pInfo.SetValue(DirectCast(ctrlContainer, ToolStrip).Items(p.ColumnName_nvc), Convert.ChangeType(p.Value_nvc, pInfo.PropertyType), Nothing)
                                End If
                            End If
                        ElseIf TypeOf (ctrlContainer) Is Janus.Windows.GridEX.GridEX Then
                            If String.IsNullOrEmpty(p.ColumnName_nvc) Then
                                Dim pInfo As System.Reflection.PropertyInfo = ctrlContainer.GetType.GetProperty(p.PropertyName_nvc)
                                If pInfo IsNot Nothing Then
                                    pInfo.SetValue(ctrlContainer, Convert.ChangeType(p.Value_nvc, pInfo.PropertyType), Nothing)
                                End If
                            Else
                                Dim pInfo As System.Reflection.PropertyInfo = DirectCast(ctrlContainer, Janus.Windows.GridEX.GridEX).RootTable.Columns(p.ColumnName_nvc).GetType.GetProperty(p.PropertyName_nvc)
                                If pInfo IsNot Nothing Then
                                    pInfo.SetValue(DirectCast(ctrlContainer, Janus.Windows.GridEX.GridEX).RootTable.Columns(p.ColumnName_nvc), Convert.ChangeType(p.Value_nvc, pInfo.PropertyType), Nothing)
                                End If
                            End If
                        Else
                            Dim pInfo As System.Reflection.PropertyInfo = ctrlContainer.GetType.GetProperty(p.PropertyName_nvc)
                            If pInfo IsNot Nothing Then
                                pInfo.SetValue(ctrlContainer, Convert.ChangeType(p.Value_nvc, pInfo.PropertyType), Nothing)
                            End If
                        End If
                    Catch ex As System.Exception
                        Throw ex
                    End Try
                Next
            End If

            If TypeOf (ctrlContainer) Is MenuStrip OrElse TypeOf (ctrlContainer) Is ToolStrip OrElse TypeOf (ctrlContainer) Is MenuItem OrElse TypeOf (ctrlContainer) Is ToolStripMenuItem Then
                Dim ItemsInfo As System.Reflection.PropertyInfo = ctrlContainer.GetType.GetProperty("Items")
                If ItemsInfo Is Nothing Then
                    ItemsInfo = ctrlContainer.GetType.GetProperty("DropDownItems")
                End If
                If ItemsInfo IsNot Nothing Then
                    Dim ItemsObj As Object = ItemsInfo.GetValue(ctrlContainer, Nothing)
                    If ItemsObj IsNot Nothing Then
                        For Each itm As Object In ItemsObj
                            SetPermission(itm)
                        Next
                    End If
                End If
            End If

            Dim ControlsInfo As System.Reflection.PropertyInfo = ctrlContainer.GetType.GetProperty("Controls")
            If ControlsInfo IsNot Nothing Then
                Dim ControlsObj As Object = ControlsInfo.GetValue(ctrlContainer, Nothing)
                If ControlsObj IsNot Nothing Then
                    For Each itm As Control In ControlsObj
                        SetPermission(itm)
                    Next
                End If
            End If
        End Sub
        '</Hamed>

#Region "Category"

        Protected ReadOnly Property GetCategory(ByVal ComboBox As ComboBox) As Category
            Get
                For index As Integer = 0 To Me._CategoryList.Count - 1
                    If Me._CategoryList.Item(index).CategoryComboBox Is ComboBox Then
                        Return Me._CategoryList.Item(index)
                    End If
                Next
                Return Nothing
            End Get
        End Property

        Protected ReadOnly Property GetCategory(ByVal TreeView As TreeView) As Category
            Get
                For index As Integer = 0 To Me._CategoryList.Count - 1
                    If Me._CategoryList.Item(index).CategoryTreeView.Equals(TreeView) Then
                        Return Me._CategoryList.Item(index)
                    End If
                Next
                Return Nothing
            End Get
        End Property

        Protected ReadOnly Property GetCategory(ByVal SearchButton As Button) As Category
            Get
                For index As Integer = 0 To Me._CategoryList.Count - 1
                    If Me._CategoryList.Item(index).CategorySearchButton.Equals(SearchButton) Then
                        Return Me._CategoryList.Item(index)
                    End If
                Next
                Return Nothing
            End Get
        End Property


        Protected ReadOnly Property GetCategory(ByVal Key As String) As Category
            Get
                For index As Integer = 0 To Me._CategoryList.Count - 1
                    If Me._CategoryList.Item(index).Key Is Key Then
                        Return Me._CategoryList.Item(index)
                    End If
                Next
                Return Nothing
            End Get
        End Property

        Protected ReadOnly Property GetCategory() As Category
            Get
                For index As Integer = 0 To Me._CategoryList.Count - 1
                    Return Me._CategoryList.Item(index)
                Next
                Return Nothing
            End Get
        End Property

        Protected Sub ResetCategory(ByVal Key As String)
            For index As Integer = 0 To _CategoryList.Count - 1
                If _CategoryList.Item(index).Key = Key Then
                    _CategoryList.Item(index).SelectedCategory.Clear()
                End If
            Next
        End Sub

        Protected Sub ResetCategory()
            For index As Integer = 0 To _CategoryList.Count - 1
                _CategoryList.Item(index).SelectedCategory.Clear()
            Next
        End Sub

        Private Sub CategoryTreeView_AfterLabelEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.NodeLabelEditEventArgs)
            Dim Caption As String
            Dim MyCategory As Category = GetCategory(DirectCast(sender, TreeView))

            If MyCategory Is Nothing Then
                Exit Sub
            End If

            If String.IsNullOrEmpty(e.Label) Then
                Caption = e.Node.Text
            Else
                Caption = e.Label
            End If

            Try
                Dim Factory As New BLL.BLLCategoryTree_TFactory
                Dim Entity As New BLL.BLLCategoryTree_T
                Entity.CategoryID_bint = MyCategory.CategoryComboBox.SelectedValue
                Entity.Node_nvc = Caption
                If e.Node.Parent Is Nothing Then
                    Entity.ParentID_bint = Nothing
                Else
                    Entity.ParentID_bint = e.Node.Parent.Name
                End If
                If MyCategory.State = Category.enmCategoryState.Add Then
                    If String.IsNullOrEmpty(Caption) Then
                        e.Node.Remove()
                        Exit Sub
                    End If
                    Factory.Insert(Entity)
                    e.Node.Name = Entity.CategoryTreeID_bint
                ElseIf MyCategory.State = Category.enmCategoryState.Edit Then
                    Dim Key As New BLL.BLLCategoryTree_TKeys
                    Key.CategoryTreeID_bint = e.Node.Name
                    Factory.Update(Entity, Key)
                End If
                e.Node.EndEdit(False)
                DirectCast(sender, TreeView).SelectedNode = e.Node
            Catch ex As System.Exception
                If MyCategory.State = Category.enmCategoryState.Add Then
                    e.Node.Remove()
                ElseIf MyCategory.State = Category.enmCategoryState.Edit Then
                    e.CancelEdit = True
                End If
                Common.MessageBox.ErrorMessage(ex.Message)
            Finally
                MyCategory.State = Category.enmCategoryState.View
            End Try
        End Sub

        Private Sub CategoryTreeView_BeforeLabelEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.NodeLabelEditEventArgs)
            If String.IsNullOrEmpty(e.Node.Name) = False Then
                GetCategory(DirectCast(sender, TreeView)).State = Category.enmCategoryState.Edit
            End If
        End Sub

        Private Sub CategoryTreeView_BeforeSelect(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TreeViewCancelEventArgs)
            If GetCategory(DirectCast(sender, TreeView)).CategoryTreeView.SelectedNode IsNot Nothing Then
                GetCategory(DirectCast(sender, TreeView)).CategoryTreeView.SelectedNode.BackColor = System.Drawing.SystemColors.Window
                GetCategory(DirectCast(sender, TreeView)).CategoryTreeView.SelectedNode.ForeColor = System.Drawing.SystemColors.WindowText
            End If
        End Sub

        Private Sub CategoryTreeAddParentButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
            Dim MyCategory As Category = DirectCast(DirectCast(sender, ToolStripMenuItem).Tag, Category)
            If MyCategory.State = Category.enmCategoryState.View Then
                MyCategory.State = Category.enmCategoryState.Add
                Dim NewNode As New TreeNode
                NewNode.Text = String.Empty
                If MyCategory.CategoryTreeView.SelectedNode Is Nothing OrElse MyCategory.CategoryTreeView.SelectedNode.Parent Is Nothing Then
                    MyCategory.CategoryTreeView.Nodes.Add(NewNode)
                    MyCategory.CategoryTreeView.SelectedNode = NewNode
                    NewNode.BeginEdit()
                Else
                    MyCategory.CategoryTreeView.SelectedNode.Parent.Nodes.Add(NewNode)
                    MyCategory.CategoryTreeView.SelectedNode = NewNode
                    NewNode.BeginEdit()
                End If
            End If
        End Sub

        Private Sub CategoryTreeAddChildButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
            Dim MyCategory As Category = DirectCast(DirectCast(sender, ToolStripMenuItem).Tag, Category)
            Try
                If MyCategory.State = Category.enmCategoryState.View Then
                    MyCategory.State = Category.enmCategoryState.Add
                    Dim NewNode As New TreeNode
                    NewNode.Text = String.Empty
                    If MyCategory.CategoryTreeView.SelectedNode Is Nothing Then
                        MyCategory.CategoryTreeView.Nodes.Add(NewNode)
                        MyCategory.CategoryTreeView.SelectedNode = NewNode
                        NewNode.BeginEdit()
                    Else
                        MyCategory.CategoryTreeView.SelectedNode.Nodes.Add(NewNode)
                        MyCategory.CategoryTreeView.SelectedNode = NewNode
                        NewNode.BeginEdit()
                    End If
                End If
            Catch ex As System.Exception
                MyCategory.State = Category.enmCategoryState.View
                Common.MessageBox.ErrorMessage(ex.Message)
            End Try
        End Sub

        Private Sub CategoryTreeEditButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
            Dim MyCategory As Category = DirectCast(DirectCast(sender, ToolStripMenuItem).Tag, Category)
            If MyCategory.CategoryTreeView.SelectedNode IsNot Nothing AndAlso MyCategory.State = Category.enmCategoryState.View Then
                MyCategory.CategoryTreeView.SelectedNode.BeginEdit()
            End If
        End Sub

        Private Sub CategoryTreeDeleteButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
            Dim MyCategory As Category = DirectCast(DirectCast(sender, ToolStripMenuItem).Tag, Category)
            If MyCategory.State = Category.enmCategoryState.View Then
                If Common.MessageBox.ConfirmDeleteMessage = False Then
                    Exit Sub
                End If

                Dim CategoryTreeFactory As New BLL.BLLCategoryTree_TFactory
                Try
                    If MyCategory.CategoryTreeView.SelectedNode Is Nothing Then
                        Exit Sub
                    End If
                    CategoryTreeFactory.BeginProc()
                    DeleteCategory(MyCategory.CategoryTreeView.SelectedNode)
                    CategoryTreeFactory.CommitProc()
                    MyCategory.CategoryTreeView.SelectedNode.Remove()
                Catch ex As System.Exception
                    CategoryTreeFactory.RollBackProc()
                    Common.MessageBox.ErrorMessage(ex.Message)
                End Try
            End If
        End Sub

        Private Sub DeleteCategory(ByVal Node As TreeNode)
            Try
                Dim CategoryMemberFactory As New BLL.BLLCategoryMember_TFactory
                If CategoryMemberFactory.GetAllBy(BLL.BLLCategoryMember_T.CategoryMember_TField.CategoryTreeID_bint, Node.Name).Count > 0 Then
                    Throw New Exception.CategoryIsInUse
                Else
                    Dim CategoryTreeFactory As New BLL.BLLCategoryTree_TFactory
                    CategoryTreeFactory.Delete(BLL.BLLCategoryTree_T.CategoryTree_TField.CategoryTreeID_bint, Node.Name)
                    For index As Integer = 0 To Node.Nodes.Count - 1
                        DeleteCategory(Node.Nodes(index))
                    Next
                End If
            Catch ex As System.Exception
                Throw ex
            End Try
        End Sub

        Private Sub CategoryTreeView_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
            If e.Button = Windows.Forms.MouseButtons.Right Then
                Dim MyCategory As Category = Me.GetCategory(DirectCast(sender, TreeView))
                If MyCategory Is Nothing OrElse MyCategory.CategoryComboBox.SelectedValue Is Nothing Then
                    Exit Sub
                End If

                Dim AddParentContextMenu As New System.Windows.Forms.ToolStripMenuItem
                AddParentContextMenu.Image = My.Resources.Resources.RootAdd
                AddParentContextMenu.Name = "AddParentContextMenu"
                AddParentContextMenu.Text = My.Resources.Captions.AddParentCategory
                AddParentContextMenu.Tag = MyCategory
                AddHandler AddParentContextMenu.Click, AddressOf CategoryTreeAddParentButton_Click

                Dim AddChildContextMenu As New System.Windows.Forms.ToolStripMenuItem
                AddChildContextMenu.Image = My.Resources.Resources.ChildAdd
                AddChildContextMenu.Name = "AddChildContextMenu"
                AddChildContextMenu.Text = My.Resources.Captions.AddChildCategory
                AddChildContextMenu.Tag = MyCategory
                AddHandler AddChildContextMenu.Click, AddressOf CategoryTreeAddChildButton_Click

                Dim EditContextMenu As New System.Windows.Forms.ToolStripMenuItem
                EditContextMenu.Image = My.Resources.Resources.Edit
                EditContextMenu.Name = "EditContextMenu"
                EditContextMenu.Text = My.Resources.Captions.EditCategory
                EditContextMenu.Tag = MyCategory
                AddHandler EditContextMenu.Click, AddressOf CategoryTreeEditButton_Click

                Dim DeleteContextMenu As New System.Windows.Forms.ToolStripMenuItem
                DeleteContextMenu.Image = My.Resources.Resources.Delete
                DeleteContextMenu.Name = "DeleteContextMenu"
                DeleteContextMenu.Text = My.Resources.Captions.DeleteCategory
                DeleteContextMenu.Tag = MyCategory
                AddHandler DeleteContextMenu.Click, AddressOf CategoryTreeDeleteButton_Click

                Dim ContextMenuStrip As New ContextMenuStrip
                ContextMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {AddParentContextMenu, AddChildContextMenu, EditContextMenu, DeleteContextMenu})

                AddParentContextMenu.Enabled = IIf(MyCategory.CategoryTreeView.GetNodeAt(e.Location) Is Nothing, True, True)
                AddChildContextMenu.Enabled = IIf(MyCategory.CategoryTreeView.GetNodeAt(e.Location) Is Nothing, False, True)
                EditContextMenu.Enabled = IIf(MyCategory.CategoryTreeView.GetNodeAt(e.Location) Is Nothing, False, True)
                DeleteContextMenu.Enabled = IIf(MyCategory.CategoryTreeView.GetNodeAt(e.Location) Is Nothing, False, True)

                If MyCategory.CategoryTreeView.Nodes.Count > 0 AndAlso MyCategory.CategoryTreeView.GetNodeAt(e.Location) IsNot Nothing AndAlso MyCategory.CategoryTreeView.GetNodeAt(e.Location).Bounds.X <= e.Location.X AndAlso MyCategory.CategoryTreeView.GetNodeAt(e.Location).Bounds.X + MyCategory.CategoryTreeView.GetNodeAt(e.Location).Bounds.Width >= e.Location.X Then
                    MyCategory.CategoryTreeView.SelectedNode = MyCategory.CategoryTreeView.GetNodeAt(e.Location)
                    ContextMenuStrip.Show(MyCategory.CategoryTreeView, e.Location)
                ElseIf MyCategory.CategoryTreeView.Nodes.Count = 0 Then
                    MyCategory.CategoryTreeView.SelectedNode = MyCategory.CategoryTreeView.GetNodeAt(e.Location)
                    ContextMenuStrip.Show(MyCategory.CategoryTreeView, e.Location)
                End If
            End If
        End Sub

        Private Sub SearchButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
            Dim SearchForm As New SearchTreeViewForm(Me.GetCategory(DirectCast(sender, Button)).CategoryTreeView)
            SearchForm.Show()
        End Sub

        Protected Sub AddCategory(ByVal Key As String, ByRef ComboBox As ComboBox, ByRef TreeView As TreeView, Optional ByVal SearchButton As Button = Nothing)
            If ComboBox Is Nothing OrElse TreeView Is Nothing Then
                Exit Sub
            End If
            If Me.GetCategory(ComboBox) IsNot Nothing OrElse Me.GetCategory(TreeView) IsNot Nothing Then
                Exit Sub
            End If

            Dim MyCategory As New Category
            MyCategory.Key = Key
            MyCategory.CategoryComboBox = ComboBox
            MyCategory.CategoryTreeView = TreeView
            MyCategory.State = Category.enmCategoryState.View
            MyCategory.CategoryTreeView.LabelEdit = True
            MyCategory.CategorySearchButton = SearchButton

            If MyCategory.CategorySearchButton IsNot Nothing Then
                AddHandler MyCategory.CategorySearchButton.Click, AddressOf SearchButton_Click
            End If
            AddHandler ComboBox.SelectedValueChanged, AddressOf CategoryComboBox_SelectedValueChanged
            AddHandler ComboBox.TextChanged, AddressOf CategoryComboBox_SelectedValueChanged
            AddHandler MyCategory.CategoryTreeView.AfterLabelEdit, AddressOf CategoryTreeView_AfterLabelEdit
            AddHandler MyCategory.CategoryTreeView.BeforeLabelEdit, AddressOf CategoryTreeView_BeforeLabelEdit
            AddHandler MyCategory.CategoryTreeView.BeforeSelect, AddressOf CategoryTreeView_BeforeSelect
            AddHandler MyCategory.CategoryTreeView.MouseDown, AddressOf CategoryTreeView_MouseDown
            AddHandler TreeView.AfterCheck, AddressOf CategoryTreeView_AfterCheck
            Me._CategoryList.Add(MyCategory)
        End Sub

        Private Sub CategoryComboBox_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
            Dim MyCategory As Category = Me.GetCategory(DirectCast(sender, ComboBox))
            If sender.SelectedValue IsNot Nothing AndAlso String.IsNullOrEmpty(sender.text) = False Then
                Me.FillCategoryTreeView(MyCategory)
                MyCategory.State = Category.enmCategoryState.View
            Else
                MyCategory.CategoryTreeView.Nodes.Clear()
            End If
        End Sub

        Private Sub CategoryTreeView_AfterCheck(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TreeViewEventArgs)
            For index As Integer = 0 To Me._CategoryList.Count - 1
                If Me._CategoryList.Item(index).CategoryTreeView Is sender Then
                    If e.Node.Checked = True Then
                        If Me._CategoryList.Item(index).SelectedCategory.IndexOf(e.Node.Name) = -1 Then
                            Me._CategoryList.Item(index).SelectedCategory.Add(e.Node.Name)
                        End If
                        If e.Node.Parent IsNot Nothing Then
                            e.Node.Parent.Checked = True
                        End If
                    Else
                        If Me._CategoryList.Item(index).SelectedCategory.IndexOf(e.Node.Name) <> -1 Then
                            Me._CategoryList.Item(index).SelectedCategory.RemoveAt(Me._CategoryList.Item(index).SelectedCategory.IndexOf(e.Node.Name))
                        End If
                        For j As Integer = 0 To e.Node.Nodes.Count - 1
                            e.Node.Nodes.Item(j).Checked = False
                        Next
                    End If
                End If
            Next
        End Sub

        Private Sub FillCategoryTreeView(ByRef Category As Category)
            Try
                Category.CategoryTreeView.Nodes.Clear()
                Dim CategoryTreeFactory As New BLL.BLLCategoryTree_TFactory
                Dim CategoryTreeDataTable As New DataTable
                CategoryTreeFactory.GetAllBy(BLL.BLLCategoryTree_T.CategoryTree_TField.CategoryID_bint, Category.CategoryComboBox.SelectedValue, CategoryTreeDataTable)
                Me.MakeCategoryTree(Nothing, CategoryTreeDataTable, Nothing, Category)
            Catch ex As System.Exception
                Common.MessageBox.ErrorMessage(ex.Message)
            End Try
        End Sub

        Private Sub MakeCategoryTree(ByVal ParentID As Nullable(Of Int64), ByRef DataTable As DataTable, ByRef Node As TreeNode, ByRef Category As Category)
            Dim dr() As DataRow
            If ParentID.HasValue Then
                dr = DataTable.Select(BLL.BLLCategoryTree_T.CategoryTree_TField.ParentID_bint.ToString + " = " + ParentID.ToString)
            Else
                dr = DataTable.Select(BLL.BLLCategoryTree_T.CategoryTree_TField.ParentID_bint.ToString + " IS NULL")
            End If
            For index As Integer = 0 To dr.Length - 1
                Dim MyNode As New TreeNode
                MyNode.Name = dr(index).Item(BLL.BLLCategoryTree_T.CategoryTree_TField.CategoryTreeID_bint.ToString)
                MyNode.Text = dr(index).Item(BLL.BLLCategoryTree_T.CategoryTree_TField.Node_nvc.ToString)
                If Category.SelectedCategory.IndexOf(MyNode.Name) > -1 Then
                    MyNode.Checked = True
                End If
                If Node Is Nothing AndAlso Category.CategoryTreeView IsNot Nothing Then
                    Category.CategoryTreeView.Nodes.Add(MyNode)
                ElseIf Node IsNot Nothing AndAlso Category.CategoryTreeView IsNot Nothing Then
                    Node.Nodes.Add(MyNode)
                    If Node.Checked AndAlso MyNode.Checked Then
                        Node.Expand()
                    End If
                End If
                Me.MakeCategoryTree(dr(index).Item(BLL.BLLCategoryTree_T.CategoryTree_TField.CategoryTreeID_bint.ToString), DataTable, MyNode, Category)
            Next
        End Sub

        Protected Sub SaveCategory(ByVal MemberID As String, ByVal TableID As Int64)
            Try
                Dim CategoryTreeMemberFactory As New BLL.BLLCategoryMember_TFactory
                CategoryTreeMemberFactory.Delete(BLL.BLLCategoryMember_T.CategoryMember_TField.MemberID_nvc, MemberID)
                Dim CategoryTreeEntity As New BLL.BLLCategoryMember_T
                For index As Integer = 0 To Me._CategoryList.Count - 1
                    For j As Integer = 0 To Me._CategoryList.Item(index).SelectedCategory.Count - 1
                        CategoryTreeEntity.CategoryTreeID_bint = Me._CategoryList.Item(index).SelectedCategory.Item(j)
                        CategoryTreeEntity.MemberID_nvc = MemberID
                        CategoryTreeEntity.TableID_bint = TableID
                        CategoryTreeMemberFactory.Insert(CategoryTreeEntity)
                    Next
                Next
            Catch ex As System.Exception
                Throw ex
            End Try
        End Sub

        Protected Sub LoadCategory(ByVal MemberId As String)
            Try
                Dim CategoryTreeMemberFactory As New BLL.BLLCategoryMember_TFactory
                Dim Entity As List(Of BLL.BLLCategoryMember_T) = CategoryTreeMemberFactory.GetAllBy(BLL.BLLCategoryMember_T.CategoryMember_TField.MemberID_nvc, MemberId)
                For j As Integer = 0 To Me._CategoryList.Count - 1
                    Me._CategoryList.Item(j).SelectedCategory.Clear()
                Next
                For index As Integer = 0 To Entity.Count - 1
                    For j As Integer = 0 To Me._CategoryList.Count - 1
                        Me._CategoryList.Item(j).SelectedCategory.Add(Entity.Item(index).CategoryTreeID_bint)
                    Next
                Next
                For j As Integer = 0 To Me._CategoryList.Count - 1
                    Me._CategoryList.Item(j).CategoryComboBox.SelectedIndex = -1
                Next
            Catch ex As System.Exception
                Throw ex
            End Try
        End Sub

        Protected Sub DeleteCategory(ByVal MemberId As String)
            Try
                Dim CategoryTreeMemberFactory As New BLL.BLLCategoryMember_TFactory
                CategoryTreeMemberFactory.Delete(BLL.BLLCategoryMember_T.CategoryMember_TField.MemberID_nvc, MemberId)
            Catch ex As System.Exception
                Throw ex
            End Try
        End Sub

#End Region

    End Class
End Namespace