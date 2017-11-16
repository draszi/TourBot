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
    Private Sub UpBtn_Click(sender As Object, e As EventArgs) Handles UpBtn.Click
        Dim NewLocation As New Object
        If (CameraImg.Location.Y > -100) Then
            NewLocation = New System.Drawing.Point(CameraImg.Location.X, 0)
        Else
            NewLocation = New System.Drawing.Point(CameraImg.Location.X, CameraImg.Location.Y + 100)
        End If
        CameraImg.Location = NewLocation
    End Sub

    Private Sub DownBtn_Click(sender As Object, e As EventArgs) Handles DownBtn.Click
        Dim NewLocation As New Object
        If (CameraImg.Location.Y < CameraImg.Image.Height * -1 + CameraPnl.Size.Height + 100) Then
            NewLocation = New System.Drawing.Point(CameraImg.Location.X, CameraImg.Image.Height * -1 + CameraPnl.Size.Height)
        Else
            NewLocation = New System.Drawing.Point(CameraImg.Location.X, CameraImg.Location.Y - 100)
        End If
        CameraImg.Location = NewLocation
    End Sub
    Private Sub LeftBtn_Click(sender As Object, e As EventArgs) Handles LeftBtn.Click
        Dim NewLocation As New Object
        If (CameraImg.Location.X > -100) Then
            NewLocation = New System.Drawing.Point(0, CameraImg.Location.Y)
        Else
            NewLocation = New System.Drawing.Point(CameraImg.Location.X + 100, CameraImg.Location.Y)
        End If
        CameraImg.Location = NewLocation
    End Sub
    Private Sub RightBtn_Click(sender As Object, e As EventArgs) Handles RightBtn.Click
        Dim NewLocation As New Object
        If (CameraImg.Location.X < CameraImg.Image.Width * -1 + CameraPnl.Size.Width + 100) Then
            NewLocation = New System.Drawing.Point(CameraImg.Image.Width * -1 + CameraPnl.Size.Width, CameraImg.Location.Y)
        Else
            NewLocation = New System.Drawing.Point(CameraImg.Location.X - 100, CameraImg.Location.Y)
        End If
        CameraImg.Location = NewLocation
    End Sub

End Class
