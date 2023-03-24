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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Myprogress = New Guna.UI.WinForms.GunaProgressBar()
        Me.PercentageLbl = New System.Windows.Forms.Label()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Timer1
        '
        '
        'Myprogress
        '
        Me.Myprogress.BackColor = System.Drawing.Color.White
        Me.Myprogress.BorderColor = System.Drawing.Color.Black
        Me.Myprogress.ColorStyle = Guna.UI.WinForms.ColorStyle.[Default]
        Me.Myprogress.IdleColor = System.Drawing.Color.Gainsboro
        Me.Myprogress.Location = New System.Drawing.Point(-4, 189)
        Me.Myprogress.Name = "Myprogress"
        Me.Myprogress.ProgressMaxColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Myprogress.ProgressMinColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Myprogress.Size = New System.Drawing.Size(489, 21)
        Me.Myprogress.TabIndex = 6
        '
        'PercentageLbl
        '
        Me.PercentageLbl.AutoSize = True
        Me.PercentageLbl.BackColor = System.Drawing.Color.White
        Me.PercentageLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.PercentageLbl.ForeColor = System.Drawing.Color.Black
        Me.PercentageLbl.Location = New System.Drawing.Point(237, 190)
        Me.PercentageLbl.Name = "PercentageLbl"
        Me.PercentageLbl.Size = New System.Drawing.Size(20, 17)
        Me.PercentageLbl.TabIndex = 7
        Me.PercentageLbl.Text = "%"
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), System.Drawing.Image)
        Me.PictureBox5.Location = New System.Drawing.Point(122, 71)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(252, 103)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox5.TabIndex = 31
        Me.PictureBox5.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(94, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(331, 38)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Book Shop Ordering"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkSlateGray
        Me.ClientSize = New System.Drawing.Size(485, 219)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.PercentageLbl)
        Me.Controls.Add(Me.Myprogress)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Myprogress As Guna.UI.WinForms.GunaProgressBar
    Friend WithEvents PercentageLbl As Label
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents Label1 As Label
End Class
