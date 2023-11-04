Public Class Form1
    Dim random As New Random()
    Dim numeroSecreto As Integer = random.Next(100, 1000)
    Dim intentosRestantes As Integer = 10

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ReiniciarJuego()
    End Sub

    Private Sub ReiniciarJuego()
        random = New Random()
        numeroSecreto = random.Next(100, 1000)
        intentosRestantes = 10
        txtnumero.Text = ""
        lblResultado.Text = ""
        lblIntentos.Text = "Intentos restantes: " & intentosRestantes
    End Sub

    Private Sub BtnConfirmar_Click(sender As Object, e As EventArgs) Handles btnconfirmar.Click
        If intentosRestantes > 0 Then
            Try
                Dim numeroIngresado As Integer = Integer.Parse(txtnumero.Text)
                If numeroIngresado > 99 And numeroIngresado < 1000 Then
                    If numeroIngresado = numeroSecreto Then
                        lblResultado.Text = "¡Felicidades! ¡Has adivinado el número!"
                        intentosRestantes = 0
                    ElseIf numeroIngresado < numeroSecreto Then
                        lblResultado.Text = "El número secreto es mayor."
                        intentosRestantes -= 1
                    Else
                        lblResultado.Text = "El número secreto es menor."
                        intentosRestantes -= 1
                    End If
                    lblIntentos.Text = "Intentos restantes: " & intentosRestantes
                    If intentosRestantes = 0 Then
                        MessageBox.Show("¡Has agotado tus intentos! El número secreto era " & numeroSecreto & ".")
                        ReiniciarJuego()
                    End If
                Else
                    MessageBox.Show("Por favor, ingrese un número de 3 cifras.")
                End If
            Catch ex As Exception
                MessageBox.Show("Por favor, ingrese un número válido.")
            End Try
        End If
    End Sub

    Private Sub BtnReiniciar_Click(sender As Object, e As EventArgs) Handles btnreiniciar.Click
        ReiniciarJuego()
    End Sub

    Private Sub btnminizar_Click(sender As Object, e As EventArgs) Handles btnminizar.Click
        Me.WindowState = FormWindowState.Minimized

    End Sub

    Private Sub btncerrar_Click(sender As Object, e As EventArgs) Handles btncerrar.Click
        Me.Close()
    End Sub
End Class
