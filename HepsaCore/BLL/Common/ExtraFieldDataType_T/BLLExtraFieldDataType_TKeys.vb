Imports System
Imports System.Collections.Generic
Imports System.Text

Namespace BLL

    Public Class BLLExtraFieldDataType_TKeys

        Private _ExtraFieldDataTypeID_tint As Byte


        Public Property ExtraFieldDataTypeID_tint() As Byte
            Get
                Return _ExtraFieldDataTypeID_tint
            End Get
            Set(ByVal value As Byte)
                Me._ExtraFieldDataTypeID_tint = Value
            End Set
        End Property


    End Class
End Namespace