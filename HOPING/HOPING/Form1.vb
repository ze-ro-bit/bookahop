Public Class Form1
    Private Sub Label2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick










    End Sub

    Private Sub Myprogress_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Timer1.Start()


    End Sub

    Private Sub GunaCircleButton1_Click(sender As Object, e As EventArgs)





    End Sub

    Private Sub Label2_Click_1(sender As Object, e As EventArgs) 

    End Sub

    Private Sub GunaProgressBar1_Click(sender As Object, e As EventArgs) Handles Myprogress.Click

        Myprogress.Increment(10)
        PercentageLbl.Text = Convert.ToString(Myprogress.Value) + "%"
        If Myprogress.Value = 100 Then
            Me.Hide()
            Dim log = New login
            log.Show()
            Timer1.Enabled = False

        End If
    End Sub
End Class
