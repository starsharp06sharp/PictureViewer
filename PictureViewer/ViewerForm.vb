﻿Public Class ViewerForm

    Private Sub ViewerForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.LoadSettings()
    End Sub

    Public Sub LoadSettings()
        If RegistryModule.BackColor = "Gray" Then
            picShowPicture.BackColor = System.Drawing.SystemColors.Control
        Else
            picShowPicture.BackColor = Color.White
        End If

        mnuConfirmOnExit.Checked = RegistryModule.PromptOnExit
    End Sub

    Private Sub ViewerForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If mnuConfirmOnExit.Checked Then
            If MessageBox.Show("Close the Picture Viewer program?", _
                               "Picture Viewer", MessageBoxButtons.YesNo, _
                               MessageBoxIcon.Question) = _
               Windows.Forms.DialogResult.No Then
                e.Cancel = True
            End If
        End If
    End Sub

    Private Sub btnEnlarge_Click(sender As Object, e As EventArgs) Handles btnEnlarge.Click
        Me.Width += 20
        Me.Height += 20
    End Sub

    Private Sub btnShrink_Click(sender As Object, e As EventArgs) Handles btnShrink.Click
        Me.Width -= 20
        Me.Height -= 20
    End Sub

    Private Sub picShowPicture_MouseLeave(sender As Object, e As EventArgs) Handles picShowPicture.MouseLeave
        lblX.Text = "X:"
        lblY.Text = "Y:"
    End Sub

    Private Sub picShowPicture_MouseMove(sender As Object, e As MouseEventArgs) Handles picShowPicture.MouseMove
        lblX.Text = "X: " & e.X
        lblY.Text = "Y: " & e.Y
    End Sub

    Private Sub mnuOpenPicture_Click(sender As Object, e As EventArgs) Handles mnuOpenPicture.Click
        DrawingModule.OpenPicture()
    End Sub

    Private Sub mnuConfirmOnExit_Click(sender As Object, e As EventArgs) Handles mnuConfirmOnExit.Click
        mnuConfirmOnExit.Checked = Not (mnuConfirmOnExit.Checked)
        RegistryModule.PromptOnExit = mnuConfirmOnExit.Checked
    End Sub

    Private Sub mnuProperties_Click(sender As Object, e As EventArgs) Handles mnuProperties.Click
        Dim strProperties As String
        Dim lngAttributes As Long

        If ofdSelectPicture.FileName = "" Then Exit Sub

        'Get the dates
        strProperties = "Created: " & _
            System.IO.File.GetCreationTime(ofdSelectPicture.FileName)

        strProperties &= vbCrLf
        strProperties &= "Accessed: " & _
            System.IO.File.GetLastAccessTime(ofdSelectPicture.FileName)
        strProperties &= vbCrLf
        strProperties &= "Modified: " & _
            System.IO.File.GetLastWriteTime(ofdSelectPicture.FileName)

        'Get the file attributes
        lngAttributes = System.IO.File.GetAttributes(ofdSelectPicture.FileName)

        'Use a binary ND to extract the specific attributes
        strProperties &= vbCrLf
        strProperties &= "Hidden: " & _
            CBool(lngAttributes And IO.FileAttributes.Hidden)

        strProperties &= vbCrLf
        strProperties &= "ReadOnly: " & _
            CBool(lngAttributes And IO.FileAttributes.ReadOnly)

        strProperties &= vbCrLf
        strProperties &= "System: " & _
            CBool(lngAttributes And IO.FileAttributes.System)

        strProperties &= vbCrLf
        strProperties &= "Archive: " & _
            CBool(lngAttributes And IO.FileAttributes.Archive)

        MessageBox.Show(strProperties, "Picture Viewer")
    End Sub

    Private Sub mnuQuit_Click(sender As Object, e As EventArgs) Handles mnuQuit.Click
        Me.Close()
    End Sub

    Private Sub mnuDrawBorder_Click(sender As Object, e As EventArgs) Handles mnuDrawBorder.Click
        DrawingModule.DrawBorder(picShowPicture)
    End Sub

    Private Sub mnuOptions_Click(sender As Object, e As EventArgs) Handles mnuOptions.Click
        OptionsForm.ShowDialog()
    End Sub

    Private Sub DrawBorderToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DrawBorderToolStripMenuItem.Click
        Dim objGraphics As Graphics
        objGraphics = Me.CreateGraphics()
        objGraphics.Clear(SystemColors.Control)
        objGraphics.DrawRectangle(Pens.Blue, picShowPicture.Left - 1, _
                                  picShowPicture.Top - 1, _
                                  picShowPicture.Width + 1, _
                                  picShowPicture.Height + 1)
        objGraphics.Dispose()
    End Sub

    Private Sub tbbOpenPicture_Click(sender As Object, e As EventArgs) Handles tbbOpenPicture.Click
        mnuOpenPicture_Click(sender, e)
    End Sub

    Private Sub tbbDrawBorder_Click(sender As Object, e As EventArgs) Handles tbbDrawBorder.Click
        mnuDrawBorder_Click(sender, e)
    End Sub

    Private Sub tbbOptions_Click(sender As Object, e As EventArgs) Handles tbbOptions.Click
        mnuOptions_Click(sender, e)
    End Sub

    Private Sub tbbGetFileAttributes_Click(sender As Object, e As EventArgs) Handles tbbGetFileAttributes.Click
        mnuProperties_Click(sender, e)
    End Sub
End Class
