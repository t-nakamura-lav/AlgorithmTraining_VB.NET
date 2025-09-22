<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Chapter1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        txtResult = New TextBox()
        txtQuestion = New TextBox()
        btnAnswer = New Button()
        txtN = New TextBox()
        Label2 = New Label()
        btnQuestion = New Button()
        SuspendLayout()
        ' 
        ' txtResult
        ' 
        txtResult.Location = New Point(28, 272)
        txtResult.Multiline = True
        txtResult.Name = "txtResult"
        txtResult.Size = New Size(743, 153)
        txtResult.TabIndex = 1
        ' 
        ' txtQuestion
        ' 
        txtQuestion.Location = New Point(28, 55)
        txtQuestion.Multiline = True
        txtQuestion.Name = "txtQuestion"
        txtQuestion.Size = New Size(736, 84)
        txtQuestion.TabIndex = 3
        ' 
        ' btnAnswer
        ' 
        btnAnswer.Location = New Point(28, 237)
        btnAnswer.Name = "btnAnswer"
        btnAnswer.Size = New Size(94, 29)
        btnAnswer.TabIndex = 4
        btnAnswer.Text = "解答"
        btnAnswer.UseVisualStyleBackColor = True
        ' 
        ' txtN
        ' 
        txtN.Location = New Point(95, 178)
        txtN.Name = "txtN"
        txtN.Size = New Size(101, 27)
        txtN.TabIndex = 6
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(32, 178)
        Label2.Name = "Label2"
        Label2.Size = New Size(59, 20)
        Label2.TabIndex = 5
        Label2.Text = "nの値："
        ' 
        ' btnQuestion
        ' 
        btnQuestion.Location = New Point(28, 20)
        btnQuestion.Name = "btnQuestion"
        btnQuestion.Size = New Size(94, 29)
        btnQuestion.TabIndex = 8
        btnQuestion.Text = "問題"
        btnQuestion.UseVisualStyleBackColor = True
        ' 
        ' Chapter1
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btnQuestion)
        Controls.Add(txtN)
        Controls.Add(Label2)
        Controls.Add(btnAnswer)
        Controls.Add(txtQuestion)
        Controls.Add(txtResult)
        Name = "Chapter1"
        Text = "Chapter1 Training1-6"
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents txtResult As TextBox
    Friend WithEvents txtQuestion As TextBox
    Friend WithEvents btnAnswer As Button
    Friend WithEvents txtN As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btnQuestion As Button

End Class
