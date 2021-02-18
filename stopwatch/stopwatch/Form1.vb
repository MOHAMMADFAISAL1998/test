Public Class stopwatch


    Dim nano As Integer
    Dim sec As Integer
    Dim min As Integer
    Dim hour As Integer


    Private Sub Btn1_Click(sender As Object, e As EventArgs) Handles Btn1.Click

        Timer1.Start()

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        nano += 5
        If nano = 100 Then
            sec += 1
            nano = 30
        End If
        If sec = 60 Then
            min += 1
            sec = 0
        End If
        If min = 60 Then
            hour += 1
            min = 0
        End If
        
        l1.Text = hour & ":" & min & ":" & sec & "." & nano
    End Sub

    Private Sub Btn2_Click(sender As Object, e As EventArgs) Handles Btn2.Click

        Timer1.Stop()

    End Sub

    Private Sub Btn3_Click(sender As Object, e As EventArgs) Handles Btn3.Click

        hour = "0"
        min = "0"
        sec = "0"
        nano = "0"
       
    End Sub

    Private Sub stopwatch_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        l1.Text = hour & ":" & min & ":" & sec & "." & nano

    End Sub
End Class