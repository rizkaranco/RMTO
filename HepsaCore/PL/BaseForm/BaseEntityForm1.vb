Namespace PL
    Public Class BaseEntityForm1

        Public Sub New(ByVal DataTable As DataTable)
            MyBase.New(enmFormType.ButtonForm, DataTable)
            InitializeComponent()
            MakeClass()
        End Sub

        Public Sub New(ByVal State As BaseEntityParentForm.enmState, ByVal DataTable As DataTable, ByVal Key As Object)
            MyBase.New(enmFormType.ButtonForm, State, DataTable, Key)
            InitializeComponent()
            MakeClass()
        End Sub

        Public Sub New()
            InitializeComponent()
            MakeClass()
        End Sub

        Private Sub MakeClass()
            MyBase.ShowStackFormWhenFormClosed = False
            MyBase.SaveAndContinueButton = Me.SaveAndNextButton
            MyBase.SaveAndExitButton = Me.SaveAndCloseButton
            MyBase.DeleteButton = Me.DeleteRecordButton
            MyBase.CloseButton = Me.CloseFormButton
        End Sub

    End Class
End Namespace