<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OptionsForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(OptionsForm))
        Me.btnOK = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.tabOptions = New System.Windows.Forms.TabControl()
        Me.pgeGeneral = New System.Windows.Forms.TabPage()
        Me.chkPromptOnExit = New System.Windows.Forms.CheckBox()
        Me.txtUserName = New System.Windows.Forms.TextBox()
        Me.lblUserName = New System.Windows.Forms.Label()
        Me.pgeAppearance = New System.Windows.Forms.TabPage()
        Me.grpDefaultBackcolor = New System.Windows.Forms.GroupBox()
        Me.optBackgroundWhite = New System.Windows.Forms.RadioButton()
        Me.optBackgroundDefault = New System.Windows.Forms.RadioButton()
        Me.tabOptions.SuspendLayout()
        Me.pgeGeneral.SuspendLayout()
        Me.pgeAppearance.SuspendLayout()
        Me.grpDefaultBackcolor.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnOK
        '
        Me.btnOK.Location = New System.Drawing.Point(305, 12)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(75, 23)
        Me.btnOK.TabIndex = 0
        Me.btnOK.Text = "OK"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Location = New System.Drawing.Point(305, 38)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 3
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'tabOptions
        '
        Me.tabOptions.Controls.Add(Me.pgeGeneral)
        Me.tabOptions.Controls.Add(Me.pgeAppearance)
        Me.tabOptions.Location = New System.Drawing.Point(12, 12)
        Me.tabOptions.Name = "tabOptions"
        Me.tabOptions.SelectedIndex = 0
        Me.tabOptions.Size = New System.Drawing.Size(287, 149)
        Me.tabOptions.TabIndex = 6
        '
        'pgeGeneral
        '
        Me.pgeGeneral.Controls.Add(Me.chkPromptOnExit)
        Me.pgeGeneral.Controls.Add(Me.txtUserName)
        Me.pgeGeneral.Controls.Add(Me.lblUserName)
        Me.pgeGeneral.Location = New System.Drawing.Point(4, 22)
        Me.pgeGeneral.Name = "pgeGeneral"
        Me.pgeGeneral.Padding = New System.Windows.Forms.Padding(3)
        Me.pgeGeneral.Size = New System.Drawing.Size(279, 123)
        Me.pgeGeneral.TabIndex = 0
        Me.pgeGeneral.Text = "General"
        Me.pgeGeneral.UseVisualStyleBackColor = True
        '
        'chkPromptOnExit
        '
        Me.chkPromptOnExit.AutoSize = True
        Me.chkPromptOnExit.Location = New System.Drawing.Point(39, 76)
        Me.chkPromptOnExit.Name = "chkPromptOnExit"
        Me.chkPromptOnExit.Size = New System.Drawing.Size(174, 16)
        Me.chkPromptOnExit.TabIndex = 7
        Me.chkPromptOnExit.Text = "Prompt to confirm on exit"
        Me.chkPromptOnExit.UseVisualStyleBackColor = True
        '
        'txtUserName
        '
        Me.txtUserName.Location = New System.Drawing.Point(102, 33)
        Me.txtUserName.Name = "txtUserName"
        Me.txtUserName.Size = New System.Drawing.Size(139, 21)
        Me.txtUserName.TabIndex = 6
        Me.txtUserName.Tag = ""
        '
        'lblUserName
        '
        Me.lblUserName.AutoSize = True
        Me.lblUserName.Location = New System.Drawing.Point(37, 36)
        Me.lblUserName.Name = "lblUserName"
        Me.lblUserName.Size = New System.Drawing.Size(65, 12)
        Me.lblUserName.TabIndex = 5
        Me.lblUserName.Text = "User Name:"
        '
        'pgeAppearance
        '
        Me.pgeAppearance.Controls.Add(Me.grpDefaultBackcolor)
        Me.pgeAppearance.Location = New System.Drawing.Point(4, 22)
        Me.pgeAppearance.Name = "pgeAppearance"
        Me.pgeAppearance.Padding = New System.Windows.Forms.Padding(3)
        Me.pgeAppearance.Size = New System.Drawing.Size(279, 123)
        Me.pgeAppearance.TabIndex = 1
        Me.pgeAppearance.Text = "Appearance"
        Me.pgeAppearance.UseVisualStyleBackColor = True
        '
        'grpDefaultBackcolor
        '
        Me.grpDefaultBackcolor.Controls.Add(Me.optBackgroundWhite)
        Me.grpDefaultBackcolor.Controls.Add(Me.optBackgroundDefault)
        Me.grpDefaultBackcolor.Location = New System.Drawing.Point(44, 26)
        Me.grpDefaultBackcolor.Name = "grpDefaultBackcolor"
        Me.grpDefaultBackcolor.Size = New System.Drawing.Size(200, 72)
        Me.grpDefaultBackcolor.TabIndex = 6
        Me.grpDefaultBackcolor.TabStop = False
        Me.grpDefaultBackcolor.Text = "Default Background Color"
        '
        'optBackgroundWhite
        '
        Me.optBackgroundWhite.AutoSize = True
        Me.optBackgroundWhite.Location = New System.Drawing.Point(14, 42)
        Me.optBackgroundWhite.Name = "optBackgroundWhite"
        Me.optBackgroundWhite.Size = New System.Drawing.Size(53, 16)
        Me.optBackgroundWhite.TabIndex = 1
        Me.optBackgroundWhite.Text = "White"
        Me.optBackgroundWhite.UseVisualStyleBackColor = True
        '
        'optBackgroundDefault
        '
        Me.optBackgroundDefault.AutoSize = True
        Me.optBackgroundDefault.Checked = True
        Me.optBackgroundDefault.Location = New System.Drawing.Point(14, 19)
        Me.optBackgroundDefault.Name = "optBackgroundDefault"
        Me.optBackgroundDefault.Size = New System.Drawing.Size(95, 16)
        Me.optBackgroundDefault.TabIndex = 0
        Me.optBackgroundDefault.TabStop = True
        Me.optBackgroundDefault.Text = "Default Gray"
        Me.optBackgroundDefault.UseVisualStyleBackColor = True
        '
        'OptionsForm
        '
        Me.AcceptButton = Me.btnOK
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.PictureViewer.My.Resources.Resources.Options
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(384, 262)
        Me.Controls.Add(Me.tabOptions)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnOK)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "OptionsForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Picture Viewer Options"
        Me.tabOptions.ResumeLayout(False)
        Me.pgeGeneral.ResumeLayout(False)
        Me.pgeGeneral.PerformLayout()
        Me.pgeAppearance.ResumeLayout(False)
        Me.grpDefaultBackcolor.ResumeLayout(False)
        Me.grpDefaultBackcolor.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnOK As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents tabOptions As System.Windows.Forms.TabControl
    Friend WithEvents pgeGeneral As System.Windows.Forms.TabPage
    Friend WithEvents chkPromptOnExit As System.Windows.Forms.CheckBox
    Friend WithEvents txtUserName As System.Windows.Forms.TextBox
    Friend WithEvents lblUserName As System.Windows.Forms.Label
    Friend WithEvents pgeAppearance As System.Windows.Forms.TabPage
    Friend WithEvents grpDefaultBackcolor As System.Windows.Forms.GroupBox
    Friend WithEvents optBackgroundWhite As System.Windows.Forms.RadioButton
    Friend WithEvents optBackgroundDefault As System.Windows.Forms.RadioButton
End Class
