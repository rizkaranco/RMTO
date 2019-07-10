Imports System
Imports System.Collections.Generic
Imports System.Text

Namespace BLL

    Public Class BLLDataSource_TKeys

        Private _DataSourceID_bint As Int64


        Public Property DataSourceID_bint() As Int64
            Get
                Return _DataSourceID_bint
            End Get
            Set(ByVal value As Int64)
                Me._DataSourceID_bint = value
            End Set
        End Property


    End Class
End Namespace