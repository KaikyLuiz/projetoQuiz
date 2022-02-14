Public Class splash_screen
    Private Sub splash_screen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
        My.Computer.Audio.Play(My.Resources.basqueteball, AudioPlayMode.BackgroundLoop)
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If (ProgressBar1.Value = ProgressBar1.Maximum) Then
            Timer1.Stop()
            Me.Hide()
            inicio.Show()

        Else
            ProgressBar1.PerformStep()
            Label1.Text = ProgressBar1.Value & ("%")


        End If

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub
End Class


