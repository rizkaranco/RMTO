Imports System
Imports System.Collections.Generic
Imports System.Text

Namespace BLL

    Public Class BLLExtraFieldTemplate_TKeys

        Private _ExtraFieldTemplateID_bint As Int64


        Public Property ExtraFieldTemplateID_bint() As Int64
            Get
                Return _ExtraFieldTemplateID_bint
            End Get
            Set(ByVal value As Int64)
                Me._ExtraFieldTemplateID_bint = Value
            End Set
        End Property


    End Class
End Namespace