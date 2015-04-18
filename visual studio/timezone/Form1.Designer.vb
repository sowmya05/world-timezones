<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.box = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Moccasin
        Me.Button1.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(286, 616)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(151, 33)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Local Time"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.NavajoWhite
        Me.Button2.Font = New System.Drawing.Font("Lucida Bright", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(514, 614)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(151, 33)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "GMT"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button3.BackgroundImage = Global.timezone.My.Resources.Resources.help_browser_hi
        Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button3.Location = New System.Drawing.Point(1131, 692)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(26, 29)
        Me.Button3.TabIndex = 3
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = Global.timezone.My.Resources.Resources.Standard_World_Times_Zones_Map
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Panel1.Location = New System.Drawing.Point(16, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(891, 545)
        Me.Panel1.TabIndex = 0
        '
        'box
        '
        Me.box.AllowDrop = True
        Me.box.BackColor = System.Drawing.Color.NavajoWhite
        Me.box.DropDownHeight = 80
        Me.box.FormattingEnabled = True
        Me.box.IntegralHeight = False
        Me.box.Items.AddRange(New Object() {"American Samoa", "Andorra", "Angola", "Anguilla", "Antarctica", "Antigua", "Argentina", "Argentina western prov", "Armenia", "Aruba", "Ascension", "Australia Western", "Australia South", "Australia Northern Territory", "Australia New South Wales", "Australia Queensland", "Australia Victoria", "Australian Capital Territory", "Australia Tasmania", "Australia Lord Howe Island", "Austria", "Azerbaijan", "Azores", "Bahamas", "Bahrain", "Balearic Islands", "Bangladesh", "Barbados", "Belarus", "Belgium", "Belize", "Benin", "Bermuda", "Bhutan", "Bolivia", "Bonaire", "Bosnia Hercegovina", "Botswana", "Brazil West", "Brazil Acre", "Brazil East", "Brazil Atlantic Islands", "British Virgin Islands", "Brunei", "Bulgaria", "Burkina Faso", "Burundi          ", "Cambodia", "Cameroon", "Canada Yukon & Pacific", "Canada Mountain", "Canada Central", "Canada Eastern", "Canada Atlantic", "Canada Newfoundland", "Canary Islands", "Canton Enderbury Islands", "Cape Verde", "Caroline Island", "Chad", "Chile", "Colombia", "Congo", "Costa Rica", "Cuba", "Czech Republic      ", "Denmark", "Egypt", "England", "Equatorial Guinea", "Estonia", "Ethiopia      ", "Fiji", "Finland", "France", "Georgia", "Germany", "Ghana", "Greece", "Greenland", "Guinea", "Hong Kong", "Hungary         ", "Iceland", "India", "Indonesia", "Iran", "Iraq", "Ireland", "Israel", "Italy         ", "Japan", "Jordan        ", "Kazakhstan", "Kenya", "Korea", "Kuwait", "Liberia", "Libya", "Madagascar", "Malaysia", "Maldives", "Mauritius", "Mexico", "Mongolia", "Morocco", "Myanmar", "Nepal", "Netherlands", "New Zealand", "Nigeria", "Norway     ", "Oman        ", "Pakistan", "Peru", "Philippines", "Poland", "Saudi Arabia", "Scotland", "Singapore", "Somalia", "South Africa", "Spain", "Sri Lanka", "Sudan", "Sweden", "Switzerland", "Syria", "Taiwan", "Tajikistan", "Tanzania", "Thailand", "Turkey", "Uganda", "Ukraine", "United Kingdom", "USA Aleutian", "USA Hawaii", "USA Alaska", "USA Pacific", "USA Mountain", "USA Arizona", "USA Central", "USA Eastern", "USA Indiana East", "Vatican City", "Zimbabwe"})
        Me.box.Location = New System.Drawing.Point(721, 616)
        Me.box.Name = "box"
        Me.box.Size = New System.Drawing.Size(154, 21)
        Me.box.TabIndex = 4
        Me.box.Tag = ""
        Me.box.Text = "Choose Country"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(717, 580)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(146, 24)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Choose Country"
        '
        'Panel2
        '
        Me.Panel2.Location = New System.Drawing.Point(913, 67)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(244, 246)
        Me.Panel2.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(718, 650)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(165, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Please choose a country from list!"
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(64, 614)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(188, 39)
        Me.Button4.TabIndex = 9
        Me.Button4.Text = "Play Quiz"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSeaGreen
        Me.ClientSize = New System.Drawing.Size(1354, 733)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.box)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Panel1)
        Me.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "World Time Zones"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents box As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Button4 As System.Windows.Forms.Button

End Class
