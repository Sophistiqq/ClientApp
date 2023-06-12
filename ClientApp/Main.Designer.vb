<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Main
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.displayName = New System.Windows.Forms.Label()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.chatBtn = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.fileshareBtn = New System.Windows.Forms.Label()
        Me.settingsBtn = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.filesharePanel = New System.Windows.Forms.TableLayoutPanel()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.fileTextBox = New System.Windows.Forms.TextBox()
        Me.selectfileBtn = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.clearBtn = New System.Windows.Forms.Button()
        Me.sendBtn = New System.Windows.Forms.Button()
        Me.storage = New System.Windows.Forms.RadioButton()
        Me.selected = New System.Windows.Forms.RadioButton()
        Me.chatPanel = New System.Windows.Forms.TableLayoutPanel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.downloadBtn = New System.Windows.Forms.Button()
        Me.filesReceived = New System.Windows.Forms.DataGridView()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.filesharePanel.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.chatPanel.SuspendLayout()
        CType(Me.filesReceived, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.displayName)
        Me.Panel1.Controls.Add(Me.PictureBox4)
        Me.Panel1.Controls.Add(Me.TextBox2)
        Me.Panel1.Controls.Add(Me.TextBox1)
        Me.Panel1.Controls.Add(Me.PictureBox3)
        Me.Panel1.Controls.Add(Me.Panel4)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.settingsBtn)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.Panel1.Location = New System.Drawing.Point(26, 53)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(244, 377)
        Me.Panel1.TabIndex = 0
        '
        'displayName
        '
        Me.displayName.AutoSize = True
        Me.displayName.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.displayName.Location = New System.Drawing.Point(102, 54)
        Me.displayName.Name = "displayName"
        Me.displayName.Size = New System.Drawing.Size(57, 22)
        Me.displayName.TabIndex = 14
        Me.displayName.Text = "Name"
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = Global.ClientApp.My.Resources.Resources.avatar
        Me.PictureBox4.Location = New System.Drawing.Point(39, 40)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(50, 50)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 13
        Me.PictureBox4.TabStop = False
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.TextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox2.Enabled = False
        Me.TextBox2.Location = New System.Drawing.Point(131, 137)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ReadOnly = True
        Me.TextBox2.Size = New System.Drawing.Size(100, 5)
        Me.TextBox2.TabIndex = 12
        Me.TextBox2.TabStop = False
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.Enabled = False
        Me.TextBox1.Location = New System.Drawing.Point(16, 41)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(5, 300)
        Me.TextBox1.TabIndex = 11
        Me.TextBox1.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.ClientApp.My.Resources.Resources.settings
        Me.PictureBox3.Location = New System.Drawing.Point(48, 320)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(40, 40)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox3.TabIndex = 7
        Me.PictureBox3.TabStop = False
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.PictureBox2)
        Me.Panel4.Controls.Add(Me.chatBtn)
        Me.Panel4.Location = New System.Drawing.Point(42, 249)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Padding = New System.Windows.Forms.Padding(3)
        Me.Panel4.Size = New System.Drawing.Size(200, 44)
        Me.Panel4.TabIndex = 6
        '
        'PictureBox2
        '
        Me.PictureBox2.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox2.Image = Global.ClientApp.My.Resources.Resources.chat_fixed
        Me.PictureBox2.Location = New System.Drawing.Point(3, 3)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(44, 38)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox2.TabIndex = 3
        Me.PictureBox2.TabStop = False
        '
        'chatBtn
        '
        Me.chatBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.chatBtn.Dock = System.Windows.Forms.DockStyle.Right
        Me.chatBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chatBtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.chatBtn.Location = New System.Drawing.Point(48, 3)
        Me.chatBtn.Name = "chatBtn"
        Me.chatBtn.Size = New System.Drawing.Size(149, 38)
        Me.chatBtn.TabIndex = 4
        Me.chatBtn.Text = "Chat"
        Me.chatBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.Panel3.Controls.Add(Me.PictureBox1)
        Me.Panel3.Controls.Add(Me.fileshareBtn)
        Me.Panel3.Location = New System.Drawing.Point(39, 175)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Padding = New System.Windows.Forms.Padding(3)
        Me.Panel3.Size = New System.Drawing.Size(200, 44)
        Me.Panel3.TabIndex = 5
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox1.Image = Global.ClientApp.My.Resources.Resources.file_share
        Me.PictureBox1.Location = New System.Drawing.Point(3, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(44, 38)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'fileshareBtn
        '
        Me.fileshareBtn.BackColor = System.Drawing.Color.Transparent
        Me.fileshareBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.fileshareBtn.Dock = System.Windows.Forms.DockStyle.Right
        Me.fileshareBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fileshareBtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.fileshareBtn.Location = New System.Drawing.Point(47, 3)
        Me.fileshareBtn.Name = "fileshareBtn"
        Me.fileshareBtn.Size = New System.Drawing.Size(150, 38)
        Me.fileshareBtn.TabIndex = 2
        Me.fileshareBtn.Text = "File Share"
        Me.fileshareBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'settingsBtn
        '
        Me.settingsBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.settingsBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.settingsBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.settingsBtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.settingsBtn.Location = New System.Drawing.Point(90, 320)
        Me.settingsBtn.Name = "settingsBtn"
        Me.settingsBtn.Size = New System.Drawing.Size(152, 43)
        Me.settingsBtn.TabIndex = 3
        Me.settingsBtn.Text = "Settings"
        Me.settingsBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(35, 122)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 31)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Menu"
        '
        'filesharePanel
        '
        Me.filesharePanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.filesharePanel.ColumnCount = 2
        Me.filesharePanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.filesharePanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 208.0!))
        Me.filesharePanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.filesharePanel.Controls.Add(Me.DataGridView1, 1, 2)
        Me.filesharePanel.Controls.Add(Me.fileTextBox, 1, 0)
        Me.filesharePanel.Controls.Add(Me.selectfileBtn, 0, 0)
        Me.filesharePanel.Controls.Add(Me.Label4, 1, 1)
        Me.filesharePanel.Controls.Add(Me.Label5, 0, 1)
        Me.filesharePanel.Controls.Add(Me.Panel2, 0, 2)
        Me.filesharePanel.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize
        Me.filesharePanel.Location = New System.Drawing.Point(285, 40)
        Me.filesharePanel.Name = "filesharePanel"
        Me.filesharePanel.Padding = New System.Windows.Forms.Padding(5)
        Me.filesharePanel.RowCount = 3
        Me.filesharePanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.137055!))
        Me.filesharePanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.15228!))
        Me.filesharePanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80.17429!))
        Me.filesharePanel.Size = New System.Drawing.Size(397, 404)
        Me.filesharePanel.TabIndex = 1
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToResizeRows = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(41, Byte), Integer))
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(19, Byte), Integer), CType(CType(6, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(244, Byte), Integer))
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(19, Byte), Integer), CType(CType(6, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(244, Byte), Integer))
        DataGridViewCellStyle2.Padding = New System.Windows.Forms.Padding(5)
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(69, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(41, Byte), Integer))
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Enabled = False
        Me.DataGridView1.GridColor = System.Drawing.Color.Black
        Me.DataGridView1.Location = New System.Drawing.Point(187, 84)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(19, Byte), Integer), CType(CType(6, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(244, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridView1.RowHeadersVisible = False
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(19, Byte), Integer), CType(CType(6, Byte), Integer))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(244, Byte), Integer))
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(69, Byte), Integer))
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(11, Byte), Integer), CType(CType(22, Byte), Integer))
        Me.DataGridView1.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridView1.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DataGridView1.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(19, Byte), Integer), CType(CType(6, Byte), Integer))
        Me.DataGridView1.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.DataGridView1.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.DataGridView1.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.DataGridView1.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(11, Byte), Integer), CType(CType(22, Byte), Integer))
        Me.DataGridView1.RowTemplate.Height = 28
        Me.DataGridView1.Size = New System.Drawing.Size(202, 312)
        Me.DataGridView1.TabIndex = 3
        '
        'fileTextBox
        '
        Me.fileTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.fileTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.fileTextBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.fileTextBox.Enabled = False
        Me.fileTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fileTextBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.fileTextBox.Location = New System.Drawing.Point(187, 8)
        Me.fileTextBox.Multiline = True
        Me.fileTextBox.Name = "fileTextBox"
        Me.fileTextBox.ReadOnly = True
        Me.fileTextBox.Size = New System.Drawing.Size(202, 30)
        Me.fileTextBox.TabIndex = 2
        Me.fileTextBox.TabStop = False
        Me.fileTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'selectfileBtn
        '
        Me.selectfileBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.selectfileBtn.AutoSize = True
        Me.selectfileBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.selectfileBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.selectfileBtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.selectfileBtn.Location = New System.Drawing.Point(8, 12)
        Me.selectfileBtn.Name = "selectfileBtn"
        Me.selectfileBtn.Size = New System.Drawing.Size(173, 22)
        Me.selectfileBtn.TabIndex = 1
        Me.selectfileBtn.Text = "Select a file"
        Me.selectfileBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(187, 59)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(202, 22)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Employee List"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'Label5
        '
        Me.Label5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(8, 59)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(173, 22)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Send to"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.clearBtn)
        Me.Panel2.Controls.Add(Me.sendBtn)
        Me.Panel2.Controls.Add(Me.storage)
        Me.Panel2.Controls.Add(Me.selected)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.Panel2.Location = New System.Drawing.Point(8, 84)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(173, 312)
        Me.Panel2.TabIndex = 7
        '
        'clearBtn
        '
        Me.clearBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.clearBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.clearBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.clearBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clearBtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.clearBtn.Location = New System.Drawing.Point(0, 213)
        Me.clearBtn.Name = "clearBtn"
        Me.clearBtn.Size = New System.Drawing.Size(176, 36)
        Me.clearBtn.TabIndex = 4
        Me.clearBtn.Text = "Clear Selection"
        Me.clearBtn.UseVisualStyleBackColor = False
        '
        'sendBtn
        '
        Me.sendBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.sendBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.sendBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.sendBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sendBtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.sendBtn.Location = New System.Drawing.Point(0, 160)
        Me.sendBtn.Name = "sendBtn"
        Me.sendBtn.Size = New System.Drawing.Size(173, 36)
        Me.sendBtn.TabIndex = 3
        Me.sendBtn.Text = "Send"
        Me.sendBtn.UseVisualStyleBackColor = False
        '
        'storage
        '
        Me.storage.AutoSize = True
        Me.storage.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.storage.ForeColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.storage.Location = New System.Drawing.Point(23, 64)
        Me.storage.Name = "storage"
        Me.storage.Padding = New System.Windows.Forms.Padding(15, 0, 0, 0)
        Me.storage.Size = New System.Drawing.Size(99, 24)
        Me.storage.TabIndex = 2
        Me.storage.TabStop = True
        Me.storage.Text = "Storage"
        Me.storage.UseVisualStyleBackColor = True
        '
        'selected
        '
        Me.selected.AutoSize = True
        Me.selected.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.selected.ForeColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.selected.Location = New System.Drawing.Point(23, 22)
        Me.selected.Name = "selected"
        Me.selected.Padding = New System.Windows.Forms.Padding(15, 0, 0, 0)
        Me.selected.Size = New System.Drawing.Size(137, 24)
        Me.selected.TabIndex = 1
        Me.selected.TabStop = True
        Me.selected.Text = "Selected only"
        Me.selected.UseVisualStyleBackColor = True
        '
        'chatPanel
        '
        Me.chatPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.chatPanel.ColumnCount = 1
        Me.chatPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.chatPanel.Controls.Add(Me.filesReceived, 0, 0)
        Me.chatPanel.Location = New System.Drawing.Point(695, 93)
        Me.chatPanel.Name = "chatPanel"
        Me.chatPanel.RowCount = 1
        Me.chatPanel.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.chatPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 318.0!))
        Me.chatPanel.Size = New System.Drawing.Size(262, 203)
        Me.chatPanel.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!)
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(688, 48)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(116, 22)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Storage FIles"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(874, 21)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(80, 29)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Refresh"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'downloadBtn
        '
        Me.downloadBtn.BackColor = System.Drawing.Color.Transparent
        Me.downloadBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.downloadBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.downloadBtn.ForeColor = System.Drawing.Color.White
        Me.downloadBtn.Location = New System.Drawing.Point(874, 61)
        Me.downloadBtn.Name = "downloadBtn"
        Me.downloadBtn.Size = New System.Drawing.Size(80, 29)
        Me.downloadBtn.TabIndex = 5
        Me.downloadBtn.Text = "Download"
        Me.downloadBtn.UseVisualStyleBackColor = False
        '
        'filesReceived
        '
        Me.filesReceived.AllowUserToAddRows = False
        Me.filesReceived.AllowUserToDeleteRows = False
        Me.filesReceived.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.filesReceived.Dock = System.Windows.Forms.DockStyle.Fill
        Me.filesReceived.Location = New System.Drawing.Point(3, 3)
        Me.filesReceived.Name = "filesReceived"
        Me.filesReceived.ReadOnly = True
        Me.filesReceived.Size = New System.Drawing.Size(256, 197)
        Me.filesReceived.TabIndex = 0
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(11, Byte), Integer), CType(CType(22, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(976, 534)
        Me.ControlBox = False
        Me.Controls.Add(Me.downloadBtn)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.chatPanel)
        Me.Controls.Add(Me.filesharePanel)
        Me.Controls.Add(Me.Panel1)
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.Name = "Main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.filesharePanel.ResumeLayout(False)
        Me.filesharePanel.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.chatPanel.ResumeLayout(False)
        CType(Me.filesReceived, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents chatBtn As Label
    Friend WithEvents settingsBtn As Label
    Friend WithEvents fileshareBtn As Label
    Friend WithEvents filesharePanel As TableLayoutPanel
    Friend WithEvents chatPanel As TableLayoutPanel
    Friend WithEvents Label3 As Label
    Friend WithEvents selectfileBtn As Label
    Friend WithEvents fileTextBox As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents sendBtn As Button
    Friend WithEvents storage As RadioButton
    Friend WithEvents selected As RadioButton
    Friend WithEvents clearBtn As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel4 As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents displayName As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents downloadBtn As Button
    Friend WithEvents filesReceived As DataGridView
End Class
