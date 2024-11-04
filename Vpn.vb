Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel
Imports System.Environment.SpecialFolder
Imports System.Environment.SpecialFolderOption



Public Class Vpn
    Dim username As String
    Dim password As String
    Dim host As String
    Private Sub btnClose_Click(sender As Object, e As EventArgs)
        Hide

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        username = "FreeVPN"
        host = "83.170.115.92"
        password = "America"
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        username = "FreeOpen"
        host = "108.163.169.44"
        password = "Germany"
    End Sub

    <Obsolete>
    Private Sub MyButton2_Click(sender As Object, e As EventArgs) Handles MyButton2.Click
        If Not IO.Directory.Exists(System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\VPNconnector") Then
            IO.Directory.CreateDirectory(System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\VPNconnector")

        End If
        IO.File.WriteAllText(System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\VPNconnector" & "Connection.pbk", "[VPN]" & vbNewLine & "MEDIArastapi" & "port=VPN2-0" & vbNewLine & "Device=WAN miniport (Ikv2)" & vbNewLine & "DEVICE=vpn" & vbNewLine & "PhoneNumber" & host)
        IO.File.WriteAllText(System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\VPNconnector" & "Connection.bat", "rasdial" & username & "" & password & "/PhoneBook" & "" & System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\VPNconnector" & "Connection.pbk" & "")
        Dim connect As System.Diagnostics.Process
        connect = New System.Diagnostics.Process()
        connect.StartInfo.FileName = System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\VPNconnector" & "Connection.bat"
        connect.StartInfo.WindowStyle = ProcessWindowStyle.Normal
        connect.Start()
        connect.WaitForExit()

        If connect.ExitCode Then
            Conn.Text = " VPN Connected - Your IP Address is" & host
            Conn.ForeColor = Color.Green
        End If
    End Sub

    Private Sub MyButton1_Click(sender As Object, e As EventArgs) Handles MyButton1.Click
        IO.File.WriteAllText(System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\VPNconnector" & "Disconnection.bat", "rasdial/d")
        Dim connect As System.Diagnostics.Process
        connect = New System.Diagnostics.Process()
        connect.StartInfo.FileName = System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\VPNconnector" & "Disconnection.bat"
        connect.StartInfo.WindowStyle = ProcessWindowStyle.Normal
        connect.Start()
        connect.WaitForExit()

        Conn.Text = "VPN Disonnected to Selected Your IP Address"
        Conn.ForeColor = Color.Red

    End Sub

    Private Sub Conn_Click(sender As Object, e As EventArgs) Handles Conn.Click

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs)
        Hide()
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        Me.Hide()
    End Sub
End Class