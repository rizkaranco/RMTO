Namespace PL
    Public Class BaseListForm

        Public Class Group
            Inherits PL.BaseForm

            Private _CollapseButton As ToolStripButton
            Private _ExpandButton As ToolStripButton
            Private _GroupName As String
            Private _FilterStack As Stack
            Private _ToolStrip As ToolStrip
            Private _AddButton As Object
            Private _EditButton As ToolStripButton
            Private _DeleteButton As ToolStripButton
            Private _RefreshButton As ToolStripButton
            Private _ExportButton As ToolStripButton
            Private _PrintButton As ToolStripButton
            Private _HelpBookMarkButton As ToolStripButton
            Private _RowCountLabel As ToolStripLabel

            Private _FilterFieldComboBox As ToolStripComboBox
            Private _FilterOperatorComboBox As ToolStripComboBox
            Private _FilterTextBox As ToolStripTextBox
            Private _FilterButton As ToolStripButton
            Private _UndoFilterButton As ToolStripButton
            Private _ClearFilterButton As ToolStripButton
            Private _Grid As Object
            Private _RecordCount As ToolStripLabel
            Private _GridColumnPercent As Collection
            Private _GridColumnSize As Collection
            Private _OperatorDataTable As DataTable
            Private _HasFilterControl As Boolean = False
            Private _HelpBookMark As String
            Private _LevelLen As Object
            Private _AddButtonCaption As New List(Of String)

            Private _DeleteButtonEnable As Boolean = True
            Private _EditButtonEnable As Boolean = True
            Private _RefreshButtonEnable As Boolean = True
            Private _AddButtonEnable As Boolean = True
            Private _ExportButtonEnable As Boolean = True
            Private _PrintButtonEnable As Boolean = True
            Private _JanusGridExDataSource As DataView
            Private _LastFilterField As String
            Private _LastFilterOperator As String
            Private _GridDataSourceChanged As Boolean = False

            Public Sub New()
                Me._FilterStack = New Stack
                Me._GridColumnPercent = New Collection
                Me._GridColumnSize = New Collection

                Me._OperatorDataTable = New DataTable
                Me._OperatorDataTable.Columns.Add("Operator")
                Me._OperatorDataTable.Columns.Add("DataType")
                Me._OperatorDataTable.Columns.Add("Title")

                Dim dr As DataRow

                dr = _OperatorDataTable.NewRow
                dr.Item("Operator") = "Field Like '%Value%'"
                dr.Item("DataType") = "System.String"
                dr.Item("Title") = My.Resources.Captions.Includes
                _OperatorDataTable.Rows.Add(dr)

                dr = _OperatorDataTable.NewRow
                dr.Item("Operator") = "Field = Value"
                dr.Item("DataType") = "System.Int16;System.Int32;System.Int64;System.Single;System.Double;System.Date;System.Decimal"
                dr.Item("Title") = My.Resources.Captions.Equal
                _OperatorDataTable.Rows.Add(dr)


                dr = _OperatorDataTable.NewRow
                dr.Item("Operator") = "Field = 'Value'"
                dr.Item("DataType") = "System.String"
                dr.Item("Title") = My.Resources.Captions.Equal
                _OperatorDataTable.Rows.Add(dr)

                dr = _OperatorDataTable.NewRow
                dr.Item("Operator") = "Field Like 'Value%'"
                dr.Item("DataType") = "System.String"
                dr.Item("Title") = My.Resources.Captions.StartsWith
                _OperatorDataTable.Rows.Add(dr)

                dr = _OperatorDataTable.NewRow
                dr.Item("Operator") = "Field Like '%Value'"
                dr.Item("DataType") = "System.String"
                dr.Item("Title") = My.Resources.Captions.EndsWith
                _OperatorDataTable.Rows.Add(dr)

                dr = _OperatorDataTable.NewRow
                dr.Item("Operator") = "Field Not Like '%Value%'"
                dr.Item("DataType") = "System.String"
                dr.Item("Title") = My.Resources.Captions.NotInclude
                _OperatorDataTable.Rows.Add(dr)

                dr = _OperatorDataTable.NewRow
                dr.Item("Operator") = "Field <> 'Value'"
                dr.Item("Title") = My.Resources.Captions.NotEqual
                dr.Item("DataType") = "System.String"
                _OperatorDataTable.Rows.Add(dr)

                dr = _OperatorDataTable.NewRow
                dr.Item("Operator") = "Field <> Value"
                dr.Item("Title") = My.Resources.Captions.NotEqual
                dr.Item("DataType") = "System.Int16;System.Int32;System.Int64;System.Single;System.Double;System.Date;System.Decimal"
                _OperatorDataTable.Rows.Add(dr)

                dr = _OperatorDataTable.NewRow
                dr.Item("Operator") = "Field > Value"
                dr.Item("Title") = My.Resources.Captions.GreaterThan
                dr.Item("DataType") = "System.Int16;System.Int32;System.Int64;System.Single;System.Double;System.Date;System.Decimal"
                _OperatorDataTable.Rows.Add(dr)

                dr = _OperatorDataTable.NewRow
                dr.Item("Operator") = "Field >= Value"
                dr.Item("Title") = My.Resources.Captions.GreaterOrEqual
                dr.Item("DataType") = "System.Int16;System.Int32;System.Int64;System.Single;System.Double;System.Date;System.Decimal"
                _OperatorDataTable.Rows.Add(dr)


                dr = _OperatorDataTable.NewRow
                dr.Item("Operator") = "Field > 'Value'"
                dr.Item("Title") = My.Resources.Captions.GreaterThan
                dr.Item("DataType") = "System.String"
                _OperatorDataTable.Rows.Add(dr)

                dr = _OperatorDataTable.NewRow
                dr.Item("Operator") = "Field >= 'Value'"
                dr.Item("Title") = My.Resources.Captions.GreaterOrEqual
                dr.Item("DataType") = "System.String"
                _OperatorDataTable.Rows.Add(dr)


                dr = _OperatorDataTable.NewRow
                dr.Item("Operator") = "Field < 'Value'"
                dr.Item("Title") = My.Resources.Captions.LessThan
                dr.Item("DataType") = "System.String"
                _OperatorDataTable.Rows.Add(dr)

                dr = _OperatorDataTable.NewRow
                dr.Item("Operator") = "Field <= 'Value'"
                dr.Item("Title") = My.Resources.Captions.LessOrEqual
                dr.Item("DataType") = "System.String"
                _OperatorDataTable.Rows.Add(dr)


                dr = _OperatorDataTable.NewRow
                dr.Item("Operator") = "Field < Value"
                dr.Item("Title") = My.Resources.Captions.LessThan
                dr.Item("DataType") = "System.Int16;System.Int32;System.Int64;System.Single;System.Double;System.Date;System.Decimal"
                _OperatorDataTable.Rows.Add(dr)

                dr = _OperatorDataTable.NewRow
                dr.Item("Operator") = "Field <= Value"
                dr.Item("Title") = My.Resources.Captions.LessOrEqual
                dr.Item("DataType") = "System.Int16;System.Int32;System.Int64;System.Single;System.Double;System.Date;System.Decimal"
                _OperatorDataTable.Rows.Add(dr)
            End Sub
           






#Region "Help"

#Region "Function"

            Public Sub CreateHelpButton()
                If String.IsNullOrEmpty(Me._HelpBookMark) = False Then
                    Me.ToolStrip.Items.Add(Me.HelpBookMarkButton)
                End If
            End Sub

#End Region

#Region "Property"

            Public ReadOnly Property HelpBookMarkButton() As ToolStripButton
                Get
                    If Me._HelpBookMarkButton Is Nothing Then
                        Me._HelpBookMarkButton = New ToolStripButton
                        AddHandler Me._HelpBookMarkButton.Click, AddressOf Me.HelpWanted
                        Me._HelpBookMarkButton.ToolTipText = My.Resources.Captions.Help
                        Dim KeyConvertor As New KeysConverter
                        If Me._HelpBookMarkButton.ToolTipText.EndsWith(" : " + KeyConvertor.ConvertToString(Int32.Parse(My.Settings.HelpButton))) = False Then
                            Me._HelpBookMarkButton.ToolTipText += " : " + KeyConvertor.ConvertToString(Int32.Parse(My.Settings.HelpButton))
                        End If
                        Me._HelpBookMarkButton.Image = My.Resources.help
                    End If
                    Return Me._HelpBookMarkButton
                End Get
            End Property

            Public Property HelpBookMark() As String
                Get
                    Return Me._HelpBookMark
                End Get
                Set(ByVal value As String)
                    Me._HelpBookMark = value
                End Set
            End Property

#End Region

#End Region

#Region "Filter"

#Region "Property"

            Public Property HasFilterControl() As Boolean
                Get
                    Return _HasFilterControl
                End Get
                Set(ByVal value As Boolean)
                    Me._HasFilterControl = value
                End Set
            End Property

            Private Property FilterStack() As Stack
                Get
                    Return _FilterStack
                End Get
                Set(ByVal value As Stack)
                    Me._FilterStack = value
                End Set
            End Property

            Private ReadOnly Property FilterTextBox() As ToolStripTextBox
                Get
                    If Me._FilterTextBox Is Nothing Then
                        Me._FilterTextBox = New ToolStripTextBox
                        AddHandler Me._FilterTextBox.TextChanged, AddressOf FilterTextBox_TextChanged
                        AddHandler Me._FilterTextBox.KeyDown, AddressOf FilterTextBox_KeyDown
                    End If
                    Return _FilterTextBox
                End Get
            End Property

            Private ReadOnly Property FilterButton() As ToolStripButton
                Get
                    If Me._FilterButton Is Nothing Then
                        Me._FilterButton = New ToolStripButton
                        Me._FilterButton.Enabled = False
                        Me._FilterButton.Image = My.Resources.AddFilter
                        AddHandler Me._FilterButton.Click, AddressOf Me.Filter
                    End If
                    Return _FilterButton
                End Get
            End Property

            Private ReadOnly Property UndoFilterButton() As ToolStripButton
                Get
                    If Me._UndoFilterButton Is Nothing Then
                        Me._UndoFilterButton = New ToolStripButton
                        Me._UndoFilterButton.Enabled = False
                        Me._UndoFilterButton.Image = My.Resources.UndoFilter
                        AddHandler Me._UndoFilterButton.Click, AddressOf Me.UndoFilter
                    End If
                    Return _UndoFilterButton
                End Get
            End Property

            Private ReadOnly Property ClearFilterButton() As ToolStripButton
                Get
                    If Me._ClearFilterButton Is Nothing Then
                        Me._ClearFilterButton = New ToolStripButton
                        Me._ClearFilterButton.Enabled = False
                        Me._ClearFilterButton.Image = My.Resources.ClearFilter
                        AddHandler Me._ClearFilterButton.Click, AddressOf Me.ClearFilter
                    End If
                    Return _ClearFilterButton
                End Get
            End Property

            Private ReadOnly Property FilterOperatorComboBox() As ToolStripComboBox
                Get
                    If Me._FilterOperatorComboBox Is Nothing Then
                        Me._FilterOperatorComboBox = New ToolStripComboBox
                        Me._FilterOperatorComboBox.Size = New System.Drawing.Size(125, _FilterOperatorComboBox.Size.Height)
                        Me._FilterOperatorComboBox.ComboBox.DataSource = _OperatorDataTable
                        Me._FilterOperatorComboBox.ComboBox.DisplayMember = "Title"
                        Me._FilterOperatorComboBox.ComboBox.ValueMember = "Operator"
                        Me._FilterOperatorComboBox.DropDownStyle = ComboBoxStyle.DropDownList
                    End If
                    Return _FilterOperatorComboBox
                End Get
            End Property

            Private ReadOnly Property FilterFieldComboBox() As ToolStripComboBox
                Get
                    If Me._FilterFieldComboBox Is Nothing Then
                        Me._FilterFieldComboBox = New ToolStripComboBox
                        Me._FilterFieldComboBox.DropDownStyle = ComboBoxStyle.DropDownList
                        AddHandler Me._FilterFieldComboBox.SelectedIndexChanged, AddressOf Me.FilterFieldComboboxChanged
                    End If
                    Return _FilterFieldComboBox
                End Get
            End Property

            Private ReadOnly Property SearchCaptionLabel() As ToolStripLabel
                Get
                    Dim lbl As New ToolStripLabel
                    With lbl
                        .Text = My.Resources.Captions.Search
                    End With
                    Return lbl
                End Get
            End Property

#End Region

