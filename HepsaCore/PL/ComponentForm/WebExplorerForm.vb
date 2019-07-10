Namespace PL
    Public Class WebExplorerForm

        Private _Address As String

        Public Sub New(ByVal Address As String)
            InitializeComponent()
            Me._Address = Address
        End Sub

        Private Sub WebExplorerForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
            Dim Url As New System.Uri(Me._Address)
            Me.WebBrowser.Url = Url
        End Sub

    End Class
End Namespace