Imports System.IO
Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'display of window on load
        Me.Visible = True
        Me.CenterToScreen()

        'to display local time when there is no selection
        Dim theSecondForm As New Form2(5, 30)
        theSecondForm.TopLevel = False
        Me.Panel2.Controls.Add(theSecondForm)
        theSecondForm.Show()

        'combobox mode set so that search can be possible
        box.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        box.AutoCompleteSource = AutoCompleteSource.ListItems

        'handles incorrect searches initially invisible
        Label2.Visible = False
    End Sub

    'code for marking the selected point as reference when checking time
    Dim Rect As Rectangle
    Private Sub Panel1_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint
        e.Graphics.DrawRectangle(Pens.Black, Rect)
        e.Graphics.FillRectangle(Brushes.Black, Rect)
    End Sub
    Private Sub Panel1_MouseDown(sender As Object, e As MouseEventArgs) Handles Panel1.MouseDown
        'a different map is load that each time selection is done
        Panel2.Controls.Clear()

        'location for marking the point of selection
        Rect.Location = e.Location
        Rect.Size = New Size(5, 5)
        Panel1.Invalidate()

        'combobox set to default entry when selection from map is done
        box.Text = "Choose Country"
        Label2.Visible = False

        'code for getting the timezone for selected point 
        If e.Location.X >= 12 AndAlso e.Location.X <= 39 AndAlso e.Location.Y >= 48 AndAlso e.Location.Y <= 492 Then
            'loading Form2 in Panel2
            Dim theSecondForm As New Form2(-11, 0)
            theSecondForm.TopLevel = False
            Me.Panel2.Controls.Add(theSecondForm)
            theSecondForm.Show()

        ElseIf e.Location.X > 39 AndAlso e.Location.X <= 57 AndAlso e.Location.Y >= 48 AndAlso e.Location.Y <= 492 Then
            Panel2.Controls.Clear()
            Dim theSecondForm As New Form2(-10, 30)
            theSecondForm.TopLevel = False
            Me.Panel2.Controls.Add(theSecondForm)
            theSecondForm.Show()

        ElseIf e.Location.X > 57 AndAlso e.Location.X <= 75 AndAlso e.Location.Y >= 48 AndAlso e.Location.Y <= 492 Then
            Panel2.Controls.Clear()
            Dim theSecondForm As New Form2(-10, 0)
            theSecondForm.TopLevel = False
            Me.Panel2.Controls.Add(theSecondForm)
            theSecondForm.Show()
        ElseIf e.Location.X > 75 AndAlso e.Location.X <= 93 AndAlso e.Location.Y >= 48 AndAlso e.Location.Y <= 492 Then
            Panel2.Controls.Clear()
            Dim theSecondForm As New Form2(-9, 30)
            theSecondForm.TopLevel = False
            Me.Panel2.Controls.Add(theSecondForm)
            theSecondForm.Show()
        ElseIf e.Location.X > 93 AndAlso e.Location.X <= 111 AndAlso e.Location.Y >= 48 AndAlso e.Location.Y <= 492 Then
            Panel2.Controls.Clear()
            Dim theSecondForm As New Form2(-9, 0)
            theSecondForm.TopLevel = False
            Me.Panel2.Controls.Add(theSecondForm)
            theSecondForm.Show()
        ElseIf e.Location.X > 111 AndAlso e.Location.X <= 129 AndAlso e.Location.Y >= 48 AndAlso e.Location.Y <= 492 Then
            Panel2.Controls.Clear()
            Dim theSecondForm As New Form2(-8, 30)
            theSecondForm.TopLevel = False
            Me.Panel2.Controls.Add(theSecondForm)
            theSecondForm.Show()
        ElseIf e.Location.X > 129 AndAlso e.Location.X <= 147 AndAlso e.Location.Y >= 48 AndAlso e.Location.Y <= 492 Then
            Panel2.Controls.Clear()
            Dim theSecondForm As New Form2(-8, 0)
            theSecondForm.TopLevel = False
            Me.Panel2.Controls.Add(theSecondForm)
            theSecondForm.Show()
        ElseIf e.Location.X > 147 AndAlso e.Location.X <= 165 AndAlso e.Location.Y >= 48 AndAlso e.Location.Y <= 492 Then
            Panel2.Controls.Clear()
            Dim theSecondForm As New Form2(-7, 30)
            theSecondForm.TopLevel = False
            Me.Panel2.Controls.Add(theSecondForm)
            theSecondForm.Show()
        ElseIf e.Location.X > 165 AndAlso e.Location.X <= 183 AndAlso e.Location.Y >= 48 AndAlso e.Location.Y <= 492 Then
            Panel2.Controls.Clear()
            Dim theSecondForm As New Form2(-7, 0)
            theSecondForm.TopLevel = False
            Me.Panel2.Controls.Add(theSecondForm)
            theSecondForm.Show()
        ElseIf e.Location.X > 183 AndAlso e.Location.X <= 201 AndAlso e.Location.Y >= 48 AndAlso e.Location.Y <= 492 Then
            Panel2.Controls.Clear()
            Dim theSecondForm As New Form2(-6, 30)
            theSecondForm.TopLevel = False
            Me.Panel2.Controls.Add(theSecondForm)
            theSecondForm.Show()
        ElseIf e.Location.X > 201 AndAlso e.Location.X <= 219 AndAlso e.Location.Y >= 48 AndAlso e.Location.Y <= 492 Then
            Panel2.Controls.Clear()
            Dim theSecondForm As New Form2(-6, 0)
            theSecondForm.TopLevel = False
            Me.Panel2.Controls.Add(theSecondForm)
            theSecondForm.Show()
        ElseIf e.Location.X > 219 AndAlso e.Location.X <= 237 AndAlso e.Location.Y >= 48 AndAlso e.Location.Y <= 492 Then
            Panel2.Controls.Clear()
            Dim theSecondForm As New Form2(-5, 30)
            theSecondForm.TopLevel = False
            Me.Panel2.Controls.Add(theSecondForm)
            theSecondForm.Show()
        ElseIf e.Location.X > 237 AndAlso e.Location.X <= 255 AndAlso e.Location.Y >= 48 AndAlso e.Location.Y <= 492 Then
            Panel2.Controls.Clear()
            Dim theSecondForm As New Form2(-5, 0)
            theSecondForm.TopLevel = False
            Me.Panel2.Controls.Add(theSecondForm)
            theSecondForm.Show()
        ElseIf e.Location.X > 255 AndAlso e.Location.X <= 273 AndAlso e.Location.Y >= 48 AndAlso e.Location.Y <= 492 Then
            Panel2.Controls.Clear()
            Dim theSecondForm As New Form2(-4, 30)
            theSecondForm.TopLevel = False
            Me.Panel2.Controls.Add(theSecondForm)
            theSecondForm.Show()
        ElseIf e.Location.X > 273 AndAlso e.Location.X <= 291 AndAlso e.Location.Y >= 48 AndAlso e.Location.Y <= 492 Then
            Panel2.Controls.Clear()
            Dim theSecondForm As New Form2(-4, 0)
            theSecondForm.TopLevel = False
            Me.Panel2.Controls.Add(theSecondForm)
            theSecondForm.Show()
        ElseIf e.Location.X > 291 AndAlso e.Location.X <= 309 AndAlso e.Location.Y >= 48 AndAlso e.Location.Y <= 492 Then
            Panel2.Controls.Clear()
            Dim theSecondForm As New Form2(-3, 30)
            theSecondForm.TopLevel = False
            Me.Panel2.Controls.Add(theSecondForm)
            theSecondForm.Show()
        ElseIf e.Location.X > 309 AndAlso e.Location.X <= 327 AndAlso e.Location.Y >= 48 AndAlso e.Location.Y <= 492 Then
            Panel2.Controls.Clear()
            Dim theSecondForm As New Form2(-3, 0)
            theSecondForm.TopLevel = False
            Me.Panel2.Controls.Add(theSecondForm)
            theSecondForm.Show()
        ElseIf e.Location.X > 327 AndAlso e.Location.X <= 345 AndAlso e.Location.Y >= 48 AndAlso e.Location.Y <= 492 Then
            Panel2.Controls.Clear()
            Dim theSecondForm As New Form2(-2, 30)
            theSecondForm.TopLevel = False
            Me.Panel2.Controls.Add(theSecondForm)
            theSecondForm.Show()
        ElseIf e.Location.X > 345 AndAlso e.Location.X <= 363 AndAlso e.Location.Y >= 48 AndAlso e.Location.Y <= 492 Then
            Panel2.Controls.Clear()
            Dim theSecondForm As New Form2(-2, 0)
            theSecondForm.TopLevel = False
            Me.Panel2.Controls.Add(theSecondForm)
            theSecondForm.Show()
        ElseIf e.Location.X > 363 AndAlso e.Location.X <= 381 AndAlso e.Location.Y >= 48 AndAlso e.Location.Y <= 492 Then
            Panel2.Controls.Clear()
            Dim theSecondForm As New Form2(-1, 30)
            theSecondForm.TopLevel = False
            Me.Panel2.Controls.Add(theSecondForm)
            theSecondForm.Show()
        ElseIf e.Location.X > 381 AndAlso e.Location.X <= 399 AndAlso e.Location.Y >= 48 AndAlso e.Location.Y <= 492 Then
            Panel2.Controls.Clear()
            Dim theSecondForm As New Form2(-1, 0)
            theSecondForm.TopLevel = False
            Me.Panel2.Controls.Add(theSecondForm)
            theSecondForm.Show()
        ElseIf e.Location.X > 399 AndAlso e.Location.X <= 435 AndAlso e.Location.Y >= 48 AndAlso e.Location.Y <= 492 Then
            Panel2.Controls.Clear()
            Dim theSecondForm As New Form2(0, 0)
            theSecondForm.TopLevel = False
            Me.Panel2.Controls.Add(theSecondForm)
            theSecondForm.Show()
        ElseIf e.Location.X > 435 AndAlso e.Location.X <= 453 AndAlso e.Location.Y >= 48 AndAlso e.Location.Y <= 492 Then
            Panel2.Controls.Clear()
            Dim theSecondForm As New Form2(1, 0)
            theSecondForm.TopLevel = False
            Me.Panel2.Controls.Add(theSecondForm)
            theSecondForm.Show()
        ElseIf e.Location.X > 453 AndAlso e.Location.X <= 471 AndAlso e.Location.Y >= 48 AndAlso e.Location.Y <= 492 Then
            Panel2.Controls.Clear()
            Dim theSecondForm As New Form2(1, 30)
            theSecondForm.TopLevel = False
            Me.Panel2.Controls.Add(theSecondForm)
            theSecondForm.Show()
        ElseIf e.Location.X > 471 AndAlso e.Location.X <= 489 AndAlso e.Location.Y >= 48 AndAlso e.Location.Y <= 492 Then
            Panel2.Controls.Clear()
            Dim theSecondForm As New Form2(2, 0)
            theSecondForm.TopLevel = False
            Me.Panel2.Controls.Add(theSecondForm)
            theSecondForm.Show()
        ElseIf e.Location.X > 489 AndAlso e.Location.X <= 507 AndAlso e.Location.Y >= 48 AndAlso e.Location.Y <= 492 Then
            Panel2.Controls.Clear()
            Dim theSecondForm As New Form2(2, 30)
            theSecondForm.TopLevel = False
            Me.Panel2.Controls.Add(theSecondForm)
            theSecondForm.Show()
        ElseIf e.Location.X > 507 AndAlso e.Location.X <= 525 AndAlso e.Location.Y >= 48 AndAlso e.Location.Y <= 492 Then
            Panel2.Controls.Clear()
            Dim theSecondForm As New Form2(3, 0)
            theSecondForm.TopLevel = False
            Me.Panel2.Controls.Add(theSecondForm)
            theSecondForm.Show()
        ElseIf e.Location.X > 525 AndAlso e.Location.X <= 543 AndAlso e.Location.Y >= 48 AndAlso e.Location.Y <= 492 Then
            Panel2.Controls.Clear()
            Dim theSecondForm As New Form2(3, 30)
            theSecondForm.TopLevel = False
            Me.Panel2.Controls.Add(theSecondForm)
            theSecondForm.Show()
        ElseIf e.Location.X > 543 AndAlso e.Location.X <= 561 AndAlso e.Location.Y >= 48 AndAlso e.Location.Y <= 492 Then
            Panel2.Controls.Clear()
            Dim theSecondForm As New Form2(4, 0)
            theSecondForm.TopLevel = False
            Me.Panel2.Controls.Add(theSecondForm)
            theSecondForm.Show()
        ElseIf e.Location.X > 561 AndAlso e.Location.X <= 579 AndAlso e.Location.Y >= 48 AndAlso e.Location.Y <= 492 Then
            Panel2.Controls.Clear()
            Dim theSecondForm As New Form2(4, 30)
            theSecondForm.TopLevel = False
            Me.Panel2.Controls.Add(theSecondForm)
            theSecondForm.Show()
        ElseIf e.Location.X > 579 AndAlso e.Location.X <= 597 AndAlso e.Location.Y >= 48 AndAlso e.Location.Y <= 492 Then
            Panel2.Controls.Clear()
            Dim theSecondForm As New Form2(5, 0)
            theSecondForm.TopLevel = False
            Me.Panel2.Controls.Add(theSecondForm)
            theSecondForm.Show()
        ElseIf e.Location.X > 597 AndAlso e.Location.X <= 615 AndAlso e.Location.Y >= 48 AndAlso e.Location.Y <= 492 Then
            Panel2.Controls.Clear()
            Dim theSecondForm As New Form2(5, 30)
            theSecondForm.TopLevel = False
            Me.Panel2.Controls.Add(theSecondForm)
            theSecondForm.Show()
        ElseIf e.Location.X > 615 AndAlso e.Location.X <= 633 AndAlso e.Location.Y >= 48 AndAlso e.Location.Y <= 492 Then
            Panel2.Controls.Clear()
            Dim theSecondForm As New Form2(6, 0)
            theSecondForm.TopLevel = False
            Me.Panel2.Controls.Add(theSecondForm)
            theSecondForm.Show()
        ElseIf e.Location.X > 633 AndAlso e.Location.X <= 651 AndAlso e.Location.Y >= 48 AndAlso e.Location.Y <= 492 Then
            Panel2.Controls.Clear()
            Dim theSecondForm As New Form2(6, 30)
            theSecondForm.TopLevel = False
            Me.Panel2.Controls.Add(theSecondForm)
            theSecondForm.Show()
        ElseIf e.Location.X > 651 AndAlso e.Location.X <= 669 AndAlso e.Location.Y >= 48 AndAlso e.Location.Y <= 492 Then
            Panel2.Controls.Clear()
            Dim theSecondForm As New Form2(7, 0)
            theSecondForm.TopLevel = False
            Me.Panel2.Controls.Add(theSecondForm)
            theSecondForm.Show()
        ElseIf e.Location.X > 669 AndAlso e.Location.X <= 687 AndAlso e.Location.Y >= 48 AndAlso e.Location.Y <= 492 Then
            Panel2.Controls.Clear()
            Dim theSecondForm As New Form2(7, 30)
            theSecondForm.TopLevel = False
            Me.Panel2.Controls.Add(theSecondForm)
            theSecondForm.Show()
        ElseIf e.Location.X > 687 AndAlso e.Location.X <= 705 AndAlso e.Location.Y >= 48 AndAlso e.Location.Y <= 492 Then
            Panel2.Controls.Clear()
            Dim theSecondForm As New Form2(8, 0)
            theSecondForm.TopLevel = False
            Me.Panel2.Controls.Add(theSecondForm)
            theSecondForm.Show()
        ElseIf e.Location.X > 705 AndAlso e.Location.X <= 723 AndAlso e.Location.Y >= 48 AndAlso e.Location.Y <= 492 Then
            Panel2.Controls.Clear()
            Dim theSecondForm As New Form2(8, 30)
            theSecondForm.TopLevel = False
            Me.Panel2.Controls.Add(theSecondForm)
            theSecondForm.Show()
        ElseIf e.Location.X > 723 AndAlso e.Location.X <= 741 AndAlso e.Location.Y >= 48 AndAlso e.Location.Y <= 492 Then
            Panel2.Controls.Clear()
            Dim theSecondForm As New Form2(9, 0)
            theSecondForm.TopLevel = False
            Me.Panel2.Controls.Add(theSecondForm)
            theSecondForm.Show()
        ElseIf e.Location.X > 741 AndAlso e.Location.X <= 759 AndAlso e.Location.Y >= 48 AndAlso e.Location.Y <= 492 Then
            Panel2.Controls.Clear()
            Dim theSecondForm As New Form2(9, 30)
            theSecondForm.TopLevel = False
            Me.Panel2.Controls.Add(theSecondForm)
            theSecondForm.Show()
        ElseIf e.Location.X > 759 AndAlso e.Location.X <= 777 AndAlso e.Location.Y >= 48 AndAlso e.Location.Y <= 492 Then
            Panel2.Controls.Clear()
            Dim theSecondForm As New Form2(10, 0)
            theSecondForm.TopLevel = False
            Me.Panel2.Controls.Add(theSecondForm)
            theSecondForm.Show()
        ElseIf e.Location.X > 777 AndAlso e.Location.X <= 795 AndAlso e.Location.Y >= 48 AndAlso e.Location.Y <= 492 Then
            Panel2.Controls.Clear()
            Dim theSecondForm As New Form2(10, 30)
            theSecondForm.TopLevel = False
            Me.Panel2.Controls.Add(theSecondForm)
            theSecondForm.Show()
        ElseIf e.Location.X > 795 AndAlso e.Location.X <= 813 AndAlso e.Location.Y >= 48 AndAlso e.Location.Y <= 492 Then
            Panel2.Controls.Clear()
            Dim theSecondForm As New Form2(11, 0)
            theSecondForm.TopLevel = False
            Me.Panel2.Controls.Add(theSecondForm)
            theSecondForm.Show()
        ElseIf e.Location.X > 813 AndAlso e.Location.X <= 831 AndAlso e.Location.Y >= 48 AndAlso e.Location.Y <= 492 Then
            Panel2.Controls.Clear()
            Dim theSecondForm As New Form2(11, 30)
            theSecondForm.TopLevel = False
            Me.Panel2.Controls.Add(theSecondForm)
            theSecondForm.Show()
        ElseIf e.Location.X > 831 AndAlso e.Location.X <= 849 AndAlso e.Location.Y >= 48 AndAlso e.Location.Y <= 492 Then
            Panel2.Controls.Clear()
            Dim theSecondForm As New Form2(12, 0)
            theSecondForm.TopLevel = False
            Me.Panel2.Controls.Add(theSecondForm)
            theSecondForm.Show()
        ElseIf e.Location.X > 849 AndAlso e.Location.X <= 867 AndAlso e.Location.Y >= 48 AndAlso e.Location.Y <= 492 Then
            Panel2.Controls.Clear()
            Dim theSecondForm As New Form2(-12, 0)
            theSecondForm.TopLevel = False
            Me.Panel2.Controls.Add(theSecondForm)
            theSecondForm.Show()
        ElseIf e.Location.X > 867 AndAlso e.Location.X <= 885 AndAlso e.Location.Y >= 48 AndAlso e.Location.Y <= 492 Then
            Panel2.Controls.Clear()
            Dim theSecondForm As New Form2(-11, 30)
            theSecondForm.TopLevel = False
            Me.Panel2.Controls.Add(theSecondForm)
            theSecondForm.Show()
            End If
    End Sub

    'code for local time button
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'to remove marked position on clicking of combobox
        Rect.Location = New Point(0, 0)
        Rect.Size = New Size(5, 5)
        Panel1.Invalidate()

        'show form2 in panel2
        Panel2.Controls.Clear()
        Dim theSecondForm As New Form2(5, 30)
        theSecondForm.TopLevel = False
        Me.Panel2.Controls.Add(theSecondForm)
        theSecondForm.Show()
    End Sub

    'for GMT button
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'to remove marked position on clicking of combobox
        Rect.Location = New Point(0, 0)
        Rect.Size = New Size(5, 5)
        Panel1.Invalidate()

        'show form2 in panel2
        Panel2.Controls.Clear()
        Dim theSecondForm As New Form2(0, 0)
        theSecondForm.TopLevel = False
        Me.Panel2.Controls.Add(theSecondForm)
        theSecondForm.Show()
    End Sub

    'help button handler
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Visible = True
        Form3.Show()
    End Sub

    'code for change in combobox selected index
    Private Sub box_SelectedIndexChanged(sender As Object, e As EventArgs) Handles box.SelectedIndexChanged
        'variable to handle incorrect entries
        Dim flag As Boolean
        flag = False

        'panel 2 is cleared so that new form is loaded
        Panel2.Controls.Clear()

        'to remove marked position on clicking of combobox
        Rect.Location = New Point(0, 0)
        Rect.Size = New Size(5, 5)
        Panel1.Invalidate()

        'selected item and corresponding variables are passed to form2
        If box.SelectedItem = "Algeria" Then
            Dim theSecondForm As New Form2(1, 0)
            theSecondForm.TopLevel = False
            Me.Panel2.Controls.Add(theSecondForm)
            theSecondForm.Show()
            flag = True
        ElseIf box.SelectedItem = "American Samoa" Then
            Dim theSecondForm As New Form2(-11, 0)
            theSecondForm.TopLevel = False
            Me.Panel2.Controls.Add(theSecondForm)
            theSecondForm.Show()
            flag = True
        ElseIf box.SelectedItem = "Andorra" Then
            Dim theSecondForm As New Form2(1, 0)
            theSecondForm.TopLevel = False
            Me.Panel2.Controls.Add(theSecondForm)
            theSecondForm.Show()
            flag = True
        End If
        If box.SelectedItem = "Angola" Then
            Dim theSecondForm As New Form2(1, 0)
            theSecondForm.TopLevel = False
            Me.Panel2.Controls.Add(theSecondForm)
            theSecondForm.Show()
            flag = True
        End If
        If box.SelectedItem = "Anguilla" Then
            Dim theSecondForm As New Form2(-4, 0)
            theSecondForm.TopLevel = False
            Me.Panel2.Controls.Add(theSecondForm)
            theSecondForm.Show()
            flag = True
        End If
        If box.SelectedItem = "Antarctica" Then
            Dim theSecondForm As New Form2(-2, 0)
            theSecondForm.TopLevel = False
            Me.Panel2.Controls.Add(theSecondForm)
            theSecondForm.Show()
            flag = True
        End If
        If box.SelectedItem = "Antigua" Then
            Dim theSecondForm As New Form2(-4, 0)
            theSecondForm.TopLevel = False
            Me.Panel2.Controls.Add(theSecondForm)
            theSecondForm.Show()
            flag = True
        End If
        If box.SelectedItem = "Argentina" Then
            Dim theSecondForm As New Form2(-3, 0)
            theSecondForm.TopLevel = False
            Me.Panel2.Controls.Add(theSecondForm)
            theSecondForm.Show()
            flag = True
        End If
        If box.SelectedItem = "Argentina western prov" Then
            Dim theSecondForm As New Form2(-4, 0)
            theSecondForm.TopLevel = False
            Me.Panel2.Controls.Add(theSecondForm)
            theSecondForm.Show()
            flag = True
        End If
        If box.SelectedItem = "Armenia" Then
            Dim theSecondForm As New Form2(4, 0)
            theSecondForm.TopLevel = False
            Me.Panel2.Controls.Add(theSecondForm)
            theSecondForm.Show()
            flag = True
        End If
        If box.SelectedItem = "Aruba" Then
            Dim theSecondForm As New Form2(-4, 0)
            theSecondForm.TopLevel = False
            Me.Panel2.Controls.Add(theSecondForm)
            theSecondForm.Show()
            flag = True
        End If
        If box.SelectedItem = "Ascension" Then
            Dim theSecondForm As New Form2(0, 0)
            theSecondForm.TopLevel = False
            Me.Panel2.Controls.Add(theSecondForm)
            theSecondForm.Show()
            flag = True
        End If
        If box.SelectedItem = "Australia Western" Then
            Dim theSecondForm As New Form2(8, 0)
            theSecondForm.TopLevel = False
            Me.Panel2.Controls.Add(theSecondForm)
            theSecondForm.Show()
            flag = True
        End If
        If box.SelectedItem = "Australia South" Then
            Dim theSecondForm As New Form2(9, 30)
            theSecondForm.TopLevel = False
            Me.Panel2.Controls.Add(theSecondForm)
            theSecondForm.Show()
            flag = True
        End If
        If box.SelectedItem = "Australia Northern Territory" Then
            Dim theSecondForm As New Form2(9, 30)
            theSecondForm.TopLevel = False
            Me.Panel2.Controls.Add(theSecondForm)
            theSecondForm.Show()
            flag = True
        End If
        If box.SelectedItem = "Australia New South Wales" Then
            Dim theSecondForm As New Form2(10, 0)
            theSecondForm.TopLevel = False
            Me.Panel2.Controls.Add(theSecondForm)
            theSecondForm.Show()
            flag = True
        End If
        If box.SelectedItem = "Australia Queensland" Then
            Dim theSecondForm As New Form2(10, 0)
            theSecondForm.TopLevel = False
            Me.Panel2.Controls.Add(theSecondForm)
            theSecondForm.Show()
            flag = True
        End If
        If box.SelectedItem = "Australia Victoria" Then
            Dim theSecondForm As New Form2(10, 0)
            theSecondForm.TopLevel = False
            Me.Panel2.Controls.Add(theSecondForm)
            theSecondForm.Show()
            flag = True
        End If
        If box.SelectedItem = "Australia Capital Territory" Then
            Dim theSecondForm As New Form2(9, 30)
            theSecondForm.TopLevel = False
            Me.Panel2.Controls.Add(theSecondForm)
            theSecondForm.Show()
            flag = True
        End If
        If box.SelectedItem = "Australia Tasmania" Then
            Dim theSecondForm As New Form2(10, 0)
            theSecondForm.TopLevel = False
            Me.Panel2.Controls.Add(theSecondForm)
            theSecondForm.Show()
            flag = True
        End If
        If box.SelectedItem = "Australia Lord Howe Island" Then
            Dim theSecondForm As New Form2(10, 30)
            theSecondForm.TopLevel = False
            Me.Panel2.Controls.Add(theSecondForm)
            theSecondForm.Show()
            flag = True
        End If
        If box.SelectedItem = "Austria" Then
            Dim theSecondForm As New Form2(1, 0)
            theSecondForm.TopLevel = False
            Me.Panel2.Controls.Add(theSecondForm)
            theSecondForm.Show()
            flag = True
        End If
        If box.SelectedItem = "Azerbaijan" Then
            Dim theSecondForm As New Form2(3, 0)
            theSecondForm.TopLevel = False
            Me.Panel2.Controls.Add(theSecondForm)
            theSecondForm.Show()
            flag = True
        End If
        If box.SelectedItem = "Azores" Then
            Dim theSecondForm As New Form2(-1, 0)
            theSecondForm.TopLevel = False
            Me.Panel2.Controls.Add(theSecondForm)
            theSecondForm.Show()
            flag = True
        End If
        If box.SelectedItem = "Bahamas" Then
            Dim theSecondForm As New Form2(-5, 0)
            theSecondForm.TopLevel = False
            Me.Panel2.Controls.Add(theSecondForm)
            theSecondForm.Show()
            flag = True
        End If
        If box.SelectedItem = "Baharain" Then
            Dim theSecondForm As New Form2(3, 0)
            theSecondForm.TopLevel = False
            Me.Panel2.Controls.Add(theSecondForm)
            theSecondForm.Show()
            flag = True
        End If
        If box.SelectedItem = "Balearic Islands" Then
            Dim theSecondForm As New Form2(1, 0)
            theSecondForm.TopLevel = False
            Me.Panel2.Controls.Add(theSecondForm)
            theSecondForm.Show()
            flag = True
        End If
        If box.SelectedItem = "Barbados" Then
            Dim theSecondForm As New Form2(-4, 0)
            theSecondForm.TopLevel = False
            Me.Panel2.Controls.Add(theSecondForm)
            theSecondForm.Show()
            flag = True
        End If
        If box.SelectedItem = "Belarus" Then
            Dim theSecondForm As New Form2(2, 0)
            theSecondForm.TopLevel = False
            Me.Panel2.Controls.Add(theSecondForm)
            theSecondForm.Show()
            flag = True
        End If
        If box.SelectedItem = "Azerbaijan" Then
            Dim theSecondForm As New Form2(3, 0)
            theSecondForm.TopLevel = False
            Me.Panel2.Controls.Add(theSecondForm)
            theSecondForm.Show()
            flag = True
        End If
        If box.SelectedItem = "Bangladesh" Then
            Dim theSecondForm As New Form2(6, 0)
            theSecondForm.TopLevel = False
            Me.Panel2.Controls.Add(theSecondForm)
            theSecondForm.Show()
            flag = True
        End If
        If box.SelectedItem = "Belgium" Then
            Dim theSecondForm As New Form2(1, 0)
            theSecondForm.TopLevel = False
            Me.Panel2.Controls.Add(theSecondForm)
            theSecondForm.Show()
            flag = True
        End If
        If box.SelectedItem = "Belize" Then
            Dim theSecondForm As New Form2(-6, 0)
            theSecondForm.TopLevel = False
            Me.Panel2.Controls.Add(theSecondForm)
            theSecondForm.Show()
            flag = True
        End If
        If box.SelectedItem = "Benin" Then
            Dim theSecondForm As New Form2(1, 0)
            theSecondForm.TopLevel = False
            Me.Panel2.Controls.Add(theSecondForm)
            theSecondForm.Show()
            flag = True
        End If
        If box.SelectedItem = "Bermuda" Then
            Dim theSecondForm As New Form2(-4, 0)
            theSecondForm.TopLevel = False
            Me.Panel2.Controls.Add(theSecondForm)
            theSecondForm.Show()
            flag = True
        End If
        If box.SelectedItem = "Bhutan" Then
            Dim theSecondForm As New Form2(6, 0)
            theSecondForm.TopLevel = False
            Me.Panel2.Controls.Add(theSecondForm)
            theSecondForm.Show()
            flag = True
        End If
        If box.SelectedItem = "Bolivia" Then
            Dim theSecondForm As New Form2(-4, 0)
            theSecondForm.TopLevel = False
            Me.Panel2.Controls.Add(theSecondForm)
            theSecondForm.Show()
            flag = True
        End If
        If box.SelectedItem = "Bonaire" Then
            Dim theSecondForm As New Form2(-4, 0)
            theSecondForm.TopLevel = False
            Me.Panel2.Controls.Add(theSecondForm)
            theSecondForm.Show()
            flag = True
        End If
        If box.SelectedItem = "Azerbaijan" Then
            Dim theSecondForm As New Form2(3, 0)
            theSecondForm.TopLevel = False
            Me.Panel2.Controls.Add(theSecondForm)
            theSecondForm.Show()
            flag = True
        End If
        If box.SelectedItem = "Bosnia Hercegovina" Then
            Dim theSecondForm As New Form2(1, 0)
            theSecondForm.TopLevel = False
            Me.Panel2.Controls.Add(theSecondForm)
            theSecondForm.Show()
            flag = True
        End If
        If box.SelectedItem = "Botswana" Then
            Dim theSecondForm As New Form2(2, 0)
            theSecondForm.TopLevel = False
            Me.Panel2.Controls.Add(theSecondForm)
            theSecondForm.Show()
            flag = True
        End If
        If box.SelectedItem = "Brazil West" Then
            Dim theSecondForm As New Form2(-4, 0)
            theSecondForm.TopLevel = False
            Me.Panel2.Controls.Add(theSecondForm)
            theSecondForm.Show()
            flag = True
        End If
        If box.SelectedItem = "Brazil Acre" Then
            Dim theSecondForm As New Form2(-4, 0)
            theSecondForm.TopLevel = False
            Me.Panel2.Controls.Add(theSecondForm)
            theSecondForm.Show()
            flag = True
        End If
        If box.SelectedItem = "Brazil East" Then
            Dim theSecondForm As New Form2(-3, 0)
            theSecondForm.TopLevel = False
            Me.Panel2.Controls.Add(theSecondForm)
            theSecondForm.Show()
            flag = True
        End If
        If box.SelectedItem = "Brazil Atlantic Islands" Then
            Dim theSecondForm As New Form2(-1, 0)
            theSecondForm.TopLevel = False
            Me.Panel2.Controls.Add(theSecondForm)
            theSecondForm.Show()
            flag = True
        End If
        If box.SelectedItem = "British Virgin Islands" Then
            Dim theSecondForm As New Form2(-4, 0)
            theSecondForm.TopLevel = False
            Me.Panel2.Controls.Add(theSecondForm)
            theSecondForm.Show()
            flag = True
        End If
        If box.SelectedItem = "Brunei" Then
            Dim theSecondForm As New Form2(8, 0)
            theSecondForm.TopLevel = False
            Me.Panel2.Controls.Add(theSecondForm)
            theSecondForm.Show()
            flag = True
        End If
        If box.SelectedItem = "Burkina Faso" Then
            Dim theSecondForm As New Form2(0, 0)
            theSecondForm.TopLevel = False
            Me.Panel2.Controls.Add(theSecondForm)
            theSecondForm.Show()
            flag = True
        End If
        If box.SelectedItem = "Bulgaria" Then
            Dim theSecondForm As New Form2(2, 0)
            theSecondForm.TopLevel = False
            Me.Panel2.Controls.Add(theSecondForm)
            theSecondForm.Show()
            flag = True
        End If
        If box.SelectedItem = "Burundi" Then
            Dim theSecondForm As New Form2(2, 0)
            theSecondForm.TopLevel = False
            Me.Panel2.Controls.Add(theSecondForm)
            theSecondForm.Show()
            flag = True
        End If
        If box.SelectedItem = "Cambodia" Then
            Dim theSecondForm As New Form2(7, 0)
            theSecondForm.TopLevel = False
            Me.Panel2.Controls.Add(theSecondForm)
            theSecondForm.Show()
            flag = True
        End If
        If box.SelectedItem = "Cameroon" Then
            Dim theSecondForm As New Form2(1, 0)
            theSecondForm.TopLevel = False
            Me.Panel2.Controls.Add(theSecondForm)
            theSecondForm.Show()
            flag = True
        End If
        If box.SelectedItem = "Canada Yukon & Pacific" Then
            Dim theSecondForm As New Form2(-8, 0)
            theSecondForm.TopLevel = False
            Me.Panel2.Controls.Add(theSecondForm)
            theSecondForm.Show()
            flag = True
        End If
        If box.SelectedItem = "Canada Mountain" Then
            Dim theSecondForm As New Form2(-7, 0)
            theSecondForm.TopLevel = False
            Me.Panel2.Controls.Add(theSecondForm)
            theSecondForm.Show()
            flag = True
        End If
        If box.SelectedItem = "Canada Central" Then
            Dim theSecondForm As New Form2(-6, 0)
            theSecondForm.TopLevel = False
            Me.Panel2.Controls.Add(theSecondForm)
            theSecondForm.Show()
            flag = True
        End If
        If box.SelectedItem = "Canada Eastern" Then
            Dim theSecondForm As New Form2(-5, 0)
            theSecondForm.TopLevel = False
            Me.Panel2.Controls.Add(theSecondForm)
            theSecondForm.Show()
            flag = True
        End If
        If box.SelectedItem = "Canada Atlantic" Then
            Dim theSecondForm As New Form2(-4, 0)
            theSecondForm.TopLevel = False
            Me.Panel2.Controls.Add(theSecondForm)
            theSecondForm.Show()
            flag = True
        End If
        If box.SelectedItem = "Canada Newfoundland" Then
            Dim theSecondForm As New Form2(-3, 30)
            theSecondForm.TopLevel = False
            Me.Panel2.Controls.Add(theSecondForm)
            theSecondForm.Show()
            flag = True
        End If
        If box.SelectedItem = "Canary Islands" Then
            Dim theSecondForm As New Form2(0, 0)
            theSecondForm.TopLevel = False
            Me.Panel2.Controls.Add(theSecondForm)
            theSecondForm.Show()
            flag = True
        End If
        If box.SelectedItem = "Chad" Then
            Dim theSecondForm As New Form2(1, 0)
            theSecondForm.TopLevel = False
            Me.Panel2.Controls.Add(theSecondForm)
            theSecondForm.Show()
            flag = True
        End If
        If box.SelectedItem = "Chile" Then
            Dim theSecondForm As New Form2(-4, 0)
            theSecondForm.TopLevel = False
            Me.Panel2.Controls.Add(theSecondForm)
            theSecondForm.Show()
            flag = True
        End If
        If box.SelectedItem = "Colombia" Then
            Dim theSecondForm As New Form2(-5, 0)
            theSecondForm.TopLevel = False
            Me.Panel2.Controls.Add(theSecondForm)
            theSecondForm.Show()
            flag = True
        End If
        If box.SelectedItem = "Congo" Then
            Dim theSecondForm As New Form2(1, 0)
            theSecondForm.TopLevel = False
            Me.Panel2.Controls.Add(theSecondForm)
            theSecondForm.Show()
            flag = True
        End If
        If box.SelectedItem = "Costa Rica" Then
            Dim theSecondForm As New Form2(-6, 0)
            theSecondForm.TopLevel = False
            Me.Panel2.Controls.Add(theSecondForm)
            theSecondForm.Show()
            flag = True
        End If
        If box.SelectedItem = "Cuba" Then
            Dim theSecondForm As New Form2(-5, 0)
            theSecondForm.TopLevel = False
            Me.Panel2.Controls.Add(theSecondForm)
            theSecondForm.Show()
            flag = True
        End If
        If box.SelectedItem = "Czech Republic" Then
            Dim theSecondForm As New Form2(1, 0)
            theSecondForm.TopLevel = False
            Me.Panel2.Controls.Add(theSecondForm)
            theSecondForm.Show()
            flag = True
        End If
        If box.SelectedItem = "Denmark" Then
            Dim theSecondForm As New Form2(1, 0)
            theSecondForm.TopLevel = False
            Me.Panel2.Controls.Add(theSecondForm)
            theSecondForm.Show()
            flag = True
        End If
        If box.SelectedItem = "Egypt" Then
            Dim theSecondForm As New Form2(2, 0)
            theSecondForm.TopLevel = False
            Me.Panel2.Controls.Add(theSecondForm)
            theSecondForm.Show()
            flag = True
        End If
        If box.SelectedItem = "England" Then
            Dim theSecondForm As New Form2(0, 0)
            theSecondForm.TopLevel = False
            Me.Panel2.Controls.Add(theSecondForm)
            theSecondForm.Show()
            flag = True
        End If
        If box.SelectedItem = "Equatorial Guinea" Then
            Dim theSecondForm As New Form2(1, 0)
            theSecondForm.TopLevel = False
            Me.Panel2.Controls.Add(theSecondForm)
            theSecondForm.Show()
            flag = True
        End If
        If box.SelectedItem = "Estonia" Then
            Dim theSecondForm As New Form2(2, 0)
            theSecondForm.TopLevel = False
            Me.Panel2.Controls.Add(theSecondForm)
            theSecondForm.Show()
            flag = True
        End If
        If box.SelectedItem = "Ethiopia" Then
            Dim theSecondForm As New Form2(3, 0)
            theSecondForm.TopLevel = False
            Me.Panel2.Controls.Add(theSecondForm)
            theSecondForm.Show()
            flag = True
        End If
        If box.SelectedItem = "Fiji" Then
            Dim theSecondForm As New Form2(12, 0)
            theSecondForm.TopLevel = False
            Me.Panel2.Controls.Add(theSecondForm)
            theSecondForm.Show()
            flag = True
        End If
        If box.SelectedItem = "Finland" Then
            Dim theSecondForm As New Form2(2, 0)
            theSecondForm.TopLevel = False
            Me.Panel2.Controls.Add(theSecondForm)
            theSecondForm.Show()
            flag = True
        End If
        If box.SelectedItem = "France" Then
            Dim theSecondForm As New Form2(1, 0)
            theSecondForm.TopLevel = False
            Me.Panel2.Controls.Add(theSecondForm)
            theSecondForm.Show()
            flag = True
        End If
        If box.SelectedItem = "Georgia" Then
            Dim theSecondForm As New Form2(4, 0)
            theSecondForm.TopLevel = False
            Me.Panel2.Controls.Add(theSecondForm)
            theSecondForm.Show()
            flag = True
        End If
        If box.SelectedItem = "Germany" Then
            Dim theSecondForm As New Form2(1, 0)
            theSecondForm.TopLevel = False
            Me.Panel2.Controls.Add(theSecondForm)
            theSecondForm.Show()
            flag = True
        End If
        If box.SelectedItem = "Ghana" Then
            Dim theSecondForm As New Form2(0, 0)
            theSecondForm.TopLevel = False
            Me.Panel2.Controls.Add(theSecondForm)
            theSecondForm.Show()
            flag = True
        End If
        If box.SelectedItem = "Greece" Then
            Dim theSecondForm As New Form2(2, 0)
            theSecondForm.TopLevel = False
            Me.Panel2.Controls.Add(theSecondForm)
            theSecondForm.Show()
            flag = True
        End If
        If box.SelectedItem = "Greenland" Then
            Dim theSecondForm As New Form2(-3, 0)
            theSecondForm.TopLevel = False
            Me.Panel2.Controls.Add(theSecondForm)
            theSecondForm.Show()
            flag = True
        End If
        If box.SelectedItem = "Guinea" Then
            Dim theSecondForm As New Form2(0, 0)
            theSecondForm.TopLevel = False
            Me.Panel2.Controls.Add(theSecondForm)
            theSecondForm.Show()
            flag = True
        End If
        If box.SelectedItem = "Hong Kong" Then
            Dim theSecondForm As New Form2(8, 0)
            theSecondForm.TopLevel = False
            Me.Panel2.Controls.Add(theSecondForm)
            theSecondForm.Show()
            flag = True
        End If
        If box.SelectedItem = "Hungary" Then
            Dim theSecondForm As New Form2(1, 0)
            theSecondForm.TopLevel = False
            Me.Panel2.Controls.Add(theSecondForm)
            theSecondForm.Show()
            flag = True
        End If
        If box.SelectedItem = "Iceland" Then
            Dim theSecondForm As New Form2(0, 0)
            theSecondForm.TopLevel = False
            Me.Panel2.Controls.Add(theSecondForm)
            theSecondForm.Show()
            flag = True
        End If
        If box.SelectedItem = "India" Then
            Dim theSecondForm As New Form2(5, 30)
            theSecondForm.TopLevel = False
            Me.Panel2.Controls.Add(theSecondForm)
            theSecondForm.Show()
            flag = True
        End If
        If box.SelectedItem = "Indonesia" Then
            Dim theSecondForm As New Form2(8, 0)
            theSecondForm.TopLevel = False
            Me.Panel2.Controls.Add(theSecondForm)
            theSecondForm.Show()
            flag = True
        End If
        If box.SelectedItem = "Iran" Then
            Dim theSecondForm As New Form2(3, 30)
            theSecondForm.TopLevel = False
            Me.Panel2.Controls.Add(theSecondForm)
            theSecondForm.Show()
            flag = True
        End If
        If box.SelectedItem = "Iraq" Then
            Dim theSecondForm As New Form2(3, 0)
            theSecondForm.TopLevel = False
            Me.Panel2.Controls.Add(theSecondForm)
            theSecondForm.Show()
            flag = True
        End If
        If box.SelectedItem = "Ireland " Then
            Dim theSecondForm As New Form2(0, 0)
            theSecondForm.TopLevel = False
            Me.Panel2.Controls.Add(theSecondForm)
            theSecondForm.Show()
            flag = True
        End If
        If box.SelectedItem = "Israel" Then
            Dim theSecondForm As New Form2(2, 0)
            theSecondForm.TopLevel = False
            Me.Panel2.Controls.Add(theSecondForm)
            theSecondForm.Show()
            flag = True
        End If
        If box.SelectedItem = "Italy" Then
            Dim theSecondForm As New Form2(1, 0)
            theSecondForm.TopLevel = False
            Me.Panel2.Controls.Add(theSecondForm)
            theSecondForm.Show()
            flag = True
        End If
        If box.SelectedItem = "Japan" Then
            Dim theSecondForm As New Form2(9, 0)
            theSecondForm.TopLevel = False
            Me.Panel2.Controls.Add(theSecondForm)
            theSecondForm.Show()
            flag = True
        End If
        If box.SelectedItem = "Jordan" Then
            Dim theSecondForm As New Form2(2, 0)
            theSecondForm.TopLevel = False
            Me.Panel2.Controls.Add(theSecondForm)
            theSecondForm.Show()
            flag = True
        End If
        If box.SelectedItem = "Kazakhstan" Then
            Dim theSecondForm As New Form2(6, 0)
            theSecondForm.TopLevel = False
            Me.Panel2.Controls.Add(theSecondForm)
            theSecondForm.Show()
            flag = True
        End If
        If box.SelectedItem = "Kenya" Then
            Dim theSecondForm As New Form2(3, 0)
            theSecondForm.TopLevel = False
            Me.Panel2.Controls.Add(theSecondForm)
            theSecondForm.Show()
            flag = True
        End If
        If box.SelectedItem = "Korea" Then
            Dim theSecondForm As New Form2(9, 0)
            theSecondForm.TopLevel = False
            Me.Panel2.Controls.Add(theSecondForm)
            theSecondForm.Show()
            flag = True
        End If
        If box.SelectedItem = "Kuwait" Then
            Dim theSecondForm As New Form2(3, 0)
            theSecondForm.TopLevel = False
            Me.Panel2.Controls.Add(theSecondForm)
            theSecondForm.Show()
            flag = True
        End If
        If box.SelectedItem = "Liberia" Then
            Dim theSecondForm As New Form2(0, 0)
            theSecondForm.TopLevel = False
            Me.Panel2.Controls.Add(theSecondForm)
            theSecondForm.Show()
            flag = True
        End If
        If box.SelectedItem = "Libya" Then
            Dim theSecondForm As New Form2(2, 0)
            theSecondForm.TopLevel = False
            Me.Panel2.Controls.Add(theSecondForm)
            theSecondForm.Show()
            flag = True
        End If
        If box.SelectedItem = "Madagascar" Then
            Dim theSecondForm As New Form2(3, 0)
            theSecondForm.TopLevel = False
            Me.Panel2.Controls.Add(theSecondForm)
            theSecondForm.Show()
            flag = True
        End If
        If box.SelectedItem = "Malaysia" Then
            Dim theSecondForm As New Form2(8, 0)
            theSecondForm.TopLevel = False
            Me.Panel2.Controls.Add(theSecondForm)
            theSecondForm.Show()
            flag = True
        End If
        If box.SelectedItem = "Maldives" Then
            Dim theSecondForm As New Form2(5, 0)
            theSecondForm.TopLevel = False
            Me.Panel2.Controls.Add(theSecondForm)
            theSecondForm.Show()
            flag = True
        End If
        If box.SelectedItem = "Mauritius" Then
            Dim theSecondForm As New Form2(4, 0)
            theSecondForm.TopLevel = False
            Me.Panel2.Controls.Add(theSecondForm)
            theSecondForm.Show()
            flag = True
        End If
        If box.SelectedItem = "Mexico" Then
            Dim theSecondForm As New Form2(-6, 0)
            theSecondForm.TopLevel = False
            Me.Panel2.Controls.Add(theSecondForm)
            theSecondForm.Show()
            flag = True
        End If
        If box.SelectedItem = "Mongolia" Then
            Dim theSecondForm As New Form2(8, 0)
            theSecondForm.TopLevel = False
            Me.Panel2.Controls.Add(theSecondForm)
            theSecondForm.Show()
            flag = True
        End If
        If box.SelectedItem = "Morocco" Then
            Dim theSecondForm As New Form2(0, 0)
            theSecondForm.TopLevel = False
            Me.Panel2.Controls.Add(theSecondForm)
            theSecondForm.Show()
            flag = True
        End If
        If box.SelectedItem = "Myanmar" Then
            Dim theSecondForm As New Form2(6, 30)
            theSecondForm.TopLevel = False
            Me.Panel2.Controls.Add(theSecondForm)
            theSecondForm.Show()
            flag = True
        End If
        If box.SelectedItem = "Nepal" Then
            Dim theSecondForm As New Form2(5, 45)
            theSecondForm.TopLevel = False
            Me.Panel2.Controls.Add(theSecondForm)
            theSecondForm.Show()
            flag = True
        End If
        If box.SelectedItem = "Netherlands" Then
            Dim theSecondForm As New Form2(1, 0)
            theSecondForm.TopLevel = False
            Me.Panel2.Controls.Add(theSecondForm)
            theSecondForm.Show()
            flag = True
        End If
        If box.SelectedItem = "New Zealand" Then
            Dim theSecondForm As New Form2(12, 0)
            theSecondForm.TopLevel = False
            Me.Panel2.Controls.Add(theSecondForm)
            theSecondForm.Show()
            flag = True
        End If
        If box.SelectedItem = "Nigeria" Then
            Dim theSecondForm As New Form2(1, 0)
            theSecondForm.TopLevel = False
            Me.Panel2.Controls.Add(theSecondForm)
            theSecondForm.Show()
            flag = True
        End If
        If box.SelectedItem = "Norway" Then
            Dim theSecondForm As New Form2(1, 0)
            theSecondForm.TopLevel = False
            Me.Panel2.Controls.Add(theSecondForm)
            theSecondForm.Show()
            flag = True
        End If
        If box.SelectedItem = "Oman" Then
            Dim theSecondForm As New Form2(4, 0)
            theSecondForm.TopLevel = False
            Me.Panel2.Controls.Add(theSecondForm)
            theSecondForm.Show()
            flag = True
        End If
        If box.SelectedItem = "Pakistan" Then
            Dim theSecondForm As New Form2(5, 0)
            theSecondForm.TopLevel = False
            Me.Panel2.Controls.Add(theSecondForm)
            theSecondForm.Show()
            flag = True
        End If
        If box.SelectedItem = "Peru" Then
            Dim theSecondForm As New Form2(-5, 0)
            theSecondForm.TopLevel = False
            Me.Panel2.Controls.Add(theSecondForm)
            theSecondForm.Show()
            flag = True
        End If
        If box.SelectedItem = "Philippines" Then
            Dim theSecondForm As New Form2(8, 0)
            theSecondForm.TopLevel = False
            Me.Panel2.Controls.Add(theSecondForm)
            theSecondForm.Show()
            flag = True
        End If
        If box.SelectedItem = "Philippines" Then
            Dim theSecondForm As New Form2(1, 0)
            theSecondForm.TopLevel = False
            Me.Panel2.Controls.Add(theSecondForm)
            theSecondForm.Show()
            flag = True
        End If
        If box.SelectedItem = "Saudi Arabia" Then
            Dim theSecondForm As New Form2(3, 0)
            theSecondForm.TopLevel = False
            Me.Panel2.Controls.Add(theSecondForm)
            theSecondForm.Show()
            flag = True
        End If
        If box.SelectedItem = "Scotland" Then
            Dim theSecondForm As New Form2(0, 0)
            theSecondForm.TopLevel = False
            Me.Panel2.Controls.Add(theSecondForm)
            theSecondForm.Show()
            flag = True
        End If
        If box.SelectedItem = "Singapore" Then
            Dim theSecondForm As New Form2(8, 0)
            theSecondForm.TopLevel = False
            Me.Panel2.Controls.Add(theSecondForm)
            theSecondForm.Show()
            flag = True
        End If
        If box.SelectedItem = "Somalia" Then
            Dim theSecondForm As New Form2(3, 0)
            theSecondForm.TopLevel = False
            Me.Panel2.Controls.Add(theSecondForm)
            theSecondForm.Show()
            flag = True
        End If
        If box.SelectedItem = "South Africa" Then
            Dim theSecondForm As New Form2(2, 0)
            theSecondForm.TopLevel = False
            Me.Panel2.Controls.Add(theSecondForm)
            theSecondForm.Show()
            flag = True
        End If
        If box.SelectedItem = "Spain" Then
            Dim theSecondForm As New Form2(1, 0)
            theSecondForm.TopLevel = False
            Me.Panel2.Controls.Add(theSecondForm)
            theSecondForm.Show()
            flag = True
        End If
        If box.SelectedItem = "Sri Lanka" Then
            Dim theSecondForm As New Form2(5, 30)
            theSecondForm.TopLevel = False
            Me.Panel2.Controls.Add(theSecondForm)
            theSecondForm.Show()
            flag = True
        End If
        If box.SelectedItem = "Sudan" Then
            Dim theSecondForm As New Form2(2, 0)
            theSecondForm.TopLevel = False
            Me.Panel2.Controls.Add(theSecondForm)
            theSecondForm.Show()
            flag = True
        End If
        If box.SelectedItem = "Sweden" Then
            Dim theSecondForm As New Form2(1, 0)
            theSecondForm.TopLevel = False
            Me.Panel2.Controls.Add(theSecondForm)
            theSecondForm.Show()
            flag = True
        End If
        If box.SelectedItem = "Switzerland" Then
            Dim theSecondForm As New Form2(1, 0)
            theSecondForm.TopLevel = False
            Me.Panel2.Controls.Add(theSecondForm)
            theSecondForm.Show()
            flag = True
        End If
        If box.SelectedItem = "Syria" Then
            Dim theSecondForm As New Form2(2, 0)
            theSecondForm.TopLevel = False
            Me.Panel2.Controls.Add(theSecondForm)
            theSecondForm.Show()
            flag = True
        End If
        If box.SelectedItem = "Taiwan" Then
            Dim theSecondForm As New Form2(8, 0)
            theSecondForm.TopLevel = False
            Me.Panel2.Controls.Add(theSecondForm)
            theSecondForm.Show()
            flag = True
        End If
        If box.SelectedItem = "Tajikistan" Then
            Dim theSecondForm As New Form2(6, 0)
            theSecondForm.TopLevel = False
            Me.Panel2.Controls.Add(theSecondForm)
            theSecondForm.Show()
            flag = True
        End If
        If box.SelectedItem = "Tanzania" Then
            Dim theSecondForm As New Form2(3, 0)
            theSecondForm.TopLevel = False
            Me.Panel2.Controls.Add(theSecondForm)
            theSecondForm.Show()
            flag = True
        End If
        If box.SelectedItem = "Thailand" Then
            Dim theSecondForm As New Form2(7, 0)
            theSecondForm.TopLevel = False
            Me.Panel2.Controls.Add(theSecondForm)
            theSecondForm.Show()
            flag = True
        End If
        If box.SelectedItem = "Turkey" Then
            Dim theSecondForm As New Form2(2, 0)
            theSecondForm.TopLevel = False
            Me.Panel2.Controls.Add(theSecondForm)
            theSecondForm.Show()
            flag = True
        End If
        If box.SelectedItem = "Uganda" Then
            Dim theSecondForm As New Form2(3, 0)
            theSecondForm.TopLevel = False
            Me.Panel2.Controls.Add(theSecondForm)
            theSecondForm.Show()
            flag = True
        End If
        If box.SelectedItem = "Ukraine" Then
            Dim theSecondForm As New Form2(2, 0)
            theSecondForm.TopLevel = False
            Me.Panel2.Controls.Add(theSecondForm)
            theSecondForm.Show()
            flag = True
        End If
        If box.SelectedItem = "United Kingdom" Then
            Dim theSecondForm As New Form2(0, 0)
            theSecondForm.TopLevel = False
            Me.Panel2.Controls.Add(theSecondForm)
            theSecondForm.Show()
            flag = True
        End If
        If box.SelectedItem = "Ukraine" Then
            Dim theSecondForm As New Form2(2, 0)
            theSecondForm.TopLevel = False
            Me.Panel2.Controls.Add(theSecondForm)
            theSecondForm.Show()
            flag = True
        End If
        If box.SelectedItem = "USA Aleutian" Then
            Dim theSecondForm As New Form2(-10, 0)
            theSecondForm.TopLevel = False
            Me.Panel2.Controls.Add(theSecondForm)
            theSecondForm.Show()
            flag = True
        End If
        If box.SelectedItem = "USA Hawaii" Then
            Dim theSecondForm As New Form2(-10, 0)
            theSecondForm.TopLevel = False
            Me.Panel2.Controls.Add(theSecondForm)
            theSecondForm.Show()
            flag = True
        End If
        If box.SelectedItem = "USA Alaska" Then
            Dim theSecondForm As New Form2(-8, 0)
            theSecondForm.TopLevel = False
            Me.Panel2.Controls.Add(theSecondForm)
            theSecondForm.Show()
            flag = True
        End If
        If box.SelectedItem = "USA Mountain" Then
            Dim theSecondForm As New Form2(-7, 0)
            theSecondForm.TopLevel = False
            Me.Panel2.Controls.Add(theSecondForm)
            theSecondForm.Show()
            flag = True
        End If
        If box.SelectedItem = "USA Arizona" Then
            Dim theSecondForm As New Form2(-7, 0)
            theSecondForm.TopLevel = False
            Me.Panel2.Controls.Add(theSecondForm)
            theSecondForm.Show()
            flag = True
        End If
        If box.SelectedItem = "USA Central" Then
            Dim theSecondForm As New Form2(-6, 0)
            theSecondForm.TopLevel = False
            Me.Panel2.Controls.Add(theSecondForm)
            theSecondForm.Show()
            flag = True
        End If
        If box.SelectedItem = "USA Eastern" Then
            Dim theSecondForm As New Form2(-5, 0)
            theSecondForm.TopLevel = False
            Me.Panel2.Controls.Add(theSecondForm)
            theSecondForm.Show()
            flag = True
        End If
        If box.SelectedItem = "USA Indiana East" Then
            Dim theSecondForm As New Form2(-5, 0)
            theSecondForm.TopLevel = False
            Me.Panel2.Controls.Add(theSecondForm)
            theSecondForm.Show()
            flag = True
        End If
        If box.SelectedItem = "Vatican City" Then
            Dim theSecondForm As New Form2(1, 0)
            theSecondForm.TopLevel = False
            Me.Panel2.Controls.Add(theSecondForm)
            theSecondForm.Show()
            flag = True
        End If
        If box.SelectedItem = "Zimbabwe" Then
            Dim theSecondForm As New Form2(2, 0)
            theSecondForm.TopLevel = False
            Me.Panel2.Controls.Add(theSecondForm)
            theSecondForm.Show()
            flag = True
        End If

        'handling invalid option selection
        If flag = False Then
            Label2.Visible = True
        Else
            Label2.Visible = False
        End If
    End Sub

    'loading quiz 
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim instance As New quiz.menu
        instance.Show()
    End Sub

    'handling incorrect submissions in combobox
    Private Sub box_TextChanged(sender As Object, e As EventArgs) Handles box.TextChanged
        Label2.Visible = True
    End Sub
End Class
