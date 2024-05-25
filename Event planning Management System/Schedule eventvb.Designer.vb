<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Schedule_eventvb
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Schedule_eventvb))
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtname = New System.Windows.Forms.TextBox()
        Me.txtst = New System.Windows.Forms.ComboBox()
        Me.txtet = New System.Windows.Forms.ComboBox()
        Me.txtetime = New System.Windows.Forms.TextBox()
        Me.txtvenue = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtsd = New System.Windows.Forms.TextBox()
        Me.txted = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label13
        '
        Me.Label13.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Mongolian Baiti", 10.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(461, 126)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(62, 21)
        Me.Label13.TabIndex = 1
        Me.Label13.Text = "Name"
        '
        'txtname
        '
        Me.txtname.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtname.Location = New System.Drawing.Point(648, 115)
        Me.txtname.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtname.Name = "txtname"
        Me.txtname.Size = New System.Drawing.Size(148, 26)
        Me.txtname.TabIndex = 2
        '
        'txtst
        '
        Me.txtst.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtst.FormattingEnabled = True
        Me.txtst.Items.AddRange(New Object() {"Photoshoot", "Chairs", "Tent", "Catering", "Helpers", ""})
        Me.txtst.Location = New System.Drawing.Point(651, 249)
        Me.txtst.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtst.Name = "txtst"
        Me.txtst.Size = New System.Drawing.Size(180, 28)
        Me.txtst.TabIndex = 23
        '
        'txtet
        '
        Me.txtet.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtet.FormattingEnabled = True
        Me.txtet.Items.AddRange(New Object() {"Birthday", "Wedding", "Naming Cermony"})
        Me.txtet.Location = New System.Drawing.Point(651, 192)
        Me.txtet.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtet.Name = "txtet"
        Me.txtet.Size = New System.Drawing.Size(180, 28)
        Me.txtet.TabIndex = 22
        '
        'txtetime
        '
        Me.txtetime.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtetime.Location = New System.Drawing.Point(648, 451)
        Me.txtetime.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtetime.Name = "txtetime"
        Me.txtetime.Size = New System.Drawing.Size(148, 26)
        Me.txtetime.TabIndex = 21
        '
        'txtvenue
        '
        Me.txtvenue.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtvenue.Location = New System.Drawing.Point(648, 400)
        Me.txtvenue.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtvenue.Name = "txtvenue"
        Me.txtvenue.Size = New System.Drawing.Size(577, 26)
        Me.txtvenue.TabIndex = 12
        '
        'Label10
        '
        Me.Label10.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Mongolian Baiti", 10.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(453, 400)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(67, 21)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = "Venue"
        '
        'Label11
        '
        Me.Label11.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Mongolian Baiti", 10.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(453, 300)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(102, 21)
        Me.Label11.TabIndex = 10
        Me.Label11.Text = "Start Date"
        '
        'Label12
        '
        Me.Label12.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Mongolian Baiti", 10.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(459, 197)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(113, 21)
        Me.Label12.TabIndex = 11
        Me.Label12.Text = "Event Type"
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Mongolian Baiti", 10.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(453, 451)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(115, 21)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Event Time"
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Mongolian Baiti", 10.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(453, 351)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(93, 21)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "End Date"
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Mongolian Baiti", 10.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(453, 249)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(129, 21)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Service Type"
        '
        'Button1
        '
        Me.Button1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Button1.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(513, 760)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(112, 35)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Save"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Button2.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(746, 760)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(112, 35)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Cancel"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Mongolian Baiti", 11.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(644, 29)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(215, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "SCHEDULE EVENT"
        '
        'txtsd
        '
        Me.txtsd.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtsd.Location = New System.Drawing.Point(651, 300)
        Me.txtsd.Name = "txtsd"
        Me.txtsd.Size = New System.Drawing.Size(180, 26)
        Me.txtsd.TabIndex = 24
        '
        'txted
        '
        Me.txted.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txted.Location = New System.Drawing.Point(651, 351)
        Me.txted.Name = "txted"
        Me.txted.Size = New System.Drawing.Size(180, 26)
        Me.txted.TabIndex = 25
        '
        'Schedule_eventvb
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1580, 814)
        Me.Controls.Add(Me.txted)
        Me.Controls.Add(Me.txtsd)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.txtst)
        Me.Controls.Add(Me.txtname)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.txtet)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtetime)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtvenue)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label11)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Schedule_eventvb"
        Me.Text = "Schedule_eventvb"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtvenue As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtname As System.Windows.Forms.TextBox
    Friend WithEvents txtetime As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents txtst As System.Windows.Forms.ComboBox
    Friend WithEvents txtet As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtsd As System.Windows.Forms.TextBox
    Friend WithEvents txted As System.Windows.Forms.TextBox
End Class
