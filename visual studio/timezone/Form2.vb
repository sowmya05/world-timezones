Imports System.Drawing.Drawing2D
Public Class Form2
    'define constant for calculating angle
    Const Convert As Double = Math.PI / 180

    'define radius for each hand
    Const SecRadius As Double = 92
    Const MinRadius As Double = 89
    Const HrRadius As Double = 70

    'define variables for setting angle for each hand
    Dim SecAngle As Double
    Dim MinAngle As Double
    Dim HrAngle As Double

    'define inital values for secants
    Dim SecX As Single = 110
    Dim SecY As Single = 10
    Dim MinX As Single = 110
    Dim MinY As Single = 10
    Dim HrX As Single = 110
    Dim HrY As Single = 10


    Dim hrs, min, value As Integer
    Dim TimeString As String
    Dim WithEvents tmrClock As New Timer
    ' Dim lblTB As New Label
    Dim pnlExtras As New Panel
    Dim tTip As New ToolTip
    Dim StartPoint(60) As PointF
    Dim EndPoint(60) As PointF
    Dim NumberPoint() As PointF = {New PointF(143, 25), New PointF(175, 57), New PointF(188, 102),
                                   New PointF(175, 145), New PointF(143, 175), New PointF(103, 183),
                                   New PointF(63, 175), New PointF(30, 145), New PointF(19, 102),
                                   New PointF(28, 60), New PointF(56, 30), New PointF(98, 18)}

    'Create the Pens 
    Dim RedPen As Pen = New Pen(Color.Red, 6)
    Dim BluePen As Pen = New Pen(Color.Blue, 4)
    Dim OrangePen As Pen = New Pen(Color.DarkOrange, 5)
    Dim BlackPen As Pen = New Pen(Color.Black, 6)
    Dim myPen As New Pen(Color.DarkBlue, 8)

    'Create the Fonts 
    Dim NumberFont As New Font("Arial", 12, FontStyle.Bold)
    Dim ClockFont As New Font("Arial", 9, FontStyle.Bold)
    Dim NameFont As New Font("Brush Script MT", 12, FontStyle.Italic)

    'Create the Bitmap to draw the clock face 
    Dim ClockFace As New Bitmap(222, 222)
    Dim gr As Graphics = Graphics.FromImage(ClockFace)
    Private _p1 As Integer
    Private _p2 As Integer

    'function for getting variables from form1
    Sub New(p1 As Integer, p2 As Integer)
        ' TODO: Complete member initialization 
        InitializeComponent()
        _p1 = p1
        _p2 = p2
    End Sub
    Private Sub Form2_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'define different hands of the clock
        BluePen.SetLineCap(LineCap.Round, LineCap.ArrowAnchor, DashCap.Flat)
        OrangePen.SetLineCap(LineCap.Round, LineCap.ArrowAnchor, DashCap.Flat)
        BlackPen.SetLineCap(LineCap.Round, LineCap.ArrowAnchor, DashCap.Flat)

        'draw clock
        DrawClockFace()
        tmrClock.Interval = 990
        tmrClock.Start()

        'to make the window invisible
        Me.ControlBox = False
        Me.Text = ""
        
    End Sub



    Sub DrawClockFace()

        'Draw Clock Background 
        gr.FillEllipse(Brushes.Beige, 10, 10, 200, 200)
        gr.DrawEllipse(RedPen, 10, 10, 200, 200)

        'Draw Numbers 
        For I As Integer = 1 To 12
            gr.DrawString(I.ToString, NumberFont, Brushes.Black, NumberPoint(I - 1))
        Next

        'Draw Name 
        gr.DrawString("World Time", NameFont, Brushes.Black, 90, 43)

        'Draw Digital Clock Background 
        gr.FillRectangle(Brushes.DarkBlue, 85, 130, 50, 15)
        myPen.LineJoin = LineJoin.Round
        gr.DrawRectangle(myPen, 85, 130, 50, 15)

    End Sub

    Protected Overrides Sub OnPaint(ByVal e As System.Windows.Forms.PaintEventArgs)
        e.Graphics.SmoothingMode = SmoothingMode.HighQuality

        'Draw Clock Background 
        e.Graphics.DrawImage(ClockFace, Point.Empty)

        'Draw Digital Time 
        e.Graphics.DrawString(TimeString, ClockFont, Brushes.White, 85, 130)

        'Draw Hands 
        e.Graphics.DrawLine(BlackPen, 110, 110, HrX, HrY)
        e.Graphics.FillEllipse(Brushes.Black, 105, 105, 10, 10)
        e.Graphics.DrawLine(OrangePen, 110, 110, MinX, MinY)
        e.Graphics.FillEllipse(Brushes.DarkOrange, 106, 106, 8, 8)
        e.Graphics.DrawLine(BluePen, 110, 110, SecX, SecY)
        e.Graphics.FillEllipse(Brushes.Blue, 108, 108, 5, 5)

    End Sub
    Private Sub tmrClock_Tick(sender As System.Object, e As System.EventArgs) Handles tmrClock.Tick
        Dim hour As Integer
        Dim min As Integer
        Dim sec As Integer

        'calculation of time at selected location using time difference from GMT
        If _p1 < 0 Then
            hour = Now.Hour + _p1 - 5
            min = Now.Minute - _p2 - 30
            sec = Now.Second
        Else
            hour = Now.Hour + _p1 - 5
            min = Now.Minute + _p2 - 30
            sec = Now.Second
        End If

        'handling cases where min and hour goes out of bounds
        If min < 0 Then
            min = 60 + min
            hour = hour - 1
        End If
        If min >= 60 Then
            min = min - 60
            hour = hour + 1
        End If
        If hour < 0 Then
            hour = 24 + hour
        End If
        If hour >= 24 Then
            hour = hour - 24
        End If

        'storing time in a variable
        TimeString = hour.ToString + ":" + min.ToString + ":" + sec.ToString

        'Set The Angle of the Second, Minute and Hour hand according to the time 
        SecAngle = (Now.Second * 6)
        If _p1 < 0 Then
            MinAngle = ((Now.Minute + Now.Second / 60) - _p2 - 30) * 6
            HrAngle = ((Now.Hour + (Now.Minute - _p2 - 30) / 60) + _p1 - 5) * 30
        Else
            MinAngle = ((Now.Minute + Now.Second / 60) + _p2 - 30) * 6
            HrAngle = ((Now.Hour + (Now.Minute + _p2 - 30) / 60) + _p1 - 5) * 30
        End If


        'Get the X,Y co-ordinates of the end point of each hand 
        SecX = CInt(SecRadius * Math.Cos((90 - SecAngle) * Convert)) + 110
        SecY = 110 - CInt(SecRadius * Math.Sin((90 - SecAngle) * Convert))
        MinX = CInt(MinRadius * Math.Cos((90 - MinAngle) * Convert)) + 110
        MinY = 110 - CInt(MinRadius * Math.Sin((90 - MinAngle) * Convert))
        HrX = CInt(HrRadius * Math.Cos((90 - HrAngle) * Convert)) + 110
        HrY = 110 - CInt(HrRadius * Math.Sin((90 - HrAngle) * Convert))
        Refresh()

    End Sub

End Class
