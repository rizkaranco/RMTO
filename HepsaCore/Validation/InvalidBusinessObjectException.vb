Imports System
Imports System.Collections.Generic
Imports System.Text

Namespace Validation

    Public Class InvalidBusinessObjectException
        Inherits System.Exception

        Public Sub New(ByVal message As String)
            MyBase.New(message)
        End Sub
    End Class

End Namespace
