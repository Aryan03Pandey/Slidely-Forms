Imports System.Net.Http
Imports Newtonsoft.Json
Public Class Form2

    Private currentIndex As Integer = 0
    Private totalSubmissions As Integer = 0
    Private submissions As List(Of Submission)

    ' Form constructor
    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()

        ' Set KeyPreview to true so the form can capture key events
        Me.KeyPreview = True

        ' Add KeyDown event handler
        AddHandler Me.KeyDown, AddressOf Form2_KeyDown
    End Sub

    ' Event handler for KeyDown event
    Private Sub Form2_KeyDown(sender As Object, e As KeyEventArgs)
        ' Check if Ctrl+V is pressed
        If e.Control AndAlso e.KeyCode = Keys.P Then
            ' Call the button click event handler
            btnPrevious.PerformClick()
        End If

        ' Check is CTRL+N is pressed
        If e.Control AndAlso e.KeyCode = Keys.N Then
            ' Call the button click event handler
            btnNext.PerformClick()
        End If

        If e.Control AndAlso e.KeyCode = Keys.D Then
            ' Call the button click event handler
            btnDelete.PerformClick()
        End If

        If e.Control AndAlso e.KeyCode = Keys.E Then
            ' Call the button click event handler
            btnEdit.PerformClick()
        End If
    End Sub

    Private Async Sub ViewSubmissionsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Await LoadCount()
        If totalSubmissions > 0 Then
            Await LoadSubmission(currentIndex)
        End If
    End Sub

    Private Async Function LoadSubmission(index As Integer) As Task
        Using client As New HttpClient()
            Dim response = Await client.GetStringAsync("http://localhost:3000/read?index=" & index)
            Dim submission = JsonConvert.DeserializeObject(Of Submission)(response)
            DisplaySubmission(submission)
        End Using
    End Function

    Private Async Function DeleteSubmission(index As Integer) As Task
        If totalSubmissions > 0 Then
            Dim result As DialogResult = MessageBox.Show("Are you sure you want to delete this submission?", "Confirm Delete", MessageBoxButtons.YesNo)
            If result = DialogResult.Yes Then
                Using client As New HttpClient()
                    Dim response = Await client.DeleteAsync("http://localhost:3000/delete?index=" & index)
                    If response.IsSuccessStatusCode Then
                        MessageBox.Show("Submission deleted successfully.")
                        ' Update the total submissions count
                        Await LoadCount()
                        ' Load the next or previous submission if available
                        If currentIndex >= totalSubmissions Then
                            currentIndex = Math.Max(0, totalSubmissions - 1)
                        End If
                        If totalSubmissions > 0 Then
                            Await LoadSubmission(currentIndex)
                        Else
                            ' Clear the form if no submissions are left
                            ClearForm()
                        End If
                    Else
                        MessageBox.Show("Failed to delete the submission.")
                    End If
                End Using
            End If
        End If
    End Function

    Private Sub ClearForm()
        nameText.Text = ""
        emailText.Text = ""
        phoneText.Text = ""
        githubText.Text = ""
        timeText.Text = ""
    End Sub

    Private Async Function LoadCount() As Task
        Using client As New HttpClient()
            ' Fetch the total count of submissions
            Dim countResponse = Await client.GetStringAsync("http://localhost:3000/count")
            Dim countData = JsonConvert.DeserializeObject(Of CountResponse)(countResponse)
            totalSubmissions = countData.count
        End Using
    End Function

    Private Sub DisplaySubmission(submission As Submission)
        nameText.Text = submission.name
        emailText.Text = submission.email
        phoneText.Text = submission.phone
        githubText.Text = submission.github_link
        timeText.Text = submission.stopwatch_time
    End Sub

    ' Button click event handler
    Private Async Sub btnPrevious_Click(sender As Object, e As EventArgs) Handles btnPrevious.Click
        If currentIndex > 0 Then
            currentIndex -= 1
            Await LoadSubmission(currentIndex)
        End If
    End Sub

    Private Async Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        If currentIndex < totalSubmissions - 1 Then
            currentIndex += 1
            Await LoadSubmission(currentIndex)
        End If
    End Sub

    Private Async Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Await DeleteSubmission(currentIndex)
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        MessageBox.Show("Edit")
    End Sub


End Class

Public Class Submission
    Public Property name As String
    Public Property email As String
    Public Property phone As String
    Public Property github_link As String
    Public Property stopwatch_time As String
End Class

Public Class CountResponse
    Public Property count As Integer
End Class