﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LoginType
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
        Me.StudentLoginButton = New System.Windows.Forms.Button()
        Me.TeacherLoginButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'StudentLoginButton
        '
        Me.StudentLoginButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StudentLoginButton.Location = New System.Drawing.Point(195, 185)
        Me.StudentLoginButton.Name = "StudentLoginButton"
        Me.StudentLoginButton.Size = New System.Drawing.Size(132, 58)
        Me.StudentLoginButton.TabIndex = 0
        Me.StudentLoginButton.Text = "Student Login"
        Me.StudentLoginButton.UseVisualStyleBackColor = True
        '
        'TeacherLoginButton
        '
        Me.TeacherLoginButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TeacherLoginButton.Location = New System.Drawing.Point(446, 185)
        Me.TeacherLoginButton.Name = "TeacherLoginButton"
        Me.TeacherLoginButton.Size = New System.Drawing.Size(127, 58)
        Me.TeacherLoginButton.TabIndex = 1
        Me.TeacherLoginButton.Text = "Teacher Login"
        Me.TeacherLoginButton.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(195, 148)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(306, 18)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Are you logging in as a 'Student' or 'Teacher'?"
        '
        'LoginType
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TeacherLoginButton)
        Me.Controls.Add(Me.StudentLoginButton)
        Me.Name = "LoginType"
        Me.Text = "LoginType"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents StudentLoginButton As Button
    Friend WithEvents TeacherLoginButton As Button
    Friend WithEvents Label1 As Label
End Class
