Public Class inicio
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        My.Computer.Audio.Play(My.Resources.basqueteball, AudioPlayMode.BackgroundLoop)
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        questao1.Show()
        Me.Close()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If MessageBox.Show("Deseja sair do BasquesteQuiz?", "atenção", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            End
        Else
            MsgBox("continua")
        End If
    End Sub
    Private Sub Button4_Click_1(sender As Object, e As EventArgs) Handles Button4.Click
        My.Computer.Audio.Stop()
    End Sub

    Private Sub inicio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        My.Computer.Audio.Play(My.Resources.basqueteball, AudioPlayMode.BackgroundLoop)
    End Sub
End Class