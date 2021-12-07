Public Class Form6

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Me.Label1.Text = TimeOfDay



        For Each item As ListViewItem In Me.ListView1.Items
            If item.SubItems(0).Text = Me.Label1.Text Then
                MsgBox("START Client " + item.SubItems(1).Text)

            End If
        Next

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If Me.ListView1.SelectedItems.Count > Nothing Then
            Me.ListView1.SelectedItems(0).Remove()
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim myAlarmTime As String
        Dim myAlarmName As String

        myAlarmTime = InputBox("Please add the time of the alarm")
        myAlarmName = InputBox("Input the customer's name")
        Dim Lvitem As ListViewItem
        Lvitem = Me.ListView1.Items.Add(myAlarmTime)
        Lvitem.SubItems.Add(myAlarmName)
    End Sub

    Private Sub Form6_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Button1.Parent = PictureBox1
        Button2.Parent = PictureBox1
        Label1.Parent = PictureBox1
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Form5.Show()
    End Sub
End Class