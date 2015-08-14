Module DrawingModule
    Public Sub OpenPicture()
        'Show the open file dialog box.
        If ViewerForm.ofdSelectPicture.ShowDialog = DialogResult.OK Then
            Try
                'Load the picture into the picture box.
                ViewerForm.picShowPicture.Image = _
                    Image.FromFile(ViewerForm.ofdSelectPicture.FileName)
            Catch exNotPic As System.OutOfMemoryException
                MessageBox.Show("The file you have chosen is not an image file.", _
                                "别闹", MessageBoxButtons.OK, _
                                MessageBoxIcon.Information)
            Catch exUnknown As Exception
                MessageBox.Show("An unknown error has occurred: " & exUnknown.Message)
            End Try

            'show the name of the file in the statusbar
            ViewerForm.sbrMyStatusStrip.Items(0).Text = _
                ViewerForm.ofdSelectPicture.FileName
        End If
    End Sub

    Public Sub DrawBorder(ByRef objPicturebox As PictureBox)
        Dim objGraphics As Graphics
        objGraphics = objPicturebox.Parent.CreateGraphics
        objGraphics.Clear(SystemColors.Control)

        objGraphics.DrawRectangle(Pens.Blue, _
                                  objPicturebox.Left - 1, objPicturebox.Top - 1, _
                                  objPicturebox.Width + 1, objPicturebox.Height + 1)

        objGraphics.Dispose()
    End Sub
End Module
