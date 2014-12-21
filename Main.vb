Public Class Main
    Dim fromFileName As String
    Dim saveFileName As String

    Private Sub Open_Click(sender As System.Object, e As System.EventArgs) Handles Open.Click
        Dim fd As OpenFileDialog = New OpenFileDialog()

        fd.Title = "Open"
        fd.Filter = "PNG|*.png|JPG|*.jpg|GIF|*.gif|ICON|*.ico|All files|*.*"
        fd.FilterIndex = 5
        fd.RestoreDirectory = True

        If fd.ShowDialog() = DialogResult.OK Then
            fromFileName = fd.FileName
        End If

        OpenT.Text = fromFileName
    End Sub

    Private Sub Start_Click(sender As System.Object, e As System.EventArgs) Handles Start.Click
        Try
            Dim img As Bitmap
            Dim sFileName As String = fromFileName
            Dim fs As New System.IO.FileStream(sFileName, System.IO.FileMode.Open)
            img = Bitmap.FromStream(fs)
            fs.Close()
            Dim Imgs As New Bitmap(img.Width, img.Height)
            Dim y As Integer = 0
            Dim x As Integer = 0
            ProgressBar1.Minimum = 0
            ProgressBar1.Maximum = img.Width
            While x < img.Width
                While y < img.Height
                    Dim inputs As String = Microsoft.VisualBasic.Hex(img.GetPixel(x, y).ToArgb)
                    Dim parts As New List(Of String)
                    For i As Integer = 0 To inputs.Length - 1 Step 2
                        parts.Add(inputs.Substring(i, IIf(i + 2 < inputs.Length, 2, inputs.Length - i)))
                    Next
                    Dim r As Integer = Convert.ToInt32(parts(1), 16)
                    Dim g As Integer = Convert.ToInt32(parts(2), 16)
                    Dim b As Integer = Convert.ToInt32(parts(3), 16)
                    Dim pix As Integer
                    pix = (r + g + b) / 3
                    Imgs.SetPixel(x, y, Color.FromArgb(255, pix, pix, pix))
                    y = y + 1
                End While
                y = 0
                x = x + 1
                ProgressBar1.Value = x
            End While
            img.Dispose()
            Imgs.Save(saveFileName, Imaging.ImageFormat.Png)
        Catch ex As Exception
            '' Debug here :P
        End Try
    End Sub

    Private Sub Save_Click(sender As System.Object, e As System.EventArgs) Handles Save.Click

        Dim fs As New SaveFileDialog()
        fs.Filter = "PNG|*.png"
        fs.Title = "Save to"
        fs.ShowDialog()


        If fs.FileName <> "" Then
            saveFileName = fs.FileName
        End If

        SaveT.Text = saveFileName
    End Sub

    Private Sub OpenT_TextChanged(sender As System.Object, e As System.EventArgs) Handles OpenT.TextChanged
        fromFileName = OpenT.Text
    End Sub

    Private Sub SaveT_TextChanged(sender As System.Object, e As System.EventArgs) Handles SaveT.TextChanged
        saveFileName = SaveT.Text
    End Sub

End Class

