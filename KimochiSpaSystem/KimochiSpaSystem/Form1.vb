Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CheckBox1.Parent = PictureBox1
        Button1.Parent = PictureBox1

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "kimochi_user" And TextBox2.Text = "pas1234" Then
            Form4.Show()
            Me.Hide()

        Else
            MsgBox("Incorrect", MsgBoxStyle.Information, "Login")

        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            TextBox2.UseSystemPasswordChar = True
        Else
            TextBox2.UseSystemPasswordChar = False

        End If
    End Sub



    Private Sub TextBox2_Enter(sender As Object, e As EventArgs) Handles TextBox2.Enter
        If TextBox2.Text = "Password" Then
            TextBox2.Text = ""
            TextBox2.PasswordChar = "*"
            TextBox2.ForeColor = Color.Black

        End If
    End Sub

    Private Sub TextBox1_Enter(sender As Object, e As EventArgs) Handles TextBox1.Enter
        If TextBox1.Text = "Username" Then
            TextBox1.Text = ""
            TextBox1.ForeColor = Color.Black

        End If
    End Sub

    Private Sub TextBox1_Leave(sender As Object, e As EventArgs) Handles TextBox1.Leave
        If TextBox1.Text = "" Then
            TextBox1.Text = "Username"
            TextBox1.ForeColor = Color.Gray

        End If
    End Sub

    Private Sub TextBox2_Leave(sender As Object, e As EventArgs) Handles TextBox2.Leave
        If TextBox2.Text = "" Then
            TextBox2.Text = "Password"

            TextBox2.ForeColor = Color.Gray

        End If
    End Sub

End Class
