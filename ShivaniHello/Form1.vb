Public Class Form1
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles label1.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' label1.Visible = False
        label1.Text = TextBox1.Text
        Dim str As String = TextBox1.Text
        Dim msgBoxResult = MsgBox(Prompt:=str.Reverse)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.DialogResult = MessageBox.Show("Do you want ot exit", "Quit", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Error, MessageBoxDefaultButton.Button2)
        If (Me.DialogResult = DialogResult.Yes) Then
            Me.Close()
        End If
    End Sub
End Class
