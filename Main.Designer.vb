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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Me.MainPnl = New System.Windows.Forms.Panel()
        Me.BotBtn = New System.Windows.Forms.Button()
        Me.InfoBtn = New System.Windows.Forms.Button()
        Me.InfoPnl = New System.Windows.Forms.Panel()
        Me.InfoBackBtn = New System.Windows.Forms.Button()
        Me.InfoLbl = New System.Windows.Forms.Label()
        Me.BotPnl = New System.Windows.Forms.Panel()
        Me.PenguinBtn = New System.Windows.Forms.Button()
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
        Me.MainPnl.Location = New System.Drawing.Point(12, 12)
        Me.MainPnl.Name = "MainPnl"
        Me.MainPnl.Size = New System.Drawing.Size(1230, 929)
        Me.MainPnl.TabIndex = 0
        '
        'BotBtn
        '
        Me.BotBtn.Location = New System.Drawing.Point(287, 509)
        Me.BotBtn.Name = "BotBtn"
        Me.BotBtn.Size = New System.Drawing.Size(246, 210)
        Me.BotBtn.TabIndex = 1
        Me.BotBtn.Text = "See Bots"
        Me.BotBtn.UseVisualStyleBackColor = True
        '
        'InfoBtn
        '
        Me.InfoBtn.Location = New System.Drawing.Point(857, 609)
        Me.InfoBtn.Name = "InfoBtn"
        Me.InfoBtn.Size = New System.Drawing.Size(214, 137)
        Me.InfoBtn.TabIndex = 0
        Me.InfoBtn.Text = "Info"
        Me.InfoBtn.UseVisualStyleBackColor = True
        '
        'InfoPnl
        '
        Me.InfoPnl.Controls.Add(Me.InfoBackBtn)
        Me.InfoPnl.Controls.Add(Me.InfoLbl)
        Me.InfoPnl.Location = New System.Drawing.Point(12, 12)
        Me.InfoPnl.Name = "InfoPnl"
        Me.InfoPnl.Size = New System.Drawing.Size(1230, 929)
        Me.InfoPnl.TabIndex = 0
        Me.InfoPnl.Visible = False
        '
        'InfoBackBtn
        '
        Me.InfoBackBtn.Location = New System.Drawing.Point(3, 3)
        Me.InfoBackBtn.Name = "InfoBackBtn"
        Me.InfoBackBtn.Size = New System.Drawing.Size(169, 113)
        Me.InfoBackBtn.TabIndex = 1
        Me.InfoBackBtn.Text = "InfoBackBtn"
        Me.InfoBackBtn.UseVisualStyleBackColor = True
        '
        'InfoLbl
        '
        Me.InfoLbl.AutoSize = True
        Me.InfoLbl.Location = New System.Drawing.Point(230, 177)
        Me.InfoLbl.Name = "InfoLbl"
        Me.InfoLbl.Size = New System.Drawing.Size(76, 25)
        Me.InfoLbl.TabIndex = 0
        Me.InfoLbl.Text = "InfoLbl"
        '
        'BotPnl
        '
        Me.BotPnl.Controls.Add(Me.PenguinBtn)
        Me.BotPnl.Controls.Add(Me.TigerBtn)
        Me.BotPnl.Controls.Add(Me.BotBackBtn)
        Me.BotPnl.Location = New System.Drawing.Point(12, 12)
        Me.BotPnl.Name = "BotPnl"
        Me.BotPnl.Size = New System.Drawing.Size(1230, 929)
        Me.BotPnl.TabIndex = 1
        Me.BotPnl.Visible = False
        '
        'PenguinBtn
        '
        Me.PenguinBtn.Location = New System.Drawing.Point(345, 201)
        Me.PenguinBtn.Name = "PenguinBtn"
        Me.PenguinBtn.Size = New System.Drawing.Size(188, 144)
        Me.PenguinBtn.TabIndex = 2
        Me.PenguinBtn.Text = "Penguin"
        Me.PenguinBtn.UseVisualStyleBackColor = True
        '
        'TigerBtn
        '
        Me.TigerBtn.Location = New System.Drawing.Point(113, 205)
        Me.TigerBtn.Name = "TigerBtn"
        Me.TigerBtn.Size = New System.Drawing.Size(178, 122)
        Me.TigerBtn.TabIndex = 1
        Me.TigerBtn.Text = "Tiger"
        Me.TigerBtn.UseVisualStyleBackColor = True
        '
        'BotBackBtn
        '
        Me.BotBackBtn.Location = New System.Drawing.Point(3, 3)
        Me.BotBackBtn.Name = "BotBackBtn"
        Me.BotBackBtn.Size = New System.Drawing.Size(177, 101)
        Me.BotBackBtn.TabIndex = 0
        Me.BotBackBtn.Text = "Back"
        Me.BotBackBtn.UseVisualStyleBackColor = True
        '
        'QueuePnl
        '
        Me.QueuePnl.Controls.Add(Me.QueueBackBtn)
        Me.QueuePnl.Controls.Add(Me.SpectateBtn)
        Me.QueuePnl.Controls.Add(Me.QueueBtn)
        Me.QueuePnl.Location = New System.Drawing.Point(12, 12)
        Me.QueuePnl.Name = "QueuePnl"
        Me.QueuePnl.Size = New System.Drawing.Size(1230, 929)
        Me.QueuePnl.TabIndex = 2
        Me.QueuePnl.Visible = False
        '
        'QueueBackBtn
        '
        Me.QueueBackBtn.Location = New System.Drawing.Point(3, 3)
        Me.QueueBackBtn.Name = "QueueBackBtn"
        Me.QueueBackBtn.Size = New System.Drawing.Size(169, 113)
        Me.QueueBackBtn.TabIndex = 2
        Me.QueueBackBtn.Text = "Back"
        Me.QueueBackBtn.UseVisualStyleBackColor = True
        '
        'SpectateBtn
        '
        Me.SpectateBtn.Location = New System.Drawing.Point(669, 402)
        Me.SpectateBtn.Name = "SpectateBtn"
        Me.SpectateBtn.Size = New System.Drawing.Size(270, 201)
        Me.SpectateBtn.TabIndex = 1
        Me.SpectateBtn.Text = "Spectate"
        Me.SpectateBtn.UseVisualStyleBackColor = True
        '
        'QueueBtn
        '
        Me.QueueBtn.Location = New System.Drawing.Point(188, 381)
        Me.QueueBtn.Name = "QueueBtn"
        Me.QueueBtn.Size = New System.Drawing.Size(259, 191)
        Me.QueueBtn.TabIndex = 0
        Me.QueueBtn.Text = "Queue"
        Me.QueueBtn.UseVisualStyleBackColor = True
        '
        'QueueGrp
        '
        Me.QueueGrp.Controls.Add(Me.QCancelBtn)
        Me.QueueGrp.Controls.Add(Me.QAcceptBtn)
        Me.QueueGrp.Controls.Add(Me.QueueLbl)
        Me.QueueGrp.Location = New System.Drawing.Point(953, 3)
        Me.QueueGrp.Name = "QueueGrp"
        Me.QueueGrp.Size = New System.Drawing.Size(297, 323)
        Me.QueueGrp.TabIndex = 3
        Me.QueueGrp.TabStop = False
        Me.QueueGrp.Visible = False
        '
        'QCancelBtn
        '
        Me.QCancelBtn.Location = New System.Drawing.Point(165, 259)
        Me.QCancelBtn.Name = "QCancelBtn"
        Me.QCancelBtn.Size = New System.Drawing.Size(109, 41)
        Me.QCancelBtn.TabIndex = 2
        Me.QCancelBtn.Text = "Cancel"
        Me.QCancelBtn.UseVisualStyleBackColor = True
        '
        'QAcceptBtn
        '
        Me.QAcceptBtn.Location = New System.Drawing.Point(16, 259)
        Me.QAcceptBtn.Name = "QAcceptBtn"
        Me.QAcceptBtn.Size = New System.Drawing.Size(123, 46)
        Me.QAcceptBtn.TabIndex = 1
        Me.QAcceptBtn.Text = "Accept"
        Me.QAcceptBtn.UseVisualStyleBackColor = True
        '
        'QueueLbl
        '
        Me.QueueLbl.AutoSize = True
        Me.QueueLbl.Location = New System.Drawing.Point(30, 46)
        Me.QueueLbl.Name = "QueueLbl"
        Me.QueueLbl.Size = New System.Drawing.Size(95, 25)
        Me.QueueLbl.TabIndex = 0
        Me.QueueLbl.Text = "in queue"
        '
        'CameraPnl
        '
        Me.CameraPnl.Controls.Add(Me.CameraImg)
        Me.CameraPnl.Location = New System.Drawing.Point(12, 12)
        Me.CameraPnl.Name = "CameraPnl"
        Me.CameraPnl.Size = New System.Drawing.Size(1232, 929)
        Me.CameraPnl.TabIndex = 4
        Me.CameraPnl.Visible = False
        '
        'CameraImg
        '
        Me.CameraImg.Image = CType(resources.GetObject("CameraImg.Image"), System.Drawing.Image)
        Me.CameraImg.ImageLocation = ""
        Me.CameraImg.Location = New System.Drawing.Point(3, 3)
        Me.CameraImg.Name = "CameraImg"
        Me.CameraImg.Size = New System.Drawing.Size(1229, 923)
        Me.CameraImg.TabIndex = 0
        Me.CameraImg.TabStop = False
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1254, 953)
        Me.Controls.Add(Me.CameraPnl)
        Me.Controls.Add(Me.QueueGrp)
        Me.Controls.Add(Me.MainPnl)
        Me.Controls.Add(Me.InfoPnl)
        Me.Controls.Add(Me.BotPnl)
        Me.Controls.Add(Me.QueuePnl)
        Me.MaximumSize = New System.Drawing.Size(1280, 1024)
        Me.MinimumSize = New System.Drawing.Size(1280, 1024)
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
    Friend WithEvents PenguinBtn As Button
    Friend WithEvents TigerBtn As Button
    Friend WithEvents QueueBackBtn As Button
    Friend WithEvents CameraPnl As Panel
    Friend WithEvents CameraImg As PictureBox
End Class
