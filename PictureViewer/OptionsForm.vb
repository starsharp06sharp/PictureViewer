Public Class OptionsForm
    Private Sub OptionsForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        txtUserName.Text = RegistryModule.UserName

        chkPromptOnExit.Checked = RegistryModule.PromptOnExit

        If RegistryModule.BackColor = "Gray" Then
            optBackgroundDefault.Checked = True
        Else
            optBackgroundWhite.Checked = True
        End If
    End Sub

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        RegistryModule.UserName = txtUserName.Text

        RegistryModule.PromptOnExit = chkPromptOnExit.Checked

        If optBackgroundDefault.Checked Then
            RegistryModule.BackColor = "Gray"
        Else
            RegistryModule.BackColor = "White"
        End If

        ViewerForm.LoadSettings()
        Me.Close()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
End Class