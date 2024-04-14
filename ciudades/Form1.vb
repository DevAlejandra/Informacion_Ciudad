Public Class Form1
    Private Sub RadioButton1_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RadioButton1.CheckedChanged, RadioButton2.CheckedChanged

        If RadioButton1.Checked = True Then
            Try
                PictureBox1.Image = Image.FromFile("Reynosa.jpg")
            Catch ex As Exception
            End Try
            Try
                RichTextBox1.LoadFile("Texto_Reynosa.rtf")

            Catch ex As Exception
                MessageBox.Show(ex.Message)

            End Try
            AxWindowsMediaPlayer1.URL = "Video_Reynosa.mp4"
            AxWindowsMediaPlayer1.Ctlcontrols.stop()
        ElseIf RadioButton2.Checked = True Then
            Try
                PictureBox1.Image = Image.FromFile("Matamoros.jpg")
            Catch ex As Exception
                MessageBox.Show(ex.Message)

            End Try
            Try
                RichTextBox1.LoadFile("Texto_Matamoros.rtf")

            Catch ex As Exception
                MessageBox.Show(ex.Message)

            End Try
            AxWindowsMediaPlayer1.URL = "Video_Matamoros.mp4"
            AxWindowsMediaPlayer1.Ctlcontrols.stop()
        ElseIf RadioButton3.Checked = True Then
            Try
                PictureBox1.Image = Image.FromFile("Victoria.png")
            Catch ex As Exception
                MessageBox.Show(ex.Message)

            End Try
            Try
                RichTextBox1.LoadFile("Texto_Victoria.rtf")
            Catch ex As Exception
                MessageBox.Show(ex.Message)

            End Try
            AxWindowsMediaPlayer1.URL = "Video_Victoria.mp4"
        End If

    End Sub
    Private Sub RadioButton3_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RadioButton3.CheckedChanged

        Try
            PictureBox1.Image = Image.FromFile("Victoria.png")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Try
            RichTextBox1.LoadFile("Texto_Victoria.rtf")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        AxWindowsMediaPlayer1.URL = "Video_Victoria.mp4"
        AxWindowsMediaPlayer1.Ctlcontrols.stop()
    End Sub

End Class
