Namespace Exception

    Public Class HandleException

        Public Shared Function ChangeExceptionLanguage(ByVal ex As System.Exception, ByVal BusinessLogicLayerFactory As Object) As System.Exception
            If TypeOf ex Is SqlClient.SqlException Then
                Select Case DirectCast(ex, SqlClient.SqlException).Number
                    Case 547
                        Dim MessageSplit() As String = ex.Message.Split("""")
                        Dim TableName As String = MessageSplit(5)
                        Dim SplitTableName() As String = TableName.Split(".")
                        If SplitTableName.Length > 1 Then
                            TableName = String.Empty
                            For index As Integer = 1 To SplitTableName.Length - 1
                                If index > 1 Then
                                    TableName += "."
                                End If
                                TableName += SplitTableName(index)
                            Next
                        End If
                        Try
                            TableName = BusinessLogicLayerFactory.TablePersianName(TableName)
                        Catch
                            TableName = BusinessLogicLayerFactory.GetTablePersianName(TableName)
                        End Try
                        Return New SQL547(TableName)
                    Case 53, 2, 18452
                        Return New SQL53()
                    Case Else
                        Return ex
                End Select
            Else
                Return ex
            End If
        End Function

    End Class

#Region "RDBMS Exception"

    Public Class SQL547
        Inherits System.Exception

        Public Sub New(ByVal TablePersianName As String)
            MyBase.New(String.Format(My.Resources.Exceptions.SQL547, TablePersianName))
        End Sub
    End Class

    Public Class SQL53
        Inherits System.Exception

        Public Sub New()
            MyBase.New(My.Resources.Exceptions.SQL53)
        End Sub
    End Class

#End Region

#Region "NotFound Exception"


    Public Class CodingNotFound
        Inherits System.Exception

        Public Sub New()
            MyBase.New(String.Format(My.Resources.Exceptions.RecordNotFound, My.Resources.Captions.Coding))
        End Sub
    End Class
    Public Class DataSourceItemNotFound
        Inherits System.Exception

        Public Sub New()
            MyBase.New(String.Format(My.Resources.Exceptions.RecordNotFound, My.Resources.Captions.Item))
        End Sub
    End Class


    Public Class DataSourceNotFound
        Inherits System.Exception

        Public Sub New()
            MyBase.New(String.Format(My.Resources.Exceptions.RecordNotFound, My.Resources.Captions.DataSource))
        End Sub
    End Class

    Public Class ExtraFieldTemplateNotFound
        Inherits System.Exception

        Public Sub New()
            MyBase.New(String.Format(My.Resources.Exceptions.RecordNotFound, My.Resources.Captions.FieldPattern))
        End Sub
    End Class

    Public Class ExtraFieldNotFound
        Inherits System.Exception

        Public Sub New()
            MyBase.New(String.Format(My.Resources.Exceptions.RecordNotFound, My.Resources.Captions.Field))
        End Sub
    End Class

    Public Class UserNotFound
        Inherits System.Exception

        Public Sub New()
            MyBase.New(String.Format(My.Resources.Exceptions.RecordNotFound, My.Resources.Captions.User))
        End Sub
    End Class

    Public Class ContactNotFound
        Inherits System.Exception

        Public Sub New()
            MyBase.New(String.Format(My.Resources.Exceptions.RecordNotFound, My.Resources.Captions.ConnectionInformation))
        End Sub
    End Class

    Public Class CategoryNotFound
        Inherits System.Exception

        Public Sub New()
            MyBase.New(String.Format(My.Resources.Exceptions.RecordNotFound, My.Resources.Captions.Group))
        End Sub
    End Class

    Public Class CodingFormatNotFound
        Inherits System.Exception

        Public Sub New()
            MyBase.New(String.Format(My.Resources.Exceptions.RecordNotFound, My.Resources.Captions.CodingFormat))
        End Sub
    End Class
    Public Class ComputerNotFound
        Inherits System.Exception

        Public Sub New()
            MyBase.New(String.Format(My.Resources.Exceptions.RecordNotFound, "رایانه"))
        End Sub
    End Class


#End Region

#Region "User Exception"

    Public Class UserStartDateError
        Inherits System.Exception

        Public Sub New(ByVal StartDate As String)
            MyBase.New(String.Format(My.Resources.Exceptions.UserStartDateError, StartDate))
        End Sub
    End Class

    Public Class UserExpireDateError
        Inherits System.Exception

        Public Sub New(ByVal ExpireDate As String)
            MyBase.New(String.Format(My.Resources.Exceptions.UserExpireDateError, ExpireDate))
        End Sub
    End Class

    Public Class UserIsNotActive
        Inherits System.Exception

        Public Sub New()
            MyBase.New(My.Resources.Exceptions.UserIsNotActive)
        End Sub
    End Class

    Public Class InvalidUserNameOrPassword
        Inherits System.Exception

        Public Sub New()
            MyBase.New(My.Resources.Exceptions.InvalidUserNameOrPassword)
        End Sub
    End Class

#End Region

#Region "Category Exception"

    Public Class CategoryIsInUse
        Inherits System.Exception

        Public Sub New()
            MyBase.New(My.Resources.Exceptions.CategoryIsInUse)
        End Sub
    End Class

#End Region

#Region "Coding Exception"

    Public Class CodingIsInUse
        Inherits System.Exception

        Public Sub New()
            MyBase.New(My.Resources.Exceptions.CodingInUse)
        End Sub
    End Class

#End Region










End Namespace
