Imports System.Diagnostics
Imports System.Net.Http
Imports System.Text
Imports Newtonsoft.Json

Public Class Form3

    Private stopwatch As New Stopwatch()
    Private isStopwatchRunning As Boolean = False

    ' Form constructor
    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()

        ' Set KeyPreview to true so the form can capture key events
        Me.KeyPreview = True

        ' Add KeyDown event handler
        AddHandler Me.KeyDown, AddressOf Form3_KeyDown
    End Sub

    ' Event handler for KeyDown event
    Private Sub Form3_KeyDown(sender As Object, e As KeyEventArgs)
        ' Check if Ctrl+V is pressed
        If e.Control AndAlso e.KeyCode = Keys.T Then
            ' Call the button click event handler
            btnStopwatch.PerformClick()
        End If

        ' Check is CTRL+N is pressed
        If e.Control AndAlso e.KeyCode = Keys.S Then
            ' Call the button click event handler
            btnSubmit.PerformClick()
        End If
    End Sub

    ' Button click event handler
    Private Sub btnStopwatch_Click(sender As Object, e As EventArgs) Handles btnStopwatch.Click
        If isStopwatchRunning Then
            stopwatch.Stop()
            Timer1.Stop()
            btnStopwatch.Text = "Start Stopwatch (CTRL + T)"
        Else
            stopwatch.Start()
            Timer1.Start()
            btnStopwatch.Text = "Pause Stopwatch (CTRL + T)"
        End If
        isStopwatchRunning = Not isStopwatchRunning
    End Sub

    Private Async Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Dim submission = New With {
            .name = nameInput.Text,
            .email = emailInput.Text,
            .phone = phoneInput.Text,
            .github_link = githubInput.Text,
            .stopwatch_time = timeInput.Text
        }

        Dim json = JsonConvert.SerializeObject(submission)
        Dim data = New StringContent(json, Encoding.UTF8, "application/json")

        Using client As New HttpClient()
            Dim response = Await client.PostAsync("http://localhost:3000/submit", data)
            If response.IsSuccessStatusCode Then
                MessageBox.Show("Submission successful!")
            Else
                MessageBox.Show("Error submitting form.")
            End If
        End Using
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        timeInput.Text = String.Format("{0:hh\:mm\:ss}", stopwatch.Elapsed)
    End Sub
End Class
