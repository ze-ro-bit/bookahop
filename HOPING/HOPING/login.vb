
Imports System.Data.SqlClient
Public Class login
    Dim Con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\SystemsPROseries\Documents\HOPINGVbDb.mdf;Integrated Security=True;Connect Timeout=30")
    Dim cmd As SqlCommand
    Private Sub BunifuThinButton21_Click(sender As Object, e As EventArgs) Handles LoginBtn.Click
        If UnameTb.Text = "" Or PasswordTb.Text = "" Then
            MsgBox("Enter Username and Password")
        Else Con.Open()
            Dim query = "select * from userTbl where name ='" & UnameTb.Text & "' and password='" & PasswordTb.Text & "'"
            cmd = New SqlCommand(query, Con)
            Dim sda As SqlDataAdapter = New SqlDataAdapter(cmd)
            Dim ds As DataSet = New DataSet()
            sda.Fill(ds)
            Dim a As Integer
            a = ds.Tables(0).Rows.Count
            If a = 0 Then
                MsgBox("Incorrect Username and Password")
            Else

                Dim Bill = New bills
                Bill.Username = UnameTb.Text
                Bill.Show()
                Me.Hide()
            End If
            Con.Close()

        End If
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        Application.Exit()

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click
        Dim Obj = New AdminLogin()
        Obj.Show()
        Me.Hide()
    End Sub
End Class

