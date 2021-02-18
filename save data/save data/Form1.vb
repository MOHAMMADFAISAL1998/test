Public Class Form1

    Private Sub ColorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ColorToolStripMenuItem.Click
        If ColorDialog1.ShowDialog = DialogResult.OK Then
            TextBox5.ForeColor = ColorDialog1.Color
        End If
    End Sub

   
    Private Sub FontToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FontToolStripMenuItem.Click
        If FontDialog1.ShowDialog = DialogResult.OK Then
            TextBox5.Font = FontDialog1.Font
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox5.AppendText("" + vbNewLine)
        TextBox5.AppendText(vbTab & Label1.Text + " : " + TextBox1.Text + vbNewLine)
        TextBox5.AppendText("" + vbNewLine)
        TextBox5.AppendText(vbTab & Label2.Text + " : " + TextBox2.Text + vbNewLine)
        TextBox5.AppendText("" + vbNewLine)
        TextBox5.AppendText(vbTab & Label3.Text + " : " + TextBox3.Text + vbNewLine)
        TextBox5.AppendText("" + vbNewLine)
        TextBox5.AppendText(vbTab & Label4.Text + " : " + TextBox4.Text + vbNewLine)
        TextBox5.AppendText("" + vbNewLine)
        TextBox5.AppendText("***********************************************************" + vbNewLine)
        TextBox5.AppendText(vbTab & Today & vbTab & TimeOfDay + vbNewLine)
        TextBox5.AppendText("***********************************************************" + vbNewLine)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim isave As New SaveFileDialog
        isave.Filter = "txt files (*.txt) |*.txt"
        isave.FilterIndex = 2
        isave.RestoreDirectory = False

        If isave.ShowDialog() = DialogResult.OK Then
            IO.File.WriteAllText(isave.FileName, TextBox5.Text)
        End If
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

   
End Class
