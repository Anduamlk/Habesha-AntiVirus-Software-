<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Home
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Home))
        Panel1 = New Panel()
        Label2 = New Label()
        MyButton2 = New MyButton()
        Label1 = New Label()
        PictureBox1 = New PictureBox()
        Panel3 = New Panel()
        PictureBox2 = New PictureBox()
        Label4 = New Label()
        Panel4 = New Panel()
        Label3 = New Label()
        PictureBox3 = New PictureBox()
        Panel5 = New Panel()
        Label5 = New Label()
        PictureBox4 = New PictureBox()
        Panel6 = New Panel()
        Label6 = New Label()
        PictureBox5 = New PictureBox()
        Label8 = New Label()
        Panel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel3.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        Panel4.SuspendLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        Panel5.SuspendLayout()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        Panel6.SuspendLayout()
        CType(PictureBox5, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.CadetBlue
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(MyButton2)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(PictureBox1)
        Panel1.Location = New Point(54, 74)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(811, 121)
        Panel1.TabIndex = 3
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(95, 46)
        Label2.Name = "Label2"
        Label2.Size = New Size(547, 45)
        Label2.TabIndex = 7
        Label2.Text = resources.GetString("Label2.Text")
        ' 
        ' MyButton2
        ' 
        MyButton2.BottomColor = Color.Black
        MyButton2.Font = New Font("Wide Latin", 9.75F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        MyButton2.ForeColor = SystemColors.ButtonFace
        MyButton2.Location = New Point(374, 37)
        MyButton2.Name = "MyButton2"
        MyButton2.Size = New Size(116, 32)
        MyButton2.TabIndex = 6
        MyButton2.Text = "Enable"
        MyButton2.TopColor = Color.ForestGreen
        MyButton2.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(95, 12)
        Label1.Name = "Label1"
        Label1.Size = New Size(175, 19)
        Label1.TabIndex = 6
        Label1.Text = "Enable / Disable Firewall"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(3, 3)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(86, 115)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.CadetBlue
        Panel3.Controls.Add(PictureBox2)
        Panel3.Controls.Add(Label4)
        Panel3.Location = New Point(6, 219)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(207, 121)
        Panel3.TabIndex = 6
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(37, 12)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(100, 59)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 7
        PictureBox2.TabStop = False
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Elephant", 11.9999981F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(23, 86)
        Label4.Name = "Label4"
        Label4.Size = New Size(114, 21)
        Label4.TabIndex = 6
        Label4.Text = "Scan Quick"
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = Color.CadetBlue
        Panel4.Controls.Add(Label3)
        Panel4.Controls.Add(PictureBox3)
        Panel4.Location = New Point(235, 219)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(207, 121)
        Panel4.TabIndex = 7
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Elephant", 11.9999981F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(46, 86)
        Label3.Name = "Label3"
        Label3.Size = New Size(123, 21)
        Label3.TabIndex = 8
        Label3.Text = "System Scan"
        ' 
        ' PictureBox3
        ' 
        PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), Image)
        PictureBox3.Location = New Point(34, 3)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(126, 68)
        PictureBox3.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox3.TabIndex = 7
        PictureBox3.TabStop = False
        ' 
        ' Panel5
        ' 
        Panel5.BackColor = Color.CadetBlue
        Panel5.Controls.Add(Label5)
        Panel5.Controls.Add(PictureBox4)
        Panel5.Location = New Point(461, 219)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(184, 121)
        Panel5.TabIndex = 8
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Elephant", 9.75F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(-1, 86)
        Label5.Name = "Label5"
        Label5.Size = New Size(185, 17)
        Label5.TabIndex = 9
        Label5.Text = "Computer Performance"
        ' 
        ' PictureBox4
        ' 
        PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), Image)
        PictureBox4.Location = New Point(66, 12)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(50, 40)
        PictureBox4.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox4.TabIndex = 7
        PictureBox4.TabStop = False
        ' 
        ' Panel6
        ' 
        Panel6.BackColor = Color.CadetBlue
        Panel6.Controls.Add(Label6)
        Panel6.Controls.Add(PictureBox5)
        Panel6.Location = New Point(655, 219)
        Panel6.Name = "Panel6"
        Panel6.Size = New Size(207, 121)
        Panel6.TabIndex = 9
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Elephant", 11.9999981F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(56, 89)
        Label6.Name = "Label6"
        Label6.Size = New Size(59, 21)
        Label6.TabIndex = 9
        Label6.Text = "VPN"
        ' 
        ' PictureBox5
        ' 
        PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), Image)
        PictureBox5.Location = New Point(23, 12)
        PictureBox5.Name = "PictureBox5"
        PictureBox5.Size = New Size(142, 74)
        PictureBox5.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox5.TabIndex = 7
        PictureBox5.TabStop = False
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.BackColor = SystemColors.ActiveCaptionText
        Label8.Font = New Font("Elephant", 15.7499981F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label8.ForeColor = Color.CornflowerBlue
        Label8.Location = New Point(295, 18)
        Label8.Name = "Label8"
        Label8.Size = New Size(237, 27)
        Label8.TabIndex = 6
        Label8.Text = "You Are Protected!!"
        ' 
        ' Home
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaptionText
        Controls.Add(Label8)
        Controls.Add(Panel6)
        Controls.Add(Panel5)
        Controls.Add(Panel4)
        Controls.Add(Panel3)
        Controls.Add(Panel1)
        ForeColor = SystemColors.ActiveCaptionText
        Name = "Home"
        Size = New Size(865, 548)
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        Panel4.ResumeLayout(False)
        Panel4.PerformLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        Panel5.ResumeLayout(False)
        Panel5.PerformLayout()
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        Panel6.ResumeLayout(False)
        Panel6.PerformLayout()
        CType(PictureBox5, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Panel1 As Panel
    Friend WithEvents MyButton2 As MyButton
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Panel4 As Panel
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Panel5 As Panel
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents Panel6 As Panel
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label8 As Label

End Class
