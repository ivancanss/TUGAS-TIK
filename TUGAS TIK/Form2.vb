Public Class Form2
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        MessageBox.Show(Label1.Text & vbCrLf & ComboBox1.Text & vbCrLf & ComboBox2.Text & vbCrLf & ComboBox3.Text, "Hasil", MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        End

    End Sub
End Class