Public Class Window1

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        My.Computer.Audio.Play(My.Resources.RickAstley, AudioPlayMode.WaitToComplete)
    End Sub
End Class