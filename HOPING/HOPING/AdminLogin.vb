﻿Public Class AdminLogin
    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click
        Dim Obj = New login()
        Obj.Show()
        Me.Hide()

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        Application.Exit()

    End Sub



    Private Sub LoginBtn_Click(sender As Object, e As EventArgs) Handles LoginBtn.Click
        If PasswordTb.Text = "Password" Then
            Dim Obj = New book()
            Obj.Show()
            Me.Hide()
        Else
            MsgBox("Incorrect Password")
        End If
    End Sub
End Class