Public Class Q1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        'checking for answer and loading the msg box and next question
        Button1.Invalidate()
        Me.Visible = False
        If CheckBox2.Checked AndAlso CheckBox1.CheckState = 0 AndAlso CheckBox3.CheckState = 0 Then
            Dim Form1 As New Q2
            MsgBox("Right Answer !")
            Form1.Show()

            'handling multiple answers from users where not required
        ElseIf CheckBox2.CheckState = 1 AndAlso CheckBox1.CheckState = 1 AndAlso CheckBox3.CheckState = 0 Then
            Dim Form1 As New Q1
            MsgBox("Choose one option")
            Form1.Show()

        ElseIf CheckBox2.CheckState = 1 AndAlso CheckBox1.CheckState = 0 AndAlso CheckBox3.CheckState = 1 Then
            Dim Form1 As New Q1
            MsgBox("Choose one option")
            Form1.Show()

        ElseIf CheckBox2.CheckState = 0 AndAlso CheckBox1.CheckState = 1 AndAlso CheckBox3.CheckState = 1 Then
            Dim Form1 As New Q1
            MsgBox("Choose one option")
            Form1.Show()

        ElseIf CheckBox2.CheckState = 1 AndAlso CheckBox1.CheckState = 1 AndAlso CheckBox3.CheckState = 1 Then
            Dim Form1 As New Q1
            MsgBox("Choose one option")
            Form1.Show()

            'incorrect answer
        Else
            MsgBox("Wrong answer" & vbNewLine & " Right answer is GREENWHICH")
            Dim Form1 As New Q2
            Form1.Show()
        End If

    End Sub

End Class