#Region "Function"

            Private Sub FilterTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
                If Me.FilterTextBox.Text = "" Then
                    Me.FilterButton.Enabled = False
                Else
                    Me.FilterButton.Enabled = True
                    FilterButton.ToolTipText = "اعمال جستجو"
                End If
            End Sub

            Private Sub FilterTextBox_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
                If e.KeyCode = Keys.Enter AndAlso Me.FilterButton.Enabled = True Then
                    Filter(sender, New EventArgs)
                    MyBase.RaiseKeyDownEvent = False
                End If
            End Sub

            Private Sub FilterFieldComboboxChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
                Try
                    Dim rs As String = ""
                    rs = Me.FilterFieldComboBox.ComboBox.SelectedValue
                    If TypeOf Me.Grid.DataSource Is DataView Then
                        rs = DirectCast(Me.Grid.DataSource, DataView).ToTable.Columns(rs).DataType.ToString
                    Else
                        rs = DirectCast(Me.Grid.DataSource, DataTable).Columns(rs).DataType.ToString
                    End If
                    rs = "DataType Like '%" + rs + "%'"
                    Me._OperatorDataTable.DefaultView.RowFilter = rs
                    Me.FilterOperatorComboBox.ComboBox.DataSource = Me._OperatorDataTable.DefaultView.ToTable
                    If Me.FilterFieldComboBox.ComboBox.SelectedValue = Me._LastFilterField Then
                        Me._FilterOperatorComboBox.ComboBox.SelectedValue = Me._LastFilterOperator
                        Me._LastFilterField = String.Empty
                    End If
                Catch ex As System.Exception
                End Try
            End Sub

            Public Sub GridDataSourceChange(ByVal sender As System.Object, ByVal e As System.EventArgs)
                If Me._GridDataSourceChanged = False Then
                    If sender.datasource IsNot Nothing AndAlso Me._HasFilterControl AndAlso Me.FilterFieldComboBox.ComboBox.Items.Count > 0 Then
                        Me.FilterFieldComboboxChanged(Me.FilterFieldComboBox, New EventArgs)
                    End If
                End If
                Me._GridDataSourceChanged = True
            End Sub

            Public Sub Filter(ByVal sender As System.Object, ByVal e As System.EventArgs)
                If Me.HasFilterControl = False _
                OrElse Me.FilterTextBox.Text = "" _
                OrElse Me.Grid Is Nothing _
                OrElse Me.Grid.DataSource Is Nothing _
                OrElse Me.FilterFieldComboBox.ComboBox.SelectedIndex = -1 _
                OrElse Me.FilterButton.Enabled = False _
                Then
                    Return
                End If

                Dim rs As String
                rs = Me.FilterOperatorComboBox.ComboBox.SelectedValue
                If rs.IndexOf("'") = -1 AndAlso IsNumeric(Me.FilterTextBox.Text) = False Then
                    Exit Sub
                End If
                If rs.IndexOf("%") > -1 Then
                    rs = rs.Replace("Field", Me.FilterFieldComboBox.ComboBox.SelectedValue).Replace("Value", Common.PersentationController.CorrectLike(Me.FilterTextBox.Text))
                Else
                    rs = rs.Replace("Field", Me.FilterFieldComboBox.ComboBox.SelectedValue).Replace("Value", Me.FilterTextBox.Text.Replace("'", "''"))
                End If

                Dim RowFilter As String
                If TypeOf Me.Grid.DataSource Is DataView Then
                    RowFilter = DirectCast(Me.Grid.DataSource, DataView).ToTable.DefaultView.RowFilter
                Else
                    RowFilter = DirectCast(Me.Grid.DataSource, DataTable).DefaultView.RowFilter
                End If

                If RowFilter = String.Empty Then
                    RowFilter = rs
                Else
                    RowFilter += " AND " + rs
                End If

                'If TypeOf Me.Grid.DataSource Is DataView Then
                '    If Me.FilterStack.Count = 0 Then
                '        Me._JanusGridExDataSource = Me.Grid.DataSource
                '    End If
                '    Me.FilterStack.Push(DirectCast(Me.Grid.DataSource, DataView).RowFilter)
                '    Dim dv As New DataView
                '    dv = DirectCast(Me.Grid.DataSource, DataView).ToTable.DefaultView
                '    dv.RowFilter = RowFilter

                '    If TypeOf Me.Grid Is Janus.Windows.GridEX.GridEX Then
                '        DirectCast(Me.Grid, Janus.Windows.GridEX.GridEX).SetDataBinding(dv, "")
                '    Else
                '        Me.Grid.DataSource = dv.ToTable
                '    End If

                'Else
                '    Me.FilterStack.Push(DirectCast(Me.Grid.DataSource, DataTable).DefaultView.RowFilter)
                '    DirectCast(Me.Grid.DataSource, DataTable).DefaultView.RowFilter = RowFilter
                'End If
                If TypeOf Me.Grid.DataSource Is DataView Then
                    If Me.FilterStack.Count = 0 Then
                        Me._JanusGridExDataSource = Me.Grid.DataSource
                    End If
                    Me.FilterStack.Push(DirectCast(Me.Grid.DataSource, DataView).RowFilter)
                    Dim dv As New DataView
                    dv = DirectCast(Me.Grid.DataSource, DataView).ToTable.DefaultView
                    dv.RowFilter = RowFilter
                    DirectCast(Me.Grid, Janus.Windows.GridEX.GridEX).SetDataBinding(dv, "")
                Else

                    If TypeOf Me.Grid Is Janus.Windows.GridEX.GridEX Then
                        Dim dv As New DataView(DirectCast(Me.Grid.DataSource, DataTable))
                        If Me.FilterStack.Count = 0 Then
                            Me._JanusGridExDataSource = DirectCast(Me.Grid.DataSource, DataTable).DefaultView
                        End If
                        Me.FilterStack.Push(DirectCast(Me.Grid.DataSource, DataTable).DefaultView.RowFilter)

                        dv.RowFilter = RowFilter
                        DirectCast(Me.Grid, Janus.Windows.GridEX.GridEX).SetDataBinding(dv, "")
                    Else
                        Me.FilterStack.Push(DirectCast(Me.Grid.DataSource, DataTable).DefaultView.RowFilter)
                        DirectCast(Me.Grid.DataSource, DataTable).DefaultView.RowFilter = RowFilter
                    End If

                End If
                UndoFilterButton.Enabled = True
                UndoFilterButton.ToolTipText = "یک مرحله بازگشت به عقب"
                ClearFilterButton.Enabled = True
                ClearFilterButton.ToolTipText = "حذف جستجو"
                ' FilterTextBox.Clear()
                FilterTextBox.Focus()
            End Sub

            Public Sub UndoFilter(ByVal sender As System.Object, ByVal e As System.EventArgs)
                If Me._UndoFilterButton.Enabled = False Then
                    Return
                End If

                Dim rs As String = ""
                If Me.FilterStack.Count = 0 Then
                    Return
                End If
                rs = Me.FilterStack.Pop
                If TypeOf Me.Grid.DataSource Is DataView Then
                    Dim dv As New DataView
                    dv = _JanusGridExDataSource
                    dv.RowFilter = rs
                    If TypeOf Me.Grid Is Janus.Windows.GridEX.GridEX Then
                        DirectCast(Me.Grid, Janus.Windows.GridEX.GridEX).SetDataBinding(dv, "")
                    Else
                        Me.Grid.DataSource = dv
                    End If
                Else
                    DirectCast(Me.Grid.DataSource, DataTable).DefaultView.RowFilter = rs
                End If
                If Me.FilterStack.Count > 0 Then
                    Me.UndoFilterButton.Enabled = True
                    UndoFilterButton.ToolTipText = "یک مرحله بازگشت به عقب"
                    Me.ClearFilterButton.Enabled = True
                    ClearFilterButton.ToolTipText = "حذف جستجو"
                Else
                    Me.UndoFilterButton.Enabled = False
                    Me.ClearFilterButton.Enabled = False
                End If
            End Sub

            Public Sub ClearFilter(ByVal sender As System.Object, ByVal e As System.EventArgs)
                Me.FilterStack.Clear()
                If TypeOf Me.Grid.DataSource Is DataView Then
                    If TypeOf Me.Grid Is Janus.Windows.GridEX.GridEX Then
                        DirectCast(Me.Grid, Janus.Windows.GridEX.GridEX).SetDataBinding(Me._JanusGridExDataSource, "")
                    Else
                        DirectCast(Me.Grid.DataSource, DataView).ToTable.DefaultView.RowFilter = ""
                    End If

                Else
                    DirectCast(Me.Grid.DataSource, DataTable).DefaultView.RowFilter = ""
                End If
                Me.UndoFilterButton.Enabled = False
                Me.ClearFilterButton.Enabled = False
                Me.FilterButton.Enabled = False
                '  Me.FilterTextBox.Clear()
            End Sub

            Public Sub CreateFilterControl()
                Dim MaxFieldCaptionName As Single = 0
                Dim MeasureSize As Single
                If Me.ToolStrip IsNot Nothing Then
                    If Me.HasFilterControl = True AndAlso Me.Grid IsNot Nothing Then
                        Dim dt As New DataTable
                        dt.Columns.Add(New DataColumn("HeaderText"))
                        dt.Columns.Add(New DataColumn("DataPropertyName"))
                        If TypeOf Me.Grid Is DataGridView Then
                            For Each col As DataGridViewColumn In DirectCast(Me.Grid, DataGridView).Columns
                                If col.Visible = True AndAlso col.CellType IsNot GetType(System.Windows.Forms.DataGridViewCheckBoxCell) AndAlso String.IsNullOrEmpty(col.HeaderText) = False Then
                                    Dim dr As DataRow = dt.NewRow
                                    dr.Item("HeaderText") = col.HeaderText
                                    dr.Item("DataPropertyName") = col.DataPropertyName
                                    MeasureSize = Common.PersentationController.Measure(col.HeaderText, Me.FilterFieldComboBox.Name, Me.FilterFieldComboBox.Font.Size).Width + 40
                                    If MeasureSize > MaxFieldCaptionName Then
                                        MaxFieldCaptionName = MeasureSize
                                    End If
                                    dt.Rows.Add(dr)
                                End If
                            Next
                        ElseIf TypeOf Grid Is Janus.Windows.GridEX.GridEX Then
                            For Each col As Janus.Windows.GridEX.GridEXColumn In DirectCast(Me.Grid, Janus.Windows.GridEX.GridEX).RootTable.Columns
                                If col.Visible = True AndAlso col.ColumnType = Janus.Windows.GridEX.ColumnType.Text AndAlso String.IsNullOrEmpty(col.Caption) = False Then
                                    Dim dr As DataRow = dt.NewRow
                                    dr.Item("HeaderText") = col.Caption
                                    dr.Item("DataPropertyName") = col.DataMember
                                    MeasureSize = Common.PersentationController.Measure(col.Caption, Me.FilterFieldComboBox.Name, Me.FilterFieldComboBox.Font.Size).Width + 40
                                    If MeasureSize > MaxFieldCaptionName Then
                                        MaxFieldCaptionName = MeasureSize
                                    End If
                                    dt.Rows.Add(dr)
                                End If
                            Next
                        End If

                        Me.FilterFieldComboBox.ComboBox.DisplayMember = "HeaderText"
                        Me.FilterFieldComboBox.ComboBox.ValueMember = "DataPropertyName"
                        Me.FilterFieldComboBox.ComboBox.DataSource = dt

                        Me.FilterFieldComboboxChanged(FilterFieldComboBox, New EventArgs)
                        Me.FilterFieldComboBox.Size = New Size(MaxFieldCaptionName, Me.FilterFieldComboBox.Size.Height)

                        If ToolStrip.Items.Count > 0 Then
                            Dim Separator As New ToolStripSeparator
                            Me.ToolStrip.Items.Add(Separator)
                        End If

                        Me.ToolStrip.Items.Add(Me.SearchCaptionLabel)
                        Me.ToolStrip.Items.Add(Me.FilterFieldComboBox)
                        Me.ToolStrip.Items.Add(Me.FilterOperatorComboBox)
                        Me.ToolStrip.Items.Add(Me.FilterTextBox)
                        Me.ToolStrip.Items.Add(Me.FilterButton)
                        Me.ToolStrip.Items.Add(Me.UndoFilterButton)
                        Me.ToolStrip.Items.Add(Me.ClearFilterButton)

                        If dt.Rows.Count > 0 Then
                            Me.FilterFieldComboBox.ComboBox.SelectedValue = dt.Rows(0).Item("DataPropertyName")
                        End If
                    End If
                    If Me.ToolStrip.Items.Count > 0 Then
                        Dim RowCountSeperator As New ToolStripSeparator
                        Me.ToolStrip.Items.Add(RowCountSeperator)
                    End If
                    Me.ToolStrip.Items.Add(Me.RowCountLabel)
                End If
            End Sub

#End Region

#End Region

#Region "Group"

