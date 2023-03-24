Imports System.Data.SqlClient

Public Class user

    Dim Con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\SystemsPROseries\Documents\HOPINGVbDb.mdf;Integrated Security=True;Connect Timeout=30")


    Private Sub Populate()
        Con.Open()

        Dim query = "select * from userTbl"
        Dim adapter As SqlDataAdapter
        adapter = New SqlDataAdapter(query, Con)
        Dim builder As SqlCommandBuilder
        builder = New SqlCommandBuilder(adapter)
        Dim ds As DataSet
        ds = New DataSet
        adapter.Fill(ds)
        UserDGV.DataSource = ds.Tables(0)
        Con.Close()

    End Sub
    Private Sub Reset()
        UnameTb.Text = ""
        ContactTb.Text = ""
        AddressTb.Text = ""
        PasswordTb.Text = ""
        Key = 0

    End Sub

    Private Sub Savebtn_Click(sender As Object, e As EventArgs) Handles Savebtn.Click

        If UnameTb.Text = "" Or ContactTb.Text = "" Or AddressTb.Text = "" Or PasswordTb.Text = "" Then
            MsgBox("Missing Information")
        Else
            Con.Open()
            Dim query As String
            query = "insert into UserTbl values('" & UnameTb.Text & "','" & ContactTb.Text & "','" & AddressTb.Text & "','" & PasswordTb.Text & "')"
            Dim cmd As SqlCommand
            cmd = New SqlCommand(query, Con)
            cmd.ExecuteNonQuery()
            MsgBox("User Saved Succesfully")
            Con.Close()

            Populate()
            Reset()

        End If
    End Sub

    Private Sub user_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Populate()

    End Sub

    Dim Key = 0
    Private Sub Deletebtn_Click(sender As Object, e As EventArgs) 


        If Key = 0 Then
            MsgBox("Select The User To Be Delected")
        Else
            Con.Open()
            Dim query As String
            query = "Delete from userTbl where Id=" & Key & ""
            Dim cmd As SqlCommand
            cmd = New SqlCommand(query, Con)
            cmd.ExecuteNonQuery()
            MsgBox("User Deleted Succesfully")
            Con.Close()

            Populate()
            Reset()

        End If


    End Sub






    Private Sub UserDGV_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles UserDGV.CellMouseDoubleClick
        Dim row As DataGridViewRow = UserDGV.Rows(e.RowIndex)
        UnameTb.Text = row.Cells(1).Value.ToString
        ContactTb.Text = row.Cells(2).Value.ToString
        AddressTb.Text = row.Cells(3).Value.ToString
        PasswordTb.Text = row.Cells(4).Value.ToString

        If UnameTb.Text = "" Then
            Key = 0
        Else
            Key = Convert.ToInt32(row.Cells(0).Value.ToString)
        End If

    End Sub

    Private Sub ResetBtn_Click(sender As Object, e As EventArgs) Handles ResetBtn.Click

        Reset()


    End Sub

    Private Sub EditBtn_Click(sender As Object, e As EventArgs) Handles EditBtn.Click

        If UnameTb.Text = "" Or ContactTb.Text = "" Or AddressTb.Text = "" Or PasswordTb.Text = "" Then
            MsgBox("Missing Information")
        Else
            Con.Open()
            Dim query As String
            query = "Update userTbl set name='" & UnameTb.Text & "',Contact='" & ContactTb.Text & "',Address='" & AddressTb.Text & "',Password='" & PasswordTb.Text & "' where Id=" & Key & ""
            Dim cmd As SqlCommand
            cmd = New SqlCommand(query, Con)
            cmd.ExecuteNonQuery()
            MsgBox("User Updated Succesfully")
            Con.Close()

            Populate()
            Reset()

        End If

    End Sub

    Private Sub UserDGV_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles UserDGV.CellContentClick

    End Sub

    Private Sub Label14_Click(sender As Object, e As EventArgs) Handles Label14.Click

        Application.Exit()


    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub Label11_Click(sender As Object, e As EventArgs) Handles Label11.Click
        Dim Obj = New book()
        Obj.Show()
        Me.Hide()

    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click
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
End Class