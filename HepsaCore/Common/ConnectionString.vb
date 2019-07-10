Namespace Common

    Public Class ConnectionString

        Public Enum enmAuthenticationMode As Byte
            SQLServerAuthentication = 1
            WindowsAuthentication = 2
        End Enum

        Public Shared Property AuthenticationMode() As enmAuthenticationMode
            Get
                If My.Settings.WindowsAuthenticationMode = False Then
                    Return enmAuthenticationMode.SQLServerAuthentication
                Else
                    Return enmAuthenticationMode.WindowsAuthentication
                End If
            End Get
            Set(ByVal value As enmAuthenticationMode)
                If value = enmAuthenticationMode.WindowsAuthentication Then
                    My.Settings.WindowsAuthenticationMode = True
                Else
                    My.Settings.WindowsAuthenticationMode = False
                End If
                My.Settings.Save()
            End Set
        End Property

        Public Shared Property Server() As String
            Get
                Return My.Settings.ServerName
            End Get
            Set(ByVal value As String)
                My.Settings.ServerName = value
                My.Settings.Save()
            End Set
        End Property

        Public Shared Property UserName() As String
            Get
                Return My.Settings.DataBaseUserName
            End Get
            Set(ByVal value As String)
                My.Settings.DataBaseUserName = value
                My.Settings.Save()
            End Set
        End Property

        Public Shared Property Password() As String
            Get
                Return My.Settings.DataBasePassword
            End Get
            Set(ByVal value As String)
                My.Settings.DataBasePassword = value
                My.Settings.Save()
            End Set
        End Property

        Public Shared Property DataBase() As String
            Get
                Return My.Settings.DataBaseName
            End Get
            Set(ByVal value As String)
                My.Settings.DataBaseName = value
                My.Settings.Save()
            End Set
        End Property

        Public Shared ReadOnly Property ConnectionString() As String
            Get
                Dim MyConnectionString As New System.Data.SqlClient.SqlConnectionStringBuilder
                If String.IsNullOrEmpty(DataBase.ToString) = False Then
                    MyConnectionString.InitialCatalog = DataBase.ToString
                    MyConnectionString.DataSource = Server.ToString
                    MyConnectionString.ConnectTimeout = 10
                    MyConnectionString.Pooling = True
                    MyConnectionString.MaxPoolSize = 10
                    MyConnectionString.MinPoolSize = 1
                    MyConnectionString.WorkstationID = My.Computer.Name
                    MyConnectionString.IntegratedSecurity = True
                    If AuthenticationMode = enmAuthenticationMode.SQLServerAuthentication Then
                        MyConnectionString.IntegratedSecurity = False
                        MyConnectionString.UserID = UserName
                        MyConnectionString.Password = Password
                    End If
                End If
                Return MyConnectionString.ConnectionString
            End Get
        End Property

    End Class

End Namespace
