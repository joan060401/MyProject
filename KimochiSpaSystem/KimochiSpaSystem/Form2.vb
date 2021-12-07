Public Class Form2

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ClientRecordsDataSet._Client_sRecord' table. You can move, or remove it, as needed.
        Me.Client_sRecordTableAdapter.Fill(Me.ClientRecordsDataSet._Client_sRecord)

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
        Label9.Parent = PictureBox1
        Label10.Parent = PictureBox1
        Label11.Parent = PictureBox1
        Label12.Parent = PictureBox1
        Label13.Parent = PictureBox1
        Label1.Parent = PictureBox1



    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If String.IsNullOrEmpty(TextBox12.Text.Trim) Then
            MessageBox.Show("Complete the form before saving")
        Else
            Try
                Dim result As DialogResult
                result = MessageBox.Show("Do you want to save the selected record?", "Save Data: Succeessfull",
                            MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If (result = DialogResult.Yes) Then
                    Validate()
                    ClientsRecordBindingSource.EndEdit()
                    Client_sRecordTableAdapter.Update(ClientRecordsDataSet._Client_sRecord)
                    MessageBox.Show("Save Successfully",
                "Save Data: Succcess", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    RefreshData()
                End If
            Catch ex As Exception
                MessageBox.Show("Save Data Failed: " & ex.Message.ToString(),
                "Save Data: Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ClientsRecordBindingSource.AddNew()

    End Sub

    Private Sub RefreshData()
        Try
            ClientsRecordBindingSource.Filter = Nothing
            Client_sRecordTableAdapter.Fill(ClientRecordsDataSet._Client_sRecord)
        Catch ex As Exception
            MsgBox("Refresh Data Error!")
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form4.Show()
        Me.Hide()

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim a As String
        Dim sum As Integer
        a = ComboBox1.Text
        Dim c As Integer
        c = TextBox6.Text
        Dim b As Integer
        If (a = "Massage") Then
            b = 300
        ElseIf (a = "Pedicure") Then
            b = 250
        ElseIf (a = "Manicure") Then
            b = 150
        ElseIf (a = "Footspa") Then
            b = 200
        ElseIf (a = "Ear Candling") Then
            b = 180
        End If


        sum = b * c

        TextBox8.Text = sum


    End Sub

    Private Sub ComboBox1_MouseHover(sender As Object, e As EventArgs) Handles ComboBox1.MouseHover
        If ComboBox1.Text = "<----------S e l e c t----------->" Then
            ComboBox1.Text = ""
            ComboBox1.ForeColor = Color.Black
        End If
    End Sub
    Private Sub ComboBox1_MouseLeave(sender As Object, e As EventArgs) Handles ComboBox1.MouseLeave
        If ComboBox1.Text = "" Then
            ComboBox1.Text = "<----------S e l e c t----------->"
            ComboBox1.ForeColor = Color.Gray
        End If
    End Sub

    Private Sub ComboBox2_MouseHover(sender As Object, e As EventArgs) Handles ComboBox2.MouseHover
        If ComboBox2.Text <= "----------S e l e c t----------->e" Then
            ComboBox2.Text = ""
            ComboBox2.ForeColor = Color.Black
        End If
    End Sub

    Private Sub ComboBox2_MouseLeave(sender As Object, e As EventArgs) Handles ComboBox2.MouseLeave
        If ComboBox2.Text = "" Then
            ComboBox2.Text = "<----------S e l e c t----------->"
            ComboBox2.ForeColor = Color.Gray
        End If
    End Sub


End Class