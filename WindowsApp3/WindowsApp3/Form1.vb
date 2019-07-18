Public Class FORM1
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BUTTON1_Click(sender As Object, e As EventArgs) Handles BUTTON1.Click

        FORM2.Show()


    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Dim p1_name As String = TextBox1.Text
        FORM2.TextBox1.Text = p1_name
        Form3.TextBox1.Text = p1_name

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        Dim p2_name As String = TextBox2.Text
        FORM2.TextBox2.Text = p2_name
        Form3.TextBox2.Text = p2_name
    End Sub

End Class