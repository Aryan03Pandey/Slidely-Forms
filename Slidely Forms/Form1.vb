Public Class Form1

    ' Form constructor
    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()

        ' Set KeyPreview to true so the form can capture key events
        Me.KeyPreview = True

        ' Add KeyDown event handler
        AddHandler Me.KeyDown, AddressOf Form1_KeyDown
    End Sub

    ' Event handler for KeyDown event
    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs)
        ' Check if Ctrl+V is pressed
        If e.Control AndAlso e.KeyCode = Keys.V Then
            ' Call the button click event handler
            btnViewSubmissions.PerformClick()
        End If

        ' Check is CTRL+N is pressed
        If e.Control AndAlso e.KeyCode = Keys.N Then
            ' Call the button click event handler
            btnCreateSubmission.PerformClick()
        End If
    End Sub

    ' Button click event handler
    Private Sub btnView_Click(sender As Object, e As EventArgs) Handles btnViewSubmissions.Click
        Dim viewSubmissionsForm As New Form2()
        viewSubmissionsForm.ShowDialog()
    End Sub

    Private Sub btnCreate_Click(sender As Object, e As EventArgs) Handles btnCreateSubmission.Click
        Dim createSubmissionForm As New Form3()
        createSubmissionForm.ShowDialog()
    End Sub

End Class
