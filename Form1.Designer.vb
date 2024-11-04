<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        HeadPanel = New Panel()
        Button1 = New Button()
        Button10 = New Button()
        Button3 = New Button()
        Label1 = New Label()
        Panel1 = New Panel()
        PictureBox9 = New PictureBox()
        MyButton8 = New MyButton()
        Panel2 = New Panel()
        ScanButton = New Button()
        PrivButton = New Button()
        StatButton = New Button()
        HomeButton = New Button()
        Malware2 = New Malware()
        Protect1 = New Protect()
        Base1 = New Base()
        Paypreim1 = New Paypreim()
        Status1 = New Status()
        Users1 = New Users()
        Login2 = New Login()
        Admin3 = New Admin()
        HeadPanel.SuspendLayout()
        CType(PictureBox9, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' HeadPanel
        ' 
        HeadPanel.BackColor = Color.FromArgb(CByte(43), CByte(53), CByte(70))
        HeadPanel.Controls.Add(Button1)
        HeadPanel.Controls.Add(Button10)
        HeadPanel.Controls.Add(Button3)
        HeadPanel.Controls.Add(Label1)
        HeadPanel.Controls.Add(Panel1)
        HeadPanel.Controls.Add(PictureBox9)
        HeadPanel.Controls.Add(MyButton8)
        HeadPanel.Dock = DockStyle.Top
        HeadPanel.ForeColor = SystemColors.ButtonFace
        HeadPanel.Location = New Point(0, 0)
        HeadPanel.Name = "HeadPanel"
        HeadPanel.Size = New Size(978, 52)
        HeadPanel.TabIndex = 1
        ' 
        ' Button1
        ' 
        Button1.FlatStyle = FlatStyle.Popup
        Button1.Font = New Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.ForeColor = Color.White
        Button1.Image = CType(resources.GetObject("Button1.Image"), Image)
        Button1.Location = New Point(882, 2)
        Button1.Name = "Button1"
        Button1.Size = New Size(22, 26)
        Button1.TabIndex = 21
        Button1.TextAlign = Drawing.ContentAlignment.MiddleRight
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button10
        ' 
        Button10.FlatStyle = FlatStyle.Popup
        Button10.Font = New Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button10.ForeColor = Color.White
        Button10.Image = CType(resources.GetObject("Button10.Image"), Image)
        Button10.Location = New Point(851, -1)
        Button10.Name = "Button10"
        Button10.Size = New Size(35, 28)
        Button10.TabIndex = 20
        Button10.TextAlign = Drawing.ContentAlignment.MiddleRight
        Button10.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.FlatStyle = FlatStyle.Popup
        Button3.Font = New Font("Segoe UI", 8F, FontStyle.Bold)
        Button3.ForeColor = Color.White
        Button3.Location = New Point(938, 0)
        Button3.Name = "Button3"
        Button3.Size = New Size(37, 32)
        Button3.TabIndex = 11
        Button3.Text = "X"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Lucida Fax", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.White
        Label1.Location = New Point(1, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(281, 32)
        Label1.TabIndex = 10
        Label1.Text = "Habesha Antivirus"
        ' 
        ' Panel1
        ' 
        Panel1.Location = New Point(0, 64)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(93, 587)
        Panel1.TabIndex = 9
        ' 
        ' PictureBox9
        ' 
        PictureBox9.Image = CType(resources.GetObject("PictureBox9.Image"), Image)
        PictureBox9.Location = New Point(910, 6)
        PictureBox9.Name = "PictureBox9"
        PictureBox9.Size = New Size(22, 22)
        PictureBox9.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox9.TabIndex = 8
        PictureBox9.TabStop = False
        ' 
        ' MyButton8
        ' 
        MyButton8.BottomColor = Color.Black
        MyButton8.Font = New Font("Elephant", 8.999999F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        MyButton8.ForeColor = SystemColors.ButtonFace
        MyButton8.Location = New Point(671, 3)
        MyButton8.Name = "MyButton8"
        MyButton8.Size = New Size(165, 23)
        MyButton8.TabIndex = 7
        MyButton8.Text = "Go Premium"
        MyButton8.TopColor = Color.FromArgb(CByte(192), CByte(192), CByte(0))
        MyButton8.UseVisualStyleBackColor = True
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.FromArgb(CByte(43), CByte(53), CByte(70))
        Panel2.Controls.Add(ScanButton)
        Panel2.Controls.Add(PrivButton)
        Panel2.Controls.Add(StatButton)
        Panel2.Controls.Add(HomeButton)
        Panel2.Location = New Point(0, 55)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(69, 593)
        Panel2.TabIndex = 13
        ' 
        ' ScanButton
        ' 
        ScanButton.FlatStyle = FlatStyle.Popup
        ScanButton.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ScanButton.ForeColor = Color.White
        ScanButton.Image = CType(resources.GetObject("ScanButton.Image"), Image)
        ScanButton.ImageAlign = Drawing.ContentAlignment.TopCenter
        ScanButton.Location = New Point(2, 86)
        ScanButton.Name = "ScanButton"
        ScanButton.Size = New Size(64, 81)
        ScanButton.TabIndex = 18
        ScanButton.Text = "Scan"
        ScanButton.TextAlign = Drawing.ContentAlignment.BottomCenter
        ScanButton.UseVisualStyleBackColor = True
        ' 
        ' PrivButton
        ' 
        PrivButton.FlatStyle = FlatStyle.Popup
        PrivButton.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        PrivButton.ForeColor = Color.White
        PrivButton.Image = CType(resources.GetObject("PrivButton.Image"), Image)
        PrivButton.ImageAlign = Drawing.ContentAlignment.TopCenter
        PrivButton.Location = New Point(3, 173)
        PrivButton.Name = "PrivButton"
        PrivButton.Size = New Size(63, 82)
        PrivButton.TabIndex = 17
        PrivButton.Text = "Privacy"
        PrivButton.TextAlign = Drawing.ContentAlignment.BottomCenter
        PrivButton.UseVisualStyleBackColor = True
        ' 
        ' StatButton
        ' 
        StatButton.FlatStyle = FlatStyle.Popup
        StatButton.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        StatButton.ForeColor = Color.White
        StatButton.Image = CType(resources.GetObject("StatButton.Image"), Image)
        StatButton.ImageAlign = Drawing.ContentAlignment.TopCenter
        StatButton.Location = New Point(0, 269)
        StatButton.Name = "StatButton"
        StatButton.Size = New Size(66, 70)
        StatButton.TabIndex = 16
        StatButton.Text = "Status"
        StatButton.TextAlign = Drawing.ContentAlignment.BottomCenter
        StatButton.UseVisualStyleBackColor = True
        ' 
        ' HomeButton
        ' 
        HomeButton.FlatStyle = FlatStyle.Popup
        HomeButton.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        HomeButton.ForeColor = Color.White
        HomeButton.Image = CType(resources.GetObject("HomeButton.Image"), Image)
        HomeButton.ImageAlign = Drawing.ContentAlignment.TopCenter
        HomeButton.Location = New Point(0, 2)
        HomeButton.Name = "HomeButton"
        HomeButton.Size = New Size(66, 78)
        HomeButton.TabIndex = 15
        HomeButton.Text = "Home"
        HomeButton.TextAlign = Drawing.ContentAlignment.BottomCenter
        HomeButton.UseVisualStyleBackColor = True
        ' 
        ' Malware2
        ' 
        Malware2.BackColor = Color.FromArgb(CByte(46), CByte(54), CByte(77))
        Malware2.BorderStyle = BorderStyle.FixedSingle
        Malware2.Location = New Point(72, 55)
        Malware2.Name = "Malware2"
        Malware2.Size = New Size(906, 593)
        Malware2.TabIndex = 28
        ' 
        ' Protect1
        ' 
        Protect1.BackColor = Color.FromArgb(CByte(46), CByte(54), CByte(77))
        Protect1.BorderStyle = BorderStyle.FixedSingle
        Protect1.Location = New Point(72, 56)
        Protect1.Name = "Protect1"
        Protect1.Size = New Size(903, 592)
        Protect1.TabIndex = 29
        ' 
        ' Base1
        ' 
        Base1.BackColor = Color.FromArgb(CByte(46), CByte(54), CByte(77))
        Base1.BorderStyle = BorderStyle.FixedSingle
        Base1.Location = New Point(75, 54)
        Base1.Name = "Base1"
        Base1.Size = New Size(903, 593)
        Base1.TabIndex = 16
        ' 
        ' Paypreim1
        ' 
        Paypreim1.BackColor = Color.FromArgb(CByte(46), CByte(54), CByte(77))
        Paypreim1.BorderStyle = BorderStyle.FixedSingle
        Paypreim1.Location = New Point(72, 55)
        Paypreim1.Name = "Paypreim1"
        Paypreim1.Size = New Size(903, 593)
        Paypreim1.TabIndex = 21
        ' 
        ' Status1
        ' 
        Status1.BackColor = Color.FromArgb(CByte(46), CByte(54), CByte(77))
        Status1.BorderStyle = BorderStyle.FixedSingle
        Status1.Location = New Point(72, 56)
        Status1.Name = "Status1"
        Status1.Size = New Size(901, 591)
        Status1.TabIndex = 21
        ' 
        ' Users1
        ' 
        Users1.BackColor = Color.FromArgb(CByte(46), CByte(54), CByte(77))
        Users1.BorderStyle = BorderStyle.FixedSingle
        Users1.Location = New Point(151, 100)
        Users1.Name = "Users1"
        Users1.Size = New Size(735, 419)
        Users1.TabIndex = 22
        ' 
        ' Login2
        ' 
        Login2.BackColor = Color.FromArgb(CByte(46), CByte(54), CByte(77))
        Login2.BorderStyle = BorderStyle.FixedSingle
        Login2.Location = New Point(151, 100)
        Login2.Name = "Login2"
        Login2.Size = New Size(735, 419)
        Login2.TabIndex = 31
        ' 
        ' Admin3
        ' 
        Admin3.BackColor = Color.FromArgb(CByte(46), CByte(54), CByte(77))
        Admin3.BorderStyle = BorderStyle.Fixed3D
        Admin3.Location = New Point(151, 102)
        Admin3.Name = "Admin3"
        Admin3.Size = New Size(707, 282)
        Admin3.TabIndex = 32
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(46), CByte(54), CByte(77))
        ClientSize = New Size(978, 649)
        Controls.Add(Panel2)
        Controls.Add(HeadPanel)
        Controls.Add(Base1)
        Controls.Add(Malware2)
        Controls.Add(Protect1)
        Controls.Add(Paypreim1)
        Controls.Add(Status1)
        Controls.Add(Users1)
        Controls.Add(Login2)
        Controls.Add(Admin3)
        ForeColor = SystemColors.ButtonFace
        FormBorderStyle = FormBorderStyle.None
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form1"
        HeadPanel.ResumeLayout(False)
        HeadPanel.PerformLayout()
        CType(PictureBox9, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        ResumeLayout(False)
    End Sub
    Friend WithEvents HeadPanel As Panel
    Friend WithEvents MyButton8 As MyButton
    Friend WithEvents PictureBox9 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Button3 As Button
    Friend WithEvents HomeButton As Button
    Friend WithEvents ScanButton As Button
    Friend WithEvents PrivButton As Button
    Friend WithEvents StatButton As Button
    Friend WithEvents Button10 As Button
    Friend WithEvents Malware2 As Malware
    Friend WithEvents Protect1 As Protect
    Friend WithEvents Base1 As Base
    Friend WithEvents Paypreim1 As Paypreim
    Friend WithEvents Status1 As Status
    Friend WithEvents Button1 As Button
    Friend WithEvents Users1 As Users
    Friend WithEvents Login2 As Login
    Friend WithEvents Admin3 As Admin

End Class
