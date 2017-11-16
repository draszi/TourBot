Public Class Main
    Dim alpha As Int16 ' <---  number between 0 (totally transparent) and 255 (totally opaque)
    Dim panelName As String

    Private Sub InfoBtn_Click(sender As Object, e As EventArgs) Handles InfoBtn.Click
        If MainPnl.Visible = True Then
            panelName = MainPnl.Name
            MainPnl.Visible = False

        ElseIf BotPnl.Visible = True Then
            panelName = BotPnl.Name
            BotPnl.Visible = False

        ElseIf QueuePnl.Visible = True Then
            panelName = QueuePnl.Name
            QueuePnl.Visible = False
        End If
        InfoPnl.Visible = True
        'MainPnl.Visible = False
    End Sub

    Private Sub InfoBackBtn_Click(sender As Object, e As EventArgs) Handles InfoBackBtn.Click
        If panelName = MainPnl.Name Then
            InfoPnl.Visible = False
            MainPnl.Visible = True
        ElseIf panelName = BotPnl.Name Then
            InfoPnl.Visible = False
            BotPnl.Visible = True
        ElseIf panelName = QueuePnl.Name Then
            InfoPnl.Visible = False
            QueuePnl.Visible = True
        End If
    End Sub

    Private Sub BotBtn_Click(sender As Object, e As EventArgs) Handles BotBtn.Click
        BotPnl.Visible = True
        MainPnl.Visible = False
    End Sub

    Private Sub QueueBtn_Click(sender As Object, e As EventArgs) Handles QueueBtn.Click
        QueueGrp.BringToFront()
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

    'Private Sub InfoLbl_Click(sender As Object, e As EventArgs) Handles InfoBtn.Click
    '    panelName = 
    'End Sub



    'Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick, InfoBtn.VisibleChanged
    '    alpha = 60
    '    InfoBtn.BackColor = Color.Black
    'End Sub
End Class