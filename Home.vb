Public Class Home
    Friend Shared Sub BringToFont()
        Throw New NotImplementedException()
    End Sub
    Dim isActive As Boolean = False
    Private Sub Home_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub MyButton2_Click(sender As Object, e As EventArgs) Handles MyButton2.Click
        If isActive = False Then
            isActive = True
            MyButton2.Text = "Disable"
            MyButton2.BottomColor = Color.Red
            MyButton2.TopColor = Color.DarkRed

        ElseIf isActive = False Then
            isActive = False
            MyButton2.Text = "Enable"
            MyButton2.BottomColor = Color.DarkGray
            MyButton2.TopColor = Color.Blue





        End If
    End Sub
End Class
