Public Class Form5
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ClientsRecordBindingSource.EndEdit()
        Client_sRecordTableAdapter.Update(ClientRecordsDataSet._Client_sRecord)
        MessageBox.Show("Updated", "Table", MessageBoxButtons.OK, MessageBoxIcon.Information)

    End Sub




    Private Sub FillBy11ToolStripButton_Click(sender As Object, e As EventArgs) Handles FillBy11ToolStripButton.Click
        Try
            Me.Client_sRecordTableAdapter.FillBy11(Me.ClientRecordsDataSet._Client_sRecord, Last_NameToolStripTextBox.Text)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Client_sRecordTableAdapter.FillBy1(Me.ClientRecordsDataSet._Client_sRecord, TextBox9.Text)
    End Sub

    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ClientRecordsDataSet._Client_sRecord' table. You can move, or remove it, as needed.
        Me.Client_sRecordTableAdapter.Fill(Me.ClientRecordsDataSet._Client_sRecord)
        DataGridView2.Parent = PictureBox1
        Button1.Parent = PictureBox1
        Button2.Parent = PictureBox1
        Button3.Parent = PictureBox1
        Label1.Parent = PictureBox1
        Label2.Parent = PictureBox1
        Label3.Parent = PictureBox1
        Label4.Parent = PictureBox1
        Label5.Parent = PictureBox1
        Label6.Parent = PictureBox1
        Label7.Parent = PictureBox1
        Label8.Parent = PictureBox1
        Label10.Parent = PictureBox1
        Label11.Parent = PictureBox1
        Label12.Parent = PictureBox1
        Label14.Parent = PictureBox1
        Label15.Parent = PictureBox1


    End Sub


    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Form3.Show()
        Me.Hide()

    End Sub

    Private Sub TextBox12_TextChanged(sender As Object, e As EventArgs) Handles TextBox12.TextChanged

    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click

    End Sub

    Private Sub Label11_Click(sender As Object, e As EventArgs) Handles Label11.Click

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click

    End Sub

    Private Sub Label15_Click(sender As Object, e As EventArgs) Handles Label15.Click

    End Sub

    Private Sub TextBox8_TextChanged(sender As Object, e As EventArgs) Handles TextBox8.TextChanged

    End Sub

    Private Sub TextBox7_TextChanged(sender As Object, e As EventArgs) Handles TextBox7.TextChanged

    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged

    End Sub

    Private Sub Label12_Click(sender As Object, e As EventArgs) Handles Label12.Click

    End Sub

    Private Sub TextBox11_TextChanged(sender As Object, e As EventArgs) Handles TextBox11.TextChanged

    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged

    End Sub

    Private Sub TextBox9_Enter(sender As Object, e As EventArgs) Handles TextBox9.Enter
        If TextBox9.Text = "First Name" Then
            TextBox9.Text = ""
            TextBox9.ForeColor = Color.White

        End If
    End Sub

    Private Sub TextBox9_Leave(sender As Object, e As EventArgs) Handles TextBox9.Leave
        If TextBox9.Text = "" Then
            TextBox9.Text = "First Name"
            TextBox9.ForeColor = Color.LightGray

        End If
    End Sub


End Class