<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        components = New ComponentModel.Container()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Timer1 = New Timer(components)
        Label5 = New Label()
        PictureBox1 = New PictureBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 60F, FontStyle.Bold)
        Label1.Location = New Point(83, 165)
        Label1.Name = "Label1"
        Label1.Size = New Size(137, 106)
        Label1.TabIndex = 0
        Label1.Text = "00"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 60F, FontStyle.Bold)
        Label2.Location = New Point(259, 165)
        Label2.Name = "Label2"
        Label2.Size = New Size(137, 106)
        Label2.TabIndex = 1
        Label2.Text = "00"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 30F, FontStyle.Italic)
        Label3.Location = New Point(147, 323)
        Label3.Name = "Label3"
        Label3.Size = New Size(181, 54)
        Label3.TabIndex = 2
        Label3.Text = "Domingo"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 20F)
        Label4.Location = New Point(104, 427)
        Label4.Name = "Label4"
        Label4.Size = New Size(276, 37)
        Label4.TabIndex = 3
        Label4.Text = "09 de marzo del 2026"
        ' 
        ' Timer1
        ' 
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 60F, FontStyle.Bold)
        Label5.Location = New Point(195, 165)
        Label5.Name = "Label5"
        Label5.Size = New Size(67, 106)
        Label5.TabIndex = 4
        Label5.Text = ":"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.face
        PictureBox1.Location = New Point(12, 12)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(469, 575)
        PictureBox1.SizeMode = PictureBoxSizeMode.AutoSize
        PictureBox1.TabIndex = 5
        PictureBox1.TabStop = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(494, 601)
        Controls.Add(Label2)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label1)
        Controls.Add(PictureBox1)
        Name = "Form1"
        SizeGripStyle = SizeGripStyle.Hide
        Text = "Reloj Digital"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label5 As Label
    Friend WithEvents PictureBox1 As PictureBox

End Class
