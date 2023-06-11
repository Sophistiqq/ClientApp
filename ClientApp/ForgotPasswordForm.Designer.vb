<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ForgotPasswordForm
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
        Me.Cancel_Button = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.usernameTextBox = New System.Windows.Forms.TextBox()
        Me.emailTextBox = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Cancel_Button
        '
        Me.Cancel_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Cancel_Button.BackColor = System.Drawing.Color.FromArgb(CType(CType(87, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel_Button.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Cancel_Button.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.Cancel_Button.Location = New System.Drawing.Point(303, 275)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(67, 23)
        Me.Cancel_Button.TabIndex = 1
        Me.Cancel_Button.Text = "Cancel"
        Me.Cancel_Button.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(32, 101)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Username"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(35, 152)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Email"
        '
        'usernameTextBox
        '
        Me.usernameTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.usernameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.usernameTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.usernameTextBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.usernameTextBox.Location = New System.Drawing.Point(162, 97)
        Me.usernameTextBox.Multiline = True
        Me.usernameTextBox.Name = "usernameTextBox"
        Me.usernameTextBox.Size = New System.Drawing.Size(174, 29)
        Me.usernameTextBox.TabIndex = 3
        '
        'emailTextBox
        '
        Me.emailTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.emailTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.emailTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.emailTextBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.emailTextBox.Location = New System.Drawing.Point(162, 146)
        Me.emailTextBox.Multiline = True
        Me.emailTextBox.Name = "emailTextBox"
        Me.emailTextBox.Size = New System.Drawing.Size(174, 29)
        Me.emailTextBox.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(94, 36)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(98, 25)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Password"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.Button1.Location = New System.Drawing.Point(122, 220)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(132, 35)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Recover Password"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(87, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(190, 36)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(94, 25)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Recovery"
        '
        'ForgotPasswordForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(19, Byte), Integer), CType(CType(6, Byte), Integer))
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(387, 315)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Cancel_Button)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.emailTextBox)
        Me.Controls.Add(Me.usernameTextBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ForgotPasswordForm"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Password Recovery"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents usernameTextBox As TextBox
    Friend WithEvents emailTextBox As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label4 As Label
End Class