#Region "Property"

            Public Property DeleteButtonEnable() As Boolean
                Get
                    Return _DeleteButtonEnable
                End Get
                Set(ByVal value As Boolean)
                    Me._DeleteButtonEnable = value
                End Set
            End Property

            Public Property EditButtonEnable() As Boolean
                Get
                    Return _EditButtonEnable
                End Get
                Set(ByVal value As Boolean)
                    Me._EditButtonEnable = value
                End Set
            End Property

            Public Property AddButtonEnable() As Boolean
                Get
                    Return _AddButtonEnable
                End Get
                Set(ByVal value As Boolean)
                    Me._AddButtonEnable = value
                    If Me.Grid IsNot Nothing AndAlso (TypeOf Grid Is DataGridView OrElse TypeOf Grid Is Janus.Windows.GridEX.GridEX) Then
                        Me.GridRecordCountChanged(Me.Grid, New EventArgs)
                    End If
                End Set
            End Property

            Public Property ExportButtonEnable() As Boolean
                Get
                    Return _ExportButtonEnable
                End Get
                Set(ByVal value As Boolean)
                    Me._ExportButtonEnable = value
                End Set
            End Property

            Public Property RefreshButtonEnable() As Boolean
                Get
                    Return _RefreshButtonEnable
                End Get
                Set(ByVal value As Boolean)
                    Me._RefreshButtonEnable = value
                End Set
            End Property

            Public Property PrintButtonEnable() As Boolean
                Get
                    Return _PrintButtonEnable
                End Get
                Set(ByVal value As Boolean)
                    Me._PrintButtonEnable = value
                End Set
            End Property

            Public Property AddButtonCaption() As List(Of String)
                Get
                    Return Me._AddButtonCaption
                End Get
                Set(ByVal value As List(Of String))
                    Me._AddButtonCaption = value
                End Set
            End Property

            Public Property GroupName() As String
                Get
                    Return _GroupName
                End Get
                Set(ByVal value As String)
                    Me._GroupName = value
                End Set
            End Property

            Public Property RecordCount() As ToolStripLabel
                Get
                    Return _RecordCount
                End Get
                Set(ByVal value As ToolStripLabel)
                    Me._RecordCount = value
                End Set
            End Property

            Public Property ToolStrip() As ToolStrip
                Get
                    Return _ToolStrip
                End Get
                Set(ByVal value As ToolStrip)
                    Me._ToolStrip = value
                End Set
            End Property

            Public Property AddButton() As Object
                Get
                    Return _AddButton
                End Get
                Set(ByVal value As Object)
                    Me._AddButton = value
                    Me.AddButtonCaption.Clear()
                    If TypeOf _AddButton Is ToolStripSplitButton Then
                        Dim AddButton As ToolStripSplitButton = DirectCast(_AddButton, ToolStripSplitButton)
                        For index As Integer = 0 To AddButton.DropDownItems.Count - 1
                            Me.AddButtonCaption.Add(AddButton.DropDownItems(index).Text)
                        Next
                    ElseIf _AddButton IsNot Nothing Then
                        Dim KeyConvertor As New KeysConverter
                        If Me._AddButton.ToolTipText.EndsWith(" : " + KeyConvertor.ConvertToString(Int32.Parse(My.Settings.NewButton))) = False Then
                            Me._AddButton.ToolTipText += " : " + KeyConvertor.ConvertToString(Int32.Parse(My.Settings.NewButton))
                        End If
                    End If
                End Set
            End Property

            Public Property EditButton() As ToolStripButton
                Get
                    Return _EditButton
                End Get
                Set(ByVal value As ToolStripButton)
                    Me._EditButton = value
                    If Me._EditButton IsNot Nothing Then
                        Dim KeyConvertor As New KeysConverter
                        If Me._EditButton.ToolTipText.EndsWith(" : " + KeyConvertor.ConvertToString(Int32.Parse(My.Settings.EditButton))) = False Then
                            Me._EditButton.ToolTipText += " : " + KeyConvertor.ConvertToString(Int32.Parse(My.Settings.EditButton))
                        End If
                    End If
                End Set
            End Property

            Public Property DeleteButton() As ToolStripButton
                Get
                    Return _DeleteButton
                End Get
                Set(ByVal value As ToolStripButton)
                    Me._DeleteButton = value
                    If Me._DeleteButton IsNot Nothing Then
                        AddHandler Me._DeleteButton.Click, AddressOf Me.DeleteButtonClick
                        Dim KeyConvertor As New KeysConverter
                        If Me._DeleteButton.ToolTipText.EndsWith(" : " + KeyConvertor.ConvertToString(Int32.Parse(My.Settings.DeleteButton))) = False Then
                            Me._DeleteButton.ToolTipText += " : " + KeyConvertor.ConvertToString(Int32.Parse(My.Settings.DeleteButton))
                        End If
                    End If
                End Set
            End Property

            Public Property RefreshButton() As ToolStripButton
                Get
                    Return _RefreshButton
                End Get
                Set(ByVal value As ToolStripButton)
                    Me._RefreshButton = value
                    If Me._RefreshButton IsNot Nothing Then
                        Dim KeyConvertor As New KeysConverter
                        If Me._RefreshButton.ToolTipText.EndsWith(" : " + KeyConvertor.ConvertToString(Int32.Parse(My.Settings.RefreshButton))) = False Then
                            Me._RefreshButton.ToolTipText += " : " + KeyConvertor.ConvertToString(Int32.Parse(My.Settings.RefreshButton))
                        End If
                    End If
                End Set
            End Property

            Public Property ExportButton() As ToolStripButton
                Get
                    Return _ExportButton
                End Get
                Set(ByVal value As ToolStripButton)
                    Me._ExportButton = value
                    If Me.ExportButton IsNot Nothing Then
                        AddHandler Me.ExportButton.Click, AddressOf ExportToExcel
                    End If
                End Set
            End Property

            Public Property PrintButton() As ToolStripButton
                Get
                    Return _PrintButton
                End Get
                Set(ByVal value As ToolStripButton)
                    Me._PrintButton = value
                End Set
            End Property

            Public Property CollapseButton() As ToolStripButton
                Get
                    Return Me._CollapseButton
                End Get
                Set(ByVal value As ToolStripButton)
                    Me._CollapseButton = value
                End Set
            End Property

            Public Property ExpandButton() As ToolStripButton
                Get
                    Return Me._ExpandButton
                End Get
                Set(ByVal value As ToolStripButton)
                    Me._ExpandButton = value
                End Set
            End Property

            Public Property Grid(Optional ByVal SetGridProperty As Boolean = True, Optional ByVal SetGridColumnPercent As Boolean = True, Optional ByVal FillGrid As Boolean = False) As Object
                Get
                    Return _Grid
                End Get
                Set(ByVal value As Object)
                    Me._Grid = value
                    If TypeOf value Is DataGridView Then
                        If SetGridColumnPercent = True Then
                            Me.SetGridColumnPercent(Me._Grid)
                            AddHandler DirectCast(Me._Grid, DataGridView).SizeChanged, AddressOf SetGridColSize
                            AddHandler DirectCast(Me._Grid, DataGridView).RowsAdded, AddressOf SetGridColSize
                            AddHandler DirectCast(Me._Grid, DataGridView).RowsRemoved, AddressOf SetGridColSize
                        ElseIf FillGrid = True Then
                            Me.SetGridColumnSize(Me._Grid)
                            AddHandler DirectCast(Me._Grid, DataGridView).SizeChanged, AddressOf SetGridColSize
                            AddHandler DirectCast(Me._Grid, DataGridView).RowsAdded, AddressOf SetGridColSize
                            AddHandler DirectCast(Me._Grid, DataGridView).RowsRemoved, AddressOf SetGridColSize
                        End If
                        If SetGridProperty = True Then
                            Me.SetGridProperty()
                        End If
                        AddHandler DirectCast(Me._Grid, DataGridView).Paint, AddressOf Me.GridRecordCountChanged
                        AddHandler DirectCast(Me.Grid, DataGridView).KeyDown, AddressOf Me.Grid_KeyDown
                        AddHandler DirectCast(Me.Grid, DataGridView).MouseDoubleClick, AddressOf Me.GridView_DoubleClick
                        AddHandler DirectCast(Me._Grid, DataGridView).DataSourceChanged, AddressOf GridDataSourceChange
                        AddHandler DirectCast(Me._Grid, DataGridView).Paint, AddressOf Grid_Paint
                        If SetGridColumnPercent Then
                            Me.SetGridColSize(Me._Grid, New EventArgs)
                        End If
                    ElseIf TypeOf value Is Janus.Windows.GridEX.GridEX Then
                        If SetGridColumnPercent = True Then
                            Me.SetGridColumnPercent(Me._Grid)
                            AddHandler DirectCast(Me._Grid, Janus.Windows.GridEX.GridEX).SizeChanged, AddressOf SetGridColSize
                            AddHandler DirectCast(Me._Grid, Janus.Windows.GridEX.GridEX).RowCountChanged, AddressOf SetGridColSize
                        End If
                        If SetGridProperty = True Then
                            Me.SetGridProperty()
                        End If
                        AddHandler DirectCast(Me._Grid, Janus.Windows.GridEX.GridEX).Paint, AddressOf Me.GridRecordCountChanged
                        AddHandler DirectCast(Me.Grid, Janus.Windows.GridEX.GridEX).KeyDown, AddressOf Me.Grid_KeyDown
                        AddHandler DirectCast(Me.Grid, Janus.Windows.GridEX.GridEX).MouseDoubleClick, AddressOf Me.GridView_DoubleClick
                        AddHandler DirectCast(Me._Grid, Janus.Windows.GridEX.GridEX).BindingContextChanged, AddressOf GridDataSourceChange
                        AddHandler DirectCast(Me._Grid, Janus.Windows.GridEX.GridEX).Paint, AddressOf Grid_Paint
                        If SetGridColumnPercent Then
                            Me.SetGridColSize(Me._Grid, New EventArgs)
                        End If
                    ElseIf TypeOf value Is TreeView Then
                        AddHandler DirectCast(Me.Grid, TreeView).KeyDown, AddressOf Me.Grid_KeyDown
                    End If
                End Set
            End Property

            Public WriteOnly Property GridColumnPercent() As Collection
                Set(ByVal value As Collection)
                    Me._GridColumnPercent = value
                End Set
            End Property

            Private ReadOnly Property RowCountLabel() As ToolStripLabel
                Get
                    If Me._RowCountLabel Is Nothing Then
                        Me._RowCountLabel = New ToolStripLabel
                        Me._RowCountLabel.Name = "RowCountLabel"
                        Me._RowCountLabel.Text = String.Empty
                    End If
                    Return Me._RowCountLabel
                End Get
            End Property

            Protected Sub DeleteButtonClick(ByVal sender As Object, ByVal e As EventArgs)
                Dim LogFactory As New Hepsa.Core.BLL.BLLLog_TFactory
                Dim LogEntity As New Hepsa.Core.BLL.BLLLog_T
                Try
                    LogEntity.Date_nvc = LogFactory.ServerJalaliDate
                    LogEntity.Time_nvc = LogFactory.ServerTime
                    LogEntity.IPAddress_nvc = Hepsa.Core.Common.ApplicationInfo.IpAddress
                    LogEntity.MacAddress_nvc = Hepsa.Core.Common.ApplicationInfo.MacAddress
                    LogEntity.UserName_nvc = Hepsa.Core.Common.CurrentUser.User.UserName_nvc
                    LogEntity.FormText_nvc = Me.Name
                    LogEntity.ActionID_int = Hepsa.Core.BLL.BLLAction_T.Actions.Delete
                    LogEntity.Body_nvc = Me.MakeLog(Me)
                    LogFactory.BeginProc()

                    If String.IsNullOrEmpty(LogEntity.Body_nvc) = False Then
                        LogFactory.Insert(LogEntity)
                    End If

                    LogFactory.CommitProc()
                Catch ex As System.Exception
                    LogFactory.RollBackProc()
                    Common.MessageBox.ErrorMessage(ex.Message)
                End Try
            End Sub

#End Region

