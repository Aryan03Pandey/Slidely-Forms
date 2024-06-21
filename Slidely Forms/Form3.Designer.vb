<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        nameLabel = New Label()
        emailLabel = New Label()
        phoneLabel = New Label()
        githubLabel = New Label()
        nameInput = New TextBox()
        emailInput = New TextBox()
        phoneInput = New TextBox()
        githubInput = New TextBox()
        btnStopwatch = New Button()
        timeInput = New Label()
        btnSubmit = New Button()
        Timer1 = New Timer(components)
        SuspendLayout()
        ' 
        ' nameLabel
        ' 
        nameLabel.AutoSize = True
        nameLabel.Location = New Point(369, 149)
        nameLabel.Name = "nameLabel"
        nameLabel.Size = New Size(49, 20)
        nameLabel.TabIndex = 0
        nameLabel.Text = "Name"
        ' 
        ' emailLabel
        ' 
        emailLabel.AutoSize = True
        emailLabel.Location = New Point(369, 204)
        emailLabel.Name = "emailLabel"
        emailLabel.Size = New Size(46, 20)
        emailLabel.TabIndex = 1
        emailLabel.Text = "Email"
        ' 
        ' phoneLabel
        ' 
        phoneLabel.AutoSize = True
        phoneLabel.Location = New Point(369, 262)
        phoneLabel.Name = "phoneLabel"
        phoneLabel.Size = New Size(86, 20)
        phoneLabel.TabIndex = 2
        phoneLabel.Text = "Phone Num"
        ' 
        ' githubLabel
        ' 
        githubLabel.AutoSize = True
        githubLabel.Location = New Point(369, 317)
        githubLabel.Name = "githubLabel"
        githubLabel.Size = New Size(149, 20)
        githubLabel.TabIndex = 3
        githubLabel.Text = "Github Link for Task 2"
        ' 
        ' nameInput
        ' 
        nameInput.Location = New Point(565, 142)
        nameInput.Name = "nameInput"
        nameInput.Size = New Size(281, 27)
        nameInput.TabIndex = 4
        ' 
        ' emailInput
        ' 
        emailInput.Location = New Point(565, 197)
        emailInput.Name = "emailInput"
        emailInput.Size = New Size(281, 27)
        emailInput.TabIndex = 5
        ' 
        ' phoneInput
        ' 
        phoneInput.Location = New Point(565, 255)
        phoneInput.Name = "phoneInput"
        phoneInput.Size = New Size(281, 27)
        phoneInput.TabIndex = 6
        ' 
        ' githubInput
        ' 
        githubInput.Location = New Point(565, 310)
        githubInput.Name = "githubInput"
        githubInput.Size = New Size(281, 27)
        githubInput.TabIndex = 7
        ' 
        ' btnStopwatch
        ' 
        btnStopwatch.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        btnStopwatch.ForeColor = Color.White
        btnStopwatch.Location = New Point(369, 395)
        btnStopwatch.Name = "btnStopwatch"
        btnStopwatch.Size = New Size(280, 29)
        btnStopwatch.TabIndex = 8
        btnStopwatch.Text = "Toggle Stopwatch (CTRL+T)"
        btnStopwatch.UseVisualStyleBackColor = False
        ' 
        ' timeInput
        ' 
        timeInput.AutoSize = True
        timeInput.Location = New Point(783, 395)
        timeInput.Name = "timeInput"
        timeInput.Size = New Size(63, 20)
        timeInput.TabIndex = 9
        timeInput.Text = "00:00:00"
        ' 
        ' btnSubmit
        ' 
        btnSubmit.BackColor = Color.Green
        btnSubmit.ForeColor = Color.White
        btnSubmit.Location = New Point(439, 463)
        btnSubmit.Name = "btnSubmit"
        btnSubmit.Size = New Size(351, 29)
        btnSubmit.TabIndex = 10
        btnSubmit.Text = "Submit (CTRL+S)"
        btnSubmit.UseVisualStyleBackColor = False
        ' 
        ' Timer1
        ' 
        Timer1.Interval = 1000
        ' 
        ' Form3
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaption
        ClientSize = New Size(1156, 665)
        Controls.Add(btnSubmit)
        Controls.Add(timeInput)
        Controls.Add(btnStopwatch)
        Controls.Add(githubInput)
        Controls.Add(phoneInput)
        Controls.Add(emailInput)
        Controls.Add(nameInput)
        Controls.Add(githubLabel)
        Controls.Add(phoneLabel)
        Controls.Add(emailLabel)
        Controls.Add(nameLabel)
        Name = "Form3"
        Text = "Form3"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents nameLabel As Label
    Friend WithEvents emailLabel As Label
    Friend WithEvents phoneLabel As Label
    Friend WithEvents githubLabel As Label
    Friend WithEvents nameInput As TextBox
    Friend WithEvents emailInput As TextBox
    Friend WithEvents phoneInput As TextBox
    Friend WithEvents githubInput As TextBox
    Friend WithEvents btnStopwatch As Button
    Friend WithEvents timeInput As Label
    Friend WithEvents btnSubmit As Button
    Friend WithEvents Timer1 As Timer
End Class
