
Imports System.Data.SqlClient
Public Class book

    Dim Con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\SystemsPROseries\Documents\HOPINGVbDb.mdf;Integrated Security=True;Connect Timeout=30")

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

    Private Sub Filter()
        Con.Open()

        Dim query = "select * from bookTbl where Genre= '" & FilterCb.SelectedItem.ToString() & "'"
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




    Private Sub Reset()
        BooksNameTb.Text = ""
        AuthorTb.Text = ""
        QtyTb.Text = ""
        PriceTb.Text = ""

        CatCb.SelectedIndex = -1

        key = 0

    End Sub


    Private Sub BunifuThinButton21_Click(sender As Object, e As EventArgs) Handles SaveBtn.Click
        If BooksNameTb.Text = "" Or AuthorTb.Text = "" Or QtyTb.Text = "" Or PriceTb.Text = "" Or CatCb.SelectedIndex = -1 Then
            MsgBox("Missing information")

        Else
            Con.Open()
            Dim query As String
            query = " insert into bookTbl values('" & BooksNameTb.Text & "','" & AuthorTb.Text & "','" & CatCb.SelectedItem.ToString & "'," & QtyTb.Text & "," & PriceTb.Text & ") "
            Dim cmd As SqlCommand
            cmd = New SqlCommand(query, Con)
            cmd.ExecuteNonQuery()
            MsgBox("Book Saved Successfully")
            Con.Close()
            Populate()
            Reset()

        End If

    End Sub
    Dim key = 0
    Private Sub BookDGV_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles BookDGV.CellMouseDoubleClick
        Dim row As DataGridViewRow = BookDGV.Rows(e.RowIndex)
        BooksNameTb.Text = row.Cells(1).Value.ToString
        AuthorTb.Text = row.Cells(2).Value.ToString
        CatCb.SelectedItem = row.Cells(3).Value.ToString
      
        QtyTb.Text = row.Cells(4).Value.ToString
        PriceTb.Text = row.Cells(5).Value.ToString

        If BooksNameTb.Text = "" Then

            key = 0
        Else
            key = Convert.ToInt32(row.Cells(0).Value.ToString)
        End If


    End Sub

    Private Sub book_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Populate()

    End Sub

    Private Sub ResetBtn_Click(sender As Object, e As EventArgs) Handles ResetBtn.Click
        Reset()

    End Sub

    Private Sub DeleteBtn_Click(sender As Object, e As EventArgs) 

        If key = 0 Then
            MsgBox("Select The User To Be Delected")
        Else
            Con.Open()
            Dim query As String
            query = "Delete from bookTbl where Bld=" & key & ""
            Dim cmd As SqlCommand
            cmd = New SqlCommand(query, Con)
            cmd.ExecuteNonQuery()
            MsgBox("book Deleted Succesfully")
            Con.Close()

            Populate()
            Reset()
        End If

    End Sub

    Private Sub Label14_Click(sender As Object, e As EventArgs) Handles Label14.Click
        Application.Exit()


    End Sub

    Private Sub EditBtn_Click(sender As Object, e As EventArgs) Handles EditBtn.Click


        If BooksNameTb.Text = "" Or AuthorTb.Text = "" Or QtyTb.Text = "" Or PriceTb.Text = "" Or CatCb.SelectedIndex = -1 Then
            MsgBox("Missing Information")
        Else
            Con.Open()
            Dim query As String
            query = " insert into bookTbl values('" & BooksNameTb.Text & "','" & AuthorTb.Text & "','" & CatCb.SelectedItem.ToString & "'," & QtyTb.Text & "," & PriceTb.Text & ") "
            Dim cmd As SqlCommand
            cmd = New SqlCommand(query, Con)
            cmd.ExecuteNonQuery()
        MsgBox("Book Updated Succesfully")
        Con.Close()

            Populate()
            Reset()

        End If


    End Sub

    Private Sub FilterCb_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles FilterCb.SelectionChangeCommitted


        Filter()

    End Sub

    Private Sub RefreshBtn_Click(sender As Object, e As EventArgs) Handles RefreshBtn.Click
        Populate()

    End Sub

    Private Sub Label11_Click(sender As Object, e As EventArgs) Handles Users.Click
        Dim Obj = New user()
        Obj.Show()
        Me.Hide()


    End Sub

    Private Sub Label12_Click(sender As Object, e As EventArgs) Handles Label12.Click
        Dim Obj = New Dashboard()
        Obj.Show()
        Me.Hide()

    End Sub

    Private Sub Label13_Click(sender As Object, e As EventArgs) Handles Label13.Click
        Dim Obj = New login()
        Obj.Show()
        Me.Hide()

    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click
        Dim Obj = New book()
        Obj.Show()
        Me.Hide()

    End Sub




End Class
