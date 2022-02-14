Public Class pontuacao
    Private Sub pontuacao_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        resultado = (pontuacao10 + 0)
        Label5.Text = resultado

        If (resultado <= 75) Then
            Label1.Text = ("poxa não foi dessa vez, mas tente novamente")
        ElseIf (resultado <= 150) Then
            Label1.Text = ("incrivel!!! tente mais uma vez e melhore seu desempenho")
        ElseIf (resultado > 150) Then
            Label1.Text = ("exelente resultado !!!")

        End If
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        inicio.Show()
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        historico.Show()
        Me.Close()
    End Sub
End Class