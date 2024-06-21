<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        btnViewSubmissions = New Button()
        btnCreateSubmission = New Button()
        SuspendLayout()
        ' 
        ' btnViewSubmissions
        ' 
        btnViewSubmissions.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        btnViewSubmissions.BackgroundImageLayout = ImageLayout.None
        btnViewSubmissions.ForeColor = SystemColors.ControlLightLight
        btnViewSubmissions.Location = New Point(377, 200)
        btnViewSubmissions.Name = "btnViewSubmissions"
        btnViewSubmissions.Size = New Size(294, 29)
        btnViewSubmissions.TabIndex = 0
        btnViewSubmissions.Text = "View Submissions (CTRL+V)"
        btnViewSubmissions.TextImageRelation = TextImageRelation.ImageAboveText
        btnViewSubmissions.UseVisualStyleBackColor = False
        ' 
        ' btnCreateSubmission
        ' 
        btnCreateSubmission.BackColor = Color.FromArgb(CByte(192), CByte(64), CByte(0))
        btnCreateSubmission.ForeColor = SystemColors.ButtonHighlight
        btnCreateSubmission.Location = New Point(377, 265)
        btnCreateSubmission.Name = "btnCreateSubmission"
        btnCreateSubmission.Size = New Size(294, 29)
        btnCreateSubmission.TabIndex = 1
        btnCreateSubmission.Text = "Create New Submission (CTRL+N)"
        btnCreateSubmission.UseVisualStyleBackColor = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaption
        ClientSize = New Size(1053, 565)
        Controls.Add(btnCreateSubmission)
        Controls.Add(btnViewSubmissions)
        KeyPreview = True
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
    End Sub

    Friend WithEvents btnViewSubmissions As Button
    Friend WithEvents btnCreateSubmission As Button

End Class
