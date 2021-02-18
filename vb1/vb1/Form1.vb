Imports System.Data.OleDb

Public Class Form1
    Public conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\vbdb.accdb")
    Dim dr As OleDbDataReader
    Dim dr1 As OleDbDataReader

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn.Open()

        ComboBox1.Items.Clear()
        ComboBox2.Items.Clear()
        Dim cmd As New OleDbCommand
        cmd.CommandText = "select States from City"
        cmd.Connection = conn
        dr = cmd.ExecuteReader
        While dr.Read
            ComboBox1.Items.Add(dr.GetString(1))
        End While

        conn.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        conn.Open()
        Dim cmd1 As New OleDbCommand
        cmd1.CommandText = "select City from City"
        cmd1.Connection = conn
        dr1 = cmd1.ExecuteReader
        While dr1.Read
            ComboBox2.Items.Add(dr1.GetString(1))
        End While
        conn.Close()
    End Sub
End Class
