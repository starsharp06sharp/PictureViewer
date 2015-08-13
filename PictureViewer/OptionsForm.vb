Public Class OptionsForm

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        Me.Close()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub tabOptions_Click(sender As Object, e As EventArgs) Handles tabOptions.Click
        MessageBox.Show("tabOptions Clicked!")
    End Sub

    Private Sub tabOptions_SelectedIndexChanged(sender As Object, e As EventArgs) Handles tabOptions.SelectedIndexChanged
        MessageBox.Show("Change No" & tabOptions.SelectedIndex & " Tab " & tabOptions.TabPages.Item(tabOptions.SelectedIndex).Text)
    End Sub
End Class