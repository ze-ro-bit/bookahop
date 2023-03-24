Imports System.Data.SqlClient

Public Class bills

    Dim Con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\SystemsPROseries\Documents\HOPINGVbDb.mdf;Integrated Security=True;Connect Timeout=30")
    Public Property Username As String
    Private Sub Populate()
        Con.Open()

        Dim query = "select * from bookTbl"
        Dim adapter As SqlDataAdapter
        adapter = New SqlDataAdapter(query, Con)
        Dim builder As SqlCommandBuilder
        builder = New SqlCommandBuilder(adapter)
        Dim ds As DataSet
        ds = New DataSet
        adapter.Fill(ds)
        BookDGV.DataSource = ds.Tables(0)
        Con.Close()

    End Sub



    Private Sub bills_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Populate()
        UnameLbl.Text = Username

    End Sub
    Dim key = 0, Stock = 0, GrdTotal = 0, i = 0

    Private Sub Label14_Click(sender As Object, e As EventArgs) Handles Label14.Click
        Dim Obj = New login()
        Obj.Show()
        Me.Hide()

    End Sub
    Private Sub Reset()
        key = 0
        QtyTb.Text = ""
        PriceTb.Text = ""
        ClientNameTb.Text = ""
        BNameTb.Text = ""
    End Sub
    Private Sub BunifuThinButton22_Click(sender As Object, e As EventArgs) Handles BunifuThinButton22.Click
        Reset()

    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        e.Graphics.DrawString("Book Shop", New Font("Arial", 25), Brushes.MidnightBlue, 350, 40)
        e.Graphics.DrawString("======Your Bill=======", New Font("Arial", 16), Brushes.MidnightBlue, 350, 40)
        Dim bm As New Bitmap(Me.BillDGV.Width, Me.BillDGV.Height)
        BillDGV.DrawToBitmap(bm, New Rectangle(0, 0, Me.BillDGV.Width, Me.BillDGV.Height))
        e.Graphics.DrawImage(bm, 60, 120)
        e.Graphics.DrawString("Total Amount Php " + GrdTotal.ToString, New Font("Arial", 15), Brushes.MidnightBlue, 280, 500)
        e.Graphics.DrawString("=========Thank You for Purchasing===========", New Font("Arial", 15), Brushes.Crimson, 150, 580)
    End Sub

    Private Sub BunifuThinButton25_Click(sender As Object, e As EventArgs) Handles BunifuThinButton25.Click
        PrintPreviewDialog1.Show()
        AddBill()

    End Sub
    Private Sub AddBill()


        Con.Open()
        Dim query As String
        query = " insert into billsTbl values('" & UnameLbl.Text & "','" & ClientNameTb.Text & "'," & GrdTotal & ")"
        Dim cmd As SqlCommand
        cmd = New SqlCommand(query, Con)
        cmd.ExecuteNonQuery()
        MsgBox("Bill Saved Successfully")
        Con.Close()


    End Sub

    Private Overloads Sub Update()

        Dim NewQty = Stock - Convert.ToInt32(QtyTb.Text)
        Con.Open()
        Dim query As String
        query = " Update bookTbl set Quantity=" & NewQty & " Where Bld=" & key & ""
        Dim cmd As SqlCommand
        cmd = New SqlCommand(query, Con)
        cmd.ExecuteNonQuery()
        MsgBox("Book Updated Succesfully")
        Con.Close()
        Populate()

    End Sub
    Private Sub BunifuThinButton21_Click(sender As Object, e As EventArgs) Handles AddToBillBtn.Click
        If PriceTb.Text = "" Or QtyTb.Text = "" Then
            MsgBox("Enter the Quantity")
        ElseIf key = 0 Then
            MsgBox("Select The book")






        Else
            Dim rnum As Integer = BillDGV.Rows.Add()
            i = i + 1



            Dim total = Convert.ToInt32(QtyTb.Text) * Convert.ToInt32(PriceTb.Text)
            BillDGV.Rows.Item(rnum).Cells("Column1").Value = i
            BillDGV.Rows.Item(rnum).Cells("Column2").Value = BNameTb.Text
            BillDGV.Rows.Item(rnum).Cells("Column3").Value = PriceTb.Text
            BillDGV.Rows.Item(rnum).Cells("Column4").Value = QtyTb.Text

            BillDGV.Rows.Item(rnum).Cells("Column5").Value = total

            GrdTotal = GrdTotal + total
            Dim Tot As String
            Tot = "Php" + Convert.ToString(GrdTotal)
            TotalLbl.Text = Tot
            Update()


        End If
    End Sub


    Private Sub BookDGV_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles BookDGV.CellContentClick


        Dim row As DataGridViewRow = BookDGV.Rows(e.RowIndex)
        BNameTb.Text = row.Cells(1).Value.ToString
        PriceTb.Text = row.Cells(5).Value.ToString


        PriceTb.Text = row.Cells(5).Value.ToString




        If BNameTb.Text = "" Then

            key = 0
        Else
            key = Convert.ToInt32(row.Cells(0).Value.ToString)
        End If

    End Sub
End Class

