Public Class Counter
    Private i As Integer = 0
    Private a As Integer = 1
    Private Sub Counter_btn_MouseDown(sender As Object, e As MouseEventArgs) Handles Counter_btn.MouseDown
        If e.Button = MouseButtons.Left And a = 1 Then
            i += 1
        End If
        If e.Button = MouseButtons.Right And a = 1 Then
            i -= 1
        End If
        If e.Button = MouseButtons.Left And a = 5 Then
            i += 5
        End If
        If e.Button = MouseButtons.Right And a = 5 Then
            i -= 5
        End If
        If e.Button = MouseButtons.Left And a = 10 Then
            i += 10
        End If
        If e.Button = MouseButtons.Right And a = 10 Then
            i -= 10
        End If
        Counter_txt.Text = i.ToString
        My.Computer.FileSystem.WriteAllText("..\..\obj\Debug\Counter_save.txt", Counter_txt.Text, False)
    End Sub

    Private Sub save_btn_MouseDown(sender As Object, e As MouseEventArgs) Handles save_btn.MouseDown
        Dateiauswahl()
        If Save_txt.Text <> "" Then
            My.Computer.FileSystem.WriteAllText(Save_txt.Text, Counter_txt.Text, False)
        End If
        Counter_btn.Select()
    End Sub

    Private Sub Open_btn_Click(sender As Object, e As EventArgs) Handles Open_btn.Click
        Dim dateidialog As OpenFileDialog = New OpenFileDialog
        dateidialog.FileName = "*.txt"
        dateidialog.InitialDirectory = "Saves"
        If dateidialog.ShowDialog() = DialogResult.OK Then
            Save_txt.Text = dateidialog.FileName
        Else
            Save_txt.Text = ""
        End If
        If Save_txt.Text <> "" Then
            Dim filereader As String
            filereader = My.Computer.FileSystem.ReadAllText("" & Save_txt.Text)
            i = filereader
            Counter_txt.Text = i.ToString
        End If
        Counter_btn.Select()
    End Sub

    Private Sub Counter_Closing(sender As Object, e As FormClosingEventArgs) Handles Me.Closing
        My.Computer.FileSystem.WriteAllText("..\..\obj\Debug\Counter_save.txt", Counter_txt.Text, False)
    End Sub

    Private Sub Dateiauswahl()
        Dim dateidialog As SaveFileDialog = New SaveFileDialog()
        dateidialog.FileName = "*.txt"
        dateidialog.InitialDirectory = "..\..\Saves"
        If dateidialog.ShowDialog() = DialogResult.OK Then
            Save_txt.Text = dateidialog.FileName
        Else
            Save_txt.Text = ""
        End If
    End Sub

    Private Sub Counter_btn_KeyDown(sender As Object, e As KeyEventArgs) Handles Counter_btn.KeyDown
        If e.KeyCode = Keys.Space And a = 1 Then
            i += 1
        End If
        If e.KeyCode = Keys.Space And a = 5 Then
            i += 5
        End If
        If e.KeyCode = Keys.Space And a = 10 Then
            i += 10
        End If
        Counter_txt.Text = i.ToString
        My.Computer.FileSystem.WriteAllText("..\..\obj\Debug\Counter_save.txt", Counter_txt.Text, False)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        a = 1
        txt_countup.Text = "+1"
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        a = 5
        txt_countup.Text = "+5"

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        a = 10
        txt_countup.Text = "+10"
    End Sub

    Private Sub New_btn_Click(sender As Object, e As EventArgs) Handles New_btn.Click
        i = 0
        Counter_txt.Text = i.ToString
        Save_txt.Text = ""
    End Sub
End Class

