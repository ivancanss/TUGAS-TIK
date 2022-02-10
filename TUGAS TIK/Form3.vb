Public Class Form3
    Private Sub form3_load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DateTimePicker1.Format = DateTimePickerFormat.Short
        DateTimePicker1.CustomFormat = "dd/mm/yyyy"
        DateTimePicker1.Value = Format(Now)
    End Sub

    Private Sub button1_click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        TextBox1.Text = DateTimePicker1.Text

    End Sub
End Class