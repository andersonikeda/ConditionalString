Public Class Form1
    Private Sub btnVerificar_Click(sender As Object, e As EventArgs) Handles btnVerificar.Click

        Dim nome1 As String = txtNome1.Text
        Dim nome2 As String = txtNome2.Text

        If nome1 = nome2 Then
            MessageBox.Show("Os nomes são iguais, Nome: " & nome1)
        Else
            MessageBox.Show("Os nomes são diferentes, Nome1: " & nome1 & " - Nome2: " & nome2)
        End If

    End Sub

    Private Sub btnVerificaNum_Click(sender As Object, e As EventArgs) Handles btnVerificaNum.Click
        Dim num1 As Integer
        Dim num2 As Integer

        Try
            num1 = txtNum1.Text
            num2 = txtNum2.Text
        Catch ex As Exception
            MessageBox.Show("Valores não são números!", "Erro")
            Exit Sub
        End Try

        If num1 = num2 Then
            MessageBox.Show("Os números são iguais, número: " & num1)
        Else
            MessageBox.Show("Os números são diferentes, número 1:" & num1 & " - número 2:" & num2)
        End If

    End Sub
End Class
