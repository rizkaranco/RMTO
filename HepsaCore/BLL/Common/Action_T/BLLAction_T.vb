Imports System
Imports System.Collections.Generic
Imports System.Text
Imports Hepsa.Core.Validation

Namespace BLL

    Public Class BLLAction_T
        Inherits BusinessObjectBase

        Public Enum Action_TField
            ActionID_int
            Action_nvc
        End Enum

        Public Enum Actions
            OpeningForm = 1
            ClosingForm = 2
            Add = 3
            Edit = 4
            Delete = 5
            Print = 6
            Report = 7
        End Enum

        Private _ActionID_int As Int32
        Private _Action_nvc As String


        Public Property ActionID_int() As Int32
            Get
                Return _ActionID_int
            End Get
            Set(ByVal value As Int32)
                Me._ActionID_int = value
            End Set
        End Property

        Public Property Action_nvc() As String
            Get
                Return _Action_nvc
            End Get
            Set(ByVal value As String)
                Me._Action_nvc = value
            End Set
        End Property


        Friend Overloads Overrides Sub AddValidationRules()
            ValidationRules.AddRules(New NotNullRule("Action_nvc", "عملیات"))
            ValidationRules.AddRules(New StringMaxLengthRule("Action_nvc", "عملیات", 50))
            ValidationRules.AddRules(New UniqueRule("UniqueActionID_int", "شناسه عملیات", "Action_T", "ActionID_int"))
        End Sub
    End Class
End Namespace