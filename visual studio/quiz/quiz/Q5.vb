Public Class Q5

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Button1.Invalidate()
        Me.Visible = False
        If CheckBox2.Checked AndAlso CheckBox1.CheckState = 0 AndAlso CheckBox3.CheckState = 0 Then

            MsgBox("Right Answer !")


        ElseIf CheckBox2.CheckState = 1 AndAlso CheckBox1.CheckState = 1 AndAlso CheckBox3.CheckState = 0 Then
            Dim Form1 As New Q5
            MsgBox("Choose one option")
            Form1.Show()

        ElseIf CheckBox2.CheckState = 1 AndAlso CheckBox1.CheckState = 0 AndAlso CheckBox3.CheckState = 1 Then
            Dim Form1 As New Q5
            MsgBox("Choose one option")
            Form1.Show()

        ElseIf CheckBox2.CheckState = 0 AndAlso CheckBox1.CheckState = 1 AndAlso CheckBox3.CheckState = 1 Then
            Dim Form1 As New Q5
            MsgBox("Choose one option")
            Form1.Show()

        ElseIf CheckBox2.CheckState = 1 AndAlso CheckBox1.CheckState = 1 AndAlso CheckBox3.CheckState = 1 Then
            Dim Form1 As New Q5
            MsgBox("Choose one option")
            Form1.Show()
        Else
            MsgBox("Wrong answer" & vbNewLine & " Right answer is 0830 hrs")
        End If
    End Sub


    Private Sub Q5_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class