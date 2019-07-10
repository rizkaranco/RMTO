Namespace Common

    Public Class ClipBoard

        Private Shared ClipBoard As List(Of Object)

        Public Shared Function GetObjects(ByVal objType As Type, Optional ByVal Remove As Boolean = True) As List(Of Object)
            Dim tmpClipBoard As New List(Of Object)
            Dim Res As New List(Of Object)
            If ClipBoard Is Nothing Then
                Return Res
            End If

            For Each obj As Object In ClipBoard
                Dim info As Type = obj.GetType
                If objType Is info Then
                    Res.Add(obj)
                    If Remove Then
                        tmpClipBoard.Add(obj)
                    End If
                End If
            Next
            For Each obj In tmpClipBoard
                ClipBoard.Remove(obj)
            Next

            Return Res
        End Function

        Public Shared Sub Add(ByVal myObject As Object)
            If ClipBoard Is Nothing Then
                ClipBoard = New List(Of Object)
            End If
            ClipBoard.Add(myObject)
        End Sub

        Public Shared Sub Clear(ByVal objType As Type)
            Dim tmpClipBoard As New List(Of Object)
            If ClipBoard IsNot Nothing Then
                For Each obj As Object In ClipBoard
                    Dim info As Type = obj.GetType
                    If objType Is info Then
                        tmpClipBoard.Add(obj)
                    End If
                Next
                For Each obj In tmpClipBoard
                    ClipBoard.Remove(obj)
                Next
            End If
        End Sub

    End Class

End Namespace

