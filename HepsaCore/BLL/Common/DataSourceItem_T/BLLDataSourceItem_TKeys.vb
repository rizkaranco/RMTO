Imports System
Imports System.Collections.Generic
Imports System.Text

Namespace BLL

    Public Class BLLDataSourceItem_TKeys

        Private _DataSourceItemID_bint As Int64


        Public Property DataSourceItemID_bint() As Int64
            Get
                Return _DataSourceItemID_bint
            End Get
            Set(ByVal value As Int64)
                Me._DataSourceItemID_bint = value
            End Set
        End Property

    End Class
End Namespace