Namespace Common

    Public Class ApplicationInfo

        Private _TableName As String = String.Empty
        Private Shared _MainForm As Form
        Private Shared _ProgramName As String

        Public Sub New(ByVal TableName As String)
            Me._TableName = TableName
        End Sub

        Public ReadOnly Property TableName() As String
            Get
                Return "[" + _TableName + "]"
            End Get
        End Property

        Public ReadOnly Property BLLFactory() As String
            Get
                Return "BLL" + _TableName + "Factory"
            End Get
        End Property

        Public ReadOnly Property DAL() As String
            Get
                Return "DAL" + _TableName
            End Get
        End Property

        Public ReadOnly Property BusinessLogicLayer() As String
            Get
                Dim lst As New List(Of Type)
                lst.AddRange(System.Reflection.Assembly.GetEntryAssembly.GetTypes)
                lst.AddRange(System.Reflection.Assembly.GetExecutingAssembly.GetTypes)
                Dim Array() As Type = lst.ToArray
                For index As Integer = 0 To Array.Length - 1
                    Dim Split() As String = Array(index).FullName.ToString.Split("+")
                    For j As Integer = 0 To Split.Count - 1
                        If Split(j).EndsWith("." + BLLFactory) Then
                            Return Split(j)
                        End If
                    Next
                Next
                Return Nothing
            End Get
        End Property

        Public ReadOnly Property BusinessLogicLayer(ByVal _NameSpace As String) As String
            Get
                Dim FullTypeName As String = _NameSpace
                If String.IsNullOrEmpty(FullTypeName) = False Then
                    FullTypeName += "."
                End If
                FullTypeName += BLLFactory

                Dim lst As New List(Of Type)
                lst.AddRange(System.Reflection.Assembly.GetEntryAssembly.GetTypes)
                lst.AddRange(System.Reflection.Assembly.GetExecutingAssembly.GetTypes)
                Dim Array() As Type = lst.ToArray

                For index As Integer = 0 To Array.Length - 1
                    Dim Split() As String = Array(index).FullName.ToString.Split("+")
                    For j As Integer = 0 To Split.Count - 1
                        If Split(j).EndsWith("." + FullTypeName) Then
                            Return Split(j)
                        End If
                    Next
                Next
                Return Nothing
            End Get
        End Property

        Public ReadOnly Property DataAccessLayer() As String
            Get
                Dim lst As New List(Of Type)
                lst.AddRange(System.Reflection.Assembly.GetEntryAssembly.GetTypes)
                lst.AddRange(System.Reflection.Assembly.GetExecutingAssembly.GetTypes)
                Dim Array() As Type = lst.ToArray

                For index As Integer = 0 To Array.Length - 1
                    Dim Split() As String = Array(index).FullName.ToString.Split("+")
                    For j As Integer = 0 To Split.Count - 1
                        If Split(j).EndsWith("." + DAL) Then
                            Return Split(j)
                        End If
                    Next
                Next
                Return Nothing
            End Get
        End Property

        Public ReadOnly Property DataAccessLayer(ByVal _NameSpace As String) As String
            Get
                Dim FullTypeName As String = _NameSpace
                If String.IsNullOrEmpty(FullTypeName) = False Then
                    FullTypeName += "."
                End If
                FullTypeName += DAL

                Dim lst As New List(Of Type)
                lst.AddRange(System.Reflection.Assembly.GetEntryAssembly.GetTypes)
                lst.AddRange(System.Reflection.Assembly.GetExecutingAssembly.GetTypes)
                Dim Array() As Type = lst.ToArray

                For index As Integer = 0 To Array.Length - 1
                    Dim Split() As String = Array(index).FullName.ToString.Split("+")
                    For j As Integer = 0 To Split.Count - 1
                        If Split(j).EndsWith("." + FullTypeName) Then
                            Return Split(j)
                        End If
                    Next
                Next
                Return Nothing
            End Get
        End Property

        Public Shared Property MainForm() As Form
            Get
                Return _MainForm
            End Get
            Set(ByVal value As Form)
                _MainForm = value
                If value IsNot Nothing Then
                    AddHandler _MainForm.FormClosed, AddressOf MainForm_Closed
                End If
            End Set
        End Property

        Public Shared Property ProgramName() As String
            Get
                Return _ProgramName
            End Get
            Set(ByVal value As String)
                _ProgramName = value
            End Set
        End Property

        Private Shared Sub MainForm_Closed(ByVal sender As Object, ByVal e As EventArgs)
            Application.Exit()
        End Sub

        Public Shared ReadOnly Property IpAddress() As String
            Get
                Try
                    Return System.Net.Dns.GetHostEntry(System.Net.Dns.GetHostName()).AddressList(0).ToString
                Catch ex As System.Exception
                    Throw ex
                End Try
            End Get
        End Property

        Public Shared ReadOnly Property MacAddress() As String
            Get
                Try
                    For Each nic As System.Net.NetworkInformation.NetworkInterface In System.Net.NetworkInformation.NetworkInterface.GetAllNetworkInterfaces
                        If nic.OperationalStatus = Net.NetworkInformation.OperationalStatus.Up Then
                            If nic.GetIPProperties.UnicastAddresses.Count > 0 Then
                                For Each address As Net.NetworkInformation.UnicastIPAddressInformation In nic.GetIPProperties.UnicastAddresses
                                    If address.Address.ToString = IpAddress Then
                                        Return nic.GetPhysicalAddress.ToString
                                    End If
                                Next
                            End If
                        End If
                    Next
                    Return String.Empty
                Catch ex As System.Exception
                    Throw ex
                End Try
            End Get
        End Property

    End Class

End Namespace