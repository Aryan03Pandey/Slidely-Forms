<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        nameField = New Label()
        timeField = New Label()
        githubField = New Label()
        phoneField = New Label()
        emailField = New Label()
        nameText = New TextBox()
        emailText = New TextBox()
        phoneText = New TextBox()
        githubText = New TextBox()
        timeText = New TextBox()
        btnPrevious = New Button()
        btnNext = New Button()
        btnDelete = New Button()
        btnEdit = New Button()
        SuspendLayout()
        ' 
        ' nameField
        ' 
        nameField.AutoSize = True
        nameField.Location = New Point(380, 134)
        nameField.Name = "nameField"
        nameField.Size = New Size(49, 20)
        nameField.TabIndex = 0
        nameField.Text = "Name"
        ' 
        ' timeField
        ' 
        timeField.AutoSize = True
        timeField.Location = New Point(380, 309)
        timeField.Name = "timeField"
        timeField.Size = New Size(116, 20)
        timeField.TabIndex = 8
        timeField.Text = "Stopwatch Time"
        ' 
        ' githubField
        ' 
        githubField.AutoSize = True
        githubField.Location = New Point(380, 265)
        githubField.Name = "githubField"
        githubField.Size = New Size(149, 20)
        githubField.TabIndex = 6
        githubField.Text = "Github Link for Task 2"
        ' 
        ' phoneField
        ' 
        phoneField.AutoSize = True
        phoneField.Location = New Point(380, 218)
        phoneField.Name = "phoneField"
        phoneField.Size = New Size(86, 20)
        phoneField.TabIndex = 4
        phoneField.Text = "Phone Num"
        ' 
        ' emailField
        ' 
        emailField.AutoSize = True
        emailField.Location = New Point(380, 175)
        emailField.Name = "emailField"
        emailField.Size = New Size(46, 20)
        emailField.TabIndex = 2
        emailField.Text = "Email"
        ' 
        ' nameText
        ' 
        nameText.Location = New Point(601, 127)
        nameText.Name = "nameText"
        nameText.ReadOnly = True
        nameText.Size = New Size(293, 27)
        nameText.TabIndex = 1
        ' 
        ' emailText
        ' 
        emailText.Location = New Point(601, 168)
        emailText.Name = "emailText"
        emailText.ReadOnly = True
        emailText.Size = New Size(293, 27)
        emailText.TabIndex = 3
        ' 
        ' phoneText
        ' 
        phoneText.Location = New Point(601, 211)
        phoneText.Name = "phoneText"
        phoneText.ReadOnly = True
        phoneText.Size = New Size(293, 27)
        phoneText.TabIndex = 5
        ' 
        ' githubText
        ' 
        githubText.Location = New Point(601, 258)
        githubText.Name = "githubText"
        githubText.ReadOnly = True
        githubText.Size = New Size(293, 27)
        githubText.TabIndex = 7
        ' 
        ' timeText
        ' 
        timeText.Location = New Point(601, 302)
        timeText.Name = "timeText"
        timeText.ReadOnly = True
        timeText.Size = New Size(293, 27)
        timeText.TabIndex = 9
        ' 
        ' btnPrevious
        ' 
        btnPrevious.Location = New Point(357, 410)
        btnPrevious.Name = "btnPrevious"
        btnPrevious.Size = New Size(258, 29)
        btnPrevious.TabIndex = 10
        btnPrevious.Text = "Previous (CTRL+P)"
        btnPrevious.UseVisualStyleBackColor = True
        ' 
        ' btnNext
        ' 
        btnNext.Location = New Point(652, 410)
        btnNext.Name = "btnNext"
        btnNext.Size = New Size(258, 29)
        btnNext.TabIndex = 11
        btnNext.Text = "Next (CTRL+N)"
        btnNext.UseVisualStyleBackColor = True
        ' 
        ' btnDelete
        ' 
        btnDelete.Location = New Point(357, 477)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(258, 29)
        btnDelete.TabIndex = 12
        btnDelete.Text = "Delete Submission (CTRL+D)"
        btnDelete.UseVisualStyleBackColor = True
        ' 
        ' btnEdit
        ' 
        btnEdit.Location = New Point(652, 477)
        btnEdit.Name = "btnEdit"
        btnEdit.Size = New Size(258, 29)
        btnEdit.TabIndex = 13
        btnEdit.Text = "Edit Submission (CTRL+E)"
        btnEdit.UseVisualStyleBackColor = True
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1233, 638)
        Controls.Add(btnEdit)
        Controls.Add(btnDelete)
        Controls.Add(btnNext)
        Controls.Add(btnPrevious)
        Controls.Add(timeText)
        Controls.Add(githubText)
        Controls.Add(phoneText)
        Controls.Add(emailText)
        Controls.Add(nameText)
        Controls.Add(emailField)
        Controls.Add(phoneField)
        Controls.Add(githubField)
        Controls.Add(timeField)
        Controls.Add(nameField)
        Name = "Form2"
        Text = "Form2"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents nameField As Label
    Friend WithEvents timeField As Label
    Friend WithEvents githubField As Label
    Friend WithEvents phoneField As Label
    Friend WithEvents emailField As Label
    Friend WithEvents nameText As TextBox
    Friend WithEvents emailText As TextBox
    Friend WithEvents phoneText As TextBox
    Friend WithEvents githubText As TextBox
    Friend WithEvents timeText As TextBox
    Friend WithEvents btnPrevious As Button
    Friend WithEvents btnNext As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnEdit As Button
End Class
