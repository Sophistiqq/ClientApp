<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LoginForm
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
        Me.Label5 = New System.Windows.Forms.Label()
        Me.loginBtn = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.label1 = New System.Windows.Forms.Label()
        Me.forgotPassword = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.passwordBox = New System.Windows.Forms.MaskedTextBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.usernameBox = New System.Windows.Forms.MaskedTextBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox6.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(35, 166)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(93, 18)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Login Now"
        '
        'loginBtn
        '
        Me.loginBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.loginBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.loginBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.loginBtn.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Bold)
        Me.loginBtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.loginBtn.Location = New System.Drawing.Point(38, 338)
        Me.loginBtn.Name = "loginBtn"
        Me.loginBtn.Size = New System.Drawing.Size(90, 34)
        Me.loginBtn.TabIndex = 6
        Me.loginBtn.Text = "Login"
        Me.loginBtn.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Verdana", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(34, 27)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(185, 23)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "Security System"
        '
        'label1
        '
        Me.label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.label1.AutoSize = True
        Me.label1.Font = New System.Drawing.Font("Verdana", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.label1.Location = New System.Drawing.Point(32, 119)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(245, 32)
        Me.label1.TabIndex = 0
        Me.label1.Text = "Welcome Back,"
        '
        'forgotPassword
        '
        Me.forgotPassword.AutoSize = True
        Me.forgotPassword.Cursor = System.Windows.Forms.Cursors.Hand
        Me.forgotPassword.Font = New System.Drawing.Font("Verdana", 9.0!)
        Me.forgotPassword.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.forgotPassword.Location = New System.Drawing.Point(34, 389)
        Me.forgotPassword.Name = "forgotPassword"
        Me.forgotPassword.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.forgotPassword.Size = New System.Drawing.Size(121, 14)
        Me.forgotPassword.TabIndex = 3
        Me.forgotPassword.Text = "Forgot Password?"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(12, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Controls.Add(Me.GroupBox6)
        Me.Panel1.Controls.Add(Me.TextBox1)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.loginBtn)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.label1)
        Me.Panel1.Controls.Add(Me.forgotPassword)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(363, 450)
        Me.Panel1.TabIndex = 17
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.Enabled = False
        Me.TextBox1.Location = New System.Drawing.Point(18, 32)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(5, 370)
        Me.TextBox1.TabIndex = 10
        Me.TextBox1.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.ClientApp.My.Resources.Resources._20945597
        Me.PictureBox1.Location = New System.Drawing.Point(369, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(431, 450)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 16
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.White
        Me.PictureBox2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox2.Image = Global.ClientApp.My.Resources.Resources.close
        Me.PictureBox2.Location = New System.Drawing.Point(760, 0)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(40, 40)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox2.TabIndex = 18
        Me.PictureBox2.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.passwordBox)
        Me.GroupBox1.Controls.Add(Me.PictureBox5)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(36, 264)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(10)
        Me.GroupBox1.Size = New System.Drawing.Size(241, 63)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Password"
        '
        'passwordBox
        '
        Me.passwordBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(12, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.passwordBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.passwordBox.Dock = System.Windows.Forms.DockStyle.Left
        Me.passwordBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.passwordBox.ForeColor = System.Drawing.Color.White
        Me.passwordBox.Location = New System.Drawing.Point(10, 25)
        Me.passwordBox.Name = "passwordBox"
        Me.passwordBox.Size = New System.Drawing.Size(187, 22)
        Me.passwordBox.TabIndex = 1
        Me.passwordBox.UseSystemPasswordChar = True
        '
        'PictureBox5
        '
        Me.PictureBox5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox5.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox5.Image = Global.ClientApp.My.Resources.Resources.password
        Me.PictureBox5.Location = New System.Drawing.Point(201, 22)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(30, 30)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox5.TabIndex = 11
        Me.PictureBox5.TabStop = False
        '
        'GroupBox6
        '
        Me.GroupBox6.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.GroupBox6.Controls.Add(Me.usernameBox)
        Me.GroupBox6.Controls.Add(Me.PictureBox3)
        Me.GroupBox6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox6.ForeColor = System.Drawing.Color.White
        Me.GroupBox6.Location = New System.Drawing.Point(36, 195)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Padding = New System.Windows.Forms.Padding(10)
        Me.GroupBox6.Size = New System.Drawing.Size(241, 63)
        Me.GroupBox6.TabIndex = 11
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Username"
        '
        'usernameBox
        '
        Me.usernameBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(12, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.usernameBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.usernameBox.Dock = System.Windows.Forms.DockStyle.Left
        Me.usernameBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.usernameBox.ForeColor = System.Drawing.Color.White
        Me.usernameBox.Location = New System.Drawing.Point(10, 25)
        Me.usernameBox.Name = "usernameBox"
        Me.usernameBox.Size = New System.Drawing.Size(187, 22)
        Me.usernameBox.TabIndex = 1
        '
        'PictureBox3
        '
        Me.PictureBox3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox3.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox3.Image = Global.ClientApp.My.Resources.Resources.user
        Me.PictureBox3.Location = New System.Drawing.Point(201, 22)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(30, 30)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox3.TabIndex = 11
        Me.PictureBox3.TabStop = False
        '
        'LoginForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "LoginForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Private WithEvents Label5 As Label
    Private WithEvents loginBtn As Button
    Private WithEvents Label7 As Label
    Private WithEvents label1 As Label
    Private WithEvents forgotPassword As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents passwordBox As MaskedTextBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents usernameBox As MaskedTextBox
    Friend WithEvents PictureBox3 As PictureBox
End Class