#Region "Function"

            Private Sub Grid_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
                If e.KeyCode = Keys.Enter AndAlso Me.EditButton IsNot Nothing AndAlso Me.EditButton.Enabled = True Then
                    Me.EditButton.PerformClick()
                    e.Handled = True
                End If
            End Sub

            Public Sub SetGridColSize(ByVal sender As System.Object, ByVal e As System.EventArgs)
                Try
                    Dim DataGridView As DataGridView
                    Dim JanusGridEx As Janus.Windows.GridEX.GridEX

                    If TypeOf sender Is DataGridView Then
                        DataGridView = DirectCast(sender, DataGridView)
                    ElseIf TypeOf sender Is Janus.Windows.GridEX.GridEX Then
                        JanusGridEx = DirectCast(sender, Janus.Windows.GridEX.GridEX)
                    End If

                    Dim ExtraWidth As Double = 0
                    Dim ColCount As Integer = 0

                    If DataGridView IsNot Nothing Then
                        If Me._GridColumnPercent.Count > 0 Then
                            Dim ScrollSize As Integer = 5
                            If Common.PersentationController.DataGridViewHasVerticalScroll(DataGridView) Then
                                ScrollSize = 20
                            End If
                            Dim Width As Single = DataGridView.Width - ScrollSize
                            For Each col As DataGridViewColumn In DataGridView.Columns
                                If col.CellType Is GetType(System.Windows.Forms.DataGridViewCheckBoxCell) AndAlso col.Visible = True Then
                                    ExtraWidth += Width * Me._GridColumnPercent.Item(col.Name) / 100 - col.Width
                                ElseIf Me._GridColumnPercent.Item(col.Name) > 0 Then
                                    ColCount += 1
                                End If
                            Next
                            For Each col As DataGridViewColumn In DataGridView.Columns
                                If col.CellType IsNot GetType(System.Windows.Forms.DataGridViewCheckBoxCell) AndAlso Me._GridColumnPercent.Item(col.Name) > 0 Then
                                    col.Width = (Width * Me._GridColumnPercent.Item(col.Name) / 100) + (ExtraWidth / ColCount)
                                End If
                            Next
                        ElseIf Me._GridColumnSize.Count > 0 Then
                            For Each col As DataGridViewColumn In DataGridView.Columns
                                col.Width = Me._GridColumnSize.Item(col.Name)
                            Next
                            Common.PersentationController.DataGridViewColumnFill(DataGridView)
                        End If
                    ElseIf JanusGridEx IsNot Nothing Then
                        If Me._GridColumnPercent.Count > 0 Then
                            Dim ScrollSize As Integer = 5
                            If Common.PersentationController.DataGridViewHasVerticalScroll(JanusGridEx) Then
                                ScrollSize = 20
                            End If
                            Dim Width As Single = JanusGridEx.Width - ScrollSize
                            For Each col As Janus.Windows.GridEX.GridEXColumn In JanusGridEx.RootTable.Columns
                                col.Width = Width * Me._GridColumnPercent.Item(col.Key) / 100
                            Next
                        ElseIf Me._GridColumnSize.Count > 0 Then

                        End If
                    End If
                Catch ex As System.Exception
                End Try
            End Sub

            Private Sub GridRecordCountChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
                If Me.Grid.CurrentRow IsNot Nothing Then
                    If Me.AddButton IsNot Nothing Then
                        Me.AddButton.Enabled = True And Me.AddButtonEnable
                    End If
                    If Me.EditButton IsNot Nothing Then
                        Me.EditButton.Enabled = True And Me.EditButtonEnable
                    End If
                    If Me.DeleteButton IsNot Nothing Then
                        Me.DeleteButton.Enabled = True And Me.DeleteButtonEnable
                    End If
                    If Me.ExportButton IsNot Nothing Then
                        Me.ExportButton.Enabled = True And Me.ExportButtonEnable
                    End If
                    If Me.PrintButton IsNot Nothing Then
                        Me.PrintButton.Enabled = True And Me.PrintButtonEnable
                    End If
                Else
                    If Me.AddButton IsNot Nothing Then
                        Me.AddButton.Enabled = True And Me.AddButtonEnable
                    End If
                    If Me.EditButton IsNot Nothing Then
                        Me.EditButton.Enabled = False And Me.EditButtonEnable
                    End If
                    If Me.DeleteButton IsNot Nothing Then
                        Me.DeleteButton.Enabled = False And Me.DeleteButtonEnable
                    End If
                    If Me.ExportButton IsNot Nothing Then
                        Me.ExportButton.Enabled = False And Me.ExportButtonEnable
                    End If
                    If Me.PrintButton IsNot Nothing Then
                        Me.PrintButton.Enabled = False And Me.PrintButtonEnable
                    End If
                End If
                If Me.RecordCount IsNot Nothing Then
                    Me.RecordCount.Text = Me.Grid.Rows.Count
                End If
            End Sub

            Public Sub SetGridColumnPercent(ByVal Grid As DataGridView)
                Me._GridColumnPercent.Clear()
                For Each col As DataGridViewColumn In Grid.Columns
                    If col.Visible = True Then
                        Me._GridColumnPercent.Add(col.Width / Grid.Width * 100, col.Name)
                    Else
                        Me._GridColumnPercent.Add(0, col.Name)
                    End If
                Next
            End Sub

            Public Sub SetGridColumnSize(ByVal Grid As DataGridView)
                Me._GridColumnSize.Clear()
                For Each col As DataGridViewColumn In Grid.Columns
                    If col.Visible = True Then
                        Me._GridColumnSize.Add(col.Width, col.Name)
                    Else
                        Me._GridColumnSize.Add(0, col.Name)
                    End If
                Next
            End Sub

            Public Sub SetGridColumnPercent(ByVal Grid As Janus.Windows.GridEX.GridEX)
                Me._GridColumnPercent.Clear()
                For Each col As Janus.Windows.GridEX.GridEXColumn In Grid.RootTable.Columns
                    If col.Visible = True Then
                        Me._GridColumnPercent.Add(col.Width / Grid.Width * 100, col.Key)
                    Else
                        Me._GridColumnPercent.Add(0, col.Key)
                    End If
                Next
            End Sub

            Private Sub SetGridProperty()
                If TypeOf Grid Is DataGridView Then
                    DirectCast(Grid, DataGridView).AllowUserToAddRows = False
                    DirectCast(Grid, DataGridView).AllowUserToDeleteRows = False
                    DirectCast(Grid, DataGridView).AllowUserToOrderColumns = False
                    DirectCast(Grid, DataGridView).AllowUserToResizeColumns = True
                    DirectCast(Grid, DataGridView).AllowUserToResizeRows = False
                    DirectCast(Grid, DataGridView).MultiSelect = False
                    DirectCast(Grid, DataGridView).ReadOnly = True
                    DirectCast(Grid, DataGridView).RowHeadersVisible = False
                    DirectCast(Grid, DataGridView).AutoGenerateColumns = False
                    DirectCast(Grid, DataGridView).SelectionMode = DataGridViewSelectionMode.FullRowSelect
                    DirectCast(Grid, DataGridView).AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(205, 226, 252)
                    DirectCast(Grid, DataGridView).DefaultCellStyle.BackColor = Color.White
                ElseIf TypeOf Grid Is Janus.Windows.GridEX.GridEX Then
                    DirectCast(Grid, Janus.Windows.GridEX.GridEX).AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.False
                    DirectCast(Grid, Janus.Windows.GridEX.GridEX).AllowDelete = Janus.Windows.GridEX.InheritableBoolean.False
                    DirectCast(Grid, Janus.Windows.GridEX.GridEX).AllowColumnDrag = False
                    DirectCast(Grid, Janus.Windows.GridEX.GridEX).AlternatingColors = True
                    DirectCast(Grid, Janus.Windows.GridEX.GridEX).VisualStyle = Janus.Windows.GridEX.VisualStyle.Standard
                    DirectCast(Grid, Janus.Windows.GridEX.GridEX).SelectionMode = Janus.Windows.GridEX.SelectionMode.SingleSelection
                    DirectCast(Grid, Janus.Windows.GridEX.GridEX).GroupByBoxVisible = False
                    DirectCast(Grid, Janus.Windows.GridEX.GridEX).RowHeaders = Janus.Windows.GridEX.InheritableBoolean.False
                End If
            End Sub

            Public Sub LoadTreeView(ByVal PkFieldName As String, ByVal ParentFieldName As String, ByVal TextField As String, ByRef DataSource As DataTable, Optional ByVal Node As Object = Nothing)
                Try
                    Application.DoEvents()

                    If Not TypeOf Me._Grid Is TreeView Then
                        Return
                    End If

                    Dim Condition As String = String.Empty
                    If TypeOf Node Is TreeView Then
                        Condition = ParentFieldName + " Is NULL"
                    ElseIf TypeOf Node Is TreeNode Then
                        Condition = ParentFieldName + " = '" + Node.Name.Replace("'", "''") + "'"
                    End If

                    Dim dr() As DataRow = DataSource.Select(Condition)
                    For index As Integer = 0 To dr.Length - 1
                        Dim myNode As New TreeNode
                        myNode.Name = dr(index).Item(PkFieldName)
                        myNode.Text = dr(index).Item(TextField)
                        Node.Nodes.Add(myNode)
                        Me.LoadTreeView(PkFieldName, ParentFieldName, TextField, DataSource, myNode)
                    Next
                Catch ex As System.Exception
                    Throw ex
                End Try
            End Sub

            Public Sub ColapsToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
                If TypeOf Grid Is TreeView Then
                    If DirectCast(Me.Grid, TreeView).SelectedNode IsNot Nothing Then
                        DirectCast(Grid, TreeView).SelectedNode.BackColor = System.Drawing.SystemColors.Window
                        DirectCast(Grid, TreeView).SelectedNode.ForeColor = System.Drawing.SystemColors.WindowText
                    End If
                    DirectCast(Grid, TreeView).CollapseAll()
                End If
            End Sub

            Public Sub ExpandToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
                If TypeOf Grid Is TreeView Then
                    DirectCast(Grid, TreeView).ExpandAll()
                End If
            End Sub

                Private Sub GridView_DoubleClick(ByVal sender As System.Object, ByVal e As MouseEventArgs)
                If e.Button = Windows.Forms.MouseButtons.Left Then
                    If TypeOf sender Is DataGridView Then
                        Dim Grid As DataGridView = DirectCast(sender, DataGridView)
                        If e.Location.Y >= Grid.ColumnHeadersHeight Then
                            If Me.EditButton IsNot Nothing AndAlso Me.EditButton.Visible = True AndAlso Me.EditButton.Enabled = True Then
                                Me.EditButton.PerformClick()
                            End If
                        End If
                    ElseIf TypeOf sender Is Janus.Windows.GridEX.GridEX Then
                        Dim Grid As Janus.Windows.GridEX.GridEX = DirectCast(sender, Janus.Windows.GridEX.GridEX)
                        If Grid.CurrentColumn IsNot Nothing Then
                            If Me.EditButton IsNot Nothing AndAlso Me.EditButton.Visible = True AndAlso Me.EditButton.Enabled = True Then
                                Me.EditButton.PerformClick()
                            End If
                        End If
                    End If
                End If
            End Sub

            Private Sub HelpWanted(ByVal sender As Object, ByVal e As EventArgs)
                Dim HelpFilePath As String = (Application.StartupPath + "\Help\MainPage.html").Replace("\", "/")
                If String.IsNullOrEmpty(Me.HelpBookMark) = False Then
                    HelpFilePath += "#" + Me.HelpBookMark
                End If
                HelpFilePath = "file:///" + HelpFilePath
                Dim frm As New WebExplorerForm(HelpFilePath)
                frm.Show()
            End Sub

            Private Sub ExportToExcel(ByVal sender As Object, ByVal e As EventArgs)
                If Me.Grid Is Nothing OrElse TypeOf Me.Grid Is TreeView Then
                    Exit Sub
                End If
                Dim OldCulture As System.Globalization.CultureInfo = System.Threading.Thread.CurrentThread.CurrentCulture
                Try
                    Dim FilePath As String = String.Empty
                    Dim SaveFileDialog As New SaveFileDialog
                    SaveFileDialog.OverwritePrompt = False
                    SaveFileDialog.Filter = "Excel WorkBook(*.xlsx)|*.xlsx"
                    If SaveFileDialog.ShowDialog = Windows.Forms.DialogResult.OK Then
                        FilePath = SaveFileDialog.FileName
                    Else
                        Exit Sub
                    End If
                    Dim RowCount As Integer = -1
                    Dim ColumnCount As Integer = -1
                    If TypeOf Grid Is DataGridView Then
                        For Column As Integer = 0 To DirectCast(Grid, DataGridView).ColumnCount - 1
                            If DirectCast(Grid, DataGridView).Columns(Column).Visible = True Then
                                ColumnCount += 1
                            End If
                        Next
                        RowCount = DirectCast(Grid, DataGridView).RowCount
                    ElseIf TypeOf Grid Is Janus.Windows.GridEX.GridEX Then
                        For Column As Integer = 0 To DirectCast(Grid, Janus.Windows.GridEX.GridEX).RootTable.Columns.Count - 1
                            If DirectCast(Grid, Janus.Windows.GridEX.GridEX).RootTable.Columns(Column).Visible = True Then
                                ColumnCount += 1
                            End If
                        Next
                        RowCount = DirectCast(Grid, Janus.Windows.GridEX.GridEX).RowCount
                    End If

                    Dim GridData(RowCount, ColumnCount) As String
                    Dim CurrentColumn As Integer = -1
                    If TypeOf Grid Is DataGridView Then
                        For Column As Integer = 0 To DirectCast(Grid, DataGridView).ColumnCount - 1
                            If DirectCast(Grid, DataGridView).Columns(Column).Visible = True Then
                                CurrentColumn += 1
                                GridData(0, CurrentColumn) = DirectCast(Grid, DataGridView).Columns.Item(Column).HeaderText
                            End If
                        Next
                    ElseIf TypeOf Grid Is Janus.Windows.GridEX.GridEX Then
                        For Column As Integer = 0 To DirectCast(Grid, Janus.Windows.GridEX.GridEX).RootTable.Columns.Count - 1
                            If DirectCast(Grid, Janus.Windows.GridEX.GridEX).RootTable.Columns(Column).Visible = True Then
                                CurrentColumn += 1
                                GridData(0, CurrentColumn) = DirectCast(Grid, Janus.Windows.GridEX.GridEX).RootTable.Columns(Column).Caption
                            End If
                        Next
                    End If

                    CurrentColumn = -1
                    If TypeOf Grid Is DataGridView Then
                        For Row As Integer = 0 To DirectCast(Grid, DataGridView).RowCount - 1
                            For Column As Integer = 0 To DirectCast(Grid, DataGridView).ColumnCount - 1
                                If DirectCast(Grid, DataGridView).Columns(Column).Visible = True Then
                                    CurrentColumn += 1
                                    If DirectCast(Grid, DataGridView).Rows(Row).Cells(Column).Value Is Nothing Then
                                        GridData(Row + 1, CurrentColumn) = String.Empty
                                    Else
                                        GridData(Row + 1, CurrentColumn) = DirectCast(Grid, DataGridView).Rows(Row).Cells(Column).Value.ToString
                                    End If
                                End If
                            Next
                            CurrentColumn = -1
                        Next
                    ElseIf TypeOf Grid Is Janus.Windows.GridEX.GridEX Then
                        For Row As Integer = 0 To DirectCast(Grid, Janus.Windows.GridEX.GridEX).RowCount - 1
                            For Column As Integer = 0 To DirectCast(Grid, Janus.Windows.GridEX.GridEX).RootTable.Columns.Count - 1
                                If DirectCast(Grid, Janus.Windows.GridEX.GridEX).RootTable.Columns(Column).Visible = True Then
                                    CurrentColumn += 1
                                    GridData(Row + 1, CurrentColumn) = DirectCast(Grid, Janus.Windows.GridEX.GridEX).GetRow(Row).Cells(Column).Value.ToString
                                End If
                            Next
                            CurrentColumn = -1
                        Next
                    End If

                    System.Threading.Thread.CurrentThread.CurrentCulture = New System.Globalization.CultureInfo("en-US")
                    Dim ExcelApplication As New Microsoft.Office.Interop.Excel.Application
                    Dim ExcelWorkBook As Microsoft.Office.Interop.Excel.Workbook = ExcelApplication.Workbooks.Add
                    Dim ExcelWorkSheet As Microsoft.Office.Interop.Excel.Worksheet = ExcelWorkBook.Sheets("Sheet1")
                    ExcelWorkSheet.Range("A1").Resize(RowCount + 1, ColumnCount + 1).Value = GridData
                    Try
                        ExcelWorkSheet.SaveAs(FilePath)
                    Catch ex As System.Exception
                        Exit Sub
                    End Try
                    ExcelWorkBook.Close()
                    ExcelApplication.Quit()
                    System.Runtime.InteropServices.Marshal.ReleaseComObject(ExcelApplication)
                    ExcelApplication = Nothing
                    System.Runtime.InteropServices.Marshal.ReleaseComObject(ExcelWorkBook)
                    ExcelWorkBook = Nothing
                    System.Runtime.InteropServices.Marshal.ReleaseComObject(ExcelWorkSheet)
                    ExcelWorkSheet = Nothing
                    Common.MessageBox.InformationMessage(My.Resources.Exceptions.ExportToExcelComplete)
                Catch ex As System.Exception
                    Common.MessageBox.ErrorMessage(My.Resources.Exceptions.ExcelExportError)
                Finally
                    System.Threading.Thread.CurrentThread.CurrentCulture = OldCulture
                End Try
            End Sub

            Public Sub FilterTextBosFocus()
                If ((Not Me._FilterTextBox Is Nothing) And Me._HasFilterControl) Then
                    Me._FilterTextBox.Focus()
                    Me._FilterTextBox.SelectAll()
                End If
            End Sub




            Private Sub Grid_Paint(ByVal sender As Object, ByVal e As PaintEventArgs)
                Dim RowCount As Integer = 0
                If TypeOf Me.Grid Is DataGridView Then
                    If DirectCast(Me.Grid, DataGridView).DataSource IsNot Nothing Then
                        If TypeOf DirectCast(Me.Grid, DataGridView).DataSource Is DataTable Then
                            RowCount = DirectCast(DirectCast(Me.Grid, DataGridView).DataSource, DataTable).DefaultView.Count
                        ElseIf TypeOf DirectCast(Me.Grid, DataGridView).DataSource Is DataView Then
                            RowCount = DirectCast(DirectCast(Me.Grid, DataGridView).DataSource, DataView).Count
                        End If
                    End If
                ElseIf TypeOf Me.Grid Is Janus.Windows.GridEX.GridEX Then
                    If DirectCast(Me.Grid, Janus.Windows.GridEX.GridEX).DataSource IsNot Nothing Then
                        If TypeOf DirectCast(Me.Grid, Janus.Windows.GridEX.GridEX).DataSource Is DataTable Then
                            RowCount = DirectCast(DirectCast(Me.Grid, Janus.Windows.GridEX.GridEX).DataSource, DataTable).DefaultView.Count
                        ElseIf TypeOf DirectCast(Me.Grid, Janus.Windows.GridEX.GridEX).DataSource Is DataView Then
                            RowCount = DirectCast(DirectCast(Me.Grid, Janus.Windows.GridEX.GridEX).DataSource, DataView).Count
                        End If
                    End If
                End If
                Me.RowCountLabel.Text = String.Format("تعداد داده ها = {0}", RowCount)
            End Sub

            Private Function MakeLog(ByVal row As Object) As String
                Dim str As String = String.Empty
                If TypeOf row Is DataGridViewRow Then
                    For index As Integer = 0 To DirectCast(row, DataGridViewRow).Cells.Count - 1
                        If DirectCast(row, DataGridViewRow).Cells(index).Visible = True Then
                            Dim ValueStr As String = String.Empty

                            If TypeOf DirectCast(row, DataGridViewRow).DataGridView.Columns(DirectCast(row, DataGridViewRow).Cells(index).ColumnIndex) Is DataGridViewTextBoxColumn Then
                                ValueStr = DirectCast(row, DataGridViewRow).Cells(index).Value.ToString
                            ElseIf TypeOf DirectCast(row, DataGridViewRow).DataGridView.Columns(DirectCast(row, DataGridViewRow).Cells(index).ColumnIndex) Is DataGridViewCheckBoxColumn Then
                                If Hepsa.Core.Common.PersentationController.GetEntityValue(DirectCast(row, DataGridViewRow).Cells(index).Value, TypeCode.Boolean) = True Then
                                    ValueStr = "√"
                                Else
                                    ValueStr = ""
                                End If
                            End If
                            str += String.Format("<tr><td>{0}</td><td>{1}</td></tr>", DirectCast(row, DataGridViewRow).DataGridView.Columns(DirectCast(row, DataGridViewRow).Cells(index).ColumnIndex).HeaderText, ValueStr)
                        End If
                    Next
                ElseIf TypeOf row Is Janus.Windows.GridEX.GridEXRow Then

                    For index As Integer = 0 To DirectCast(row, Janus.Windows.GridEX.GridEXRow).Cells.Count - 1
                        If DirectCast(row, Janus.Windows.GridEX.GridEXRow).Cells(index).Column.Visible = True Then
                            Dim ValueStr As String = String.Empty

                            If DirectCast(row, Janus.Windows.GridEX.GridEXRow).Cells(index).Column.ColumnType = Janus.Windows.GridEX.ColumnType.Text Then
                                ValueStr = DirectCast(row, Janus.Windows.GridEX.GridEXRow).Cells(index).Value.ToString
                            ElseIf DirectCast(row, Janus.Windows.GridEX.GridEXRow).Cells(index).Column.ColumnType = Janus.Windows.GridEX.ColumnType.CheckBox Then
                                If Hepsa.Core.Common.PersentationController.GetEntityValue(DirectCast(row, DataGridViewRow).Cells(index).Value, TypeCode.Boolean) = True Then
                                    ValueStr = "√"
                                Else
                                    ValueStr = ""
                                End If
                            End If
                            str += String.Format("<tr><td>{0}</td><td>{1}</td></tr>", DirectCast(row, Janus.Windows.GridEX.GridEXRow).Cells(index).Column.Caption, ValueStr)

                        End If
                    Next
                End If
                Return String.Format("<table>{0}</table>", str)
            End Function

#End Region

#End Region

        End Class

        Public Class GroupList
            Private _Items As New List(Of Group)
            Private _Graphic As Graphics

            Public Sub Add(ByVal Item As Group)
                Item.CreateHelpButton()
                Item.CreateFilterControl()
                If Item.CollapseButton IsNot Nothing AndAlso TypeOf Item.Grid Is TreeView Then
                    AddHandler Item.CollapseButton.Click, AddressOf Item.ColapsToolStripButton_Click
                End If
                If Item.ExpandButton IsNot Nothing AndAlso TypeOf Item.Grid Is TreeView Then
                    AddHandler Item.ExpandButton.Click, AddressOf Item.ExpandToolStripButton_Click
                End If
                Me._Items.Add(Item)
            End Sub

            Public ReadOnly Property Count() As Integer
                Get
                    Return Me._Items.Count
                End Get
            End Property

            Public Sub Clear()
                Me._Items.Clear()
            End Sub

            Public Property Item(ByVal index As Integer) As Group
                Get
                    If index >= 0 AndAlso index <= Me.Count - 1 Then
                        Return Me._Items(index)
                    Else
                        Return Nothing
                    End If
                End Get
                Set(ByVal value As Group)
                    If index >= 0 AndAlso index <= Me.Count - 1 Then
                        Me._Items(index) = value
                    End If
                End Set
            End Property

            Public ReadOnly Property Item(ByVal GroupName As String) As Group
                Get
                    For index As Integer = 0 To Me.Count - 1
                        If Item(index).GroupName = GroupName Then
                            Return Item(index)
                        End If
                    Next
                    Return Nothing
                End Get
            End Property

            Public Sub New(ByVal Graphic As Graphics)
                Me._Graphic = Graphic
            End Sub

        End Class

        Public Class GroupRelation

            Private _LockGroup1SelectionEvent As Boolean = False
            Private _LockGroup2SelectionEvent As Boolean = True

            Public Enum enmRelationType As Byte
                Eual = 0
                StartWith = 1
            End Enum

            Public Enum enmChildDataShowType
                Filter = 0
                Find = 1
            End Enum

            Private Enum enmGroups
                Group1
                Group2
            End Enum

            Public Enum enmConnectionType
                Online
                Offline
            End Enum

            Public Class RelationStructure
                Public Group1 As Group
                Public Group2 As Group
                Public Group1FilterColumn As String
                Public Group2FilterColumn As String
                Public Group1BusinessFactory As Object
                Public Group2BusinessFactory As Object
                Public Group1RelationType As enmRelationType
                Public Group2RelationType As enmRelationType
                Public Group1ChildDataShowType As enmChildDataShowType
                Public Group2ChildDataShowType As enmChildDataShowType
                Public Group1ConnectionType As Nullable(Of enmConnectionType)
                Public Group2ConnectionType As Nullable(Of enmConnectionType)
                Public HasGroup1ChangeEvent As Boolean
                Public HasGroup2ChangeEvent As Boolean
                Public Group1NameField As String
                Public Group2NameField As String
                Public Group1ParentField As String
                Public Group2ParentField As String
                Public Group1PKField As String
                Public Group2PKField As String
                Public Group1LastValue As Object
            End Class

            Private Relations As New List(Of RelationStructure)

            Public ReadOnly Property Item(ByVal Index As Integer) As RelationStructure
                Get
                    Return Relations.Item(Index)
                End Get
            End Property

            Private Function GetGroups(ByVal Grid As Object, ByVal Group As enmGroups) As List(Of RelationStructure)
                Dim Res As New List(Of RelationStructure)
                For index As Integer = 0 To Relations.Count - 1
                    If Group = enmGroups.Group1 Then
                        If Relations.Item(index).Group1.Grid Is Grid Then
                            Res.Add(Relations.Item(index))
                        End If
                    ElseIf Group = enmGroups.Group2 Then
                        If Relations.Item(index).Group2.Grid Is Grid Then
                            Res.Add(Relations.Item(index))
                        End If
                    End If
                Next
                Return Res
            End Function

            Public Sub Add(ByRef Relation As RelationStructure)
                Me.Relations.Add(Relation)
                If Relation.HasGroup1ChangeEvent Then
                    If TypeOf Relation.Group1.Grid Is DataGridView Then
                        AddHandler DirectCast(Relation.Group1.Grid, DataGridView).SelectionChanged, AddressOf Group1Grid_SelectionChanged
                    ElseIf TypeOf Relation.Group1.Grid Is TreeView Then
                        AddHandler DirectCast(Relation.Group1.Grid, TreeView).AfterSelect, AddressOf Group1TreeView_AfterSelect
                        AddHandler DirectCast(Relation.Group2.Grid, TreeView).BeforeSelect, AddressOf TreeView_BeforeSelect
                    ElseIf TypeOf Relation.Group1.Grid Is Janus.Windows.GridEX.GridEX Then
                        AddHandler DirectCast(Relation.Group1.Grid, Janus.Windows.GridEX.GridEX).SelectionChanged, AddressOf Group1Grid_SelectionChanged
                    End If
                    Relation.Group2.AddButtonEnable = False
                End If

                If Relation.HasGroup2ChangeEvent Then
                    If TypeOf Relation.Group2.Grid Is DataGridView Then
                        AddHandler DirectCast(Relation.Group2.Grid, DataGridView).SelectionChanged, AddressOf Group2Grid_SelectionChanged
                    ElseIf TypeOf Relation.Group2.Grid Is TreeView Then
                        AddHandler DirectCast(Relation.Group2.Grid, TreeView).AfterSelect, AddressOf Group2TreeView_AfterSelect
                        AddHandler DirectCast(Relation.Group2.Grid, TreeView).BeforeSelect, AddressOf TreeView_BeforeSelect
                    ElseIf TypeOf Relation.Group2.Grid Is Janus.Windows.GridEX.GridEX Then
                        AddHandler DirectCast(Relation.Group2.Grid, Janus.Windows.GridEX.GridEX).SelectionChanged, AddressOf Group2Grid_SelectionChanged
                    End If
                End If
            End Sub

            Private Function GetGroups(ByVal Group As enmGroups, ByVal Relation As RelationStructure) As Group
                If Group = enmGroups.Group1 Then
                    Return Relation.Group1
                ElseIf Group = enmGroups.Group2 Then
                    Return Relation.Group2
                Else
                    Return Nothing
                End If
            End Function

            Private Sub Grid_SelectionChanged_SelectRelation(ByVal Grid As Object, ByVal Group As enmGroups)
                Dim Relation As List(Of RelationStructure) = Me.GetGroups(Grid, Group)

                For index As Integer = 0 To Relation.Count - 1
                    If Group = enmGroups.Group1 Then
                        If Relation.Item(index).Group1.Grid IsNot Nothing AndAlso TypeOf Relation.Item(index).Group1.Grid Is DataGridView Then
                            If DirectCast(Relation.Item(index).Group1.Grid, DataGridView).CurrentRow IsNot Nothing AndAlso (Relation.Item(index).Group1LastValue Is Nothing OrElse Relation.Item(index).Group1LastValue <> DirectCast(Relation.Item(index).Group1.Grid, DataGridView).CurrentRow.Cells(Relation.Item(index).Group1FilterColumn).Value) Then
                                Relation.Item(index).Group1LastValue = DirectCast(Relation.Item(index).Group1.Grid, DataGridView).CurrentRow.Cells(Relation.Item(index).Group1FilterColumn).Value
                            Else
                                If TypeOf Relation.Item(index).Group2.Grid Is DataGridView Then
                                    If DirectCast(Relation.Item(index).Group2.Grid, DataGridView).DataSource IsNot Nothing Then
                                        DirectCast(DirectCast(Relation.Item(index).Group2.Grid, DataGridView).DataSource, DataTable).Rows.Clear()
                                    End If
                                ElseIf TypeOf Relation.Item(index).Group2.Grid Is Janus.Windows.GridEX.GridEX Then
                                    If DirectCast(Relation.Item(index).Group2.Grid, Janus.Windows.GridEX.GridEX).DataSource IsNot Nothing Then
                                        DirectCast(DirectCast(Relation.Item(index).Group2.Grid, Janus.Windows.GridEX.GridEX).DataSource, DataTable).Rows.Clear()
                                    End If
                                End If
                            End If
                        ElseIf Relation.Item(index).Group1.Grid IsNot Nothing AndAlso TypeOf Relation.Item(index).Group1.Grid Is Janus.Windows.GridEX.GridEXRow Then
                            If DirectCast(Relation.Item(index).Group1.Grid, Janus.Windows.GridEX.GridEX).CurrentRow IsNot Nothing AndAlso (Relation.Item(index).Group1LastValue Is Nothing OrElse Relation.Item(index).Group1LastValue <> DirectCast(Relation.Item(index).Group1.Grid, Janus.Windows.GridEX.GridEX).CurrentRow.Cells(Relation.Item(index).Group1FilterColumn).Value) Then
                                Relation.Item(index).Group1LastValue = DirectCast(Relation.Item(index).Group1.Grid, Janus.Windows.GridEX.GridEX).CurrentRow.Cells(Relation.Item(index).Group1FilterColumn).Value
                            Else
                                If TypeOf Relation.Item(index).Group2.Grid Is DataGridView Then
                                    If DirectCast(Relation.Item(index).Group2.Grid, DataGridView).DataSource IsNot Nothing Then
                                        DirectCast(DirectCast(Relation.Item(index).Group2.Grid, DataGridView).DataSource, DataTable).Rows.Clear()
                                    End If
                                ElseIf TypeOf Relation.Item(index).Group2.Grid Is Janus.Windows.GridEX.GridEX Then
                                    If DirectCast(Relation.Item(index).Group2.Grid, Janus.Windows.GridEX.GridEX).DataSource IsNot Nothing Then
                                        DirectCast(DirectCast(Relation.Item(index).Group2.Grid, Janus.Windows.GridEX.GridEX).DataSource, DataTable).Rows.Clear()
                                    End If
                                End If
                            End If
                        End If

                        Dim CurrentRowValue As Object = Nothing
                        If Grid.CurrentRow IsNot Nothing Then
                            CurrentRowValue = Grid.CurrentRow.Cells(Relation(index).Group1FilterColumn).Value
                        End If
                        If Relation(index).Group1ChildDataShowType = enmChildDataShowType.Filter Then
                            Me.FilterChild(Relation(index), CurrentRowValue, enmGroups.Group2)
                        ElseIf Relation(index).Group1ChildDataShowType = enmChildDataShowType.Find Then
                            Me.FindChild(Relation(index), CurrentRowValue, enmGroups.Group2)
                        End If

                        Dim Relation2 As List(Of RelationStructure) = Me.GetGroups(Relation(index).Group2.Grid, enmGroups.Group1)
                        For index2 As Integer = 0 To Relation2.Count - 1
                            Grid_SelectionChanged_SelectRelation(Relation2(index2).Group1.Grid, enmGroups.Group1)
                        Next

                    ElseIf Group = enmGroups.Group2 Then
                        Dim CurrentRowValue As Object = Nothing
                        If Grid.CurrentRow IsNot Nothing Then
                            CurrentRowValue = Grid.CurrentRow.Cells(Relation(index).Group2FilterColumn).Value
                        End If
                        If Relation(index).Group1ChildDataShowType = enmChildDataShowType.Filter Then
                            Me.FilterChild(Relation(index), CurrentRowValue, enmGroups.Group1)
                        ElseIf Relation(index).Group1ChildDataShowType = enmChildDataShowType.Find Then
                            Me.FindChild(Relation(index), CurrentRowValue, enmGroups.Group1)
                        End If
                    End If
                Next
            End Sub

            Private Sub Group1Grid_SelectionChanged(ByVal sender As Object, ByVal e As EventArgs)
                Try
                    If Me._LockGroup1SelectionEvent = True Then
                        Exit Sub
                    Else
                        Me._LockGroup2SelectionEvent = True
                    End If

                    If sender.CurrentRow Is Nothing Then
                        Dim Groups As List(Of GroupRelation.RelationStructure) = Me.GetGroups(sender, enmGroups.Group1)
                        For index As Integer = 0 To Groups.Count - 1
                            If TypeOf Groups.Item(index).Group2.Grid Is DataGridView Then
                                If DirectCast(Groups.Item(index).Group2.Grid, DataGridView).DataSource IsNot Nothing Then
                                    DirectCast(DirectCast(Groups.Item(index).Group2.Grid, DataGridView).DataSource, DataTable).Rows.Clear()
                                End If
                            ElseIf TypeOf Groups.Item(index).Group2.Grid Is Janus.Windows.GridEX.GridEX Then
                                If DirectCast(Groups.Item(index).Group2.Grid, DataGridView).DataSource IsNot Nothing Then
                                    DirectCast(DirectCast(Groups.Item(index).Group2.Grid, Janus.Windows.GridEX.GridEX).DataSource, DataTable).Rows.Clear()
                                End If
                            ElseIf TypeOf Groups.Item(index).Group2.Grid Is TreeView Then
                                DirectCast(Groups.Item(index).Group2.Grid, TreeView).Nodes.Clear()
                            End If
                            If Groups.Item(index).Group2.AddButton IsNot Nothing Then
                                Groups.Item(index).Group2.AddButtonEnable = False
                            End If
                        Next
                        Me._LockGroup2SelectionEvent = False
                        Exit Sub
                    Else
                        Dim Groups As List(Of GroupRelation.RelationStructure) = Me.GetGroups(sender, enmGroups.Group1)
                        For index As Integer = 0 To Groups.Count - 1
                            If Groups.Item(index).Group2.AddButton IsNot Nothing Then
                                Groups.Item(index).Group2.AddButtonEnable = True
                            End If
                        Next
                    End If

                    Me.Grid_SelectionChanged_SelectRelation(sender, enmGroups.Group1)

                    Me._LockGroup2SelectionEvent = False

                Catch ex As System.Exception
                    Hepsa.Core.Common.MessageBox.ErrorMessage(ex.Message)
                    BaseListForm.Close()
                End Try
            End Sub

            Private Sub Group2Grid_SelectionChanged(ByVal sender As Object, ByVal e As EventArgs)
                Try
                    If Me._LockGroup2SelectionEvent = True Then
                        Exit Sub
                    Else
                        Me._LockGroup1SelectionEvent = True
                    End If

                    If sender.CurrentRow Is Nothing Then
                        Me._LockGroup1SelectionEvent = False
                        Exit Sub
                    End If

                    Me.Grid_SelectionChanged_SelectRelation(sender, enmGroups.Group2)

                    Me._LockGroup1SelectionEvent = False
                Catch ex As System.Exception
                    Hepsa.Core.Common.MessageBox.ErrorMessage(ex.Message)
                    BaseListForm.Close()
                End Try
            End Sub

            Private Sub FilterChild(ByVal Relation As RelationStructure, ByVal Value As Object, ByVal Group As enmGroups)
                Try
                    Dim TableName As String = String.Empty
                    Dim FieldName As String = String.Empty
                    Dim Condition As String = String.Empty
                    Dim StartCompareOperator As String = String.Empty
                    Dim EndCompareOperator As String = String.Empty
                    Dim BusinessClass As Object = Nothing
                    Dim ConnectionType As enmConnectionType
                    Dim GridMaster As Object = Nothing
                    Dim GridDetail As Object = Nothing

                    If Group = enmGroups.Group1 Then
                        If Relation.Group1ConnectionType.HasValue = False Then
                            Exit Sub
                        End If
                        If Relation.Group1ConnectionType.Value = enmConnectionType.Online Then
                            TableName = Relation.Group1BusinessFactory.TableName
                            BusinessClass = Relation.Group1BusinessFactory
                        End If
                        FieldName = Relation.Group1FilterColumn
                        ConnectionType = Relation.Group1ConnectionType.Value
                        GridMaster = Relation.Group2.Grid
                        GridDetail = Relation.Group1.Grid
                        If Relation.Group1RelationType = enmRelationType.Eual Then
                            StartCompareOperator = "= N'"
                            EndCompareOperator = "'"
                        ElseIf Relation.Group1RelationType = enmRelationType.StartWith Then
                            StartCompareOperator = "Like N'"
                            EndCompareOperator = "%'"
                        End If
                    End If
                    If Group = enmGroups.Group2 Then
                        If Relation.Group2ConnectionType.HasValue = False Then
                            Exit Sub
                        End If
                        If Relation.Group2ConnectionType.Value = enmConnectionType.Online Then
                            TableName = Relation.Group2BusinessFactory.TableName
                            BusinessClass = Relation.Group2BusinessFactory
                        End If
                        FieldName = Relation.Group2FilterColumn
                        ConnectionType = Relation.Group2ConnectionType.Value
                        GridMaster = Relation.Group1.Grid
                        GridDetail = Relation.Group2.Grid
                        If Relation.Group2RelationType = enmRelationType.Eual AndAlso ConnectionType = enmConnectionType.Online Then
                            StartCompareOperator = "= N'"
                            EndCompareOperator = "'"
                        ElseIf Relation.Group2RelationType = enmRelationType.StartWith AndAlso ConnectionType = enmConnectionType.Online Then
                            StartCompareOperator = "Like N'"
                            EndCompareOperator = "%'"
                        ElseIf Relation.Group2RelationType = enmRelationType.Eual AndAlso ConnectionType = enmConnectionType.Offline Then
                            StartCompareOperator = "= '"
                            EndCompareOperator = "'"
                        ElseIf Relation.Group2RelationType = enmRelationType.StartWith AndAlso ConnectionType = enmConnectionType.Offline Then
                            StartCompareOperator = "Like '"
                            EndCompareOperator = "%'"
                        End If
                    End If

                    If ConnectionType = enmConnectionType.Online Then
                        Condition = "[" + TableName + "].[" + FieldName + "] "
                        Condition += StartCompareOperator + Hepsa.Core.Common.PersentationController.CorrectLike(Value) + EndCompareOperator
                    Else
                        Condition = "[" + FieldName + "] "
                        Condition += StartCompareOperator + Hepsa.Core.Common.PersentationController.CorrectLike(Value) + EndCompareOperator
                    End If

                    If TypeOf GridDetail Is DataGridView OrElse TypeOf GridDetail Is Janus.Windows.GridEX.GridEX Then
                        Dim DataSource As DataTable
                        If ConnectionType = enmConnectionType.Offline Then
                            DataSource = DirectCast(GridDetail.DataSource, DataTable)
                            DataSource.DefaultView.RowFilter = Condition
                        Else
                            DataSource = New DataTable
                            BusinessClass.GetAllByCondition(Condition, DataSource)
                            GridDetail.DataSource = DataSource
                        End If
                    ElseIf TypeOf GridDetail Is TreeView Then
                        If Group = enmGroups.Group2 AndAlso String.IsNullOrEmpty(Relation.Group2ParentField) = False AndAlso String.IsNullOrEmpty(Relation.Group2NameField) = False AndAlso String.IsNullOrEmpty(Relation.Group2FilterColumn) = False AndAlso String.IsNullOrEmpty(Relation.Group2PKField) = False Then
                            DirectCast(GridDetail, TreeView).Nodes.Clear()
                            Dim DataTable As New DataTable
                            Relation.Group2BusinessFactory.GetAllByCondition(Condition, DataTable)
                            Relation.Group2.LoadTreeView(Relation.Group2PKField, Relation.Group2ParentField, Relation.Group2NameField, DataTable, GridDetail)
                            DirectCast(GridDetail, TreeView).ExpandAll()
                        ElseIf Group = enmGroups.Group1 AndAlso String.IsNullOrEmpty(Relation.Group1ParentField) = False AndAlso String.IsNullOrEmpty(Relation.Group1NameField) = False AndAlso String.IsNullOrEmpty(Relation.Group1FilterColumn) = False AndAlso String.IsNullOrEmpty(Relation.Group2PKField) = False Then
                            DirectCast(GridDetail, TreeView).Nodes.Clear()
                            Dim DataTable As New DataTable
                            Relation.Group2BusinessFactory.GetAllByCondition(Condition, DataTable)
                            Relation.Group2.LoadTreeView(Relation.Group2PKField, Relation.Group2ParentField, Relation.Group2NameField, DataTable, GridDetail)
                            DirectCast(GridDetail, TreeView).ExpandAll()
                        End If
                    End If
                Catch ex As System.Exception
                    Throw ex
                End Try
            End Sub

            Private Sub FindChild(ByVal Relation As RelationStructure, ByVal Value As Object, ByVal Group As enmGroups)
                Try
                    Dim TableName As String = String.Empty
                    Dim FieldName As String = String.Empty
                    Dim Condition As String = String.Empty
                    Dim BusinessClass As Object = Nothing
                    Dim GridMaster As Object = Nothing
                    Dim GridDetail As Object = Nothing
                    Dim ConnectionType As enmConnectionType

                    If Group = enmGroups.Group1 Then
                        If Relation.Group1ConnectionType.HasValue = False Then
                            Exit Sub
                        End If
                        If Relation.Group1ConnectionType = enmConnectionType.Online Then
                            TableName = Relation.Group1BusinessFactory.TableName
                            BusinessClass = Relation.Group1BusinessFactory
                        End If
                        If TypeOf Relation.Group1.Grid Is DataGridView AndAlso DirectCast(Relation.Group1.Grid, DataGridView).Columns.Item(Relation.Group1FilterColumn) IsNot Nothing Then
                            FieldName = DirectCast(Relation.Group1.Grid, DataGridView).Columns(Relation.Group1FilterColumn).DataPropertyName
                        ElseIf TypeOf Relation.Group1.Grid Is Janus.Windows.GridEX.GridEX AndAlso DirectCast(Relation.Group1.Grid, Janus.Windows.GridEX.GridEX).RootTable.Columns(Relation.Group1FilterColumn) IsNot Nothing Then
                            FieldName = DirectCast(Relation.Group1.Grid, Janus.Windows.GridEX.GridEX).RootTable.Columns(Relation.Group1FilterColumn).DataMember
                        Else
                            FieldName = Relation.Group1FilterColumn
                        End If
                        GridMaster = Relation.Group2.Grid
                        GridDetail = Relation.Group1.Grid
                        ConnectionType = Relation.Group1ConnectionType.Value
                    End If
                    If Group = enmGroups.Group2 Then
                        If Relation.Group2ConnectionType.HasValue = False Then
                            Exit Sub
                        End If
                        If Relation.Group2ConnectionType = enmConnectionType.Online Then
                            TableName = Relation.Group2BusinessFactory.TableName
                            BusinessClass = Relation.Group2BusinessFactory
                        End If
                        If TypeOf Relation.Group2.Grid Is DataGridView AndAlso DirectCast(Relation.Group2.Grid, DataGridView).Columns.Item(Relation.Group2FilterColumn) IsNot Nothing Then
                            FieldName = DirectCast(Relation.Group2.Grid, DataGridView).Columns(Relation.Group2FilterColumn).DataPropertyName
                        ElseIf TypeOf Relation.Group2.Grid Is Janus.Windows.GridEX.GridEX AndAlso DirectCast(Relation.Group2.Grid, Janus.Windows.GridEX.GridEX).RootTable.Columns(Relation.Group2FilterColumn) IsNot Nothing Then
                            FieldName = DirectCast(Relation.Group2.Grid, Janus.Windows.GridEX.GridEX).RootTable.Columns(Relation.Group2FilterColumn).DataMember
                        Else
                            FieldName = Relation.Group2FilterColumn
                        End If
                        GridMaster = Relation.Group1.Grid
                        GridDetail = Relation.Group2.Grid
                        ConnectionType = Relation.Group2ConnectionType.Value
                    End If

                    If ConnectionType = enmConnectionType.Online Then
                        Condition = "[" + TableName + "].[" + FieldName + "] "
                        Condition += "= N'" + Hepsa.Core.Common.PersentationController.CorrectLike(Value) + "'"
                    Else
                        Condition = "[" + FieldName + "] "
                        Condition += "= '" + Hepsa.Core.Common.PersentationController.CorrectLike(Value) + "'"
                    End If

                    If TypeOf GridDetail Is DataGridView Then
                        Dim DataSource As DataTable
                        Dim dr() As DataRow
                        If ConnectionType = enmConnectionType.Offline Then
                            DataSource = DirectCast(DirectCast(GridDetail, DataGridView).DataSource, DataTable).DefaultView.ToTable
                            dr = DataSource.Select(Condition)
                            If dr.Length > 0 Then
                                For Each column As DataGridViewColumn In DirectCast(GridDetail, DataGridView).Columns
                                    If column.Visible Then
                                        DirectCast(GridDetail, DataGridView).CurrentCell = DirectCast(GridDetail, DataGridView).Item(column.Index, DataSource.Rows.IndexOf(dr(0)))
                                        DirectCast(GridDetail, DataGridView).FirstDisplayedScrollingRowIndex = DirectCast(GridDetail, DataGridView).Rows(DataSource.Rows.IndexOf(dr(0))).Index
                                        Exit For
                                    End If
                                Next
                            End If
                        Else
                            DataSource = New DataTable
                            BusinessClass.GetAllByCondition(Condition, DataSource)
                            DirectCast(GridDetail, DataGridView).DataSource = DataSource
                        End If
                    ElseIf TypeOf GridDetail Is Janus.Windows.GridEX.GridEX Then
                        Dim DataSource As DataTable
                        Dim dr() As DataRow
                        If ConnectionType = enmConnectionType.Offline Then
                            DataSource = DirectCast(DirectCast(GridDetail, Janus.Windows.GridEX.GridEX).DataSource, DataTable).DefaultView.ToTable
                            dr = DataSource.Select(Condition)
                            If dr.Length > 0 Then
                                DirectCast(GridDetail, Janus.Windows.GridEX.GridEX).Row = DataSource.Rows.IndexOf(dr(0))
                            End If
                        Else
                            DataSource = New DataTable
                            BusinessClass.GetAllByCondition(Condition, DataSource)
                            DirectCast(GridDetail, Janus.Windows.GridEX.GridEX).DataSource = DataSource
                        End If
                    ElseIf TypeOf GridDetail Is TreeView Then
                        If DirectCast(GridDetail, TreeView).SelectedNode IsNot Nothing Then
                            DirectCast(GridDetail, TreeView).SelectedNode.BackColor = System.Drawing.SystemColors.Window
                            DirectCast(GridDetail, TreeView).SelectedNode.ForeColor = System.Drawing.SystemColors.WindowText
                        End If
                        Dim FindNode() As TreeNode = DirectCast(GridDetail, TreeView).Nodes.Find(Value, True)
                        If FindNode.Length > 0 Then
                            DirectCast(GridDetail, TreeView).SelectedNode = FindNode(0)
                            DirectCast(GridDetail, TreeView).SelectedNode.BackColor = System.Drawing.SystemColors.Highlight
                            DirectCast(GridDetail, TreeView).SelectedNode.ForeColor = System.Drawing.SystemColors.HighlightText
                        Else
                            DirectCast(GridDetail, TreeView).SelectedNode = Nothing
                        End If
                    End If
                Catch ex As System.Exception
                    Throw ex
                End Try
            End Sub

            'Private Sub Grid_SelectionChanged_SelectRelation(ByVal Grid As Object, ByVal Group As enmGroups)
            '    Dim Relation As List(Of RelationStructure) = Me.GetGroups(Grid, Group)

            '    For index As Integer = 0 To Relation.Count - 1
            '        If Group = enmGroups.Group1 Then
            '            If Relation.Item(index).Group1.Grid IsNot Nothing AndAlso TypeOf Relation.Item(index).Group1.Grid Is DataGridView Then
            '                If DirectCast(Relation.Item(index).Group1.Grid, DataGridView).CurrentRow IsNot Nothing AndAlso (Relation.Item(index).Group1LastValue Is Nothing OrElse Relation.Item(index).Group1LastValue <> DirectCast(Relation.Item(index).Group1.Grid, DataGridView).CurrentRow.Cells(Relation.Item(index).Group1FilterColumn).Value) Then
            '                    Relation.Item(index).Group1LastValue = DirectCast(Relation.Item(index).Group1.Grid, DataGridView).CurrentRow.Cells(Relation.Item(index).Group1FilterColumn).Value
            '                Else
            '                    If TypeOf Relation.Item(index).Group2.Grid Is DataGridView Then
            '                        DirectCast(DirectCast(Relation.Item(index).Group2.Grid, DataGridView).DataSource, DataTable).Rows.Clear()
            '                    ElseIf TypeOf Relation.Item(index).Group2.Grid Is Janus.Windows.GridEX.GridEX Then
            '                        DirectCast(DirectCast(Relation.Item(index).Group2.Grid, Janus.Windows.GridEX.GridEX).DataSource, DataTable).Rows.Clear()
            '                    End If
            '                End If
            '            ElseIf Relation.Item(index).Group1.Grid IsNot Nothing AndAlso TypeOf Relation.Item(index).Group1.Grid Is Janus.Windows.GridEX.GridEXRow Then
            '                If DirectCast(Relation.Item(index).Group1.Grid, Janus.Windows.GridEX.GridEX).CurrentRow IsNot Nothing AndAlso (Relation.Item(index).Group1LastValue Is Nothing OrElse Relation.Item(index).Group1LastValue <> DirectCast(Relation.Item(index).Group1.Grid, Janus.Windows.GridEX.GridEX).CurrentRow.Cells(Relation.Item(index).Group1FilterColumn).Value) Then
            '                    Relation.Item(index).Group1LastValue = DirectCast(Relation.Item(index).Group1.Grid, Janus.Windows.GridEX.GridEX).CurrentRow.Cells(Relation.Item(index).Group1FilterColumn).Value
            '                Else
            '                    If TypeOf Relation.Item(index).Group2.Grid Is DataGridView Then
            '                        DirectCast(DirectCast(Relation.Item(index).Group2.Grid, DataGridView).DataSource, DataTable).Rows.Clear()
            '                    ElseIf TypeOf Relation.Item(index).Group2.Grid Is Janus.Windows.GridEX.GridEX Then
            '                        DirectCast(DirectCast(Relation.Item(index).Group2.Grid, Janus.Windows.GridEX.GridEX).DataSource, DataTable).Rows.Clear()
            '                    End If
            '                End If
            '            End If

            '            If Relation(index).Group1ChildDataShowType = enmChildDataShowType.Filter Then
            '                Me.FilterChild(Relation(index), Grid.CurrentRow.Cells(Relation(index).Group1FilterColumn).Value, enmGroups.Group2)
            '            ElseIf Relation(index).Group1ChildDataShowType = enmChildDataShowType.Find Then
            '                Me.FindChild(Relation(index), Grid.CurrentRow.Cells(Relation(index).Group1FilterColumn).Value, enmGroups.Group2)
            '            End If
            '        ElseIf Group = enmGroups.Group2 Then
            '            If Relation(index).Group1ChildDataShowType = enmChildDataShowType.Filter Then
            '                Me.FilterChild(Relation(index), Grid.CurrentRow.Cells(Relation(index).Group2FilterColumn).Value, enmGroups.Group1)
            '            ElseIf Relation(index).Group1ChildDataShowType = enmChildDataShowType.Find Then
            '                Me.FindChild(Relation(index), Grid.CurrentRow.Cells(Relation(index).Group2FilterColumn).Value, enmGroups.Group1)
            '            End If
            '        End If
            '    Next
            'End Sub

            'Private Sub Group1Grid_SelectionChanged(ByVal sender As Object, ByVal e As EventArgs)
            '    Try
            '        If Me._LockGroup1SelectionEvent = True Then
            '            Exit Sub
            '        Else
            '            Me._LockGroup2SelectionEvent = True
            '        End If

            '        If sender.CurrentRow Is Nothing Then
            '            Dim Groups As List(Of GroupRelation.RelationStructure) = Me.GetGroups(sender, enmGroups.Group1)
            '            For index As Integer = 0 To Groups.Count - 1
            '                If TypeOf Groups.Item(index).Group2.Grid Is DataGridView Then
            '                    If DirectCast(Groups.Item(index).Group2.Grid, DataGridView).DataSource IsNot Nothing Then
            '                        DirectCast(DirectCast(Groups.Item(index).Group2.Grid, DataGridView).DataSource, DataTable).Rows.Clear()
            '                    End If
            '                ElseIf TypeOf Groups.Item(index).Group2.Grid Is Janus.Windows.GridEX.GridEX Then
            '                    If DirectCast(Groups.Item(index).Group2.Grid, DataGridView).DataSource IsNot Nothing Then
            '                        DirectCast(DirectCast(Groups.Item(index).Group2.Grid, Janus.Windows.GridEX.GridEX).DataSource, DataTable).Rows.Clear()
            '                    End If
            '                ElseIf TypeOf Groups.Item(index).Group2.Grid Is TreeView Then
            '                    DirectCast(Groups.Item(index).Group2.Grid, TreeView).Nodes.Clear()
            '                End If
            '                If Groups.Item(index).Group2.AddButton IsNot Nothing Then
            '                    Groups.Item(index).Group2.AddButtonEnable = False
            '                End If
            '            Next
            '            Me._LockGroup2SelectionEvent = False
            '            Exit Sub
            '        Else
            '            Dim Groups As List(Of GroupRelation.RelationStructure) = Me.GetGroups(sender, enmGroups.Group1)
            '            For index As Integer = 0 To Groups.Count - 1
            '                If Groups.Item(index).Group2.AddButton IsNot Nothing Then
            '                    Groups.Item(index).Group2.AddButtonEnable = True
            '                End If
            '            Next
            '        End If

            '        Me.Grid_SelectionChanged_SelectRelation(sender, enmGroups.Group1)

            '        Me._LockGroup2SelectionEvent = False
            '    Catch ex As System.Exception
            '        Common.MessageBox.ErrorMessage(ex.Message)
            '        BaseListForm.Close()
            '    End Try
            'End Sub

            'Private Sub Group2Grid_SelectionChanged(ByVal sender As Object, ByVal e As EventArgs)
            '    Try
            '        If Me._LockGroup2SelectionEvent = True Then
            '            Exit Sub
            '        Else
            '            Me._LockGroup1SelectionEvent = True
            '        End If

            '        If sender.CurrentRow Is Nothing Then
            '            Me._LockGroup1SelectionEvent = False
            '            Exit Sub
            '        End If

            '        Me.Grid_SelectionChanged_SelectRelation(sender, enmGroups.Group2)

            '        Me._LockGroup1SelectionEvent = False
            '    Catch ex As System.Exception
            '        Common.MessageBox.ErrorMessage(ex.Message)
            '        BaseListForm.Close()
            '    End Try
            'End Sub

            'Private Sub FilterChild(ByVal Relation As RelationStructure, ByVal Value As Object, ByVal Group As enmGroups)
            '    Try
            '        Dim TableName As String = String.Empty
            '        Dim FieldName As String = String.Empty
            '        Dim Condition As String = String.Empty
            '        Dim StartCompareOperator As String = String.Empty
            '        Dim EndCompareOperator As String = String.Empty
            '        Dim BusinessClass As Object = Nothing
            '        Dim ConnectionType As enmConnectionType
            '        Dim GridMaster As Object = Nothing
            '        Dim GridDetail As Object = Nothing

            '        If Group = enmGroups.Group1 Then
            '            If Relation.Group1ConnectionType.HasValue = False Then
            '                Exit Sub
            '            End If
            '            If Relation.Group1ConnectionType.Value = enmConnectionType.Online Then
            '                TableName = Relation.Group1BusinessFactory.TableName
            '                BusinessClass = Relation.Group1BusinessFactory
            '            End If
            '            FieldName = Relation.Group1FilterColumn
            '            ConnectionType = Relation.Group1ConnectionType.Value
            '            GridMaster = Relation.Group2.Grid
            '            GridDetail = Relation.Group1.Grid
            '            If Relation.Group1RelationType = enmRelationType.Eual Then
            '                StartCompareOperator = "= N'"
            '                EndCompareOperator = "'"
            '            ElseIf Relation.Group1RelationType = enmRelationType.StartWith Then
            '                StartCompareOperator = "Like N'"
            '                EndCompareOperator = "%'"
            '            End If
            '        End If
            '        If Group = enmGroups.Group2 Then
            '            If Relation.Group2ConnectionType.HasValue = False Then
            '                Exit Sub
            '            End If
            '            If Relation.Group2ConnectionType.Value = enmConnectionType.Online Then
            '                TableName = Relation.Group2BusinessFactory.TableName
            '                BusinessClass = Relation.Group2BusinessFactory
            '            End If
            '            FieldName = Relation.Group2FilterColumn
            '            ConnectionType = Relation.Group2ConnectionType.Value
            '            GridMaster = Relation.Group1.Grid
            '            GridDetail = Relation.Group2.Grid
            '            If Relation.Group2RelationType = enmRelationType.Eual AndAlso ConnectionType = enmConnectionType.Online Then
            '                StartCompareOperator = "= N'"
            '                EndCompareOperator = "'"
            '            ElseIf Relation.Group2RelationType = enmRelationType.StartWith AndAlso ConnectionType = enmConnectionType.Online Then
            '                StartCompareOperator = "Like N'"
            '                EndCompareOperator = "%'"
            '            ElseIf Relation.Group2RelationType = enmRelationType.Eual AndAlso ConnectionType = enmConnectionType.Offline Then
            '                StartCompareOperator = "= '"
            '                EndCompareOperator = "'"
            '            ElseIf Relation.Group2RelationType = enmRelationType.StartWith AndAlso ConnectionType = enmConnectionType.Offline Then
            '                StartCompareOperator = "Like '"
            '                EndCompareOperator = "%'"
            '            End If
            '        End If

            '        If ConnectionType = enmConnectionType.Online Then
            '            Condition = "[" + TableName + "].[" + FieldName + "] "
            '            Condition += StartCompareOperator + Common.PersentationController.CorrectLike(Value) + EndCompareOperator
            '        Else
            '            Condition = "[" + FieldName + "] "
            '            Condition += StartCompareOperator + Common.PersentationController.CorrectLike(Value) + EndCompareOperator
            '        End If

            '        If TypeOf GridDetail Is DataGridView OrElse TypeOf GridDetail Is Janus.Windows.GridEX.GridEX Then
            '            Dim DataSource As DataTable
            '            If ConnectionType = enmConnectionType.Offline Then
            '                DataSource = DirectCast(GridDetail.DataSource, DataTable)
            '                DataSource.DefaultView.RowFilter = Condition
            '            Else
            '                DataSource = New DataTable
            '                BusinessClass.GetAllByCondition(Condition, DataSource)
            '                GridDetail.DataSource = DataSource
            '            End If
            '        ElseIf TypeOf GridDetail Is TreeView Then
            '            If Group = enmGroups.Group2 AndAlso String.IsNullOrEmpty(Relation.Group2ParentField) = False AndAlso String.IsNullOrEmpty(Relation.Group2NameField) = False AndAlso String.IsNullOrEmpty(Relation.Group2FilterColumn) = False AndAlso String.IsNullOrEmpty(Relation.Group2PKField) = False Then
            '                DirectCast(GridDetail, TreeView).Nodes.Clear()
            '                Dim DataTable As New DataTable
            '                Relation.Group2BusinessFactory.GetAllByCondition(Condition, DataTable)
            '                Relation.Group2.LoadTreeView(Relation.Group2PKField, Relation.Group2ParentField, Relation.Group2NameField, DataTable, GridDetail)
            '                DirectCast(GridDetail, TreeView).ExpandAll()
            '            ElseIf Group = enmGroups.Group1 AndAlso String.IsNullOrEmpty(Relation.Group1ParentField) = False AndAlso String.IsNullOrEmpty(Relation.Group1NameField) = False AndAlso String.IsNullOrEmpty(Relation.Group1FilterColumn) = False AndAlso String.IsNullOrEmpty(Relation.Group2PKField) = False Then
            '                DirectCast(GridDetail, TreeView).Nodes.Clear()
            '                Dim DataTable As New DataTable
            '                Relation.Group2BusinessFactory.GetAllByCondition(Condition, DataTable)
            '                Relation.Group2.LoadTreeView(Relation.Group2PKField, Relation.Group2ParentField, Relation.Group2NameField, DataTable, GridDetail)
            '                DirectCast(GridDetail, TreeView).ExpandAll()
            '            End If
            '        End If
            '    Catch ex As System.Exception
            '        Throw ex
            '    End Try
            'End Sub

            'Private Sub FindChild(ByVal Relation As RelationStructure, ByVal Value As Object, ByVal Group As enmGroups)
            '    Try
            '        Dim TableName As String = String.Empty
            '        Dim FieldName As String = String.Empty
            '        Dim Condition As String = String.Empty
            '        Dim BusinessClass As Object = Nothing
            '        Dim GridMaster As Object = Nothing
            '        Dim GridDetail As Object = Nothing
            '        Dim ConnectionType As enmConnectionType

            '        If Group = enmGroups.Group1 Then
            '            If Relation.Group1ConnectionType.HasValue = False Then
            '                Exit Sub
            '            End If
            '            If Relation.Group1ConnectionType = enmConnectionType.Online Then
            '                TableName = Relation.Group1BusinessFactory.TableName
            '                BusinessClass = Relation.Group1BusinessFactory
            '            End If
            '            If TypeOf Relation.Group1.Grid Is DataGridView AndAlso DirectCast(Relation.Group1.Grid, DataGridView).Columns.Item(Relation.Group1FilterColumn) IsNot Nothing Then
            '                FieldName = DirectCast(Relation.Group1.Grid, DataGridView).Columns(Relation.Group1FilterColumn).DataPropertyName
            '            ElseIf TypeOf Relation.Group1.Grid Is Janus.Windows.GridEX.GridEX AndAlso DirectCast(Relation.Group1.Grid, Janus.Windows.GridEX.GridEX).RootTable.Columns(Relation.Group1FilterColumn) IsNot Nothing Then
            '                FieldName = DirectCast(Relation.Group1.Grid, Janus.Windows.GridEX.GridEX).RootTable.Columns(Relation.Group1FilterColumn).DataMember
            '            Else
            '                FieldName = Relation.Group1FilterColumn
            '            End If
            '            GridMaster = Relation.Group2.Grid
            '            GridDetail = Relation.Group1.Grid
            '            ConnectionType = Relation.Group1ConnectionType.Value
            '        End If
            '        If Group = enmGroups.Group2 Then
            '            If Relation.Group2ConnectionType.HasValue = False Then
            '                Exit Sub
            '            End If
            '            If Relation.Group2ConnectionType = enmConnectionType.Online Then
            '                TableName = Relation.Group2BusinessFactory.TableName
            '                BusinessClass = Relation.Group2BusinessFactory
            '            End If
            '            If TypeOf Relation.Group2.Grid Is DataGridView AndAlso DirectCast(Relation.Group2.Grid, DataGridView).Columns.Item(Relation.Group2FilterColumn) IsNot Nothing Then
            '                FieldName = DirectCast(Relation.Group2.Grid, DataGridView).Columns(Relation.Group2FilterColumn).DataPropertyName
            '            ElseIf TypeOf Relation.Group2.Grid Is Janus.Windows.GridEX.GridEX AndAlso DirectCast(Relation.Group2.Grid, Janus.Windows.GridEX.GridEX).RootTable.Columns(Relation.Group2FilterColumn) IsNot Nothing Then
            '                FieldName = DirectCast(Relation.Group2.Grid, Janus.Windows.GridEX.GridEX).RootTable.Columns(Relation.Group2FilterColumn).DataMember
            '            Else
            '                FieldName = Relation.Group2FilterColumn
            '            End If
            '            GridMaster = Relation.Group1.Grid
            '            GridDetail = Relation.Group2.Grid
            '            ConnectionType = Relation.Group2ConnectionType.Value
            '        End If

            '        If ConnectionType = enmConnectionType.Online Then
            '            Condition = "[" + TableName + "].[" + FieldName + "] "
            '            Condition += "= N'" + Common.PersentationController.CorrectLike(Value) + "'"
            '        Else
            '            Condition = "[" + FieldName + "] "
            '            Condition += "= '" + Common.PersentationController.CorrectLike(Value) + "'"
            '        End If

            '        If TypeOf GridDetail Is DataGridView Then
            '            Dim DataSource As DataTable
            '            Dim dr() As DataRow
            '            If ConnectionType = enmConnectionType.Offline Then
            '                DataSource = DirectCast(DirectCast(GridDetail, DataGridView).DataSource, DataTable).DefaultView.ToTable
            '                dr = DataSource.Select(Condition)
            '                If dr.Length > 0 Then
            '                    For Each column As DataGridViewColumn In DirectCast(GridDetail, DataGridView).Columns
            '                        If column.Visible Then
            '                            DirectCast(GridDetail, DataGridView).CurrentCell = DirectCast(GridDetail, DataGridView).Item(column.Index, DataSource.Rows.IndexOf(dr(0)))
            '                            DirectCast(GridDetail, DataGridView).FirstDisplayedScrollingRowIndex = DirectCast(GridDetail, DataGridView).Rows(DataSource.Rows.IndexOf(dr(0))).Index
            '                            Exit For
            '                        End If
            '                    Next
            '                End If
            '            Else
            '                DataSource = New DataTable
            '                BusinessClass.GetAllByCondition(Condition, DataSource)
            '                DirectCast(GridDetail, DataGridView).DataSource = DataSource
            '            End If
            '        ElseIf TypeOf GridDetail Is Janus.Windows.GridEX.GridEX Then
            '            Dim DataSource As DataTable
            '            Dim dr() As DataRow
            '            If ConnectionType = enmConnectionType.Offline Then
            '                DataSource = DirectCast(DirectCast(GridDetail, Janus.Windows.GridEX.GridEX).DataSource, DataTable).DefaultView.ToTable
            '                dr = DataSource.Select(Condition)
            '                If dr.Length > 0 Then
            '                    DirectCast(GridDetail, Janus.Windows.GridEX.GridEX).Row = DataSource.Rows.IndexOf(dr(0))
            '                End If
            '            Else
            '                DataSource = New DataTable
            '                BusinessClass.GetAllByCondition(Condition, DataSource)
            '                DirectCast(GridDetail, Janus.Windows.GridEX.GridEX).DataSource = DataSource
            '            End If
            '        ElseIf TypeOf GridDetail Is TreeView Then
            '            If DirectCast(GridDetail, TreeView).SelectedNode IsNot Nothing Then
            '                DirectCast(GridDetail, TreeView).SelectedNode.BackColor = System.Drawing.SystemColors.Window
            '                DirectCast(GridDetail, TreeView).SelectedNode.ForeColor = System.Drawing.SystemColors.WindowText
            '            End If
            '            Dim FindNode() As TreeNode = DirectCast(GridDetail, TreeView).Nodes.Find(Value, True)
            '            If FindNode.Length > 0 Then
            '                DirectCast(GridDetail, TreeView).SelectedNode = FindNode(0)
            '                DirectCast(GridDetail, TreeView).SelectedNode.BackColor = System.Drawing.SystemColors.Highlight
            '                DirectCast(GridDetail, TreeView).SelectedNode.ForeColor = System.Drawing.SystemColors.HighlightText
            '            Else
            '                DirectCast(GridDetail, TreeView).SelectedNode = Nothing
            '            End If
            '        End If
            '    Catch ex As System.Exception
            '        Throw ex
            '    End Try
            'End Sub

            Private Sub TreeView_AfterSelect_SelectRelation(ByVal Grid As TreeView, ByVal Group As enmGroups)
                Dim Relation As List(Of RelationStructure) = Me.GetGroups(Grid, Group)
                For index As Integer = 0 To Relation.Count - 1
                    If Group = enmGroups.Group1 Then
                        If Relation(index).Group1ChildDataShowType = enmChildDataShowType.Filter Then
                            Me.FilterChild(Relation(index), Grid.SelectedNode.Name.ToString, enmGroups.Group2)
                        ElseIf Relation(index).Group1ChildDataShowType = enmChildDataShowType.Find Then
                            Me.FindChild(Relation(index), Grid.SelectedNode.Name.ToString, enmGroups.Group2)
                        End If
                    ElseIf Group = enmGroups.Group2 Then
                        If Relation(index).Group1ChildDataShowType = enmChildDataShowType.Filter Then
                            Me.FilterChild(Relation(index), Grid.SelectedNode.Name.ToString, enmGroups.Group1)
                        ElseIf Relation(index).Group1ChildDataShowType = enmChildDataShowType.Find Then
                            Me.FindChild(Relation(index), Grid.SelectedNode.Name.ToString, enmGroups.Group1)
                        End If
                    End If
                Next
            End Sub

            Private Sub Group1TreeView_AfterSelect(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TreeViewEventArgs)
                Try
                    If Me._LockGroup2SelectionEvent = True Then
                        Exit Sub
                    Else
                        Me._LockGroup1SelectionEvent = True
                    End If

                    If e.Node Is Nothing Then
                        Me._LockGroup1SelectionEvent = False
                        Exit Sub
                    End If

                    Me.TreeView_AfterSelect_SelectRelation(DirectCast(sender, TreeView), enmGroups.Group1)

                    Me._LockGroup1SelectionEvent = False
                Catch ex As System.Exception
                    Common.MessageBox.ErrorMessage(ex.Message)
                    BaseListForm.Close()
                End Try
            End Sub

            Private Sub Group2TreeView_AfterSelect(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TreeViewEventArgs)
                Try
                    If Me._LockGroup2SelectionEvent = True Then
                        Exit Sub
                    Else
                        Me._LockGroup1SelectionEvent = True
                    End If

                    If e.Node Is Nothing Then
                        Me._LockGroup1SelectionEvent = False
                        Exit Sub
                    End If


                    Me.TreeView_AfterSelect_SelectRelation(DirectCast(sender, TreeView), enmGroups.Group2)

                    Me._LockGroup1SelectionEvent = False
                Catch ex As System.Exception
                    Common.MessageBox.ErrorMessage(ex.Message)
                    BaseListForm.Close()
                End Try
            End Sub

            Private Sub TreeView_BeforeSelect(ByVal sender As Object, ByVal e As System.Windows.Forms.TreeViewCancelEventArgs)
                If sender.SelectedNode IsNot Nothing Then
                    sender.SelectedNode.BackColor = System.Drawing.SystemColors.Window
                    sender.SelectedNode.ForeColor = System.Drawing.SystemColors.WindowText
                End If
            End Sub

        End Class

        Private _Groups As GroupList
        Private _Relation As GroupRelation

        Public ReadOnly Property Groups() As GroupList
            Get
                Return Me._Groups
            End Get
        End Property

        Public ReadOnly Property Relation() As GroupRelation
            Get
                Return Me._Relation
            End Get
        End Property

        Public Sub New()
            InitializeComponent()
            Me._Groups = New GroupList(Nothing)
            Me._Relation = New GroupRelation
        End Sub

        Private Sub BaseListForm_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
            Common.ApplicationInfo.MainForm.Text = Common.ApplicationInfo.ProgramName
        End Sub

        Private Sub BaseListForm_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
            If e.KeyCode = My.Settings.CloseButton Then
                Return
            End If

            If _Groups IsNot Nothing Then
                Dim ActiveGroup As Group = Nothing

                For index As Integer = 0 To _Groups.Count - 1
                    If _Groups.Item(index).ToolStrip IsNot Nothing AndAlso _Groups.Item(index).ToolStrip.Focused = True Then
                        ActiveGroup = _Groups.Item(index)
                    ElseIf _Groups.Item(index).Grid IsNot Nothing AndAlso _Groups.Item(index).Grid.Focused = True Then
                        ActiveGroup = _Groups.Item(index)
                    End If
                Next

                If ActiveGroup IsNot Nothing Then
                    If e.KeyCode = My.Settings.NewButton AndAlso ActiveGroup.AddButton IsNot Nothing AndAlso ActiveGroup.AddButton.Enabled = True Then
                        If TypeOf ActiveGroup.AddButton Is ToolStripButton Then
                            ActiveGroup.AddButton.PerformClick()
                        ElseIf TypeOf ActiveGroup.AddButton Is ToolStripSplitButton Then
                            DirectCast(ActiveGroup.AddButton, ToolStripSplitButton).PerformButtonClick()
                        End If
                    ElseIf e.KeyCode = My.Settings.PrintButton AndAlso ActiveGroup.PrintButton IsNot Nothing AndAlso ActiveGroup.PrintButton.Enabled = True Then
                        ActiveGroup.PrintButton.PerformClick()
                    ElseIf e.KeyCode = My.Settings.EditButton AndAlso ActiveGroup.EditButton IsNot Nothing AndAlso ActiveGroup.EditButton.Enabled = True Then
                        ActiveGroup.EditButton.PerformClick()
                    ElseIf e.KeyCode = My.Settings.DeleteButton AndAlso ActiveGroup.DeleteButton IsNot Nothing AndAlso ActiveGroup.DeleteButton.Enabled = True Then
                        ActiveGroup.DeleteButton.PerformClick()
                    ElseIf e.KeyCode = My.Settings.RefreshButton AndAlso ActiveGroup.RefreshButton IsNot Nothing AndAlso ActiveGroup.RefreshButton.Enabled = True Then
                        ActiveGroup.RefreshButton.PerformClick()
                    ElseIf e.KeyCode = My.Settings.UndoFilterButton AndAlso ActiveGroup.HasFilterControl = True Then
                        ActiveGroup.UndoFilter(sender, e)
                    ElseIf e.KeyCode = My.Settings.FilterButton AndAlso ActiveGroup.HasFilterControl = True Then
                        ActiveGroup.Filter(sender, e)
                    ElseIf e.KeyCode = My.Settings.ExportButton AndAlso ActiveGroup.ExportButton IsNot Nothing AndAlso ActiveGroup.ExportButton.Enabled = True Then
                        ActiveGroup.ExportButton.PerformClick()
                    ElseIf e.KeyCode = My.Settings.ClearFilterButton AndAlso ActiveGroup.HasFilterControl = True Then
                        ActiveGroup.ClearFilter(sender, e)
                    ElseIf e.KeyCode = My.Settings.HelpButton AndAlso String.IsNullOrEmpty(ActiveGroup.HelpBookMark) = False Then
                        ActiveGroup.HelpBookMarkButton.PerformClick()
                    End If
                End If
            End If
        End Sub

        Private Sub BaseListForm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
            'Dim LogFactory As New Hepsa.Core.BLL.BLLLog_TFactory
            'Dim LogEntity As New Hepsa.Core.BLL.BLLLog_T
            'Try
            '    LogEntity.Date_nvc = LogFactory.ServerJalaliDate
            '    LogEntity.Time_nvc = LogFactory.ServerTime
            '    LogEntity.IPAddress_nvc = Hepsa.Core.Common.ApplicationInfo.IpAddress
            '    LogEntity.MacAddress_nvc = Hepsa.Core.Common.ApplicationInfo.MacAddress
            '    LogEntity.UserName_nvc = Hepsa.Core.Common.CurrentUser.User.UserName_nvc
            '    LogEntity.FormText_nvc = IIf(String.IsNullOrEmpty(Me.Text), Me.Name, Me.Text)
            '    LogEntity.ActionID_int = Hepsa.Core.BLL.BLLAction_T.Actions.OpeningForm
            '    LogEntity.Body_nvc = String.Format("مشاهده فرم {0}", IIf(String.IsNullOrEmpty(Me.Text), Me.Name, Me.Text))
            '    LogFactory.BeginProc()
            '    LogFactory.Insert(LogEntity)
            '    LogFactory.CommitProc()
            'Catch ex As System.Exception
            '    LogFactory.RollBackProc()
            '    Hepsa.Core.Common.MessageBox.ErrorMessage(ex.Message)
            'End Try


            If Me.Groups IsNot Nothing AndAlso Me.Groups.Count > 0 Then
                For index As Integer = 0 To Me.Groups.Count - 1
                    If Me.Groups.Item(index).DeleteButton IsNot Nothing Then
                        Me.Groups.Item(index).DeleteButton.Visible = False
                    End If
                Next
            End If
        End Sub

        Private Sub BaseListForm_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
            Dim LogFactory As New Hepsa.Core.BLL.BLLLog_TFactory
            Dim LogEntity As New Hepsa.Core.BLL.BLLLog_T

            Try
                LogEntity.Date_nvc = LogFactory.ServerJalaliDate
                LogEntity.Time_nvc = LogFactory.ServerTime
                LogEntity.IPAddress_nvc = Hepsa.Core.Common.ApplicationInfo.IpAddress
                LogEntity.MacAddress_nvc = Hepsa.Core.Common.ApplicationInfo.MacAddress
                LogEntity.UserName_nvc = Hepsa.Core.Common.CurrentUser.User.UserName_nvc
                LogEntity.FormText_nvc = IIf(String.IsNullOrEmpty(Me.Text), Me.Name, Me.Text)
                LogEntity.ActionID_int = Hepsa.Core.BLL.BLLAction_T.Actions.ClosingForm
                LogEntity.Body_nvc = String.Format("بستن فرم {0}", IIf(String.IsNullOrEmpty(Me.Text), Me.Name, Me.Text))
                LogFactory.BeginProc()
                LogFactory.Insert(LogEntity)
                LogFactory.CommitProc()
            Catch ex As System.Exception
                LogFactory.RollBackProc()
                Hepsa.Core.Common.MessageBox.ErrorMessage(ex.Message)
            End Try
        End Sub

    End Class
End Namespace