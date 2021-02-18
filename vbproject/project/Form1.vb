Public Class Form1

    Dim firstvalue As Decimal
    Dim secondvalue As Decimal
    Dim ans As Decimal
    Dim operation As String

    Dim plane2mm As Integer
    Dim plane3mm, mirror3mm As Integer
    Dim whitefigure, blackfigure, kalafigure, mirror, reflective, fReflective As Integer
    Dim plane4mm As Integer
    Dim kalafigure1 As Integer
    Dim plane5mm, mirror5mm, reflective5mm, fReflective5mm, fReflective5mm1 As Integer
    Dim plane6mm As Integer
    Dim plane8mm, brown8mm As Integer
    Dim plane10mm As Integer
    Dim plane12mm As Integer

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label2.Text = ""
        Label3.Text = ""
        Label4.Text = ""
        Label5.Text = ""

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If TextBox1.Text = "0" Then
            TextBox1.Text = "1"
        Else
            TextBox1.Text += "1"
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If TextBox1.Text = "0" Then
            TextBox1.Text = "2"
        Else
            TextBox1.Text += "2"
        End If

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If TextBox1.Text = "0" Then
            TextBox1.Text = "3"
        Else
            TextBox1.Text += "3"
        End If

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If TextBox1.Text = "0" Then
            TextBox1.Text = "4"
        Else
            TextBox1.Text += "4"
        End If

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If TextBox1.Text = "0" Then
            TextBox1.Text = "5"
        Else
            TextBox1.Text += "5"
        End If

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        If TextBox1.Text = "0" Then
            TextBox1.Text = "6"
        Else
            TextBox1.Text += "6"
        End If

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        If TextBox1.Text = "0" Then
            TextBox1.Text = "7"
        Else
            TextBox1.Text += "7"
        End If

    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        If TextBox1.Text = "0" Then
            TextBox1.Text = "8"
        Else
            TextBox1.Text += "8"
        End If

    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        If TextBox1.Text = "0" Then
            TextBox1.Text = "9"
        Else
            TextBox1.Text += "9"
        End If

    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        If TextBox1.Text = "0" Then
            TextBox1.Text = "0"
        Else
            TextBox1.Text += "0"
        End If

    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click

        If Not (TextBox1.Text.Contains(".")) Then
            TextBox1.Text += "."
        End If

    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        firstvalue = TextBox1.Text
        Label1.Text = firstvalue & "+"
        TextBox1.Text = ""
        operation = "+"
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        firstvalue = TextBox1.Text
        Label1.Text = firstvalue & "-"
        TextBox1.Text = ""
        operation = "-"

    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        firstvalue = TextBox1.Text
        Label1.Text = firstvalue & "/"
        TextBox1.Text = ""
        operation = "/"

    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        firstvalue = TextBox1.Text
        Label1.Text = firstvalue & "*"
        TextBox1.Text = ""
        operation = "*"

    End Sub

   
    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        secondvalue = TextBox1.Text
        If operation = "+" Then
            ans = firstvalue + secondvalue
            TextBox1.Text = ans
            Label1.Text = ""
        ElseIf operation = "-" Then
            ans = firstvalue - secondvalue
            TextBox1.Text = ans
            Label1.Text = ""
        ElseIf operation = "/" Then
            ans = firstvalue / secondvalue
            TextBox1.Text = ans
            Label1.Text = ""
        ElseIf operation = "*" Then
            ans = firstvalue * secondvalue
            TextBox1.Text = ans
            Label1.Text = ""

        End If
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click

        TextBox1.Text = ""
        Label1.Text = ""
        TextBox1.Text = "0"


    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        ComboBox3.Visible = True
        ComboBox4.Visible = True

        If ComboBox1.SelectedItem = "2MM" Then
            plane2mm = 18
            Label2.Text = plane2mm

        End If

        If ComboBox1.SelectedItem = "3MM" Then
            If ComboBox2.SelectedItem = "Plane Glass" Then
                Label2.Text = "28"
            Else
                Label2.Text = "40"
            End If
        End If

        If ComboBox1.SelectedItem = "3.5MM" Then
            If ComboBox2.SelectedItem = "White Figure Glass" Then
                Label2.Text = "31"
            ElseIf ComboBox2.SelectedItem = "Black Swastik Figure Glass" Then
                Label2.Text = "35"
            ElseIf ComboBox2.SelectedItem = "Black Kalakachi Figure Glass" Then
                Label2.Text = "34"
            ElseIf ComboBox2.SelectedItem = "Mirror" Then
                Label2.Text = "50"
            ElseIf ComboBox2.SelectedItem = "Reflective Glass" Then
                Label2.Text = "45"
            Else
                Label2.Text = "60"
            End If
        End If

        If ComboBox1.SelectedItem = "4MM" Then
            If ComboBox2.SelectedItem = "Plane Glass" Then
                Label2.Text = "37"
            End If
        End If

        If ComboBox1.SelectedItem = "4.5MM" Then
            If ComboBox2.SelectedItem = "Black Kalakachi Figure Glass" Then
                Label2.Text = "42"
            End If
        End If

        If ComboBox1.SelectedItem = "5MM" Then
            If ComboBox2.SelectedItem = "Plane Glass" Then
                Label2.Text = "45"
            ElseIf ComboBox2.SelectedItem = "Modi Mirror" Then
                Label2.Text = "78"
            ElseIf ComboBox2.SelectedItem = "Reflective Glass" Then
                Label2.Text = "58"
            ElseIf ComboBox2.SelectedItem = "F. Blue Reflective Glass" Then
                Label2.Text = "75"
            Else
                Label2.Text = "80"
            End If
        End If

        If ComboBox1.SelectedItem = "6MM" Then
            If ComboBox2.SelectedItem = "Plane Glass" Then
                Label2.Text = "58"
            End If
        End If

        If ComboBox1.SelectedItem = "8MM" Then
            If ComboBox2.SelectedItem = "Plane Glass" Then
                Label2.Text = "78"
            Else
                Label2.Text = "110"
            End If
        End If

        If ComboBox1.SelectedItem = "10MM" Then
            If ComboBox2.SelectedItem = "Plane Glass" Then
                Label2.Text = "95"
            End If
        End If

        If ComboBox1.SelectedItem = "12MM" Then
            If ComboBox2.SelectedItem = "Plane Glass" Then
                Label2.Text = "110"
            End If
        End If

        Label45.Visible = True
        Label49.Visible = True
    End Sub

    Private Sub ComboBox4_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox4.SelectedIndexChanged
        ComboBox6.Visible = True
        ComboBox5.Visible = True

        If ComboBox3.SelectedItem = "2MM" Then
            Label3.Text = "18"
        End If

        If ComboBox3.SelectedItem = "3MM" Then
            If ComboBox4.SelectedItem = "Plane Glass" Then
                Label3.Text = "28"
            Else
                Label3.Text = "40"
            End If
        End If

        If ComboBox3.SelectedItem = "3.5MM" Then
            If ComboBox4.SelectedItem = "White Figure Glass" Then
                Label3.Text = "31"
            ElseIf ComboBox4.SelectedItem = "Black Swastik Figure Glass" Then
                Label3.Text = "35"
            ElseIf ComboBox4.SelectedItem = "Black Kalakachi Figure Glass" Then
                Label3.Text = "34"
            ElseIf ComboBox4.SelectedItem = "Mirror" Then
                Label3.Text = "50"
            ElseIf ComboBox4.SelectedItem = "Reflective Glass" Then
                Label3.Text = "45"
            Else
                Label3.Text = "60"
            End If
        End If

        If ComboBox3.SelectedItem = "4MM" Then
            If ComboBox4.SelectedItem = "Plane Glass" Then
                Label3.Text = "37"
            End If
        End If

        If ComboBox3.SelectedItem = "4.5MM" Then
            If ComboBox4.SelectedItem = "Black Kalakachi Figure Glass" Then
                Label3.Text = "42"
            End If
        End If

        If ComboBox3.SelectedItem = "5MM" Then
            If ComboBox4.SelectedItem = "Plane Glass" Then
                Label3.Text = "45"
            ElseIf ComboBox4.SelectedItem = "Modi Mirror" Then
                Label3.Text = "78"
            ElseIf ComboBox4.SelectedItem = "Reflective Glass" Then
                Label3.Text = "58"
            ElseIf ComboBox4.SelectedItem = "F. Blue Reflective Glass" Then
                Label3.Text = "75"
            Else
                Label3.Text = "80"
            End If
        End If

        If ComboBox3.SelectedItem = "6MM" Then
            If ComboBox4.SelectedItem = "Plane Glass" Then
                Label3.Text = "58"
            End If
        End If

        If ComboBox3.SelectedItem = "8MM" Then
            If ComboBox4.SelectedItem = "Plane Glass" Then
                Label3.Text = "78"
            Else
                Label3.Text = "110"
            End If
        End If

        If ComboBox3.SelectedItem = "10MM" Then
            If ComboBox4.SelectedItem = "Plane Glass" Then
                Label3.Text = "95"
            End If
        End If

        If ComboBox3.SelectedItem = "12MM" Then
            If ComboBox4.SelectedItem = "Plane Glass" Then
                Label3.Text = "110"
            End If
        End If

        Label46.Visible = True
        Label50.Visible = True

    End Sub

    Private Sub ComboBox5_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox5.SelectedIndexChanged
        ComboBox8.Visible = True
        ComboBox7.Visible = True

        If ComboBox6.SelectedItem = "2MM" Then
            Label4.Text = "18"
        End If

        If ComboBox6.SelectedItem = "3MM" Then
            If ComboBox5.SelectedItem = "Plane Glass" Then
                Label4.Text = "28"
            Else
                Label4.Text = "40"
            End If
        End If

        If ComboBox6.SelectedItem = "3.5MM" Then
            If ComboBox5.SelectedItem = "White Figure Glass" Then
                Label4.Text = "31"
            ElseIf ComboBox5.SelectedItem = "Black Swastik Figure Glass" Then
                Label4.Text = "35"
            ElseIf ComboBox5.SelectedItem = "Black Kalakachi Figure Glass" Then
                Label4.Text = "34"
            ElseIf ComboBox5.SelectedItem = "Mirror" Then
                Label4.Text = "50"
            ElseIf ComboBox5.SelectedItem = "Reflective Glass" Then
                Label4.Text = "45"
            Else
                Label4.Text = "60"
            End If
        End If

        If ComboBox6.SelectedItem = "4MM" Then
            If ComboBox5.SelectedItem = "Plane Glass" Then
                Label4.Text = "37"
            End If
        End If

        If ComboBox6.SelectedItem = "4.5MM" Then
            If ComboBox5.SelectedItem = "Black Kalakachi Figure Glass" Then
                Label4.Text = "42"
            End If
        End If

        If ComboBox6.SelectedItem = "5MM" Then
            If ComboBox5.SelectedItem = "Plane Glass" Then
                Label4.Text = "45"
            ElseIf ComboBox5.SelectedItem = "Modi Mirror" Then
                Label4.Text = "78"
            ElseIf ComboBox5.SelectedItem = "Reflective Glass" Then
                Label4.Text = "58"
            ElseIf ComboBox5.SelectedItem = "F. Blue Reflective Glass" Then
                Label4.Text = "75"
            Else
                Label4.Text = "80"
            End If
        End If

        If ComboBox6.SelectedItem = "6MM" Then
            If ComboBox5.SelectedItem = "Plane Glass" Then
                Label4.Text = "58"
            End If
        End If

        If ComboBox6.SelectedItem = "8MM" Then
            If ComboBox5.SelectedItem = "Plane Glass" Then
                Label4.Text = "78"
            Else
                Label4.Text = "110"
            End If
        End If

        If ComboBox6.SelectedItem = "10MM" Then
            If ComboBox5.SelectedItem = "Plane Glass" Then
                Label4.Text = "95"
            End If
        End If

        If ComboBox6.SelectedItem = "12MM" Then
            If ComboBox5.SelectedItem = "Plane Glass" Then
                Label4.Text = "110"
            End If
        End If

        Label47.Visible = True
        Label51.Visible = True
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

        ComboBox9.Visible = False
        ComboBox10.Visible = False
        TextBox39.Visible = False
        Button20.Visible = False

        If ComboBox1.SelectedItem = "2MM" Then
            ComboBox2.Items.Clear()
            ComboBox2.Items.Add("Plane Glass")
        ElseIf ComboBox1.SelectedItem = "3MM" Then
            ComboBox2.Items.Clear()
            ComboBox2.Items.Add("Plane Glass")
            ComboBox2.Items.Add("Mirror")

        ElseIf ComboBox1.SelectedItem = "3.5MM" Then
            ComboBox2.Items.Clear()
            ComboBox2.Items.Add("White Figure Glass")
            ComboBox2.Items.Add("Black Swastik Figure Glass")
            ComboBox2.Items.Add("Black Kalakachi Figure Glass")
            ComboBox2.Items.Add("Mirror")
            ComboBox2.Items.Add("Reflective Glass")
            ComboBox2.Items.Add("F. Reflective Glass")

        ElseIf ComboBox1.SelectedItem = "4MM" Then
            ComboBox2.Items.Clear()
            ComboBox2.Items.Add("Plane Glass")
        ElseIf ComboBox1.SelectedItem = "4.5MM" Then
            ComboBox2.Items.Clear()
            ComboBox2.Items.Add("Black Kalakachi Figure Glass")

        ElseIf ComboBox1.SelectedItem = "5MM" Then
            ComboBox2.Items.Clear()
            ComboBox2.Items.Add("Plane Glass")
            ComboBox2.Items.Add("Modi Mirror")
            ComboBox2.Items.Add("Reflective Glass")
            ComboBox2.Items.Add("F. Blue Reflective Glass")
            ComboBox2.Items.Add("F. Brown Reflective Glass")
        ElseIf ComboBox1.SelectedItem = "6MM" Then
            ComboBox2.Items.Clear()
            ComboBox2.Items.Add("Plane Glass")
        ElseIf ComboBox1.SelectedItem = "8MM" Then
            ComboBox2.Items.Clear()
            ComboBox2.Items.Add("Plane Glass")
            ComboBox2.Items.Add("Brown Plane Glass")
        ElseIf ComboBox1.SelectedItem = "10MM" Then
            ComboBox2.Items.Clear()
            ComboBox2.Items.Add("Plane Glass")
        ElseIf ComboBox1.SelectedItem = "12MM" Then
            ComboBox2.Items.Clear()
            ComboBox2.Items.Add("Plane Glass")

        End If
    End Sub

    Private Sub ComboBox3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox3.SelectedIndexChanged
        If ComboBox3.SelectedItem = "2MM" Then
            ComboBox4.Items.Clear()
            ComboBox4.Items.Add("Plane Glass")
        ElseIf ComboBox3.SelectedItem = "3MM" Then
            ComboBox4.Items.Clear()
            ComboBox4.Items.Add("Plane Glass")
            ComboBox4.Items.Add("Mirror")

        ElseIf ComboBox3.SelectedItem = "3.5MM" Then
            ComboBox4.Items.Clear()
            ComboBox4.Items.Add("White Figure Glass")
            ComboBox4.Items.Add("Black Swastik Figure Glass")
            ComboBox4.Items.Add("Black Kalakachi Figure Glass")
            ComboBox4.Items.Add("Mirror")
            ComboBox4.Items.Add("Reflective Glass")
            ComboBox4.Items.Add("F. Reflective Glass")

        ElseIf ComboBox3.SelectedItem = "4MM" Then
            ComboBox4.Items.Clear()
            ComboBox4.Items.Add("Plane Glass")
        ElseIf ComboBox3.SelectedItem = "4.5MM" Then
            ComboBox4.Items.Clear()
            ComboBox4.Items.Add("Black Kalakachi Figure Glass")

        ElseIf ComboBox3.SelectedItem = "5MM" Then
            ComboBox4.Items.Clear()
            ComboBox4.Items.Add("Plane Glass")
            ComboBox4.Items.Add("Modi Mirror")
            ComboBox4.Items.Add("Reflective Glass")
            ComboBox4.Items.Add("F. Blue Reflective Glass")
            ComboBox4.Items.Add("F. Brown Reflective Glass")
        ElseIf ComboBox3.SelectedItem = "6MM" Then
            ComboBox4.Items.Clear()
            ComboBox4.Items.Add("Plane Glass")
        ElseIf ComboBox3.SelectedItem = "8MM" Then
            ComboBox4.Items.Clear()
            ComboBox4.Items.Add("Plane Glass")
            ComboBox4.Items.Add("Brown Plane Glass")
        ElseIf ComboBox3.SelectedItem = "10MM" Then
            ComboBox4.Items.Clear()
            ComboBox4.Items.Add("Plane Glass")
        ElseIf ComboBox3.SelectedItem = "12MM" Then
            ComboBox4.Items.Clear()
            ComboBox4.Items.Add("Plane Glass")

        End If
    End Sub

    Private Sub ComboBox6_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox6.SelectedIndexChanged
        If ComboBox6.SelectedItem = "2MM" Then
            ComboBox5.Items.Clear()
            ComboBox5.Items.Add("Plane Glass")
        ElseIf ComboBox6.SelectedItem = "3MM" Then
            ComboBox5.Items.Clear()
            ComboBox5.Items.Add("Plane Glass")
            ComboBox5.Items.Add("Mirror")

        ElseIf ComboBox6.SelectedItem = "3.5MM" Then
            ComboBox5.Items.Clear()
            ComboBox5.Items.Add("White Figure Glass")
            ComboBox5.Items.Add("Black Swastik Figure Glass")
            ComboBox5.Items.Add("Black Kalakachi Figure Glass")
            ComboBox5.Items.Add("Mirror")
            ComboBox5.Items.Add("Reflective Glass")
            ComboBox5.Items.Add("F. Reflective Glass")

        ElseIf ComboBox6.SelectedItem = "4MM" Then
            ComboBox5.Items.Clear()
            ComboBox5.Items.Add("Plane Glass")
        ElseIf ComboBox6.SelectedItem = "4.5MM" Then
            ComboBox5.Items.Clear()
            ComboBox5.Items.Add("Black Kalakachi Figure Glass")

        ElseIf ComboBox6.SelectedItem = "5MM" Then
            ComboBox5.Items.Clear()
            ComboBox5.Items.Add("Plane Glass")
            ComboBox5.Items.Add("Modi Mirror")
            ComboBox5.Items.Add("Reflective Glass")
            ComboBox5.Items.Add("F. Blue Reflective Glass")
            ComboBox5.Items.Add("F. Brown Reflective Glass")
        ElseIf ComboBox6.SelectedItem = "6MM" Then
            ComboBox5.Items.Clear()
            ComboBox5.Items.Add("Plane Glass")
        ElseIf ComboBox6.SelectedItem = "8MM" Then
            ComboBox5.Items.Clear()
            ComboBox5.Items.Add("Plane Glass")
            ComboBox5.Items.Add("Brown Plane Glass")
        ElseIf ComboBox6.SelectedItem = "10MM" Then
            ComboBox5.Items.Clear()
            ComboBox5.Items.Add("Plane Glass")
        ElseIf ComboBox6.SelectedItem = "12MM" Then
            ComboBox5.Items.Clear()
            ComboBox5.Items.Add("Plane Glass")

        End If
    End Sub

    Private Sub ComboBox8_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox8.SelectedIndexChanged
        If ComboBox8.SelectedItem = "2MM" Then
            ComboBox7.Items.Clear()
            ComboBox7.Items.Add("Plane Glass")
        ElseIf ComboBox8.SelectedItem = "3MM" Then
            ComboBox7.Items.Clear()
            ComboBox7.Items.Add("Plane Glass")
            ComboBox7.Items.Add("Mirror")

        ElseIf ComboBox8.SelectedItem = "3.5MM" Then
            ComboBox7.Items.Clear()
            ComboBox7.Items.Add("White Figure Glass")
            ComboBox7.Items.Add("Black Swastik Figure Glass")
            ComboBox7.Items.Add("Black Kalakachi Figure Glass")
            ComboBox7.Items.Add("Mirror")
            ComboBox7.Items.Add("Reflective Glass")
            ComboBox7.Items.Add("F. Reflective Glass")

        ElseIf ComboBox8.SelectedItem = "4MM" Then
            ComboBox7.Items.Clear()
            ComboBox7.Items.Add("Plane Glass")
        ElseIf ComboBox8.SelectedItem = "4.5MM" Then
            ComboBox7.Items.Clear()
            ComboBox7.Items.Add("Black Kalakachi Figure Glass")

        ElseIf ComboBox8.SelectedItem = "5MM" Then
            ComboBox7.Items.Clear()
            ComboBox7.Items.Add("Plane Glass")
            ComboBox7.Items.Add("Modi Mirror")
            ComboBox7.Items.Add("Reflective Glass")
            ComboBox7.Items.Add("F. Blue Reflective Glass")
            ComboBox7.Items.Add("F. Brown Reflective Glass")
        ElseIf ComboBox8.SelectedItem = "6MM" Then
            ComboBox7.Items.Clear()
            ComboBox7.Items.Add("Plane Glass")
        ElseIf ComboBox8.SelectedItem = "8MM" Then
            ComboBox7.Items.Clear()
            ComboBox7.Items.Add("Plane Glass")
            ComboBox7.Items.Add("Brown Plane Glass")
        ElseIf ComboBox8.SelectedItem = "10MM" Then
            ComboBox7.Items.Clear()
            ComboBox7.Items.Add("Plane Glass")
        ElseIf ComboBox8.SelectedItem = "12MM" Then
            ComboBox7.Items.Clear()
            ComboBox7.Items.Add("Plane Glass")

        End If
    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        firstvalue = 0
        secondvalue = 0
        ans = 0
        operation = ""

        ComboBox2.Items.Clear()
        ComboBox4.Items.Clear()
        ComboBox5.Items.Clear()
        ComboBox7.Items.Clear()

        ComboBox3.Visible = False
        ComboBox4.Visible = False
        ComboBox5.Visible = False
        ComboBox6.Visible = False
        ComboBox7.Visible = False
        ComboBox8.Visible = False

        Label2.Text = ""
        Label3.Text = ""
        Label4.Text = ""
        Label5.Text = ""

    End Sub

    Private Sub ComboBox7_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox7.SelectedIndexChanged

        If ComboBox8.SelectedItem = "2MM" Then
            Label5.Text = "18"
        End If

        If ComboBox8.SelectedItem = "3MM" Then
            If ComboBox7.SelectedItem = "Plane Glass" Then
                Label5.Text = "28"
            Else
                Label5.Text = "40"
            End If
        End If

        If ComboBox8.SelectedItem = "3.5MM" Then
            If ComboBox7.SelectedItem = "White Figure Glass" Then
                Label5.Text = "31"
            ElseIf ComboBox7.SelectedItem = "Black Swastik Figure Glass" Then
                Label5.Text = "35"
            ElseIf ComboBox7.SelectedItem = "Black Kalakachi Figure Glass" Then
                Label5.Text = "34"
            ElseIf ComboBox7.SelectedItem = "Mirror" Then
                Label5.Text = "50"
            ElseIf ComboBox7.SelectedItem = "Reflective Glass" Then
                Label5.Text = "45"
            Else
                Label5.Text = "60"
            End If
        End If

        If ComboBox8.SelectedItem = "4MM" Then
            If ComboBox7.SelectedItem = "Plane Glass" Then
                Label5.Text = "37"
            End If
        End If

        If ComboBox8.SelectedItem = "4.5MM" Then
            If ComboBox7.SelectedItem = "Black Kalakachi Figure Glass" Then
                Label5.Text = "42"
            End If
        End If

        If ComboBox8.SelectedItem = "5MM" Then
            If ComboBox7.SelectedItem = "Plane Glass" Then
                Label5.Text = "45"
            ElseIf ComboBox7.SelectedItem = "Modi Mirror" Then
                Label5.Text = "78"
            ElseIf ComboBox7.SelectedItem = "Reflective Glass" Then
                Label5.Text = "58"
            ElseIf ComboBox7.SelectedItem = "F. Blue Reflective Glass" Then
                Label5.Text = "75"
            Else
                Label5.Text = "80"
            End If
        End If

        If ComboBox8.SelectedItem = "6MM" Then
            If ComboBox7.SelectedItem = "Plane Glass" Then
                Label5.Text = "58"
            End If
        End If

        If ComboBox8.SelectedItem = "8MM" Then
            If ComboBox7.SelectedItem = "Plane Glass" Then
                Label5.Text = "78"
            Else
                Label5.Text = "110"
            End If
        End If

        If ComboBox8.SelectedItem = "10MM" Then
            If ComboBox7.SelectedItem = "Plane Glass" Then
                Label5.Text = "95"
            End If
        End If

        If ComboBox8.SelectedItem = "12MM" Then
            If ComboBox7.SelectedItem = "Plane Glass" Then
                Label5.Text = "110"
            End If
        End If

        Label48.Visible = True
        Label52.Visible = True

    End Sub

    Private Sub ComboBox9_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox9.SelectedIndexChanged
        If ComboBox9.SelectedItem = "2MM" Then
            ComboBox10.Items.Clear()
            ComboBox10.Items.Add("Plane Glass")
        ElseIf ComboBox9.SelectedItem = "3MM" Then
            ComboBox10.Items.Clear()
            ComboBox10.Items.Add("Plane Glass")
            ComboBox10.Items.Add("Mirror")

        ElseIf ComboBox9.SelectedItem = "3.5MM" Then
            ComboBox10.Items.Clear()
            ComboBox10.Items.Add("White Figure Glass")
            ComboBox10.Items.Add("Black Swastik Figure Glass")
            ComboBox10.Items.Add("Black Kalakachi Figure Glass")
            ComboBox10.Items.Add("Mirror")
            ComboBox10.Items.Add("Reflective Glass")
            ComboBox10.Items.Add("F. Reflective Glass")

        ElseIf ComboBox9.SelectedItem = "4MM" Then
            ComboBox10.Items.Clear()
            ComboBox10.Items.Add("Plane Glass")
        ElseIf ComboBox9.SelectedItem = "4.5MM" Then
            ComboBox10.Items.Clear()
            ComboBox10.Items.Add("Black Kalakachi Figure Glass")

        ElseIf ComboBox9.SelectedItem = "5MM" Then
            ComboBox10.Items.Clear()
            ComboBox10.Items.Add("Plane Glass")
            ComboBox10.Items.Add("Modi Mirror")
            ComboBox10.Items.Add("Reflective Glass")
            ComboBox10.Items.Add("F. Blue Reflective Glass")
            ComboBox10.Items.Add("F. Brown Reflective Glass")
        ElseIf ComboBox9.SelectedItem = "6MM" Then
            ComboBox10.Items.Clear()
            ComboBox10.Items.Add("Plane Glass")
        ElseIf ComboBox9.SelectedItem = "8MM" Then
            ComboBox10.Items.Clear()
            ComboBox10.Items.Add("Plane Glass")
            ComboBox10.Items.Add("Brown Plane Glass")
        ElseIf ComboBox9.SelectedItem = "10MM" Then
            ComboBox10.Items.Clear()
            ComboBox10.Items.Add("Plane Glass")
        ElseIf ComboBox9.SelectedItem = "12MM" Then
            ComboBox10.Items.Clear()
            ComboBox10.Items.Add("Plane Glass")

        End If
    End Sub

    Private Sub ComboBox10_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox10.SelectedIndexChanged
        If ComboBox9.SelectedItem = "2MM" Then
            TextBox39.Text = "18"
        End If

        If ComboBox9.SelectedItem = "3MM" Then
            If ComboBox10.SelectedItem = "Plane Glass" Then
                TextBox39.Text = "28"
            Else
                TextBox39.Text = "40"
            End If
        End If

        If ComboBox9.SelectedItem = "3.5MM" Then
            If ComboBox10.SelectedItem = "White Figure Glass" Then
                TextBox39.Text = "31"
            ElseIf ComboBox10.SelectedItem = "Black Swastik Figure Glass" Then
                TextBox39.Text = "35"
            ElseIf ComboBox10.SelectedItem = "Black Kalakachi Figure Glass" Then
                TextBox39.Text = "34"
            ElseIf ComboBox10.SelectedItem = "Mirror" Then
                TextBox39.Text = "50"
            ElseIf ComboBox10.SelectedItem = "Reflective Glass" Then
                TextBox39.Text = "45"
            Else
                TextBox39.Text = "60"
            End If
        End If

        If ComboBox9.SelectedItem = "4MM" Then
            If ComboBox10.SelectedItem = "Plane Glass" Then
                TextBox39.Text = "37"
            End If
        End If

        If ComboBox9.SelectedItem = "4.5MM" Then
            If ComboBox10.SelectedItem = "Black Kalakachi Figure Glass" Then
                TextBox39.Text = "42"
            End If
        End If

        If ComboBox9.SelectedItem = "5MM" Then
            If ComboBox10.SelectedItem = "Plane Glass" Then
                TextBox39.Text = "45"
            ElseIf ComboBox10.SelectedItem = "Modi Mirror" Then
                TextBox39.Text = "78"
            ElseIf ComboBox10.SelectedItem = "Reflective Glass" Then
                TextBox39.Text = "58"
            ElseIf ComboBox10.SelectedItem = "F. Blue Reflective Glass" Then
                TextBox39.Text = "75"
            Else
                TextBox39.Text = "80"
            End If
        End If

        If ComboBox9.SelectedItem = "6MM" Then
            If ComboBox10.SelectedItem = "Plane Glass" Then
                TextBox39.Text = "58"
            End If
        End If

        If ComboBox9.SelectedItem = "8MM" Then
            If ComboBox10.SelectedItem = "Plane Glass" Then
                TextBox39.Text = "78"
            Else
                TextBox39.Text = "110"
            End If
        End If

        If ComboBox9.SelectedItem = "10MM" Then
            If ComboBox10.SelectedItem = "Plane Glass" Then
                TextBox39.Text = "95"
            End If
        End If

        If ComboBox9.SelectedItem = "12MM" Then
            If ComboBox10.SelectedItem = "Plane Glass" Then
                TextBox39.Text = "110"
            End If
        End If

    End Sub

    Private Sub ChangePriceToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ChangePriceToolStripMenuItem.Click
        ComboBox9.Visible = True
        ComboBox10.Visible = True
        TextBox39.Visible = True
        Button20.Visible = True

    End Sub

    Private Sub Button20_Click(sender As Object, e As EventArgs) Handles Button20.Click
        If ComboBox9.SelectedItem = "2MM" Then
            plane2mm = TextBox39.Text
        End If

        ComboBox9.Visible = False
        ComboBox10.Visible = False
        TextBox39.Visible = False
        Button20.Visible = False

    End Sub

    
End Class
