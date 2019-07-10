Imports System
Imports System.Collections.Generic
Imports System.Text

Namespace BLL

    Public Class BLLExtraFieldValue_TKeys

        Private _ExtraFieldID_bint As Int64
        Private _TableID_bint As Int64
        Private _ParentID_nvc As String


        Public Property ExtraFieldID_bint() As Int64
            Get
                Return _ExtraFieldID_bint
            End Get
            Set(ByVal value As Int64)
                Me._ExtraFieldID_bint = value
            End Set
        End Property

        Public Property TableID_bint() As Int64
            Get
                Return _TableID_bint
            End Get
            Set(ByVal value As Int64)
                Me._TableID_bint = value
            End Set
        End Property

        Public Property ParentID_nvc() As String
            Get
                Return _ParentID_nvc
            End Get
            Set(ByVal value As String)
                Me._ParentID_nvc = value
            End Set
        End Property


    End Class
End Namespace