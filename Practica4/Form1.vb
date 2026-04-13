Public Class Form1
    Dim formato As Boolean = True
    Dim boton_start As Boolean = False
    Dim tiempo_crono As Integer = 0

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Iniciar los timers
        Timer1.Start()
        Timer2.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ' Crear una variable, le asigna un valor, el valor es la fecha del dia de hoy convertida a string
        ' en el formato de "dd 'de' MMMM 'del' yyyy" [dd- numero de dia, MMMM- el mes en texto, yyyy- para el año]
        Dim Date_o = DateTime.Now.ToString("dd 'de' MMMM 'del' yyyy")
        Dim Day_o = DateTime.Now.ToString("dddd")
        Dim Time_o As String = ""


        ' Este es el formato de 24 h
        If formato = True Then
            Time_o = DateTime.Now.ToString("HH:mm:ss")
        ElseIf formato = False Then
            Time_o = DateTime.Now.ToString("hh:mm:ss")
        End If

        Dim Time_mod = Time_o.Split(":")
        horas.Text = Time_mod(0)
        minutos.Text = Time_mod(1)
        segundos.Text = Time_mod(2)
        dias.Text = Day_o
        dias.Text = Day_o
        fecha.Text = Date_o
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        If Label1.Text = ":" Then
            Label1.Text = ""
        ElseIf Label1.Text = "" Then
            Label1.Text = ":"
        End If
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        If Panel1.Visible = False Then
            Panel1.Visible = True
        ElseIf Panel1.Visible = True Then
            Panel1.Visible = False
        End If
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Dim color_texto As String = ComboBox1.SelectedItem.ToString()
        If color_texto = "Blanco" Then
            horas.ForeColor = Color.White
            minutos.ForeColor = Color.White
            Label1.ForeColor = Color.White
            dias.ForeColor = Color.White
            fecha.ForeColor = Color.White
            segundos.ForeColor = Color.White
        ElseIf color_texto = "Rojo" Then
            horas.ForeColor = Color.Red
            minutos.ForeColor = Color.Red
            Label1.ForeColor = Color.Red
            dias.ForeColor = Color.Red
            fecha.ForeColor = Color.Red
            segundos.ForeColor = Color.Red
        ElseIf color_texto = "Azul" Then
            horas.ForeColor = Color.Blue
            minutos.ForeColor = Color.Blue
            Label1.ForeColor = Color.Blue
            dias.ForeColor = Color.Blue
            fecha.ForeColor = Color.Blue
        ElseIf color_texto = "Amarillo" Then
            horas.ForeColor = Color.Yellow
            minutos.ForeColor = Color.Yellow
            Label1.ForeColor = Color.Yellow
            dias.ForeColor = Color.Yellow
            fecha.ForeColor = Color.Yellow
        ElseIf color_texto = "Verde" Then
            horas.ForeColor = Color.Green
            minutos.ForeColor = Color.Green
            Label1.ForeColor = Color.Green
            dias.ForeColor = Color.Green
            fecha.ForeColor = Color.Green
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If formato = True Then
            Button1.Text = "12h"
            formato = False
        ElseIf formato = False Then
            Button1.Text = "24h"
            formato = True
        End If
    End Sub

    'Codigo para el cronometro 

    Private startTime As DateTime
    Private elapsed As TimeSpan = TimeSpan.Zero

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick

        Dim current = elapsed + (DateTime.Now - startTime)
        tiempo.Text = current.ToString("hh\:mm\:ss\.ff")

    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        If Panel2.Visible = False Then
            Panel2.Visible = True
        ElseIf Panel2.Visible = True Then
            Panel2.Visible = False
        End If
    End Sub

    Private Sub start_Click_1(sender As Object, e As EventArgs) Handles start.Click
        If boton_start = False Then
            Timer3.Enabled = True
            boton_start = True
            start.Text = "Stop"
            startTime = DateTime.Now
        ElseIf boton_start = True Then
            Timer3.Enabled = False
            boton_start = False
            start.Text = "Start"
            elapsed += DateTime.Now - startTime
        End If
    End Sub

    Private Sub reset_Click_1(sender As Object, e As EventArgs) Handles reset.Click
        elapsed = TimeSpan.Zero
        Timer3.Enabled = False
        tiempo.Text = "00:00:00.00"
        boton_start = False
        start.Text = "Start"
    End Sub

    'Codigo del temporizador


    Private tiempoRestante As TimeSpan = TimeSpan.Zero
    Private temporizadorActivo As Boolean = False


    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        If Panel3.Visible = True Then
            Panel3.Visible = False
        ElseIf Panel3.Visible = False Then
            Panel3.Visible = True
        End If
    End Sub

    Private Sub Timer4_Tick(sender As Object, e As EventArgs) Handles Timer4.Tick

        If tiempoRestante.TotalMilliseconds > 0 Then
            tiempoRestante = tiempoRestante.Subtract(TimeSpan.FromMilliseconds(Timer1.Interval))
            Label5.Text = tiempoRestante.ToString("mm\:ss")
        Else
            ' Tiempo terminado
            Timer4.Enabled = False
            temporizadorActivo = False
            tiempoRestante = TimeSpan.Zero
            Label5.Text = "00:00"
            Button2.Text = "Start"

            MessageBox.Show("⏰ ¡Tiempo terminado!", "Temporizador",
                        MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        tiempoRestante = tiempoRestante.Add(TimeSpan.FromMinutes(5))
        Label5.Text = tiempoRestante.ToString("mm\:ss")

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        tiempoRestante = tiempoRestante.Add(TimeSpan.FromMinutes(1))
        Label5.Text = tiempoRestante.ToString("mm\:ss")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        If tiempoRestante = TimeSpan.Zero Then
            MessageBox.Show("Agrega tiempo primero.", "Aviso",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        If temporizadorActivo = False Then
            Timer4.Enabled = True
            temporizadorActivo = True
            Button2.Text = "Stop"
        Else
            Timer4.Enabled = False
            temporizadorActivo = False
            Button2.Text = "Start"
        End If

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

        Timer4.Enabled = False
        tiempoRestante = TimeSpan.Zero
        temporizadorActivo = False
        Label5.Text = "00:00"
        Button2.Text = "Start"

    End Sub


End Class
