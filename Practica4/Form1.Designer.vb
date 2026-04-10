<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.minutos = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.horas = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dias = New System.Windows.Forms.Label()
        Me.fecha = New System.Windows.Forms.Label()
        Me.segundos = New System.Windows.Forms.Label()
        Me.Timer3 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.reset = New System.Windows.Forms.Button()
        Me.start = New System.Windows.Forms.Button()
        Me.tiempo = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'minutos
        '
        Me.minutos.AutoSize = True
        Me.minutos.BackColor = System.Drawing.SystemColors.WindowText
        Me.minutos.Font = New System.Drawing.Font("Segoe UI", 40.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.minutos.ForeColor = System.Drawing.Color.Red
        Me.minutos.Location = New System.Drawing.Point(223, 105)
        Me.minutos.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.minutos.Name = "minutos"
        Me.minutos.Size = New System.Drawing.Size(116, 89)
        Me.minutos.TabIndex = 2
        Me.minutos.Text = "00"
        '
        'Timer1
        '
        '
        'Timer2
        '
        Me.Timer2.Interval = 1000
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.ComboBox1)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Location = New System.Drawing.Point(391, 68)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(271, 236)
        Me.Panel1.TabIndex = 7
        Me.Panel1.Visible = False
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Blanco", "Rojo", "Azul", "Amarillo", "Verde"})
        Me.ComboBox1.Location = New System.Drawing.Point(52, 138)
        Me.ComboBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(160, 24)
        Me.ComboBox1.TabIndex = 2
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(12, 53)
        Me.Button1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(59, 46)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(47, 11)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(169, 25)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Configuraciones"
        '
        'horas
        '
        Me.horas.AutoSize = True
        Me.horas.BackColor = System.Drawing.SystemColors.WindowText
        Me.horas.Font = New System.Drawing.Font("Segoe UI", 40.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.horas.ForeColor = System.Drawing.Color.Red
        Me.horas.Location = New System.Drawing.Point(57, 105)
        Me.horas.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.horas.Name = "horas"
        Me.horas.Size = New System.Drawing.Size(116, 89)
        Me.horas.TabIndex = 0
        Me.horas.Text = "00"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.WindowText
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 40.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(169, 105)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 89)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = ":"
        '
        'dias
        '
        Me.dias.AutoSize = True
        Me.dias.BackColor = System.Drawing.SystemColors.WindowText
        Me.dias.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dias.ForeColor = System.Drawing.Color.Red
        Me.dias.Location = New System.Drawing.Point(140, 220)
        Me.dias.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.dias.Name = "dias"
        Me.dias.Size = New System.Drawing.Size(110, 39)
        Me.dias.TabIndex = 3
        Me.dias.Text = "Lunes"
        Me.dias.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'fecha
        '
        Me.fecha.AutoSize = True
        Me.fecha.BackColor = System.Drawing.SystemColors.WindowText
        Me.fecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fecha.ForeColor = System.Drawing.Color.Red
        Me.fecha.Location = New System.Drawing.Point(68, 266)
        Me.fecha.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.fecha.Name = "fecha"
        Me.fecha.Size = New System.Drawing.Size(243, 29)
        Me.fecha.TabIndex = 4
        Me.fecha.Text = "09 de marzo del 2026"
        Me.fecha.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'segundos
        '
        Me.segundos.AutoSize = True
        Me.segundos.Location = New System.Drawing.Point(269, 89)
        Me.segundos.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.segundos.Name = "segundos"
        Me.segundos.Size = New System.Drawing.Size(51, 17)
        Me.segundos.TabIndex = 8
        Me.segundos.Text = "Label3"
        '
        'Timer3
        '
        Me.Timer3.Interval = 1
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.reset)
        Me.Panel2.Controls.Add(Me.start)
        Me.Panel2.Controls.Add(Me.tiempo)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Location = New System.Drawing.Point(374, 220)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(271, 236)
        Me.Panel2.TabIndex = 12
        Me.Panel2.Visible = False
        '
        'reset
        '
        Me.reset.Location = New System.Drawing.Point(165, 167)
        Me.reset.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.reset.Name = "reset"
        Me.reset.Size = New System.Drawing.Size(75, 23)
        Me.reset.TabIndex = 3
        Me.reset.Text = "Reset"
        Me.reset.UseVisualStyleBackColor = True
        '
        'start
        '
        Me.start.Location = New System.Drawing.Point(35, 167)
        Me.start.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.start.Name = "start"
        Me.start.Size = New System.Drawing.Size(75, 23)
        Me.start.TabIndex = 2
        Me.start.Text = "Start"
        Me.start.UseVisualStyleBackColor = True
        '
        'tiempo
        '
        Me.tiempo.AutoSize = True
        Me.tiempo.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tiempo.Location = New System.Drawing.Point(29, 94)
        Me.tiempo.Name = "tiempo"
        Me.tiempo.Size = New System.Drawing.Size(196, 39)
        Me.tiempo.TabIndex = 1
        Me.tiempo.Text = "00:00:00.00"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(69, 26)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(125, 25)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Cronometro"
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Button3)
        Me.Panel3.Controls.Add(Me.Button2)
        Me.Panel3.Controls.Add(Me.Label5)
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Location = New System.Drawing.Point(59, 82)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(272, 222)
        Me.Panel3.TabIndex = 13
        Me.Panel3.Visible = False
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = Global.Practica4.My.Resources.Resources.icono_temp
        Me.PictureBox4.Location = New System.Drawing.Point(184, 320)
        Me.PictureBox4.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(28, 28)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 14
        Me.PictureBox4.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.Practica4.My.Resources.Resources.crono
        Me.PictureBox3.Location = New System.Drawing.Point(239, 320)
        Me.PictureBox3.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(28, 28)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 9
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.Practica4.My.Resources.Resources.config
        Me.PictureBox2.Location = New System.Drawing.Point(293, 320)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(31, 28)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 6
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Practica4.My.Resources.Resources.img
        Me.PictureBox1.Location = New System.Drawing.Point(11, 10)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(385, 407)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(67, 39)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(145, 25)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Temporizador"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(89, 83)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(102, 39)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "00:00"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(165, 165)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(76, 28)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "Start"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(26, 165)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(76, 28)
        Me.Button3.TabIndex = 4
        Me.Button3.Text = "5 min"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(411, 428)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.segundos)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.fecha)
        Me.Controls.Add(Me.dias)
        Me.Controls.Add(Me.minutos)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.horas)
        Me.Controls.Add(Me.PictureBox1)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "Form1"
        Me.Text = "Reloj Digital"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents minutos As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Timer2 As Timer
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents horas As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents dias As Label
    Friend WithEvents fecha As Label
    Friend WithEvents segundos As Label
    Friend WithEvents Timer3 As Timer
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents reset As Button
    Friend WithEvents start As Button
    Friend WithEvents tiempo As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
End Class
