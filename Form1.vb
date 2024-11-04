Imports System.Runtime.InteropServices
Imports System.Windows.Forms
Imports System.Diagnostics

Public Class Form1


    Private Sub PictureBox6_Click(sender As Object, e As EventArgs)
        Exitpop.ShowDialog()
    End Sub


    Private Sub PictureBox9_Click(sender As Object, e As EventArgs) Handles PictureBox9.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub MyButton1_Click(sender As Object, e As EventArgs)



    End Sub

    Private Sub MyButton2_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub Form1_MouseDown(sender As Object, e As MouseEventArgs) Handles Me.MouseDown, Panel1.MouseDown

    End Sub



    Private Sub MyButton8_Click(sender As Object, e As EventArgs) Handles MyButton8.Click
        Paypreim1.BringToFront()

    End Sub

    Private Sub Panel6_MouseHover(sender As Object, e As EventArgs)

    End Sub

    Private Sub Panel6_MouseLeave(sender As Object, e As EventArgs)

    End Sub

    Private Sub Panel6_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub MyButton1_Click_1(sender As Object, e As EventArgs)


    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Exitpop.ShowDialog()

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles ScanButton.Click
        Malware2.BringToFront()
        MyFunction.ScanButton()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles HomeButton.Click
        MyFunction.HomeButton()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles PrivButton.Click

        MyFunction.PrivButton()
    End Sub

    Private Sub MyButton2_Click_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub MyButton3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub StatButton_Click(sender As Object, e As EventArgs) Handles StatButton.Click
        Status1.BringToFront()
        MyFunction.StatButton()
    End Sub

    Private Sub Base1_Load(sender As Object, e As EventArgs) Handles Base1.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Admin3.BringToFront()

    End Sub
End Class
