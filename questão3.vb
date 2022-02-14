Public Class questão3
    Private Sub questão_3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
        'PictureBox1.Image = My.Resources.nome_da_imagem'
        PictureBox2.Image = My.Resources.errado
        PictureBox3.Image = My.Resources.correto
        PictureBox4.Image = My.Resources.errado
        PictureBox5.Image = My.Resources.errado
        'PictureBox1.Visible = True'
        PictureBox2.Visible = False
        PictureBox3.Visible = False
        PictureBox4.Visible = False
        PictureBox5.Visible = False

        pontuacao3 = (pontuacao2 + 0)
        Label3.Text = pontuacao3

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        inicio.Show()
        Me.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        questao4.Show()
        Me.Close()
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        If (RadioButton1.Checked = True) Then
            PictureBox2.Visible = True
            PictureBox3.Visible = False
            PictureBox4.Visible = False
            PictureBox5.Visible = False
            pontuacao3 = (pontuacao2 + 5)
            Label3.Text = pontuacao3
        End If


    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        If (RadioButton2.Checked = True) Then
            PictureBox2.Visible = True
            PictureBox3.Visible = True
            PictureBox4.Visible = False
            PictureBox5.Visible = False
            pontuacao3 = (pontuacao2 + 0)
            Label3.Text = pontuacao3
        End If
    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
        If (RadioButton3.Checked = True) Then
            PictureBox2.Visible = True
            PictureBox3.Visible = False
            PictureBox4.Visible = True
            PictureBox5.Visible = False
            pontuacao3 = (pontuacao2 + 0)
            Label3.Text = pontuacao3
        End If
    End Sub

    Private Sub RadioButton4_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton4.CheckedChanged
        If (RadioButton4.Checked = True) Then
            PictureBox2.Visible = False
            PictureBox3.Visible = True
            PictureBox4.Visible = False
            PictureBox5.Visible = True
            pontuacao3 = (pontuacao2 + 0)
            Label3.Text = pontuacao3
        End If
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If (ProgressBar1.Value = ProgressBar1.Maximum) Then
            Timer1.Stop()
            Me.Hide()
            questao4.Show()

        Else
            ProgressBar1.PerformStep()
        End If

    End Sub
End Class