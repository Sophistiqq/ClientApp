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
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.chatBtn = New System.Windows.Forms.Label()
        Me.settingsBtn = New System.Windows.Forms.Label()
        Me.fileshareBtn = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
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
        Me.everyone = New System.Windows.Forms.RadioButton()
        Me.chatPanel = New System.Windows.Forms.TableLayoutPanel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.filesharePanel.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.chatBtn)
        Me.Panel1.Controls.Add(Me.settingsBtn)
        Me.Panel1.Controls.Add(Me.fileshareBtn)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(87, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.Panel1.Location = New System.Drawing.Point(26, 53)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(200, 377)
        Me.Panel1.TabIndex = 0
        '
        'chatBtn
        '
        Me.chatBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chatBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.chatBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chatBtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.chatBtn.Location = New System.Drawing.Point(-1, 197)
        Me.chatBtn.Name = "chatBtn"
        Me.chatBtn.Size = New System.Drawing.Size(200, 44)
        Me.chatBtn.TabIndex = 4
        Me.chatBtn.Text = "Chat"
        Me.chatBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'settingsBtn
        '
        Me.settingsBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.settingsBtn.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.settingsBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.settingsBtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.settingsBtn.Location = New System.Drawing.Point(0, 339)
        Me.settingsBtn.Name = "settingsBtn"
        Me.settingsBtn.Size = New System.Drawing.Size(198, 36)
        Me.settingsBtn.TabIndex = 3
        Me.settingsBtn.Text = "Settings"
        Me.settingsBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'fileshareBtn
        '
        Me.fileshareBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.fileshareBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(87, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.fileshareBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.fileshareBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fileshareBtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.fileshareBtn.Location = New System.Drawing.Point(-1, 135)
        Me.fileshareBtn.Name = "fileshareBtn"
        Me.fileshareBtn.Size = New System.Drawing.Size(200, 44)
        Me.fileshareBtn.TabIndex = 2
        Me.fileshareBtn.Text = "File Share"
        Me.fileshareBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(27, 28)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 31)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Main"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(87, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(93, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 31)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Menu"
        '
        'filesharePanel
        '
        Me.filesharePanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.filesharePanel.ColumnCount = 2
        Me.filesharePanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.filesharePanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 187.0!))
        Me.filesharePanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.filesharePanel.Controls.Add(Me.DataGridView1, 1, 2)
        Me.filesharePanel.Controls.Add(Me.fileTextBox, 1, 0)
        Me.filesharePanel.Controls.Add(Me.selectfileBtn, 0, 0)
        Me.filesharePanel.Controls.Add(Me.Label4, 1, 1)
        Me.filesharePanel.Controls.Add(Me.Label5, 0, 1)
        Me.filesharePanel.Controls.Add(Me.Panel2, 0, 2)
        Me.filesharePanel.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize
        Me.filesharePanel.Location = New System.Drawing.Point(232, 53)
        Me.filesharePanel.Name = "filesharePanel"
        Me.filesharePanel.Padding = New System.Windows.Forms.Padding(5)
        Me.filesharePanel.RowCount = 3
        Me.filesharePanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.67538!))
        Me.filesharePanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.150327!))
        Me.filesharePanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80.17429!))
        Me.filesharePanel.Size = New System.Drawing.Size(397, 469)
        Me.filesharePanel.TabIndex = 1
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer))
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(19, Byte), Integer), CType(CType(6, Byte), Integer))
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(244, Byte), Integer))
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle9
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(19, Byte), Integer), CType(CType(6, Byte), Integer))
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(244, Byte), Integer))
        DataGridViewCellStyle10.Padding = New System.Windows.Forms.Padding(5)
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle10
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Enabled = False
        Me.DataGridView1.GridColor = System.Drawing.Color.Black
        Me.DataGridView1.Location = New System.Drawing.Point(208, 98)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(19, Byte), Integer), CType(CType(6, Byte), Integer))
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(244, Byte), Integer))
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle11
        Me.DataGridView1.RowHeadersVisible = False
        DataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(19, Byte), Integer), CType(CType(6, Byte), Integer))
        DataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(244, Byte), Integer))
        DataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(210, Byte), Integer))
        DataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.DataGridView1.RowsDefaultCellStyle = DataGridViewCellStyle12
        Me.DataGridView1.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DataGridView1.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(19, Byte), Integer), CType(CType(6, Byte), Integer))
        Me.DataGridView1.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGridView1.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.DataGridView1.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.DataGridView1.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.DataGridView1.RowTemplate.Height = 28
        Me.DataGridView1.Size = New System.Drawing.Size(181, 363)
        Me.DataGridView1.TabIndex = 3
        '
        'fileTextBox
        '
        Me.fileTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.fileTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.fileTextBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.fileTextBox.Enabled = False
        Me.fileTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fileTextBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.fileTextBox.Location = New System.Drawing.Point(208, 8)
        Me.fileTextBox.Multiline = True
        Me.fileTextBox.Name = "fileTextBox"
        Me.fileTextBox.ReadOnly = True
        Me.fileTextBox.Size = New System.Drawing.Size(181, 42)
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
        Me.selectfileBtn.Location = New System.Drawing.Point(8, 18)
        Me.selectfileBtn.Name = "selectfileBtn"
        Me.selectfileBtn.Size = New System.Drawing.Size(194, 22)
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
        Me.Label4.Location = New System.Drawing.Point(208, 73)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(181, 22)
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
        Me.Label5.Location = New System.Drawing.Point(8, 73)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(194, 22)
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
        Me.Panel2.Controls.Add(Me.everyone)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(8, 98)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(194, 363)
        Me.Panel2.TabIndex = 7
        '
        'clearBtn
        '
        Me.clearBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.clearBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.clearBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.clearBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clearBtn.Location = New System.Drawing.Point(0, 263)
        Me.clearBtn.Name = "clearBtn"
        Me.clearBtn.Size = New System.Drawing.Size(191, 36)
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
        Me.sendBtn.Location = New System.Drawing.Point(0, 210)
        Me.sendBtn.Name = "sendBtn"
        Me.sendBtn.Size = New System.Drawing.Size(191, 36)
        Me.sendBtn.TabIndex = 3
        Me.sendBtn.Text = "Send"
        Me.sendBtn.UseVisualStyleBackColor = False
        '
        'storage
        '
        Me.storage.AutoSize = True
        Me.storage.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.storage.Location = New System.Drawing.Point(14, 119)
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
        Me.selected.Location = New System.Drawing.Point(14, 77)
        Me.selected.Name = "selected"
        Me.selected.Padding = New System.Windows.Forms.Padding(15, 0, 0, 0)
        Me.selected.Size = New System.Drawing.Size(137, 24)
        Me.selected.TabIndex = 1
        Me.selected.TabStop = True
        Me.selected.Text = "Selected only"
        Me.selected.UseVisualStyleBackColor = True
        '
        'everyone
        '
        Me.everyone.AutoSize = True
        Me.everyone.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.everyone.Location = New System.Drawing.Point(14, 35)
        Me.everyone.Name = "everyone"
        Me.everyone.Padding = New System.Windows.Forms.Padding(15, 0, 0, 0)
        Me.everyone.Size = New System.Drawing.Size(108, 24)
        Me.everyone.TabIndex = 0
        Me.everyone.TabStop = True
        Me.everyone.Text = "Everyone"
        Me.everyone.UseVisualStyleBackColor = True
        '
        'chatPanel
        '
        Me.chatPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.chatPanel.ColumnCount = 1
        Me.chatPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.chatPanel.Location = New System.Drawing.Point(635, 99)
        Me.chatPanel.Name = "chatPanel"
        Me.chatPanel.RowCount = 1
        Me.chatPanel.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.chatPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 351.0!))
        Me.chatPanel.Size = New System.Drawing.Size(184, 351)
        Me.chatPanel.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(635, 57)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(106, 39)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Chats"
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(19, Byte), Integer), CType(CType(6, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(848, 534)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.chatPanel)
        Me.Controls.Add(Me.filesharePanel)
        Me.Controls.Add(Me.Panel1)
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.Name = "Main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Main"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.filesharePanel.ResumeLayout(False)
        Me.filesharePanel.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
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
    Friend WithEvents everyone As RadioButton
    Friend WithEvents clearBtn As Button
End Class
