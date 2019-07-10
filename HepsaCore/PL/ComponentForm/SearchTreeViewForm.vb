Namespace PL
    Public Class SearchTreeViewForm

        Private _CurrentNode As TreeNode
        Private _TreeView As TreeView
        Private _WholeWordSearch As Boolean
        Private _SearchFor As String

        Private Sub CloseButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloseButton.Click
            Me.Close()
        End Sub

        Public Sub New(ByVal TreeView As TreeView)
            InitializeComponent()
            Me._TreeView = TreeView
            TextBox_TextChanged(Me.TextBox, New EventArgs)
        End Sub

        Private Sub SearchButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SearchButton.Click
            If Me._TreeView.Nodes.Count = 0 Then
                Me.NextButton.Enabled = False
                Common.MessageBox.InformationMessage(My.Resources.Exceptions.SearchNotFound)
                Exit Sub
            End If

            Me._WholeWordSearch = Me.WholeWordCheckBox.Checked
            Me._SearchFor = Me.TextBox.Text
            Me._CurrentNode = Nothing
            If Me.SearchFromTopCheckBox.Checked OrElse Me._TreeView.SelectedNode Is Nothing Then
                If Me.Find(Me._TreeView.Nodes(0)) = False Then
                    Me.NextButton.Enabled = False
                    Common.MessageBox.InformationMessage(My.Resources.Exceptions.SearchNotFound)
                Else
                    Me.NextButton.Enabled = True
                End If
            Else
                If Me.Find(Me._TreeView.SelectedNode) = False Then
                    Me.NextButton.Enabled = False
                    Common.MessageBox.InformationMessage(My.Resources.Exceptions.SearchNotFound)
                Else
                    Me.NextButton.Enabled = True
                End If
            End If
        End Sub

        Private Function Find(ByVal Node As TreeNode) As Boolean
            If Node Is Nothing Then
                Return False
            End If
            If Node IsNot Me._CurrentNode AndAlso Me.Compare(Node.Text) = True Then
                Me._CurrentNode = Node
                Me._TreeView.SelectedNode = Node
                Me._TreeView.SelectedNode.BackColor = System.Drawing.SystemColors.Highlight
                Me._TreeView.SelectedNode.ForeColor = System.Drawing.SystemColors.HighlightText
                Return True
            End If
            If Node.Nodes.Count = 0 Then
                If Node.NextNode Is Nothing Then
                    Dim ParentNode As TreeNode = Me.GetParentNode(Node)
                    If ParentNode IsNot Nothing Then
                        Return Me.Find(ParentNode.NextNode)
                    Else
                        Return False
                    End If
                Else
                    Return Me.Find(Node.NextNode)
                End If
            Else
                For index As Integer = 0 To Node.Nodes.Count - 1
                    If Me.Compare(Node.Nodes(index).Text) = True Then
                        Me._CurrentNode = Node.Nodes(index)
                        Me._TreeView.SelectedNode = Node.Nodes(index)
                        Me._TreeView.SelectedNode.BackColor = System.Drawing.SystemColors.Highlight
                        Me._TreeView.SelectedNode.ForeColor = System.Drawing.SystemColors.HighlightText
                        Return True
                    Else
                        If Me.Find(Node.Nodes(index)) = True Then
                            Return True
                        End If
                    End If
                Next
            End If
        End Function

        Private Function GetParentNode(ByVal node As TreeNode) As TreeNode
            If node Is Nothing Then
                Return Nothing
            End If
            If node.NextNode IsNot Nothing Then
                Return node
            End If
            If node.Parent IsNot Nothing Then
                If node.Parent.NextNode Is Nothing Then
                    If node.Parent.Parent Is Nothing Then
                        Return Nothing
                    Else
                        Return Me.GetParentNode(node.Parent.Parent)
                    End If
                Else
                    Return node.Parent
                End If
            Else
                Return Nothing
            End If
        End Function

        Private Function Compare(ByVal SearchIn As String) As Boolean
            If Me._WholeWordSearch Then
                If SearchIn.StartsWith(Me._SearchFor + " ") OrElse SearchIn.EndsWith(" " + Me._SearchFor) OrElse SearchIn.IndexOf(" " + Me._SearchFor + " ") <> -1 Then
                    Return True
                Else
                    Return False
                End If
            Else
                If SearchIn.IndexOf(Me._SearchFor) <> -1 Then
                    Return True
                Else
                    Return False
                End If
            End If
        End Function

        Private Sub NextButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NextButton.Click
            If Me.Find(Me._CurrentNode) = False Then
                Me.NextButton.Enabled = False
                Common.MessageBox.InformationMessage(My.Resources.Exceptions.SearchNotFound)
            Else
                Me.NextButton.Enabled = True
            End If
        End Sub

        Private Sub TextBox_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox.KeyDown
            If e.KeyCode = Keys.Enter AndAlso Me.SearchButton.Enabled Then
                Me.SearchButton_Click(Me.SearchButton, New EventArgs)
            End If
        End Sub

        Private Sub SearchTreeViewForm_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
            If e.KeyCode = My.Settings.FindNextButton AndAlso Me.NextButton.Enabled Then
                Me.NextButton_Click(Me.NextButton, New EventArgs)
            End If
        End Sub

        Private Sub TextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox.TextChanged
            Me.SearchButton.Enabled = Not String.IsNullOrEmpty(Me.TextBox.Text)
        End Sub

    End Class
End Namespace