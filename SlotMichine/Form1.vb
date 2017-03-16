Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox1.Text = RandomChar()
        TextBox2.Text = RandomChar()
        TextBox3.Text = RandomChar()
        If TextBox1.Text = TextBox2.Text AndAlso TextBox2.Text = TextBox3.Text Then
            MsgBox("Winner!")
        Else
            '  MsgBox("Loser!")
        End If
    End Sub
    Public Function RandomChar(Optional validchars As String = "¶■¥©§") As String
        RandomChar = ""
        Randomize()
        RandomChar &= Mid(validchars, Int(Rnd() * validchars.Length) + 1, 1)
    End Function
End Class
