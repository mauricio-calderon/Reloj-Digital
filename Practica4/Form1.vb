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

    Private Sub start_Click(sender As Object, e As EventArgs) Handles start.Click
        If boton_start = False Then
            Timer3.Enabled = True
            boton_start = True
            start.Text = "Stop"
        ElseIf boton_start = True Then
            Timer3.Enabled = False
            boton_start = False
            start.Text = "Start"
        End If
    End Sub

    Private Sub reset_Click(sender As Object, e As EventArgs) Handles reset.Click
        tiempo_crono = 0
        Timer3.Enabled = False
        tiempo.Text = "0"
    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        tiempo_crono = tiempo_crono + 1
        tiempo.Text = tiempo_crono.ToString()
    End Sub
End Class
