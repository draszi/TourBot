Public Class Main
    Private Sub InfoBtn_Click(sender As Object, e As EventArgs) Handles InfoBtn.Click
        InfoPnl.Visible = True
        MainPnl.Visible = False
    End Sub

    Private Sub InfoBackBtn_Click(sender As Object, e As EventArgs) Handles InfoBackBtn.Click
        InfoPnl.Visible = False
        MainPnl.Visible = True
    End Sub

    Private Sub BotBtn_Click(sender As Object, e As EventArgs) Handles BotBtn.Click
        BotPnl.Visible = True
        MainPnl.Visible = False
    End Sub

    Private Sub QueueBtn_Click(sender As Object, e As EventArgs) Handles QueueBtn.Click
        QueueGrp.Visible = True
    End Sub

    Private Sub QAcceptBtn_Click(sender As Object, e As EventArgs) Handles QAcceptBtn.Click
        QueueGrp.Visible = False
        CameraPnl.Visible = True
    End Sub

    Private Sub QCancelBtn_Click(sender As Object, e As EventArgs) Handles QCancelBtn.Click
        QueueGrp.Visible = False
    End Sub

    Private Sub BotBackBtn_Click(sender As Object, e As EventArgs) Handles BotBackBtn.Click
        BotPnl.Visible = False
        MainPnl.Visible = True
    End Sub

    Private Sub TigerBtn_Click(sender As Object, e As EventArgs) Handles TigerBtn.Click
        BotPnl.Visible = False
        QueuePnl.Visible = True
    End Sub

    Private Sub PenguinBtn_Click(sender As Object, e As EventArgs) Handles PenguinBtn.Click
        BotPnl.Visible = False
        QueuePnl.Visible = True
    End Sub

    Private Sub QueueBackBtn_Click(sender As Object, e As EventArgs) Handles QueueBackBtn.Click
        BotPnl.Visible = True
        QueuePnl.Visible = False
    End Sub

    Private Sub CameraImg_GiveFeedback(sender As Object, e As GiveFeedbackEventArgs) Handles CameraImg.GiveFeedback

    End Sub
End Class
