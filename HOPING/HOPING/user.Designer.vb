<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class user
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(user))
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.AddressTb = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.UserDGV = New Guna.UI.WinForms.GunaDataGridView()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.EditBtn = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.ResetBtn = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.Savebtn = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.PasswordTb = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ContactTb = New System.Windows.Forms.TextBox()
        Me.UnameTb = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Panel2.SuspendLayout()
        CType(Me.UserDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel6.SuspendLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel5.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.MintCream
        Me.Panel2.Controls.Add(Me.AddressTb)
        Me.Panel2.Controls.Add(Me.Label14)
        Me.Panel2.Controls.Add(Me.UserDGV)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.EditBtn)
        Me.Panel2.Controls.Add(Me.ResetBtn)
        Me.Panel2.Controls.Add(Me.Savebtn)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.PasswordTb)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.ContactTb)
        Me.Panel2.Controls.Add(Me.UnameTb)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Location = New System.Drawing.Point(237, 12)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1042, 887)
        Me.Panel2.TabIndex = 3
        '
        'AddressTb
        '
        Me.AddressTb.BackColor = System.Drawing.Color.White
        Me.AddressTb.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.AddressTb.Location = New System.Drawing.Point(502, 158)
        Me.AddressTb.Multiline = True
        Me.AddressTb.Name = "AddressTb"
        Me.AddressTb.Size = New System.Drawing.Size(288, 109)
        Me.AddressTb.TabIndex = 25
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.Label14.ForeColor = System.Drawing.Color.Black
        Me.Label14.Location = New System.Drawing.Point(1018, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(24, 24)
        Me.Label14.TabIndex = 24
        Me.Label14.Text = "X"
        '
        'UserDGV
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.UserDGV.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.UserDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.UserDGV.BackgroundColor = System.Drawing.Color.White
        Me.UserDGV.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.UserDGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.UserDGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkSlateGray
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.UserDGV.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.UserDGV.ColumnHeadersHeight = 29
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.UserDGV.DefaultCellStyle = DataGridViewCellStyle3
        Me.UserDGV.EnableHeadersVisualStyles = False
        Me.UserDGV.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.UserDGV.Location = New System.Drawing.Point(17, 445)
        Me.UserDGV.Name = "UserDGV"
        Me.UserDGV.RowHeadersVisible = False
        Me.UserDGV.RowTemplate.Height = 24
        Me.UserDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.UserDGV.Size = New System.Drawing.Size(1006, 391)
        Me.UserDGV.TabIndex = 23
        Me.UserDGV.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna
        Me.UserDGV.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.UserDGV.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.UserDGV.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.UserDGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.UserDGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.UserDGV.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.UserDGV.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.UserDGV.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.DarkSlateGray
        Me.UserDGV.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.UserDGV.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.UserDGV.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.UserDGV.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.UserDGV.ThemeStyle.HeaderStyle.Height = 29
        Me.UserDGV.ThemeStyle.ReadOnly = False
        Me.UserDGV.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.UserDGV.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.UserDGV.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.UserDGV.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.UserDGV.ThemeStyle.RowsStyle.Height = 24
        Me.UserDGV.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.UserDGV.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!)
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(356, 367)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(249, 39)
        Me.Label7.TabIndex = 19
        Me.Label7.Text = "Customer's List"
        '
        'EditBtn
        '
        Me.EditBtn.ActiveBorderThickness = 1
        Me.EditBtn.ActiveCornerRadius = 20
        Me.EditBtn.ActiveFillColor = System.Drawing.Color.Blue
        Me.EditBtn.ActiveForecolor = System.Drawing.Color.White
        Me.EditBtn.ActiveLineColor = System.Drawing.Color.SeaGreen
        Me.EditBtn.BackColor = System.Drawing.Color.MintCream
        Me.EditBtn.BackgroundImage = CType(resources.GetObject("EditBtn.BackgroundImage"), System.Drawing.Image)
        Me.EditBtn.ButtonText = "Update"
        Me.EditBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.EditBtn.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EditBtn.ForeColor = System.Drawing.Color.SeaGreen
        Me.EditBtn.IdleBorderThickness = 1
        Me.EditBtn.IdleCornerRadius = 20
        Me.EditBtn.IdleFillColor = System.Drawing.Color.White
        Me.EditBtn.IdleForecolor = System.Drawing.Color.Blue
        Me.EditBtn.IdleLineColor = System.Drawing.Color.SeaGreen
        Me.EditBtn.Location = New System.Drawing.Point(427, 292)
        Me.EditBtn.Margin = New System.Windows.Forms.Padding(5)
        Me.EditBtn.Name = "EditBtn"
        Me.EditBtn.Size = New System.Drawing.Size(78, 40)
        Me.EditBtn.TabIndex = 18
        Me.EditBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ResetBtn
        '
        Me.ResetBtn.ActiveBorderThickness = 1
        Me.ResetBtn.ActiveCornerRadius = 20
        Me.ResetBtn.ActiveFillColor = System.Drawing.Color.Blue
        Me.ResetBtn.ActiveForecolor = System.Drawing.Color.White
        Me.ResetBtn.ActiveLineColor = System.Drawing.Color.SeaGreen
        Me.ResetBtn.BackColor = System.Drawing.Color.MintCream
        Me.ResetBtn.BackgroundImage = CType(resources.GetObject("ResetBtn.BackgroundImage"), System.Drawing.Image)
        Me.ResetBtn.ButtonText = "Reset"
        Me.ResetBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ResetBtn.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ResetBtn.ForeColor = System.Drawing.Color.SeaGreen
        Me.ResetBtn.IdleBorderThickness = 1
        Me.ResetBtn.IdleCornerRadius = 20
        Me.ResetBtn.IdleFillColor = System.Drawing.Color.White
        Me.ResetBtn.IdleForecolor = System.Drawing.Color.Blue
        Me.ResetBtn.IdleLineColor = System.Drawing.Color.SeaGreen
        Me.ResetBtn.Location = New System.Drawing.Point(515, 292)
        Me.ResetBtn.Margin = New System.Windows.Forms.Padding(5)
        Me.ResetBtn.Name = "ResetBtn"
        Me.ResetBtn.Size = New System.Drawing.Size(78, 40)
        Me.ResetBtn.TabIndex = 16
        Me.ResetBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Savebtn
        '
        Me.Savebtn.ActiveBorderThickness = 1
        Me.Savebtn.ActiveCornerRadius = 20
        Me.Savebtn.ActiveFillColor = System.Drawing.Color.Blue
        Me.Savebtn.ActiveForecolor = System.Drawing.Color.White
        Me.Savebtn.ActiveLineColor = System.Drawing.Color.SeaGreen
        Me.Savebtn.BackColor = System.Drawing.Color.MintCream
        Me.Savebtn.BackgroundImage = CType(resources.GetObject("Savebtn.BackgroundImage"), System.Drawing.Image)
        Me.Savebtn.ButtonText = "Save"
        Me.Savebtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Savebtn.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Savebtn.ForeColor = System.Drawing.Color.SeaGreen
        Me.Savebtn.IdleBorderThickness = 1
        Me.Savebtn.IdleCornerRadius = 20
        Me.Savebtn.IdleFillColor = System.Drawing.Color.White
        Me.Savebtn.IdleForecolor = System.Drawing.Color.Blue
        Me.Savebtn.IdleLineColor = System.Drawing.Color.SeaGreen
        Me.Savebtn.Location = New System.Drawing.Point(332, 292)
        Me.Savebtn.Margin = New System.Windows.Forms.Padding(5)
        Me.Savebtn.Name = "Savebtn"
        Me.Savebtn.Size = New System.Drawing.Size(78, 40)
        Me.Savebtn.TabIndex = 15
        Me.Savebtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(799, 120)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(92, 24)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Password"
        '
        'PasswordTb
        '
        Me.PasswordTb.BackColor = System.Drawing.Color.White
        Me.PasswordTb.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.PasswordTb.Location = New System.Drawing.Point(800, 158)
        Me.PasswordTb.Multiline = True
        Me.PasswordTb.Name = "PasswordTb"
        Me.PasswordTb.Size = New System.Drawing.Size(152, 34)
        Me.PasswordTb.TabIndex = 11
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(525, 120)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(80, 24)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Address"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(293, 120)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 24)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Contact"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(81, 120)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 24)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Name"
        '
        'ContactTb
        '
        Me.ContactTb.BackColor = System.Drawing.Color.White
        Me.ContactTb.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.ContactTb.Location = New System.Drawing.Point(295, 158)
        Me.ContactTb.Multiline = True
        Me.ContactTb.Name = "ContactTb"
        Me.ContactTb.Size = New System.Drawing.Size(193, 34)
        Me.ContactTb.TabIndex = 4
        '
        'UnameTb
        '
        Me.UnameTb.BackColor = System.Drawing.Color.White
        Me.UnameTb.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.UnameTb.Location = New System.Drawing.Point(85, 158)
        Me.UnameTb.Multiline = True
        Me.UnameTb.Name = "UnameTb"
        Me.UnameTb.Size = New System.Drawing.Size(193, 33)
        Me.UnameTb.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!)
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(292, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(325, 39)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Book Shop Ordering"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.PictureBox5)
        Me.Panel1.Controls.Add(Me.Panel6)
        Me.Panel1.Controls.Add(Me.Panel5)
        Me.Panel1.Controls.Add(Me.Panel4)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Location = New System.Drawing.Point(9, 11)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(229, 888)
        Me.Panel1.TabIndex = 2
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), System.Drawing.Image)
        Me.PictureBox5.Location = New System.Drawing.Point(-1, 1)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(168, 86)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox5.TabIndex = 31
        Me.PictureBox5.TabStop = False
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.White
        Me.Panel6.Controls.Add(Me.PictureBox4)
        Me.Panel6.Controls.Add(Me.Label13)
        Me.Panel6.Location = New System.Drawing.Point(1, 340)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(228, 47)
        Me.Panel6.TabIndex = 29
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(5, 7)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(35, 37)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox4.TabIndex = 28
        Me.PictureBox4.TabStop = False
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(49, 7)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(97, 31)
        Me.Label13.TabIndex = 25
        Me.Label13.Text = "Logout"
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.White
        Me.Panel5.Controls.Add(Me.PictureBox2)
        Me.Panel5.Controls.Add(Me.Label12)
        Me.Panel5.Location = New System.Drawing.Point(0, 286)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(228, 47)
        Me.Panel5.TabIndex = 28
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(6, 7)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(35, 37)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 27
        Me.PictureBox2.TabStop = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(48, 7)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(147, 31)
        Me.Label12.TabIndex = 25
        Me.Label12.Text = "Dashboard"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.White
        Me.Panel4.Controls.Add(Me.PictureBox3)
        Me.Panel4.Controls.Add(Me.Label11)
        Me.Panel4.Location = New System.Drawing.Point(1, 174)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(228, 47)
        Me.Panel4.TabIndex = 27
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(6, 7)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(35, 37)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 28
        Me.PictureBox3.TabStop = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(51, 7)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(76, 31)
        Me.Label11.TabIndex = 25
        Me.Label11.Text = "Book"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Aqua
        Me.Panel3.Controls.Add(Me.PictureBox1)
        Me.Panel3.Controls.Add(Me.Label10)
        Me.Panel3.Location = New System.Drawing.Point(-1, 230)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(228, 47)
        Me.Panel3.TabIndex = 26
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(7, 5)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(35, 37)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 26
        Me.PictureBox1.TabStop = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(49, 7)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(72, 31)
        Me.Label10.TabIndex = 25
        Me.Label10.Text = "User"
        '
        'user
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkSlateGray
        Me.ClientSize = New System.Drawing.Size(1289, 911)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "user"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "user"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.UserDGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label14 As Label
    Friend WithEvents UserDGV As Guna.UI.WinForms.GunaDataGridView
    Friend WithEvents Label7 As Label
    Friend WithEvents EditBtn As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents ResetBtn As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents Savebtn As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents Label5 As Label
    Friend WithEvents PasswordTb As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents ContactTb As TextBox
    Friend WithEvents UnameTb As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Label13 As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Label12 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label11 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label10 As Label
    Friend WithEvents AddressTb As TextBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
End Class
