Public Class Q3

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Button1.Invalidate()
        Me.Visible = False
        If CheckBox3.Checked AndAlso CheckBox2.CheckState = 0 AndAlso CheckBox1.CheckState = 0 Then
            Dim Form1 As New Q4
            MsgBox("Right Answer !")

            Form1.Show()
        ElseIf CheckBox2.CheckState = 1 AndAlso CheckBox1.CheckState = 1 AndAlso CheckBox3.CheckState = 0 Then
            Dim Form1 As New Q3
            MsgBox("Choose one option")
            Form1.Show()

        ElseIf CheckBox2.CheckState = 1 AndAlso CheckBox1.CheckState = 0 AndAlso CheckBox3.CheckState = 1 Then
            Dim Form1 As New Q3
            MsgBox("Choose one option")
            Form1.Show()

        ElseIf CheckBox2.CheckState = 0 AndAlso CheckBox1.CheckState = 1 AndAlso CheckBox3.CheckState = 1 Then
            Dim Form1 As New Q3
            MsgBox("Choose one option")
            Form1.Show()

        ElseIf CheckBox2.CheckState = 1 AndAlso CheckBox1.CheckState = 1 AndAlso CheckBox3.CheckState = 1 Then
            Dim Form1 As New Q3
            MsgBox("Choose one option")
            Form1.Show()
        Else
            MsgBox("Wrong answer" & vbNewLine & " Right answer is France")
            Dim Form1 As New Q4
            Form1.Show()
        End If
    End Sub
End Class