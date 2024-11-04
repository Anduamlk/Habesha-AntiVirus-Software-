<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
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
        MyButton1 = New MyButton()
        SuspendLayout()
        ' 
        ' MyButton1
        ' 
        MyButton1.BottomColor = Color.Orange
        MyButton1.Location = New Point(415, 64)
        MyButton1.Name = "MyButton1"
        MyButton1.Size = New Size(75, 23)
        MyButton1.TabIndex = 0
        MyButton1.Text = "MyButton1"
        MyButton1.TopColor = Color.LightGreen
        MyButton1.UseVisualStyleBackColor = True
        ' 
        ' Main
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaptionText
        Controls.Add(MyButton1)
        Name = "Main"
        Size = New Size(865, 548)
        ResumeLayout(False)
    End Sub

    Friend WithEvents MyButton1 As MyButton

End Class
