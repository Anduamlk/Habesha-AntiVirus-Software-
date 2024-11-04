<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Settsetup
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Settsetup))
        Panel1 = New Panel()
        Label3 = New Label()
        MyButton2 = New MyButton()
        Label1 = New Label()
        Label4 = New Label()
        PictureBox1 = New PictureBox()
        CheckBox1 = New CheckBox()
        CheckBox2 = New CheckBox()
        CheckBox3 = New CheckBox()
        MyButton1 = New MyButton()
        btnClose = New PictureBox()
        Panel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(btnClose, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = SystemColors.ControlLight
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(MyButton2)
        Panel1.Controls.Add(Label1)
        Panel1.Location = New Point(3, 50)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(603, 89)
        Panel1.TabIndex = 0
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Gadugi", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = SystemColors.ActiveCaptionText
        Label3.Location = New Point(29, 30)
        Label3.Name = "Label3"
        Label3.Size = New Size(246, 32)
        Label3.TabIndex = 8
        Label3.Text = "To enable Real-Time Protection to keep your " & vbCrLf & "Computer from harmful activites." & vbCrLf
        ' 
        ' MyButton2
        ' 
        MyButton2.BottomColor = Color.Black
        MyButton2.Font = New Font("Ebrima", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        MyButton2.ForeColor = SystemColors.ButtonFace
        MyButton2.Location = New Point(480, 15)
        MyButton2.Name = "MyButton2"
        MyButton2.Size = New Size(110, 40)
        MyButton2.TabIndex = 7
        MyButton2.Text = "Enable"
        MyButton2.TopColor = Color.ForestGreen
        MyButton2.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Wide Latin", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = SystemColors.ActiveCaptionText
        Label1.Location = New Point(25, 15)
        Label1.Name = "Label1"
        Label1.Size = New Size(226, 15)
        Label1.TabIndex = 1
        Label1.Text = "Real-Time Protection"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Wide Latin", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = SystemColors.ControlLight
        Label4.Location = New Point(47, 9)
        Label4.Name = "Label4"
        Label4.Size = New Size(150, 15)
        Label4.TabIndex = 2
        Label4.Text = "Syetm Setting"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(3, 2)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(38, 32)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 3
        PictureBox1.TabStop = False
        ' 
        ' CheckBox1
        ' 
        CheckBox1.AutoSize = True
        CheckBox1.Location = New Point(56, 175)
        CheckBox1.Name = "CheckBox1"
        CheckBox1.Size = New Size(153, 19)
        CheckBox1.TabIndex = 4
        CheckBox1.Text = "Start VPN Automaticaliy"
        CheckBox1.UseVisualStyleBackColor = True
        ' 
        ' CheckBox2
        ' 
        CheckBox2.AutoSize = True
        CheckBox2.Location = New Point(56, 219)
        CheckBox2.Name = "CheckBox2"
        CheckBox2.Size = New Size(119, 19)
        CheckBox2.TabIndex = 5
        CheckBox2.Text = "Scan every 2 hour"
        CheckBox2.UseVisualStyleBackColor = True
        ' 
        ' CheckBox3
        ' 
        CheckBox3.AutoSize = True
        CheckBox3.Location = New Point(56, 268)
        CheckBox3.Name = "CheckBox3"
        CheckBox3.Size = New Size(93, 19)
        CheckBox3.TabIndex = 6
        CheckBox3.Text = "Auto Update"
        CheckBox3.UseVisualStyleBackColor = True
        ' 
        ' MyButton1
        ' 
        MyButton1.BottomColor = Color.LightSeaGreen
        MyButton1.Font = New Font("Ebrima", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        MyButton1.ForeColor = SystemColors.ActiveCaptionText
        MyButton1.Location = New Point(245, 268)
        MyButton1.Name = "MyButton1"
        MyButton1.Size = New Size(86, 40)
        MyButton1.TabIndex = 8
        MyButton1.Text = "save"
        MyButton1.TopColor = Color.MediumBlue
        MyButton1.UseVisualStyleBackColor = True
        ' 
        ' btnClose
        ' 
        btnClose.Image = CType(resources.GetObject("btnClose.Image"), Image)
        btnClose.Location = New Point(559, 2)
        btnClose.Name = "btnClose"
        btnClose.Size = New Size(47, 33)
        btnClose.SizeMode = PictureBoxSizeMode.Zoom
        btnClose.TabIndex = 17
        btnClose.TabStop = False
        ' 
        ' Settsetup
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaptionText
        ClientSize = New Size(608, 318)
        Controls.Add(btnClose)
        Controls.Add(MyButton1)
        Controls.Add(CheckBox3)
        Controls.Add(CheckBox2)
        Controls.Add(CheckBox1)
        Controls.Add(PictureBox1)
        Controls.Add(Label4)
        Controls.Add(Panel1)
        ForeColor = SystemColors.Control
        FormBorderStyle = FormBorderStyle.None
        Name = "Settsetup"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Settsetup"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(btnClose, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents MyButton2 As MyButton
    Friend WithEvents Label4 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents CheckBox3 As CheckBox
    Friend WithEvents MyButton1 As MyButton
    Friend WithEvents btnClose As PictureBox
End Class
