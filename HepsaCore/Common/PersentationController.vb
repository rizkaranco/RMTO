Namespace Common

    Public Class PersentationController

        Private Shared _FormStack As New Stack

        Public Shared Sub ShowForm(ByVal ContentPane As Panel, ByVal frm As Form, ByVal MdiParentForm As Form, Optional ByVal PushCurrentFormToStack As Boolean = False, Optional ByVal CloseForms As Boolean = True)
            Try
                'For Each ctrl As Control In ContentPane.Controls
                '    If TypeOf ctrl Is Form AndAlso frm.Equals(ctrl) = False Then
                '        If PushCurrentFormToStack = True Then
                '            _FormStack.Push(ctrl)
                '            ContentPane.Controls.Remove(ctrl)
                '        End If
                '    End If
                'Next
                'frm.FormBorderStyle = FormBorderStyle.FixedSingle
                frm.ControlBox = True
                frm.MaximizeBox = True
                frm.MinimizeBox = True
                frm.TopLevel = True
                ' frm.MdiParent = MdiParentForm
                frm.ShowInTaskbar = True
                frm.StartPosition = FormStartPosition.CenterParent
                frm.WindowState = FormWindowState.Normal
                frm.Refresh()
                ' ContentPane.Controls.Add(frm)
                frm.BringToFront()
                'frm.Dock = DockStyle.Fill
                'frm.Size = ContentPane.Size
                frm.Show()
                frm.Focus()
            Catch ex As System.Exception
            End Try
        End Sub

        Public Shared Function CorrectLike(ByVal str As String) As String
            If String.IsNullOrEmpty(str) Then
                Return String.Empty
            End If
            Dim res As String = ""
            For Each c As Char In str
                If c = "]" OrElse c = "[" OrElse c = "%" Then
                    res += "[" + c + "]"
                Else
                    res += c
                End If
            Next
            Return res.Replace("'", "''")
        End Function

        Public Shared Function Measure(ByVal Text As String, ByVal FontName As String, ByVal FontSize As Single, Optional ByVal Bold As Boolean = False) As Size
            Dim Bitmap As Bitmap
            Dim gr As Graphics
            Dim Font As Font
            If Bold Then
                Font = New Font(FontName, FontSize, FontStyle.Bold)
            Else
                Font = New Font(FontName, FontSize, FontStyle.Regular)
            End If
            Bitmap = New Bitmap(1, 1, System.Drawing.Imaging.PixelFormat.Format32bppArgb)
            gr = Graphics.FromImage(Bitmap)
            Dim stringSize As SizeF = gr.MeasureString(Text, Font)
            Dim rWidth = stringSize.Width
            Dim rHeight = stringSize.Height
            gr.Dispose()
            Bitmap.Dispose()
            Return New Size(rWidth, rHeight)
        End Function


        Public Shared Sub ShowStackForm(ByVal ContentPane As Panel)
            If _FormStack IsNot Nothing AndAlso _FormStack.Count > 0 Then
                Dim frm As Form = _FormStack.Pop
                ContentPane.Controls.Clear()
                ContentPane.Controls.Add(frm)
                frm.Focus()
            End If
        End Sub

        Public Shared Sub SetComboBoxValue(ByRef ComboBox As ComboBox, ByVal Value As Object, ByVal Type As System.TypeCode)
            If Value Is DBNull.Value OrElse Value Is Nothing OrElse (TypeOf (Value) Is String AndAlso String.IsNullOrEmpty(Value)) Then
                ComboBox.SelectedIndex = -1
            Else
                ComboBox.SelectedValue = Convert.ChangeType(Value, Type)
            End If
        End Sub

        Public Shared Function GetComboBoxValueInDatabaseFormat(ByVal ComboBox As ComboBox) As Object
            If ComboBox.SelectedValue Is Nothing Then
                Return DBNull.Value
            Else
                Return ComboBox.SelectedValue
            End If
        End Function

        Public Shared Function GetEntityValueInDatabaseFormat(ByVal value As Object, ByVal Type As System.TypeCode) As Object
            If value Is Nothing OrElse (TypeOf (value) Is String AndAlso String.IsNullOrEmpty(value)) Then
                Return DBNull.Value
            Else
                Return Convert.ChangeType(value, Type)
            End If
        End Function

        Public Shared Function GetComboBoxDisplayMember(ByVal ComboBox As ComboBox) As Object
            If ComboBox.SelectedValue Is Nothing Then
                Return DBNull.Value
            Else
                Return ComboBox.Text
            End If
        End Function

        Public Shared Function GetEntityValue(ByVal value As Object, ByVal Type As System.TypeCode) As Object
            If TypeOf (value) Is String AndAlso String.IsNullOrEmpty(value) Then
                Return String.Empty
            ElseIf value Is Nothing OrElse value Is DBNull.Value OrElse (TypeOf (value) Is String AndAlso String.IsNullOrEmpty(value)) Then
                Return Nothing
            Else
                Return Convert.ChangeType(value, Type)
            End If
        End Function

        Public Shared Function GetCheckBoxValue(ByVal input As Nullable(Of Boolean)) As Boolean
            If input.HasValue Then
                Return input.Value
            Else
                Return False
            End If
        End Function

        Public Shared Function DataGridViewHasVerticalScroll(ByRef DG As DataGridView)
            Dim Height As Single = 0
            Height += DG.ColumnHeadersHeight
            If DG.Rows.Count > 0 Then
                Height += DG.Rows(0).Height * DG.Rows.Count
            End If
            If DG.Height > Height Then
                Return False
            Else
                Return True
            End If
        End Function

        Public Shared Function DataGridViewHasVerticalScroll(ByRef DG As Janus.Windows.GridEX.GridEX)
            Dim Height As Single = 20
            If DG.RowCount > 0 Then
                Height += 20 * DG.RowCount
            End If
            If DG.Height > Height Then
                Return False
            Else
                Return True
            End If
        End Function

        Public Shared Sub DataGridViewColumnFill(ByRef DG As DataGridView)
            Dim ColWidth As Single = 0
            Dim MaxColumnWidth As Single = 0
            Dim Column As Integer = 0
            Dim ScrollWidth As Single = 0
            If DataGridViewHasVerticalScroll(DG) Then
                ScrollWidth = 20
            End If
            For index As Integer = 0 To DG.ColumnCount - 1
                If DG.Columns(index).Visible Then
                    ColWidth += DG.Columns(index).Width
                    If MaxColumnWidth < DG.Columns(index).Width Then
                        MaxColumnWidth = DG.Columns(index).Width
                        Column = index
                    End If
                End If
            Next
            DG.Columns(Column).Width -= ScrollWidth
            ColWidth -= ScrollWidth
            If ColWidth < DG.Width - ScrollWidth Then
                DG.Columns(Column).Width += DG.Width - ScrollWidth - ColWidth - 4
            End If
        End Sub

        Public Shared Function GetMaskedTextBoxValue(ByVal MaskedTextBoxControl As MaskedTextBox) As String
            Dim index As Integer = MaskedTextBoxControl.Text.IndexOf(" ")
            If index >= 0 Then

                Return MaskedTextBoxControl.Text.Substring(0, index)
            Else
                Return MaskedTextBoxControl.Text
            End If
        End Function


        Public Shared Function CorrectNumberPlate(ByVal NumberPlate As String) As String
            Dim strArray As String() = New String(4 - 1) {}
            Dim num As Integer = 0
            strArray(0) = String.Empty
            strArray(1) = String.Empty
            strArray(2) = String.Empty
            Dim str3 As String = NumberPlate
            Dim num2 As Integer = 0
            Dim length As Integer = str3.Length
            Do While (num2 < length)
                Dim c As Char = str3.Chars(num2)
                If Char.IsDigit(c) Then
                    Dim index As Integer = num
                    strArray(index) = (strArray(index) & c.ToString())
                Else
                    strArray(1) = c.ToString()
                    num = 2
                End If
                num2 += 1
            Loop
            If (strArray(2).Length > strArray(0).Length) Then
                Return (strArray(2) & strArray(1) & strArray(0))
            End If
            Return (strArray(0) & strArray(1) & strArray(2))
        End Function


        Public Sub AutoComplete(ByRef cb As ComboBox, ByVal e As System.Windows.Forms.KeyPressEventArgs, Optional ByVal blnLimitToList As Boolean = False)
            Dim strFindStr As String
            If e.KeyChar = Chr(8) Then 'Check For Backspace
                If cb.SelectionStart <= 1 Then
                    cb.Text = ""
                    Exit Sub
                End If
                If cb.SelectionLength = 0 Then
                    strFindStr = cb.Text.Substring(0, cb.Text.Length - 1)
                Else
                    strFindStr = cb.Text.Substring(0, cb.SelectionStart - 1)
                End If
            Else
                If cb.SelectionLength = 0 Then
                    strFindStr = cb.Text & e.KeyChar
                Else
                    strFindStr = cb.Text.Substring(0, cb.SelectionStart) & e.KeyChar
                End If
            End If
            Dim intIdx As Integer = -1
            'Search the string in the ComboBox List.
            intIdx = cb.FindString(strFindStr)
            If intIdx <> -1 Then ' String found in the List.
                cb.SelectedText = ""
                cb.SelectedIndex = intIdx
                cb.SelectionStart = strFindStr.Length
                cb.SelectionLength = cb.Text.Length
                e.Handled = True
            Else
                If blnLimitToList = True Then
                    e.Handled = True
                Else
                    e.Handled = False
                End If
            End If

            ' CALL KEY PRESS of combobx
            'If cbAutoComplete.Checked = True Then

            '    If cbLimitToList.Checked = True Then

            '        AutoComplete(cmbAutoComplete, e, True)

            '    Else

            '        AutoComplete(cmbAutoComplete, e, False)

            '    End If

            'End If

        End Sub
    End Class

End Namespace
