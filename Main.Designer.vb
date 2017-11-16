<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Me.MainPnl = New System.Windows.Forms.Panel()
        Me.BotBtn = New System.Windows.Forms.Button()
        Me.InfoBtn = New System.Windows.Forms.Button()
        Me.InfoPnl = New System.Windows.Forms.Panel()
        Me.InfoBackBtn = New System.Windows.Forms.Button()
        Me.InfoLbl = New System.Windows.Forms.Label()
        Me.BotPnl = New System.Windows.Forms.Panel()
        Me.ElephantBtn = New System.Windows.Forms.Button()
        Me.ZebraBtn = New System.Windows.Forms.Button()
        Me.HippoBtn = New System.Windows.Forms.Button()
        Me.PenguinBtn = New System.Windows.Forms.Button()
        Me.CamelBtn = New System.Windows.Forms.Button()
        Me.BearBtn = New System.Windows.Forms.Button()
        Me.GorillaBtn = New System.Windows.Forms.Button()
        Me.LionBtn = New System.Windows.Forms.Button()
        Me.TigerBtn = New System.Windows.Forms.Button()
        Me.BotBackBtn = New System.Windows.Forms.Button()
        Me.QueuePnl = New System.Windows.Forms.Panel()
        Me.QueueBackBtn = New System.Windows.Forms.Button()
        Me.SpectateBtn = New System.Windows.Forms.Button()
        Me.QueueBtn = New System.Windows.Forms.Button()
        Me.QueueGrp = New System.Windows.Forms.GroupBox()
        Me.QCancelBtn = New System.Windows.Forms.Button()
        Me.QAcceptBtn = New System.Windows.Forms.Button()
        Me.QueueLbl = New System.Windows.Forms.Label()
        Me.CameraPnl = New System.Windows.Forms.Panel()
        Me.CameraImg = New System.Windows.Forms.PictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.MainPnl.SuspendLayout()
        Me.InfoPnl.SuspendLayout()
        Me.BotPnl.SuspendLayout()
        Me.QueuePnl.SuspendLayout()
        Me.QueueGrp.SuspendLayout()
        Me.CameraPnl.SuspendLayout()
        CType(Me.CameraImg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MainPnl
        '
        Me.MainPnl.Controls.Add(Me.BotBtn)
        Me.MainPnl.Controls.Add(Me.InfoBtn)
        Me.MainPnl.Location = New System.Drawing.Point(6, 6)
        Me.MainPnl.Margin = New System.Windows.Forms.Padding(2)
        Me.MainPnl.Name = "MainPnl"
        Me.MainPnl.Size = New System.Drawing.Size(615, 483)
        Me.MainPnl.TabIndex = 0
        '
        'BotBtn
        '
        Me.BotBtn.Location = New System.Drawing.Point(144, 265)
        Me.BotBtn.Margin = New System.Windows.Forms.Padding(2)
        Me.BotBtn.Name = "BotBtn"
        Me.BotBtn.Size = New System.Drawing.Size(123, 109)
        Me.BotBtn.TabIndex = 1
        Me.BotBtn.Text = "See Bots"
        Me.BotBtn.UseVisualStyleBackColor = True
        '
        'InfoBtn
        '
        Me.InfoBtn.Location = New System.Drawing.Point(428, 317)
        Me.InfoBtn.Margin = New System.Windows.Forms.Padding(2)
        Me.InfoBtn.Name = "InfoBtn"
        Me.InfoBtn.Size = New System.Drawing.Size(107, 71)
        Me.InfoBtn.TabIndex = 0
        Me.InfoBtn.Text = "Info"
        Me.InfoBtn.UseVisualStyleBackColor = True
        '
        'InfoPnl
        '
        Me.InfoPnl.Controls.Add(Me.InfoBackBtn)
        Me.InfoPnl.Controls.Add(Me.InfoLbl)
        Me.InfoPnl.Location = New System.Drawing.Point(6, 6)
        Me.InfoPnl.Margin = New System.Windows.Forms.Padding(2)
        Me.InfoPnl.Name = "InfoPnl"
        Me.InfoPnl.Size = New System.Drawing.Size(615, 483)
        Me.InfoPnl.TabIndex = 0
        Me.InfoPnl.Visible = False
        '
        'InfoBackBtn
        '
        Me.InfoBackBtn.BackColor = System.Drawing.Color.White
        Me.InfoBackBtn.BackgroundImage = CType(resources.GetObject("InfoBackBtn.BackgroundImage"), System.Drawing.Image)
        Me.InfoBackBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.InfoBackBtn.Location = New System.Drawing.Point(2, 2)
        Me.InfoBackBtn.Margin = New System.Windows.Forms.Padding(2)
        Me.InfoBackBtn.Name = "InfoBackBtn"
        Me.InfoBackBtn.Size = New System.Drawing.Size(84, 59)
        Me.InfoBackBtn.TabIndex = 1
        Me.InfoBackBtn.Text = "InfoBackBtn"
        Me.InfoBackBtn.UseVisualStyleBackColor = False
        '
        'InfoLbl
        '
        Me.InfoLbl.AutoSize = True
        Me.InfoLbl.Location = New System.Drawing.Point(115, 92)
        Me.InfoLbl.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.InfoLbl.Name = "InfoLbl"
        Me.InfoLbl.Size = New System.Drawing.Size(39, 13)
        Me.InfoLbl.TabIndex = 0
        Me.InfoLbl.Text = "InfoLbl"
        '
        'BotPnl
        '
        Me.BotPnl.Controls.Add(Me.ElephantBtn)
        Me.BotPnl.Controls.Add(Me.ZebraBtn)
        Me.BotPnl.Controls.Add(Me.HippoBtn)
        Me.BotPnl.Controls.Add(Me.PenguinBtn)
        Me.BotPnl.Controls.Add(Me.CamelBtn)
        Me.BotPnl.Controls.Add(Me.BearBtn)
        Me.BotPnl.Controls.Add(Me.GorillaBtn)
        Me.BotPnl.Controls.Add(Me.LionBtn)
        Me.BotPnl.Controls.Add(Me.TigerBtn)
        Me.BotPnl.Controls.Add(Me.BotBackBtn)
        Me.BotPnl.Location = New System.Drawing.Point(6, 6)
        Me.BotPnl.Margin = New System.Windows.Forms.Padding(2)
        Me.BotPnl.Name = "BotPnl"
        Me.BotPnl.Size = New System.Drawing.Size(615, 483)
        Me.BotPnl.TabIndex = 1
        Me.BotPnl.Visible = False
        '
        'ElephantBtn
        '
        Me.ElephantBtn.BackColor = System.Drawing.Color.White
        Me.ElephantBtn.BackgroundImage = CType(resources.GetObject("ElephantBtn.BackgroundImage"), System.Drawing.Image)
        Me.ElephantBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ElephantBtn.Location = New System.Drawing.Point(366, 155)
        Me.ElephantBtn.Margin = New System.Windows.Forms.Padding(2)
        Me.ElephantBtn.Name = "ElephantBtn"
        Me.ElephantBtn.Size = New System.Drawing.Size(120, 68)
        Me.ElephantBtn.TabIndex = 11
        Me.ElephantBtn.UseVisualStyleBackColor = False
        '
        'ZebraBtn
        '
        Me.ZebraBtn.BackColor = System.Drawing.Color.White
        Me.ZebraBtn.BackgroundImage = CType(resources.GetObject("ZebraBtn.BackgroundImage"), System.Drawing.Image)
        Me.ZebraBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ZebraBtn.Location = New System.Drawing.Point(366, 299)
        Me.ZebraBtn.Margin = New System.Windows.Forms.Padding(2)
        Me.ZebraBtn.Name = "ZebraBtn"
        Me.ZebraBtn.Size = New System.Drawing.Size(120, 68)
        Me.ZebraBtn.TabIndex = 10
        Me.ZebraBtn.UseVisualStyleBackColor = False
        '
        'HippoBtn
        '
        Me.HippoBtn.BackColor = System.Drawing.Color.White
        Me.HippoBtn.BackgroundImage = CType(resources.GetObject("HippoBtn.BackgroundImage"), System.Drawing.Image)
        Me.HippoBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.HippoBtn.Location = New System.Drawing.Point(242, 227)
        Me.HippoBtn.Margin = New System.Windows.Forms.Padding(2)
        Me.HippoBtn.Name = "HippoBtn"
        Me.HippoBtn.Size = New System.Drawing.Size(120, 68)
        Me.HippoBtn.TabIndex = 9
        Me.HippoBtn.UseVisualStyleBackColor = False
        '
        'PenguinBtn
        '
        Me.PenguinBtn.BackColor = System.Drawing.Color.White
        Me.PenguinBtn.BackgroundImage = CType(resources.GetObject("PenguinBtn.BackgroundImage"), System.Drawing.Image)
        Me.PenguinBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PenguinBtn.Location = New System.Drawing.Point(118, 299)
        Me.PenguinBtn.Margin = New System.Windows.Forms.Padding(2)
        Me.PenguinBtn.Name = "PenguinBtn"
        Me.PenguinBtn.Size = New System.Drawing.Size(120, 68)
        Me.PenguinBtn.TabIndex = 8
        Me.PenguinBtn.UseVisualStyleBackColor = False
        '
        'CamelBtn
        '
        Me.CamelBtn.BackColor = System.Drawing.Color.White
        Me.CamelBtn.BackgroundImage = CType(resources.GetObject("CamelBtn.BackgroundImage"), System.Drawing.Image)
        Me.CamelBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.CamelBtn.Location = New System.Drawing.Point(242, 155)
        Me.CamelBtn.Margin = New System.Windows.Forms.Padding(2)
        Me.CamelBtn.Name = "CamelBtn"
        Me.CamelBtn.Size = New System.Drawing.Size(120, 68)
        Me.CamelBtn.TabIndex = 7
        Me.CamelBtn.UseVisualStyleBackColor = False
        '
        'BearBtn
        '
        Me.BearBtn.BackColor = System.Drawing.Color.White
        Me.BearBtn.BackgroundImage = CType(resources.GetObject("BearBtn.BackgroundImage"), System.Drawing.Image)
        Me.BearBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BearBtn.Location = New System.Drawing.Point(118, 155)
        Me.BearBtn.Margin = New System.Windows.Forms.Padding(2)
        Me.BearBtn.Name = "BearBtn"
        Me.BearBtn.Size = New System.Drawing.Size(120, 68)
        Me.BearBtn.TabIndex = 6
        Me.BearBtn.UseVisualStyleBackColor = False
        '
        'GorillaBtn
        '
        Me.GorillaBtn.BackColor = System.Drawing.Color.White
        Me.GorillaBtn.BackgroundImage = CType(resources.GetObject("GorillaBtn.BackgroundImage"), System.Drawing.Image)
        Me.GorillaBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.GorillaBtn.Location = New System.Drawing.Point(118, 227)
        Me.GorillaBtn.Margin = New System.Windows.Forms.Padding(2)
        Me.GorillaBtn.Name = "GorillaBtn"
        Me.GorillaBtn.Size = New System.Drawing.Size(120, 68)
        Me.GorillaBtn.TabIndex = 5
        Me.GorillaBtn.UseVisualStyleBackColor = False
        '
        'LionBtn
        '
        Me.LionBtn.BackColor = System.Drawing.Color.White
        Me.LionBtn.BackgroundImage = CType(resources.GetObject("LionBtn.BackgroundImage"), System.Drawing.Image)
        Me.LionBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.LionBtn.Location = New System.Drawing.Point(366, 227)
        Me.LionBtn.Margin = New System.Windows.Forms.Padding(2)
        Me.LionBtn.Name = "LionBtn"
        Me.LionBtn.Size = New System.Drawing.Size(120, 68)
        Me.LionBtn.TabIndex = 4
        Me.LionBtn.UseVisualStyleBackColor = False
        '
        'TigerBtn
        '
        Me.TigerBtn.BackColor = System.Drawing.Color.White
        Me.TigerBtn.BackgroundImage = CType(resources.GetObject("TigerBtn.BackgroundImage"), System.Drawing.Image)
        Me.TigerBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.TigerBtn.Location = New System.Drawing.Point(242, 299)
        Me.TigerBtn.Margin = New System.Windows.Forms.Padding(2)
        Me.TigerBtn.Name = "TigerBtn"
        Me.TigerBtn.Size = New System.Drawing.Size(120, 68)
        Me.TigerBtn.TabIndex = 1
        Me.TigerBtn.UseVisualStyleBackColor = False
        '
        'BotBackBtn
        '
        Me.BotBackBtn.BackColor = System.Drawing.Color.White
        Me.BotBackBtn.BackgroundImage = CType(resources.GetObject("BotBackBtn.BackgroundImage"), System.Drawing.Image)
        Me.BotBackBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BotBackBtn.Location = New System.Drawing.Point(2, 2)
        Me.BotBackBtn.Margin = New System.Windows.Forms.Padding(2)
        Me.BotBackBtn.Name = "BotBackBtn"
        Me.BotBackBtn.Size = New System.Drawing.Size(88, 53)
        Me.BotBackBtn.TabIndex = 0
        Me.BotBackBtn.UseVisualStyleBackColor = False
        '
        'QueuePnl
        '
        Me.QueuePnl.Controls.Add(Me.QueueBackBtn)
        Me.QueuePnl.Controls.Add(Me.SpectateBtn)
        Me.QueuePnl.Controls.Add(Me.QueueBtn)
        Me.QueuePnl.Location = New System.Drawing.Point(6, 6)
        Me.QueuePnl.Margin = New System.Windows.Forms.Padding(2)
        Me.QueuePnl.Name = "QueuePnl"
        Me.QueuePnl.Size = New System.Drawing.Size(615, 483)
        Me.QueuePnl.TabIndex = 2
        Me.QueuePnl.Visible = False
        '
        'QueueBackBtn
        '
        Me.QueueBackBtn.BackColor = System.Drawing.Color.White
        Me.QueueBackBtn.BackgroundImage = CType(resources.GetObject("QueueBackBtn.BackgroundImage"), System.Drawing.Image)
        Me.QueueBackBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.QueueBackBtn.Location = New System.Drawing.Point(2, 2)
        Me.QueueBackBtn.Margin = New System.Windows.Forms.Padding(2)
        Me.QueueBackBtn.Name = "QueueBackBtn"
        Me.QueueBackBtn.Size = New System.Drawing.Size(84, 59)
        Me.QueueBackBtn.TabIndex = 2
        Me.QueueBackBtn.UseVisualStyleBackColor = False
        '
        'SpectateBtn
        '
        Me.SpectateBtn.BackColor = System.Drawing.SystemColors.Control
        Me.SpectateBtn.BackgroundImage = CType(resources.GetObject("SpectateBtn.BackgroundImage"), System.Drawing.Image)
        Me.SpectateBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.SpectateBtn.Location = New System.Drawing.Point(334, 181)
        Me.SpectateBtn.Margin = New System.Windows.Forms.Padding(2)
        Me.SpectateBtn.Name = "SpectateBtn"
        Me.SpectateBtn.Size = New System.Drawing.Size(201, 173)
        Me.SpectateBtn.TabIndex = 1
        Me.SpectateBtn.UseVisualStyleBackColor = False
        '
        'QueueBtn
        '
        Me.QueueBtn.BackColor = System.Drawing.SystemColors.Control
        Me.QueueBtn.BackgroundImage = CType(resources.GetObject("QueueBtn.BackgroundImage"), System.Drawing.Image)
        Me.QueueBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.QueueBtn.Location = New System.Drawing.Point(84, 181)
        Me.QueueBtn.Margin = New System.Windows.Forms.Padding(2)
        Me.QueueBtn.Name = "QueueBtn"
        Me.QueueBtn.Size = New System.Drawing.Size(199, 173)
        Me.QueueBtn.TabIndex = 0
        Me.QueueBtn.UseVisualStyleBackColor = False
        '
        'QueueGrp
        '
        Me.QueueGrp.Controls.Add(Me.QCancelBtn)
        Me.QueueGrp.Controls.Add(Me.QAcceptBtn)
        Me.QueueGrp.Controls.Add(Me.QueueLbl)
        Me.QueueGrp.Location = New System.Drawing.Point(476, 2)
        Me.QueueGrp.Margin = New System.Windows.Forms.Padding(2)
        Me.QueueGrp.Name = "QueueGrp"
        Me.QueueGrp.Padding = New System.Windows.Forms.Padding(2)
        Me.QueueGrp.Size = New System.Drawing.Size(148, 155)
        Me.QueueGrp.TabIndex = 3
        Me.QueueGrp.TabStop = False
        Me.QueueGrp.Visible = False
        '
        'QCancelBtn
        '
        Me.QCancelBtn.Location = New System.Drawing.Point(82, 125)
        Me.QCancelBtn.Margin = New System.Windows.Forms.Padding(2)
        Me.QCancelBtn.Name = "QCancelBtn"
        Me.QCancelBtn.Size = New System.Drawing.Size(54, 21)
        Me.QCancelBtn.TabIndex = 2
        Me.QCancelBtn.Text = "Cancel"
        Me.QCancelBtn.UseVisualStyleBackColor = True
        '
        'QAcceptBtn
        '
        Me.QAcceptBtn.Location = New System.Drawing.Point(8, 125)
        Me.QAcceptBtn.Margin = New System.Windows.Forms.Padding(2)
        Me.QAcceptBtn.Name = "QAcceptBtn"
        Me.QAcceptBtn.Size = New System.Drawing.Size(62, 24)
        Me.QAcceptBtn.TabIndex = 1
        Me.QAcceptBtn.Text = "Accept"
        Me.QAcceptBtn.UseVisualStyleBackColor = True
        '
        'QueueLbl
        '
        Me.QueueLbl.AutoSize = True
        Me.QueueLbl.Location = New System.Drawing.Point(15, 24)
        Me.QueueLbl.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.QueueLbl.Name = "QueueLbl"
        Me.QueueLbl.Size = New System.Drawing.Size(48, 13)
        Me.QueueLbl.TabIndex = 0
        Me.QueueLbl.Text = "in queue"
        '
        'CameraPnl
        '
        Me.CameraPnl.Controls.Add(Me.CameraImg)
        Me.CameraPnl.Location = New System.Drawing.Point(6, 6)
        Me.CameraPnl.Margin = New System.Windows.Forms.Padding(2)
        Me.CameraPnl.Name = "CameraPnl"
        Me.CameraPnl.Size = New System.Drawing.Size(616, 483)
        Me.CameraPnl.TabIndex = 4
        Me.CameraPnl.Visible = False
        '
        'CameraImg
        '
        Me.CameraImg.ImageLocation = ""
        Me.CameraImg.Location = New System.Drawing.Point(2, 2)
        Me.CameraImg.Margin = New System.Windows.Forms.Padding(2)
        Me.CameraImg.Name = "CameraImg"
        Me.CameraImg.Size = New System.Drawing.Size(614, 480)
        Me.CameraImg.TabIndex = 0
        Me.CameraImg.TabStop = False
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(632, 513)
        Me.Controls.Add(Me.QueueGrp)
        Me.Controls.Add(Me.QueuePnl)
        Me.Controls.Add(Me.CameraPnl)
        Me.Controls.Add(Me.MainPnl)
        Me.Controls.Add(Me.InfoPnl)
        Me.Controls.Add(Me.BotPnl)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MaximumSize = New System.Drawing.Size(648, 551)
        Me.MinimumSize = New System.Drawing.Size(648, 551)
        Me.Name = "Main"
        Me.Text = "TourBot"
        Me.MainPnl.ResumeLayout(False)
        Me.InfoPnl.ResumeLayout(False)
        Me.InfoPnl.PerformLayout()
        Me.BotPnl.ResumeLayout(False)
        Me.QueuePnl.ResumeLayout(False)
        Me.QueueGrp.ResumeLayout(False)
        Me.QueueGrp.PerformLayout()
        Me.CameraPnl.ResumeLayout(False)
        CType(Me.CameraImg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents MainPnl As Panel
    Friend WithEvents InfoBtn As Button
    Friend WithEvents InfoPnl As Panel
    Friend WithEvents InfoLbl As Label
    Friend WithEvents InfoBackBtn As Button
    Friend WithEvents BotPnl As Panel
    Friend WithEvents BotBtn As Button
    Friend WithEvents QueuePnl As Panel
    Friend WithEvents SpectateBtn As Button
    Friend WithEvents QueueBtn As Button
    Friend WithEvents QueueGrp As GroupBox
    Friend WithEvents QCancelBtn As Button
    Friend WithEvents QAcceptBtn As Button
    Friend WithEvents QueueLbl As Label
    Friend WithEvents BotBackBtn As Button
    Friend WithEvents TigerBtn As Button
    Friend WithEvents QueueBackBtn As Button
    Friend WithEvents ElephantBtn As Button
    Friend WithEvents ZebraBtn As Button
    Friend WithEvents HippoBtn As Button
    Friend WithEvents PenguinBtn As Button
    Friend WithEvents CamelBtn As Button
    Friend WithEvents BearBtn As Button
    Friend WithEvents GorillaBtn As Button
    Friend WithEvents LionBtn As Button
    Friend WithEvents CameraPnl As Panel
    Friend WithEvents CameraImg As PictureBox
    Friend WithEvents Timer1 As Timer
End Class
