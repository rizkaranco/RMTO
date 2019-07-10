Namespace BLL

    Public MustInherit Class BusinessFactoryBase
        Private _TableName As String
        Private _dataObject As Object

        Public Sub New(ByVal TableName As String)
            Me._TableName = TableName
            Dim AppInfo As New Common.ApplicationInfo(TableName)

            If Type.GetType(AppInfo.DataAccessLayer) IsNot Nothing Then
                _dataObject = Activator.CreateInstance(Type.GetType(AppInfo.DataAccessLayer))
            Else
                _dataObject = System.Reflection.Assembly.GetEntryAssembly.CreateInstance(AppInfo.DataAccessLayer)
            End If
        End Sub

        Public ReadOnly Property DataAccessLayer() As Object
            Get
                Return _dataObject
            End Get
        End Property

        Public ReadOnly Property TableID() As Int64
            Get
                Try
                    Return Me._dataObject.TableID(Me._TableName)
                Catch ex As System.Exception
                    Throw ex
                End Try
            End Get
        End Property

        Public ReadOnly Property TablePersianName() As String
            Get
                Try
                    Return Me._dataObject.TablePersianName(Me.TableID)
                Catch ex As System.Exception
                    Throw ex
                End Try
            End Get
        End Property

        Public ReadOnly Property TablePersianName(ByVal TableName As String) As String
            Get
                Try
                    Return Me._dataObject.TablePersianName(Me._dataObject.TableID(TableName))
                Catch ex As System.Exception
                    Throw ex
                End Try
            End Get
        End Property

        Public ReadOnly Property TableName() As String
            Get
                Try
                    Return Me._TableName
                Catch ex As System.Exception
                    Throw ex
                End Try
            End Get
        End Property

        Public Sub BeginProc()
            Try
                Me._dataObject.BeginTransaction()
            Catch ex As System.Exception
                Throw ex
            End Try
        End Sub

        Public Sub CommitProc()
            Try
                Me._dataObject.Commit()
            Catch ex As System.Exception
                Throw ex
            End Try
        End Sub

        Public Sub RollBackProc()
            Try
                Me._dataObject.RollBack()
            Catch ex As System.Exception
                Throw ex
            End Try
        End Sub

        Public ReadOnly Property ServerJalaliDate() As String
            Get
                Try
                    Return Me.ConvertDate(Me.ServerDate)
                Catch ex As System.Exception
                    Throw ex
                End Try
            End Get
        End Property

        Public ReadOnly Property ServerDate() As Date
            Get
                Try
                    Return _dataObject.ServerDate
                Catch ex As System.Exception
                    Throw ex
                End Try
            End Get
        End Property

        Public ReadOnly Property ServerTime() As String
            Get
                Try
                    Dim time As TimeSpan
                    time = _dataObject.ServerDate.TimeOfDay()
                    Return time.ToString.Substring(0, 8)
                Catch ex As System.Exception
                    Throw ex
                End Try
            End Get
        End Property

        Private Function ConvertDate(ByVal InputDate As Date) As String
            Try
                Dim Result As String = String.Empty
                Dim PersianCalender As New System.Globalization.PersianCalendar
                Dim Year As Integer = PersianCalender.GetYear(InputDate)
                Dim Month As Integer = PersianCalender.GetMonth(InputDate)
                Dim Day As Integer = PersianCalender.GetDayOfMonth(InputDate)
                Result += Year.ToString + "/"
                If Month < 10 Then
                    Result += "0" + Month.ToString + "/"
                Else
                    Result += Month.ToString + "/"
                End If
                If Day < 10 Then
                    Result += "0" + Day.ToString
                Else
                    Result += Day.ToString
                End If
                Return Result
            Catch ex As System.Exception
                Throw ex
            End Try
        End Function

    End Class

End Namespace