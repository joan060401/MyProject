Imports System.Data.OleDb
Public Class Form3
    Dim conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\joanna\source\repos\ClientRecords.accdb")
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ClientRecordsDataSet._Client_sRecord' table. You can move, or remove it, as needed.
        Me.Client_sRecordTableAdapter.Fill(Me.ClientRecordsDataSet._Client_sRecord)
        Button5.Parent = PictureBox1
        Button2.Parent = PictureBox1
        Button6.Parent = PictureBox1
        Label3.Parent = PictureBox1
        d1.Format = DateTimePickerFormat.Custom
        d1.CustomFormat = "dd/MM/yyyy"

        d2.Format = DateTimePickerFormat.Custom
        d2.CustomFormat = "dd/MM/yyyy"

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form4.Show()
        Me.Hide()

    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs)
        ClientsRecordBindingSource.EndEdit()
        Client_sRecordTableAdapter.Update(ClientRecordsDataSet._Client_sRecord)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Try
            If MessageBox.Show("Do you want to permanently delete the selected record?",
                                "Delete Data: Success", MessageBoxButtons.YesNo, MessageBoxIcon.Question) Then
                ClientsRecordBindingSource.RemoveCurrent()
                ClientsRecordBindingSource.EndEdit()
                Client_sRecordTableAdapter.Update(ClientRecordsDataSet._Client_sRecord)
                RefreshData()
                MessageBox.Show("Delete Successfully",
                "Delete Data: Succcess", MessageBoxButtons.OK, MessageBoxIcon.Information)
                RefreshData()
            End If
        Catch ex As Exception
            MessageBox.Show("Delete Data Failed: " & ex.Message.ToString(),
            "Delete Data: Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub FillBy1ToolStripButton_Click(sender As Object, e As EventArgs) Handles FillBy1ToolStripButton.Click
        Try
            Me.Client_sRecordTableAdapter.FillBy1(Me.ClientRecordsDataSet._Client_sRecord, First_NameToolStripTextBox.Text)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Client_sRecordTableAdapter.FillBy1(Me.ClientRecordsDataSet._Client_sRecord, TextBox1.Text)
    End Sub


    Private Sub RefreshData()
        Try
            ClientsRecordBindingSource.Filter = Nothing
            Client_sRecordTableAdapter.Fill(ClientRecordsDataSet._Client_sRecord)
        Catch ex As Exception
            MsgBox("Refresh Data Error!")
        End Try
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Form5.Show()
        Me.Close()
    End Sub

    Private Sub TextBox1_Enter(sender As Object, e As EventArgs) Handles TextBox1.Enter
        If TextBox1.Text = "First Name" Then
            TextBox1.Text = ""
            TextBox1.ForeColor = Color.White

        End If
    End Sub

    Private Sub TextBox1_Leave(sender As Object, e As EventArgs) Handles TextBox1.Leave
        If TextBox1.Text = "" Then
            TextBox1.Text = "First Name"
            TextBox1.ForeColor = Color.LightGray

        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        If conn.State = ConnectionState.Closed Then
            conn.Open()

        End If

        Dim dtdate1 As DateTime = DateTime.Parse(d1.Text)
        Dim dtdate2 As DateTime = DateTime.Parse(d2.Text)

        Dim cmd1 As OleDbCommand = New OleDbCommand("Select * from [Client'sRecord] where Date between #" & dtdate1.ToString("dd/MM/yyyy") & "# and #" & dtdate2.ToString("dd/MM/yyyy") & "# order by Date desc", conn)
        Dim da As New OleDbDataAdapter
        da.SelectCommand = cmd1
        Dim dt As New DataTable
        dt.Clear()
        da.Fill(dt)
        DataGridView1.DataSource = dt
        conn.Close()



    End Sub


    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Form7.Show()

    End Sub

    Private Sub Button3_Click_2(sender As Object, e As EventArgs) Handles Button3.Click
        Form6.Show()
    End Sub
End Class