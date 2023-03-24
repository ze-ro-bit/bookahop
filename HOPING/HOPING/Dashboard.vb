
Imports System.Data.SqlClient

Public Class Dashboard
    Dim Con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\SystemsPROseries\Documents\HOPINGVbDb.mdf;Integrated Security=True;Connect Timeout=30")
    Private Sub CountBooks()
        Dim BookNum As Integer
        Con.Open()
        Dim sql = "select COUNT(*) from bookTbl"
        Dim cmd As SqlCommand
        cmd = New SqlCommand(sql, Con)
        BookNum = cmd.ExecuteScalar
        BookLbl.Text = BookNum
        Con.Close()
    End Sub

    Private Sub CountUsers()
        Dim UsersNum As Integer
        Con.Open()
        Dim sql = "select COUNT(*) from userTbl"
        Dim cmd As SqlCommand
        cmd = New SqlCommand(sql, Con)
        UsersNum = cmd.ExecuteScalar
        UserLbl.Text = UsersNum
        Con.Close()
    End Sub
    Private Sub SumAmount()
        Dim AmountNum As Integer
        Con.Open()
        Dim sql = "select Sum(Amount) from billsTbl"
        Dim cmd As SqlCommand
        cmd = New SqlCommand(sql, Con)
        AmountNum = cmd.ExecuteScalar
        AmountLbl.Text = "Php " + Convert.ToString(AmountNum)
        Con.Close()
    End Sub

    Private Sub Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CountBooks()
        CountUsers()
        SumAmount()


    End Sub

    Private Sub Label14_Click(sender As Object, e As EventArgs) Handles Label14.Click
        Application.Exit()

    End Sub

    Private Sub Label12_Click(sender As Object, e As EventArgs) Handles Label12.Click
        Dim Obj = New book()
        Obj.Show()
        Me.Hide()

    End Sub

    Private Sub Label11_Click(sender As Object, e As EventArgs) Handles Label11.Click
        Dim Obj = New user()
        Obj.Show()
        Me.Hide()

    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click
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