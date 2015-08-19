<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ViewerForm
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
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

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ViewerForm))
        Me.ofdSelectPicture = New System.Windows.Forms.OpenFileDialog()
        Me.btnEnlarge = New System.Windows.Forms.Button()
        Me.btnShrink = New System.Windows.Forms.Button()
        Me.lblX = New System.Windows.Forms.Label()
        Me.lblY = New System.Windows.Forms.Label()
        Me.mnuMainMenu = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuOpenPicture = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuProperties = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuQuit = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuConfirmOnExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuDrawBorder = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuOptions = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuPictureContext = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.DrawBorderToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.tbrMainToolbar = New System.Windows.Forms.ToolStrip()
        Me.tbbOpenPicture = New System.Windows.Forms.ToolStripButton()
        Me.tbbDrawBorder = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.tbbOptions = New System.Windows.Forms.ToolStripButton()
        Me.tbbGetFileAttributes = New System.Windows.Forms.ToolStripButton()
        Me.sbrMyStatusStrip = New System.Windows.Forms.StatusStrip()
        Me.lblStatus = New System.Windows.Forms.ToolStripStatusLabel()
        Me.picShowPicture = New System.Windows.Forms.PictureBox()
        Me.mnuMainMenu.SuspendLayout()
        Me.mnuPictureContext.SuspendLayout()
        Me.tbrMainToolbar.SuspendLayout()
        Me.sbrMyStatusStrip.SuspendLayout()
        CType(Me.picShowPicture, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ofdSelectPicture
        '
        Me.ofdSelectPicture.Filter = "All Files|*.*"
        Me.ofdSelectPicture.Title = "Select Picture"
        '
        'btnEnlarge
        '
        Me.btnEnlarge.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnEnlarge.Location = New System.Drawing.Point(336, 274)
        Me.btnEnlarge.Name = "btnEnlarge"
        Me.btnEnlarge.Size = New System.Drawing.Size(21, 23)
        Me.btnEnlarge.TabIndex = 6
        Me.btnEnlarge.Text = "v"
        Me.btnEnlarge.UseVisualStyleBackColor = True
        '
        'btnShrink
        '
        Me.btnShrink.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnShrink.Location = New System.Drawing.Point(357, 274)
        Me.btnShrink.Name = "btnShrink"
        Me.btnShrink.Size = New System.Drawing.Size(21, 23)
        Me.btnShrink.TabIndex = 7
        Me.btnShrink.Text = "^"
        Me.btnShrink.UseVisualStyleBackColor = True
        '
        'lblX
        '
        Me.lblX.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblX.AutoSize = True
        Me.lblX.Location = New System.Drawing.Point(336, 236)
        Me.lblX.Name = "lblX"
        Me.lblX.Size = New System.Drawing.Size(17, 12)
        Me.lblX.TabIndex = 3
        Me.lblX.Text = "X:"
        '
        'lblY
        '
        Me.lblY.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblY.AutoSize = True
        Me.lblY.Location = New System.Drawing.Point(336, 251)
        Me.lblY.Name = "lblY"
        Me.lblY.Size = New System.Drawing.Size(17, 12)
        Me.lblY.TabIndex = 4
        Me.lblY.Text = "Y:"
        '
        'mnuMainMenu
        '
        Me.mnuMainMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.ToolsToolStripMenuItem})
        Me.mnuMainMenu.Location = New System.Drawing.Point(0, 0)
        Me.mnuMainMenu.Name = "mnuMainMenu"
        Me.mnuMainMenu.Size = New System.Drawing.Size(384, 25)
        Me.mnuMainMenu.TabIndex = 8
        Me.mnuMainMenu.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuOpenPicture, Me.mnuProperties, Me.mnuQuit, Me.mnuConfirmOnExit})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(39, 21)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'mnuOpenPicture
        '
        Me.mnuOpenPicture.Name = "mnuOpenPicture"
        Me.mnuOpenPicture.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
        Me.mnuOpenPicture.Size = New System.Drawing.Size(207, 22)
        Me.mnuOpenPicture.Text = "&Open Picture..."
        '
        'mnuProperties
        '
        Me.mnuProperties.Name = "mnuProperties"
        Me.mnuProperties.Size = New System.Drawing.Size(207, 22)
        Me.mnuProperties.Text = "&Properties..."
        '
        'mnuQuit
        '
        Me.mnuQuit.Name = "mnuQuit"
        Me.mnuQuit.Size = New System.Drawing.Size(207, 22)
        Me.mnuQuit.Text = "&Quit"
        '
        'mnuConfirmOnExit
        '
        Me.mnuConfirmOnExit.Name = "mnuConfirmOnExit"
        Me.mnuConfirmOnExit.Size = New System.Drawing.Size(207, 22)
        Me.mnuConfirmOnExit.Text = "Confirm on Exit"
        '
        'ToolsToolStripMenuItem
        '
        Me.ToolsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuDrawBorder, Me.ToolStripSeparator1, Me.mnuOptions})
        Me.ToolsToolStripMenuItem.Name = "ToolsToolStripMenuItem"
        Me.ToolsToolStripMenuItem.Size = New System.Drawing.Size(52, 21)
        Me.ToolsToolStripMenuItem.Text = "&Tools"
        '
        'mnuDrawBorder
        '
        Me.mnuDrawBorder.Name = "mnuDrawBorder"
        Me.mnuDrawBorder.Size = New System.Drawing.Size(151, 22)
        Me.mnuDrawBorder.Text = "&Draw Border"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(148, 6)
        '
        'mnuOptions
        '
        Me.mnuOptions.Name = "mnuOptions"
        Me.mnuOptions.Size = New System.Drawing.Size(151, 22)
        Me.mnuOptions.Text = "&Options..."
        '
        'mnuPictureContext
        '
        Me.mnuPictureContext.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DrawBorderToolStripMenuItem})
        Me.mnuPictureContext.Name = "mnuPictureContext"
        Me.mnuPictureContext.Size = New System.Drawing.Size(148, 26)
        '
        'DrawBorderToolStripMenuItem
        '
        Me.DrawBorderToolStripMenuItem.Name = "DrawBorderToolStripMenuItem"
        Me.DrawBorderToolStripMenuItem.Size = New System.Drawing.Size(147, 22)
        Me.DrawBorderToolStripMenuItem.Text = "DrawBorder"
        '
        'tbrMainToolbar
        '
        Me.tbrMainToolbar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tbbOpenPicture, Me.tbbDrawBorder, Me.ToolStripSeparator2, Me.tbbOptions, Me.tbbGetFileAttributes})
        Me.tbrMainToolbar.Location = New System.Drawing.Point(0, 25)
        Me.tbrMainToolbar.Name = "tbrMainToolbar"
        Me.tbrMainToolbar.Size = New System.Drawing.Size(384, 25)
        Me.tbrMainToolbar.TabIndex = 10
        Me.tbrMainToolbar.Text = "ToolStrip1"
        '
        'tbbOpenPicture
        '
        Me.tbbOpenPicture.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tbbOpenPicture.Image = Global.PictureViewer.My.Resources.Resources.Open
        Me.tbbOpenPicture.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tbbOpenPicture.Name = "tbbOpenPicture"
        Me.tbbOpenPicture.Size = New System.Drawing.Size(23, 22)
        Me.tbbOpenPicture.Text = "Open Picture"
        '
        'tbbDrawBorder
        '
        Me.tbbDrawBorder.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tbbDrawBorder.Image = Global.PictureViewer.My.Resources.Resources.DrawBorder
        Me.tbbDrawBorder.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tbbDrawBorder.Name = "tbbDrawBorder"
        Me.tbbDrawBorder.Size = New System.Drawing.Size(23, 22)
        Me.tbbDrawBorder.Text = "Draw Border"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'tbbOptions
        '
        Me.tbbOptions.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tbbOptions.Image = Global.PictureViewer.My.Resources.Resources.Options1
        Me.tbbOptions.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tbbOptions.Name = "tbbOptions"
        Me.tbbOptions.Size = New System.Drawing.Size(23, 22)
        Me.tbbOptions.Text = "Options"
        '
        'tbbGetFileAttributes
        '
        Me.tbbGetFileAttributes.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tbbGetFileAttributes.Image = Global.PictureViewer.My.Resources.Resources.Properties
        Me.tbbGetFileAttributes.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tbbGetFileAttributes.Name = "tbbGetFileAttributes"
        Me.tbbGetFileAttributes.Size = New System.Drawing.Size(23, 22)
        Me.tbbGetFileAttributes.Text = "Get File Attributes"
        '
        'sbrMyStatusStrip
        '
        Me.sbrMyStatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblStatus})
        Me.sbrMyStatusStrip.Location = New System.Drawing.Point(0, 300)
        Me.sbrMyStatusStrip.Name = "sbrMyStatusStrip"
        Me.sbrMyStatusStrip.Size = New System.Drawing.Size(384, 22)
        Me.sbrMyStatusStrip.TabIndex = 11
        Me.sbrMyStatusStrip.Text = "StatusStrip1"
        '
        'lblStatus
        '
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(369, 17)
        Me.lblStatus.Spring = True
        Me.lblStatus.Text = "No image loaded"
        Me.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'picShowPicture
        '
        Me.picShowPicture.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.picShowPicture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picShowPicture.ContextMenuStrip = Me.mnuPictureContext
        Me.picShowPicture.Location = New System.Drawing.Point(8, 59)
        Me.picShowPicture.Name = "picShowPicture"
        Me.picShowPicture.Size = New System.Drawing.Size(320, 238)
        Me.picShowPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picShowPicture.TabIndex = 2
        Me.picShowPicture.TabStop = False
        '
        'ViewerForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(384, 322)
        Me.Controls.Add(Me.sbrMyStatusStrip)
        Me.Controls.Add(Me.tbrMainToolbar)
        Me.Controls.Add(Me.lblY)
        Me.Controls.Add(Me.lblX)
        Me.Controls.Add(Me.btnShrink)
        Me.Controls.Add(Me.btnEnlarge)
        Me.Controls.Add(Me.picShowPicture)
        Me.Controls.Add(Me.mnuMainMenu)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.mnuMainMenu
        Me.MinimumSize = New System.Drawing.Size(400, 360)
        Me.Name = "ViewerForm"
        Me.Text = "Picture Viewer"
        Me.mnuMainMenu.ResumeLayout(False)
        Me.mnuMainMenu.PerformLayout()
        Me.mnuPictureContext.ResumeLayout(False)
        Me.tbrMainToolbar.ResumeLayout(False)
        Me.tbrMainToolbar.PerformLayout()
        Me.sbrMyStatusStrip.ResumeLayout(False)
        Me.sbrMyStatusStrip.PerformLayout()
        CType(Me.picShowPicture, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents picShowPicture As System.Windows.Forms.PictureBox
    Friend WithEvents ofdSelectPicture As System.Windows.Forms.OpenFileDialog
    Friend WithEvents btnEnlarge As System.Windows.Forms.Button
    Friend WithEvents btnShrink As System.Windows.Forms.Button
    Friend WithEvents lblX As System.Windows.Forms.Label
    Friend WithEvents lblY As System.Windows.Forms.Label
    Friend WithEvents mnuMainMenu As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuOpenPicture As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuQuit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuDrawBorder As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mnuOptions As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuConfirmOnExit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuPictureContext As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents DrawBorderToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tbrMainToolbar As System.Windows.Forms.ToolStrip
    Friend WithEvents tbbOpenPicture As System.Windows.Forms.ToolStripButton
    Friend WithEvents tbbDrawBorder As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tbbOptions As System.Windows.Forms.ToolStripButton
    Friend WithEvents sbrMyStatusStrip As System.Windows.Forms.StatusStrip
    Friend WithEvents lblStatus As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents tbbGetFileAttributes As System.Windows.Forms.ToolStripButton
    Friend WithEvents mnuProperties As System.Windows.Forms.ToolStripMenuItem

End Class
