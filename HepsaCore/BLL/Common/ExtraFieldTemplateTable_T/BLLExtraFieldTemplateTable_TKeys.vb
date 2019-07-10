Imports System
Imports System.Collections.Generic
Imports System.Text

Namespace BLL

    Public Class BLLExtraFieldTemplateTable_TKeys

        Private _ExtraFieldTemplateTableID_bint As Int64

        Public Property ExtraFieldTemplateTableID_bint() As Int64
            Get
                Return _ExtraFieldTemplateTableID_bint
            End Get
            Set(ByVal value As Int64)
                Me._ExtraFieldTemplateTableID_bint = value
            End Set
        End Property

    End Class
End Namespace