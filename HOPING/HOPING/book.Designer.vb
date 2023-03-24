<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class book
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(book))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Users = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Year = New System.Windows.Forms.Panel()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.BookDGV = New Guna.UI.WinForms.GunaDataGridView()
        Me.RefreshBtn = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.FilterCb = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.EditBtn = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.ResetBtn = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.SaveBtn = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.PriceTb = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.QtyTb = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.CatCb = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.AuthorTb = New System.Windows.Forms.TextBox()
        Me.BooksNameTb = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel6.SuspendLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel5.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Year.SuspendLayout()
        CType(Me.BookDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.PictureBox5)
        Me.Panel1.Controls.Add(Me.Panel6)
        Me.Panel1.Controls.Add(Me.Panel5)
        Me.Panel1.Controls.Add(Me.Panel4)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Location = New System.Drawing.Point(7, 10)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(229, 888)
        Me.Panel1.TabIndex = 0
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), System.Drawing.Image)
        Me.PictureBox5.Location = New System.Drawing.Point(0, 3)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(168, 86)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox5.TabIndex = 30
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
        Me.PictureBox4.Location = New System.Drawing.Point(5, 5)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(35, 37)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox4.TabIndex = 30
        Me.PictureBox4.TabStop = False
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(47, 7)
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
        Me.PictureBox2.Location = New System.Drawing.Point(4, 7)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(35, 37)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 30
        Me.PictureBox2.TabStop = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(47, 7)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(147, 31)
        Me.Label12.TabIndex = 25
        Me.Label12.Text = "Dashboard"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.White
        Me.Panel4.Controls.Add(Me.PictureBox1)
        Me.Panel4.Controls.Add(Me.Users)
        Me.Panel4.Location = New System.Drawing.Point(0, 232)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(228, 47)
        Me.Panel4.TabIndex = 27
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(6, 6)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(35, 37)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 27
        Me.PictureBox1.TabStop = False
        '
        'Users
        '
        Me.Users.AutoSize = True
        Me.Users.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.Users.ForeColor = System.Drawing.Color.Black
        Me.Users.Location = New System.Drawing.Point(47, 7)
        Me.Users.Name = "Users"
        Me.Users.Size = New System.Drawing.Size(72, 31)
        Me.Users.TabIndex = 25
        Me.Users.Text = "User"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Aqua
        Me.Panel3.Controls.Add(Me.PictureBox3)
        Me.Panel3.Controls.Add(Me.Label10)
        Me.Panel3.Location = New System.Drawing.Point(0, 178)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(228, 47)
        Me.Panel3.TabIndex = 26
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(4, 4)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(35, 37)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 29
        Me.PictureBox3.TabStop = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(47, 7)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(90, 31)
        Me.Label10.TabIndex = 25
        Me.Label10.Text = "Books"
        '
        'Year
        '
        Me.Year.BackColor = System.Drawing.Color.MintCream
        Me.Year.Controls.Add(Me.Label14)
        Me.Year.Controls.Add(Me.BookDGV)
        Me.Year.Controls.Add(Me.RefreshBtn)
        Me.Year.Controls.Add(Me.FilterCb)
        Me.Year.Controls.Add(Me.Label7)
        Me.Year.Controls.Add(Me.EditBtn)
        Me.Year.Controls.Add(Me.ResetBtn)
        Me.Year.Controls.Add(Me.SaveBtn)
        Me.Year.Controls.Add(Me.Label6)
        Me.Year.Controls.Add(Me.PriceTb)
        Me.Year.Controls.Add(Me.Label5)
        Me.Year.Controls.Add(Me.QtyTb)
        Me.Year.Controls.Add(Me.Label4)
        Me.Year.Controls.Add(Me.CatCb)
        Me.Year.Controls.Add(Me.Label3)
        Me.Year.Controls.Add(Me.Label2)
        Me.Year.Controls.Add(Me.AuthorTb)
        Me.Year.Controls.Add(Me.BooksNameTb)
        Me.Year.Controls.Add(Me.Label1)
        Me.Year.Location = New System.Drawing.Point(234, 11)
        Me.Year.Name = "Year"
        Me.Year.Size = New System.Drawing.Size(1042, 887)
        Me.Year.TabIndex = 1
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.Label14.ForeColor = System.Drawing.Color.Black
        Me.Label14.Location = New System.Drawing.Point(1018, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(24, 24)
        Me.Label14.TabIndex = 25
        Me.Label14.Text = "X"
        '
        'BookDGV
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.BookDGV.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.BookDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.BookDGV.BackgroundColor = System.Drawing.Color.White
        Me.BookDGV.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.BookDGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.BookDGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkSlateGray
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.BookDGV.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.BookDGV.ColumnHeadersHeight = 29
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.BookDGV.DefaultCellStyle = DataGridViewCellStyle3
        Me.BookDGV.EnableHeadersVisualStyles = False
        Me.BookDGV.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BookDGV.Location = New System.Drawing.Point(11, 475)
        Me.BookDGV.Name = "BookDGV"
        Me.BookDGV.RowHeadersVisible = False
        Me.BookDGV.RowTemplate.Height = 24
        Me.BookDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.BookDGV.Size = New System.Drawing.Size(1006, 353)
        Me.BookDGV.TabIndex = 24
        Me.BookDGV.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna
        Me.BookDGV.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.BookDGV.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.BookDGV.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.BookDGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.BookDGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.BookDGV.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.BookDGV.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BookDGV.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.DarkSlateGray
        Me.BookDGV.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.BookDGV.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.BookDGV.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.BookDGV.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.BookDGV.ThemeStyle.HeaderStyle.Height = 29
        Me.BookDGV.ThemeStyle.ReadOnly = False
        Me.BookDGV.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.BookDGV.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.BookDGV.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.BookDGV.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.BookDGV.ThemeStyle.RowsStyle.Height = 24
        Me.BookDGV.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BookDGV.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'RefreshBtn
        '
        Me.RefreshBtn.ActiveBorderThickness = 1
        Me.RefreshBtn.ActiveCornerRadius = 20
        Me.RefreshBtn.ActiveFillColor = System.Drawing.Color.Blue
        Me.RefreshBtn.ActiveForecolor = System.Drawing.Color.White
        Me.RefreshBtn.ActiveLineColor = System.Drawing.Color.SeaGreen
        Me.RefreshBtn.BackColor = System.Drawing.Color.MintCream
        Me.RefreshBtn.BackgroundImage = CType(resources.GetObject("RefreshBtn.BackgroundImage"), System.Drawing.Image)
        Me.RefreshBtn.ButtonText = "Refresh"
        Me.RefreshBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.RefreshBtn.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RefreshBtn.ForeColor = System.Drawing.Color.SeaGreen
        Me.RefreshBtn.IdleBorderThickness = 1
        Me.RefreshBtn.IdleCornerRadius = 20
        Me.RefreshBtn.IdleFillColor = System.Drawing.Color.White
        Me.RefreshBtn.IdleForecolor = System.Drawing.Color.Blue
        Me.RefreshBtn.IdleLineColor = System.Drawing.Color.SeaGreen
        Me.RefreshBtn.Location = New System.Drawing.Point(579, 398)
        Me.RefreshBtn.Margin = New System.Windows.Forms.Padding(5)
        Me.RefreshBtn.Name = "RefreshBtn"
        Me.RefreshBtn.Size = New System.Drawing.Size(78, 40)
        Me.RefreshBtn.TabIndex = 22
        Me.RefreshBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FilterCb
        '
        Me.FilterCb.BackColor = System.Drawing.Color.White
        Me.FilterCb.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FilterCb.FormattingEnabled = True
        Me.FilterCb.Items.AddRange(New Object() {"Non Fiction", "Novel", "History", "Dystopian", "Mystery", "Historical Fiction", "Romance", "Contemporary Fiction", "Literary Fiction", "Memoir", "Science", "Programming", "Mathematics", "Christian Literature"})
        Me.FilterCb.Location = New System.Drawing.Point(380, 403)
        Me.FilterCb.Name = "FilterCb"
        Me.FilterCb.Size = New System.Drawing.Size(191, 33)
        Me.FilterCb.TabIndex = 20
        Me.FilterCb.Text = "Filter by Genre"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(373, 338)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(284, 38)
        Me.Label7.TabIndex = 19
        Me.Label7.Text = "Order (Book) List"
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
        Me.EditBtn.Location = New System.Drawing.Point(481, 230)
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
        Me.ResetBtn.Location = New System.Drawing.Point(569, 229)
        Me.ResetBtn.Margin = New System.Windows.Forms.Padding(5)
        Me.ResetBtn.Name = "ResetBtn"
        Me.ResetBtn.Size = New System.Drawing.Size(78, 40)
        Me.ResetBtn.TabIndex = 16
        Me.ResetBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'SaveBtn
        '
        Me.SaveBtn.ActiveBorderThickness = 1
        Me.SaveBtn.ActiveCornerRadius = 20
        Me.SaveBtn.ActiveFillColor = System.Drawing.Color.Blue
        Me.SaveBtn.ActiveForecolor = System.Drawing.Color.White
        Me.SaveBtn.ActiveLineColor = System.Drawing.Color.SeaGreen
        Me.SaveBtn.BackColor = System.Drawing.Color.MintCream
        Me.SaveBtn.BackgroundImage = CType(resources.GetObject("SaveBtn.BackgroundImage"), System.Drawing.Image)
        Me.SaveBtn.ButtonText = "Save"
        Me.SaveBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.SaveBtn.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SaveBtn.ForeColor = System.Drawing.Color.SeaGreen
        Me.SaveBtn.IdleBorderThickness = 1
        Me.SaveBtn.IdleCornerRadius = 20
        Me.SaveBtn.IdleFillColor = System.Drawing.Color.White
        Me.SaveBtn.IdleForecolor = System.Drawing.Color.Blue
        Me.SaveBtn.IdleLineColor = System.Drawing.Color.SeaGreen
        Me.SaveBtn.Location = New System.Drawing.Point(386, 230)
        Me.SaveBtn.Margin = New System.Windows.Forms.Padding(5)
        Me.SaveBtn.Name = "SaveBtn"
        Me.SaveBtn.Size = New System.Drawing.Size(78, 40)
        Me.SaveBtn.TabIndex = 15
        Me.SaveBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(861, 117)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(53, 24)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Price"
        '
        'PriceTb
        '
        Me.PriceTb.BackColor = System.Drawing.Color.White
        Me.PriceTb.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!)
        Me.PriceTb.Location = New System.Drawing.Point(863, 155)
        Me.PriceTb.Multiline = True
        Me.PriceTb.Name = "PriceTb"
        Me.PriceTb.Size = New System.Drawing.Size(154, 27)
        Me.PriceTb.TabIndex = 13
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(715, 117)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(78, 24)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Quantity"
        '
        'QtyTb
        '
        Me.QtyTb.BackColor = System.Drawing.Color.White
        Me.QtyTb.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!)
        Me.QtyTb.Location = New System.Drawing.Point(719, 155)
        Me.QtyTb.Multiline = True
        Me.QtyTb.Name = "QtyTb"
        Me.QtyTb.Size = New System.Drawing.Size(135, 27)
        Me.QtyTb.TabIndex = 11
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(518, 117)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 24)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Genre"
        '
        'CatCb
        '
        Me.CatCb.BackColor = System.Drawing.Color.White
        Me.CatCb.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!)
        Me.CatCb.FormattingEnabled = True
        Me.CatCb.Items.AddRange(New Object() {"Non Fiction", "Novel", "History", "Dystopian", "Mystery", "Historical Fiction", "Romance", "Contemporary Fiction", "Literary Fiction", "Memoir", "Science", "Programming", "Mathematics", "Christian Literature"})
        Me.CatCb.Location = New System.Drawing.Point(516, 155)
        Me.CatCb.Name = "CatCb"
        Me.CatCb.Size = New System.Drawing.Size(185, 28)
        Me.CatCb.TabIndex = 9
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(269, 117)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 24)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Author"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(12, 117)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(93, 24)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Book Title"
        '
        'AuthorTb
        '
        Me.AuthorTb.BackColor = System.Drawing.Color.White
        Me.AuthorTb.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!)
        Me.AuthorTb.Location = New System.Drawing.Point(267, 155)
        Me.AuthorTb.Multiline = True
        Me.AuthorTb.Name = "AuthorTb"
        Me.AuthorTb.Size = New System.Drawing.Size(240, 28)
        Me.AuthorTb.TabIndex = 4
        '
        'BooksNameTb
        '
        Me.BooksNameTb.BackColor = System.Drawing.Color.White
        Me.BooksNameTb.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!)
        Me.BooksNameTb.Location = New System.Drawing.Point(11, 155)
        Me.BooksNameTb.Multiline = True
        Me.BooksNameTb.Name = "BooksNameTb"
        Me.BooksNameTb.Size = New System.Drawing.Size(250, 28)
        Me.BooksNameTb.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(311, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(361, 40)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Book Shop Ordering"
        '
        'book
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkSlateGray
        Me.ClientSize = New System.Drawing.Size(1289, 911)
        Me.Controls.Add(Me.Year)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "book"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "user"
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
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Year.ResumeLayout(False)
        Me.Year.PerformLayout()
        CType(Me.BookDGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Year As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents BooksNameTb As TextBox
    Friend WithEvents AuthorTb As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents PriceTb As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents QtyTb As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents CatCb As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents SaveBtn As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Label13 As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Label12 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Users As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label10 As Label
    Friend WithEvents RefreshBtn As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents FilterCb As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents EditBtn As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents ResetBtn As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents BookDGV As Guna.UI.WinForms.GunaDataGridView
    Friend WithEvents Label14 As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
End Class
